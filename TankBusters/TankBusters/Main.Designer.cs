namespace TankBusters
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            GameTimer = new System.Windows.Forms.Timer(components);
            BulletTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 80;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // BulletTimer
            // 
            BulletTimer.Enabled = true;
            BulletTimer.Interval = 75;
            BulletTimer.Tick += BulletTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 1;
            label2.Text = "0";
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
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.Red;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(743, 9);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 7;
            guna2ControlBox1.UseWaitCursor = true;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2ControlBox1);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Text = "TankBusters";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer BulletTimer;
        private Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}