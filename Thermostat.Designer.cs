
namespace Person_Machine
{
    partial class Thermostat
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
            this.ColdRB = new System.Windows.Forms.RadioButton();
            this.HotRB = new System.Windows.Forms.RadioButton();
            this.ThermSet = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TempVs = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThermSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ColdRB
            // 
            this.ColdRB.AutoSize = true;
            this.ColdRB.BackColor = System.Drawing.Color.PowderBlue;
            this.ColdRB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColdRB.ForeColor = System.Drawing.Color.Black;
            this.ColdRB.Location = new System.Drawing.Point(12, 12);
            this.ColdRB.Name = "ColdRB";
            this.ColdRB.Size = new System.Drawing.Size(79, 26);
            this.ColdRB.TabIndex = 0;
            this.ColdRB.TabStop = true;
            this.ColdRB.Text = "Κρύο";
            this.ColdRB.UseVisualStyleBackColor = false;
            this.ColdRB.CheckedChanged += new System.EventHandler(this.ColdRB_CheckedChanged);
            // 
            // HotRB
            // 
            this.HotRB.AutoSize = true;
            this.HotRB.BackColor = System.Drawing.Color.Tomato;
            this.HotRB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HotRB.Location = new System.Drawing.Point(264, 12);
            this.HotRB.Name = "HotRB";
            this.HotRB.Size = new System.Drawing.Size(83, 26);
            this.HotRB.TabIndex = 1;
            this.HotRB.TabStop = true;
            this.HotRB.Text = "Ζέστη";
            this.HotRB.UseVisualStyleBackColor = false;
            this.HotRB.CheckedChanged += new System.EventHandler(this.HotRB_CheckedChanged);
            // 
            // ThermSet
            // 
            this.ThermSet.Location = new System.Drawing.Point(153, 0);
            this.ThermSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThermSet.Maximum = 23;
            this.ThermSet.Minimum = 17;
            this.ThermSet.Name = "ThermSet";
            this.ThermSet.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ThermSet.Size = new System.Drawing.Size(69, 556);
            this.ThermSet.TabIndex = 0;
            this.ThermSet.Value = 20;
            this.ThermSet.Scroll += new System.EventHandler(this.ThermSet_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(126, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Αποθήκευση";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Κρεβατοκάμαρα",
            "Σαλόνι",
            "Παιδικό",
            "Κουζίνα",
            "Μπάνιο",
            "Σοφίτα"});
            this.listBox1.Location = new System.Drawing.Point(12, 637);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(336, 46);
            this.listBox1.TabIndex = 3;
            // 
            // TempVs
            // 
            this.TempVs.AutoSize = true;
            this.TempVs.Location = new System.Drawing.Point(141, 561);
            this.TempVs.Name = "TempVs";
            this.TempVs.Size = new System.Drawing.Size(73, 25);
            this.TempVs.TabIndex = 4;
            this.TempVs.Text = "TempVs";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Person_Machine.Properties.Resources.home_page;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(153, 689);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 52);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Thermostat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TempVs);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThermSet);
            this.Controls.Add(this.HotRB);
            this.Controls.Add(this.ColdRB);
            this.Name = "Thermostat";
            this.Text = "Θερμοστάτης";
            ((System.ComponentModel.ISupportInitialize)(this.ThermSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ColdRB;
        private System.Windows.Forms.RadioButton HotRB;
        private System.Windows.Forms.TrackBar ThermSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label TempVs;
        private System.Windows.Forms.Button button2;
    }
}