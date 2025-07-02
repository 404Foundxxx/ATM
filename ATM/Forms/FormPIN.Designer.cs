namespace Cajero
{
    partial class FormPIN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            piPlantilla = new PictureBox();
            lblCancel = new Label();
            lblEnter = new Label();
            lblIngreseClave = new Label();
            txtPassword = new TextBox();
            lbl0 = new Label();
            lbl9 = new Label();
            lbl8 = new Label();
            lbl7 = new Label();
            lbl6 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            lblClear = new Label();
            ((System.ComponentModel.ISupportInitialize)piPlantilla).BeginInit();
            SuspendLayout();
            // 
            // piPlantilla
            // 
            piPlantilla.Dock = DockStyle.Fill;
            piPlantilla.Image = ATM.Properties.Resources.JAWA_con_tarjeta;
            piPlantilla.Location = new Point(0, 0);
            piPlantilla.Margin = new Padding(3, 2, 3, 2);
            piPlantilla.Name = "piPlantilla";
            piPlantilla.Size = new Size(700, 750);
            piPlantilla.SizeMode = PictureBoxSizeMode.StretchImage;
            piPlantilla.TabIndex = 39;
            piPlantilla.TabStop = false;
            // 
            // lblCancel
            // 
            lblCancel.AutoSize = true;
            lblCancel.BackColor = Color.FromArgb(255, 49, 49);
            lblCancel.Cursor = Cursors.Hand;
            lblCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCancel.Location = new Point(325, 529);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(54, 15);
            lblCancel.TabIndex = 13;
            lblCancel.Text = "CANCEL";
            // 
            // lblEnter
            // 
            lblEnter.AutoSize = true;
            lblEnter.BackColor = Color.FromArgb(0, 191, 99);
            lblEnter.Cursor = Cursors.Hand;
            lblEnter.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnter.Location = new Point(328, 626);
            lblEnter.Name = "lblEnter";
            lblEnter.Size = new Size(48, 15);
            lblEnter.TabIndex = 15;
            lblEnter.Text = "ENTER";
            lblEnter.Click += label3_Click;
            // 
            // lblIngreseClave
            // 
            lblIngreseClave.AutoSize = true;
            lblIngreseClave.BackColor = Color.FromArgb(0, 74, 173);
            lblIngreseClave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreseClave.ForeColor = Color.White;
            lblIngreseClave.Location = new Point(167, 179);
            lblIngreseClave.Name = "lblIngreseClave";
            lblIngreseClave.Size = new Size(118, 20);
            lblIngreseClave.TabIndex = 16;
            lblIngreseClave.Text = "Ingrese su PIN:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(167, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(166, 26);
            txtPassword.TabIndex = 17;
            // 
            // lbl0
            // 
            lbl0.AutoSize = true;
            lbl0.BackColor = Color.FromArgb(166, 166, 166);
            lbl0.Cursor = Cursors.Hand;
            lbl0.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl0.Location = new Point(143, 670);
            lbl0.Name = "lbl0";
            lbl0.Size = new Size(24, 26);
            lbl0.TabIndex = 37;
            lbl0.Text = "0";
            lbl0.Click += lbl0_Click;
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.BackColor = Color.FromArgb(166, 166, 166);
            lbl9.Cursor = Cursors.Hand;
            lbl9.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl9.Location = new Point(217, 622);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(24, 26);
            lbl9.TabIndex = 36;
            lbl9.Text = "9";
            lbl9.Click += lbl9_Click;
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.BackColor = Color.FromArgb(166, 166, 166);
            lbl8.Cursor = Cursors.Hand;
            lbl8.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl8.Location = new Point(143, 622);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(24, 26);
            lbl8.TabIndex = 35;
            lbl8.Text = "8";
            lbl8.Click += lbl8_Click;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.BackColor = Color.FromArgb(166, 166, 166);
            lbl7.Cursor = Cursors.Hand;
            lbl7.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl7.Location = new Point(66, 622);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(24, 26);
            lbl7.TabIndex = 34;
            lbl7.Text = "7";
            lbl7.Click += lbl7_Click;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.BackColor = Color.FromArgb(166, 166, 166);
            lbl6.Cursor = Cursors.Hand;
            lbl6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl6.Location = new Point(217, 574);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(24, 26);
            lbl6.TabIndex = 33;
            lbl6.Text = "6";
            lbl6.Click += lbl6_Click;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = Color.FromArgb(166, 166, 166);
            lbl5.Cursor = Cursors.Hand;
            lbl5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl5.Location = new Point(142, 574);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(24, 26);
            lbl5.TabIndex = 32;
            lbl5.Text = "5";
            lbl5.Click += lbl5_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.FromArgb(166, 166, 166);
            lbl4.Cursor = Cursors.Hand;
            lbl4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(67, 574);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(24, 26);
            lbl4.TabIndex = 31;
            lbl4.Text = "4";
            lbl4.Click += lbl4_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.FromArgb(166, 166, 166);
            lbl3.Cursor = Cursors.Hand;
            lbl3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(217, 526);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(24, 26);
            lbl3.TabIndex = 30;
            lbl3.Text = "3";
            lbl3.Click += lbl3_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.FromArgb(166, 166, 166);
            lbl2.Cursor = Cursors.Hand;
            lbl2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(142, 526);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(24, 26);
            lbl2.TabIndex = 29;
            lbl2.Text = "2";
            lbl2.Click += lbl2_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.FromArgb(166, 166, 166);
            lbl1.Cursor = Cursors.Hand;
            lbl1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(66, 526);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(24, 26);
            lbl1.TabIndex = 28;
            lbl1.Text = "1";
            lbl1.Click += lbl1_Click;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.BackColor = Color.FromArgb(255, 222, 89);
            lblClear.Cursor = Cursors.Hand;
            lblClear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClear.Location = new Point(328, 578);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(46, 15);
            lblClear.TabIndex = 38;
            lblClear.Text = "CLEAR";
            lblClear.Click += lblClear_Click;
            // 
            // FormPIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 750);
            Controls.Add(lblClear);
            Controls.Add(lbl0);
            Controls.Add(lbl9);
            Controls.Add(lbl8);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtPassword);
            Controls.Add(lblIngreseClave);
            Controls.Add(lblEnter);
            Controls.Add(lblCancel);
            Controls.Add(piPlantilla);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cajero Automatico";
            ((System.ComponentModel.ISupportInitialize)piPlantilla).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piPlantilla;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblIngreseClave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblClear;
    }
}

