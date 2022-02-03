namespace Ventas_ERG
{
    partial class Login
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
            this.bntIngresarU = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuarioL = new System.Windows.Forms.TextBox();
            this.txtPaswordL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntIngresarU
            // 
            this.bntIngresarU.BackColor = System.Drawing.Color.Lime;
            this.bntIngresarU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntIngresarU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntIngresarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIngresarU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntIngresarU.Location = new System.Drawing.Point(212, 441);
            this.bntIngresarU.Margin = new System.Windows.Forms.Padding(0);
            this.bntIngresarU.Name = "bntIngresarU";
            this.bntIngresarU.Size = new System.Drawing.Size(204, 50);
            this.bntIngresarU.TabIndex = 1;
            this.bntIngresarU.Text = "Ingresar";
            this.bntIngresarU.UseVisualStyleBackColor = false;
            this.bntIngresarU.Click += new System.EventHandler(this.bntIngresarU_Click);
            this.bntIngresarU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bntIngresarU_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Ventas_ERG.Properties.Resources.Boton_Salir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(494, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::Ventas_ERG.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 626);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuarioL
            // 
            this.txtUsuarioL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtUsuarioL.Location = new System.Drawing.Point(203, 298);
            this.txtUsuarioL.Name = "txtUsuarioL";
            this.txtUsuarioL.Size = new System.Drawing.Size(268, 31);
            this.txtUsuarioL.TabIndex = 3;
            this.txtUsuarioL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioL_KeyPress);
            // 
            // txtPaswordL
            // 
            this.txtPaswordL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaswordL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPaswordL.Location = new System.Drawing.Point(203, 361);
            this.txtPaswordL.Name = "txtPaswordL";
            this.txtPaswordL.Size = new System.Drawing.Size(268, 31);
            this.txtPaswordL.TabIndex = 4;
            this.txtPaswordL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPaswordL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaswordL_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(626, 626);
            this.Controls.Add(this.txtPaswordL);
            this.Controls.Add(this.txtUsuarioL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntIngresarU);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntIngresarU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsuarioL;
        private System.Windows.Forms.TextBox txtPaswordL;
    }
}