using Billing;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace School_Student_FrontPage
{
    public partial class EnrollPage2 : Form
    {
        private bool isImageToggled;
        public New_Student_Application_Information New_Student_Course;
        public EnrollPage2(New_Student_Application_Information course)
        {
            InitializeComponent();
            this.BackColor = Color.White;
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\night_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel_Section.BackColor = Color.White;

            New_Student_Course = course;
            MessageBox.Show($"Course from Page 2: {New_Student_Course.Course}");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            school_Student_FrontPage school_Student_FrontPage = new school_Student_FrontPage();
            this.Hide();
            school_Student_FrontPage.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnNextStep_Click(object sender, EventArgs e)
        {
            string Student_CurrentAddress = $"{txtStreetNo.Text}, {txtStreet.Text}, {txtSubd.Text}, {txtBarangay.Text}, {txtCity.Text}, {txtProvince.Text}, {txtZIPcode.Text}";
            string Student_Religion = TxtBox_Religion.Text;

            string Student_DateOfBirth = dateTimePicker_Birthday.Value.ToString("yyyy-MM-dd");
            if (long.TryParse(txtMobileNo.Text, out long Student_mobileNumber)) { }
            else
            {

            }

            string Father_Name = $"{txtFatherFN.Text} {txtFatherMI.Text} {txtFatherLN.Text} {txtFatherSuffix.Text}";
            if (long.TryParse(txtFatherNo.Text, out long Father_mobileNumber)) { }
            else
            {

            }

            string Mother_Name = $"{txtMotherFN.Text} {txtMotherMI.Text} {txtMotherLN.Text} {txtMotherSuffix.Text}";
            if (long.TryParse(txtMotherNo.Text, out long Mother_mobileNumber)) { }
            else
            {

            }

            string Guardian_Name = $"{txtGuardianFN.Text} {txtGuardianMI.Text} {txtGuardianLN.Text} {txtGuardianSuffix.Text}";
            if (long.TryParse(txtGuardianNo.Text, out long Guardian_mobileNumber)) { }
            else
            {

            }

            // Proceed to the next page

            string validationError = ValidateInputs();
            if (!string.IsNullOrEmpty(validationError))
            {
                MessageBox.Show(validationError);
                return;
            }

            New_Student_Application_Information New_Student = new New_Student_Application_Information(cbAdmitType.Text, cbYearLevel.Text, cbSchoolYear.Text, cbTerm.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtSuffix.Text, cbGender.Text, cbStatus.Text, txtCitizenship.Text, txtBirthplace.Text, TxtBox_Religion.Text, Student_CurrentAddress,
            Student_DateOfBirth, txtTelephone.Text, Student_mobileNumber, txtEmailAddress.Text);

            New_Student_Application_Information ParentInfo = new New_Student_Application_Information(Father_Name, txtFatherEmail.Text, Father_mobileNumber,  txtFatherOccup.Text, Mother_Name, txtMotherEmail.Text, Mother_mobileNumber, txtMotherOccup.Text);

            New_Student_Application_Information GuardianInfo = new New_Student_Application_Information(Guardian_Name, txtGuardianEmail.Text, Guardian_mobileNumber, txtGuardianOccup.Text, txtGuardianRelation.Text);

            EnrollPage3 enrollPage3 = new EnrollPage3(New_Student, New_Student_Course, ParentInfo, GuardianInfo);
            this.Hide();
            enrollPage3.ShowDialog();
            this.Close();


        }

        private string ValidateInputs()
        {
            // Validate Student Information
            if (string.IsNullOrWhiteSpace(txtStreetNo.Text) || string.IsNullOrWhiteSpace(txtStreet.Text) || string.IsNullOrWhiteSpace(txtSubd.Text) ||
                string.IsNullOrWhiteSpace(txtBarangay.Text) || string.IsNullOrWhiteSpace(txtCity.Text) || string.IsNullOrWhiteSpace(txtProvince.Text) ||
                string.IsNullOrWhiteSpace(txtZIPcode.Text))
            {
                return "Please fill in all address fields.";
            }

            // Validate Date of Birth
            if (dateTimePicker_Birthday.Value > DateTime.Now)
            {
                return "Date of birth cannot be in the future.";
            }

            // Validate Mobile Number for Student (Must be 11 digits including leading 0)
            if (!IsValidMobileNumber(txtMobileNo.Text))
            {
                return "Invalid Student mobile number. It should contain exactly 11 digits, starting with a 0.";
            }

            // Validate Parent Information
            if (string.IsNullOrWhiteSpace(txtFatherFN.Text) || string.IsNullOrWhiteSpace(txtFatherLN.Text))
            {
                return "Father's first and last name are required.";
            }
            if (!IsValidMobileNumber(txtFatherNo.Text))
            {
                return "Invalid Father mobile number. It should contain exactly 11 digits, starting with a 0.";
            }

            // Validate Mother's Information
            if (string.IsNullOrWhiteSpace(txtMotherFN.Text) || string.IsNullOrWhiteSpace(txtMotherLN.Text))
            {
                return "Mother's first and last name are required.";
            }
            if (!IsValidMobileNumber(txtMotherNo.Text))
            {
                return "Invalid Mother mobile number. It should contain exactly 11 digits, starting with a 0.";
            }

            // Validate Guardian Information
            if (string.IsNullOrWhiteSpace(txtGuardianFN.Text) || string.IsNullOrWhiteSpace(txtGuardianLN.Text))
            {
                return "Guardian's first and last name are required.";
            }
            if (!IsValidMobileNumber(txtGuardianNo.Text))
            {
                return "Invalid Guardian mobile number. It should contain exactly 11 digits, starting with a 0.";
            }

            // Validate Email Addresses
            if (!IsValidEmail(txtFatherEmail.Text) || !IsValidEmail(txtMotherEmail.Text) || !IsValidEmail(txtGuardianEmail.Text) || !IsValidEmail(txtEmailAddress.Text))
            {
                return "Please enter valid email addresses.";
            }

            // No errors found
            return string.Empty;
        }

        // Helper method for mobile number validation (11 digits starting with 0)
        private bool IsValidMobileNumber(string mobileNumber)
        {
            return mobileNumber.Length == 11 && mobileNumber.StartsWith("0") && mobileNumber.All(char.IsDigit);
        }

        // Helper method for email validation
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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
                lblValidate.BackColor = Color.FromArgb(0, 114, 188);
                lblValidate.ForeColor = Color.White;
                lblFinish.BackColor = Color.FromArgb(0, 114, 188);
                lblFinish.ForeColor = Color.White;

                btnNextStep.BackColor = Color.FromArgb(255, 242, 0);
                btnNextStep.ForeColor = Color.FromArgb(0, 114, 188);
                panelStudInfo.BackColor = Color.FromArgb(255, 242, 0);
                lblStudInfo.ForeColor = Color.FromArgb(0, 114, 188);
                panelAddress.BackColor = Color.FromArgb(255, 242, 0);
                lblAddress.ForeColor = Color.FromArgb(0, 114, 188);
                panelContact.BackColor = Color.FromArgb(255, 242, 0);
                lblContact.ForeColor = Color.FromArgb(0, 114, 188);
                panelParent.BackColor = Color.FromArgb(255, 242, 0);
                lblParent.ForeColor = Color.FromArgb(0, 114, 188);
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
                lblValidate.BackColor = Color.FromArgb(0, 114, 188);
                lblValidate.ForeColor = Color.White;
                lblFinish.BackColor = Color.FromArgb(0, 114, 188);
                lblFinish.ForeColor = Color.White;

                btnNextStep.BackColor = Color.FromArgb(58, 51, 33);
                btnNextStep.ForeColor = Color.White;
                panelStudInfo.BackColor = Color.FromArgb(58, 51, 33);
                lblStudInfo.ForeColor = Color.White;
                panelAddress.BackColor = Color.FromArgb(58, 51, 33);
                lblAddress.ForeColor = Color.White;
                panelContact.BackColor = Color.FromArgb(58, 51, 33);
                lblContact.ForeColor = Color.White;
                panelParent.BackColor = Color.FromArgb(58, 51, 33);
                lblParent.ForeColor = Color.White;
            }
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
