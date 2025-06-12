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

namespace UI
{
    public partial class Customers : Form
    {
        static readonly IBl s_bl = Factory.Get;
        public const string PlaceholderText = "חיפוש לקוח";

        List<Customer> customers = new List<Customer>();


        public Customers()
        {
            InitializeComponent();

            customers = s_bl.Customer.ReadAll();
            foreach (BO.Customer customer in customers)
            {
                customerDgv.Rows.Add(customer!.Id, customer.Name, customer.Adress, customer.PhoneNumber);
            }

            findCustomerTxt.Text = PlaceholderText;
            findCustomerTxt.ForeColor = Color.Gray;

            addTypeCb.DataSource = Enum.GetNames(typeof(CustomerPreference));

            customerDgv.CellClick += (s, e) => changeCurrentCustoner(s, e);
        }
        


        private void cleanTxb()
        {
            idTxtB.Clear();
            nameTxtB.Clear();
            addressTxtB.Clear();
            phoneTxtB.Clear();
        }
        private void addRowsToCustomerDgv(List<BO.Customer> customers)
        {
            
            customerDgv.Rows.Clear();
            foreach (BO.Customer customer in customers)
            {
                customerDgv.Rows.Add(customer!.Id, customer.Name, customer.Adress, customer.PhoneNumber);
            }
        }

        private void findCustomerTxt_Enter(object sender, EventArgs e)
        {
            if (findCustomerTxt.Text == PlaceholderText)
            {
                findCustomerTxt.Text = "";
                findCustomerTxt.ForeColor = Color.Black;
            }
        }

        private void findCustomerTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(findCustomerTxt.Text))
            {
                findCustomerTxt.Text = PlaceholderText;
                findCustomerTxt.ForeColor = Color.Gray; // Reset color to gray

            }
        }

        private void customerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer(int.Parse(addIdTxt.Text), addNameTxt.Text, addAddressTxt.Text, addPhoneTxt.Text);

                s_bl.Customer.Create(c);
                customers = s_bl.Customer.ReadAll()!;

                MessageBox.Show("הלקוח נוסף בהצלחה!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer? selectedCustomer = s_bl.Customer.Read(c => c.Id == int.Parse(idTxtB.Text))!;
                Customer? c = new(int.Parse(idTxtB.Text), nameTxtB.Text, addAddressTxt.Text, phoneTxtB.Text);
                s_bl!.Customer.Update(c);
                customers = s_bl.Customer.ReadAll()!;
                cleanTxb();
                currentConsumer.Clear();
                addRowsToCustomerDgv(customers);
                MessageBox.Show("הלקוח עודכן בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer? customer = s_bl.Customer.Read(c => c.Name == currentConsumer.Text)!;
                s_bl!.Customer.Delete(customer.Id);
                customers = s_bl.Customer.ReadAll();
                currentConsumer.Clear();
                cleanTxb();
                addRowsToCustomerDgv(customers);
                MessageBox.Show("Customer deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idToUpdateCb_SelectedValueChanged_1(object sender, EventArgs e)
        {
            //if (idToUpdateCb.SelectedItem is Customer customer)
            //{
            //    idTxtB.Text = customer.Id.ToString();
            //    nameTxtB.Text = customer.Name;
            //    addressTxtB.Text = customer.Adress;
            //    phoneTxtB.Text = customer.PhoneNumber;
            //}
            //else
            //{
            //    idTxtB.Clear();
            //    nameTxtB.Clear();
            //    addressTxtB.Clear();
            //    phoneTxtB.Clear();
            //}
        }

        private void customerDgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void changeCurrentCustoner(object sender, DataGridViewCellEventArgs e)
        {

            idTxtB.Text = customerDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameTxtB.Text = customerDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            addressTxtB.Text = customerDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            phoneTxtB.Text = customerDgv.Rows[e.RowIndex].Cells[3].Value.ToString();

            currentConsumer.Text = customerDgv.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void findCustomerTxt_TextChanged(object sender, EventArgs e)
        {
            customers = s_bl.Customer.ReadAll(p => p.Name.Contains(findCustomerTxt.Text));
            customerDgv.Rows.Clear();
            addRowsToCustomerDgv(customers);
        }



        private void nameTxtB_TextChanged(object sender, EventArgs e)
        {

        }



        //private void customerDgv_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        //{

        //    idTxtB.Text = customerDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    nameTxtB.Text = customerDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    addressTxtB.Text = customerDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    phoneTxtB.Text = customerDgv.Rows[e.RowIndex].Cells[3].Value.ToString();

        //    currentConsumer.Text = customerDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
        //}
    }
}
