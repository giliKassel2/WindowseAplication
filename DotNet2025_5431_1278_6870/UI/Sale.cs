using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Sale : Form
    {
        public static IBl s_bl = Factory.Get;
        public static List<BO.Sale> sales;
        public const string PlaceholderText = "הכנס שם מוצר למבצע";

        public Sale()
        {
            InitializeComponent();


            findSaleTxt.Text = PlaceholderText;
            findSaleTxt.ForeColor = Color.Gray;
            initialSalesList();
            initialSalesList();
            updateLists(sales);

            salesDgv.CellClick += (s, e) => changeCurrentSale(s, e);


        }
        private void changeCurrentSale(object sender, DataGridViewCellEventArgs e)
        {
            saleCodeTb.Text = salesDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            productIdTxt.Text = salesDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            amountSaleNUD.Text = salesDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            priceNumTb.Text = salesDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            startDate.Text = salesDgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            startDate.Text = salesDgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            currentSale.Text = salesDgv.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
        private void clear()
        {
            saleCodeTb.Clear();
            productIdTxt.Clear();
            amountSaleNUD.Text = "1";
            priceNumTb.Clear();
            startDate = null;
            startDate = null;
            currentSale.Clear();
        }
        private void findSaleTxt_Enter(object sender, EventArgs e)
        {
            if (findSaleTxt.Text == PlaceholderText)
            {
                findSaleTxt.Text = "";
                findSaleTxt.ForeColor = Color.Black;
            }
        }

        private void findSaleTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(findSaleTxt.Text))
            {
                findSaleTxt.Text = PlaceholderText;
                findSaleTxt.ForeColor = Color.Gray; // Reset color to gray
                initialSalesList();
                updateLists(sales);
            }
        }

        private void findSaleTxt_TextChanged(object sender, EventArgs e)
        {
            List<BO.Product> products = s_bl.Product.ReadAll().Where(p => p.ProductName.Contains(findSaleTxt.Text)).ToList();
            sales = s_bl.sale.ReadAll(p => products.FirstOrDefault(pr => pr.ProductCode == p.ProductId) != null);
            updateLists(sales);
        }

        private void updateLists(List<BO.Sale> salesL)
        {
            salesDgv.Rows.Clear();
            foreach (BO.Sale sale in salesL)
            {
                salesDgv.Rows.Add(sale.SaleCode, s_bl.Product.Read(sale.ProductId).ProductName, sale.ProductId, sale.QuantityForSale, sale.SalePrice, sale.StartSale, sale.EndSale, sale.IsClub);
            }
        }

        private void initialSalesList()
        {
            sales = s_bl.sale.ReadAll();
        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(addProductIdTxt.Text))
            {
                errorProvider1.SetError(addProductIdTxt, "יש להזין מזהה מוצר");
                isValid = false;
            }

            if (addAmountSaleNUD.Value <= 0)
            {
                errorProvider1.SetError(addAmountSaleNUD, "כמות חייבת להיות גדולה מ-0");
                isValid = false;
            }

            if (int.Parse(priceNumTb.Text) < 0)
            {
                errorProvider1.SetError(priceNumTb, "מחיר לא יכול להיות שלילי");
                isValid = false;
            }

            if (startSaleDTP.Value >= endSaleDTP.Value)
            {
                errorProvider1.SetError(endSaleDTP, "תאריך סיום חייב להיות לאחר תאריך התחלה");
                isValid = false;
            }

            if (isValid)
            {
                try
                {
                    BO.Sale sale = new BO.Sale(0, int.Parse(addProductIdTxt.Text), (int)addAmountSaleNUD.Value, int.Parse(priceNumTb.Text), isClubCB.Checked, startSaleDTP.Value, endSaleDTP.Value);
                    s_bl.sale.Create(sale);
                    initialSalesList();
                    updateLists(sales);
                    MessageBox.Show("המבצע נוסף בהצלחה!");

                    addProductIdTxt.Text = string.Empty;
                    addAmountSaleNUD.Value = 1;
                    priceNumTb.Text = "0";
                    isClubCB.Checked = false;
                    startSaleDTP.Value = DateTime.Now;
                    endSaleDTP.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (saleCodeTb.Text == null)
            {
                errorProvider1.SetError(saleCodeTb, "יש לבחור מבצע לעדכון");
                isValid = false;
            }
            if (isValid)
            {
                try
                {
                    BO.Sale sale = new BO.Sale(int.Parse(saleCodeTb.Text), int.Parse(productIdTxt.Text),
                        (int)amountSaleNUD.Value, double.Parse(priceNumTb.Text), clubCB.Checked,
                        startSaleDTP.Value, endSaleDTP.Value);
                    s_bl.sale.Update(sale);
                    List<BO.Sale> salesL = s_bl.sale.ReadAll();
                    initialSalesList();
                    updateLists(salesL);
                    clear();
                    MessageBox.Show("המבצע עודכן בהצלחה!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void deleteSaleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                s_bl!.sale.Delete(int.Parse(currentSale.Text));
                sales = s_bl.sale.ReadAll();
                updateLists(sales);
                clear();
                MessageBox.Show("Sale deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {

        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {

        }

        private void salesDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clubCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void priceNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void amountSaleNUD_ValueChanged(object sender, EventArgs e)
        {
        }

        private void productIdTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
