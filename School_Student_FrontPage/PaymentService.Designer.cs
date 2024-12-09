namespace Billing
{
    partial class PaymentService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentService));
            this.pbSTIHeader = new System.Windows.Forms.PictureBox();
            this.pbSTILogo = new System.Windows.Forms.PictureBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblOtc = new System.Windows.Forms.Label();
            this.pictureBox_OnlinePayment = new System.Windows.Forms.PictureBox();
            this.pictureBox_OverTheCounter = new System.Windows.Forms.PictureBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OnlinePayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OverTheCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSTIHeader
            // 
            this.pbSTIHeader.Image = ((System.Drawing.Image)(resources.GetObject("pbSTIHeader.Image")));
            this.pbSTIHeader.Location = new System.Drawing.Point(-1, -1);
            this.pbSTIHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSTIHeader.Name = "pbSTIHeader";
            this.pbSTIHeader.Size = new System.Drawing.Size(1428, 178);
            this.pbSTIHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSTIHeader.TabIndex = 0;
            this.pbSTIHeader.TabStop = false;
            // 
            // pbSTILogo
            // 
            this.pbSTILogo.Image = ((System.Drawing.Image)(resources.GetObject("pbSTILogo.Image")));
            this.pbSTILogo.Location = new System.Drawing.Point(52, 22);
            this.pbSTILogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSTILogo.Name = "pbSTILogo";
            this.pbSTILogo.Size = new System.Drawing.Size(214, 122);
            this.pbSTILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSTILogo.TabIndex = 1;
            this.pbSTILogo.TabStop = false;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(454, 265);
            this.lblChoose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(556, 38);
            this.lblChoose.TabIndex = 2;
            this.lblChoose.Text = "Choose your payment method";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.ForeColor = System.Drawing.Color.Black;
            this.lblOnline.Location = new System.Drawing.Point(474, 574);
            this.lblOnline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(164, 14);
            this.lblOnline.TabIndex = 5;
            this.lblOnline.Text = "Online Payment Method";
            // 
            // lblOtc
            // 
            this.lblOtc.AutoSize = true;
            this.lblOtc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtc.ForeColor = System.Drawing.Color.Black;
            this.lblOtc.Location = new System.Drawing.Point(822, 574);
            this.lblOtc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtc.Name = "lblOtc";
            this.lblOtc.Size = new System.Drawing.Size(173, 14);
            this.lblOtc.TabIndex = 6;
            this.lblOtc.Text = "Over the Counter Method";
            // 
            // pictureBox_OnlinePayment
            // 
            this.pictureBox_OnlinePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_OnlinePayment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_OnlinePayment.Image")));
            this.pictureBox_OnlinePayment.Location = new System.Drawing.Point(476, 414);
            this.pictureBox_OnlinePayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_OnlinePayment.Name = "pictureBox_OnlinePayment";
            this.pictureBox_OnlinePayment.Size = new System.Drawing.Size(151, 147);
            this.pictureBox_OnlinePayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OnlinePayment.TabIndex = 7;
            this.pictureBox_OnlinePayment.TabStop = false;
            this.pictureBox_OnlinePayment.Click += new System.EventHandler(this.pictureBox_OnlinePayment_Click);
            // 
            // pictureBox_OverTheCounter
            // 
            this.pictureBox_OverTheCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_OverTheCounter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_OverTheCounter.Image")));
            this.pictureBox_OverTheCounter.Location = new System.Drawing.Point(824, 414);
            this.pictureBox_OverTheCounter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_OverTheCounter.Name = "pictureBox_OverTheCounter";
            this.pictureBox_OverTheCounter.Size = new System.Drawing.Size(151, 147);
            this.pictureBox_OverTheCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OverTheCounter.TabIndex = 8;
            this.pictureBox_OverTheCounter.TabStop = false;
            this.pictureBox_OverTheCounter.Click += new System.EventHandler(this.pictureBox_OverTheCounter_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(62, 797);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // PaymentService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 854);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.pictureBox_OverTheCounter);
            this.Controls.Add(this.pictureBox_OnlinePayment);
            this.Controls.Add(this.lblOtc);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.pbSTILogo);
            this.Controls.Add(this.pbSTIHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "PaymentService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Service";
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OnlinePayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OverTheCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSTIHeader;
        private System.Windows.Forms.PictureBox pbSTILogo;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblOtc;
        private System.Windows.Forms.PictureBox pictureBox_OnlinePayment;
        private System.Windows.Forms.PictureBox pictureBox_OverTheCounter;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}

