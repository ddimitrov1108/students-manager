using StudentsManager.Classes;

namespace StudentsManager.Components
{
    public class InputGroup : Panel
    {
        protected Label inputGroupHeader;
        protected Panel horizontalLine;

        public InputGroup()
        {
            this.inputGroupHeader = new Label();
            this.inputGroupHeader.Text = "text";
            this.inputGroupHeader.FlatStyle = FlatStyle.System;
            this.inputGroupHeader.AutoSize = false;
            this.inputGroupHeader.Size = new Size(160, 21);
            this.inputGroupHeader.ForeColor = ColorCollection.Gray;
            this.inputGroupHeader.Font = new Font("Poppins", 10, FontStyle.Bold);
            this.inputGroupHeader.Dock = DockStyle.Top;

            this.horizontalLine = new Panel();
            this.horizontalLine.Size = new Size(160, 2);
            this.horizontalLine.BackColor = ColorCollection.LightGray;
            this.horizontalLine.Dock = DockStyle.Bottom;

            this.Size = new Size(160, 52);
            this.Margin = new Padding(0, 0, 0, 20);
        }

        protected void initControls()
        {
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.inputGroupHeader);
        }

        public string HeaderText
        {
            get => this.inputGroupHeader.Text;
            set => this.inputGroupHeader.Text = value;
        }
    }
}
