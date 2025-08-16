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
    public partial class AppointmentForm : Form
    {
        private readonly string connStr = ConfigurationManager.ConnectionStrings["MedicalDbConn"].ConnectionString;

        public AppointmentForm()
        {
            InitializeComponent();
            LoadDoctors();
            LoadPatients();
        }

        private void LoadDoctors()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT DoctorID, FullName FROM Doctors WHERE Availability = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbDoctors.Items.Add(new
                        {
                            Text = reader["FullName"].ToString(),
                            Value = reader["DoctorID"]
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading doctors: {ex.Message}");
                }
            }
        }

        private void LoadPatients()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT PatientID, FullName FROM Patients";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbPatients.Items.Add(new
                        {
                            Text = reader["FullName"].ToString(),
                            Value = reader["PatientID"].ToString()
                        });


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading patients: {ex.Message}");
                }
            }
        }

       

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbDoctors.SelectedIndex == -1 || cmbPatients.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a doctor and a patient.");
                return;
            }

            var selectedDoctor = (dynamic)cmbDoctors.SelectedItem;
            var selectedPatient = (dynamic)cmbPatients.SelectedItem;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, Notes) VALUES (@DoctorID, @PatientID, @AppointmentDate, @Notes)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@DoctorID", selectedDoctor.Value);
                cmd.Parameters.AddWithValue("@PatientID", selectedPatient.Value);
                cmd.Parameters.AddWithValue("@AppointmentDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Notes", txtPatientNotes.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Appointment booked successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error booking appointment: {ex.Message}");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AppointmentForm().Close();

        }
    }
}
