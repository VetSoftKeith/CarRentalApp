namespace Car_Rental_App
{
    partial class frmMainWindow
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
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblReturnedDate = new System.Windows.Forms.Label();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.pnlMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainLayout
            // 
            this.pnlMainLayout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMainLayout.ColumnCount = 5;
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlMainLayout.Controls.Add(this.lblMainHeader, 1, 0);
            this.pnlMainLayout.Controls.Add(this.label1, 0, 1);
            this.pnlMainLayout.Controls.Add(this.tbxCustomerName, 0, 2);
            this.pnlMainLayout.Controls.Add(this.lblDateRented, 0, 3);
            this.pnlMainLayout.Controls.Add(this.dtpDateRented, 0, 4);
            this.pnlMainLayout.Controls.Add(this.cmbCarType, 0, 6);
            this.pnlMainLayout.Controls.Add(this.lblCarType, 0, 5);
            this.pnlMainLayout.Controls.Add(this.lblReturnedDate, 3, 3);
            this.pnlMainLayout.Controls.Add(this.dtpDateReturned, 3, 4);
            this.pnlMainLayout.Controls.Add(this.btnSubmit, 2, 8);
            this.pnlMainLayout.Controls.Add(this.lblCost, 3, 1);
            this.pnlMainLayout.Controls.Add(this.nudCost, 3, 2);
            this.pnlMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainLayout.Location = new System.Drawing.Point(10, 10);
            this.pnlMainLayout.Name = "pnlMainLayout";
            this.pnlMainLayout.RowCount = 10;
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlMainLayout.Size = new System.Drawing.Size(1244, 661);
            this.pnlMainLayout.TabIndex = 0;
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMainHeader.AutoSize = true;
            this.pnlMainLayout.SetColumnSpan(this.lblMainHeader, 3);
            this.lblMainHeader.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainHeader.Location = new System.Drawing.Point(383, 0);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(474, 55);
            this.lblMainHeader.TabIndex = 0;
            this.lblMainHeader.Text = "Car Rental System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbxCustomerName
            // 
            this.pnlMainLayout.SetColumnSpan(this.tbxCustomerName, 2);
            this.tbxCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCustomerName.Location = new System.Drawing.Point(3, 135);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(490, 23);
            this.tbxCustomerName.TabIndex = 1;
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateRented.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateRented.Location = new System.Drawing.Point(3, 165);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(242, 33);
            this.lblDateRented.TabIndex = 3;
            this.lblDateRented.Text = "Date Rented";
            this.lblDateRented.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpDateRented
            // 
            this.pnlMainLayout.SetColumnSpan(this.dtpDateRented, 2);
            this.dtpDateRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateRented.Location = new System.Drawing.Point(3, 201);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(490, 23);
            this.dtpDateRented.TabIndex = 2;
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
            this.cmbCarType.Location = new System.Drawing.Point(3, 267);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(490, 23);
            this.cmbCarType.TabIndex = 3;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarType.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarType.Location = new System.Drawing.Point(3, 231);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(242, 33);
            this.lblCarType.TabIndex = 6;
            this.lblCarType.Text = "Type of Car";
            this.lblCarType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblReturnedDate
            // 
            this.lblReturnedDate.AutoSize = true;
            this.lblReturnedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReturnedDate.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReturnedDate.Location = new System.Drawing.Point(747, 165);
            this.lblReturnedDate.Name = "lblReturnedDate";
            this.lblReturnedDate.Size = new System.Drawing.Size(242, 33);
            this.lblReturnedDate.TabIndex = 7;
            this.lblReturnedDate.Text = "Date Returned";
            this.lblReturnedDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpDateReturned
            // 
            this.pnlMainLayout.SetColumnSpan(this.dtpDateReturned, 2);
            this.dtpDateReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateReturned.Location = new System.Drawing.Point(747, 201);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(494, 23);
            this.dtpDateReturned.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(499, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(242, 60);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCost.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCost.Location = new System.Drawing.Point(747, 99);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(242, 33);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudCost
            // 
            this.pnlMainLayout.SetColumnSpan(this.nudCost, 2);
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCost.Location = new System.Drawing.Point(747, 135);
            this.nudCost.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(494, 23);
            this.nudCost.TabIndex = 4;
            this.nudCost.ThousandsSeparator = true;
            this.nudCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMainLayout);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMainWindow";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental App";
            this.pnlMainLayout.ResumeLayout(false);
            this.pnlMainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel pnlMainLayout;
        private Label label1;
        private TextBox tbxCustomerName;
        private Label lblMainHeader;
        private Label lblDateRented;
        private DateTimePicker dtpDateRented;
        private ComboBox cmbCarType;
        private Label lblCarType;
        private Label lblReturnedDate;
        private DateTimePicker dtpDateReturned;
        private Button btnSubmit;
        private Label lblCost;
        private NumericUpDown nudCost;
    }
}