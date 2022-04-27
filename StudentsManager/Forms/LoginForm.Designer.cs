namespace StudentsManager.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.EmailInput = new StudentsManager.Components.TextBoxInput();
            this.PasswordInput = new StudentsManager.Components.TextBoxInput();
            this.headerText1 = new StudentsManager.Components.HeaderText();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginFormErrorLabel = new StudentsManager.Components.ErrorLabel();
            this.LoginBtn = new StudentsManager.Components.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailInput
            // 
            this.EmailInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.EmailInput.HeaderText = "Email";
            this.EmailInput.IsPasswordField = false;
            this.EmailInput.Location = new System.Drawing.Point(23, 151);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EmailInput.MaxLength = 60;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(258, 52);
            this.EmailInput.TabIndex = 1;
            this.EmailInput.Value = "";
            // 
            // PasswordInput
            // 
            this.PasswordInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.PasswordInput.HeaderText = "Password";
            this.PasswordInput.IsPasswordField = true;
            this.PasswordInput.Location = new System.Drawing.Point(23, 223);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PasswordInput.MaxLength = 20;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(258, 52);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.Value = "";
            // 
            // headerText1
            // 
            this.headerText1.AutoSize = true;
            this.headerText1.Font = new System.Drawing.Font("Poppins", 13.28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText1.HeaderType = StudentsManager.Components.HeaderType.Normal;
            this.headerText1.Location = new System.Drawing.Point(20, 110);
            this.headerText1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText1.Name = "headerText1";
            this.headerText1.Size = new System.Drawing.Size(216, 31);
            this.headerText1.TabIndex = 6;
            this.headerText1.Text = "Enter your credentials";
            this.headerText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentsManager.Properties.Resources.StudentsManagementSystemLogoBlack;
            this.pictureBox1.Location = new System.Drawing.Point(23, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFormErrorLabel
            // 
            this.LoginFormErrorLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginFormErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.LoginFormErrorLabel.Location = new System.Drawing.Point(20, 278);
            this.LoginFormErrorLabel.Name = "LoginFormErrorLabel";
            this.LoginFormErrorLabel.Size = new System.Drawing.Size(261, 45);
            this.LoginFormErrorLabel.TabIndex = 8;
            this.LoginFormErrorLabel.Text = "Email or Password is invalid";
            this.LoginFormErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginFormErrorLabel.Visible = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.LoginBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(23, 326);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(258, 52);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Sign In";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 401);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginFormErrorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headerText1);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.EmailInput);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 5, 20, 20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Manager - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.TextBoxInput EmailInput;
        private Components.TextBoxInput PasswordInput;
        private Components.HeaderText headerText1;
        private PictureBox pictureBox1;
        private Components.ErrorLabel LoginFormErrorLabel;
        private Components.CButton LoginBtn;
    }
}