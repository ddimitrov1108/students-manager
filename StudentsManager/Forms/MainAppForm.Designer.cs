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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cButton4 = new StudentsManager.Components.CButton();
            this.textBoxInput3 = new StudentsManager.Components.TextBoxInput();
            this.textBoxInput2 = new StudentsManager.Components.TextBoxInput();
            this.headerText5 = new StudentsManager.Components.HeaderText();
            this.SearchBtn = new StudentsManager.Components.CButton();
            this.headerText3 = new StudentsManager.Components.HeaderText();
            this.ReadAllRecordsBtn = new StudentsManager.Components.CButton();
            this.textBoxInput1 = new StudentsManager.Components.TextBoxInput();
            this.AddNewRecordBtn = new StudentsManager.Components.CButton();
            this.DeleteSelectedRowBtn = new StudentsManager.Components.CButton();
            this.headerText2 = new StudentsManager.Components.HeaderText();
            this.EditSelectedRowBtn = new StudentsManager.Components.CButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.faIcon3 = new StudentsManager.Components.FAIcon();
            this.headerText1 = new StudentsManager.Components.HeaderText();
            this.faIcon2 = new StudentsManager.Components.FAIcon();
            this.StudentsDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cButton4);
            this.panel1.Controls.Add(this.textBoxInput3);
            this.panel1.Controls.Add(this.textBoxInput2);
            this.panel1.Controls.Add(this.headerText5);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.headerText3);
            this.panel1.Controls.Add(this.ReadAllRecordsBtn);
            this.panel1.Controls.Add(this.textBoxInput1);
            this.panel1.Controls.Add(this.AddNewRecordBtn);
            this.panel1.Controls.Add(this.DeleteSelectedRowBtn);
            this.panel1.Controls.Add(this.headerText2);
            this.panel1.Controls.Add(this.EditSelectedRowBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel1.Size = new System.Drawing.Size(220, 681);
            this.panel1.TabIndex = 0;
            // 
            // cButton4
            // 
            this.cButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.cButton4.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.cButton4.FlatAppearance.BorderSize = 0;
            this.cButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton4.ForeColor = System.Drawing.Color.White;
            this.cButton4.Location = new System.Drawing.Point(100, 122);
            this.cButton4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.cButton4.Name = "cButton4";
            this.cButton4.Size = new System.Drawing.Size(100, 32);
            this.cButton4.TabIndex = 2;
            this.cButton4.Text = "Search";
            this.cButton4.UseVisualStyleBackColor = false;
            // 
            // textBoxInput3
            // 
            this.textBoxInput3.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.textBoxInput3.HeaderText = "To Faculty Number";
            this.textBoxInput3.IsPasswordField = false;
            this.textBoxInput3.Location = new System.Drawing.Point(20, 288);
            this.textBoxInput3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxInput3.MaxLength = 20;
            this.textBoxInput3.Name = "textBoxInput3";
            this.textBoxInput3.Size = new System.Drawing.Size(180, 52);
            this.textBoxInput3.TabIndex = 4;
            this.textBoxInput3.Value = "";
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.textBoxInput2.HeaderText = "From Faculty Number";
            this.textBoxInput2.IsPasswordField = false;
            this.textBoxInput2.Location = new System.Drawing.Point(20, 216);
            this.textBoxInput2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxInput2.MaxLength = 20;
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(180, 52);
            this.textBoxInput2.TabIndex = 3;
            this.textBoxInput2.Value = "";
            // 
            // headerText5
            // 
            this.headerText5.Font = new System.Drawing.Font("Poppins", 10.72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText5.HeaderType = StudentsManager.Components.HeaderType.Small;
            this.headerText5.Location = new System.Drawing.Point(20, 174);
            this.headerText5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText5.Name = "headerText5";
            this.headerText5.Size = new System.Drawing.Size(180, 32);
            this.headerText5.TabIndex = 12;
            this.headerText5.Text = "Search In Range";
            this.headerText5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.SearchBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(100, 360);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 32);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
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
            // ReadAllRecordsBtn
            // 
            this.ReadAllRecordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ReadAllRecordsBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.ReadAllRecordsBtn.FlatAppearance.BorderSize = 0;
            this.ReadAllRecordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadAllRecordsBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadAllRecordsBtn.ForeColor = System.Drawing.Color.White;
            this.ReadAllRecordsBtn.Location = new System.Drawing.Point(20, 464);
            this.ReadAllRecordsBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.ReadAllRecordsBtn.Name = "ReadAllRecordsBtn";
            this.ReadAllRecordsBtn.Size = new System.Drawing.Size(180, 32);
            this.ReadAllRecordsBtn.TabIndex = 6;
            this.ReadAllRecordsBtn.Text = "Read All Records";
            this.ReadAllRecordsBtn.UseVisualStyleBackColor = false;
            this.ReadAllRecordsBtn.Click += new System.EventHandler(this.ReadAllRecordsBtn_Click);
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.textBoxInput1.HeaderText = "Faculty Number";
            this.textBoxInput1.IsPasswordField = false;
            this.textBoxInput1.Location = new System.Drawing.Point(20, 50);
            this.textBoxInput1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxInput1.MaxLength = 20;
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(180, 52);
            this.textBoxInput1.TabIndex = 1;
            this.textBoxInput1.Value = "";
            // 
            // AddNewRecordBtn
            // 
            this.AddNewRecordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.AddNewRecordBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Success;
            this.AddNewRecordBtn.FlatAppearance.BorderSize = 0;
            this.AddNewRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewRecordBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewRecordBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewRecordBtn.Location = new System.Drawing.Point(20, 516);
            this.AddNewRecordBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.AddNewRecordBtn.Name = "AddNewRecordBtn";
            this.AddNewRecordBtn.Size = new System.Drawing.Size(180, 32);
            this.AddNewRecordBtn.TabIndex = 7;
            this.AddNewRecordBtn.Text = "New Record";
            this.AddNewRecordBtn.UseVisualStyleBackColor = false;
            this.AddNewRecordBtn.Click += new System.EventHandler(this.AddNewRecordBtn_Click);
            // 
            // DeleteSelectedRowBtn
            // 
            this.DeleteSelectedRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.DeleteSelectedRowBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Error;
            this.DeleteSelectedRowBtn.FlatAppearance.BorderSize = 0;
            this.DeleteSelectedRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedRowBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedRowBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteSelectedRowBtn.Location = new System.Drawing.Point(20, 620);
            this.DeleteSelectedRowBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.DeleteSelectedRowBtn.Name = "DeleteSelectedRowBtn";
            this.DeleteSelectedRowBtn.Size = new System.Drawing.Size(180, 32);
            this.DeleteSelectedRowBtn.TabIndex = 9;
            this.DeleteSelectedRowBtn.Text = "Delete Selected Record";
            this.DeleteSelectedRowBtn.UseVisualStyleBackColor = false;
            this.DeleteSelectedRowBtn.Click += new System.EventHandler(this.DeleteSelectedRowBtn_Click);
            // 
            // headerText2
            // 
            this.headerText2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText2.HeaderType = StudentsManager.Components.HeaderType.XSmall;
            this.headerText2.Location = new System.Drawing.Point(20, 422);
            this.headerText2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText2.Name = "headerText2";
            this.headerText2.Size = new System.Drawing.Size(180, 32);
            this.headerText2.TabIndex = 3;
            this.headerText2.Text = "CRUD Operations";
            this.headerText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditSelectedRowBtn
            // 
            this.EditSelectedRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.EditSelectedRowBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Secondary;
            this.EditSelectedRowBtn.FlatAppearance.BorderSize = 0;
            this.EditSelectedRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSelectedRowBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditSelectedRowBtn.ForeColor = System.Drawing.Color.White;
            this.EditSelectedRowBtn.Location = new System.Drawing.Point(20, 568);
            this.EditSelectedRowBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EditSelectedRowBtn.Name = "EditSelectedRowBtn";
            this.EditSelectedRowBtn.Size = new System.Drawing.Size(180, 32);
            this.EditSelectedRowBtn.TabIndex = 8;
            this.EditSelectedRowBtn.Text = "Edit Selected Record";
            this.EditSelectedRowBtn.UseVisualStyleBackColor = false;
            this.EditSelectedRowBtn.Click += new System.EventHandler(this.EditSelectedRowBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.faIcon3);
            this.panel2.Controls.Add(this.headerText1);
            this.panel2.Controls.Add(this.faIcon2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(1044, 50);
            this.panel2.TabIndex = 1;
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
            this.faIcon3.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.faIcon3.Name = "faIcon3";
            this.faIcon3.SetIconSize = 28;
            this.faIcon3.Size = new System.Drawing.Size(28, 28);
            this.faIcon3.TabIndex = 6;
            this.faIcon3.TabStop = false;
            this.faIcon3.UseGdi = true;
            // 
            // headerText1
            // 
            this.headerText1.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerText1.Font = new System.Drawing.Font("Poppins", 10.72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.headerText1.HeaderType = StudentsManager.Components.HeaderType.Small;
            this.headerText1.Location = new System.Drawing.Point(20, 0);
            this.headerText1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerText1.Name = "headerText1";
            this.headerText1.Size = new System.Drawing.Size(320, 50);
            this.headerText1.TabIndex = 2;
            this.headerText1.Text = "Welcome back, Daniel Dimitrov";
            this.headerText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // faIcon2
            // 
            this.faIcon2.BackColor = System.Drawing.Color.Transparent;
            this.faIcon2.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.faIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.faIcon2.Icon = FontAwesome.Sharp.IconChar.PowerOff;
            this.faIcon2.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.faIcon2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.faIcon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faIcon2.IconSize = 28;
            this.faIcon2.Location = new System.Drawing.Point(993, 12);
            this.faIcon2.Name = "faIcon2";
            this.faIcon2.SetIconSize = 28;
            this.faIcon2.Size = new System.Drawing.Size(28, 28);
            this.faIcon2.TabIndex = 4;
            this.faIcon2.TabStop = false;
            this.faIcon2.UseGdi = true;
            // 
            // StudentsDataGrid
            // 
            this.StudentsDataGrid.AllowUserToAddRows = false;
            this.StudentsDataGrid.AllowUserToDeleteRows = false;
            this.StudentsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.StudentsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.StudentsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.StudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.StudentsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsDataGrid.GridColor = System.Drawing.Color.White;
            this.StudentsDataGrid.Location = new System.Drawing.Point(220, 50);
            this.StudentsDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.StudentsDataGrid.MultiSelect = false;
            this.StudentsDataGrid.Name = "StudentsDataGrid";
            this.StudentsDataGrid.ReadOnly = true;
            this.StudentsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.StudentsDataGrid.RowTemplate.Height = 25;
            this.StudentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDataGrid.Size = new System.Drawing.Size(1044, 631);
            this.StudentsDataGrid.StandardTab = true;
            this.StudentsDataGrid.TabIndex = 10;
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Components.HeaderText headerText1;
        private Components.HeaderText headerText2;
        private Components.FAIcon faIcon2;
        private Components.HeaderText headerText3;
        private Components.CButton ReadAllRecordsBtn;
        private Components.CButton DeleteSelectedRowBtn;
        private Components.TextBoxInput textBoxInput1;
        private Components.CButton EditSelectedRowBtn;
        private Components.CButton AddNewRecordBtn;
        private Components.FAIcon faIcon3;
        private DataGridView StudentsDataGrid;
        private Components.CButton SearchBtn;
        private Components.TextBoxInput textBoxInput3;
        private Components.TextBoxInput textBoxInput2;
        private Components.HeaderText headerText5;
        private Components.CButton cButton4;
    }
}