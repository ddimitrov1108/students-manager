using FontAwesome.Sharp;
using StudentsManager.Classes;
using StudentsManager.Components.Classes;

namespace StudentsManager.Components
{
    public class FAIcon : IconPictureBox, ColorTypeSelection
    {
        private ColorType colorType;

        public FAIcon()
        {
            this.IconChar = IconChar.Times;
            this.IconSize = 28;
            init();
        }

        public FAIcon(IconChar iconChar)
        {
            this.IconChar = iconChar;
            this.IconSize = 28;
            init();
        }

        public FAIcon(IconChar iconChar, int iconSize)
        {
            this.IconChar = iconChar;
            this.IconSize = iconSize;
            init();
        }

        private void init()
        {
            this.colorType = ColorType.Primary;
            this.Cursor = Cursors.Hand;
            this.UseGdi = true;
            this.ForeColor = ColorCollection.Primary;
            this.BackColor = Color.Transparent;
            //this.MouseEnter += new EventHandler((sender, eventArgs) => this.ForeColor = ColorPallete.Gray);
            //this.MouseLeave += new EventHandler((sender, eventArgs) => this.ForeColor = ColorPallete.Black);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            this.PaintSelectedColorType();
        }

        public void addClickEvent(EventHandler clickEvent)
        {
            this.Click += clickEvent;
        }

        public void PaintSelectedColorType()
        {
            switch (this.colorType)
            {
                default: case ColorType.Primary: this.IconColor = ColorCollection.Primary; break;
                case ColorType.Secondary: this.IconColor = ColorCollection.LightBlue; break;
                case ColorType.Success: this.IconColor = ColorCollection.Green; break;
                case ColorType.Error: this.IconColor = ColorCollection.Tomato; break;
            }
        }

        public ColorType ColorSelected
        {
            get => this.colorType;
            set
            {
                this.colorType = value;
                this.Invalidate();
            }
        }

        public IconChar Icon
        {
            get { return this.IconChar; }
            set
            {
                this.IconChar = value;
                this.Invalidate();
            }
        }

        public int SetIconSize
        {
            get { return this.IconSize; }
            set
            {
                this.IconSize = value;
                this.Size = new Size(value, value);
                this.Invalidate();
            }
        }
    }
}
