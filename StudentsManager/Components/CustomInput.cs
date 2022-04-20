using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager.Components
{
    public partial class CustomInput : Component
    {
        public CustomInput()
        {
            InitializeComponent();
        }

        public CustomInput(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
