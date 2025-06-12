namespace UI
{
    partial class Sale
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
            components = new System.ComponentModel.Container();
            findSaleTxt = new TextBox();
            label1 = new Label();
            salesDgv = new DataGridView();
            producerCode = new DataGridViewTextBoxColumn();
            מוצר = new DataGridViewTextBoxColumn();
            productId = new DataGridViewTextBoxColumn();
            amountSale = new DataGridViewTextBoxColumn();
            priceSale = new DataGridViewTextBoxColumn();
            StartSale = new DataGridViewTextBoxColumn();
            EndSale = new DataGridViewTextBoxColumn();
            club = new DataGridViewCheckBoxColumn();
            productsTitle = new Label();
            tabProducts = new TabControl();
            addCustomer = new TabPage();
            textBox1 = new TextBox();
            addAmountSaleNUD = new NumericUpDown();
            isClubCB = new CheckBox();
            label12 = new Label();
            addProductIdTxt = new TextBox();
            endSaleDTP = new DateTimePicker();
            startSaleDTP = new DateTimePicker();
            addSaleBtn = new Button();
            label10 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            updateCustomer = new TabPage();
            priceNumTb = new TextBox();
            label17 = new Label();
            saleCodeTb = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label14 = new Label();
            label15 = new Label();
            clubCB = new CheckBox();
            amountSaleNUD = new NumericUpDown();
            productIdTxt = new TextBox();
            EndDate = new DateTimePicker();
            updateBtn = new Button();
            startDate = new DateTimePicker();
            delete = new TabPage();
            currentSale = new TextBox();
            label16 = new Label();
            deleteSaleBtn = new Button();
            label13 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)salesDgv).BeginInit();
            tabProducts.SuspendLayout();
            addCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountSaleNUD).BeginInit();
            updateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountSaleNUD).BeginInit();
            delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // findSaleTxt
            // 
            findSaleTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            findSaleTxt.Location = new Point(837, 110);
            findSaleTxt.Name = "findSaleTxt";
            findSaleTxt.RightToLeft = RightToLeft.Yes;
            findSaleTxt.Size = new Size(171, 26);
            findSaleTxt.TabIndex = 12;
            findSaleTxt.TextChanged += findSaleTxt_TextChanged;
            findSaleTxt.Enter += findSaleTxt_Enter;
            findSaleTxt.Leave += findSaleTxt_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1013, 103);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 11;
            label1.Text = "חיפוש";
            // 
            // salesDgv
            // 
            salesDgv.BackgroundColor = SystemColors.Control;
            salesDgv.BorderStyle = BorderStyle.None;
            salesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDgv.Columns.AddRange(new DataGridViewColumn[] { producerCode, מוצר, productId, amountSale, priceSale, StartSale, EndSale, club });
            salesDgv.GridColor = SystemColors.Control;
            salesDgv.Location = new Point(484, 140);
            salesDgv.Name = "salesDgv";
            salesDgv.RightToLeft = RightToLeft.Yes;
            salesDgv.RowHeadersWidth = 51;
            salesDgv.Size = new Size(622, 440);
            salesDgv.TabIndex = 10;
            salesDgv.CellContentClick += salesDgv_CellContentClick;
            // 
            // producerCode
            // 
            producerCode.HeaderText = "קוד מבצע";
            producerCode.MinimumWidth = 6;
            producerCode.Name = "producerCode";
            producerCode.ReadOnly = true;
            producerCode.Resizable = DataGridViewTriState.True;
            producerCode.Width = 50;
            // 
            // מוצר
            // 
            מוצר.HeaderText = "מוצר";
            מוצר.MinimumWidth = 6;
            מוצר.Name = "מוצר";
            מוצר.ReadOnly = true;
            מוצר.Width = 125;
            // 
            // productId
            // 
            productId.HeaderText = "קוד מוצר";
            productId.MinimumWidth = 6;
            productId.Name = "productId";
            productId.ReadOnly = true;
            productId.Width = 50;
            // 
            // amountSale
            // 
            amountSale.HeaderText = "כמות";
            amountSale.MinimumWidth = 6;
            amountSale.Name = "amountSale";
            amountSale.ReadOnly = true;
            amountSale.Width = 45;
            // 
            // priceSale
            // 
            priceSale.HeaderText = "מחיר";
            priceSale.MinimumWidth = 6;
            priceSale.Name = "priceSale";
            priceSale.ReadOnly = true;
            priceSale.Width = 70;
            // 
            // StartSale
            // 
            StartSale.HeaderText = "תאריך התחלה";
            StartSale.MinimumWidth = 6;
            StartSale.Name = "StartSale";
            StartSale.ReadOnly = true;
            StartSale.Width = 120;
            // 
            // EndSale
            // 
            EndSale.HeaderText = "תאריך סיום";
            EndSale.MinimumWidth = 6;
            EndSale.Name = "EndSale";
            EndSale.ReadOnly = true;
            EndSale.Width = 125;
            // 
            // club
            // 
            club.HeaderText = "מועדון";
            club.MinimumWidth = 6;
            club.Name = "club";
            club.ReadOnly = true;
            club.Resizable = DataGridViewTriState.True;
            club.SortMode = DataGridViewColumnSortMode.Automatic;
            club.Width = 55;
            // 
            // productsTitle
            // 
            productsTitle.AutoSize = true;
            productsTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            productsTitle.ForeColor = Color.FromArgb(255, 128, 128);
            productsTitle.Location = new Point(475, 29);
            productsTitle.Name = "productsTitle";
            productsTitle.Size = new Size(200, 65);
            productsTitle.TabIndex = 9;
            productsTitle.Text = "מבצעים";
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(addCustomer);
            tabProducts.Controls.Add(updateCustomer);
            tabProducts.Controls.Add(delete);
            tabProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabProducts.Location = new Point(23, 127);
            tabProducts.Name = "tabProducts";
            tabProducts.RightToLeft = RightToLeft.Yes;
            tabProducts.RightToLeftLayout = true;
            tabProducts.SelectedIndex = 0;
            tabProducts.Size = new Size(456, 440);
            tabProducts.TabIndex = 8;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(textBox1);
            addCustomer.Controls.Add(addAmountSaleNUD);
            addCustomer.Controls.Add(isClubCB);
            addCustomer.Controls.Add(label12);
            addCustomer.Controls.Add(addProductIdTxt);
            addCustomer.Controls.Add(endSaleDTP);
            addCustomer.Controls.Add(startSaleDTP);
            addCustomer.Controls.Add(addSaleBtn);
            addCustomer.Controls.Add(label10);
            addCustomer.Controls.Add(label6);
            addCustomer.Controls.Add(label2);
            addCustomer.Controls.Add(label5);
            addCustomer.Controls.Add(label3);
            addCustomer.Location = new Point(4, 30);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3, 3, 3, 3);
            addCustomer.Size = new Size(448, 406);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            addCustomer.Click += addCustomer_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(124, 158);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 25);
            textBox1.TabIndex = 37;
            // 
            // addAmountSaleNUD
            // 
            addAmountSaleNUD.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addAmountSaleNUD.Location = new Point(124, 115);
            addAmountSaleNUD.Margin = new Padding(3, 2, 3, 2);
            addAmountSaleNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            addAmountSaleNUD.Name = "addAmountSaleNUD";
            addAmountSaleNUD.Size = new Size(118, 25);
            addAmountSaleNUD.TabIndex = 10;
            addAmountSaleNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // isClubCB
            // 
            isClubCB.AutoSize = true;
            isClubCB.Location = new Point(191, 297);
            isClubCB.Name = "isClubCB";
            isClubCB.Size = new Size(15, 14);
            isClubCB.TabIndex = 9;
            isClubCB.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(348, 289);
            label12.Name = "label12";
            label12.Size = new Size(51, 21);
            label12.TabIndex = 8;
            label12.Text = "מועדון";
            label12.Click += label12_Click;
            // 
            // addProductIdTxt
            // 
            addProductIdTxt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addProductIdTxt.Location = new Point(123, 69);
            addProductIdTxt.Name = "addProductIdTxt";
            addProductIdTxt.Size = new Size(136, 25);
            addProductIdTxt.TabIndex = 7;
            // 
            // endSaleDTP
            // 
            endSaleDTP.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            endSaleDTP.Location = new Point(123, 249);
            endSaleDTP.Name = "endSaleDTP";
            endSaleDTP.Size = new Size(136, 25);
            endSaleDTP.TabIndex = 6;
            // 
            // startSaleDTP
            // 
            startSaleDTP.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            startSaleDTP.Location = new Point(123, 204);
            startSaleDTP.Name = "startSaleDTP";
            startSaleDTP.Size = new Size(136, 25);
            startSaleDTP.TabIndex = 6;
            // 
            // addSaleBtn
            // 
            addSaleBtn.Location = new Point(180, 333);
            addSaleBtn.Name = "addSaleBtn";
            addSaleBtn.Size = new Size(155, 42);
            addSaleBtn.TabIndex = 3;
            addSaleBtn.Text = "הוספה";
            addSaleBtn.UseVisualStyleBackColor = true;
            addSaleBtn.Click += addSaleBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(306, 245);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 0;
            label10.Text = "תאריך סיום";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(281, 202);
            label6.Name = "label6";
            label6.Size = new Size(112, 21);
            label6.TabIndex = 0;
            label6.Text = "תאריך התחלה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(355, 158);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 0;
            label2.Text = "מחיר";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(298, 115);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 0;
            label5.Text = "כמות למבצע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(327, 71);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 0;
            label3.Text = "קוד מוצר";
            label3.Click += label3_Click;
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(priceNumTb);
            updateCustomer.Controls.Add(label17);
            updateCustomer.Controls.Add(saleCodeTb);
            updateCustomer.Controls.Add(label4);
            updateCustomer.Controls.Add(label7);
            updateCustomer.Controls.Add(label8);
            updateCustomer.Controls.Add(label9);
            updateCustomer.Controls.Add(label11);
            updateCustomer.Controls.Add(label14);
            updateCustomer.Controls.Add(label15);
            updateCustomer.Controls.Add(clubCB);
            updateCustomer.Controls.Add(amountSaleNUD);
            updateCustomer.Controls.Add(productIdTxt);
            updateCustomer.Controls.Add(EndDate);
            updateCustomer.Controls.Add(updateBtn);
            updateCustomer.Controls.Add(startDate);
            updateCustomer.Location = new Point(4, 30);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3, 3, 3, 3);
            updateCustomer.Size = new Size(448, 406);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            updateCustomer.Click += updateCustomer_Click;
            // 
            // priceNumTb
            // 
            priceNumTb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            priceNumTb.Location = new Point(89, 180);
            priceNumTb.Margin = new Padding(3, 2, 3, 2);
            priceNumTb.Name = "priceNumTb";
            priceNumTb.Size = new Size(138, 25);
            priceNumTb.TabIndex = 36;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(303, 59);
            label17.Name = "label17";
            label17.Size = new Size(66, 19);
            label17.TabIndex = 34;
            label17.Text = "קוד מבצע";
            label17.TextAlign = ContentAlignment.TopCenter;
            label17.Click += label17_Click;
            // 
            // saleCodeTb
            // 
            saleCodeTb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saleCodeTb.Location = new Point(89, 53);
            saleCodeTb.Name = "saleCodeTb";
            saleCodeTb.Size = new Size(138, 25);
            saleCodeTb.TabIndex = 35;
            saleCodeTb.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(321, 309);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 34;
            label4.Text = "מועדון";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(284, 270);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 29;
            label7.Text = "תאריך סיום";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(264, 225);
            label8.Name = "label8";
            label8.Size = new Size(97, 19);
            label8.TabIndex = 30;
            label8.Text = "תאריך התחלה";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(327, 180);
            label9.Name = "label9";
            label9.Size = new Size(39, 19);
            label9.TabIndex = 31;
            label9.Text = "מחיר";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(279, 135);
            label11.Name = "label11";
            label11.Size = new Size(85, 19);
            label11.TabIndex = 32;
            label11.Text = "כמות למבצע";
            label11.Click += label11_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(303, 96);
            label14.Name = "label14";
            label14.Size = new Size(62, 19);
            label14.TabIndex = 33;
            label14.Text = "קוד מוצר";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(239, 14);
            label15.Name = "label15";
            label15.Size = new Size(179, 21);
            label15.TabIndex = 27;
            label15.Text = "בחר קוד מבצע מהטבלה";
            // 
            // clubCB
            // 
            clubCB.AutoSize = true;
            clubCB.Location = new Point(211, 315);
            clubCB.Name = "clubCB";
            clubCB.Size = new Size(15, 14);
            clubCB.TabIndex = 25;
            clubCB.UseVisualStyleBackColor = true;
            clubCB.CheckedChanged += clubCB_CheckedChanged;
            // 
            // amountSaleNUD
            // 
            amountSaleNUD.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            amountSaleNUD.Location = new Point(89, 129);
            amountSaleNUD.Margin = new Padding(3, 2, 3, 2);
            amountSaleNUD.Name = "amountSaleNUD";
            amountSaleNUD.Size = new Size(119, 25);
            amountSaleNUD.TabIndex = 23;
            amountSaleNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            amountSaleNUD.ValueChanged += amountSaleNUD_ValueChanged;
            // 
            // productIdTxt
            // 
            productIdTxt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productIdTxt.Location = new Point(89, 90);
            productIdTxt.Name = "productIdTxt";
            productIdTxt.Size = new Size(138, 25);
            productIdTxt.TabIndex = 14;
            productIdTxt.TextChanged += productIdTxt_TextChanged;
            // 
            // EndDate
            // 
            EndDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            EndDate.Location = new Point(89, 270);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(138, 25);
            EndDate.TabIndex = 21;
            EndDate.ValueChanged += EndDate_ValueChanged;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateBtn.Location = new Point(138, 350);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(155, 42);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "עדכון";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // startDate
            // 
            startDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            startDate.Location = new Point(89, 225);
            startDate.Name = "startDate";
            startDate.Size = new Size(138, 25);
            startDate.TabIndex = 22;
            startDate.ValueChanged += startDate_ValueChanged;
            // 
            // delete
            // 
            delete.Controls.Add(currentSale);
            delete.Controls.Add(label16);
            delete.Controls.Add(deleteSaleBtn);
            delete.Controls.Add(label13);
            delete.Location = new Point(4, 30);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 3, 3, 3);
            delete.Size = new Size(448, 406);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // currentSale
            // 
            currentSale.Location = new Point(172, 166);
            currentSale.Margin = new Padding(3, 2, 3, 2);
            currentSale.Name = "currentSale";
            currentSale.Size = new Size(110, 29);
            currentSale.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(240, 10);
            label16.Name = "label16";
            label16.Size = new Size(179, 21);
            label16.TabIndex = 30;
            label16.Text = "בחר קוד מבצע מהטבלה";
            // 
            // deleteSaleBtn
            // 
            deleteSaleBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSaleBtn.Location = new Point(172, 257);
            deleteSaleBtn.Name = "deleteSaleBtn";
            deleteSaleBtn.Size = new Size(116, 46);
            deleteSaleBtn.TabIndex = 4;
            deleteSaleBtn.Text = "מחיקה";
            deleteSaleBtn.UseVisualStyleBackColor = true;
            deleteSaleBtn.Click += deleteSaleBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(180, 124);
            label13.Name = "label13";
            label13.Size = new Size(95, 20);
            label13.TabIndex = 3;
            label13.Text = "מחיקת מבצע";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 624);
            Controls.Add(findSaleTxt);
            Controls.Add(label1);
            Controls.Add(salesDgv);
            Controls.Add(productsTitle);
            Controls.Add(tabProducts);
            Name = "Sale";
            Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)salesDgv).EndInit();
            tabProducts.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountSaleNUD).EndInit();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountSaleNUD).EndInit();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox findSaleTxt;
        private Label label1;
        private DataGridView salesDgv;
        private Label productsTitle;
        private TabControl tabProducts;
        private TabPage addCustomer;
        private Button addSaleBtn;
        private Label label2;
        private Label label5;
        private Label label3;
        private TabPage updateCustomer;
        private Button updateBtn;
        private TabPage delete;
        private Button deleteSaleBtn;
        private Label label13;
        private ComboBox productNameCb;
        private DateTimePicker startSaleDTP;
        private DateTimePicker endSaleDTP;
        private Label label10;
        private Label label6;
        private DateTimePicker EndDate;
        private DateTimePicker startDate;
        private ComboBox nameCb;
        private TextBox addProductIdTxt;
        private TextBox productIdTxt;
        private CheckBox isClubCB;
        private Label label12;
        private NumericUpDown addAmountSaleNUD;
        private NumericUpDown amountSaleNUD;
        private Label label15;
        private CheckBox clubCB;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label14;
        private ErrorProvider errorProvider1;
        private TextBox currentSale;
        private Label label16;
        private DataGridViewTextBoxColumn producerCode;
        private DataGridViewTextBoxColumn מוצר;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn amountSale;
        private DataGridViewTextBoxColumn priceSale;
        private DataGridViewTextBoxColumn StartSale;
        private DataGridViewTextBoxColumn EndSale;
        private DataGridViewCheckBoxColumn club;
        private Label label17;
        private TextBox saleCodeTb;
        private TextBox priceNumTb;
        private TextBox textBox1;
    }
}