using StudentsManager.Classes;

namespace StudentsManager.Components
{
    public class InputGroup : Panel
    {
        private ColorType colorType;
        private Label inputGroupHeader;
        private Panel horizontalLine;

        public InputGroup()
        {
            this.colorType = ColorType.Primary;
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

        protected void initFocus()
        {
            switch (this.colorType)
            {
                default:
                case ColorType.Primary:
                        this.horizontalLine.BackColor = ColorCollection.Primary;
                        this.inputGroupHeader.ForeColor = ColorCollection.Primary;
                    break;
                case ColorType.Secondary:
                        this.horizontalLine.BackColor = ColorCollection.LightBlue;
                        this.inputGroupHeader.ForeColor = ColorCollection.LightBlue;
                    break;
                case ColorType.Success:
                        this.horizontalLine.BackColor = ColorCollection.Green;
                        this.inputGroupHeader.ForeColor = ColorCollection.Green;
                    break;
                case ColorType.Error:
                        this.horizontalLine.BackColor = ColorCollection.Tomato;
                        this.inputGroupHeader.ForeColor = ColorCollection.Tomato;
                    break;
            }
        }

        protected void removeFocus()
        {
            this.horizontalLine.BackColor = ColorCollection.LightGray;
            this.inputGroupHeader.ForeColor = ColorCollection.Gray;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }

        public string HeaderText
        {
            get => this.inputGroupHeader.Text;
            set => this.inputGroupHeader.Text = value;
        }

        public ColorType ColorType
        {
            get => this.colorType;
            set
            {
                this.colorType = value;
                this.Invalidate();
            }
        }
    }
}