
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient ;
using Microsoft.Data.SqlClient; 



namespace MedicalAppointmentBookingSystem
{
  internal class DataAccess
    {
        private readonly string _connString;

        public DataAccess()
        {
            _connString = ConfigurationManager.ConnectionStrings["MedicalDb"].ConnectionString;
        }

        // Get list of doctors - uses SqlDataReader

        public List<Doctors> GetDoctors()
        {
            var list = new List<Doctors>();
            string sql = "SELECT DoctorID, FullName, Specialty, Availability FROM Doctors";

            using ( var conn = new Microsoft.Data.SqlClient.SqlConnection(_connString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Doctors
                            {
                                DoctorID = reader.GetInt32(0),
                                FullName = reader.GetString(1),
                                Specialty = reader.GetString(2),
                                Availability = reader.GetBoolean(3)
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    throw; // let caller handle/log
                }
            }
            return list;
        }

        // Get patients (DataReader)
        public List<Patients> GetPatients()
        {
            var list = new List<Patients>();
            string sql = "SELECT PatientID, FullName, Email FROM Patients";

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(_connString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Patients
                            {
                                PatientID = reader.GetInt32(0),
                                FullName = reader.GetString(1),
                                Email = reader.IsDBNull(2) ? null : reader.GetString(2)
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return list;
        }

        // Insert appointment (ExecuteNonQuery + parameters)
        public int InsertAppointment(Appointments appointment)
        {
            string sql = @"INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, Notes)
                       VALUES (@DoctorID, @PatientID, @AppointmentDate, @Notes)";
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(_connString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@Notes", (object)appointment.Notes ?? DBNull.Value);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery(); // returns rows affected
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // Get appointments for a patient using DataAdapter + DataSet
        public DataSet GetAppointmentsDataSetByPatient(int patientId)
        {
            var ds = new DataSet();
            string sql = @"SELECT a.AppointmentID, a.DoctorID, d.FullName AS DoctorName, a.PatientID, p.FullName AS PatientName, a.AppointmentDate, a.Notes
                       FROM Appointments a
                       JOIN Doctors d ON a.DoctorID = d.DoctorID
                       JOIN Patients p ON a.PatientID = p.PatientID
                       WHERE a.PatientID = @PatientID
                       ORDER BY a.AppointmentDate";

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(_connString))
            using (var adapter = new Microsoft.Data.SqlClient.SqlDataAdapter(sql, conn))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.Parameters.AddWithValue("@PatientID", patientId);

                try
                {
                    adapter.Fill(ds, "Appointments");
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return ds;
        }

        // Update appointment date by appointment id
        public int UpdateAppointmentDate(int appointmentId, DateTime newDate)
        {
            string sql = "UPDATE Appointments SET AppointmentDate = @AppointmentDate WHERE AppointmentID = @AppointmentID";
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(_connString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@AppointmentDate", newDate);
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // Delete appointment
        public int DeleteAppointment(int appointmentId)
        {
            string sql = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(_connString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // Check doctor availability for a datetime
        public bool IsDoctorAvailable(int doctorId, DateTime appointmentDate)
        {
            string sql = @"SELECT COUNT(*) FROM Appointments
                       WHERE DoctorID = @DoctorID AND AppointmentDate = @AppointmentDate";
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(_connString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count == 0;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
