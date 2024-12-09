using School_Student_FrontPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing
{
    public partial class GCashConfirmation : Form
    {
        public GCashConfirmation(long studentID, long phoneNumber, string payeeName, double amountToPay)
        {
            InitializeComponent();

            Lbl_StudentID.Text = studentID.ToString();
            Lbl_PhoneNumber.Text = phoneNumber.ToString();
            Lbl_PayeeName.Text = payeeName;
            Lbl_AmountToPay.Text = amountToPay.ToString();

            lblConfirm.ForeColor = Color.FromArgb(255, 0, 0);

            btnBack.BackColor = Color.FromArgb(57, 117, 233);
            btnSubmit.BackColor = Color.FromArgb(57, 117, 233);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GCash gc = new GCash();
            this.Hide();
            gc.ShowDialog();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                long studentID = long.Parse(Lbl_StudentID.Text);
                long phoneNumber = long.Parse(Lbl_PhoneNumber.Text);
                string payeeName = Lbl_PayeeName.Text;
                double amountToPay = double.Parse(Lbl_AmountToPay.Text);

                GCashInvoice gci = new GCashInvoice(studentID, phoneNumber, payeeName, amountToPay);
                this.Hide();
                gci.ShowDialog();
                this.Close();
            }
        }

        private void pbSTILogo_Click(object sender, EventArgs e)
        {
            PaymentService ps = new PaymentService();
            this.Hide();
            ps.ShowDialog();
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            school_Student_FrontPage School_Student_FrontPage = new school_Student_FrontPage();
            this.Hide();
            School_Student_FrontPage.ShowDialog();
            this.Close();
        }
    }
}
