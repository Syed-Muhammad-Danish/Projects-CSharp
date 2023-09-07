
namespace CarRentalGUI.Forms
{
    partial class FrmViewBooking
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
            this.bookingsGV = new System.Windows.Forms.DataGridView();
            this.isCurrentlyBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingsGV
            // 
            this.bookingsGV.AutoGenerateColumns = false;
            this.bookingsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isCurrentlyBookDataGridViewTextBoxColumn,
            this.bookCodeDataGridViewTextBoxColumn});
            this.bookingsGV.DataSource = this.bookingBindingSource;
            this.bookingsGV.Location = new System.Drawing.Point(96, 185);
            this.bookingsGV.Name = "bookingsGV";
            this.bookingsGV.Size = new System.Drawing.Size(246, 236);
            this.bookingsGV.TabIndex = 0;
            this.bookingsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // isCurrentlyBookDataGridViewTextBoxColumn
            // 
            this.isCurrentlyBookDataGridViewTextBoxColumn.DataPropertyName = "IsCurrentlyBook";
            this.isCurrentlyBookDataGridViewTextBoxColumn.HeaderText = "IsCurrentlyBook";
            this.isCurrentlyBookDataGridViewTextBoxColumn.Name = "isCurrentlyBookDataGridViewTextBoxColumn";
            // 
            // bookCodeDataGridViewTextBoxColumn
            // 
            this.bookCodeDataGridViewTextBoxColumn.DataPropertyName = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.HeaderText = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.Name = "bookCodeDataGridViewTextBoxColumn";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(CarRentalGUI.BL.Booking);
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
            this.guna2GradientPanel1.Controls.Add(this.bookingsGV);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -35);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(441, 520);
            this.guna2GradientPanel1.TabIndex = 58;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Rental Management";
            // 
            // FrmViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmViewBooking";
            this.Text = "FrmViewBooking";
            this.Load += new System.EventHandler(this.FrmViewBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCurrentlyBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
    }
}