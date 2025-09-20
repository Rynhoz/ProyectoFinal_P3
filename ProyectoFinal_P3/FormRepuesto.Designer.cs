namespace ProyectoFinal_P3
{
    partial class FormRepuesto
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
            txtDescripcionRepuesto = new Label();
            label5 = new Label();
            label6 = new Label();
            txtIDRepuesto = new TextBox();
            txtNombreRepuesto = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtStock = new TextBox();
            cboxFamilia = new ComboBox();
            label4 = new Label();
            btnGuardarRepuesto = new Button();
            listRepuestosInfo = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Repuestos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 62);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 1;
            label2.Text = "ID del Repuesto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 131);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // txtDescripcionRepuesto
            // 
            txtDescripcionRepuesto.AutoSize = true;
            txtDescripcionRepuesto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcionRepuesto.Location = new Point(109, 200);
            txtDescripcionRepuesto.Name = "txtDescripcionRepuesto";
            txtDescripcionRepuesto.Size = new Size(98, 23);
            txtDescripcionRepuesto.TabIndex = 3;
            txtDescripcionRepuesto.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 267);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 4;
            label5.Text = "Familia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(109, 332);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 5;
            label6.Text = "Stock";
            // 
            // txtIDRepuesto
            // 
            txtIDRepuesto.Location = new Point(109, 85);
            txtIDRepuesto.Name = "txtIDRepuesto";
            txtIDRepuesto.Size = new Size(206, 27);
            txtIDRepuesto.TabIndex = 6;
            // 
            // txtNombreRepuesto
            // 
            txtNombreRepuesto.Location = new Point(109, 154);
            txtNombreRepuesto.Name = "txtNombreRepuesto";
            txtNombreRepuesto.Size = new Size(206, 27);
            txtNombreRepuesto.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(109, 223);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(206, 27);
            txtDescripcion.TabIndex = 8;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(109, 418);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(206, 27);
            txtPrecioUnitario.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(109, 355);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(206, 27);
            txtStock.TabIndex = 10;
            // 
            // cboxFamilia
            // 
            cboxFamilia.FormattingEnabled = true;
            cboxFamilia.Location = new Point(109, 293);
            cboxFamilia.Name = "cboxFamilia";
            cboxFamilia.Size = new Size(206, 28);
            cboxFamilia.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(109, 395);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 12;
            label4.Text = "Precio Unitario";
            // 
            // btnGuardarRepuesto
            // 
            btnGuardarRepuesto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarRepuesto.Location = new Point(326, 475);
            btnGuardarRepuesto.Name = "btnGuardarRepuesto";
            btnGuardarRepuesto.Size = new Size(142, 46);
            btnGuardarRepuesto.TabIndex = 13;
            btnGuardarRepuesto.Text = "Guardar";
            btnGuardarRepuesto.UseVisualStyleBackColor = true;
            // 
            // listRepuestosInfo
            // 
            listRepuestosInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listRepuestosInfo.FormattingEnabled = true;
            listRepuestosInfo.ItemHeight = 23;
            listRepuestosInfo.Location = new Point(372, 85);
            listRepuestosInfo.Name = "listRepuestosInfo";
            listRepuestosInfo.Size = new Size(401, 349);
            listRepuestosInfo.TabIndex = 14;
            // 
            // FormRepuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 580);
            Controls.Add(listRepuestosInfo);
            Controls.Add(btnGuardarRepuesto);
            Controls.Add(label4);
            Controls.Add(cboxFamilia);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreRepuesto);
            Controls.Add(txtIDRepuesto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtDescripcionRepuesto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRepuesto";
            Text = "FormRepuesto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtDescripcionRepuesto;
        private Label label5;
        private Label label6;
        private TextBox txtIDRepuesto;
        private TextBox txtNombreRepuesto;
        private TextBox txtDescripcion;
        private TextBox txtPrecioUnitario;
        private TextBox txtStock;
        private ComboBox cboxFamilia;
        private Label label4;
        private Button btnGuardarRepuesto;
        private ListBox listRepuestosInfo;
    }
}