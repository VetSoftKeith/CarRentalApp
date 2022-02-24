using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class FrmViewCustomers : Form
    {
        public FrmViewCustomers()
        {
            InitializeComponent();
        }

        private void FrmViewCustomers_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            BindData();
        }

        private void BindData()
        {
            // set all columns to display full data by default
            dgViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            List<View_AllCustomers> list = Globals.db.View_AllCustomers.ToList();
            dgViewCustomers.DataSource = list;

            // Hide foreign keys and primary keys
            dgViewCustomers.Columns[10].Visible = false;
            dgViewCustomers.Columns[14].Visible = false;

            // freeze name columns
            dgViewCustomers.Columns[0].Frozen = true;
            dgViewCustomers.Columns[1].Frozen = true;

            // header text formatting
            dgViewCustomers.Columns[0].HeaderText = "Last Name";
            dgViewCustomers.Columns[1].HeaderText = "First Name";
            dgViewCustomers.Columns[2].HeaderText = "Address";
            dgViewCustomers.Columns[5].HeaderText = "Zip Code";
            dgViewCustomers.Columns[6].HeaderText = "Insurance?";
            dgViewCustomers.Columns[7].HeaderText = "Insurance Expiry";
            dgViewCustomers.Columns[8].HeaderText = "Insurance Co";
            dgViewCustomers.Columns[9].HeaderText = "Insurance Co Phone #";
            dgViewCustomers.Columns[11].HeaderText = "Insurance State";
            dgViewCustomers.Columns[12].HeaderText = "Created";
            dgViewCustomers.Columns[13].HeaderText = "Updated";
        }

        private void DgViewCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6: // Format the bool column (stored as a byte) into something human-readable
                    switch (e.Value.ToString())
                    {
                        case "1":
                            e.Value = "Yes";
                            break;
                        case "0":
                            e.Value = "No";
                            break;
                    }

                    e.FormattingApplied = true;
                    break;

                case 7: // Strip time from insurance DateTime object
                    DateTime dt = (DateTime)e.Value;
                    e.Value = dt.Date;

                    e.FormattingApplied = true;
                    break;

                case 9:
                    e.Value = Convert.ToInt32(e.Value).ToString("###-####");

                    e.FormattingApplied = true;
                    break;
            }

            e.FormattingApplied = false;
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer(this)
            {
                MdiParent = this.MdiParent
            };

            this.Hide();
            frmAddCustomer.Show();
            this.Close();
        }

        public void UpdateTableData()
        {
            BindData();
            dgViewCustomers.Update();
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgViewCustomers.SelectedRows)
            {
                // Fetch db record id
                int recordId = (int)row.Cells["id"].Value;

                var customer = Globals.db.Customers.FirstOrDefault(w => w.id == recordId);

                Globals.db.Customers.Remove(customer);
                Globals.db.SaveChanges();
            }

            MessageBox.Show($"{dgViewCustomers.SelectedRows.Count} {(dgViewCustomers.SelectedRows.Count == 1 ? "Customer" : "Customers")} Deleted", "Great Success!!", MessageBoxButtons.OK);

            UpdateTableData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
