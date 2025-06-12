using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace UI
{
    public partial class CashRegister : Form
    {
        static readonly IBl s_bl = Factory.Get;

        List<BO.Product> products = new List<BO.Product>();
        DataGridView productTbl;
        BO.Order order;
        List<BO.ProductInOrder> productInOrder = new List<BO.ProductInOrder>();
        ProductInOrder currentProduct;
        public CashRegister(BO.Order order, BO.Customer customer)
        {
            InitializeComponent();
            this.order = order;
            productInOrder = order.ProductsInOrder;

            productInOrderLv.View = View.Details;
            productInOrderLv.Columns.Add("Product ID", 100);
            productInOrderLv.Columns.Add("Product Name", 150);
            productInOrderLv.Columns.Add("Price", 100);
            productInOrderLv.Columns.Add("Quantity", 100);

            products = s_bl.Product.ReadAll();
            productTbl = this.dataGridView1;

            foreach (BO.Product product in products)
            {
                productTbl.Rows.Add(product.ProductName, product.Price, product.Category, product.ProductCode);
            }

            foreach (BO.ProductInOrder p in productInOrder)

            {
                ListViewItem item = new ListViewItem(p.ProductName.ToString(), int.Parse(p.Price.ToString()));
                //,p.CountInOrder
                productInOrderLv.Items.Add(item);
            }
            productInOrderLv.View = View.List;

            searchTb.TextChanged += new EventHandler(search_TextChanged);
            productTbl.CellDoubleClick += (s, e) => addProductToOrder(s, e);
            productInOrderLv.DoubleClick += (s, e) => changeCurrentProduct(s, e);
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            products = s_bl.Product.ReadAll(p => p.ProductName.Contains(searchTb.Text));
            productTbl.Rows.Clear();
            foreach (BO.Product product in products)
            {
                productTbl.Rows.Add(product.ProductName, product.Price, product.Category, product.ProductCode);
            }
        }
        private void showProductsInOrder()
        {
            productInOrderLv.Items.Clear();
            foreach (BO.ProductInOrder p in productInOrder)
            {
                ListViewItem item = new ListViewItem(p.ProductId.ToString());
                item.SubItems.Add(p.ProductName);
                item.SubItems.Add(p.Price.ToString());
                item.SubItems.Add(p.Quantity.ToString());
                productInOrderLv.Items.Add(item);
            }
        }
        private void changeCurrentProduct(object sender, EventArgs e)
        {
            //currentProduct =e. ;

            // DataGridViewRow selectedRow = productTbl.Rows[e.RowIndex];
            //String val= e.;
        }
        private void addProductToOrder(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)productTbl.Rows[e.RowIndex].Cells[3].Value;
            s_bl.Order.AddProductToOrder(order, id, 1);
            productInOrder = order.ProductsInOrder;

            if (productInOrderLv.View != View.Details)
            {
                productInOrderLv.View = View.Details;
            }

            showProductsInOrder();
            changeTotalPrice();
        }
        private void changeTotalPrice()
        {
            totalPrice.Text = order.TotalPrice.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //BO.ProductInOrder newProductInOrder = new BO.ProductInOrder(
            //    (int)productTbl.Rows[e.RowIndex].Cells[3].Value,
            //    productTbl.Rows[e.RowIndex].Cells[0].Value.ToString(),
            //    (int)productTbl.Rows[e.RowIndex].Cells[1].Value, 0);

        }

        private void CashRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // acount.Visible = true;
            //להוסיף קוד של חשבונית ופרוט המוצרים וההזמנות
            if (order.Preference == BO.CustomerPreference.MANEGER)
            {
                order.TotalPrice = order.TotalPrice * 90/100;
                MessageBox.Show($" אתה זכאי להנחת מנהל 10% \n יום טוב והרבה הצלחות \n {order.TotalPrice} המכיר הסופי לתשלום ", " הנחה בתשלום", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (order.Preference == BO.CustomerPreference.WORKER)
            {
                order.TotalPrice = order.TotalPrice * 95 / 100;
                MessageBox.Show($" אתה זכאי להנחת עובד 5% \n יום טוב והרבה הצלחות \n {order.TotalPrice} המכיר הסופי לתשלום ", " הנחה בתשלום", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            acountDetailPnl.Visible = true;
            foreach (var product in order.ProductsInOrder)
            {
                productsAcount.Items.Add(product.ToString());
            }
            s_bl.Order.DoOrder(order);

            this.Close();
        }

        private void customerDetails_Enter(object sender, EventArgs e)
        {

        }

        private void customerDetailsBtn_Click(object sender, EventArgs e)

        {
            //GroupBox groupBox = customerDetails;
            //if (groupBox.Visible)
            //{
            //    groupBox.Visible = false;
            //}
            //groupBox.Visible = true;
        }

        private void productInOrderLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productInOrderLv.SelectedItems.Count > 0)
            {
                var r = productInOrderLv.SelectedItems[0].SubItems[3].Text;
                count.Value = int.Parse(r);
            }
            else
            {
            }
        }


        private void count_ValueChanged(object sender, EventArgs e)
        {
            if (productInOrderLv.SelectedItems.Count == 0)
            {
                MessageBox.Show("!בחר מוצר");
                count.Value = 1;
            }
            else
            {
                int num = (int)count.Value;
                int id = int.Parse(productInOrderLv.SelectedItems[0].Text);
                productInOrderLv.SelectedItems[0].SubItems[3].Text = num.ToString();

                s_bl.Order.AddProductToOrder(order, id, num);
                Console.WriteLine(order);
                changeTotalPrice();
            }
        }

        private void productInOrderLv_Click(object sender, EventArgs e)
        {

        }


        private void deletProductFromOrderBtn_Click(object sender, EventArgs e)
        {
            if (productInOrderLv.SelectedItems.Count == 0)
            {
                MessageBox.Show("!בחר מוצר");
                count.Value = 1;
            }
            int id = int.Parse(productInOrderLv.SelectedItems[0].Text);
            s_bl.Order.DeleteProductFromOrder(order, id);
            showProductsInOrder();
            changeTotalPrice();
        }




    }
}
