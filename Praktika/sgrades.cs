using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class frm_sgrades : Form
    {
        public frm_sgrades()
        {
            InitializeComponent();
        }

        private void frm_sgrades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student.tblstudent' table. You can move, or remove it, as needed.
            this.tblstudentTableAdapter.Fill(this.student.tblstudent);

        }

        private void tblstudentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
