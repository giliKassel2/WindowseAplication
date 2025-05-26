namespace UI
{
    partial class CustomerDetail
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
            customerDetails = new GroupBox();
            preferance = new ComboBox();
            label1 = new Label();
            addresTxb = new TextBox();
            nameTxb = new TextBox();
            phoneTxb = new TextBox();
            idTxb = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            newOrderBtn = new Button();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            customerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // customerDetails
            // 
            customerDetails.Controls.Add(preferance);
            customerDetails.Controls.Add(label1);
            customerDetails.Controls.Add(addresTxb);
            customerDetails.Controls.Add(nameTxb);
            customerDetails.Controls.Add(phoneTxb);
            customerDetails.Controls.Add(idTxb);
            customerDetails.Controls.Add(label6);
            customerDetails.Controls.Add(label5);
            customerDetails.Controls.Add(label4);
            customerDetails.Controls.Add(label3);
            customerDetails.Location = new Point(258, 69);
            customerDetails.Name = "customerDetails";
            customerDetails.Size = new Size(284, 254);
            customerDetails.TabIndex = 14;
            customerDetails.TabStop = false;
            customerDetails.Text = " ";
            // 
            // preferance
            // 
            preferance.FormattingEnabled = true;
            preferance.Location = new Point(6, 207);
            preferance.Name = "preferance";
            preferance.Size = new Size(160, 23);
            preferance.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label1.Location = new Point(205, 207);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 8;
            label1.Text = "סוג לקוח";
            // 
            // addresTxb
            // 
            addresTxb.Location = new Point(6, 164);
            addresTxb.Name = "addresTxb";
            addresTxb.Size = new Size(160, 23);
            addresTxb.TabIndex = 7;
            // 
            // nameTxb
            // 
            nameTxb.Location = new Point(6, 84);
            nameTxb.Name = "nameTxb";
            nameTxb.Size = new Size(160, 23);
            nameTxb.TabIndex = 6;
            // 
            // phoneTxb
            // 
            phoneTxb.Location = new Point(6, 124);
            phoneTxb.Name = "phoneTxb";
            phoneTxb.Size = new Size(160, 23);
            phoneTxb.TabIndex = 5;
            // 
            // idTxb
            // 
            idTxb.Location = new Point(6, 44);
            idTxb.Name = "idTxb";
            idTxb.Size = new Size(160, 23);
            idTxb.TabIndex = 4;
            idTxb.TextChanged += idTxb_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label6.Location = new Point(238, 89);
            label6.Name = "label6";
            label6.Size = new Size(30, 19);
            label6.TabIndex = 3;
            label6.Text = "שם";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label5.Location = new Point(224, 130);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 2;
            label5.Text = "טלפון";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label4.Location = new Point(224, 168);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 1;
            label4.Text = "כתובת";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label3.Location = new Point(192, 48);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 0;
            label3.Text = "מזהה לקוח";
            // 
            // newOrderBtn
            // 
            newOrderBtn.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newOrderBtn.Location = new Point(258, 354);
            newOrderBtn.Name = "newOrderBtn";
            newOrderBtn.Size = new Size(284, 55);
            newOrderBtn.TabIndex = 15;
            newOrderBtn.Text = "מעבר להזמנה";
            newOrderBtn.UseVisualStyleBackColor = true;
            newOrderBtn.Click += newOrderBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(308, 20);
            label2.Name = "label2";
            label2.Size = new Size(183, 51);
            label2.TabIndex = 16;
            label2.Text = "התחברות";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomerDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(newOrderBtn);
            Controls.Add(customerDetails);
            Name = "CustomerDetail";
            Text = "CustomerDetail";
            customerDetails.ResumeLayout(false);
            customerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox customerDetails;
        private TextBox addresTxb;
        private TextBox nameTxb;
        private TextBox phoneTxb;
        private TextBox idTxb;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button newOrderBtn;
        private ComboBox preferance;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}