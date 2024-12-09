namespace Billing
{
    partial class OTCConfirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTCConfirmation));
            this.pbSTILogo = new System.Windows.Forms.PictureBox();
            this.pbSTIHeader = new System.Windows.Forms.PictureBox();
            this.lblOverTheCounter = new System.Windows.Forms.Label();
            this.lblPayeeName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.Lbl_StudentID = new System.Windows.Forms.Label();
            this.Lbl_PayeeName = new System.Windows.Forms.Label();
            this.Lbl_AmountToPay = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSTILogo
            // 
            this.pbSTILogo.Image = ((System.Drawing.Image)(resources.GetObject("pbSTILogo.Image")));
            this.pbSTILogo.Location = new System.Drawing.Point(52, 22);
            this.pbSTILogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbSTILogo.Name = "pbSTILogo";
            this.pbSTILogo.Size = new System.Drawing.Size(214, 122);
            this.pbSTILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSTILogo.TabIndex = 3;
            this.pbSTILogo.TabStop = false;
            this.pbSTILogo.Click += new System.EventHandler(this.pbSTILogo_Click);
            // 
            // pbSTIHeader
            // 
            this.pbSTIHeader.Image = ((System.Drawing.Image)(resources.GetObject("pbSTIHeader.Image")));
            this.pbSTIHeader.Location = new System.Drawing.Point(-1, -1);
            this.pbSTIHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pbSTIHeader.Name = "pbSTIHeader";
            this.pbSTIHeader.Size = new System.Drawing.Size(1428, 178);
            this.pbSTIHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSTIHeader.TabIndex = 2;
            this.pbSTIHeader.TabStop = false;
            // 
            // lblOverTheCounter
            // 
            this.lblOverTheCounter.AutoSize = true;
            this.lblOverTheCounter.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverTheCounter.Location = new System.Drawing.Point(388, 277);
            this.lblOverTheCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverTheCounter.Name = "lblOverTheCounter";
            this.lblOverTheCounter.Size = new System.Drawing.Size(538, 32);
            this.lblOverTheCounter.TabIndex = 5;
            this.lblOverTheCounter.Text = "Over the Counter Payment Method";
            // 
            // lblPayeeName
            // 
            this.lblPayeeName.AutoSize = true;
            this.lblPayeeName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayeeName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPayeeName.Location = new System.Drawing.Point(377, 428);
            this.lblPayeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayeeName.Name = "lblPayeeName";
            this.lblPayeeName.Size = new System.Drawing.Size(102, 18);
            this.lblPayeeName.TabIndex = 6;
            this.lblPayeeName.Text = "Payee Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStudentID.Location = new System.Drawing.Point(377, 384);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(237, 18);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "Student ID/Application Number";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAmountToPay.Location = new System.Drawing.Point(377, 472);
            this.lblAmountToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(120, 18);
            this.lblAmountToPay.TabIndex = 13;
            this.lblAmountToPay.Text = "Amount to Pay";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblConfirm.Location = new System.Drawing.Point(378, 518);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(189, 10);
            this.lblConfirm.TabIndex = 17;
            this.lblConfirm.Text = "Please Confirm that the following are correct.";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(688, 620);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 41);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(902, 620);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(192, 41);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Lbl_StudentID
            // 
            this.Lbl_StudentID.AutoSize = true;
            this.Lbl_StudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentID.ForeColor = System.Drawing.Color.Black;
            this.Lbl_StudentID.Location = new System.Drawing.Point(685, 384);
            this.Lbl_StudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_StudentID.Name = "Lbl_StudentID";
            this.Lbl_StudentID.Size = new System.Drawing.Size(0, 18);
            this.Lbl_StudentID.TabIndex = 20;
            // 
            // Lbl_PayeeName
            // 
            this.Lbl_PayeeName.AutoSize = true;
            this.Lbl_PayeeName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PayeeName.ForeColor = System.Drawing.Color.Black;
            this.Lbl_PayeeName.Location = new System.Drawing.Point(685, 428);
            this.Lbl_PayeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PayeeName.Name = "Lbl_PayeeName";
            this.Lbl_PayeeName.Size = new System.Drawing.Size(0, 18);
            this.Lbl_PayeeName.TabIndex = 21;
            // 
            // Lbl_AmountToPay
            // 
            this.Lbl_AmountToPay.AutoSize = true;
            this.Lbl_AmountToPay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AmountToPay.ForeColor = System.Drawing.Color.Black;
            this.Lbl_AmountToPay.Location = new System.Drawing.Point(685, 472);
            this.Lbl_AmountToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_AmountToPay.Name = "Lbl_AmountToPay";
            this.Lbl_AmountToPay.Size = new System.Drawing.Size(0, 18);
            this.Lbl_AmountToPay.TabIndex = 22;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(52, 797);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 23;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // OTCConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 854);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Lbl_AmountToPay);
            this.Controls.Add(this.Lbl_PayeeName);
            this.Controls.Add(this.Lbl_StudentID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblPayeeName);
            this.Controls.Add(this.lblOverTheCounter);
            this.Controls.Add(this.pbSTILogo);
            this.Controls.Add(this.pbSTIHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "OTCConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Service";
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSTILogo;
        private System.Windows.Forms.PictureBox pbSTIHeader;
        private System.Windows.Forms.Label lblOverTheCounter;
        private System.Windows.Forms.Label lblPayeeName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label Lbl_StudentID;
        private System.Windows.Forms.Label Lbl_PayeeName;
        private System.Windows.Forms.Label Lbl_AmountToPay;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}