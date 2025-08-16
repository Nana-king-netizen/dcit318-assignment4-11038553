namespace MedicalAppointmentBookingSystem
{
    partial class ManageAppointmentsForm
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
            dgvAppointments = new DataGridView();
            textBox2 = new TextBox();
            dateTimePickerAppointments = new DateTimePicker();
            btnUpate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(67, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 36);
            textBox1.TabIndex = 0;
            textBox1.Text = "Manage Appointments\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(35, 88);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(476, 236);
            dgvAppointments.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(35, 349);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 16);
            textBox2.TabIndex = 2;
            textBox2.Text = "New Date:";
            // 
            // dateTimePickerAppointments
            // 
            dateTimePickerAppointments.Location = new Point(104, 349);
            dateTimePickerAppointments.Name = "dateTimePickerAppointments";
            dateTimePickerAppointments.Size = new Size(200, 23);
            dateTimePickerAppointments.TabIndex = 3;
            // 
            // btnUpate
            // 
            btnUpate.Location = new Point(436, 349);
            btnUpate.Name = "btnUpate";
            btnUpate.Size = new Size(75, 23);
            btnUpate.TabIndex = 4;
            btnUpate.Text = "Update";
            btnUpate.UseVisualStyleBackColor = true;
            btnUpate.Click += btnUpate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(436, 391);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ManageAppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpate);
            Controls.Add(dateTimePickerAppointments);
            Controls.Add(textBox2);
            Controls.Add(dgvAppointments);
            Controls.Add(textBox1);
            Name = "ManageAppointmentsForm";
            Text = "ManageAppointmentsForm";
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dgvAppointments;
        private TextBox textBox2;
        private DateTimePicker dateTimePickerAppointments;
        private Button btnUpate;
        private Button btnDelete;
    }
}