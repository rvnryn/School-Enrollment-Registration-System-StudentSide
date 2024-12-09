namespace Billing
{
    partial class BDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDO));
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblAsterisk2 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPayeeName = new System.Windows.Forms.TextBox();
            this.lblAsterisk4 = new System.Windows.Forms.Label();
            this.lblPayeeName = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.lblAsterisk3 = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSTIHeader = new System.Windows.Forms.PictureBox();
            this.pbSTILogo = new System.Windows.Forms.PictureBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTransaction.Location = new System.Drawing.Point(929, 282);
            this.lblTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(224, 10);
            this.lblTransaction.TabIndex = 57;
            this.lblTransaction.Text = "Transactions are subject to applicable processing fees.";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRequired.Location = new System.Drawing.Point(929, 302);
            this.lblRequired.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(124, 10);
            this.lblRequired.TabIndex = 56;
            this.lblRequired.Text = "(*) These are required fields.";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMessage.Location = new System.Drawing.Point(929, 250);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(171, 10);
            this.lblMessage.TabIndex = 55;
            this.lblMessage.Text = "Please provide the following information.";
            // 
            // lblAsterisk2
            // 
            this.lblAsterisk2.AutoSize = true;
            this.lblAsterisk2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk2.Location = new System.Drawing.Point(488, 410);
            this.lblAsterisk2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsterisk2.Name = "lblAsterisk2";
            this.lblAsterisk2.Size = new System.Drawing.Size(19, 18);
            this.lblAsterisk2.TabIndex = 54;
            this.lblAsterisk2.Text = "*";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStudentID.Location = new System.Drawing.Point(257, 410);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(237, 18);
            this.lblStudentID.TabIndex = 53;
            this.lblStudentID.Text = "Student ID/Application Number";
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(958, 640);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(192, 41);
            this.btnNext.TabIndex = 52;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(744, 640);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 41);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPayeeName
            // 
            this.txtPayeeName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayeeName.Location = new System.Drawing.Point(762, 439);
            this.txtPayeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayeeName.Name = "txtPayeeName";
            this.txtPayeeName.Size = new System.Drawing.Size(389, 25);
            this.txtPayeeName.TabIndex = 50;
            // 
            // lblAsterisk4
            // 
            this.lblAsterisk4.AutoSize = true;
            this.lblAsterisk4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk4.Location = new System.Drawing.Point(858, 410);
            this.lblAsterisk4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsterisk4.Name = "lblAsterisk4";
            this.lblAsterisk4.Size = new System.Drawing.Size(19, 18);
            this.lblAsterisk4.TabIndex = 49;
            this.lblAsterisk4.Text = "*";
            // 
            // lblPayeeName
            // 
            this.lblPayeeName.AutoSize = true;
            this.lblPayeeName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayeeName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPayeeName.Location = new System.Drawing.Point(761, 410);
            this.lblPayeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayeeName.Name = "lblPayeeName";
            this.lblPayeeName.Size = new System.Drawing.Size(102, 18);
            this.lblPayeeName.TabIndex = 48;
            this.lblPayeeName.Text = "Payee Name";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToPay.Location = new System.Drawing.Point(258, 542);
            this.txtAmountToPay.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(389, 25);
            this.txtAmountToPay.TabIndex = 47;
            // 
            // lblAsterisk3
            // 
            this.lblAsterisk3.AutoSize = true;
            this.lblAsterisk3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk3.Location = new System.Drawing.Point(375, 514);
            this.lblAsterisk3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsterisk3.Name = "lblAsterisk3";
            this.lblAsterisk3.Size = new System.Drawing.Size(19, 18);
            this.lblAsterisk3.TabIndex = 46;
            this.lblAsterisk3.Text = "*";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAmountToPay.Location = new System.Drawing.Point(257, 514);
            this.lblAmountToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(120, 18);
            this.lblAmountToPay.TabIndex = 45;
            this.lblAmountToPay.Text = "Amount to Pay";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(259, 439);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(389, 25);
            this.txtStudentID.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 274);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pbSTIHeader
            // 
            this.pbSTIHeader.Image = ((System.Drawing.Image)(resources.GetObject("pbSTIHeader.Image")));
            this.pbSTIHeader.Location = new System.Drawing.Point(-1, -1);
            this.pbSTIHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pbSTIHeader.Name = "pbSTIHeader";
            this.pbSTIHeader.Size = new System.Drawing.Size(1428, 178);
            this.pbSTIHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSTIHeader.TabIndex = 38;
            this.pbSTIHeader.TabStop = false;
            // 
            // pbSTILogo
            // 
            this.pbSTILogo.Image = ((System.Drawing.Image)(resources.GetObject("pbSTILogo.Image")));
            this.pbSTILogo.Location = new System.Drawing.Point(52, 22);
            this.pbSTILogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbSTILogo.Name = "pbSTILogo";
            this.pbSTILogo.Size = new System.Drawing.Size(214, 122);
            this.pbSTILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSTILogo.TabIndex = 61;
            this.pbSTILogo.TabStop = false;
            this.pbSTILogo.Click += new System.EventHandler(this.pbSTILogo_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(36, 806);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 62;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // BDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 854);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.pbSTILogo);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblAsterisk2);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPayeeName);
            this.Controls.Add(this.lblAsterisk4);
            this.Controls.Add(this.lblPayeeName);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.lblAsterisk3);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbSTIHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "BDO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Service";
            this.Load += new System.EventHandler(this.BDO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblAsterisk2;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPayeeName;
        private System.Windows.Forms.Label lblAsterisk4;
        private System.Windows.Forms.Label lblPayeeName;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Label lblAsterisk3;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbSTIHeader;
        private System.Windows.Forms.PictureBox pbSTILogo;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}