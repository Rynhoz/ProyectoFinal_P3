namespace ProyectoFinal_P3
{
    partial class FormCliente
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
            txtIDCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtEmailCliente = new TextBox();
            label6 = new Label();
            btnRegistrarCliente = new Button();
            listClientesRegistrados = new ListBox();
            cboxNombreCliente = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 31);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Registrar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 67);
            label2.Name = "label2";
            label2.Size = new Size(27, 23);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 135);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 204);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 3;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 270);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 4;
            label5.Text = "Teléfono";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(115, 90);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(211, 27);
            txtIDCliente.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(115, 161);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(211, 27);
            txtNombreCliente.TabIndex = 6;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(115, 230);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(211, 27);
            txtDireccionCliente.TabIndex = 7;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(115, 296);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(211, 27);
            txtTelefonoCliente.TabIndex = 8;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(115, 366);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(211, 27);
            txtEmailCliente.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 340);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarCliente.Location = new Point(334, 431);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(144, 42);
            btnRegistrarCliente.TabIndex = 11;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // listClientesRegistrados
            // 
            listClientesRegistrados.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listClientesRegistrados.FormattingEnabled = true;
            listClientesRegistrados.ItemHeight = 23;
            listClientesRegistrados.Location = new Point(375, 90);
            listClientesRegistrados.Name = "listClientesRegistrados";
            listClientesRegistrados.Size = new Size(468, 303);
            listClientesRegistrados.TabIndex = 12;
            // 
            // cboxNombreCliente
            // 
            cboxNombreCliente.FormattingEnabled = true;
            cboxNombreCliente.Location = new Point(528, 431);
            cboxNombreCliente.Name = "cboxNombreCliente";
            cboxNombreCliente.Size = new Size(253, 28);
            cboxNombreCliente.TabIndex = 13;
            cboxNombreCliente.SelectedIndexChanged += cboxNombreCliente_SelectedIndexChanged;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 527);
            Controls.Add(cboxNombreCliente);
            Controls.Add(listClientesRegistrados);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(label6);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIDCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIDCliente;
        private TextBox txtNombreCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtEmailCliente;
        private Label label6;
        private Button btnRegistrarCliente;
        private ListBox listClientesRegistrados;
        private ComboBox cboxNombreCliente;
    }
}