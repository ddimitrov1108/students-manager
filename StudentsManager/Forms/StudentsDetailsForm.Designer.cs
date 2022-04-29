namespace StudentsManager.Forms
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
            this.FirstNameInput = new StudentsManager.Components.TextBoxInput();
            this.LastNameInput = new StudentsManager.Components.TextBoxInput();
            this.StudentsDetailsBtn = new StudentsManager.Components.CButton();
            this.headerText1 = new StudentsManager.Components.HeaderText();
            this.FacultyNumberInput = new StudentsManager.Components.TextBoxInput();
            this.PhoneNumberInput = new StudentsManager.Components.TextBoxInput();
            this.faIcon2 = new StudentsManager.Components.FAIcon();
            this.headerText2 = new StudentsManager.Components.HeaderText();
            this.EduTypeCombo = new StudentsManager.Components.ComboBoxInput();
            this.EduSpecialtyCombo = new StudentsManager.Components.ComboBoxInput();
            this.EduFormCombo = new StudentsManager.Components.ComboBoxInput();
            this.EduYearInput = new StudentsManager.Components.TextBoxInput();
            this.EduGpaInput = new StudentsManager.Components.TextBoxInput();
            this.EduPausedCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon2)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.FirstNameInput.HeaderText = "First Name";
            this.FirstNameInput.IsPasswordField = false;
            this.FirstNameInput.Location = new System.Drawing.Point(23, 124);
            this.FirstNameInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.FirstNameInput.MaxLength = 20;
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.ReadOnly = false;
            this.FirstNameInput.Size = new System.Drawing.Size(160, 52);
            this.FirstNameInput.TabIndex = 2;
            this.FirstNameInput.Value = "";
            // 
            // LastNameInput
            // 
            this.LastNameInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.LastNameInput.HeaderText = "Last Name";
            this.LastNameInput.IsPasswordField = false;
            this.LastNameInput.Location = new System.Drawing.Point(211, 124);
            this.LastNameInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.LastNameInput.MaxLength = 20;
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.ReadOnly = false;
            this.LastNameInput.Size = new System.Drawing.Size(160, 52);
            this.LastNameInput.TabIndex = 3;
            this.LastNameInput.Value = "";
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
            this.StudentsDetailsBtn.Location = new System.Drawing.Point(23, 529);
            this.StudentsDetailsBtn.Name = "StudentsDetailsBtn";
            this.StudentsDetailsBtn.Size = new System.Drawing.Size(348, 52);
            this.StudentsDetailsBtn.TabIndex = 11;
            this.StudentsDetailsBtn.Text = "Edit Record";
            this.StudentsDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // headerText1
            // 
            this.headerText1.Font = new System.Drawing.Font("Poppins", 13.28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText1.HeaderType = StudentsManager.Components.HeaderType.Normal;
            this.headerText1.Location = new System.Drawing.Point(51, 10);
            this.headerText1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText1.Name = "headerText1";
            this.headerText1.Size = new System.Drawing.Size(320, 32);
            this.headerText1.TabIndex = 5;
            this.headerText1.Text = "New Student Record";
            this.headerText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FacultyNumberInput
            // 
            this.FacultyNumberInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.FacultyNumberInput.HeaderText = "Faculty Number";
            this.FacultyNumberInput.IsPasswordField = false;
            this.FacultyNumberInput.Location = new System.Drawing.Point(23, 52);
            this.FacultyNumberInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.FacultyNumberInput.MaxLength = 20;
            this.FacultyNumberInput.Name = "FacultyNumberInput";
            this.FacultyNumberInput.ReadOnly = true;
            this.FacultyNumberInput.Size = new System.Drawing.Size(348, 52);
            this.FacultyNumberInput.TabIndex = 1;
            this.FacultyNumberInput.Value = "";
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.PhoneNumberInput.HeaderText = "Phone Number";
            this.PhoneNumberInput.IsPasswordField = false;
            this.PhoneNumberInput.Location = new System.Drawing.Point(23, 196);
            this.PhoneNumberInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PhoneNumberInput.MaxLength = 20;
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.ReadOnly = false;
            this.PhoneNumberInput.Size = new System.Drawing.Size(348, 52);
            this.PhoneNumberInput.TabIndex = 4;
            this.PhoneNumberInput.Value = "";
            // 
            // faIcon2
            // 
            this.faIcon2.BackColor = System.Drawing.Color.Transparent;
            this.faIcon2.ColorSelected = StudentsManager.Components.Classes.ColorType.Success;
            this.faIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.faIcon2.Icon = FontAwesome.Sharp.IconChar.UserPlus;
            this.faIcon2.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.faIcon2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.faIcon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon2.IconSize = 28;
            this.faIcon2.Location = new System.Drawing.Point(20, 12);
            this.faIcon2.Name = "faIcon2";
            this.faIcon2.SetIconSize = 28;
            this.faIcon2.Size = new System.Drawing.Size(28, 28);
            this.faIcon2.TabIndex = 24;
            this.faIcon2.TabStop = false;
            this.faIcon2.UseGdi = true;
            // 
            // headerText2
            // 
            this.headerText2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText2.HeaderType = StudentsManager.Components.HeaderType.XSmall;
            this.headerText2.Location = new System.Drawing.Point(23, 268);
            this.headerText2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText2.Name = "headerText2";
            this.headerText2.Size = new System.Drawing.Size(348, 32);
            this.headerText2.TabIndex = 25;
            this.headerText2.Text = "Education";
            this.headerText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EduTypeCombo
            // 
            this.EduTypeCombo.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.EduTypeCombo.HeaderText = "Type";
            this.EduTypeCombo.Location = new System.Drawing.Point(23, 310);
            this.EduTypeCombo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EduTypeCombo.Name = "EduTypeCombo";
            this.EduTypeCombo.Size = new System.Drawing.Size(160, 52);
            this.EduTypeCombo.TabIndex = 5;
            // 
            // EduSpecialtyCombo
            // 
            this.EduSpecialtyCombo.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.EduSpecialtyCombo.HeaderText = "Specialty";
            this.EduSpecialtyCombo.Location = new System.Drawing.Point(211, 310);
            this.EduSpecialtyCombo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EduSpecialtyCombo.Name = "EduSpecialtyCombo";
            this.EduSpecialtyCombo.Size = new System.Drawing.Size(160, 52);
            this.EduSpecialtyCombo.TabIndex = 6;
            // 
            // EduFormCombo
            // 
            this.EduFormCombo.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.EduFormCombo.HeaderText = "Form";
            this.EduFormCombo.Location = new System.Drawing.Point(23, 382);
            this.EduFormCombo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EduFormCombo.Name = "EduFormCombo";
            this.EduFormCombo.Size = new System.Drawing.Size(160, 52);
            this.EduFormCombo.TabIndex = 7;
            // 
            // EduYearInput
            // 
            this.EduYearInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.EduYearInput.HeaderText = "Year";
            this.EduYearInput.IsPasswordField = false;
            this.EduYearInput.Location = new System.Drawing.Point(211, 382);
            this.EduYearInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EduYearInput.MaxLength = 20;
            this.EduYearInput.Name = "EduYearInput";
            this.EduYearInput.ReadOnly = false;
            this.EduYearInput.Size = new System.Drawing.Size(160, 52);
            this.EduYearInput.TabIndex = 8;
            this.EduYearInput.Value = "";
            // 
            // EduGpaInput
            // 
            this.EduGpaInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.EduGpaInput.HeaderText = "GPA";
            this.EduGpaInput.IsPasswordField = false;
            this.EduGpaInput.Location = new System.Drawing.Point(23, 454);
            this.EduGpaInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EduGpaInput.MaxLength = 20;
            this.EduGpaInput.Name = "EduGpaInput";
            this.EduGpaInput.ReadOnly = false;
            this.EduGpaInput.Size = new System.Drawing.Size(160, 52);
            this.EduGpaInput.TabIndex = 9;
            this.EduGpaInput.Value = "";
            // 
            // EduPausedCheckbox
            // 
            this.EduPausedCheckbox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EduPausedCheckbox.Location = new System.Drawing.Point(204, 473);
            this.EduPausedCheckbox.Name = "EduPausedCheckbox";
            this.EduPausedCheckbox.Size = new System.Drawing.Size(167, 33);
            this.EduPausedCheckbox.TabIndex = 10;
            this.EduPausedCheckbox.Text = "Paused";
            this.EduPausedCheckbox.UseVisualStyleBackColor = true;
            // 
            // StudentsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 594);
            this.Controls.Add(this.EduPausedCheckbox);
            this.Controls.Add(this.EduGpaInput);
            this.Controls.Add(this.EduYearInput);
            this.Controls.Add(this.EduFormCombo);
            this.Controls.Add(this.EduSpecialtyCombo);
            this.Controls.Add(this.EduTypeCombo);
            this.Controls.Add(this.headerText2);
            this.Controls.Add(this.faIcon2);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.FacultyNumberInput);
            this.Controls.Add(this.headerText1);
            this.Controls.Add(this.StudentsDetailsBtn);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameInput);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentsDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "6";
            ((System.ComponentModel.ISupportInitialize)(this.faIcon2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.TextBoxInput FirstNameInput;
        private Components.TextBoxInput LastNameInput;
        private Components.CButton StudentsDetailsBtn;
        private Components.HeaderText headerText1;
        private Components.TextBoxInput FacultyNumberInput;
        private Components.TextBoxInput PhoneNumberInput;
        private Components.FAIcon faIcon2;
        private Components.HeaderText headerText2;
        private Components.ComboBoxInput EduTypeCombo;
        private Components.ComboBoxInput EduSpecialtyCombo;
        private Components.ComboBoxInput EduFormCombo;
        private Components.TextBoxInput EduYearInput;
        private Components.TextBoxInput EduGpaInput;
        private CheckBox EduPausedCheckbox;
    }
}