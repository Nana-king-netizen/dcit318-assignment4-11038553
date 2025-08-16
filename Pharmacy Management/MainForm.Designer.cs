namespace Pharmacy_Management
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtCategory = new TextBox();
            dgvMedicines = new DataGridView();
            btnAddMedicine = new Button();
            btnSearch = new Button();
            btnUpdateStock = new Button();
            btnRecordSale = new Button();
            btnViewAll = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(105, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 25);
            textBox1.TabIndex = 0;
            textBox1.Text = "Pharmacy Inventory and Sales";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(93, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Medicine Name";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(93, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Category";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 236);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 23);
            textBox4.TabIndex = 3;
            textBox4.Tag = "";
            textBox4.Text = "Search";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 196);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(93, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "Quantity";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 151);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(93, 23);
            textBox6.TabIndex = 5;
            textBox6.Text = "Price";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(139, 196);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(193, 23);
            txtQuantity.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(139, 151);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 23);
            txtPrice.TabIndex = 9;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(139, 109);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(193, 23);
            txtCategory.TabIndex = 10;
            // 
            // dgvMedicines
            // 
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicines.Location = new Point(12, 292);
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.Size = new Size(463, 146);
            dgvMedicines.TabIndex = 11;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Location = new Point(365, 67);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(99, 23);
            btnAddMedicine.TabIndex = 12;
            btnAddMedicine.Text = "Add Medicine";
            btnAddMedicine.UseVisualStyleBackColor = true;
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(365, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 23);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(365, 151);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(99, 23);
            btnUpdateStock.TabIndex = 14;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnRecordSale
            // 
            btnRecordSale.Location = new Point(365, 195);
            btnRecordSale.Name = "btnRecordSale";
            btnRecordSale.Size = new Size(99, 23);
            btnRecordSale.TabIndex = 15;
            btnRecordSale.Text = "Record Sale";
            btnRecordSale.UseVisualStyleBackColor = true;
            btnRecordSale.Click += btnRecordSale_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(365, 237);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(99, 23);
            btnViewAll.TabIndex = 16;
            btnViewAll.Text = "View All";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(139, 238);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 23);
            txtSearch.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnViewAll);
            Controls.Add(btnRecordSale);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnSearch);
            Controls.Add(btnAddMedicine);
            Controls.Add(dgvMedicines);
            Controls.Add(txtCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtCategory;
        private DataGridView dgvMedicines;
        private Button btnAddMedicine;
        private Button btnSearch;
        private Button btnUpdateStock;
        private Button btnRecordSale;
        private Button btnViewAll;
        private TextBox txtSearch;
    }
}