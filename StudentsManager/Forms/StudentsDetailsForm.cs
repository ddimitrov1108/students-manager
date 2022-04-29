using StudentsManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManager.Forms
{
    public partial class StudentsDetailsForm : Form
    {
        public StudentsDetailsForm(StudentsList studentsCollection, int edit = 0, int editIndex = -1)
        {
            InitializeComponent();
        }
    }
}
