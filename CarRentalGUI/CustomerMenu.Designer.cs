
namespace CarRentalGUI
{
    partial class CustomerMenu
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
            this.MessageWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageWelcome
            // 
            this.MessageWelcome.BackColor = System.Drawing.Color.Transparent;
            this.MessageWelcome.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageWelcome.Location = new System.Drawing.Point(74, 243);
            this.MessageWelcome.Name = "MessageWelcome";
            this.MessageWelcome.Size = new System.Drawing.Size(391, 90);
            this.MessageWelcome.TabIndex = 28;
            this.MessageWelcome.Text = "Welcome! Select any Option to continue...............";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookCarToolStripMenuItem,
            this.updatePersonalRecordsToolStripMenuItem,
            this.viewPerToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 450);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookCarToolStripMenuItem
            // 
            this.bookCarToolStripMenuItem.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCarToolStripMenuItem.Name = "bookCarToolStripMenuItem";
            this.bookCarToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.bookCarToolStripMenuItem.Text = "Book Car";
            this.bookCarToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.bookCarToolStripMenuItem.Click += new System.EventHandler(this.bookCarToolStripMenuItem_Click);
            // 
            // updatePersonalRecordsToolStripMenuItem
            // 
            this.updatePersonalRecordsToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F);
            this.updatePersonalRecordsToolStripMenuItem.Name = "updatePersonalRecordsToolStripMenuItem";
            this.updatePersonalRecordsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.updatePersonalRecordsToolStripMenuItem.Text = "Update Personal Records";
            this.updatePersonalRecordsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.updatePersonalRecordsToolStripMenuItem.Click += new System.EventHandler(this.updatePersonalRecordsToolStripMenuItem_Click);
            // 
            // viewPerToolStripMenuItem
            // 
            this.viewPerToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F);
            this.viewPerToolStripMenuItem.Name = "viewPerToolStripMenuItem";
            this.viewPerToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.viewPerToolStripMenuItem.Text = "View personal Records";
            this.viewPerToolStripMenuItem.Click += new System.EventHandler(this.viewPerToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Forte", 15F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
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
            this.guna2GradientPanel1.Controls.Add(this.MessageWelcome);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(186, -35);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(616, 520);
            this.guna2GradientPanel1.TabIndex = 30;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(548, 51);
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
            this.label5.Size = new System.Drawing.Size(243, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer Menu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.Load += new System.EventHandler(this.CustomerMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MessageWelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}