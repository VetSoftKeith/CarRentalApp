namespace Car_Rental_App
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string customerName = tbxCustomerName.Text;
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
                    errMsg[^1] = "Error: Customer Name is required.";
                }

                if (string.IsNullOrWhiteSpace(carType))
                {
                    Array.Resize(ref errMsg, errMsg.Length + 1);
                    errMsg[^1] = "Error: Car Type is required.";
                }

                if (dateOut > dateIn)
                {
                    Array.Resize(ref errMsg, errMsg.Length + 1);
                    errMsg[^1] = "Error: A car cannot be returned before it was rented!";
                }
            }
            catch (Exception ex)
            {
                Array.Resize(ref errMsg, errMsg.Length + 1);
                errMsg[^1] = "Error: Unknown error!";
            }
            finally
            {
                if (errMsg.Length != 0)
                {
                    MessageBox.Show(string.Join("\n\r", errMsg), "Ruh Roh!!", MessageBoxButtons.OK);
                }
            }
           
        }
    }
}