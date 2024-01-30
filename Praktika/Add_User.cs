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
    public partial class frm_add_user : Form
    {
        public frm_add_user()
        {
            InitializeComponent();
        }

        private void frm_add_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);
        }

        private void Edit(bool value)
        {
            txt_username.Enabled = value;
            txt_password.Enabled = value;
            cb_role.Enabled = value;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tbllog.AddtbllogRow(appData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txt_username.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_username.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(appData.tbllog);
                dgv_adminuser.Refresh();
                txt_username.Focus();
                MessageBox.Show("Jūsų duomenys sėkmingai išsaugoti.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite ištrinti?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void dgv_adminuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbllogBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
