﻿namespace StudentsManager.Forms
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
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(12, 12);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(234, 23);
            this.emailInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(12, 59);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(234, 23);
            this.passwordInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailInput);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox emailInput;
        private TextBox passwordInput;
        private Button button1;
    }
}