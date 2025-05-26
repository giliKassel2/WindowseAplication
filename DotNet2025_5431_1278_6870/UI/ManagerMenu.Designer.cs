namespace UI
{
    partial class ManagerMenu
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
            CustomerBtn = new Button();
            ProductBtn = new Button();
            SaleBtn = new Button();
            SuspendLayout();
            // 
            // CustomerBtn
            // 
            CustomerBtn.Font = new Font("Segoe UI", 26.25F);
            CustomerBtn.Location = new Point(709, 227);
            CustomerBtn.Name = "CustomerBtn";
            CustomerBtn.Size = new Size(200, 88);
            CustomerBtn.TabIndex = 0;
            CustomerBtn.Text = "לקוחות";
            CustomerBtn.UseVisualStyleBackColor = true;
            CustomerBtn.Click += CustomerBtn_Click;
            // 
            // ProductBtn
            // 
            ProductBtn.Font = new Font("Segoe UI", 26.25F);
            ProductBtn.Location = new Point(458, 227);
            ProductBtn.Name = "ProductBtn";
            ProductBtn.Size = new Size(200, 88);
            ProductBtn.TabIndex = 0;
            ProductBtn.Text = "מוצרים";
            ProductBtn.UseVisualStyleBackColor = true;
            ProductBtn.Click += ProductBtn_Click;
            // 
            // SaleBtn
            // 
            SaleBtn.Font = new Font("Segoe UI", 26.25F);
            SaleBtn.Location = new Point(207, 227);
            SaleBtn.Name = "SaleBtn";
            SaleBtn.Size = new Size(200, 88);
            SaleBtn.TabIndex = 0;
            SaleBtn.Text = "מבצעים";
            SaleBtn.UseVisualStyleBackColor = true;
            SaleBtn.Click += SaleBtn_Click;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 597);
            Controls.Add(SaleBtn);
            Controls.Add(ProductBtn);
            Controls.Add(CustomerBtn);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button CustomerBtn;
        private Button ProductBtn;
        private Button SaleBtn;
    }
}