namespace StudentsManager.Forms
{
    partial class MainAppForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.faIcon9 = new StudentsManager.Components.FAIcon();
            this.faIcon8 = new StudentsManager.Components.FAIcon();
            this.faIcon7 = new StudentsManager.Components.FAIcon();
            this.faIcon6 = new StudentsManager.Components.FAIcon();
            this.DeleteSelectedRowBtn = new StudentsManager.Components.CButton();
            this.EditSelectedRowBtn = new StudentsManager.Components.CButton();
            this.AddNewRecordBtn = new StudentsManager.Components.CButton();
            this.ReadAllRecordsBtn = new StudentsManager.Components.CButton();
            this.SearchBtn = new StudentsManager.Components.CButton();
            this.headerText1 = new StudentsManager.Components.HeaderText();
            this.ToFacultyNumberInput = new StudentsManager.Components.TextBoxInput();
            this.FromFacultyNumberInput = new StudentsManager.Components.TextBoxInput();
            this.headerText5 = new StudentsManager.Components.HeaderText();
            this.headerText3 = new StudentsManager.Components.HeaderText();
            this.QuickSearchFacNumberInput = new StudentsManager.Components.TextBoxInput();
            this.headerText2 = new StudentsManager.Components.HeaderText();
            this.panel2 = new System.Windows.Forms.Panel();
            this.faIcon5 = new StudentsManager.Components.FAIcon();
            this.faIcon4 = new StudentsManager.Components.FAIcon();
            this.faIcon2 = new StudentsManager.Components.FAIcon();
            this.faIcon1 = new StudentsManager.Components.FAIcon();
            this.SelectedRowInfo = new StudentsManager.Components.HeaderText();
            this.faIcon3 = new StudentsManager.Components.FAIcon();
            this.WelcomeHeaderText = new StudentsManager.Components.HeaderText();
            this.LogOutFAIcon = new StudentsManager.Components.FAIcon();
            this.StudentsDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutFAIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.faIcon9);
            this.panel1.Controls.Add(this.faIcon8);
            this.panel1.Controls.Add(this.faIcon7);
            this.panel1.Controls.Add(this.faIcon6);
            this.panel1.Controls.Add(this.DeleteSelectedRowBtn);
            this.panel1.Controls.Add(this.EditSelectedRowBtn);
            this.panel1.Controls.Add(this.AddNewRecordBtn);
            this.panel1.Controls.Add(this.ReadAllRecordsBtn);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.headerText1);
            this.panel1.Controls.Add(this.ToFacultyNumberInput);
            this.panel1.Controls.Add(this.FromFacultyNumberInput);
            this.panel1.Controls.Add(this.headerText5);
            this.panel1.Controls.Add(this.headerText3);
            this.panel1.Controls.Add(this.QuickSearchFacNumberInput);
            this.panel1.Controls.Add(this.headerText2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel1.Size = new System.Drawing.Size(220, 681);
            this.panel1.TabIndex = 0;
            // 
            // faIcon9
            // 
            this.faIcon9.BackColor = System.Drawing.Color.Transparent;
            this.faIcon9.ColorSelected = StudentsManager.Components.Classes.ColorType.Error;
            this.faIcon9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.faIcon9.Icon = FontAwesome.Sharp.IconChar.UserTimes;
            this.faIcon9.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.faIcon9.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.faIcon9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon9.IconSize = 28;
            this.faIcon9.Location = new System.Drawing.Point(20, 621);
            this.faIcon9.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.faIcon9.Name = "faIcon9";
            this.faIcon9.SetIconSize = 28;
            this.faIcon9.Size = new System.Drawing.Size(28, 28);
            this.faIcon9.TabIndex = 26;
            this.faIcon9.TabStop = false;
            this.faIcon9.UseGdi = true;
            this.faIcon9.Click += new System.EventHandler(this.DeleteSelectedRowBtn_Click);
            // 
            // faIcon8
            // 
            this.faIcon8.BackColor = System.Drawing.Color.Transparent;
            this.faIcon8.ColorSelected = StudentsManager.Components.Classes.ColorType.Secondary;
            this.faIcon8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.faIcon8.Icon = FontAwesome.Sharp.IconChar.UserEdit;
            this.faIcon8.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.faIcon8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.faIcon8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon8.IconSize = 28;
            this.faIcon8.Location = new System.Drawing.Point(20, 569);
            this.faIcon8.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.faIcon8.Name = "faIcon8";
            this.faIcon8.SetIconSize = 28;
            this.faIcon8.Size = new System.Drawing.Size(28, 28);
            this.faIcon8.TabIndex = 26;
            this.faIcon8.TabStop = false;
            this.faIcon8.UseGdi = true;
            this.faIcon8.Click += new System.EventHandler(this.EditSelectedRowBtn_Click);
            // 
            // faIcon7
            // 
            this.faIcon7.BackColor = System.Drawing.Color.Transparent;
            this.faIcon7.ColorSelected = StudentsManager.Components.Classes.ColorType.Success;
            this.faIcon7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.faIcon7.Icon = FontAwesome.Sharp.IconChar.UserPlus;
            this.faIcon7.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.faIcon7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.faIcon7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon7.IconSize = 28;
            this.faIcon7.Location = new System.Drawing.Point(20, 517);
            this.faIcon7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.faIcon7.Name = "faIcon7";
            this.faIcon7.SetIconSize = 28;
            this.faIcon7.Size = new System.Drawing.Size(28, 28);
            this.faIcon7.TabIndex = 26;
            this.faIcon7.TabStop = false;
            this.faIcon7.UseGdi = true;
            this.faIcon7.Click += new System.EventHandler(this.AddNewRecordBtn_Click);
            // 
            // faIcon6
            // 
            this.faIcon6.BackColor = System.Drawing.Color.Transparent;
            this.faIcon6.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.faIcon6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.faIcon6.Icon = FontAwesome.Sharp.IconChar.Sync;
            this.faIcon6.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.faIcon6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.faIcon6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon6.IconSize = 28;
            this.faIcon6.Location = new System.Drawing.Point(20, 465);
            this.faIcon6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.faIcon6.Name = "faIcon6";
            this.faIcon6.SetIconSize = 28;
            this.faIcon6.Size = new System.Drawing.Size(28, 28);
            this.faIcon6.TabIndex = 26;
            this.faIcon6.TabStop = false;
            this.faIcon6.UseGdi = true;
            this.faIcon6.Click += new System.EventHandler(this.ReadAllRecordsBtn_Click);
            // 
            // DeleteSelectedRowBtn
            // 
            this.DeleteSelectedRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.DeleteSelectedRowBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Error;
            this.DeleteSelectedRowBtn.FlatAppearance.BorderSize = 0;
            this.DeleteSelectedRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedRowBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedRowBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteSelectedRowBtn.Location = new System.Drawing.Point(57, 619);
            this.DeleteSelectedRowBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.DeleteSelectedRowBtn.Name = "DeleteSelectedRowBtn";
            this.DeleteSelectedRowBtn.Size = new System.Drawing.Size(143, 32);
            this.DeleteSelectedRowBtn.TabIndex = 20;
            this.DeleteSelectedRowBtn.Text = "Delete Record";
            this.DeleteSelectedRowBtn.UseVisualStyleBackColor = false;
            this.DeleteSelectedRowBtn.Click += new System.EventHandler(this.DeleteSelectedRowBtn_Click);
            // 
            // EditSelectedRowBtn
            // 
            this.EditSelectedRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.EditSelectedRowBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Secondary;
            this.EditSelectedRowBtn.FlatAppearance.BorderSize = 0;
            this.EditSelectedRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSelectedRowBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditSelectedRowBtn.ForeColor = System.Drawing.Color.White;
            this.EditSelectedRowBtn.Location = new System.Drawing.Point(57, 567);
            this.EditSelectedRowBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EditSelectedRowBtn.Name = "EditSelectedRowBtn";
            this.EditSelectedRowBtn.Size = new System.Drawing.Size(143, 32);
            this.EditSelectedRowBtn.TabIndex = 19;
            this.EditSelectedRowBtn.Text = "Edit Record";
            this.EditSelectedRowBtn.UseVisualStyleBackColor = false;
            this.EditSelectedRowBtn.Click += new System.EventHandler(this.EditSelectedRowBtn_Click);
            // 
            // AddNewRecordBtn
            // 
            this.AddNewRecordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.AddNewRecordBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Success;
            this.AddNewRecordBtn.FlatAppearance.BorderSize = 0;
            this.AddNewRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewRecordBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewRecordBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewRecordBtn.Location = new System.Drawing.Point(57, 515);
            this.AddNewRecordBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.AddNewRecordBtn.Name = "AddNewRecordBtn";
            this.AddNewRecordBtn.Size = new System.Drawing.Size(143, 32);
            this.AddNewRecordBtn.TabIndex = 18;
            this.AddNewRecordBtn.Text = "New Record";
            this.AddNewRecordBtn.UseVisualStyleBackColor = false;
            this.AddNewRecordBtn.Click += new System.EventHandler(this.AddNewRecordBtn_Click);
            // 
            // ReadAllRecordsBtn
            // 
            this.ReadAllRecordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ReadAllRecordsBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.ReadAllRecordsBtn.FlatAppearance.BorderSize = 0;
            this.ReadAllRecordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadAllRecordsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadAllRecordsBtn.ForeColor = System.Drawing.Color.White;
            this.ReadAllRecordsBtn.Location = new System.Drawing.Point(57, 463);
            this.ReadAllRecordsBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.ReadAllRecordsBtn.Name = "ReadAllRecordsBtn";
            this.ReadAllRecordsBtn.Size = new System.Drawing.Size(143, 32);
            this.ReadAllRecordsBtn.TabIndex = 17;
            this.ReadAllRecordsBtn.Text = "Refresh Records";
            this.ReadAllRecordsBtn.UseVisualStyleBackColor = false;
            this.ReadAllRecordsBtn.Click += new System.EventHandler(this.ReadAllRecordsBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.SearchBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(110, 342);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 32);
            this.SearchBtn.TabIndex = 16;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // headerText1
            // 
            this.headerText1.Font = new System.Drawing.Font("Poppins", 10.72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText1.HeaderType = StudentsManager.Components.HeaderType.Small;
            this.headerText1.Location = new System.Drawing.Point(20, 122);
            this.headerText1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.headerText1.Name = "headerText1";
            this.headerText1.Size = new System.Drawing.Size(180, 20);
            this.headerText1.TabIndex = 15;
            this.headerText1.Text = "or";
            this.headerText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToFacultyNumberInput
            // 
            this.ToFacultyNumberInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.ToFacultyNumberInput.HeaderText = "To Faculty Number";
            this.ToFacultyNumberInput.IsPasswordField = false;
            this.ToFacultyNumberInput.Location = new System.Drawing.Point(20, 276);
            this.ToFacultyNumberInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.ToFacultyNumberInput.MaxLength = 20;
            this.ToFacultyNumberInput.Name = "ToFacultyNumberInput";
            this.ToFacultyNumberInput.ReadOnly = false;
            this.ToFacultyNumberInput.Size = new System.Drawing.Size(180, 52);
            this.ToFacultyNumberInput.TabIndex = 4;
            this.ToFacultyNumberInput.Value = "";
            // 
            // FromFacultyNumberInput
            // 
            this.FromFacultyNumberInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.FromFacultyNumberInput.HeaderText = "From Faculty Number";
            this.FromFacultyNumberInput.IsPasswordField = false;
            this.FromFacultyNumberInput.Location = new System.Drawing.Point(20, 204);
            this.FromFacultyNumberInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.FromFacultyNumberInput.MaxLength = 20;
            this.FromFacultyNumberInput.Name = "FromFacultyNumberInput";
            this.FromFacultyNumberInput.ReadOnly = false;
            this.FromFacultyNumberInput.Size = new System.Drawing.Size(180, 52);
            this.FromFacultyNumberInput.TabIndex = 3;
            this.FromFacultyNumberInput.Value = "";
            // 
            // headerText5
            // 
            this.headerText5.Font = new System.Drawing.Font("Poppins", 10.72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText5.HeaderType = StudentsManager.Components.HeaderType.Small;
            this.headerText5.Location = new System.Drawing.Point(20, 162);
            this.headerText5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText5.Name = "headerText5";
            this.headerText5.Size = new System.Drawing.Size(180, 32);
            this.headerText5.TabIndex = 12;
            this.headerText5.Text = "Search In Range";
            this.headerText5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headerText3
            // 
            this.headerText3.Font = new System.Drawing.Font("Poppins", 10.72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText3.HeaderType = StudentsManager.Components.HeaderType.Small;
            this.headerText3.Location = new System.Drawing.Point(20, 8);
            this.headerText3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText3.Name = "headerText3";
            this.headerText3.Size = new System.Drawing.Size(180, 32);
            this.headerText3.TabIndex = 9;
            this.headerText3.Text = "Quick Search";
            this.headerText3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuickSearchFacNumberInput
            // 
            this.QuickSearchFacNumberInput.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.QuickSearchFacNumberInput.HeaderText = "Faculty Number";
            this.QuickSearchFacNumberInput.IsPasswordField = false;
            this.QuickSearchFacNumberInput.Location = new System.Drawing.Point(20, 50);
            this.QuickSearchFacNumberInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.QuickSearchFacNumberInput.MaxLength = 20;
            this.QuickSearchFacNumberInput.Name = "QuickSearchFacNumberInput";
            this.QuickSearchFacNumberInput.ReadOnly = false;
            this.QuickSearchFacNumberInput.Size = new System.Drawing.Size(180, 52);
            this.QuickSearchFacNumberInput.TabIndex = 1;
            this.QuickSearchFacNumberInput.Value = "";
            // 
            // headerText2
            // 
            this.headerText2.Font = new System.Drawing.Font("Poppins", 10.72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText2.HeaderType = StudentsManager.Components.HeaderType.Small;
            this.headerText2.Location = new System.Drawing.Point(20, 421);
            this.headerText2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText2.Name = "headerText2";
            this.headerText2.Size = new System.Drawing.Size(180, 32);
            this.headerText2.TabIndex = 3;
            this.headerText2.Text = "CRUD Operations";
            this.headerText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.faIcon5);
            this.panel2.Controls.Add(this.faIcon4);
            this.panel2.Controls.Add(this.faIcon2);
            this.panel2.Controls.Add(this.faIcon1);
            this.panel2.Controls.Add(this.SelectedRowInfo);
            this.panel2.Controls.Add(this.faIcon3);
            this.panel2.Controls.Add(this.WelcomeHeaderText);
            this.panel2.Controls.Add(this.LogOutFAIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(1044, 50);
            this.panel2.TabIndex = 1;
            // 
            // faIcon5
            // 
            this.faIcon5.BackColor = System.Drawing.Color.Transparent;
            this.faIcon5.ColorSelected = StudentsManager.Components.Classes.ColorType.Secondary;
            this.faIcon5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.faIcon5.Icon = FontAwesome.Sharp.IconChar.UserEdit;
            this.faIcon5.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.faIcon5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.faIcon5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon5.IconSize = 28;
            this.faIcon5.Location = new System.Drawing.Point(851, 12);
            this.faIcon5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.faIcon5.Name = "faIcon5";
            this.faIcon5.SetIconSize = 28;
            this.faIcon5.Size = new System.Drawing.Size(28, 28);
            this.faIcon5.TabIndex = 25;
            this.faIcon5.TabStop = false;
            this.faIcon5.UseGdi = true;
            this.faIcon5.Click += new System.EventHandler(this.EditSelectedRowBtn_Click);
            // 
            // faIcon4
            // 
            this.faIcon4.BackColor = System.Drawing.Color.Transparent;
            this.faIcon4.ColorSelected = StudentsManager.Components.Classes.ColorType.Error;
            this.faIcon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.faIcon4.Icon = FontAwesome.Sharp.IconChar.UserTimes;
            this.faIcon4.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.faIcon4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.faIcon4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon4.IconSize = 28;
            this.faIcon4.Location = new System.Drawing.Point(889, 12);
            this.faIcon4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.faIcon4.Name = "faIcon4";
            this.faIcon4.SetIconSize = 28;
            this.faIcon4.Size = new System.Drawing.Size(28, 28);
            this.faIcon4.TabIndex = 24;
            this.faIcon4.TabStop = false;
            this.faIcon4.UseGdi = true;
            this.faIcon4.Click += new System.EventHandler(this.DeleteSelectedRowBtn_Click);
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
            this.faIcon2.Location = new System.Drawing.Point(813, 12);
            this.faIcon2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.faIcon2.Name = "faIcon2";
            this.faIcon2.SetIconSize = 28;
            this.faIcon2.Size = new System.Drawing.Size(28, 28);
            this.faIcon2.TabIndex = 23;
            this.faIcon2.TabStop = false;
            this.faIcon2.UseGdi = true;
            this.faIcon2.Click += new System.EventHandler(this.AddNewRecordBtn_Click);
            // 
            // faIcon1
            // 
            this.faIcon1.BackColor = System.Drawing.Color.Transparent;
            this.faIcon1.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.faIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.faIcon1.Icon = FontAwesome.Sharp.IconChar.Sync;
            this.faIcon1.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.faIcon1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.faIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon1.IconSize = 28;
            this.faIcon1.Location = new System.Drawing.Point(775, 12);
            this.faIcon1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.faIcon1.Name = "faIcon1";
            this.faIcon1.SetIconSize = 28;
            this.faIcon1.Size = new System.Drawing.Size(28, 28);
            this.faIcon1.TabIndex = 22;
            this.faIcon1.TabStop = false;
            this.faIcon1.UseGdi = true;
            this.faIcon1.Click += new System.EventHandler(this.ReadAllRecordsBtn_Click);
            // 
            // SelectedRowInfo
            // 
            this.SelectedRowInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectedRowInfo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedRowInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SelectedRowInfo.HeaderType = StudentsManager.Components.HeaderType.XSmall;
            this.SelectedRowInfo.Location = new System.Drawing.Point(310, 0);
            this.SelectedRowInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.SelectedRowInfo.Name = "SelectedRowInfo";
            this.SelectedRowInfo.Size = new System.Drawing.Size(244, 50);
            this.SelectedRowInfo.TabIndex = 21;
            this.SelectedRowInfo.Text = "or";
            this.SelectedRowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // faIcon3
            // 
            this.faIcon3.BackColor = System.Drawing.Color.Transparent;
            this.faIcon3.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.faIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.faIcon3.Icon = FontAwesome.Sharp.IconChar.UserCog;
            this.faIcon3.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.faIcon3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.faIcon3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon3.IconSize = 28;
            this.faIcon3.Location = new System.Drawing.Point(952, 12);
            this.faIcon3.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.faIcon3.Name = "faIcon3";
            this.faIcon3.SetIconSize = 28;
            this.faIcon3.Size = new System.Drawing.Size(28, 28);
            this.faIcon3.TabIndex = 6;
            this.faIcon3.TabStop = false;
            this.faIcon3.UseGdi = true;
            // 
            // WelcomeHeaderText
            // 
            this.WelcomeHeaderText.Dock = System.Windows.Forms.DockStyle.Left;
            this.WelcomeHeaderText.Font = new System.Drawing.Font("Poppins", 10.72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeHeaderText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.WelcomeHeaderText.HeaderType = StudentsManager.Components.HeaderType.Small;
            this.WelcomeHeaderText.Location = new System.Drawing.Point(20, 0);
            this.WelcomeHeaderText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.WelcomeHeaderText.Name = "WelcomeHeaderText";
            this.WelcomeHeaderText.Size = new System.Drawing.Size(290, 50);
            this.WelcomeHeaderText.TabIndex = 2;
            this.WelcomeHeaderText.Text = "Welcome back, Daniel Dimitrov";
            this.WelcomeHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogOutFAIcon
            // 
            this.LogOutFAIcon.BackColor = System.Drawing.Color.Transparent;
            this.LogOutFAIcon.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.LogOutFAIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.LogOutFAIcon.Icon = FontAwesome.Sharp.IconChar.PowerOff;
            this.LogOutFAIcon.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.LogOutFAIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.LogOutFAIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOutFAIcon.IconSize = 28;
            this.LogOutFAIcon.Location = new System.Drawing.Point(993, 12);
            this.LogOutFAIcon.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.LogOutFAIcon.Name = "LogOutFAIcon";
            this.LogOutFAIcon.SetIconSize = 28;
            this.LogOutFAIcon.Size = new System.Drawing.Size(28, 28);
            this.LogOutFAIcon.TabIndex = 4;
            this.LogOutFAIcon.TabStop = false;
            this.LogOutFAIcon.UseGdi = true;
            this.LogOutFAIcon.Click += new System.EventHandler(this.LogOutFAIcon_Click);
            // 
            // StudentsDataGrid
            // 
            this.StudentsDataGrid.AllowUserToAddRows = false;
            this.StudentsDataGrid.AllowUserToDeleteRows = false;
            this.StudentsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.StudentsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsDataGrid.GridColor = System.Drawing.Color.White;
            this.StudentsDataGrid.Location = new System.Drawing.Point(220, 50);
            this.StudentsDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.StudentsDataGrid.MultiSelect = false;
            this.StudentsDataGrid.Name = "StudentsDataGrid";
            this.StudentsDataGrid.ReadOnly = true;
            this.StudentsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StudentsDataGrid.RowTemplate.Height = 25;
            this.StudentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDataGrid.Size = new System.Drawing.Size(1044, 631);
            this.StudentsDataGrid.StandardTab = true;
            this.StudentsDataGrid.TabIndex = 10;
            this.StudentsDataGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.StudentsDataGrid_RowStateChanged);
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.StudentsDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainAppForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAppForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAppForm_FormClosed);
            this.Load += new System.EventHandler(this.MainAppForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faIcon9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon6)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutFAIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Components.HeaderText WelcomeHeaderText;
        private Components.HeaderText headerText2;
        private Components.FAIcon LogOutFAIcon;
        private Components.HeaderText headerText3;
        private Components.TextBoxInput QuickSearchFacNumberInput;
        private Components.FAIcon faIcon3;
        private DataGridView StudentsDataGrid;
        private Components.TextBoxInput ToFacultyNumberInput;
        private Components.TextBoxInput FromFacultyNumberInput;
        private Components.HeaderText headerText5;
        private Components.CButton SearchBtn;
        private Components.HeaderText headerText1;
        private Components.CButton ReadAllRecordsBtn;
        private Components.CButton AddNewRecordBtn;
        private Components.CButton EditSelectedRowBtn;
        private Components.CButton DeleteSelectedRowBtn;
        private Components.HeaderText SelectedRowInfo;
        private Components.FAIcon faIcon1;
        private Components.FAIcon faIcon2;
        private Components.FAIcon faIcon9;
        private Components.FAIcon faIcon8;
        private Components.FAIcon faIcon7;
        private Components.FAIcon faIcon6;
        private Components.FAIcon faIcon5;
        private Components.FAIcon faIcon4;
    }
}