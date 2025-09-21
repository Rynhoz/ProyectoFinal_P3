namespace ProyectoFinal_P3
{
    partial class FormEquipo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtIDEquipo = new TextBox();
            txtModeloEquipo = new TextBox();
            txtIDCliente = new TextBox();
            txtNumeroDESerie = new TextBox();
            cboxTipoEquipo = new ComboBox();
            label8 = new Label();
            txtDescripcionProblema = new TextBox();
            btnRegistrarEquipo = new Button();
            listRegistroEquipos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 25);
            label1.Name = "label1";
            label1.Size = new Size(163, 23);
            label1.TabIndex = 0;
            label1.Text = "Registro de Equipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 64);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 1;
            label2.Text = "ID del Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 127);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 2;
            label3.Text = "ID del Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(105, 320);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 3;
            label4.Text = "Número de Serie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(105, 195);
            label5.Name = "label5";
            label5.Size = new Size(125, 23);
            label5.TabIndex = 4;
            label5.Text = "Tipo de Equipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 387);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(105, 258);
            label7.Name = "label7";
            label7.Size = new Size(150, 23);
            label7.TabIndex = 6;
            label7.Text = "Modelo de Equipo";
            // 
            // txtIDEquipo
            // 
            txtIDEquipo.Location = new Point(105, 87);
            txtIDEquipo.Name = "txtIDEquipo";
            txtIDEquipo.Size = new Size(253, 27);
            txtIDEquipo.TabIndex = 7;
            // 
            // txtModeloEquipo
            // 
            txtModeloEquipo.Location = new Point(105, 281);
            txtModeloEquipo.Name = "txtModeloEquipo";
            txtModeloEquipo.Size = new Size(253, 27);
            txtModeloEquipo.TabIndex = 8;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(105, 156);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(253, 27);
            txtIDCliente.TabIndex = 9;
            // 
            // txtNumeroDESerie
            // 
            txtNumeroDESerie.Location = new Point(105, 343);
            txtNumeroDESerie.Name = "txtNumeroDESerie";
            txtNumeroDESerie.Size = new Size(253, 27);
            txtNumeroDESerie.TabIndex = 11;
            // 
            // cboxTipoEquipo
            // 
            cboxTipoEquipo.FormattingEnabled = true;
            cboxTipoEquipo.Location = new Point(105, 221);
            cboxTipoEquipo.Name = "cboxTipoEquipo";
            cboxTipoEquipo.Size = new Size(253, 28);
            cboxTipoEquipo.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(105, 387);
            label8.Name = "label8";
            label8.Size = new Size(204, 23);
            label8.TabIndex = 14;
            label8.Text = "Descripción del problema";
            // 
            // txtDescripcionProblema
            // 
            txtDescripcionProblema.Location = new Point(105, 410);
            txtDescripcionProblema.Name = "txtDescripcionProblema";
            txtDescripcionProblema.Size = new Size(248, 27);
            txtDescripcionProblema.TabIndex = 15;
            // 
            // btnRegistrarEquipo
            // 
            btnRegistrarEquipo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarEquipo.Location = new Point(294, 464);
            btnRegistrarEquipo.Name = "btnRegistrarEquipo";
            btnRegistrarEquipo.Size = new Size(163, 41);
            btnRegistrarEquipo.TabIndex = 16;
            btnRegistrarEquipo.Text = "Registar Equipo";
            btnRegistrarEquipo.UseVisualStyleBackColor = true;
            btnRegistrarEquipo.Click += btnRegistrarEquipo_Click;
            // 
            // listRegistroEquipos
            // 
            listRegistroEquipos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listRegistroEquipos.FormattingEnabled = true;
            listRegistroEquipos.ItemHeight = 23;
            listRegistroEquipos.Location = new Point(422, 87);
            listRegistroEquipos.Name = "listRegistroEquipos";
            listRegistroEquipos.Size = new Size(397, 349);
            listRegistroEquipos.TabIndex = 17;
            // 
            // FormEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 538);
            Controls.Add(listRegistroEquipos);
            Controls.Add(btnRegistrarEquipo);
            Controls.Add(txtDescripcionProblema);
            Controls.Add(label8);
            Controls.Add(cboxTipoEquipo);
            Controls.Add(txtNumeroDESerie);
            Controls.Add(txtIDCliente);
            Controls.Add(txtModeloEquipo);
            Controls.Add(txtIDEquipo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEquipo";
            Text = "FormEquipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtIDEquipo;
        private TextBox txtModeloEquipo;
        private TextBox txtIDCliente;
        private TextBox txtNumeroDESerie;
        private ComboBox cboxTipoEquipo;
        private Label label8;
        private TextBox txtDescripcionProblema;
        private Button btnRegistrarEquipo;
        private ListBox listRegistroEquipos;
    }
}