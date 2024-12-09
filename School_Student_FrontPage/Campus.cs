using Billing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace School_Student_FrontPage
{
    public partial class About_STI : Form
    {
        private bool isImageToggled;
        school_Student_FrontPage school_Student_FrontPage = new school_Student_FrontPage();
        Life_at_STI_system Life_at_STI = new Life_at_STI_system();
        public About_STI()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\night_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel_Section.BackColor = Color.White;
            PBlocation.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\location.png");
            PBlocation.BackgroundImageLayout = ImageLayout.Stretch;
            phone.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\telephone.png");
            phone.BackgroundImageLayout = ImageLayout.Stretch;
            facebook.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\facebook (1).png");
            facebook.BackgroundImageLayout = ImageLayout.Stretch;
            messenger.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\messenger.png");
            messenger.BackgroundImageLayout = ImageLayout.Stretch;

            Color color = ColorTranslator.FromHtml("#fff200");
            Lbl_Campus.BackColor = color;
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
            PBlocation.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\location.png");
            PBlocation.BackgroundImageLayout = ImageLayout.Stretch;
            phone.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\telephone.png");
            phone.BackgroundImageLayout = ImageLayout.Stretch;
            facebook.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\facebook (1).png");
            facebook.BackgroundImageLayout = ImageLayout.Stretch;
            messenger.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\messenger.png");
            messenger.BackgroundImageLayout = ImageLayout.Stretch;

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
            PBlocation.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\location_light.png");
            PBlocation.BackgroundImageLayout = ImageLayout.Stretch;
            phone.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\telephone_light.png");
            phone.BackgroundImageLayout = ImageLayout.Stretch;
            facebook.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\facebook_light.png");
            facebook.BackgroundImageLayout = ImageLayout.Stretch;
            messenger.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\messenger_light.png");
            messenger.BackgroundImageLayout = ImageLayout.Stretch;

            this.BackColor = Color.Black; // Set dark mode background

            // Update other controls (if necessary)
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.Black;
                ctrl.ForeColor = Color.White;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Hide();
            school_Student_FrontPage.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Life_at_STI.ShowDialog();
            this.Close();
        }

        private void About_STI_Load(object sender, EventArgs e)
        {
            Foundation.Parent = STI_Image;
            Foundation.BackColor = Color.Transparent;
            Foundation.ForeColor = Color.White;
            Foundation.Location = new Point(80, 265);

            lblCore.ForeColor = Color.FromArgb(44, 102, 184);

        }

        private void label9_Click(object sender, EventArgs e)
        {

            this.Hide();
            Life_at_STI.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Life_at_STI.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/ortigascainta.sti.edu");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.messenger.com/t/108450775860611/?messaging_source=source%3Apages%3Amessage_shortlink&source_id=1441792&recurring_notification=0");
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
