using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika.AppDataTableAdapters;

namespace Praktika
{
    public partial class frm_grades : Form
    {
        public frm_grades()
        {
            InitializeComponent();
        }
        private void Edit(bool value)
        {
            txt_namegrade.Enabled = value;
            txt_passgrade.Enabled = value;
            cb_subject.Enabled = value;
            txt_grade.Enabled = value;
        }
        private void dgv_grades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_grades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student.tblstudent' table. You can move, or remove it, as needed.
            this.tblstudentTableAdapter.Fill(this.student.tblstudent);
            Edit(false);
        }
        

        private void txt_namegrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_passgrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_grade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addgrade_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Edit(true);
                    student.tblstudent.AddtblstudentRow(student.tblstudent.NewtblstudentRow());
                    studentbinding.MoveLast();
                    txt_namegrade.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    student.tblstudent.RejectChanges();
                }
            }
        }

        private void btn_editgrade_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_namegrade.Focus();
        }

        private void btn_savegrade_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                studentbinding.EndEdit();
                tblstudentTableAdapter.Update(student.tblstudent);
                dgv_grades.Refresh();
                txt_namegrade.Focus();
                MessageBox.Show("Jūsų duomenys sėkmingai išsaugoti.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                student.tblstudent.RejectChanges();
            }
        }

        private void btn_deletegrade_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite ištrinti?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                studentbinding.RemoveCurrent();
            }
        }
    }
}