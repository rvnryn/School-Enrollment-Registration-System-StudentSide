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
    public partial class GCash : Form
    {
        public GCash()
        {
            InitializeComponent();

            lblAsterisk2.ForeColor = Color.FromArgb(255, 0, 0);
            lblAsterisk3.ForeColor = Color.FromArgb(255, 0, 0);
            lblAsterisk4.ForeColor = Color.FromArgb(255, 0, 0);
            lblAsterisk5.ForeColor = Color.FromArgb(255, 0, 0);

            txtStudentID.BackColor = Color.FromArgb(217, 217, 217);
            txtPhoneNumber.BackColor = Color.FromArgb(217, 217, 217);
            txtPayeeName.BackColor = Color.FromArgb(217, 217, 217);
            txtAmountToPay.BackColor = Color.FromArgb(217, 217, 217);
            
            lblTransaction.ForeColor = Color.FromArgb(255, 0, 0);
            lblRequired.ForeColor = Color.FromArgb(255, 0, 0);

            btnBack.BackColor = Color.FromArgb(57, 117, 233);
            btnNext.BackColor = Color.FromArgb(57, 117, 233);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnlinePayment op = new OnlinePayment();
            this.Hide();
            op.ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields() || !ValidateStudentID() || !ValidatePhoneNumber() || !ValidatePayeeName() || !ValidateAmountToPay())
            {
                return; 
            }

            // Proceed if all validations pass
            ProceedToGCashConfirmation();
        }

        private void pbSTILogo_Click(object sender, EventArgs e)
        {
            PaymentService ps = new PaymentService();
            this.Hide();
            ps.ShowDialog();
            this.Close();
        }

        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtPayeeName.Text) ||
                string.IsNullOrWhiteSpace(txtAmountToPay.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightEmptyFields();
                return false;
            }

            ResetFieldHighlights();
            return true;
        }

        private bool ValidateStudentID()
        {
            if (!long.TryParse(txtStudentID.Text, out _) || txtStudentID.Text.Length != 11)
            {
                MessageBox.Show("Invalid Student ID. Enter exactly 11 numeric digits (Ex. 02000281331).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightField(txtStudentID);
                return false;
            }

            ResetFieldHighlight(txtStudentID);
            return true;
        }


        private bool ValidatePhoneNumber()
        {
            if (!long.TryParse(txtPhoneNumber.Text, out _) || txtPhoneNumber.Text.Length != 11)
            {        
                MessageBox.Show("Invalid Phone Number. Enter exactly 11 numeric digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightField(txtPhoneNumber);
                return false;
            }

            ResetFieldHighlight(txtPhoneNumber);
            return true;
        }

        private bool ValidatePayeeName()
        {
            if (txtPayeeName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Invalid Payee Name. Numbers are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightField(txtPayeeName);
                return false;
            }

            ResetFieldHighlight(txtPayeeName);
            return true;
        }


        private bool ValidateAmountToPay()
        {
            // Check if the input is a valid number and greater than zero
            if (!double.TryParse(txtAmountToPay.Text, out double amountToPay) || amountToPay <= 0)
            {
                // Highlight the field in red if the input is invalid
                HighlightField(txtAmountToPay);

              
                MessageBox.Show("Invalid Amount to Pay. Enter a positive numeric value greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

          
            ResetFieldHighlight(txtAmountToPay);
            return true;
        }


        private void HighlightEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text)) HighlightField(txtStudentID);
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text)) HighlightField(txtPhoneNumber);
            if (string.IsNullOrWhiteSpace(txtPayeeName.Text)) HighlightField(txtPayeeName);
            if (string.IsNullOrWhiteSpace(txtAmountToPay.Text)) HighlightField(txtAmountToPay);
        }

        private void ProceedToGCashConfirmation()
        {
            long studentID = long.Parse(txtStudentID.Text);
            long phoneNumber = long.Parse(txtPhoneNumber.Text);
            string payeeName = txtPayeeName.Text;
            double amountToPay = double.Parse(txtAmountToPay.Text);

            GCashConfirmation gcc = new GCashConfirmation(studentID, phoneNumber, payeeName, amountToPay);
            this.Hide();
            gcc.ShowDialog();
            this.Close();
        }

        private void HighlightField(Control field)
        {
            field.BackColor = Color.LightCoral;
            field.ForeColor = Color.Red;
        }

        private void ResetFieldHighlights()
        {
            ResetFieldHighlight(txtStudentID);
            ResetFieldHighlight(txtPhoneNumber);
            ResetFieldHighlight(txtPayeeName);
            ResetFieldHighlight(txtAmountToPay);
        }

        private void ResetFieldHighlight(Control field)
        {
            field.BackColor = SystemColors.Window;
            field.ForeColor = SystemColors.WindowText;
        }


        private void GCash_Load(object sender, EventArgs e)
        {

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
