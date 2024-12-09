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
    public partial class OTCInvoice : Form
    {
        public OTCInvoice(long studentID, string payeeName, double amountToPay)
        {
            InitializeComponent();

            Lbl_StudentID.Text = studentID.ToString();
            Lbl_PayeeName.Text = payeeName;
            Lbl_AmountToPay.Text = amountToPay.ToString();

            lblCanPay.ForeColor = Color.FromArgb(44, 102, 184);

            btnGoBack.BackColor = Color.FromArgb(57, 117, 233);
        }

        private void pbSTILogo_Click(object sender, EventArgs e)
        {
            PaymentService ps = new PaymentService();
            this.Hide();
            ps.ShowDialog();
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            school_Student_FrontPage School_Student_FrontPage = new school_Student_FrontPage();
            this.Hide();
            School_Student_FrontPage.ShowDialog();
            this.Close();
        }
    }
}
