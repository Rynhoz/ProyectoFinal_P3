using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_P3
{
    partial class FormClienteYEquipo
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombreCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtEmailCliente = new TextBox();
            btnRegistrarCliente = new Button();
            btnRegistrarEquipo = new Button();
            txtNumeroDESerieEquipo = new TextBox();
            txtModeloEquipo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cboxTipoDEEquipo = new ComboBox();
            txtDescripcionDelProblemaEquipo = new TextBox();
            dgvMostrarClientesYEquipos = new DataGridView();
            label3 = new Label();
            txtEquipo = new TextBox();
            ((ISupportInitialize)dgvMostrarClientesYEquipos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 28);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 0;
            label1.Text = "CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(354, 28);
            label2.Name = "label2";
            label2.Size = new Size(100, 27);
            label2.TabIndex = 1;
            label2.Text = "EQUIPO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.Location = new Point(34, 82);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 4;
            label4.Text = "NOMBRE:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F);
            label5.Location = new Point(34, 156);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 5;
            label5.Text = "DIRECCIÓN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F);
            label6.Location = new Point(34, 230);
            label6.Name = "label6";
            label6.Size = new Size(99, 19);
            label6.TabIndex = 6;
            label6.Text = "TELÉFONO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F);
            label7.Location = new Point(34, 302);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 7;
            label7.Text = "EMAIL:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Arial", 10F);
            txtNombreCliente.Location = new Point(34, 114);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(217, 27);
            txtNombreCliente.TabIndex = 10;
            txtNombreCliente.TextChanged += textBox1_TextChanged;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Font = new Font("Arial", 10F);
            txtDireccionCliente.Location = new Point(34, 188);
            txtDireccionCliente.Margin = new Padding(3, 2, 3, 2);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(217, 27);
            txtDireccionCliente.TabIndex = 11;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Font = new Font("Arial", 10F);
            txtTelefonoCliente.Location = new Point(34, 262);
            txtTelefonoCliente.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(217, 27);
            txtTelefonoCliente.TabIndex = 12;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Font = new Font("Arial", 10F);
            txtEmailCliente.Location = new Point(34, 335);
            txtEmailCliente.Margin = new Padding(3, 2, 3, 2);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(217, 27);
            txtEmailCliente.TabIndex = 13;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Enabled = false;
            btnRegistrarCliente.Font = new Font("Arial", 10F);
            btnRegistrarCliente.Location = new Point(45, 518);
            btnRegistrarCliente.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(174, 46);
            btnRegistrarCliente.TabIndex = 14;
            btnRegistrarCliente.Text = "REGISTRAR CLIENTE";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEquipo
            // 
            btnRegistrarEquipo.Font = new Font("Arial", 10F);
            btnRegistrarEquipo.Location = new Point(337, 518);
            btnRegistrarEquipo.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarEquipo.Name = "btnRegistrarEquipo";
            btnRegistrarEquipo.Size = new Size(174, 46);
            btnRegistrarEquipo.TabIndex = 27;
            btnRegistrarEquipo.Text = "REGISTRAR EQUIPO";
            btnRegistrarEquipo.UseVisualStyleBackColor = true;
            // 
            // txtNumeroDESerieEquipo
            // 
            txtNumeroDESerieEquipo.Font = new Font("Arial", 10F);
            txtNumeroDESerieEquipo.Location = new Point(294, 262);
            txtNumeroDESerieEquipo.Margin = new Padding(3, 2, 3, 2);
            txtNumeroDESerieEquipo.Name = "txtNumeroDESerieEquipo";
            txtNumeroDESerieEquipo.Size = new Size(257, 27);
            txtNumeroDESerieEquipo.TabIndex = 26;
            // 
            // txtModeloEquipo
            // 
            txtModeloEquipo.Font = new Font("Arial", 10F);
            txtModeloEquipo.Location = new Point(294, 188);
            txtModeloEquipo.Margin = new Padding(3, 2, 3, 2);
            txtModeloEquipo.Name = "txtModeloEquipo";
            txtModeloEquipo.Size = new Size(257, 27);
            txtModeloEquipo.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10F);
            label9.Location = new Point(294, 300);
            label9.Name = "label9";
            label9.Size = new Size(257, 19);
            label9.TabIndex = 21;
            label9.Text = "DESCRIPCIÓN DEL PROBLEMA:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F);
            label10.Location = new Point(289, 229);
            label10.Name = "label10";
            label10.Size = new Size(114, 19);
            label10.TabIndex = 20;
            label10.Text = "N° DE SERIE:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10F);
            label11.Location = new Point(289, 156);
            label11.Name = "label11";
            label11.Size = new Size(83, 19);
            label11.TabIndex = 19;
            label11.Text = "MODELO:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10F);
            label12.Location = new Point(296, 82);
            label12.Name = "label12";
            label12.Size = new Size(146, 19);
            label12.TabIndex = 18;
            label12.Text = "TIPO DE EQUIPO:";
            // 
            // cboxTipoDEEquipo
            // 
            cboxTipoDEEquipo.Font = new Font("Arial", 10F);
            cboxTipoDEEquipo.FormattingEnabled = true;
            cboxTipoDEEquipo.Location = new Point(289, 114);
            cboxTipoDEEquipo.Margin = new Padding(3, 2, 3, 2);
            cboxTipoDEEquipo.Name = "cboxTipoDEEquipo";
            cboxTipoDEEquipo.Size = new Size(257, 27);
            cboxTipoDEEquipo.TabIndex = 31;
            // 
            // txtDescripcionDelProblemaEquipo
            // 
            txtDescripcionDelProblemaEquipo.Font = new Font("Arial", 10F);
            txtDescripcionDelProblemaEquipo.Location = new Point(294, 332);
            txtDescripcionDelProblemaEquipo.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionDelProblemaEquipo.Multiline = true;
            txtDescripcionDelProblemaEquipo.Name = "txtDescripcionDelProblemaEquipo";
            txtDescripcionDelProblemaEquipo.Size = new Size(257, 166);
            txtDescripcionDelProblemaEquipo.TabIndex = 32;
            txtDescripcionDelProblemaEquipo.TextChanged += textBox7_TextChanged;
            // 
            // dgvMostrarClientesYEquipos
            // 
            dgvMostrarClientesYEquipos.AllowUserToAddRows = false;
            dgvMostrarClientesYEquipos.AllowUserToDeleteRows = false;
            dgvMostrarClientesYEquipos.BackgroundColor = Color.LightGray;
            dgvMostrarClientesYEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarClientesYEquipos.GridColor = Color.DimGray;
            dgvMostrarClientesYEquipos.Location = new Point(609, 82);
            dgvMostrarClientesYEquipos.Margin = new Padding(3, 2, 3, 2);
            dgvMostrarClientesYEquipos.Name = "dgvMostrarClientesYEquipos";
            dgvMostrarClientesYEquipos.ReadOnly = true;
            dgvMostrarClientesYEquipos.RowHeadersWidth = 51;
            dgvMostrarClientesYEquipos.Size = new Size(415, 458);
            dgvMostrarClientesYEquipos.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.Location = new Point(34, 384);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 35;
            label3.Text = "EQUIPO:";
            // 
            // txtEquipo
            // 
            txtEquipo.Font = new Font("Arial", 10F);
            txtEquipo.Location = new Point(34, 415);
            txtEquipo.Margin = new Padding(3, 2, 3, 2);
            txtEquipo.Name = "txtEquipo";
            txtEquipo.Size = new Size(217, 27);
            txtEquipo.TabIndex = 36;
            // 
            // FormClienteYEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 626);
            Controls.Add(txtEquipo);
            Controls.Add(label3);
            Controls.Add(dgvMostrarClientesYEquipos);
            Controls.Add(txtDescripcionDelProblemaEquipo);
            Controls.Add(cboxTipoDEEquipo);
            Controls.Add(btnRegistrarEquipo);
            Controls.Add(txtNumeroDESerieEquipo);
            Controls.Add(txtModeloEquipo);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormClienteYEquipo";
            Text = "FormClienteYEquipo";
            ((ISupportInitialize)dgvMostrarClientesYEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombreCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtEmailCliente;
        private Button btnRegistrarCliente;
        private Button btnRegistrarEquipo;
        private TextBox txtNumeroDESerieEquipo;
        private TextBox txtModeloEquipo;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cboxTipoDEEquipo;
        private TextBox txtDescripcionDelProblemaEquipo;
        private DataGridView dgvMostrarClientesYEquipos;
        private Label label3;
        private TextBox txtEquipo;
    }
}