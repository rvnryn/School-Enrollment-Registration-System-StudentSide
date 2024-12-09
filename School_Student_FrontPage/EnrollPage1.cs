using Billing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace School_Student_FrontPage
{
    public partial class EnrollPage1 : Form
    {
        private bool isImageToggled;
        public EnrollPage1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\night_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel_Section.BackColor = Color.White;
        }


        private void EnrollPage1_Load(object sender, EventArgs e)
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

                btnNextStep.BackColor = Color.FromArgb(255, 242, 0);
                btnNextStep.ForeColor = Color.FromArgb(0, 114, 188);
                panelType.BackColor = Color.FromArgb(255, 242, 0);
                lblType.ForeColor = Color.FromArgb(0, 114, 188);
                panelCourses.BackColor = Color.FromArgb(255, 242, 0);
                lblCourses.ForeColor = Color.FromArgb(0, 114, 188);
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

                btnNextStep.BackColor = Color.FromArgb(58, 51, 33);
                btnNextStep.ForeColor = Color.White;
                panelType.BackColor = Color.FromArgb(58, 51, 33);
                lblType.ForeColor = Color.White;
                panelCourses.BackColor = Color.FromArgb(58, 51, 33);
                lblCourses.ForeColor = Color.White;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            school_Student_FrontPage school_Student_FrontPage = new school_Student_FrontPage();
            this.Hide();
            school_Student_FrontPage.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Program_System program = new Program_System();
            this.Hide();
            program.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            About_STI about_STI = new About_STI();
            this.Hide();
            about_STI.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Life_at_STI_system LAS = new Life_at_STI_system();
            this.Hide();
            LAS.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Enroll_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            PaymentService paymentService = new PaymentService();
            this.Hide();
            paymentService.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BSTMrb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BSCpErb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BSITrb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BSCSrb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelCourses_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCourses_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelCampus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCampus_Click(object sender, EventArgs e)
        {

        }

        private void ExistingStudRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelType_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void NewStudentRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblCandP_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void Validatelbl_Click(object sender, EventArgs e)
        {

        }

        private void lblFinish_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            string validationError = ValidateStudentSelection();
            if (!string.IsNullOrEmpty(validationError))
            {
                MessageBox.Show(validationError);
                return;
            }


            string selectedCourse = string.Empty;

            if (NewStudentRB.Checked)
            {

                if (BSITrb.Checked)
                {
                    selectedCourse = BSITrb.Text;
                }
                else if (BSCSrb.Checked)
                {
                    selectedCourse = BSCSrb.Text;
                }
                else if (BSCpErb.Checked)
                {
                    selectedCourse = BSCpErb.Text;
                }
                else if (BSTMrb.Checked)
                {
                    selectedCourse = BSTMrb.Text;
                }
                else
                {
                    return;
                }

                New_Student_Application_Information New_Student = new New_Student_Application_Information(selectedCourse);

                EnrollPage2 enrollPage2 = new EnrollPage2(New_Student);
                this.Hide();
                enrollPage2.ShowDialog();
                this.Close();

            }
           
            else
            {
                MessageBox.Show("");
            }
        }

        private string ValidateStudentSelection()
        {
            // Check if a student type is selected (New or Existing)
            if (!NewStudentRB.Checked)
            {
                return "Please select a type of student.";
            }

            // Check if a course is selected when New Student is chosen
            if (NewStudentRB.Checked)
            {
                if (!BSITrb.Checked && !BSCSrb.Checked && !BSCpErb.Checked && !BSTMrb.Checked)
                {
                    return "Please select a course.";
                }
            }

            // No validation errors
            return string.Empty;
        }
    }
}
