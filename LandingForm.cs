using System;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class FrmLandingPage : Form
    {
        public FrmLandingPage()
        {
            InitializeComponent();
        }

        private void NewRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddRentalRecord frmAddRentalRecord = new FrmAddRentalRecord()
            {
                MdiParent = this
            };

            frmAddRentalRecord.Show();
        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer()
            {
                MdiParent = this
            };

            frmAddCustomer.Show();
        }
    }
}