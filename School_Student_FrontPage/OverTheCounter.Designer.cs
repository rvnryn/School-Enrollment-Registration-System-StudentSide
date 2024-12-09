namespace Billing
{
    partial class OverTheCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverTheCounter));
            this.pbSTILogo = new System.Windows.Forms.PictureBox();
            this.pbSTIHeader = new System.Windows.Forms.PictureBox();
            this.lblOverTheCounter = new System.Windows.Forms.Label();
            this.lblPayeeName = new System.Windows.Forms.Label();
            this.lblAsterisk = new System.Windows.Forms.Label();
            this.txtPayeeName = new System.Windows.Forms.TextBox();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.lblAsterisk2 = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblAsterisk3 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
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
            this.lblOverTheCounter.Location = new System.Drawing.Point(199, 281);
            this.lblOverTheCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverTheCounter.Name = "lblOverTheCounter";
            this.lblOverTheCounter.Size = new System.Drawing.Size(538, 32);
            this.lblOverTheCounter.TabIndex = 4;
            this.lblOverTheCounter.Text = "Over the Counter Payment Method";
            // 
            // lblPayeeName
            // 
            this.lblPayeeName.AutoSize = true;
            this.lblPayeeName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayeeName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPayeeName.Location = new System.Drawing.Point(256, 424);
            this.lblPayeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayeeName.Name = "lblPayeeName";
            this.lblPayeeName.Size = new System.Drawing.Size(102, 18);
            this.lblPayeeName.TabIndex = 5;
            this.lblPayeeName.Text = "Payee Name";
            // 
            // lblAsterisk
            // 
            this.lblAsterisk.AutoSize = true;
            this.lblAsterisk.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk.Location = new System.Drawing.Point(353, 424);
            this.lblAsterisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsterisk.Name = "lblAsterisk";
            this.lblAsterisk.Size = new System.Drawing.Size(19, 18);
            this.lblAsterisk.TabIndex = 6;
            this.lblAsterisk.Text = "*";
            // 
            // txtPayeeName
            // 
            this.txtPayeeName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayeeName.Location = new System.Drawing.Point(259, 452);
            this.txtPayeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayeeName.Name = "txtPayeeName";
            this.txtPayeeName.Size = new System.Drawing.Size(389, 25);
            this.txtPayeeName.TabIndex = 7;
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToPay.Location = new System.Drawing.Point(259, 594);
            this.txtAmountToPay.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(389, 25);
            this.txtAmountToPay.TabIndex = 10;
            // 
            // lblAsterisk2
            // 
            this.lblAsterisk2.AutoSize = true;
            this.lblAsterisk2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk2.Location = new System.Drawing.Point(376, 566);
            this.lblAsterisk2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsterisk2.Name = "lblAsterisk2";
            this.lblAsterisk2.Size = new System.Drawing.Size(19, 18);
            this.lblAsterisk2.TabIndex = 9;
            this.lblAsterisk2.Text = "*";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAmountToPay.Location = new System.Drawing.Point(256, 566);
            this.lblAmountToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(120, 18);
            this.lblAmountToPay.TabIndex = 8;
            this.lblAmountToPay.Text = "Amount to Pay";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(784, 452);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(389, 25);
            this.txtStudentID.TabIndex = 13;
            // 
            // lblAsterisk3
            // 
            this.lblAsterisk3.AutoSize = true;
            this.lblAsterisk3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk3.Location = new System.Drawing.Point(1013, 424);
            this.lblAsterisk3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsterisk3.Name = "lblAsterisk3";
            this.lblAsterisk3.Size = new System.Drawing.Size(19, 18);
            this.lblAsterisk3.TabIndex = 12;
            this.lblAsterisk3.Text = "*";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStudentID.Location = new System.Drawing.Point(781, 424);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(237, 18);
            this.lblStudentID.TabIndex = 11;
            this.lblStudentID.Text = "Student ID/Application Number";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(755, 642);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 41);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(969, 642);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(192, 41);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMessage.Location = new System.Drawing.Point(958, 273);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(171, 10);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Please provide the following information.";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRequired.Location = new System.Drawing.Point(958, 325);
            this.lblRequired.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(124, 10);
            this.lblRequired.TabIndex = 15;
            this.lblRequired.Text = "(*) These are required fields.";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTransaction.Location = new System.Drawing.Point(958, 304);
            this.lblTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(224, 10);
            this.lblTransaction.TabIndex = 16;
            this.lblTransaction.Text = "Transactions are subject to applicable processing fees.";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(52, 802);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 36;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // OverTheCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 854);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblAsterisk3);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.lblAsterisk2);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.txtPayeeName);
            this.Controls.Add(this.lblAsterisk);
            this.Controls.Add(this.lblPayeeName);
            this.Controls.Add(this.lblOverTheCounter);
            this.Controls.Add(this.pbSTILogo);
            this.Controls.Add(this.pbSTIHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "OverTheCounter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Service";
            this.Load += new System.EventHandler(this.OverTheCounter_Load);
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
        private System.Windows.Forms.Label lblAsterisk;
        private System.Windows.Forms.TextBox txtPayeeName;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Label lblAsterisk2;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblAsterisk3;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}