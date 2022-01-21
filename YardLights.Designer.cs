
namespace Person_Machine
{
    partial class YardLights
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SwitchB = new System.Windows.Forms.Button();
            this.HomeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(86, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 439);
            this.panel1.TabIndex = 0;
            // 
            // SwitchB
            // 
            this.SwitchB.BackColor = System.Drawing.Color.Transparent;
            this.SwitchB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwitchB.FlatAppearance.BorderSize = 0;
            this.SwitchB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SwitchB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SwitchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchB.Location = new System.Drawing.Point(10, 196);
            this.SwitchB.Name = "SwitchB";
            this.SwitchB.Size = new System.Drawing.Size(70, 70);
            this.SwitchB.TabIndex = 1;
            this.SwitchB.UseVisualStyleBackColor = false;
            this.SwitchB.Click += new System.EventHandler(this.SwitchB_Click);
            // 
            // HomeB
            // 
            this.HomeB.BackColor = System.Drawing.Color.Transparent;
            this.HomeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeB.FlatAppearance.BorderSize = 0;
            this.HomeB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HomeB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HomeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeB.Location = new System.Drawing.Point(709, 360);
            this.HomeB.Name = "HomeB";
            this.HomeB.Size = new System.Drawing.Size(70, 70);
            this.HomeB.TabIndex = 2;
            this.HomeB.UseVisualStyleBackColor = false;
            this.HomeB.Click += new System.EventHandler(this.HomeB_Click);
            // 
            // YardLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Person_Machine.Properties.Resources.FrontYard2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(791, 442);
            this.Controls.Add(this.HomeB);
            this.Controls.Add(this.SwitchB);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "YardLights";
            this.Text = "Φώτα Μποστινής Αυλής";
            this.Load += new System.EventHandler(this.YardLights_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SwitchB;
        private System.Windows.Forms.Button HomeB;
    }
}