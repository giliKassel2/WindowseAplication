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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            manageBtn = new Button();
            cashRegisterBtn = new Button();
            SuspendLayout();
            // 
            // manageBtn
            // 
            manageBtn.AutoSize = true;
            manageBtn.BackColor = Color.IndianRed;
            manageBtn.DialogResult = DialogResult.OK;
            manageBtn.FlatStyle = FlatStyle.Flat;
            manageBtn.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            manageBtn.Location = new Point(428, 332);
            manageBtn.Margin = new Padding(3, 4, 3, 4);
            manageBtn.Name = "manageBtn";
            manageBtn.Size = new Size(178, 93);
            manageBtn.TabIndex = 0;
            manageBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageBtn.UseVisualStyleBackColor = true;
            manageBtn.Click += manageBtn_Click;
            // 
            // cashRegisterBtn
            // 
            cashRegisterBtn.AutoSize = true;
            cashRegisterBtn.BackColor = Color.White;
            cashRegisterBtn.FlatStyle = FlatStyle.Flat;
            cashRegisterBtn.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            cashRegisterBtn.Location = new Point(640, 337);
            cashRegisterBtn.Margin = new Padding(3, 4, 3, 4);
            cashRegisterBtn.Name = "cashRegisterBtn";
            cashRegisterBtn.Size = new Size(185, 88);
            cashRegisterBtn.TabIndex = 1;
            cashRegisterBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            cashRegisterBtn.UseVisualStyleBackColor = false;
            cashRegisterBtn.Click += cashRegisterBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1250, 644);
            Controls.Add(cashRegisterBtn);
            Controls.Add(manageBtn);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1268, 691);
            MinimumSize = new Size(1268, 691);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button manageBtn;
        private Button cashRegisterBtn;
    }
}