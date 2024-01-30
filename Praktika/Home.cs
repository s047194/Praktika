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
    public partial class frm_home : Form
    {
        public frm_home(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }

        private void btn_adduseradmin_Click(object sender, EventArgs e)
        {
            frm_add_user fau = new frm_add_user();
            fau.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login fl = new frm_login();
            fl.Show();
            this.Hide();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            if(ulog.type == "A")
            {
                btn_adduseradmin.Visible = true;
                btn_grades.Visible = true;
                btn_student.Visible = true;
                btn_sgrades.Visible = false;
            }
            else if(ulog.type == "D")
            {
                btn_adduseradmin.Visible = false;
                btn_grades.Visible = true;
                btn_student.Visible = true;
                btn_sgrades.Visible = false;
            }
            else if (ulog.type == "S")
            {
                btn_adduseradmin.Visible = false;
                btn_grades.Visible = false;
                btn_student.Visible = false;
                btn_sgrades.Visible = true;
            }
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            frm_student fs = new frm_student();
            fs.ShowDialog();
        }

        private void btn_grades_Click(object sender, EventArgs e)
        {
            frm_grades fg = new frm_grades();
            fg.ShowDialog();
        }

        private void btn_sgrades_Click(object sender, EventArgs e)
        {
            frm_sgrades sg = new frm_sgrades();
            sg.ShowDialog();
        }
    }
}
