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
    public partial class OverTheCounter : Form
    {
        public OverTheCounter()
        {
            InitializeComponent();

            lblOverTheCounter.ForeColor = Color.FromArgb(44, 102, 184);
            lblAsterisk.ForeColor = Color.FromArgb(255, 0, 0);
            lblAsterisk2.ForeColor = Color.FromArgb(255, 0, 0);
            lblAsterisk3.ForeColor = Color.FromArgb(255, 0, 0);

            txtPayeeName.BackColor = Color.FromArgb(217, 217, 217);
            txtAmountToPay.BackColor = Color.FromArgb(217, 217, 217);
            txtStudentID.BackColor = Color.FromArgb(217, 217, 217);

            lblTransaction.ForeColor = Color.FromArgb(255, 0, 0);
            lblRequired.ForeColor = Color.FromArgb(255, 0, 0);

            btnBack.BackColor = Color.FromArgb(57, 117, 233);
            btnNext.BackColor = Color.FromArgb(57, 117, 233);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PaymentService ps = new PaymentService();
            this.Hide();
            ps.ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
 
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtPayeeName.Text) ||
                string.IsNullOrWhiteSpace(txtAmountToPay.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightEmptyFields();
                return; 
            }

            if (!long.TryParse(txtStudentID.Text, out long studentID) || txtStudentID.Text.Length != 11)
            {
                MessageBox.Show("Invalid Student ID. Enter exactly 11 numeric digits \n(Ex. 02000281331)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightField(txtStudentID); 
                return; 
            }

            if (txtPayeeName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Invalid Payee Name. Numbers are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightField(txtPayeeName); 
                return; 
            }

            if (!double.TryParse(txtAmountToPay.Text, out double amountToPay) || amountToPay <= 0)
            {
                MessageBox.Show("Invalid Amount to Pay. Enter a valid numeric value greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightField(txtAmountToPay); 
                return; 
            }

            string payeeName = txtPayeeName.Text;

            BDOConfirmation bdoc = new BDOConfirmation(studentID, payeeName, amountToPay);
            this.Hide();
            bdoc.ShowDialog();
            this.Close();

        }

        private void HighlightEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text)) HighlightField(txtStudentID);
            if (string.IsNullOrWhiteSpace(txtPayeeName.Text)) HighlightField(txtPayeeName);
            if (string.IsNullOrWhiteSpace(txtAmountToPay.Text)) HighlightField(txtAmountToPay);
        }

        private void HighlightField(Control field)
        {
            field.BackColor = Color.LightCoral;
            field.ForeColor = Color.Red;
        }
        private void ResetFieldHighlights()
        {
            ResetFieldHighlight(txtStudentID);
            ResetFieldHighlight(txtPayeeName);
            ResetFieldHighlight(txtAmountToPay);
        }

        private void ResetFieldHighlight(Control field)
        {
            field.BackColor = SystemColors.Window;
            field.ForeColor = SystemColors.WindowText;
        }

        private void pbSTILogo_Click(object sender, EventArgs e)
        {
            PaymentService ps = new PaymentService();
            this.Hide();
            ps.ShowDialog();
            this.Close();
        }

        private void OverTheCounter_Load(object sender, EventArgs e)
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
