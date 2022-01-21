
namespace Person_Machine
{
    partial class QplanSMS
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
            this.LinkB = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NameLbl = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ChatB = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LinkB
            // 
            this.LinkB.BackColor = System.Drawing.Color.Transparent;
            this.LinkB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LinkB.FlatAppearance.BorderSize = 0;
            this.LinkB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinkB.Location = new System.Drawing.Point(989, 499);
            this.LinkB.Name = "LinkB";
            this.LinkB.Size = new System.Drawing.Size(80, 80);
            this.LinkB.TabIndex = 0;
            this.LinkB.UseVisualStyleBackColor = false;
            this.LinkB.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "8:00 - 10:00",
            "10:00 - 12:00",
            "12:00 - 14:00",
            "14:00 - 16:00",
            "16:00 - 18:00",
            "18:00 - 20:00"});
            this.listBox1.Location = new System.Drawing.Point(40, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(115, 136);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover_1);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Items.AddRange(new object[] {
            "Μετακίνηση 1 - Εργασία",
            "Μετακίνηση 2 - Άθληση",
            "Μετακίνηση 3 - Αγορά Προϊόντων",
            "Μετακίνηση 4 - Προσφορά Βοήθειας",
            "Μετακίνηση 5 - Φαρμακείο",
            "Μετακίνηση 6 - Νοσοκομείο"});
            this.listBox2.Location = new System.Drawing.Point(40, 214);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(308, 136);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(378, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 448);
            this.label1.TabIndex = 4;
            this.label1.Text = "Μήνυμα";
            // 
            // SendB
            // 
            this.SendB.BackColor = System.Drawing.Color.Transparent;
            this.SendB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendB.FlatAppearance.BorderSize = 0;
            this.SendB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendB.Location = new System.Drawing.Point(620, 499);
            this.SendB.Name = "SendB";
            this.SendB.Size = new System.Drawing.Size(80, 80);
            this.SendB.TabIndex = 5;
            this.SendB.UseVisualStyleBackColor = false;
            this.SendB.Click += new System.EventHandler(this.SendB_Click);
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.Transparent;
            this.ExitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitB.FlatAppearance.BorderSize = 0;
            this.ExitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitB.Location = new System.Drawing.Point(1009, 428);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(60, 60);
            this.ExitB.TabIndex = 6;
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(177, 164);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(171, 31);
            this.TxtCity.TabIndex = 7;
            this.TxtCity.MouseHover += new System.EventHandler(this.TextBox1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(177, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Πόλη";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLbl.Location = new System.Drawing.Point(177, 41);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(64, 22);
            this.NameLbl.TabIndex = 15;
            this.NameLbl.Text = "Όνομα";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(177, 69);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(171, 31);
            this.TxtName.TabIndex = 16;
            this.TxtName.MouseHover += new System.EventHandler(this.TxtName_MouseHover);
            // 
            // ChatB
            // 
            this.ChatB.BackColor = System.Drawing.Color.Transparent;
            this.ChatB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChatB.FlatAppearance.BorderSize = 0;
            this.ChatB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatB.Location = new System.Drawing.Point(378, 499);
            this.ChatB.Name = "ChatB";
            this.ChatB.Size = new System.Drawing.Size(80, 80);
            this.ChatB.TabIndex = 17;
            this.ChatB.UseVisualStyleBackColor = false;
            this.ChatB.Click += new System.EventHandler(this.ChatB_Click);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 22;
            this.listBox3.Items.AddRange(new object[] {
            "ΗΣΑΠ",
            "ΜΕΤΡΟ",
            "Λεωφορείο",
            "Ι.Χ",
            "Ποδήλατο",
            "Περπάτημα"});
            this.listBox3.Location = new System.Drawing.Point(40, 369);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(115, 136);
            this.listBox3.TabIndex = 18;
            this.listBox3.MouseHover += new System.EventHandler(this.listBox3_MouseHover);
            // 
            // QplanSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Person_Machine.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(1081, 591);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.ChatB);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.SendB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LinkB);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "QplanSMS";
            this.Text = "Έξυπνο Πλάνο Καραντίνας";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LinkB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button ChatB;
        private System.Windows.Forms.ListBox listBox3;
    }
}