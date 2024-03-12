namespace WinFormsModelViewModelViewApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            lblName = new Label();
            lblAge = new Label();
            txtAge = new NumericUpDown();
            btnChancgeName = new Button();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.Location = new Point(26, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 39);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F);
            lblName.Location = new Point(26, 215);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 32);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 18F);
            lblAge.Location = new Point(26, 262);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(78, 32);
            lblAge.TabIndex = 1;
            lblAge.Text = "label1";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 18F);
            txtAge.Location = new Point(26, 129);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(287, 39);
            txtAge.TabIndex = 2;
            // 
            // btnChancgeName
            // 
            btnChancgeName.Font = new Font("Segoe UI", 16F);
            btnChancgeName.Location = new Point(335, 226);
            btnChancgeName.Name = "btnChancgeName";
            btnChancgeName.Size = new Size(149, 78);
            btnChancgeName.TabIndex = 3;
            btnChancgeName.Text = "Change Name";
            btnChancgeName.UseVisualStyleBackColor = true;
            btnChancgeName.Click += btnChancgeName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 316);
            Controls.Add(btnChancgeName);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblAge;
        private NumericUpDown txtAge;
        private Button btnChancgeName;
    }
}
