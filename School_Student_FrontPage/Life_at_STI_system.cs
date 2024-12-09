using Billing;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace School_Student_FrontPage
{
    public partial class Life_at_STI_system : Form
    {
        private bool isImageToggled;
        Color color = ColorTranslator.FromHtml("#fff200");
        public Life_at_STI_system()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\night_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel_Section.BackColor = Color.White;
            Lbl_LifeAtSTI.BackColor = color;


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

            }
        }

        private void Life_at_STI_system_Load(object sender, EventArgs e)
        {
            Header.Parent = Headline;
            Header.BackColor = Color.Transparent;
            Header.Location = new Point(50, 425);

            SubHeader.Parent = Headline;
            SubHeader.BackColor = Color.Transparent;
            SubHeader.Location = new Point(50, 520);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            school_Student_FrontPage school_Student_FrontPage = new school_Student_FrontPage();
            this.Hide();
            school_Student_FrontPage.ShowDialog();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            About_STI abt_sti = new About_STI();
            this.Hide();
            abt_sti.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Program_System program = new Program_System();
            this.Hide();
            program.ShowDialog();
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
