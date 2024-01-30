using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Praktika
{
    public partial class frm_login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.uaDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public frm_login()
        {
            InitializeComponent();
        }

        string log;
        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE Username='"+txt_Username.Text+"' and Password='"+txt_Password.Text+"'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[3].ToString() == "Admin")
                {
                    ulog.type = "A";
                }
                else if (dr[3].ToString() == "Destytojas")
                {
                    ulog.type = "D";
                }
                else if (dr[3].ToString() == "Studentas")
                {
                    ulog.type = "S";
                }
                log = "Sveiki: " + txt_Username.Text;
                this.Hide();
                frm_home fh = new frm_home(log);
                fh.Show();
            }
            else
            {
                MessageBox.Show("Neteisingas vartotojo vardas arba slaptažodis", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
