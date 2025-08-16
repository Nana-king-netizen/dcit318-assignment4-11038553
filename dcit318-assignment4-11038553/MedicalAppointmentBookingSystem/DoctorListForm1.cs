using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MedicalAppointmentBookingSystem
{
    public partial class DoctorListForm1 : Form
    {
        public DoctorListForm1()
        {
            InitializeComponent();
            LoadDoctors();


        }
        private void LoadDoctors()
        {
            string connString = ConfigurationManager.ConnectionStrings["MedicalDbConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT DoctorID, FullName, Specialty, Availability FROM Doctors";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    var dt = new System.Data.DataTable();
                    dt.Load(reader);
                    dgvDoctors.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading doctors: {ex.Message}");
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDoctors();

        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDoctors();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new DoctorListForm1().Close();

        }
    }
}

