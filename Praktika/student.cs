using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class frm_student : Form
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.uaDBConnectionString);
        private DataTable dataTable = new DataTable();
        public frm_student()
        {
            InitializeComponent();
        }
        private void frm_student_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                connection.Open();

                // Retrieve data from database
                string query = "SELECT Username, Password AS Pavardė FROM dbo.tbllog WHERE Role = 'Studentas'";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Clear existing data
                    dataTable.Clear();

                    // Fill data into the DataTable
                    adapter.Fill(dataTable);
                    // Bind data to DataGridView
                    dgv_student.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dgv_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_student.DataSource = dataTable;
            // Code for DataGridView cell content click event, if needed
        }
    }
}
