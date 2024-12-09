using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using Billing;

namespace School_Student_FrontPage
{
    public partial class EnrollPage3 : Form
    {
        public bool isImageToggled;
        public New_Student_Application_Information New_Student;
        public New_Student_Application_Information Parent;
        public New_Student_Application_Information Guardian;
        public New_Student_Application_Information course;


        public EnrollPage3(New_Student_Application_Information Student_Application, New_Student_Application_Information Course, New_Student_Application_Information ParentInfo, New_Student_Application_Information GuardianInfo)
        {
            InitializeComponent();
            this.BackColor = Color.White;
            Btn_Modes.BackgroundImage = Image.FromFile("C:\\EDP Finals\\STI image\\night_mode.png");
            Btn_Modes.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel_Section.BackColor = Color.White;

            New_Student = Student_Application;
            Parent = ParentInfo;
            Guardian = GuardianInfo;
            course = Course;

            MessageBox.Show("Course from Page 3: " + course.Course);

            lblCourse.Text = course.Course ?? "No course selected";
            lblAdmit.Text = New_Student.AdmitType ?? "Not provided";
            lblLevel.Text = New_Student.YearLevel ?? "Not provided";
            lblSchoolYear.Text = New_Student.SchoolYear ?? "Not provided";
            lblTerm.Text = New_Student.Term ?? "Not provided";

            Lbl_Student_Fname.Text = New_Student.Student_FirstName ?? "Not provided";
            Lbl_Student_Lname.Text = New_Student.Student_LastName ?? "Not provided";
            Lbl_Student_Mname.Text = New_Student.Student_MiddleName ?? "Not provided";
            Lbl_Student_Sname.Text = New_Student.Student_SuffixName ?? "Not provided";

            Lbl_Student_telNo.Text = New_Student.Student_TelephoneNumber ?? "Not provided";
            Lbl_Student_MobileNo.Text = New_Student.Student_MobileNumber.ToString() ?? "Not provided";
            Lbl_Student_Address.Text = New_Student.Student_CurrentAddress ?? "Not provided";
            lblEmail.Text = New_Student.Student_EmailAddress ?? "Not provided";
            LblBirth.Text = New_Student.Student_DateOfBirth ?? "Not provided";
            lblReligion.Text = New_Student.Student_Religion ?? "Not provided";
            lblCitizenship.Text = New_Student.Student_Citizenship ?? "Not provided";
            lblGender.Text = New_Student.Student_Gender ?? "Not provided";
            lblStatus.Text = New_Student.Student_Status ?? "Not provided";

            lblFatherAndContact.Text = $"{Parent.Father_Name} / {Parent.Father_Mobile}" ?? "Not provided";
            lblMotherAndContact.Text = $"{Parent.Mother_Name} / {Parent.Mother_Mobile}" ?? "Not provided";
            lblGuardianAndContact.Text = $"{Guardian.Guardian_Name} / {Guardian.Guardian_Mobile}" ?? "Not provided";
        }

        private void lblType_Click(object sender, EventArgs e)
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

                btnSubmit.BackColor = Color.FromArgb(255, 242, 0);
                btnSubmit.ForeColor = Color.FromArgb(0, 114, 188);
                panelSchoolInfo.BackColor = Color.FromArgb(255, 242, 0);
                lblSchoolInfo.ForeColor = Color.FromArgb(0, 114, 188);
                panelStudentInfo.BackColor = Color.FromArgb(255, 242, 0);
                lblStudentInfo.ForeColor = Color.FromArgb(0, 114, 188);
                panelParentInfo.BackColor = Color.FromArgb(255, 242, 0);
                lblParentInfo.ForeColor = Color.FromArgb(0, 114, 188);
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

                btnSubmit.BackColor = Color.FromArgb(58, 51, 33);
                btnSubmit.ForeColor = Color.White;
                panelSchoolInfo.BackColor = Color.FromArgb(58, 51, 33);
                lblSchoolInfo.ForeColor = Color.White;
                panelStudentInfo.BackColor = Color.FromArgb(58, 51, 33);
                lblStudentInfo.ForeColor = Color.White;
                panelParentInfo.BackColor = Color.FromArgb(58, 51, 33);
                lblParentInfo.ForeColor = Color.White;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=ZERO; Initial Catalog=AdminDB; Integrated Security=true;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        SqlCommand insertCommand = new SqlCommand(@"
                        INSERT INTO NEW_STUDENT_APPLICATION 
                        (
                            Admit_Type, YearLevel, Course, School_Year, Term,
                            First_Name, Middle_Name, Last_Name, Suffix_Name, Gender, Status, Citizenship, Date_Of_Birth, BirthPlace, Religion, Current_Address, Telephone_Number, Mobile_Number, Email_Address,
                            Father_Name, Father_MobileNo, Father_Email_Address, Father_Occupation,
                            Mother_Name, Mother_MobileNo, Mother_Email_Address, Mother_Occupation,
                            Guardian_Name, Guardian_MobileNo, Guardian_Email_Address, Guardian_Occupation, Guardian_Relationship
                        )
                        VALUES 
                        (@AdmitType, @YearLevel, @Course, @SchoolYear, @Term,
                        @FirstName, @MiddleName, @LastName, @SuffixName, @Gender,
                        @Status, @Citizenship, @DateOfBirth, @BirthPlace, @Religion, @CurrentAddress,
                        @TelephoneNumber, @MobileNumber, @EmailAddress,
                        @FatherName, @FatherMobile, @FatherEmail, @FatherOccupation,
                        @MotherName, @MotherMobile, @MotherEmail, @MotherOccupation,
                        @GuardianName, @GuardianMobile, @GuardianEmail, @GuardianOccupation, @GuardianRelationship);",
                                conn, transaction);

                        insertCommand.Parameters.AddWithValue("@AdmitType", New_Student.AdmitType);
                        insertCommand.Parameters.AddWithValue("@YearLevel", New_Student.YearLevel);
                        insertCommand.Parameters.AddWithValue("@Course", course.Course);
                        insertCommand.Parameters.AddWithValue("@SchoolYear", New_Student.SchoolYear);
                        insertCommand.Parameters.AddWithValue("@Term", New_Student.Term);
                        insertCommand.Parameters.AddWithValue("@FirstName", New_Student.Student_FirstName);
                        insertCommand.Parameters.AddWithValue("@MiddleName", New_Student.Student_MiddleName);
                        insertCommand.Parameters.AddWithValue("@LastName", New_Student.Student_LastName);
                        insertCommand.Parameters.AddWithValue("@SuffixName", string.IsNullOrEmpty(New_Student.Student_SuffixName) ? DBNull.Value : (object)New_Student.Student_SuffixName);
                        insertCommand.Parameters.AddWithValue("@Gender", New_Student.Student_Gender);
                        insertCommand.Parameters.AddWithValue("@Status", New_Student.Student_Status);
                        insertCommand.Parameters.AddWithValue("@Citizenship", New_Student.Student_Citizenship);
                        insertCommand.Parameters.AddWithValue("@DateOfBirth", New_Student.Student_DateOfBirth);
                        insertCommand.Parameters.AddWithValue("@BirthPlace", New_Student.Student_BirthPlace);
                        insertCommand.Parameters.AddWithValue("@Religion", New_Student.Student_Religion);
                        insertCommand.Parameters.AddWithValue("@CurrentAddress", New_Student.Student_CurrentAddress);
                        insertCommand.Parameters.AddWithValue("@TelephoneNumber", New_Student.Student_TelephoneNumber);
                        insertCommand.Parameters.AddWithValue("@MobileNumber", New_Student.Student_MobileNumber);
                        insertCommand.Parameters.AddWithValue("@EmailAddress", New_Student.Student_EmailAddress);
                        insertCommand.Parameters.AddWithValue("@FatherName", Parent.Father_Name);
                        insertCommand.Parameters.AddWithValue("@FatherMobile", Parent.Father_Mobile);
                        insertCommand.Parameters.AddWithValue("@FatherEmail", Parent.Father_Email);
                        insertCommand.Parameters.AddWithValue("@FatherOccupation", string.IsNullOrEmpty(Parent.Father_Occupation) ? DBNull.Value : (object)Parent.Father_Occupation);
                        insertCommand.Parameters.AddWithValue("@MotherName", Parent.Mother_Name);
                        insertCommand.Parameters.AddWithValue("@MotherMobile", Parent.Mother_Mobile);
                        insertCommand.Parameters.AddWithValue("@MotherEmail", Parent.Mother_Email);
                        insertCommand.Parameters.AddWithValue("@MotherOccupation", string.IsNullOrEmpty(Parent.Mother_Occupation) ? DBNull.Value : (object)Parent.Mother_Occupation);
                        insertCommand.Parameters.AddWithValue("@GuardianName", Guardian.Guardian_Name);
                        insertCommand.Parameters.AddWithValue("@GuardianMobile", Guardian.Guardian_Mobile);
                        insertCommand.Parameters.AddWithValue("@GuardianEmail", Guardian.Guardian_Email);
                        insertCommand.Parameters.AddWithValue("@GuardianOccupation", string.IsNullOrEmpty(Guardian.Guardian_Occupation) ? DBNull.Value : (object)Guardian.Guardian_Occupation);
                        insertCommand.Parameters.AddWithValue("@GuardianRelationship", Guardian.Guardian_Relationship);

                        insertCommand.ExecuteNonQuery();
                        transaction.Commit();

                        DialogResult result = MessageBox.Show("Application submitted successfully!");
                        if (result == DialogResult.OK)
                        {
                            SendConfirmationEmail(New_Student.Student_EmailAddress, New_Student.Student_LastName, course.Course, "STI Ortigas-Cainta");
                        }


                        NavigateToNextPage();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void SendConfirmationEmail(string studentEmail, string studentName, string programName, string institutionName)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.office365.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("urayan.224002@ortigas-cainta.sti.edu.ph", "Arvincarlsimon747"),
                    EnableSsl = true
                };

                MailMessage message = new MailMessage
                {
                    From = new MailAddress("urayan.224002@ortigas-cainta.sti.edu.ph"),
                    Subject = "Confirmation of Your Application Submission",
                    Body = $@"
                    Dear Mr./Ms. {studentName},
                    
                    Subject: Confirmation of Your Application Submission
                    
                    Thank you for submitting your application to {institutionName}. We have received your application for admission to the {programName} and would like to confirm that it is currently under review.
                    
                    At this stage, your application is being carefully evaluated by our admissions team. Please note that this process may take several weeks. We kindly ask for your patience during this period.
                    
                    You will be notified as soon as a decision has been made regarding the approval of your application. Should any additional information or documentation be required, we will contact you directly.
                    
                    If you have any questions or require further assistance, please do not hesitate to reach out to our admissions office at 09682117634 or via email at mesina.281331@ortigas-cainta.sti.edu.ph.
                    
                    Thank you again for your interest in STI Ortigas-Cainta. We appreciate your understanding and look forward to keeping you informed about the progress of your application.
                    
                    Sincerely,
                    Michael William Mesina
                    Registrar
                    STI Ortigas-Cainta
                    ",
                    IsBodyHtml = false
                };

                message.To.Add(studentEmail);

                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending confirmation email: " + ex.Message);
            }
        }


        private void NavigateToNextPage()
        {
            EnrollPage4 enrollPage4 = new EnrollPage4();
            this.Hide();
            enrollPage4.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            EnrollPage2 enrollPage2 = new EnrollPage2(New_Student);
            this.Hide();
            enrollPage2.ShowDialog();

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
