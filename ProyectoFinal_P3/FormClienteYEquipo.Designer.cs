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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox4 = new ComboBox();
            textBox7 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox8 = new TextBox();
            ((ISupportInitialize)dataGridView1).BeginInit();
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
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 10F);
            textBox1.Location = new Point(34, 114);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 10F);
            textBox2.Location = new Point(34, 188);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 10F);
            textBox3.Location = new Point(34, 262);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 10F);
            textBox4.Location = new Point(34, 335);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 27);
            textBox4.TabIndex = 13;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Arial", 10F);
            button1.Location = new Point(45, 518);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(174, 46);
            button1.TabIndex = 14;
            button1.Text = "REGISTRAR CLIENTE";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10F);
            button2.Location = new Point(337, 518);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(174, 46);
            button2.TabIndex = 27;
            button2.Text = "REGISTRAR EQUIPO";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 10F);
            textBox5.Location = new Point(294, 262);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(257, 27);
            textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 10F);
            textBox6.Location = new Point(294, 188);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(257, 27);
            textBox6.TabIndex = 25;
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
            // comboBox4
            // 
            comboBox4.Font = new Font("Arial", 10F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(289, 114);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(257, 27);
            comboBox4.TabIndex = 31;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Arial", 10F);
            textBox7.Location = new Point(294, 332);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(257, 166);
            textBox7.TabIndex = 32;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DimGray;
            dataGridView1.Location = new Point(609, 82);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(415, 458);
            dataGridView1.TabIndex = 34;
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
            // textBox8
            // 
            textBox8.Font = new Font("Arial", 10F);
            textBox8.Location = new Point(34, 415);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(217, 27);
            textBox8.TabIndex = 36;
            // 
            // FormClienteYEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 626);
            Controls.Add(textBox8);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox7);
            Controls.Add(comboBox4);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormClienteYEquipo";
            Text = "FormClienteYEquipo";
            ((ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboBox4;
        private TextBox textBox7;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox8;
    }
}