namespace ProyectoFinal_P3
{
    partial class FormFactura
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
            label6 = new Label();
            cboxClienteFactura = new ComboBox();
            cboxEquipoFactura = new ComboBox();
            dtpFechaFactura = new DateTimePicker();
            txtImporteTotalFactura = new TextBox();
            btnEmitirFactura = new Button();
            btnExportarFactura = new Button();
            txtFactura = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 23);
            label1.Name = "label1";
            label1.Size = new Size(125, 27);
            label1.TabIndex = 0;
            label1.Text = "FACTURA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F);
            label2.Location = new Point(64, 77);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 2;
            label2.Text = "CLIENTE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.Location = new Point(64, 147);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 3;
            label3.Text = "EQUIPO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.Location = new Point(64, 218);
            label4.Name = "label4";
            label4.Size = new Size(169, 19);
            label4.TabIndex = 4;
            label4.Text = "FECHA DE EMISIÓN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F);
            label6.Location = new Point(64, 292);
            label6.Name = "label6";
            label6.Size = new Size(140, 19);
            label6.TabIndex = 6;
            label6.Text = "IMPORTE TOTAL:";
            // 
            // cboxClienteFactura
            // 
            cboxClienteFactura.BackColor = SystemColors.Window;
            cboxClienteFactura.Font = new Font("Arial", 10.2F);
            cboxClienteFactura.FormattingEnabled = true;
            cboxClienteFactura.Location = new Point(64, 100);
            cboxClienteFactura.Name = "cboxClienteFactura";
            cboxClienteFactura.Size = new Size(262, 27);
            cboxClienteFactura.TabIndex = 7;
            // 
            // cboxEquipoFactura
            // 
            cboxEquipoFactura.Font = new Font("Arial", 10.2F);
            cboxEquipoFactura.FormattingEnabled = true;
            cboxEquipoFactura.Location = new Point(64, 170);
            cboxEquipoFactura.Name = "cboxEquipoFactura";
            cboxEquipoFactura.Size = new Size(262, 27);
            cboxEquipoFactura.TabIndex = 8;
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Font = new Font("Arial", 10.2F);
            dtpFechaFactura.Location = new Point(64, 241);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(262, 27);
            dtpFechaFactura.TabIndex = 9;
            // 
            // txtImporteTotalFactura
            // 
            txtImporteTotalFactura.Font = new Font("Arial", 10.2F);
            txtImporteTotalFactura.Location = new Point(64, 315);
            txtImporteTotalFactura.Name = "txtImporteTotalFactura";
            txtImporteTotalFactura.Size = new Size(262, 27);
            txtImporteTotalFactura.TabIndex = 10;
            // 
            // btnEmitirFactura
            // 
            btnEmitirFactura.Font = new Font("Arial", 10F);
            btnEmitirFactura.Location = new Point(119, 382);
            btnEmitirFactura.Name = "btnEmitirFactura";
            btnEmitirFactura.Size = new Size(155, 46);
            btnEmitirFactura.TabIndex = 11;
            btnEmitirFactura.Text = "EMITIR FACTURA";
            btnEmitirFactura.UseVisualStyleBackColor = true;
            // 
            // btnExportarFactura
            // 
            btnExportarFactura.Enabled = false;
            btnExportarFactura.Font = new Font("Arial", 10F);
            btnExportarFactura.Location = new Point(474, 445);
            btnExportarFactura.Name = "btnExportarFactura";
            btnExportarFactura.Size = new Size(210, 46);
            btnExportarFactura.TabIndex = 12;
            btnExportarFactura.Text = "EXPORTAR FACTURA";
            btnExportarFactura.UseVisualStyleBackColor = true;
            // 
            // txtFactura
            // 
            txtFactura.Enabled = false;
            txtFactura.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFactura.Location = new Point(390, 92);
            txtFactura.Multiline = true;
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(392, 336);
            txtFactura.TabIndex = 13;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 555);
            Controls.Add(txtFactura);
            Controls.Add(btnExportarFactura);
            Controls.Add(btnEmitirFactura);
            Controls.Add(txtImporteTotalFactura);
            Controls.Add(dtpFechaFactura);
            Controls.Add(cboxEquipoFactura);
            Controls.Add(cboxClienteFactura);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFactura";
            Text = "FormFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox cboxClienteFactura;
        private ComboBox cboxEquipoFactura;
        private DateTimePicker dtpFechaFactura;
        private TextBox txtImporteTotalFactura;
        private Button btnEmitirFactura;
        private Button btnExportarFactura;
        private TextBox txtFactura;
    }
}