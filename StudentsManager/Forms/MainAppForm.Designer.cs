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
            this.cButton4 = new StudentsManager.Components.CButton();
            this.textBoxInput3 = new StudentsManager.Components.TextBoxInput();
            this.textBoxInput2 = new StudentsManager.Components.TextBoxInput();
            this.headerText5 = new StudentsManager.Components.HeaderText();
            this.SearchBtn = new StudentsManager.Components.CButton();
            this.headerText3 = new StudentsManager.Components.HeaderText();
            this.cButton3 = new StudentsManager.Components.CButton();
            this.textBoxInput1 = new StudentsManager.Components.TextBoxInput();
            this.AddRecordBtn = new StudentsManager.Components.CButton();
            this.cButton2 = new StudentsManager.Components.CButton();
            this.headerText2 = new StudentsManager.Components.HeaderText();
            this.cButton1 = new StudentsManager.Components.CButton();
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
            this.panel1.Controls.Add(this.cButton3);
            this.panel1.Controls.Add(this.textBoxInput1);
            this.panel1.Controls.Add(this.AddRecordBtn);
            this.panel1.Controls.Add(this.cButton2);
            this.panel1.Controls.Add(this.headerText2);
            this.panel1.Controls.Add(this.cButton1);
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
            // cButton3
            // 
            this.cButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.cButton3.ColorSelected = StudentsManager.Components.Classes.ColorType.Secondary;
            this.cButton3.FlatAppearance.BorderSize = 0;
            this.cButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton3.ForeColor = System.Drawing.Color.White;
            this.cButton3.Location = new System.Drawing.Point(20, 464);
            this.cButton3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.cButton3.Name = "cButton3";
            this.cButton3.Size = new System.Drawing.Size(180, 32);
            this.cButton3.TabIndex = 6;
            this.cButton3.Text = "Read All Records";
            this.cButton3.UseVisualStyleBackColor = false;
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
            // AddRecordBtn
            // 
            this.AddRecordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.AddRecordBtn.ColorSelected = StudentsManager.Components.Classes.ColorType.Success;
            this.AddRecordBtn.FlatAppearance.BorderSize = 0;
            this.AddRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddRecordBtn.ForeColor = System.Drawing.Color.White;
            this.AddRecordBtn.Location = new System.Drawing.Point(20, 516);
            this.AddRecordBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.AddRecordBtn.Name = "AddRecordBtn";
            this.AddRecordBtn.Size = new System.Drawing.Size(180, 32);
            this.AddRecordBtn.TabIndex = 7;
            this.AddRecordBtn.Text = "New Record";
            this.AddRecordBtn.UseVisualStyleBackColor = false;
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.cButton2.ColorSelected = StudentsManager.Components.Classes.ColorType.Error;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.Location = new System.Drawing.Point(20, 620);
            this.cButton2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(180, 32);
            this.cButton2.TabIndex = 9;
            this.cButton2.Text = "Delete Selected Record";
            this.cButton2.UseVisualStyleBackColor = false;
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
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.cButton1.ColorSelected = StudentsManager.Components.Classes.ColorType.Primary;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.Location = new System.Drawing.Point(20, 568);
            this.cButton1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(180, 32);
            this.cButton1.TabIndex = 8;
            this.cButton1.Text = "Edit Selected Record";
            this.cButton1.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.StudentsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
        private Components.CButton cButton3;
        private Components.CButton cButton2;
        private Components.TextBoxInput textBoxInput1;
        private Components.CButton cButton1;
        private Components.CButton AddRecordBtn;
        private Components.FAIcon faIcon3;
        private DataGridView StudentsDataGrid;
        private Components.CButton SearchBtn;
        private Components.TextBoxInput textBoxInput3;
        private Components.TextBoxInput textBoxInput2;
        private Components.HeaderText headerText5;
        private Components.CButton cButton4;
    }
}