namespace Car_Rental_App
{
    partial class FrmViewCustomers
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
            this.dgViewCustomers = new System.Windows.Forms.DataGridView();
            this.pnlViewCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCustomers)).BeginInit();
            this.pnlViewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgViewCustomers
            // 
            this.dgViewCustomers.AllowUserToAddRows = false;
            this.dgViewCustomers.AllowUserToDeleteRows = false;
            this.dgViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pnlViewCustomer.SetColumnSpan(this.dgViewCustomers, 3);
            this.dgViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewCustomers.Location = new System.Drawing.Point(3, 3);
            this.dgViewCustomers.Name = "dgViewCustomers";
            this.dgViewCustomers.Size = new System.Drawing.Size(794, 354);
            this.dgViewCustomers.TabIndex = 0;
            this.dgViewCustomers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgViewCustomers_CellFormatting);
            this.dgViewCustomers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgViewCustomers_CellValueChanged);
            // 
            // pnlViewCustomer
            // 
            this.pnlViewCustomer.ColumnCount = 3;
            this.pnlViewCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlViewCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.pnlViewCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.pnlViewCustomer.Controls.Add(this.dgViewCustomers, 0, 0);
            this.pnlViewCustomer.Controls.Add(this.btnAddCustomer, 0, 1);
            this.pnlViewCustomer.Controls.Add(this.btnEditCustomer, 1, 1);
            this.pnlViewCustomer.Controls.Add(this.btnDeleteCustomer, 2, 1);
            this.pnlViewCustomer.Controls.Add(this.btnClose, 0, 2);
            this.pnlViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlViewCustomer.Name = "pnlViewCustomer";
            this.pnlViewCustomer.RowCount = 3;
            this.pnlViewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlViewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlViewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlViewCustomer.Size = new System.Drawing.Size(800, 450);
            this.pnlViewCustomer.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCustomer.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(3, 363);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(260, 39);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditCustomer.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Location = new System.Drawing.Point(269, 363);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(260, 39);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(535, 363);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(262, 39);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // btnClose
            // 
            this.pnlViewCustomer.SetColumnSpan(this.btnClose, 3);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(3, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(794, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlViewCustomer);
            this.Name = "FrmViewCustomers";
            this.Text = "View Customers";
            this.Load += new System.EventHandler(this.FrmViewCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCustomers)).EndInit();
            this.pnlViewCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewCustomers;
        private System.Windows.Forms.TableLayoutPanel pnlViewCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnClose;
    }
}