using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            List<State> stateList = Globals.db.States.ToList();

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
                InsuranceCompany = 1,
                InsuranceExpirationDate = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            try
            {
                Globals.db.Customers.Add(customerRecord);
                Globals.db.SaveChanges();

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
    }
}
