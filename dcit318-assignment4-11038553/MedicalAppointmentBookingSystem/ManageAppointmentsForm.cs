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
    public partial class ManageAppointmentsForm : Form
    {
        private readonly string connStr = ConfigurationManager.ConnectionStrings["MedicalDbConn"].ConnectionString;
        private DataTable appointmentsTable;
        public ManageAppointmentsForm()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT AppointmentID, DoctorID, PatientID, AppointmentDate, Notes FROM Appointments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                appointmentsTable = new DataTable();
                adapter.Fill(appointmentsTable);
                dgvAppointments.DataSource = appointmentsTable;
            }
        }

        private void btnUpate_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0) return;

            var row = dgvAppointments.SelectedRows[0];
            int appointmentId = (int)row.Cells["AppointmentID"].Value;
            DateTime newDate = dateTimePickerAppointments.Value;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Appointments SET AppointmentDate = @NewDate WHERE AppointmentID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewDate", newDate);
                cmd.Parameters.AddWithValue("@ID", appointmentId);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Appointment updated.");
                LoadAppointments();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0) return;
            var row = dgvAppointments.SelectedRows[0];
            int appointmentId = (int)row.Cells["AppointmentID"].Value;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Appointments WHERE AppointmentID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", appointmentId);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Appointment deleted.");
                LoadAppointments();
            }
        }
    }
}
