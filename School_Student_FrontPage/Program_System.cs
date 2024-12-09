using Billing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace School_Student_FrontPage
{
    public partial class Program_System : Form
    {
        private bool isImageToggled;
        public Program_System()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\night_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel_Section.BackColor = Color.White;
            Color color = ColorTranslator.FromHtml("#fff200");
            Lbl_Program.BackColor = color;


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
                future_ready.BackColor = Color.FromArgb(255, 242, 0);
                future_ready.ForeColor = Color.FromArgb(0, 114, 188);
                be_sti.BackColor = Color.FromArgb(255, 242, 0);
                be_sti.ForeColor = Color.FromArgb(0, 114, 188);
                ITpanel.BackColor = Color.FromArgb(255, 242, 0);
                AcadPanel.BackColor = Color.FromArgb(255, 242, 0);
                BSITpanel.BackColor = Color.White;
                BSCSpanel.BackColor = Color.White;
                BSISpanel.BackColor = Color.White;
                STEMpanel.BackColor = Color.White;
                HUMSSpanel.BackColor = Color.White;
                GApanel.BackColor = Color.White;
                ABMpanel.BackColor = Color.White;
                ITlbl.ForeColor = Color.FromArgb(0, 114, 188);
                Acadlbl.ForeColor = Color.FromArgb(0, 114, 188);
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
                future_ready.BackColor = Color.FromArgb(255, 242, 0);
                future_ready.ForeColor = Color.FromArgb(0, 114, 188);
                be_sti.BackColor = Color.FromArgb(255, 242, 0);
                be_sti.ForeColor = Color.FromArgb(0, 114, 188);
                ITpanel.BackColor = Color.FromArgb(58, 51, 33);
                AcadPanel.BackColor = Color.FromArgb(58, 51, 33);
                BSITpanel.BackColor = Color.Black;
                BSCSpanel.BackColor = Color.Black;
                BSISpanel.BackColor = Color.Black;
                STEMpanel.BackColor = Color.Black;
                HUMSSpanel.BackColor = Color.Black;
                GApanel.BackColor = Color.Black;
                ABMpanel.BackColor = Color.Black;
                ITlbl.ForeColor = Color.White;
                Acadlbl.ForeColor = Color.White;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Life_at_STI_system LAS = new Life_at_STI_system();
            this.Hide();
            LAS.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            About_STI abt_sti = new About_STI();
            this.Hide();
            abt_sti.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            school_Student_FrontPage school_Student_FrontPage = new school_Student_FrontPage();
            this.Hide();
            school_Student_FrontPage.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            BSIT bsit = new BSIT();
            this.Hide();
            bsit.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            BSCS bscs = new BSCS();
            this.Hide();
            bscs.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            BSIS bsis = new BSIS();
            this.Hide();
            bsis.ShowDialog();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            STEM stem = new STEM();
            this.Hide();
            stem.ShowDialog();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HUMSS hums = new HUMSS();
            this.Hide();
            hums.ShowDialog();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            GeneralAcademic GA = new GeneralAcademic();
            this.Hide();
            GA.ShowDialog();
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Accountancy__Business__and_Management__ABM_ ABM = new Accountancy__Business__and_Management__ABM_();
            this.Hide();
            ABM.ShowDialog();
            this.Close();
        }

        private void Btn_Enroll_Click(object sender, EventArgs e)
        {
            EnrollPage1 enrollPage1 = new EnrollPage1();
            this.Hide();
            enrollPage1.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PaymentService paymentService = new PaymentService();
            this.Hide();
            paymentService.ShowDialog();
            this.Close();
        }
    }
}
