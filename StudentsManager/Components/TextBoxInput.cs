using StudentsManager.Classes;

namespace StudentsManager.Components
{
    public class TextBoxInput : InputGroup
    {
        private TextBox textInput;
        private bool isPasswordField;

        public TextBoxInput() : base()
        {
            this.textInput = new TextBox();
            this.textInput.Font = new Font("Poppins", 12);
            this.textInput.ForeColor = ColorCollection.Black;
            this.textInput.MaxLength = 20;
            this.textInput.BorderStyle = BorderStyle.None;
            this.textInput.Dock = DockStyle.Fill;
            this.textInput.GotFocus += new EventHandler((s, e) => base.PaintSelectedColorType());
            this.textInput.LostFocus += new EventHandler((s, e) => base.removeFocus());
            this.isPasswordField = false;
            this.Controls.Add(this.textInput);
            base.initControls();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (isPasswordField)
            {
                this.textInput.PasswordChar = '•';
            }
            else
            {
                this.textInput.PasswordChar = '\0';
            }
        }

        public void InputFocus() => this.textInput.Focus();

        public string Value
        {
            get => this.textInput.Text;
            set => this.textInput.Text = value;
        }

        public int MaxLength
        {
            get => this.textInput.MaxLength;
            set => this.textInput.MaxLength = value;
        }

        public bool IsPasswordField
        {
            get => this.isPasswordField;
            set
            {
                this.isPasswordField = value;
                this.Invalidate();
            }
        }

        public bool ReadOnly 
        {
            get => this.textInput.ReadOnly;
            set => this.textInput.ReadOnly = value; 
        }
    }
}
