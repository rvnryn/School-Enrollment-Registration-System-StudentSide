namespace Billing
{
    partial class OTCInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTCInvoice));
            this.pbSTILogo = new System.Windows.Forms.PictureBox();
            this.pbSTIHeader = new System.Windows.Forms.PictureBox();
            this.lblCanPay = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblPayeeName = new System.Windows.Forms.Label();
            this.Lbl_ReferenceNo = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.Lbl_Branch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Branch1 = new System.Windows.Forms.Label();
            this.Lbl_StudentID = new System.Windows.Forms.Label();
            this.Lbl_ReferenceNo1 = new System.Windows.Forms.Label();
            this.Lbl_PayeeName = new System.Windows.Forms.Label();
            this.Lbl_AmountToPay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.pbSTILogo.TabIndex = 5;
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
            this.pbSTIHeader.TabIndex = 4;
            this.pbSTIHeader.TabStop = false;
            // 
            // lblCanPay
            // 
            this.lblCanPay.AutoSize = true;
            this.lblCanPay.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanPay.Location = new System.Drawing.Point(204, 254);
            this.lblCanPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanPay.Name = "lblCanPay";
            this.lblCanPay.Size = new System.Drawing.Size(543, 32);
            this.lblCanPay.TabIndex = 6;
            this.lblCanPay.Text = "You may now pay over the counter";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAmountToPay.Location = new System.Drawing.Point(226, 551);
            this.lblAmountToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(120, 18);
            this.lblAmountToPay.TabIndex = 16;
            this.lblAmountToPay.Text = "Amount to Pay";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStudentID.Location = new System.Drawing.Point(226, 399);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(237, 18);
            this.lblStudentID.TabIndex = 15;
            this.lblStudentID.Text = "Student ID/Application Number";
            // 
            // lblPayeeName
            // 
            this.lblPayeeName.AutoSize = true;
            this.lblPayeeName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayeeName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPayeeName.Location = new System.Drawing.Point(226, 499);
            this.lblPayeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayeeName.Name = "lblPayeeName";
            this.lblPayeeName.Size = new System.Drawing.Size(102, 18);
            this.lblPayeeName.TabIndex = 14;
            this.lblPayeeName.Text = "Payee Name";
            // 
            // Lbl_ReferenceNo
            // 
            this.Lbl_ReferenceNo.AutoSize = true;
            this.Lbl_ReferenceNo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ReferenceNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_ReferenceNo.Location = new System.Drawing.Point(226, 448);
            this.Lbl_ReferenceNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ReferenceNo.Name = "Lbl_ReferenceNo";
            this.Lbl_ReferenceNo.Size = new System.Drawing.Size(146, 18);
            this.Lbl_ReferenceNo.TabIndex = 20;
            this.Lbl_ReferenceNo.Text = "Reference Number";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(658, 617);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(192, 41);
            this.btnGoBack.TabIndex = 22;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // Lbl_Branch
            // 
            this.Lbl_Branch.AutoSize = true;
            this.Lbl_Branch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Branch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_Branch.Location = new System.Drawing.Point(226, 329);
            this.Lbl_Branch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Branch.Name = "Lbl_Branch";
            this.Lbl_Branch.Size = new System.Drawing.Size(59, 18);
            this.Lbl_Branch.TabIndex = 23;
            this.Lbl_Branch.Text = "Branch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(966, 393);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1037, 493);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1102, 393);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(952, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Partner Payment Centers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Branch1
            // 
            this.Lbl_Branch1.AutoSize = true;
            this.Lbl_Branch1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Branch1.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Branch1.Location = new System.Drawing.Point(514, 332);
            this.Lbl_Branch1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Branch1.Name = "Lbl_Branch1";
            this.Lbl_Branch1.Size = new System.Drawing.Size(161, 18);
            this.Lbl_Branch1.TabIndex = 29;
            this.Lbl_Branch1.Text = "STI Ortigas-Cainta";
            // 
            // Lbl_StudentID
            // 
            this.Lbl_StudentID.AutoSize = true;
            this.Lbl_StudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentID.ForeColor = System.Drawing.Color.Black;
            this.Lbl_StudentID.Location = new System.Drawing.Point(514, 399);
            this.Lbl_StudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_StudentID.Name = "Lbl_StudentID";
            this.Lbl_StudentID.Size = new System.Drawing.Size(0, 18);
            this.Lbl_StudentID.TabIndex = 30;
            // 
            // Lbl_ReferenceNo1
            // 
            this.Lbl_ReferenceNo1.AutoSize = true;
            this.Lbl_ReferenceNo1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ReferenceNo1.ForeColor = System.Drawing.Color.Black;
            this.Lbl_ReferenceNo1.Location = new System.Drawing.Point(514, 448);
            this.Lbl_ReferenceNo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ReferenceNo1.Name = "Lbl_ReferenceNo1";
            this.Lbl_ReferenceNo1.Size = new System.Drawing.Size(140, 18);
            this.Lbl_ReferenceNo1.TabIndex = 31;
            this.Lbl_ReferenceNo1.Text = "045827193624";
            // 
            // Lbl_PayeeName
            // 
            this.Lbl_PayeeName.AutoSize = true;
            this.Lbl_PayeeName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PayeeName.ForeColor = System.Drawing.Color.Black;
            this.Lbl_PayeeName.Location = new System.Drawing.Point(514, 499);
            this.Lbl_PayeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PayeeName.Name = "Lbl_PayeeName";
            this.Lbl_PayeeName.Size = new System.Drawing.Size(0, 18);
            this.Lbl_PayeeName.TabIndex = 32;
            // 
            // Lbl_AmountToPay
            // 
            this.Lbl_AmountToPay.AutoSize = true;
            this.Lbl_AmountToPay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AmountToPay.ForeColor = System.Drawing.Color.Black;
            this.Lbl_AmountToPay.Location = new System.Drawing.Point(514, 551);
            this.Lbl_AmountToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_AmountToPay.Name = "Lbl_AmountToPay";
            this.Lbl_AmountToPay.Size = new System.Drawing.Size(0, 18);
            this.Lbl_AmountToPay.TabIndex = 33;
            // 
            // OTCInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 854);
            this.Controls.Add(this.Lbl_AmountToPay);
            this.Controls.Add(this.Lbl_PayeeName);
            this.Controls.Add(this.Lbl_ReferenceNo1);
            this.Controls.Add(this.Lbl_StudentID);
            this.Controls.Add(this.Lbl_Branch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Branch);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.Lbl_ReferenceNo);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblPayeeName);
            this.Controls.Add(this.lblCanPay);
            this.Controls.Add(this.pbSTILogo);
            this.Controls.Add(this.pbSTIHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "OTCInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Service";
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSTILogo;
        private System.Windows.Forms.PictureBox pbSTIHeader;
        private System.Windows.Forms.Label lblCanPay;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblPayeeName;
        private System.Windows.Forms.Label Lbl_ReferenceNo;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label Lbl_Branch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Branch1;
        private System.Windows.Forms.Label Lbl_StudentID;
        private System.Windows.Forms.Label Lbl_ReferenceNo1;
        private System.Windows.Forms.Label Lbl_PayeeName;
        private System.Windows.Forms.Label Lbl_AmountToPay;
    }
}