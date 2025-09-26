namespace ProyectoFinal_P3
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(382, 113);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(382, 139);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "(Ej: Juan)";
            txtUsuario.Size = new Size(227, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Arial", 10F);
            txtContrasena.Location = new Point(382, 209);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = "Contraseña(12345)";
            txtContrasena.Size = new Size(227, 27);
            txtContrasena.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 183);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 10F);
            linkLabel1.Location = new Point(403, 258);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(180, 19);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvido su contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSteelBlue;
            btnLogin.Font = new Font("Arial", 10F);
            btnLogin.Location = new Point(392, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(202, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(119, 166, 192);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(684, 449);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogin);
            Controls.Add(linkLabel1);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9F);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
