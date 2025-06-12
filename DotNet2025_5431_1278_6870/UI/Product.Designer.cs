namespace UI
{
    partial class Product
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabProducts = new TabControl();
            addCustomer = new TabPage();
            label2 = new Label();
            label3 = new Label();
            addAmountN = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            addCustomerBtn = new Button();
            addCategoryComb = new ComboBox();
            addNameTxt = new TextBox();
            updateCustomer = new TabPage();
            productPriceTxb = new TextBox();
            label11 = new Label();
            productCodeTxb = new TextBox();
            label10 = new Label();
            quantityNUD = new NumericUpDown();
            updateBtn = new Button();
            updateCategoryCmb = new ComboBox();
            updateNameTxt = new TextBox();
            label9 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            delete = new TabPage();
            label12 = new Label();
            deleteCodeTxb = new TextBox();
            deleteProductBtn = new Button();
            label13 = new Label();
            productsTitle = new Label();
            findProductTxt = new TextBox();
            label1 = new Label();
            productDgv = new DataGridView();
            producerCode = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            orderBtn = new Button();
            saerchCategoryCb = new ComboBox();
            addPriceNUP = new TextBox();
            tabProducts.SuspendLayout();
            addCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountN).BeginInit();
            updateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNUD).BeginInit();
            delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDgv).BeginInit();
            SuspendLayout();
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(addCustomer);
            tabProducts.Controls.Add(updateCustomer);
            tabProducts.Controls.Add(delete);
            tabProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabProducts.Location = new Point(86, 152);
            tabProducts.Name = "tabProducts";
            tabProducts.RightToLeft = RightToLeft.Yes;
            tabProducts.RightToLeftLayout = true;
            tabProducts.SelectedIndex = 0;
            tabProducts.Size = new Size(476, 412);
            tabProducts.TabIndex = 3;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(addPriceNUP);
            addCustomer.Controls.Add(label2);
            addCustomer.Controls.Add(label3);
            addCustomer.Controls.Add(addAmountN);
            addCustomer.Controls.Add(label5);
            addCustomer.Controls.Add(label6);
            addCustomer.Controls.Add(addCustomerBtn);
            addCustomer.Controls.Add(addCategoryComb);
            addCustomer.Controls.Add(addNameTxt);
            addCustomer.Location = new Point(4, 30);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3);
            addCustomer.Size = new Size(468, 378);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(351, 86);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 15;
            label2.Text = "שם";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(340, 214);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 12;
            label3.Text = "מחיר";
            // 
            // addAmountN
            // 
            addAmountN.Location = new Point(135, 170);
            addAmountN.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            addAmountN.Name = "addAmountN";
            addAmountN.Size = new Size(120, 29);
            addAmountN.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(288, 171);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 14;
            label5.Text = "כמות במלאי";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(315, 128);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 13;
            label6.Text = "קטגוריה";
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(166, 265);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(155, 42);
            addCustomerBtn.TabIndex = 3;
            addCustomerBtn.Text = "הוספה";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // addCategoryComb
            // 
            addCategoryComb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addCategoryComb.FormattingEnabled = true;
            addCategoryComb.Location = new Point(134, 127);
            addCategoryComb.Name = "addCategoryComb";
            addCategoryComb.Size = new Size(121, 25);
            addCategoryComb.TabIndex = 2;
            // 
            // addNameTxt
            // 
            addNameTxt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addNameTxt.Location = new Point(134, 85);
            addNameTxt.Name = "addNameTxt";
            addNameTxt.Size = new Size(121, 25);
            addNameTxt.TabIndex = 1;
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(productPriceTxb);
            updateCustomer.Controls.Add(label11);
            updateCustomer.Controls.Add(productCodeTxb);
            updateCustomer.Controls.Add(label10);
            updateCustomer.Controls.Add(quantityNUD);
            updateCustomer.Controls.Add(updateBtn);
            updateCustomer.Controls.Add(updateCategoryCmb);
            updateCustomer.Controls.Add(updateNameTxt);
            updateCustomer.Controls.Add(label9);
            updateCustomer.Controls.Add(label4);
            updateCustomer.Controls.Add(label8);
            updateCustomer.Controls.Add(label7);
            updateCustomer.Location = new Point(4, 30);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3);
            updateCustomer.Size = new Size(468, 378);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // productPriceTxb
            // 
            productPriceTxb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productPriceTxb.Location = new Point(149, 237);
            productPriceTxb.Name = "productPriceTxb";
            productPriceTxb.Size = new Size(121, 25);
            productPriceTxb.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(296, 18);
            label11.Name = "label11";
            label11.Size = new Size(145, 21);
            label11.TabIndex = 35;
            label11.Text = "בחר מוצר מהטבלא";
            // 
            // productCodeTxb
            // 
            productCodeTxb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productCodeTxb.Location = new Point(149, 75);
            productCodeTxb.Name = "productCodeTxb";
            productCodeTxb.Size = new Size(121, 25);
            productCodeTxb.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(296, 80);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 33;
            label10.Text = "קוד מוצר";
            // 
            // quantityNUD
            // 
            quantityNUD.Location = new Point(150, 192);
            quantityNUD.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantityNUD.Name = "quantityNUD";
            quantityNUD.Size = new Size(120, 29);
            quantityNUD.TabIndex = 32;
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
            // updateCategoryCmb
            // 
            updateCategoryCmb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            updateCategoryCmb.FormattingEnabled = true;
            updateCategoryCmb.Location = new Point(149, 147);
            updateCategoryCmb.Name = "updateCategoryCmb";
            updateCategoryCmb.Size = new Size(121, 25);
            updateCategoryCmb.TabIndex = 14;
            // 
            // updateNameTxt
            // 
            updateNameTxt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            updateNameTxt.Location = new Point(149, 111);
            updateNameTxt.Name = "updateNameTxt";
            updateNameTxt.Size = new Size(121, 25);
            updateNameTxt.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(334, 111);
            label9.Name = "label9";
            label9.Size = new Size(34, 21);
            label9.TabIndex = 11;
            label9.Text = "שם";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(324, 239);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 8;
            label4.Text = "מחיר";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(271, 196);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 10;
            label8.Text = "כמות במלאי";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(298, 154);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 9;
            label7.Text = "קטגוריה";
            // 
            // delete
            // 
            delete.Controls.Add(label12);
            delete.Controls.Add(deleteCodeTxb);
            delete.Controls.Add(deleteProductBtn);
            delete.Controls.Add(label13);
            delete.Location = new Point(4, 30);
            delete.Name = "delete";
            delete.Padding = new Padding(3);
            delete.Size = new Size(468, 378);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(296, 12);
            label12.Name = "label12";
            label12.Size = new Size(145, 21);
            label12.TabIndex = 36;
            label12.Text = "בחר מוצר מהטבלא";
            // 
            // deleteCodeTxb
            // 
            deleteCodeTxb.Location = new Point(203, 157);
            deleteCodeTxb.Name = "deleteCodeTxb";
            deleteCodeTxb.Size = new Size(121, 29);
            deleteCodeTxb.TabIndex = 35;
            // 
            // deleteProductBtn
            // 
            deleteProductBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteProductBtn.Location = new Point(203, 271);
            deleteProductBtn.Name = "deleteProductBtn";
            deleteProductBtn.Size = new Size(116, 46);
            deleteProductBtn.TabIndex = 4;
            deleteProductBtn.Text = "מחיקה";
            deleteProductBtn.UseVisualStyleBackColor = true;
            deleteProductBtn.Click += deleteProductBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(226, 113);
            label13.Name = "label13";
            label13.Size = new Size(79, 30);
            label13.TabIndex = 3;
            label13.Text = "מחיקה";
            // 
            // productsTitle
            // 
            productsTitle.AutoSize = true;
            productsTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            productsTitle.ForeColor = Color.DarkSeaGreen;
            productsTitle.Location = new Point(483, 26);
            productsTitle.Name = "productsTitle";
            productsTitle.Size = new Size(184, 65);
            productsTitle.TabIndex = 4;
            productsTitle.Text = "מוצרים";
            // 
            // findProductTxt
            // 
            findProductTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            findProductTxt.Location = new Point(803, 109);
            findProductTxt.Name = "findProductTxt";
            findProductTxt.RightToLeft = RightToLeft.Yes;
            findProductTxt.Size = new Size(143, 27);
            findProductTxt.TabIndex = 7;
            findProductTxt.TextChanged += findProductTxt_TextChanged;
            findProductTxt.Enter += findProductTxt_Enter;
            findProductTxt.Leave += findProductTxt_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(951, 101);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 6;
            label1.Text = "חיפוש";
            // 
            // productDgv
            // 
            dataGridViewCellStyle1.ForeColor = Color.Salmon;
            productDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productDgv.BackgroundColor = SystemColors.Control;
            productDgv.BorderStyle = BorderStyle.None;
            productDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDgv.Columns.AddRange(new DataGridViewColumn[] { producerCode, name, amount, price, type });
            productDgv.GridColor = SystemColors.Control;
            productDgv.Location = new Point(581, 152);
            productDgv.Name = "productDgv";
            productDgv.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productDgv.RowHeadersWidth = 51;
            productDgv.Size = new Size(464, 440);
            productDgv.TabIndex = 5;
            // 
            // producerCode
            // 
            producerCode.HeaderText = "קוד";
            producerCode.MinimumWidth = 6;
            producerCode.Name = "producerCode";
            producerCode.ReadOnly = true;
            producerCode.Width = 60;
            // 
            // name
            // 
            name.HeaderText = "שם";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 130;
            // 
            // amount
            // 
            amount.HeaderText = "כמות במלאי";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 90;
            // 
            // price
            // 
            price.HeaderText = "מחיר";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 70;
            // 
            // type
            // 
            type.HeaderText = "קטגוריה";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            type.Resizable = DataGridViewTriState.True;
            type.SortMode = DataGridViewColumnSortMode.NotSortable;
            type.Width = 90;
            // 
            // orderBtn
            // 
            orderBtn.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            orderBtn.ForeColor = SystemColors.ActiveCaption;
            orderBtn.Location = new Point(86, 66);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(313, 52);
            orderBtn.TabIndex = 8;
            orderBtn.Text = "הזמנת מוצר נוסף";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // saerchCategoryCb
            // 
            saerchCategoryCb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            saerchCategoryCb.FormattingEnabled = true;
            saerchCategoryCb.Location = new Point(627, 108);
            saerchCategoryCb.Margin = new Padding(3, 2, 3, 2);
            saerchCategoryCb.Name = "saerchCategoryCb";
            saerchCategoryCb.Size = new Size(155, 27);
            saerchCategoryCb.TabIndex = 9;
            saerchCategoryCb.SelectedIndexChanged += saerchCategoryCb_SelectedIndexChanged;
            // 
            // addPriceNUP
            // 
            addPriceNUP.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addPriceNUP.Location = new Point(135, 214);
            addPriceNUP.Name = "addPriceNUP";
            addPriceNUP.Size = new Size(121, 25);
            addPriceNUP.TabIndex = 16;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 634);
            Controls.Add(saerchCategoryCb);
            Controls.Add(orderBtn);
            Controls.Add(findProductTxt);
            Controls.Add(label1);
            Controls.Add(productDgv);
            Controls.Add(productsTitle);
            Controls.Add(tabProducts);
            Name = "Product";
            Text = "Product";
            tabProducts.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountN).EndInit();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNUD).EndInit();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabProducts;
        private TabPage addCustomer;
        private Button addCustomerBtn;
        private ComboBox addCategoryComb;
        private TextBox addNameTxt;
        private TabPage updateCustomer;
        private Button updateBtn;
        private TabPage delete;
        private Button deleteProductBtn;
        private Label label13;
        private Label productsTitle;
        private TextBox findProductTxt;
        private Label label1;
        private DataGridView productDgv;
        private ComboBox updateCategoryCmb;
        private TextBox updateNameTxt;
        private Label label9;
        private Label label4;
        private Label label8;
        private Label label7;
        private Button orderBtn;
        private NumericUpDown addAmountN;
        private NumericUpDown quantityNUD;
        private ComboBox saerchCategoryCb;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn producerCode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn type;
        private Label label11;
        private TextBox productCodeTxb;
        private Label label10;
        private TextBox deleteCodeTxb;
        private Label label12;
        private TextBox productPriceTxb;
        private TextBox addPriceNUP;
    }
}