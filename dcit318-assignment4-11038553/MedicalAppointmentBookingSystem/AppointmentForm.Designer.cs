namespace MedicalAppointmentBookingSystem
{
    partial class AppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            notes = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            cmbDoctors = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtPatientNotes = new TextBox();
            btnBook = new Button();
            btnCancel = new Button();
            cmbPatients = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(61, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 36);
            textBox1.TabIndex = 0;
            textBox1.Text = "Book An Appointment";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(16, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 22);
            textBox2.TabIndex = 1;
            textBox2.Text = "Doctor";
            textBox2.TextAlign = HorizontalAlignment.Center;
            
            // 
            // notes
            // 
            notes.BorderStyle = BorderStyle.None;
            notes.Font = new Font("Segoe UI", 12F);
            notes.Location = new Point(16, 244);
            notes.Name = "notes";
            notes.Size = new Size(71, 22);
            notes.TabIndex = 2;
            notes.Text = "Notes";
            notes.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(16, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(71, 22);
            textBox4.TabIndex = 3;
            textBox4.Text = "Date";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(16, 141);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(71, 22);
            textBox5.TabIndex = 4;
            textBox5.Text = "Patient";
            textBox5.TextAlign = HorizontalAlignment.Center;
            
            // 
            // cmbDoctors
            // 
            cmbDoctors.FormattingEnabled = true;
            cmbDoctors.Location = new Point(130, 103);
            cmbDoctors.Name = "cmbDoctors";
            cmbDoctors.Size = new Size(231, 23);
            cmbDoctors.TabIndex = 5;
            ;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // txtPatientNotes
            // 
            txtPatientNotes.AcceptsReturn = true;
            txtPatientNotes.AcceptsTab = true;
            txtPatientNotes.AllowDrop = true;
            txtPatientNotes.BorderStyle = BorderStyle.None;
            txtPatientNotes.Location = new Point(130, 243);
            txtPatientNotes.Multiline = true;
            txtPatientNotes.Name = "txtPatientNotes";
            txtPatientNotes.Size = new Size(239, 23);
            txtPatientNotes.TabIndex = 7;
            
            // 
            // btnBook
            // 
            btnBook.Location = new Point(183, 366);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(75, 31);
            btnBook.TabIndex = 11;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(286, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 31);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbPatients
            // 
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(130, 140);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(231, 23);
            cmbPatients.TabIndex = 13;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(cmbPatients);
            Controls.Add(btnCancel);
            Controls.Add(btnBook);
            Controls.Add(txtPatientNotes);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbDoctors);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(notes);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox notes;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox cmbDoctors;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPatientNotes;
        private Button btnBook;
        private Button btnCancel;
        private ComboBox cmbPatients;
    }
}