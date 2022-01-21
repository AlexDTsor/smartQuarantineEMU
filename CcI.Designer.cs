
namespace Person_Machine
{
    partial class CcI
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
            this.components = new System.ComponentModel.Container();
            this.VisaB = new System.Windows.Forms.Button();
            this.PaypalΒ = new System.Windows.Forms.Button();
            this.AmexB = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCCV = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbCCV = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // VisaB
            // 
            this.VisaB.BackColor = System.Drawing.Color.Transparent;
            this.VisaB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisaB.FlatAppearance.BorderSize = 0;
            this.VisaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisaB.Location = new System.Drawing.Point(136, 74);
            this.VisaB.Name = "VisaB";
            this.VisaB.Size = new System.Drawing.Size(80, 70);
            this.VisaB.TabIndex = 0;
            this.VisaB.UseVisualStyleBackColor = false;
            this.VisaB.Click += new System.EventHandler(this.VisaB_Click);
            // 
            // PaypalΒ
            // 
            this.PaypalΒ.BackColor = System.Drawing.Color.Transparent;
            this.PaypalΒ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaypalΒ.FlatAppearance.BorderSize = 0;
            this.PaypalΒ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaypalΒ.Location = new System.Drawing.Point(312, 74);
            this.PaypalΒ.Name = "PaypalΒ";
            this.PaypalΒ.Size = new System.Drawing.Size(80, 70);
            this.PaypalΒ.TabIndex = 1;
            this.PaypalΒ.UseVisualStyleBackColor = false;
            this.PaypalΒ.Click += new System.EventHandler(this.PaypalB_Click);
            // 
            // AmexB
            // 
            this.AmexB.BackColor = System.Drawing.Color.Transparent;
            this.AmexB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AmexB.FlatAppearance.BorderSize = 0;
            this.AmexB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmexB.Location = new System.Drawing.Point(485, 74);
            this.AmexB.Name = "AmexB";
            this.AmexB.Size = new System.Drawing.Size(80, 70);
            this.AmexB.TabIndex = 2;
            this.AmexB.UseVisualStyleBackColor = false;
            this.AmexB.Click += new System.EventHandler(this.AmexB_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblName.Location = new System.Drawing.Point(126, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(187, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ονομ/νυμο Ιδιοκτήτη";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumber.AutoSize = true;
            this.lblNumber.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblNumber.Location = new System.Drawing.Point(97, 223);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(216, 25);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Αριθμός Κάρτας ή Paypal";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDate.Location = new System.Drawing.Point(97, 277);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(216, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Ημερομηνία Λήξεως";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCCV
            // 
            this.lblCCV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCCV.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCCV.Location = new System.Drawing.Point(97, 328);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(214, 25);
            this.lblCCV.TabIndex = 6;
            this.lblCCV.Text = "CCV";
            this.lblCCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(332, 173);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Επώνυμο Όνομα";
            this.tbName.Size = new System.Drawing.Size(233, 31);
            this.tbName.TabIndex = 7;
            this.tbName.MouseHover += new System.EventHandler(this.tbName_MouseHover);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(332, 223);
            this.tbNum.Name = "tbNum";
            this.tbNum.PlaceholderText = "1234 5678 9012 3456";
            this.tbNum.Size = new System.Drawing.Size(233, 31);
            this.tbNum.TabIndex = 8;
            this.tbNum.MouseHover += new System.EventHandler(this.tbNum_MouseHover);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(332, 274);
            this.tbDate.Name = "tbDate";
            this.tbDate.PlaceholderText = "ΗΗ/ΜΜ/ΕΕΕΕ";
            this.tbDate.Size = new System.Drawing.Size(233, 31);
            this.tbDate.TabIndex = 9;
            this.tbDate.MouseHover += new System.EventHandler(this.tbDate_MouseHover);
            // 
            // tbCCV
            // 
            this.tbCCV.Location = new System.Drawing.Point(332, 328);
            this.tbCCV.Name = "tbCCV";
            this.tbCCV.PasswordChar = '*';
            this.tbCCV.PlaceholderText = "3 ή 4 Ψηφία";
            this.tbCCV.Size = new System.Drawing.Size(233, 31);
            this.tbCCV.TabIndex = 10;
            this.tbCCV.MouseHover += new System.EventHandler(this.tbCCV_MouseHover);
            // 
            // SaveB
            // 
            this.SaveB.BackColor = System.Drawing.Color.Transparent;
            this.SaveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveB.FlatAppearance.BorderSize = 0;
            this.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveB.Location = new System.Drawing.Point(708, 358);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(80, 80);
            this.SaveB.TabIndex = 11;
            this.SaveB.UseVisualStyleBackColor = false;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // CcI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AmexB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.tbCCV);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblCCV);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.PaypalΒ);
            this.Controls.Add(this.VisaB);
            this.Name = "CcI";
            this.Text = "Πληροφορίες Κάρτας";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VisaB;
        private System.Windows.Forms.Button PaypalΒ;
        private System.Windows.Forms.Button AmexB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbCCV;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}