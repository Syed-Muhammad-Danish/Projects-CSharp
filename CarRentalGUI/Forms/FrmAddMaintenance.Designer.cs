
namespace CarRentalGUI.Forms
{
    partial class FrmAddMaintenance
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLP = new System.Windows.Forms.Label();
            this.txtLP = new System.Windows.Forms.TextBox();
            this.lblOC = new System.Windows.Forms.Label();
            this.txtOilChange = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "AddMaintenance";
            // 
            // lblLP
            // 
            this.lblLP.BackColor = System.Drawing.Color.Transparent;
            this.lblLP.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLP.Location = new System.Drawing.Point(66, 234);
            this.lblLP.Name = "lblLP";
            this.lblLP.Size = new System.Drawing.Size(129, 28);
            this.lblLP.TabIndex = 29;
            this.lblLP.Text = "Enter License Plate";
            // 
            // txtLP
            // 
            this.txtLP.Location = new System.Drawing.Point(200, 199);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(170, 20);
            this.txtLP.TabIndex = 32;
            this.txtLP.TextChanged += new System.EventHandler(this.txtLP_TextChanged);
            // 
            // lblOC
            // 
            this.lblOC.BackColor = System.Drawing.Color.Transparent;
            this.lblOC.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOC.Location = new System.Drawing.Point(66, 294);
            this.lblOC.Name = "lblOC";
            this.lblOC.Size = new System.Drawing.Size(129, 28);
            this.lblOC.TabIndex = 33;
            this.lblOC.Text = "Enter Oil Change";
            this.lblOC.Visible = false;
            // 
            // txtOilChange
            // 
            this.txtOilChange.Location = new System.Drawing.Point(200, 260);
            this.txtOilChange.Name = "txtOilChange";
            this.txtOilChange.Size = new System.Drawing.Size(170, 20);
            this.txtOilChange.TabIndex = 34;
            this.txtOilChange.Visible = false;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(200, 311);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(170, 20);
            this.txtComments.TabIndex = 35;
            this.txtComments.Visible = false;
            // 
            // lblComments
            // 
            this.lblComments.BackColor = System.Drawing.Color.Transparent;
            this.lblComments.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(66, 346);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(129, 28);
            this.lblComments.TabIndex = 36;
            this.lblComments.Text = "Enter Comments";
            this.lblComments.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.linkLabel2);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.lblComments);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.lblOC);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.lblLP);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -35);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(441, 520);
            this.guna2GradientPanel1.TabIndex = 61;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(373, 51);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Car Rental Management";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Enter License Plate";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Enter Oil Change";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Enter Comments";
            this.label5.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.DimGray;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel2.Location = new System.Drawing.Point(30, 55);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 25);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Back";
            // 
            // FrmAddMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtOilChange);
            this.Controls.Add(this.txtLP);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmAddMaintenance";
            this.Text = "FrmAddMaintenance";
            this.Load += new System.EventHandler(this.FrmAddMaintenance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAddMaintenance_KeyDown);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLP;
        private System.Windows.Forms.TextBox txtLP;
        private System.Windows.Forms.Label lblOC;
        private System.Windows.Forms.TextBox txtOilChange;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}