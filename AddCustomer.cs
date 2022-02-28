using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class FrmAddCustomer : Form
    {
        private readonly Form owningForm = null;

        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        public FrmAddCustomer(Form frm)
        {
            InitializeComponent();

            this.owningForm = frm;
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // List<State> stateList = Globals.db.States.ToList();
            var stateList = Globals.db.States.ToList();

            cbState.ValueMember = "Code";
            cbState.DisplayMember = "Name";
            cbState.DataSource = stateList;
        }

        private void BtnAddRentalCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string[] errors = new string[] { };

            try
            {
                if (string.IsNullOrWhiteSpace(tbLastName.Text))
                {
                    Array.Resize(ref errors, errors.Length + 1);
                    errors[errors.Length - 1] = "Required: Last Name";
                }

                if (string.IsNullOrWhiteSpace(tbFirstName.Text))
                {
                    Array.Resize(ref errors, errors.Length + 1);
                    errors[errors.Length - 1] = "Required: First Name";
                }

                if (string.IsNullOrWhiteSpace(tbStreetAddress.Text))
                {
                    Array.Resize(ref errors, errors.Length + 1);
                    errors[errors.Length - 1] = "Required: Street Address";
                }

                if (string.IsNullOrWhiteSpace(tbCity.Text))
                {
                    Array.Resize(ref errors, errors.Length + 1);
                    errors[errors.Length - 1] = "Required: City";
                }

                if (string.IsNullOrWhiteSpace(cbState.SelectedValue.ToString()))
                {
                    Array.Resize(ref errors, errors.Length + 1);
                    errors[errors.Length - 1] = "Required: State";
                }

                if (string.IsNullOrWhiteSpace(tbZipCode.Text))
                {
                    Array.Resize(ref errors, errors.Length + 1);
                    errors[errors.Length - 1] = "Required: Zip Code";
                }
            }
            catch (Exception ex)
            {
                Array.Resize(ref errors, errors.Length + 1);
                errors[errors.Length - 1] = $"Unexpected Error! : {ex.Message}";
            }

            if (errors.Length > 0)
            {
                MessageBox.Show("ERRORS FOUND!!\n\r\n\r" + String.Join("\n\r", errors), "Ruh Roh!!", MessageBoxButtons.OK);
                return;
            }

            var customerRecord = new Customer
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                StreetAddress = tbStreetAddress.Text,
                City = tbCity.Text,
                State = cbState.SelectedValue.ToString(),
                ZipCode = Convert.ToInt32(tbZipCode.Text),
                InsuranceVerified = Convert.ToByte(1),
                InsuranceCompanyId = 1,
                InsuranceExpirationDate = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            try
            {
                Globals.db.Customers.Add(customerRecord);
                Globals.db.SaveChangesAsync();

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
            finally
            {
                DialogResult added = MessageBox.Show("New customer added!\n\r\n\rDo you want to add another?", "Great Success!!", MessageBoxButtons.YesNo);

                switch (added)
                {
                    case DialogResult.Yes:
                        tbLastName.Clear();
                        tbFirstName.Clear();
                        tbStreetAddress.Clear();
                        tbCity.Clear();
                        cbState.SelectedValue = "AA";
                        tbZipCode.Clear();
                        break;

                    case DialogResult.No:
                        this.Close();
                        break;

                    default:
                        this.Close();
                        break;
                }
            }
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void TbStreetAddress_TextChanged(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void TbCity_TextChanged(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void TbZipCode_TextChanged(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private bool ValidateForm()
        {
            bool lastNameComplete = false;
            bool firstNameComplete = false;
            bool addressComplete = false;
            bool cityComplete = false;
            bool stateComplete = false;
            bool zipCodeComplete = false;

            if (!string.IsNullOrWhiteSpace(tbLastName.Text) && tbLastName.TextLength > 1 && tbLastName.TextLength <= 50)
            {
                lastNameComplete = true;
            }

            if (!string.IsNullOrWhiteSpace(tbFirstName.Text) && tbFirstName.TextLength > 1 && tbFirstName.TextLength <= 50)
            {
                firstNameComplete = true;
            }

            if (!string.IsNullOrWhiteSpace(tbStreetAddress.Text) && tbStreetAddress.TextLength > 1 && tbStreetAddress.TextLength <= 250)
            {
                addressComplete = true;
            }

            if (!string.IsNullOrWhiteSpace(tbCity.Text) && tbCity.TextLength > 1 && tbCity.TextLength <= 50)
            {
                cityComplete = true;
            }

            if (!string.IsNullOrWhiteSpace(cbState.SelectedValue.ToString()))
            {
                stateComplete = true;
            }

            if (!string.IsNullOrWhiteSpace(tbZipCode.Text) && tbZipCode.TextLength == 5)
            {
                zipCodeComplete = true;
            }

            return lastNameComplete && firstNameComplete && addressComplete && cityComplete && stateComplete && zipCodeComplete;
        }

        private void FrmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.owningForm != null)
            {
                switch (this.owningForm.GetType().Name)
                {
                    case "FrmViewCustomers":
                        FrmViewCustomers frmViewCustomers = new FrmViewCustomers()
                        {
                            MdiParent = this.MdiParent
                        };

                        this.Hide();
                        frmViewCustomers.Show();
                        this.Close();
                        this.Dispose();
                        break;
                }
            }
        }
    }
}
