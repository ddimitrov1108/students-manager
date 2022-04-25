using StudentsManager.Classes;
using System.Data;

namespace StudentsManager.Components
{
    public class ComboBoxInput : InputGroup
    {
        private ComboBox comboInput;

        public ComboBoxInput() : base()
        {
            this.comboInput = new ComboBox();
            this.comboInput.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboInput.FlatStyle = FlatStyle.Flat;
            this.comboInput.Font = new Font("Poppins", 10);
            this.comboInput.ForeColor = ColorCollection.Black;
            this.comboInput.Dock = DockStyle.Fill;
            this.comboInput.GotFocus += new EventHandler((s, e) => base.initFocus());
            this.comboInput.LostFocus += new EventHandler((s, e) => base.removeFocus());
            this.comboInput.DropDownWidth = this.comboInput.Width;
            this.Controls.Add(this.comboInput);
            base.initControls();
        }

        public void InputFocus() => this.comboInput.Focus();

        public override string Text { get => this.comboInput.Text; }
        public string? Value { get => this.comboInput.SelectedValue.ToString(); }

        public void SetActiveItem(string? listItem)
        {
            if (listItem != null)
                this.comboInput.SelectedIndex = this.comboInput.FindStringExact(listItem);
        }

        public void SetListItems(DataTable table, string valueMember, string displayMember)
        {
            this.comboInput.DataSource = table;
            this.comboInput.ValueMember = valueMember;
            this.comboInput.DisplayMember = displayMember;
        }

        public void AddItem(string item) => this.comboInput.Items.Add(item);

    }
}
