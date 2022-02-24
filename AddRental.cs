using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class FrmAddRentalRecord : Form
    {
        public FrmAddRentalRecord()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string customerName = cmbCustomer.Text;
            DateTime dateOut = dtpDateRented.Value;
            DateTime dateIn = dtpDateReturned.Value;
            double cost = Convert.ToDouble(nudCost.Value);

            string carType = cmbCarType.Text;

            string[] errMsg = Array.Empty<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(customerName))
                {
                    Array.Resize(ref errMsg, errMsg.Length + 1);
                    errMsg[errMsg.Length - 1] = "Error: Customer Name is required.";
                }

                if (string.IsNullOrWhiteSpace(carType))
                {
                    Array.Resize(ref errMsg, errMsg.Length + 1);
                    errMsg[errMsg.Length - 1] = "Error: Car Type is required.";
                }

                if (dateOut > dateIn)
                {
                    Array.Resize(ref errMsg, errMsg.Length + 1);
                    errMsg[errMsg.Length - 1] = "Error: A car cannot be returned before it was rented!";
                }

                if (cost <= 0)
                {
                    Array.Resize(ref errMsg, errMsg.Length + 1);
                    errMsg[errMsg.Length - 1] = "Error: Cost must be greater than $1.";
                }
            }
            catch (Exception ex)
            {
                Array.Resize(ref errMsg, errMsg.Length + 1);
                errMsg[errMsg.Length - 1] = $"Error: Unknown error! {ex.Message}";
            }
            finally
            {
                if (errMsg.Length != 0)
                {
                    MessageBox.Show(string.Join("\n\r", errMsg), "Ruh Roh!!", MessageBoxButtons.OK);
                }
            }

        }

        private void FrmAddRentalRecord_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            List<Customer> customers = Globals.db.Customers.OrderBy(cust => cust.LastName).ToList();

            // TODO: Demo this in class (28Feb); see Customer.cs L23
            cmbCustomer.DisplayMember = "LastCommaFirst";
            cmbCustomer.ValueMember = "id";
            cmbCustomer.DataSource = customers;
        }

        private void BtnAddRentalCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}