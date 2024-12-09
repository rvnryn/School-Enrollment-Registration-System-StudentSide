using Billing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace School_Student_FrontPage
{
    public partial class EnrollPage4 : Form
    {
        private bool isImageToggled;
        public EnrollPage4()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\night_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.White;
        }

        private void EnrollPage4_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Modes_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                SetDarkMode();
            }
            else
            {
                SetLightMode();
            }
        }

        private void SetLightMode()
        {
            isImageToggled = false; // Set to light mode
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\night_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.White; // Set light mode background

            // Update other controls (if necessary)
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.White;
                ctrl.ForeColor = Color.Black;
                this.panel_Section.BackColor = Color.White;
                lblCandP.BackColor = Color.FromArgb(0, 114, 188);
                lblCandP.ForeColor = Color.White;
                lblInfo.BackColor = Color.FromArgb(0, 114, 188);
                lblInfo.ForeColor = Color.White;
                Validatelbl.BackColor = Color.FromArgb(0, 114, 188);
                Validatelbl.ForeColor = Color.White;
                lblFinish.BackColor = Color.FromArgb(0, 114, 188);
                lblFinish.ForeColor = Color.White;
                lblSuccess.ForeColor = Color.FromArgb(0, 114, 188);


            }
        }

        private void SetDarkMode()
        {
            isImageToggled = true; // Set to dark mode
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\light_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.Black; // Set dark mode background

            // Update other controls (if necessary)
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.Black;
                ctrl.ForeColor = Color.White;
                lblCandP.BackColor = Color.FromArgb(0, 114, 188);
                lblCandP.ForeColor = Color.White;
                lblInfo.BackColor = Color.FromArgb(0, 114, 188);
                lblInfo.ForeColor = Color.White;
                Validatelbl.BackColor = Color.FromArgb(0, 114, 188);
                Validatelbl.ForeColor = Color.White;
                lblFinish.BackColor = Color.FromArgb(0, 114, 188);
                lblFinish.ForeColor = Color.White;
                lblSuccess.ForeColor = Color.White;


            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            school_Student_FrontPage school_Student_FrontPage = new school_Student_FrontPage();
            this.Hide();
            school_Student_FrontPage.ShowDialog();
            this.Close();
        }

        private void lblProgram_Click(object sender, EventArgs e)
        {
            Program_System program = new Program_System();
            this.Hide();
            program.ShowDialog();
            this.Close();
        }

        private void lblCampus_Click(object sender, EventArgs e)
        {
            About_STI about_STI = new About_STI();
            this.Hide();
            about_STI.ShowDialog();
            this.Close();
        }

        private void lblLAS_Click(object sender, EventArgs e)
        {
            Life_at_STI_system LAS = new Life_at_STI_system();
            this.Hide();
            LAS.ShowDialog();
            this.Close();
        }

        private void lblPayment_Click(object sender, EventArgs e)
        {
            PaymentService paymentService = new PaymentService();
            this.Hide();
            paymentService.ShowDialog();
            this.Close();
        }
    }
}
