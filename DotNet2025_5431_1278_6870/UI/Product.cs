using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Product : Form
    {
        public static IBl s_bl = Factory.Get;
        public static List<BO.Product> products;
        public const string PlaceholderText = "הכנס שם מוצר";

        public Product()
        {
            InitializeComponent();

            findProductTxt.Text = PlaceholderText;
            findProductTxt.ForeColor = Color.Gray;
            initialProductsList();
            updateLists();
            updateCategoryCmb.DataSource = Enum.GetValues(typeof(BO.Categories));
            addCategoryComb.DataSource = Enum.GetValues(typeof(BO.Categories));
            saerchCategoryCb.Items.Add("All");
            foreach (var category in Enum.GetValues(typeof(BO.Categories)))
            {
                saerchCategoryCb.Items.Add(category);
            }
            saerchCategoryCb.SelectedIndex = 0;
            productDgv.CellClick += (s, e) => changeCurrentSale(s, e);
        }
        private void clear()
        {
            productCodeTxb.Clear();
            updateNameTxt.Clear();
            quantityNUD.Value = 0;
            productPriceTxb.Clear();
            updateCategoryCmb.Text = string.Empty;
            deleteCodeTxb.Text = string.Empty;
        }
        private void changeCurrentSale(object sender, DataGridViewCellEventArgs e)
        {
            productCodeTxb.Text = productDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateNameTxt.Text = productDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantityNUD.Value = int.Parse(productDgv.Rows[e.RowIndex].Cells[2].Value.ToString());
            productPriceTxb.Text = productDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            updateCategoryCmb.Text = productDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            deleteCodeTxb.Text = productDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void findProductTxt_Enter(object sender, EventArgs e)
        {
            if (findProductTxt.Text == PlaceholderText)
            {
                findProductTxt.Text = "";
                findProductTxt.ForeColor = Color.Black;
            }
        }

        private void findProductTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(findProductTxt.Text))
            {
                findProductTxt.Text = PlaceholderText;
                findProductTxt.ForeColor = Color.Gray;
                initialProductsList();
                updateLists();
            }
        }

        private void updateLists()
        {
            productDgv.Rows.Clear();
            foreach (BO.Product product in products)
            {
                productDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
            }
        }

        private void initialProductsList()
        {
            products = s_bl.Product.ReadAll();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderProduct form = new OrderProduct();
            form.Show();
            this.Close();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product product = new BO.Product(0, addNameTxt.Text, double.Parse(addPriceNUP.Text), (int)addAmountN.Value, (BO.Categories)addCategoryComb.SelectedItem);
                string productName = product.ProductName;

                s_bl.Product.Create(product);
                initialProductsList();
                updateLists();
                MessageBox.Show($"המוצר '{productName}' נוסף בהצלחה");

                addNameTxt.Text = string.Empty;
                addPriceNUP.Text = "";
                addAmountN.Value = 0;
                addCategoryComb.DataSource = Enum.GetValues(typeof(BO.Categories));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findProductTxt_TextChanged(object sender, EventArgs e)
        {

            products = s_bl.Product.ReadAll(p => p.ProductName.Contains(findProductTxt.Text));
            if (saerchCategoryCb.Text != "All")
            {
                products = products.Where(p => p.Category == (Categories)Enum.Parse(typeof(Categories), saerchCategoryCb.Text)).ToList();
            }

            productDgv.Rows.Clear();
            foreach (BO.Product product in products)
            {
                productDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product selectedProduct = s_bl.Product.Read(p => p.ProductCode == int.Parse(productCodeTxb.Text));
                string productName = selectedProduct.ProductName;
                // int ProductCode,string ProductName,double Price,int? Quantity, Categories? Category)
                BO.Product product = new BO.Product(selectedProduct.ProductCode, updateNameTxt.Text.ToString(),
                    double.Parse(productPriceTxb.Text.ToString()), (int)quantityNUD.Value, (BO.Categories)updateCategoryCmb.SelectedItem);
                s_bl.Product.Update(product);
                initialProductsList();
                updateLists();
                clear();
                MessageBox.Show($"המוצר '{productName}' עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product? product = s_bl.Product.Read(p => p.ProductCode == int.Parse(productCodeTxb.Text));
                string productName = product.ProductName;
                s_bl!.Product.Delete(product.ProductCode);
                products = s_bl.Product.ReadAll()!;
                updateLists();
                clear();
                MessageBox.Show($"המוצר '{productName}' נמחק בהצלחה");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saerchCategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saerchCategoryCb.SelectedIndex == 0)
            {
                initialProductsList();
                updateLists();
            }
            else
            {
                products = s_bl.Product.ReadAll(p => p.Category == (Categories)Enum.Parse(typeof(Categories), saerchCategoryCb.Text))!;
                productDgv.Rows.Clear();
                foreach (BO.Product product in products)
                    productDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
            }
        }
    }
}
