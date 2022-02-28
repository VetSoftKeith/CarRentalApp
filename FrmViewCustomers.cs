using System;
using System.Collections.Generic;
using System.Data.Entity;
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

            List<Customer> list = Globals.db.Customers.ToList();
            dgViewCustomers.DataSource = list;

            // Hide foreign keys and primary keys
            //dgViewCustomers.Columns[0].Visible = false;

            // freeze name columns
            //dgViewCustomers.Columns[1].Frozen = true;
            //dgViewCustomers.Columns[2].Frozen = true;

            // header text formatting
            //dgViewCustomers.Columns[2].HeaderText = "Last Name";
            //dgViewCustomers.Columns[1].HeaderText = "First Name";
            //dgViewCustomers.Columns[3].HeaderText = "Address";
            //dgViewCustomers.Columns[6].HeaderText = "Zip Code";
            //dgViewCustomers.Columns[7].HeaderText = "Insurance?";
            //dgViewCustomers.Columns[9].HeaderText = "Insurance Expiry";
            //dgViewCustomers.Columns[8].HeaderText = "Insurance Co Id";
            //dgViewCustomers.Columns[10].HeaderText = "Created";
            //dgViewCustomers.Columns[11].HeaderText = "Updated";

            // Disable Created/Updaed to prevent tampering
            //dgViewCustomers.Columns[10].ReadOnly = true;
            //dgViewCustomers.Columns[11].ReadOnly = true;
        }

        private void DgViewCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*switch (e.ColumnIndex)
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

            e.FormattingApplied = false;*/
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
            foreach (DataGridViewRow row in dgViewCustomers.SelectedRows)
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

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {

        }

        private void DgViewCustomers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int editedRecordId = (int)dgViewCustomers.Rows[e.RowIndex].Cells["id"].Value;

                DataGridViewRow row = dgViewCustomers.Rows[e.RowIndex];
                var newValue = row.Cells[e.ColumnIndex].Value;

                MessageBox.Show($"{newValue}");

                EditField(editedRecordId, row);
            }
        }

        private void EditField(int editedRecordId, DataGridViewRow row)
        {
            var cust = Globals.db.Customers.FirstOrDefault(w => w.id == editedRecordId);
            
            cust.FirstName = Convert.ToString(row.Cells["FirstName"].Value);
            cust.LastName = Convert.ToString(row.Cells["LastName"].Value);
            cust.StreetAddress = Convert.ToString(row.Cells["StreetAddress"].Value);
            cust.City = Convert.ToString(row.Cells["City"].Value);
            cust.State = Convert.ToString(row.Cells["State"].Value);
            cust.ZipCode = (int)row.Cells["ZipCode"].Value;
            cust.InsuranceVerified = (byte)1;

            cust.InsuranceCompany = new InsuranceCompany()
            {
                Name = cust.InsuranceCompany.Name,
                PhoneNumber = cust.InsuranceCompany.PhoneNumber,
                State = cust.InsuranceCompany.State,
                CreatedAt = cust.InsuranceCompany.CreatedAt,
                UpdatedAt = DateTime.Now,
            };

            cust.InsuranceExpirationDate = DateTime.Now.AddMonths(6);
            cust.CreatedAt = cust.CreatedAt;

            Globals.db.Entry(cust).State = EntityState.Modified;
            Globals.db.SaveChanges();

            //MessageBox.Show($"{dgViewCustomers.SelectedRows.Count} {(dgViewCustomers.SelectedRows.Count == 1 ? "Customer" : "Customers")} Edited", "Great Success!!", MessageBoxButtons.OK);

            //UpdateTableData();
        }
    }
}
