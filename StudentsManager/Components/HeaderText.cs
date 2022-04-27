using StudentsManager.Classes;

namespace StudentsManager.Components
{
    public enum HeaderType { XSmall, Small, Normal, Large, XLarge }
    public class HeaderText : Label
    {
        private HeaderType headerType;
        public HeaderText()
        {
            this.headerType = HeaderType.Normal;
            this.Font = new Font("Poppins", 9, FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ForeColor = ColorCollection.Black;
            this.Margin = new Padding(0, 0, 0, 10);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            switch (this.headerType)
            {
                case HeaderType.XSmall: this.Font = new Font("Poppins", 9.75f, FontStyle.Bold); break;
                case HeaderType.Small: this.Font = new Font("Poppins", 10.72f, FontStyle.Bold); break; 
                case HeaderType.Normal: this.Font = new Font("Poppins", 13.28f, FontStyle.Bold); break; 
                case HeaderType.Large: this.Font = new Font("Poppins", 16, FontStyle.Bold); break;
                case HeaderType.XLarge: this.Font = new Font("Poppins", 18.72f, FontStyle.Bold); break;
            }
        }

        public HeaderType HeaderType
        {
            get => this.headerType;
            set {
                this.headerType = value;
                this.Invalidate();
            }
        }
    }
}
