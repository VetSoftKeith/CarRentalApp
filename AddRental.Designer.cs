using System.Windows.Forms;

namespace Car_Rental_App
{
    partial class FrmAddRentalRecord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewRentalAgreement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblReturnedDate = new System.Windows.Forms.Label();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.btnAddRentalCancel = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.pnlMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainLayout
            // 
            this.pnlMainLayout.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainLayout.ColumnCount = 5;
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.Controls.Add(this.lblNewRentalAgreement, 1, 0);
            this.pnlMainLayout.Controls.Add(this.label1, 0, 1);
            this.pnlMainLayout.Controls.Add(this.lblDateRented, 0, 3);
            this.pnlMainLayout.Controls.Add(this.dtpDateRented, 0, 4);
            this.pnlMainLayout.Controls.Add(this.cmbCarType, 0, 6);
            this.pnlMainLayout.Controls.Add(this.lblCarType, 0, 5);
            this.pnlMainLayout.Controls.Add(this.lblReturnedDate, 3, 3);
            this.pnlMainLayout.Controls.Add(this.dtpDateReturned, 3, 4);
            this.pnlMainLayout.Controls.Add(this.btnSubmit, 2, 8);
            this.pnlMainLayout.Controls.Add(this.lblCost, 3, 1);
            this.pnlMainLayout.Controls.Add(this.nudCost, 3, 2);
            this.pnlMainLayout.Controls.Add(this.btnAddRentalCancel, 2, 10);
            this.pnlMainLayout.Controls.Add(this.cmbCustomer, 0, 2);
            this.pnlMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainLayout.Location = new System.Drawing.Point(9, 9);
            this.pnlMainLayout.Name = "pnlMainLayout";
            this.pnlMainLayout.RowCount = 12;
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlMainLayout.Size = new System.Drawing.Size(1065, 572);
            this.pnlMainLayout.TabIndex = 0;
            // 
            // lblNewRentalAgreement
            // 
            this.lblNewRentalAgreement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewRentalAgreement.AutoSize = true;
            this.pnlMainLayout.SetColumnSpan(this.lblNewRentalAgreement, 3);
            this.lblNewRentalAgreement.Font = new System.Drawing.Font("Cooper Black", 36F);
            this.lblNewRentalAgreement.Location = new System.Drawing.Point(237, 0);
            this.lblNewRentalAgreement.Name = "lblNewRentalAgreement";
            this.lblNewRentalAgreement.Size = new System.Drawing.Size(590, 55);
            this.lblNewRentalAgreement.TabIndex = 0;
            this.lblNewRentalAgreement.Text = "New Rental Agreement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateRented.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblDateRented.Location = new System.Drawing.Point(3, 141);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(207, 28);
            this.lblDateRented.TabIndex = 3;
            this.lblDateRented.Text = "Date Rented";
            this.lblDateRented.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpDateRented
            // 
            this.pnlMainLayout.SetColumnSpan(this.dtpDateRented, 2);
            this.dtpDateRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateRented.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRented.Location = new System.Drawing.Point(3, 172);
            this.dtpDateRented.MaxDate = new System.DateTime(2022, 8, 23, 15, 19, 3, 162);
            this.dtpDateRented.MinDate = new System.DateTime(2022, 2, 23, 15, 19, 3, 162);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(420, 22);
            this.dtpDateRented.TabIndex = 2;
            this.dtpDateRented.Value = new System.DateTime(2022, 2, 23, 15, 19, 3, 162);
            // 
            // cmbCarType
            // 
            this.pnlMainLayout.SetColumnSpan(this.cmbCarType, 2);
            this.cmbCarType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.Items.AddRange(new object[] {
            "Acura",
            "Audi",
            "BMW",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Dodge",
            "Fiat",
            "Ford",
            "Infiniti",
            "Jeep",
            "Kia",
            "Lexus"});
            this.cmbCarType.Location = new System.Drawing.Point(3, 228);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(420, 21);
            this.cmbCarType.TabIndex = 3;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarType.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblCarType.Location = new System.Drawing.Point(3, 197);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(207, 28);
            this.lblCarType.TabIndex = 6;
            this.lblCarType.Text = "Type of Car";
            this.lblCarType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblReturnedDate
            // 
            this.lblReturnedDate.AutoSize = true;
            this.lblReturnedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReturnedDate.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblReturnedDate.Location = new System.Drawing.Point(642, 141);
            this.lblReturnedDate.Name = "lblReturnedDate";
            this.lblReturnedDate.Size = new System.Drawing.Size(207, 28);
            this.lblReturnedDate.TabIndex = 7;
            this.lblReturnedDate.Text = "Date Returned";
            this.lblReturnedDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpDateReturned
            // 
            this.pnlMainLayout.SetColumnSpan(this.dtpDateReturned, 2);
            this.dtpDateReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateReturned.Location = new System.Drawing.Point(642, 172);
            this.dtpDateReturned.MaxDate = new System.DateTime(2023, 2, 23, 15, 19, 3, 181);
            this.dtpDateReturned.MinDate = new System.DateTime(2022, 2, 24, 15, 19, 3, 181);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(420, 20);
            this.dtpDateReturned.TabIndex = 5;
            this.dtpDateReturned.Value = new System.DateTime(2022, 2, 24, 15, 19, 3, 181);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnSubmit.Location = new System.Drawing.Point(429, 284);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(207, 51);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCost.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblCost.Location = new System.Drawing.Point(642, 85);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(207, 28);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudCost
            // 
            this.pnlMainLayout.SetColumnSpan(this.nudCost, 2);
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCost.Location = new System.Drawing.Point(642, 116);
            this.nudCost.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(420, 20);
            this.nudCost.TabIndex = 4;
            this.nudCost.ThousandsSeparator = true;
            this.nudCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddRentalCancel
            // 
            this.btnAddRentalCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRentalCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRentalCancel.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRentalCancel.Location = new System.Drawing.Point(429, 369);
            this.btnAddRentalCancel.Name = "btnAddRentalCancel";
            this.btnAddRentalCancel.Size = new System.Drawing.Size(207, 51);
            this.btnAddRentalCancel.TabIndex = 11;
            this.btnAddRentalCancel.Text = "Cancel";
            this.btnAddRentalCancel.UseVisualStyleBackColor = true;
            this.btnAddRentalCancel.Click += new System.EventHandler(this.BtnAddRentalCancel_Click);
            // 
            // cmbCustomer
            // 
            this.pnlMainLayout.SetColumnSpan(this.cmbCustomer, 2);
            this.cmbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCustomer.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(3, 116);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(420, 23);
            this.cmbCustomer.TabIndex = 1;
            // 
            // FrmAddRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 590);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainLayout);
            this.Name = "FrmAddRentalRecord";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car Rental App";
            this.Load += new System.EventHandler(this.FrmAddRentalRecord_Load);
            this.pnlMainLayout.ResumeLayout(false);
            this.pnlMainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel pnlMainLayout;
        private Label label1;
        private Label lblNewRentalAgreement;
        private Label lblDateRented;
        private DateTimePicker dtpDateRented;
        private ComboBox cmbCarType;
        private Label lblCarType;
        private Label lblReturnedDate;
        private DateTimePicker dtpDateReturned;
        private Button btnSubmit;
        private Label lblCost;
        private NumericUpDown nudCost;
        private Button btnAddRentalCancel;
        private ComboBox cmbCustomer;
    }
}