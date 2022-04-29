﻿namespace StudentsManager.Forms
{
    partial class StudentsDetailsForm
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
            this.textBoxInput1 = new StudentsManager.Components.TextBoxInput();
            this.textBoxInput3 = new StudentsManager.Components.TextBoxInput();
            this.StudentsDetailsBtn = new StudentsManager.Components.CButton();
            this.headerText1 = new StudentsManager.Components.HeaderText();
            this.SuspendLayout();
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.textBoxInput1.HeaderText = "text";
            this.textBoxInput1.IsPasswordField = false;
            this.textBoxInput1.Location = new System.Drawing.Point(20, 52);
            this.textBoxInput1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxInput1.MaxLength = 20;
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(160, 52);
            this.textBoxInput1.TabIndex = 0;
            this.textBoxInput1.Value = "";
            // 
            // textBoxInput3
            // 
            this.textBoxInput3.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.textBoxInput3.HeaderText = "text";
            this.textBoxInput3.IsPasswordField = false;
            this.textBoxInput3.Location = new System.Drawing.Point(224, 52);
            this.textBoxInput3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxInput3.MaxLength = 20;
            this.textBoxInput3.Name = "textBoxInput3";
            this.textBoxInput3.Size = new System.Drawing.Size(160, 52);
            this.textBoxInput3.TabIndex = 2;
            this.textBoxInput3.Value = "";
            // 
            // StudentsDetailsBtn
            // 
            this.StudentsDetailsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsDetailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.StudentsDetailsBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Secondary;
            this.StudentsDetailsBtn.FlatAppearance.BorderSize = 0;
            this.StudentsDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsDetailsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentsDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.StudentsDetailsBtn.Location = new System.Drawing.Point(23, 453);
            this.StudentsDetailsBtn.Name = "StudentsDetailsBtn";
            this.StudentsDetailsBtn.Size = new System.Drawing.Size(358, 52);
            this.StudentsDetailsBtn.TabIndex = 4;
            this.StudentsDetailsBtn.Text = "Edit Record";
            this.StudentsDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // headerText1
            // 
            this.headerText1.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText1.HeaderType = StudentsManager.Components.HeaderType.Large;
            this.headerText1.Location = new System.Drawing.Point(23, 10);
            this.headerText1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText1.Name = "headerText1";
            this.headerText1.Size = new System.Drawing.Size(302, 32);
            this.headerText1.TabIndex = 5;
            this.headerText1.Text = "New Student Record";
            this.headerText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 521);
            this.Controls.Add(this.headerText1);
            this.Controls.Add(this.StudentsDetailsBtn);
            this.Controls.Add(this.textBoxInput3);
            this.Controls.Add(this.textBoxInput1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentsDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Text = "6";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.TextBoxInput textBoxInput1;
        private Components.TextBoxInput textBoxInput3;
        private Components.CButton StudentsDetailsBtn;
        private Components.HeaderText headerText1;
    }
}