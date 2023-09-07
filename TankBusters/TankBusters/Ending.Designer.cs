namespace TankBusters
{
    partial class Ending
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ending));
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            label1 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox1.BorderRadius = 10;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.Red;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(261, 12);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 8;
            guna2ControlBox1.UseWaitCursor = true;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.BorderRadius = 50;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(57, 206);
            label1.Name = "label1";
            label1.Size = new Size(184, 50);
            label1.TabIndex = 9;
            label1.Text = "THE END";
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 20;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.YellowGreen;
            guna2Button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(61, 324);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.PressedColor = Color.SpringGreen;
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(180, 45);
            guna2Button2.TabIndex = 10;
            guna2Button2.Text = "Main Menu";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // Ending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(318, 512);
            Controls.Add(guna2Button2);
            Controls.Add(label1);
            Controls.Add(guna2ControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ending";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ending";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}