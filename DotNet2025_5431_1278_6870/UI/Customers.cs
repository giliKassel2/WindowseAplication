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

            findCustomerTxt.Text = PlaceholderText;
            findCustomerTxt.ForeColor = Color.Gray;

            addRowsToCustomerDgv(customers);

            addTypeCb.DataSource = Enum.GetNames(typeof(CustomerPreference));

            idToUpdateCb.DataSource = customers;
            idToUpdateCb.DisplayMember = "Name";
            idToUpdateCb.ValueMember = "Id";

            idToDeleteCb.DataSource = customers;
            idToDeleteCb.DisplayMember = "Name";
            idToDeleteCb.ValueMember = "Id";
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

                addRowsToCustomerDgv(s_bl.Customer.ReadAll());
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
                idToUpdateCb.DataSource = customers;
                idToDeleteCb.DataSource = customers;
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
                Customer? selectedCustomer = (Customer)idToUpdateCb.SelectedItem!;
                Customer? c = new(int.Parse(idTxtB.Text), nameTxtB.Text, addAddressTxt.Text, phoneTxtB.Text);
                s_bl!.Customer.Update(c);
                customers = s_bl.Customer.ReadAll()!;
                idToUpdateCb.DataSource = customers;
                idToUpdateCb.DataSource = customers;
                addRowsToCustomerDgv(s_bl.Customer.ReadAll());
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
                Customer? customer = (Customer)idToUpdateCb.SelectedItem!;
                s_bl!.Customer.Delete(customer.Id);
                customers = s_bl.Customer.ReadAll();
                idToUpdateCb.DataSource = customers;
                idToDeleteCb.DataSource = customers;
                addRowsToCustomerDgv(s_bl.Customer.ReadAll());
                MessageBox.Show("Customer deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idToUpdateCb_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (idToUpdateCb.SelectedItem is Customer customer)
            {
                idTxtB.Text = customer.Id.ToString();
                nameTxtB.Text = customer.Name;
                addressTxtB.Text = customer.Adress;
                phoneTxtB.Text = customer.PhoneNumber;
            }
            else
            {
                idTxtB.Clear();
                nameTxtB.Clear();
                addressTxtB.Clear();
                phoneTxtB.Clear();
            }
        }

        private void customerDgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void findCustomerTxt_TextChanged(object sender, EventArgs e)
        {
            customers = s_bl.Customer.ReadAll(p => p.Name.Contains(findCustomerTxt.Text));
            customerDgv.Rows.Clear();
            addRowsToCustomerDgv(customers);
        }

        private void addRowsToCustomerDgv(List<BO.Customer> customers)
        {
            customerDgv.Rows.Clear();
            foreach (BO.Customer customer in customers)
            {
                customerDgv.Rows.Add(customer!.Id, customer.Name, customer.Adress, customer.PhoneNumber);
            }
        }

    }
}
