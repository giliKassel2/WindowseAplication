namespace UI
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            productsTitle = new Label();
            customerDgv = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            tabCustomers = new TabControl();
            addCustomer = new TabPage();
            addTypeCb = new ComboBox();
            addCustomerBtn = new Button();
            addPhoneTxt = new TextBox();
            addIdTxt = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            addAddressTxt = new TextBox();
            addNameTxt = new TextBox();
            label4 = new Label();
            updateCustomer = new TabPage();
            updateBtn = new Button();
            phoneTxtB = new TextBox();
            label8 = new Label();
            addressTxtB = new TextBox();
            label9 = new Label();
            nameTxtB = new TextBox();
            label7 = new Label();
            label10 = new Label();
            idTxtB = new TextBox();
            label11 = new Label();
            delete = new TabPage();
            currentConsumer = new TextBox();
            deleteCustomerBtn = new Button();
            label1 = new Label();
            findCustomerTxt = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)customerDgv).BeginInit();
            tabCustomers.SuspendLayout();
            addCustomer.SuspendLayout();
            updateCustomer.SuspendLayout();
            delete.SuspendLayout();
            SuspendLayout();
            // 
            // productsTitle
            // 
            productsTitle.AutoSize = true;
            productsTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            productsTitle.ForeColor = Color.SkyBlue;
            productsTitle.Location = new Point(512, 12);
            productsTitle.Name = "productsTitle";
            productsTitle.Size = new Size(235, 81);
            productsTitle.TabIndex = 0;
            productsTitle.Text = "לקוחות";
            // 
            // customerDgv
            // 
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            customerDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            customerDgv.BackgroundColor = SystemColors.Control;
            customerDgv.BorderStyle = BorderStyle.None;
            customerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDgv.Columns.AddRange(new DataGridViewColumn[] { id, name, address, phone });
            customerDgv.GridColor = SystemColors.Control;
            customerDgv.Location = new Point(786, 185);
            customerDgv.Margin = new Padding(3, 4, 3, 4);
            customerDgv.Name = "customerDgv";
            customerDgv.RightToLeft = RightToLeft.Yes;
            customerDgv.RowHeadersWidth = 51;
            customerDgv.Size = new Size(394, 587);
            customerDgv.TabIndex = 1;
            customerDgv.CellContentClick += customerDgv_CellContentClick_1;
            // 
            // id
            // 
            id.HeaderText = "ת\"ז";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 35;
            // 
            // name
            // 
            name.HeaderText = "שם";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // address
            // 
            address.HeaderText = "כתובת";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.Width = 110;
            // 
            // phone
            // 
            phone.HeaderText = "טלפון";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 125;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(addCustomer);
            tabCustomers.Controls.Add(updateCustomer);
            tabCustomers.Controls.Add(delete);
            tabCustomers.Location = new Point(110, 172);
            tabCustomers.Margin = new Padding(3, 4, 3, 4);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.RightToLeft = RightToLeft.Yes;
            tabCustomers.RightToLeftLayout = true;
            tabCustomers.SelectedIndex = 0;
            tabCustomers.Size = new Size(563, 587);
            tabCustomers.TabIndex = 2;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(addTypeCb);
            addCustomer.Controls.Add(addCustomerBtn);
            addCustomer.Controls.Add(addPhoneTxt);
            addCustomer.Controls.Add(addIdTxt);
            addCustomer.Controls.Add(label2);
            addCustomer.Controls.Add(label6);
            addCustomer.Controls.Add(label3);
            addCustomer.Controls.Add(label5);
            addCustomer.Controls.Add(addAddressTxt);
            addCustomer.Controls.Add(addNameTxt);
            addCustomer.Controls.Add(label4);
            addCustomer.Location = new Point(4, 29);
            addCustomer.Margin = new Padding(3, 4, 3, 4);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3, 4, 3, 4);
            addCustomer.Size = new Size(555, 554);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            // 
            // addTypeCb
            // 
            addTypeCb.FormattingEnabled = true;
            addTypeCb.Location = new Point(190, 333);
            addTypeCb.Margin = new Padding(3, 4, 3, 4);
            addTypeCb.Name = "addTypeCb";
            addTypeCb.Size = new Size(138, 28);
            addTypeCb.TabIndex = 23;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(206, 412);
            addCustomerBtn.Margin = new Padding(3, 4, 3, 4);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(177, 56);
            addCustomerBtn.TabIndex = 3;
            addCustomerBtn.Text = "הוספה";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // addPhoneTxt
            // 
            addPhoneTxt.Location = new Point(190, 275);
            addPhoneTxt.Margin = new Padding(3, 4, 3, 4);
            addPhoneTxt.Name = "addPhoneTxt";
            addPhoneTxt.Size = new Size(138, 27);
            addPhoneTxt.TabIndex = 19;
            // 
            // addIdTxt
            // 
            addIdTxt.Location = new Point(190, 99);
            addIdTxt.Margin = new Padding(3, 4, 3, 4);
            addIdTxt.Name = "addIdTxt";
            addIdTxt.Size = new Size(138, 27);
            addIdTxt.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 339);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 14;
            label2.Text = "סוג לקוח";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 104);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 18;
            label6.Text = "ת\"ז";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 280);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 15;
            label3.Text = "טלפון";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 163);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 17;
            label5.Text = "שם";
            // 
            // addAddressTxt
            // 
            addAddressTxt.Location = new Point(190, 216);
            addAddressTxt.Margin = new Padding(3, 4, 3, 4);
            addAddressTxt.Name = "addAddressTxt";
            addAddressTxt.Size = new Size(138, 27);
            addAddressTxt.TabIndex = 20;
            // 
            // addNameTxt
            // 
            addNameTxt.Location = new Point(190, 157);
            addNameTxt.Margin = new Padding(3, 4, 3, 4);
            addNameTxt.Name = "addNameTxt";
            addNameTxt.Size = new Size(138, 27);
            addNameTxt.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 221);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 16;
            label4.Text = "כתובת";
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(updateBtn);
            updateCustomer.Controls.Add(phoneTxtB);
            updateCustomer.Controls.Add(label8);
            updateCustomer.Controls.Add(addressTxtB);
            updateCustomer.Controls.Add(label9);
            updateCustomer.Controls.Add(nameTxtB);
            updateCustomer.Controls.Add(label7);
            updateCustomer.Controls.Add(label10);
            updateCustomer.Controls.Add(idTxtB);
            updateCustomer.Controls.Add(label11);
            updateCustomer.Location = new Point(4, 29);
            updateCustomer.Margin = new Padding(3, 4, 3, 4);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3, 4, 3, 4);
            updateCustomer.Size = new Size(555, 554);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(200, 412);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(177, 56);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "עדכון";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // phoneTxtB
            // 
            phoneTxtB.Location = new Point(179, 312);
            phoneTxtB.Margin = new Padding(3, 4, 3, 4);
            phoneTxtB.Name = "phoneTxtB";
            phoneTxtB.Size = new Size(138, 27);
            phoneTxtB.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(362, 317);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 5;
            label8.Text = "טלפון";
            // 
            // addressTxtB
            // 
            addressTxtB.Location = new Point(179, 253);
            addressTxtB.Margin = new Padding(3, 4, 3, 4);
            addressTxtB.Name = "addressTxtB";
            addressTxtB.Size = new Size(138, 27);
            addressTxtB.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(355, 259);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 6;
            label9.Text = "כתובת";
            // 
            // nameTxtB
            // 
            nameTxtB.Location = new Point(179, 195);
            nameTxtB.Margin = new Padding(3, 4, 3, 4);
            nameTxtB.Name = "nameTxtB";
            nameTxtB.Size = new Size(138, 27);
            nameTxtB.TabIndex = 11;
            nameTxtB.TextChanged += nameTxtB_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(376, 40);
            label7.Name = "label7";
            label7.Size = new Size(160, 25);
            label7.TabIndex = 7;
            label7.Text = "בחר לקוח מהטבלא";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 200);
            label10.Name = "label10";
            label10.Size = new Size(31, 20);
            label10.TabIndex = 7;
            label10.Text = "שם";
            // 
            // idTxtB
            // 
            idTxtB.Location = new Point(179, 136);
            idTxtB.Margin = new Padding(3, 4, 3, 4);
            idTxtB.Name = "idTxtB";
            idTxtB.Size = new Size(138, 27);
            idTxtB.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(375, 141);
            label11.Name = "label11";
            label11.Size = new Size(31, 20);
            label11.TabIndex = 8;
            label11.Text = "ת\"ז";
            // 
            // delete
            // 
            delete.Controls.Add(label12);
            delete.Controls.Add(currentConsumer);
            delete.Controls.Add(deleteCustomerBtn);
            delete.Location = new Point(4, 29);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 4, 3, 4);
            delete.Size = new Size(555, 554);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // currentConsumer
            // 
            currentConsumer.Location = new Point(188, 246);
            currentConsumer.Margin = new Padding(3, 3, 5, 5);
            currentConsumer.Name = "currentConsumer";
            currentConsumer.Size = new Size(190, 27);
            currentConsumer.TabIndex = 5;
            // 
            // deleteCustomerBtn
            // 
            deleteCustomerBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCustomerBtn.Location = new Point(229, 361);
            deleteCustomerBtn.Margin = new Padding(3, 4, 3, 4);
            deleteCustomerBtn.Name = "deleteCustomerBtn";
            deleteCustomerBtn.Size = new Size(133, 61);
            deleteCustomerBtn.TabIndex = 4;
            deleteCustomerBtn.Text = "מחיקה";
            deleteCustomerBtn.UseVisualStyleBackColor = true;
            deleteCustomerBtn.Click += deleteCustomerBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1073, 117);
            label1.Name = "label1";
            label1.Size = new Size(87, 37);
            label1.TabIndex = 3;
            label1.Text = "חיפוש";
            // 
            // findCustomerTxt
            // 
            findCustomerTxt.Location = new Point(886, 127);
            findCustomerTxt.Margin = new Padding(3, 4, 3, 4);
            findCustomerTxt.Name = "findCustomerTxt";
            findCustomerTxt.RightToLeft = RightToLeft.Yes;
            findCustomerTxt.Size = new Size(163, 27);
            findCustomerTxt.TabIndex = 4;
            findCustomerTxt.Text = "חיפוש לקוח";
            findCustomerTxt.TextChanged += findCustomerTxt_TextChanged;
            findCustomerTxt.Enter += findCustomerTxt_Enter;
            findCustomerTxt.Leave += findCustomerTxt_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(372, 27);
            label12.Name = "label12";
            label12.Size = new Size(160, 25);
            label12.TabIndex = 8;
            label12.Text = "בחר לקוח מהטבלא";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 856);
            Controls.Add(findCustomerTxt);
            Controls.Add(label1);
            Controls.Add(tabCustomers);
            Controls.Add(customerDgv);
            Controls.Add(productsTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customers";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)customerDgv).EndInit();
            tabCustomers.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productsTitle;
        private DataGridView customerDgv;
        private TabControl tabCustomers;
        private TabPage addCustomer;
        private TabPage updateCustomer;
        private Label label1;
        private TextBox findCustomerTxt;
        private TabPage delete;
        private Button addCustomerBtn;
        private Button updateBtn;
        private TextBox phoneTxtB;
        private Label label8;
        private TextBox addressTxtB;
        private Label label9;
        private TextBox nameTxtB;
        private Label label10;
        private TextBox idTxtB;
        private Label label11;
        private Button deleteCustomerBtn;
        private ComboBox addTypeCb;
        private TextBox addPhoneTxt;
        private TextBox addIdTxt;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label5;
        private TextBox addAddressTxt;
        private TextBox addNameTxt;
        private Label label4;
        private Label label7;
        private TextBox currentConsumer;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private Label label12;
    }
}