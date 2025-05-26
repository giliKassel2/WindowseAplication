namespace UI
{
    partial class Home
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
            manageBtn = new Button();
            cashRegisterBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // manageBtn
            // 
            manageBtn.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageBtn.Location = new Point(223, 373);
            manageBtn.Name = "manageBtn";
            manageBtn.Size = new Size(246, 82);
            manageBtn.TabIndex = 0;
            manageBtn.Text = "ניהול";
            manageBtn.UseVisualStyleBackColor = true;
            manageBtn.Click += manageBtn_Click;
            // 
            // cashRegisterBtn
            // 
            cashRegisterBtn.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashRegisterBtn.Location = new Point(732, 373);
            cashRegisterBtn.Name = "cashRegisterBtn";
            cashRegisterBtn.Size = new Size(246, 82);
            cashRegisterBtn.TabIndex = 1;
            cashRegisterBtn.Text = "קופה";
            cashRegisterBtn.UseVisualStyleBackColor = true;
            cashRegisterBtn.Click += cashRegisterBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 84);
            label1.Name = "label1";
            label1.Size = new Size(777, 128);
            label1.TabIndex = 2;
            label1.Text = "__מ-מ-ת-ק-י-ם__";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 627);
            Controls.Add(label1);
            Controls.Add(cashRegisterBtn);
            Controls.Add(manageBtn);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button manageBtn;
        private Button cashRegisterBtn;
        private Label label1;
    }
}