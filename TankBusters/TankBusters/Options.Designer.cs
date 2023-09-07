namespace TankBusters
{
    partial class Options
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.BorderRadius = 50;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox1.BorderRadius = 10;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.Red;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(270, 12);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 7;
            guna2ControlBox1.UseWaitCursor = true;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(14, 78);
            label1.Name = "label1";
            label1.Size = new Size(301, 50);
            label1.TabIndex = 8;
            label1.Text = "Instructions";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(3, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 221);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 211);
            label2.Name = "label2";
            label2.Size = new Size(169, 19);
            label2.TabIndex = 10;
            label2.Text = "CapPrice Tank Movement";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 339);
            label3.Name = "label3";
            label3.Size = new Size(138, 19);
            label3.TabIndex = 11;
            label3.Text = "CapPrice Tank Firing";
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.AnimatedGIF = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.SeaGreen;
            guna2Button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(60, 437);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.SpringGreen;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "Back";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(327, 494);
            Controls.Add(guna2Button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(guna2ControlBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Options";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            Load += Options_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}