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
            this.textBoxInput1 = new StudentsManager.Components.TextBoxInput();
            this.comboBoxInput1 = new StudentsManager.Components.ComboBoxInput();
            this.SuspendLayout();
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.ColorType = StudentsManager.Classes.ColorType.Primary;
            this.textBoxInput1.HeaderText = "text";
            this.textBoxInput1.IsPasswordField = false;
            this.textBoxInput1.Location = new System.Drawing.Point(204, 285);
            this.textBoxInput1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxInput1.MaxLength = 20;
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(160, 52);
            this.textBoxInput1.TabIndex = 0;
            this.textBoxInput1.Value = "";
            // 
            // comboBoxInput1
            // 
            this.comboBoxInput1.ColorType = StudentsManager.Classes.ColorType.Primary;
            this.comboBoxInput1.HeaderText = "text";
            this.comboBoxInput1.Location = new System.Drawing.Point(396, 285);
            this.comboBoxInput1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.comboBoxInput1.Name = "comboBoxInput1";
            this.comboBoxInput1.Size = new System.Drawing.Size(160, 52);
            this.comboBoxInput1.TabIndex = 1;
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.comboBoxInput1);
            this.Controls.Add(this.textBoxInput1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainAppForm";
            this.Text = "MainAppForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAppForm_FormClosed);
            this.Load += new System.EventHandler(this.MainAppForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.TextBoxInput textBoxInput1;
        private Components.ComboBoxInput comboBoxInput1;
    }
}