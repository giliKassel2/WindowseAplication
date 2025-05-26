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
            idToUpdateCb = new ComboBox();
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
            idToDeleteCb = new ComboBox();
            deleteCustomerBtn = new Button();
            label13 = new Label();
            label1 = new Label();
            findCustomerTxt = new TextBox();
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
            productsTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsTitle.Location = new Point(448, 9);
            productsTitle.Name = "productsTitle";
            productsTitle.Size = new Size(188, 65);
            productsTitle.TabIndex = 0;
            productsTitle.Text = "לקוחות";
            // 
            // customerDgv
            // 
            customerDgv.BackgroundColor = SystemColors.Control;
            customerDgv.BorderStyle = BorderStyle.None;
            customerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDgv.Columns.AddRange(new DataGridViewColumn[] { id, name, address, phone });
            customerDgv.GridColor = SystemColors.Control;
            customerDgv.Location = new Point(682, 139);
            customerDgv.Name = "customerDgv";
            customerDgv.RightToLeft = RightToLeft.Yes;
            customerDgv.RowHeadersWidth = 51;
            customerDgv.Size = new Size(351, 440);
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
            name.Width = 80;
            // 
            // address
            // 
            address.HeaderText = "כתובת";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.Width = 90;
            // 
            // phone
            // 
            phone.HeaderText = "טלפון";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 80;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(addCustomer);
            tabCustomers.Controls.Add(updateCustomer);
            tabCustomers.Controls.Add(delete);
            tabCustomers.Location = new Point(96, 129);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.RightToLeft = RightToLeft.Yes;
            tabCustomers.RightToLeftLayout = true;
            tabCustomers.SelectedIndex = 0;
            tabCustomers.Size = new Size(493, 440);
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
            addCustomer.Location = new Point(4, 24);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3, 3, 3, 3);
            addCustomer.Size = new Size(485, 412);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            // 
            // addTypeCb
            // 
            addTypeCb.FormattingEnabled = true;
            addTypeCb.Location = new Point(166, 250);
            addTypeCb.Name = "addTypeCb";
            addTypeCb.Size = new Size(121, 23);
            addTypeCb.TabIndex = 23;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(180, 309);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(155, 42);
            addCustomerBtn.TabIndex = 3;
            addCustomerBtn.Text = "הוספה";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // addPhoneTxt
            // 
            addPhoneTxt.Location = new Point(166, 206);
            addPhoneTxt.Name = "addPhoneTxt";
            addPhoneTxt.Size = new Size(121, 23);
            addPhoneTxt.TabIndex = 19;
            // 
            // addIdTxt
            // 
            addIdTxt.Location = new Point(166, 74);
            addIdTxt.Name = "addIdTxt";
            addIdTxt.Size = new Size(121, 23);
            addIdTxt.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 254);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 14;
            label2.Text = "סוג לקוח";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 78);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 18;
            label6.Text = "ת\"ז";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 210);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 15;
            label3.Text = "טלפון";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 122);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 17;
            label5.Text = "שם";
            // 
            // addAddressTxt
            // 
            addAddressTxt.Location = new Point(166, 162);
            addAddressTxt.Name = "addAddressTxt";
            addAddressTxt.Size = new Size(121, 23);
            addAddressTxt.TabIndex = 20;
            // 
            // addNameTxt
            // 
            addNameTxt.Location = new Point(166, 118);
            addNameTxt.Name = "addNameTxt";
            addNameTxt.Size = new Size(121, 23);
            addNameTxt.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 166);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 16;
            label4.Text = "כתובת";
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(idToUpdateCb);
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
            updateCustomer.Location = new Point(4, 24);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3, 3, 3, 3);
            updateCustomer.Size = new Size(485, 412);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // idToUpdateCb
            // 
            idToUpdateCb.FormattingEnabled = true;
            idToUpdateCb.Location = new Point(221, 55);
            idToUpdateCb.Name = "idToUpdateCb";
            idToUpdateCb.Size = new Size(121, 23);
            idToUpdateCb.TabIndex = 15;
            idToUpdateCb.SelectedValueChanged += idToUpdateCb_SelectedValueChanged_1;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(175, 309);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(155, 42);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "עדכון";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // phoneTxtB
            // 
            phoneTxtB.Location = new Point(157, 234);
            phoneTxtB.Name = "phoneTxtB";
            phoneTxtB.Size = new Size(121, 23);
            phoneTxtB.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(317, 238);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 5;
            label8.Text = "טלפון";
            // 
            // addressTxtB
            // 
            addressTxtB.Location = new Point(157, 190);
            addressTxtB.Name = "addressTxtB";
            addressTxtB.Size = new Size(121, 23);
            addressTxtB.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 194);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 6;
            label9.Text = "כתובת";
            // 
            // nameTxtB
            // 
            nameTxtB.Location = new Point(157, 146);
            nameTxtB.Name = "nameTxtB";
            nameTxtB.Size = new Size(121, 23);
            nameTxtB.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 26);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 7;
            label7.Text = "בחר לקוח לעדכון";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(329, 150);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 7;
            label10.Text = "שם";
            // 
            // idTxtB
            // 
            idTxtB.Location = new Point(157, 102);
            idTxtB.Name = "idTxtB";
            idTxtB.Size = new Size(121, 23);
            idTxtB.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(328, 106);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 8;
            label11.Text = "ת\"ז";
            // 
            // delete
            // 
            delete.Controls.Add(idToDeleteCb);
            delete.Controls.Add(deleteCustomerBtn);
            delete.Controls.Add(label13);
            delete.Location = new Point(4, 24);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 3, 3, 3);
            delete.Size = new Size(485, 412);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // idToDeleteCb
            // 
            idToDeleteCb.FormattingEnabled = true;
            idToDeleteCb.Location = new Point(171, 164);
            idToDeleteCb.Name = "idToDeleteCb";
            idToDeleteCb.Size = new Size(174, 23);
            idToDeleteCb.TabIndex = 5;
            // 
            // deleteCustomerBtn
            // 
            deleteCustomerBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteCustomerBtn.Location = new Point(200, 271);
            deleteCustomerBtn.Name = "deleteCustomerBtn";
            deleteCustomerBtn.Size = new Size(116, 46);
            deleteCustomerBtn.TabIndex = 4;
            deleteCustomerBtn.Text = "מחיקה";
            deleteCustomerBtn.UseVisualStyleBackColor = true;
            deleteCustomerBtn.Click += deleteCustomerBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F);
            label13.Location = new Point(191, 109);
            label13.Name = "label13";
            label13.Size = new Size(134, 30);
            label13.TabIndex = 3;
            label13.Text = "מחיקת לקוח";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(939, 88);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 3;
            label1.Text = "חיפוש";
            // 
            // findCustomerTxt
            // 
            findCustomerTxt.Location = new Point(775, 95);
            findCustomerTxt.Name = "findCustomerTxt";
            findCustomerTxt.RightToLeft = RightToLeft.Yes;
            findCustomerTxt.Size = new Size(143, 23);
            findCustomerTxt.TabIndex = 4;
            findCustomerTxt.Text = "חיפוש לקוח";
            findCustomerTxt.TextChanged += findCustomerTxt_TextChanged;
            findCustomerTxt.Enter += findCustomerTxt_Enter;
            findCustomerTxt.Leave += findCustomerTxt_Leave;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 642);
            Controls.Add(findCustomerTxt);
            Controls.Add(label1);
            Controls.Add(tabCustomers);
            Controls.Add(customerDgv);
            Controls.Add(productsTitle);
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
        private Label label13;
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
        private ComboBox idToDeleteCb;
        private ComboBox idToUpdateCb;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private Label label7;
    }
}