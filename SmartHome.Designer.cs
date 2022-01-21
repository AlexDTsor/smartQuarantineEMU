
namespace Person_Machine
{
    partial class SmartHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.φΩΣToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.κΑΜΕΡΕΣToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.φΩΣToolStripMenuItem,
            this.θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem,
            this.κΑΜΕΡΕΣToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(221, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(390, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // φΩΣToolStripMenuItem
            // 
            this.φΩΣToolStripMenuItem.Name = "φΩΣToolStripMenuItem";
            this.φΩΣToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.φΩΣToolStripMenuItem.Text = "ΦΩΣ";
            this.φΩΣToolStripMenuItem.Click += new System.EventHandler(this.φΩΣToolStripMenuItem_Click);
            // 
            // θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem
            // 
            this.θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem.Name = "θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem";
            this.θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem.Size = new System.Drawing.Size(183, 32);
            this.θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem.Text = "ΘΕΡΜΟΣΤΑΤΗΣ";
            this.θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem.Click += new System.EventHandler(this.θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem_Click);
            // 
            // κΑΜΕΡΕΣToolStripMenuItem
            // 
            this.κΑΜΕΡΕΣToolStripMenuItem.Name = "κΑΜΕΡΕΣToolStripMenuItem";
            this.κΑΜΕΡΕΣToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
            this.κΑΜΕΡΕΣToolStripMenuItem.Text = "ΚΑΜΕΡΕΣ";
            this.κΑΜΕΡΕΣToolStripMenuItem.Click += new System.EventHandler(this.κΑΜΕΡΕΣToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Person_Machine.Properties.Resources.home_page;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(771, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SmartHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SmartHome";
            this.Text = "Smart Home - Χειριστήριο";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem φΩΣToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem κΑΜΕΡΕΣToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}