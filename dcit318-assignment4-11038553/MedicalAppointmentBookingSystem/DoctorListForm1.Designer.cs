namespace MedicalAppointmentBookingSystem
{
    partial class DoctorListForm1
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
            dgvDoctors = new DataGridView();
            btnRefresh = new Button();
            btnClose = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToOrderColumns = true;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(31, 67);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.Size = new Size(422, 170);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(264, 254);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 31);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(386, 254);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 31);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(177, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 43);
            textBox1.TabIndex = 3;
            textBox1.Text = "Doctor List";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // DoctorListForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 396);
            Controls.Add(textBox1);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(dgvDoctors);
            Name = "DoctorListForm1";
            Text = "DoctorListForm1";
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDoctors;
        private Button btnRefresh;
        private Button btnClose;
        private TextBox textBox1;
    }
}