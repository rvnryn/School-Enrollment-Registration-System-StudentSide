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
    public partial class PaymentService : Form
    {
        public PaymentService()
        {
            InitializeComponent();

            lblChoose.ForeColor = Color.FromArgb(44, 102, 184);
        }

        private void pictureBox_OnlinePayment_Click(object sender, EventArgs e)
        {
            OnlinePayment op = new OnlinePayment();
            this.Hide();
            op.ShowDialog();
            this.Close();
        }

        private void pictureBox_OverTheCounter_Click(object sender, EventArgs e)
        {
            OverTheCounter otc = new OverTheCounter();
            this.Hide();
            otc.ShowDialog();
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
