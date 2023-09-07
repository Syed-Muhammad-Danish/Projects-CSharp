
namespace CarRentalGUI
{
    partial class AdminMenu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.viewCarToolStripMenuItem,
            this.addMaintenanceToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.viewBookingsToolStripMenuItem,
            this.backToolStripMenuItem,
            this.endBookingToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(182, 450);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Italic);
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // viewCarToolStripMenuItem
            // 
            this.viewCarToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Italic);
            this.viewCarToolStripMenuItem.Name = "viewCarToolStripMenuItem";
            this.viewCarToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.viewCarToolStripMenuItem.Text = "View Car";
            this.viewCarToolStripMenuItem.Click += new System.EventHandler(this.viewCarToolStripMenuItem_Click);
            // 
            // addMaintenanceToolStripMenuItem
            // 
            this.addMaintenanceToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Italic);
            this.addMaintenanceToolStripMenuItem.Name = "addMaintenanceToolStripMenuItem";
            this.addMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.addMaintenanceToolStripMenuItem.Text = "Add Maintenance";
            this.addMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.addMaintenanceToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Italic);
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Italic);
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.viewBookingsToolStripMenuItem.Text = "View Bookings";
            this.viewBookingsToolStripMenuItem.Click += new System.EventHandler(this.viewBookingsToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Italic);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // endBookingToolStripMenuItem
            // 
            this.endBookingToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Italic);
            this.endBookingToolStripMenuItem.Name = "endBookingToolStripMenuItem";
            this.endBookingToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.endBookingToolStripMenuItem.Text = "End Booking";
            this.endBookingToolStripMenuItem.Click += new System.EventHandler(this.endBookingToolStripMenuItem_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(176, -31);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(625, 520);
            this.guna2GradientPanel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 90);
            this.label2.TabIndex = 28;
            this.label2.Text = "Welcome! Select any Option to continue...............";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(557, 51);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Rental Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Admin Menu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endBookingToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}