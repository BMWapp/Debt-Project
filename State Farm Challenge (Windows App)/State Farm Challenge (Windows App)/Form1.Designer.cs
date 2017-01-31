namespace State_Farm_Challenge__Windows_App_
{
    partial class Form1
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
            this.BtnAddLoan = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnPay = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddLoan
            // 
            this.BtnAddLoan.Location = new System.Drawing.Point(13, 12);
            this.BtnAddLoan.Name = "BtnAddLoan";
            this.BtnAddLoan.Size = new System.Drawing.Size(164, 23);
            this.BtnAddLoan.TabIndex = 0;
            this.BtnAddLoan.Text = "Add a Loan";
            this.BtnAddLoan.UseVisualStyleBackColor = true;
            this.BtnAddLoan.Click += new System.EventHandler(this.BtnAddLoan_Click);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(13, 41);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(164, 23);
            this.BtnView.TabIndex = 1;
            this.BtnView.Text = "View Timeline";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(12, 70);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(165, 23);
            this.BtnPay.TabIndex = 2;
            this.BtnPay.Text = "Payment Plan";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(13, 99);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(164, 23);
            this.BtnInfo.TabIndex = 3;
            this.BtnInfo.Text = "Information";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(189, 133);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnAddLoan);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddLoan;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Button BtnInfo;
    }
}

