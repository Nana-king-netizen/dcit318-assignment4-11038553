namespace MedicalAppointmentBookingSystem
{
    partial class MainForm
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
            btnDoctors = new Button();
            btnAppointment = new Button();
            btnManage = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(47, 19);
            textBox1.Margin = new Padding(10);
            textBox1.MaximumSize = new Size(280, 29);
            textBox1.MinimumSize = new Size(280, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "Medical Appointment Booking System";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnDoctors
            // 
            btnDoctors.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDoctors.Location = new Point(111, 79);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(166, 44);
            btnDoctors.TabIndex = 1;
            btnDoctors.Text = "View Doctors";
            btnDoctors.UseVisualStyleBackColor = true;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnAppointment
            // 
            btnAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAppointment.Location = new Point(111, 175);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(166, 44);
            btnAppointment.TabIndex = 2;
            btnAppointment.Text = "Book Appointment";
            btnAppointment.UseVisualStyleBackColor = true;
            btnAppointment.Click += btnAppointment_Click;
            // 
            // btnManage
            // 
            btnManage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnManage.Location = new Point(111, 276);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(166, 44);
            btnManage.TabIndex = 3;
            btnManage.Text = "Manage Appointments";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(385, 395);
            Controls.Add(btnManage);
            Controls.Add(btnAppointment);
            Controls.Add(btnDoctors);
            Controls.Add(textBox1);
            MinimumSize = new Size(401, 434);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnDoctors;
        private Button btnAppointment;
        private Button btnManage;
    }
}