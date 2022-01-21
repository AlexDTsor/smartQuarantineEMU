
namespace Person_Machine
{
    partial class BaseLights
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
            this.BedroomB = new System.Windows.Forms.Button();
            this.LivingRoomB = new System.Windows.Forms.Button();
            this.KitchenB = new System.Windows.Forms.Button();
            this.FrontYardB = new System.Windows.Forms.Button();
            this.HomeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BedroomB
            // 
            this.BedroomB.BackColor = System.Drawing.Color.Transparent;
            this.BedroomB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BedroomB.FlatAppearance.BorderSize = 0;
            this.BedroomB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BedroomB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BedroomB.Location = new System.Drawing.Point(37, 340);
            this.BedroomB.Name = "BedroomB";
            this.BedroomB.Size = new System.Drawing.Size(80, 80);
            this.BedroomB.TabIndex = 0;
            this.BedroomB.UseVisualStyleBackColor = false;
            this.BedroomB.Click += new System.EventHandler(this.BedroomB_Click);
            // 
            // LivingRoomB
            // 
            this.LivingRoomB.BackColor = System.Drawing.Color.Transparent;
            this.LivingRoomB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LivingRoomB.FlatAppearance.BorderSize = 0;
            this.LivingRoomB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.LivingRoomB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LivingRoomB.Location = new System.Drawing.Point(292, 340);
            this.LivingRoomB.Name = "LivingRoomB";
            this.LivingRoomB.Size = new System.Drawing.Size(80, 80);
            this.LivingRoomB.TabIndex = 1;
            this.LivingRoomB.UseVisualStyleBackColor = false;
            this.LivingRoomB.Click += new System.EventHandler(this.LivingRoomB_Click);
            // 
            // KitchenB
            // 
            this.KitchenB.BackColor = System.Drawing.Color.Transparent;
            this.KitchenB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KitchenB.FlatAppearance.BorderSize = 0;
            this.KitchenB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.KitchenB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitchenB.Location = new System.Drawing.Point(165, 340);
            this.KitchenB.Name = "KitchenB";
            this.KitchenB.Size = new System.Drawing.Size(80, 80);
            this.KitchenB.TabIndex = 2;
            this.KitchenB.UseVisualStyleBackColor = false;
            this.KitchenB.Click += new System.EventHandler(this.KitchenB_Click);
            // 
            // FrontYardB
            // 
            this.FrontYardB.BackColor = System.Drawing.Color.Transparent;
            this.FrontYardB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FrontYardB.FlatAppearance.BorderSize = 0;
            this.FrontYardB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrontYardB.Location = new System.Drawing.Point(611, 55);
            this.FrontYardB.Name = "FrontYardB";
            this.FrontYardB.Size = new System.Drawing.Size(80, 80);
            this.FrontYardB.TabIndex = 3;
            this.FrontYardB.UseVisualStyleBackColor = false;
            this.FrontYardB.Click += new System.EventHandler(this.FrontYardB_Click);
            // 
            // HomeB
            // 
            this.HomeB.BackColor = System.Drawing.Color.Transparent;
            this.HomeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeB.FlatAppearance.BorderSize = 0;
            this.HomeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeB.Location = new System.Drawing.Point(708, 358);
            this.HomeB.Name = "HomeB";
            this.HomeB.Size = new System.Drawing.Size(80, 80);
            this.HomeB.TabIndex = 4;
            this.HomeB.UseVisualStyleBackColor = false;
            this.HomeB.Click += new System.EventHandler(this.HomeB_Click);
            // 
            // BaseLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Person_Machine.Properties.Resources.a_guide_to_human_computer_interaction_1257x550;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeB);
            this.Controls.Add(this.FrontYardB);
            this.Controls.Add(this.KitchenB);
            this.Controls.Add(this.LivingRoomB);
            this.Controls.Add(this.BedroomB);
            this.DoubleBuffered = true;
            this.Name = "BaseLights";
            this.Text = "Φώτα";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BedroomB;
        private System.Windows.Forms.Button LivingRoomB;
        private System.Windows.Forms.Button KitchenB;
        private System.Windows.Forms.Button FrontYardB;
        private System.Windows.Forms.Button HomeB;
    }
}