
namespace CarRentalGUI.Forms
{
    partial class FrmEndBooking
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnEndBooking = new System.Windows.Forms.Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "End Bookings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Booking Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(227, 185);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(155, 20);
            this.txtBookCode.TabIndex = 29;
            this.txtBookCode.TextChanged += new System.EventHandler(this.txtBookCode_TextChanged);
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.Color.Transparent;
            this.lblBill.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(75, 257);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(131, 23);
            this.lblBill.TabIndex = 30;
            this.lblBill.Text = "price";
            this.lblBill.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(227, 227);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 20);
            this.txtPrice.TabIndex = 31;
            this.txtPrice.Visible = false;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Bill";
            this.label4.Visible = false;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(227, 279);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(155, 20);
            this.txtBill.TabIndex = 33;
            this.txtBill.Visible = false;
            // 
            // btnEndBooking
            // 
            this.btnEndBooking.Location = new System.Drawing.Point(227, 356);
            this.btnEndBooking.Name = "btnEndBooking";
            this.btnEndBooking.Size = new System.Drawing.Size(75, 23);
            this.btnEndBooking.TabIndex = 34;
            this.btnEndBooking.Text = "End";
            this.btnEndBooking.UseVisualStyleBackColor = true;
            this.btnEndBooking.Visible = false;
            this.btnEndBooking.Click += new System.EventHandler(this.btnEndBooking_Click);
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
            this.guna2GradientPanel1.Controls.Add(this.linkLabel2);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.lblBill);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -34);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(441, 520);
            this.guna2GradientPanel1.TabIndex = 59;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Car Rental Management";
            // 
            // FrmEndBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.btnEndBooking);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBookCode);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmEndBooking";
            this.Text = "FrmEndBooking";
            this.Load += new System.EventHandler(this.FrmEndBooking_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button btnEndBooking;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label5;
    }
}