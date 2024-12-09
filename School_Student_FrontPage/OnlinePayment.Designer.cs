namespace Billing
{
    partial class OnlinePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlinePayment));
            this.pbSTILogo = new System.Windows.Forms.PictureBox();
            this.pbSTIHeader = new System.Windows.Forms.PictureBox();
            this.lblOnlinePayment = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // lblOnlinePayment
            // 
            this.lblOnlinePayment.AutoSize = true;
            this.lblOnlinePayment.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnlinePayment.Location = new System.Drawing.Point(495, 293);
            this.lblOnlinePayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnlinePayment.Name = "lblOnlinePayment";
            this.lblOnlinePayment.Size = new System.Drawing.Size(376, 32);
            this.lblOnlinePayment.TabIndex = 5;
            this.lblOnlinePayment.Text = "Online Payment Method";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.Black;
            this.lblStudentID.Location = new System.Drawing.Point(461, 396);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(463, 26);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "Choose your preferred payment method.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(483, 489);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(773, 489);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(42, 806);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 35;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // OnlinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 854);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblOnlinePayment);
            this.Controls.Add(this.pbSTILogo);
            this.Controls.Add(this.pbSTIHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "OnlinePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Service";
            ((System.ComponentModel.ISupportInitialize)(this.pbSTILogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSTIHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSTILogo;
        private System.Windows.Forms.PictureBox pbSTIHeader;
        private System.Windows.Forms.Label lblOnlinePayment;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}