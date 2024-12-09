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
    public partial class OnlinePayment : Form
    {
        public OnlinePayment()
        {
            InitializeComponent();

            lblOnlinePayment.ForeColor = Color.FromArgb(44, 102, 184);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GCash gc = new GCash();
            this.Hide();
            gc.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BDO bdo = new BDO();
            this.Hide();
            bdo.ShowDialog();
            this.Close();
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