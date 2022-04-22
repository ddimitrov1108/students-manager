﻿using StudentsManager.Classes;
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
            this.comboInput.Font = new Font("Poppins", 12);
            this.comboInput.ForeColor = ColorCollection.Black;
            this.comboInput.Dock = DockStyle.Fill;
            this.comboInput.GotFocus += new EventHandler((s, e) => {
                base.horizontalLine.BackColor = ColorCollection.Primary;
                base.inputGroupHeader.ForeColor = ColorCollection.Primary;
            });
            this.comboInput.LostFocus += new EventHandler((s, e) => {
                base.horizontalLine.BackColor = ColorCollection.LightGray;
                base.inputGroupHeader.ForeColor = ColorCollection.Gray;
            });
            this.comboInput.DropDownWidth = this.comboInput.Width;

            this.Controls.Add(this.comboInput);
            base.initControls();
        }

        public void InputFocus() => this.comboInput.Focus();

        public override string Text { get => this.comboInput.Text; }
        public string? Value { get => this.comboInput.SelectedValue.ToString(); }

        public void setActiveItem(string? listItem)
        {
            if (listItem != null)
                this.comboInput.SelectedIndex = this.comboInput.FindStringExact(listItem);
        }

        public void setListItems(DataTable table, string valueMember, string displayMember)
        {
            this.comboInput.DataSource = table;
            this.comboInput.ValueMember = valueMember;
            this.comboInput.DisplayMember = displayMember;
        }

    }
}