
namespace CarRentalGUI.Forms
{
    partial class FrmStartBooking
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCarDetails = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCarPlate = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 48);
            this.label3.TabIndex = 26;
            this.label3.Text = "Car Rental Management";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 25F);
            this.label1.Location = new System.Drawing.Point(288, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "Start Booking";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(364, 237);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(131, 20);
            this.txtCustName.TabIndex = 39;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(364, 285);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(131, 20);
            this.txtCustID.TabIndex = 41;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(364, 331);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(131, 20);
            this.txtCustAddress.TabIndex = 42;
            // 
            // txtCarDetails
            // 
            this.txtCarDetails.Location = new System.Drawing.Point(364, 413);
            this.txtCarDetails.Name = "txtCarDetails";
            this.txtCarDetails.Size = new System.Drawing.Size(131, 20);
            this.txtCarDetails.TabIndex = 43;
            this.txtCarDetails.Visible = false;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Items.AddRange(new object[] {
            "ECONOMY",
            "LUXURY",
            "SEDAN",
            "SUV",
            "BUS"});
            this.cmbCategories.Location = new System.Drawing.Point(364, 373);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 21);
            this.cmbCategories.TabIndex = 44;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(573, 254);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 45;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(573, 319);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 46;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Visible = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Type";
            // 
            // lblCarPlate
            // 
            this.lblCarPlate.BackColor = System.Drawing.Color.Transparent;
            this.lblCarPlate.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarPlate.Location = new System.Drawing.Point(258, 413);
            this.lblCarPlate.Name = "lblCarPlate";
            this.lblCarPlate.Size = new System.Drawing.Size(100, 23);
            this.lblCarPlate.TabIndex = 51;
            this.lblCarPlate.Text = "Type";
            this.lblCarPlate.Visible = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.linkLabel2);
            this.guna2GradientPanel1.Controls.Add(this.btnBook);
            this.guna2GradientPanel1.Controls.Add(this.lblCarPlate);
            this.guna2GradientPanel1.Controls.Add(this.btnCheck);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.txtCustAddress);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.txtCustName);
            this.guna2GradientPanel1.Controls.Add(this.txtCustID);
            this.guna2GradientPanel1.Controls.Add(this.txtCarDetails);
            this.guna2GradientPanel1.Controls.Add(this.cmbCategories);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -35);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(802, 520);
            this.guna2GradientPanel1.TabIndex = 68;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(734, 51);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmStartBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmStartBooking";
            this.Text = "FrmStartBooking";
            this.Load += new System.EventHandler(this.FrmStartBooking_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCarDetails;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCarPlate;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}