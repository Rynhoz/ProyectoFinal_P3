namespace ProyectoFinal_P3
{
    partial class FrmInicio
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
            tpFactura = new TabPage();
            numericTotal = new NumericUpDown();
            txtFactura = new TextBox();
            btnExportarFactura = new Button();
            btnEmitirFactura = new Button();
            dtpFechaFactura = new DateTimePicker();
            cboxEquipoFactura = new ComboBox();
            cboxClienteFactura = new ComboBox();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tpInventario = new TabPage();
            numericPrecio = new NumericUpDown();
            numericStock = new NumericUpDown();
            btnModificarRepuestos = new Button();
            dgvRepuestos = new DataGridView();
            btnGuardarRepuestos = new Button();
            label27 = new Label();
            cboxFamiliaRepuesto = new ComboBox();
            txtDescripcionRepuesto = new TextBox();
            txtNombreRepuesto = new TextBox();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            tpClienteYEquipo = new TabPage();
            cboxEquipoCliente = new ComboBox();
            label3 = new Label();
            dgvMostrarClientesYEquipos = new DataGridView();
            txtDescripcionDelProblemaEquipo = new TextBox();
            cboxTipoDEEquipo = new ComboBox();
            btnRegistrarEquipo = new Button();
            txtNumeroDESerieEquipo = new TextBox();
            txtModeloEquipo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnRegistrarCliente = new Button();
            txtEmailCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtNombreCliente = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tpAdministrador = new TabPage();
            btnGuardar = new Button();
            btnModificarUsuario = new Button();
            bntAnadirUsuario = new Button();
            cboxRolUsuario = new ComboBox();
            txtContrasenaUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            dgvVerUsuarios = new DataGridView();
            label18 = new Label();
            label17 = new Label();
            tabInicio = new TabControl();
            tpFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            tpInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRepuestos).BeginInit();
            tpClienteYEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarClientesYEquipos).BeginInit();
            tpAdministrador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVerUsuarios).BeginInit();
            tabInicio.SuspendLayout();
            SuspendLayout();
            // 
            // tpFactura
            // 
            tpFactura.Controls.Add(numericTotal);
            tpFactura.Controls.Add(txtFactura);
            tpFactura.Controls.Add(btnExportarFactura);
            tpFactura.Controls.Add(btnEmitirFactura);
            tpFactura.Controls.Add(dtpFechaFactura);
            tpFactura.Controls.Add(cboxEquipoFactura);
            tpFactura.Controls.Add(cboxClienteFactura);
            tpFactura.Controls.Add(label8);
            tpFactura.Controls.Add(label13);
            tpFactura.Controls.Add(label14);
            tpFactura.Controls.Add(label15);
            tpFactura.Controls.Add(label16);
            tpFactura.Location = new Point(4, 25);
            tpFactura.Margin = new Padding(3, 2, 3, 2);
            tpFactura.Name = "tpFactura";
            tpFactura.Size = new Size(1061, 664);
            tpFactura.TabIndex = 3;
            tpFactura.Text = "Factura";
            tpFactura.UseVisualStyleBackColor = true;
            // 
            // numericTotal
            // 
            numericTotal.Location = new Point(132, 362);
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(300, 23);
            numericTotal.TabIndex = 26;
            // 
            // txtFactura
            // 
            txtFactura.Enabled = false;
            txtFactura.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFactura.Location = new Point(501, 131);
            txtFactura.Multiline = true;
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(392, 336);
            txtFactura.TabIndex = 25;
            // 
            // btnExportarFactura
            // 
            btnExportarFactura.Enabled = false;
            btnExportarFactura.Font = new Font("Arial", 10F);
            btnExportarFactura.Location = new Point(585, 484);
            btnExportarFactura.Name = "btnExportarFactura";
            btnExportarFactura.Size = new Size(210, 46);
            btnExportarFactura.TabIndex = 24;
            btnExportarFactura.Text = "EXPORTAR FACTURA";
            btnExportarFactura.UseVisualStyleBackColor = true;
            // 
            // btnEmitirFactura
            // 
            btnEmitirFactura.Font = new Font("Arial", 10F);
            btnEmitirFactura.Location = new Point(187, 430);
            btnEmitirFactura.Name = "btnEmitirFactura";
            btnEmitirFactura.Size = new Size(193, 46);
            btnEmitirFactura.TabIndex = 23;
            btnEmitirFactura.Text = "EMITIR FACTURA";
            btnEmitirFactura.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Font = new Font("Arial", 10.2F);
            dtpFechaFactura.Location = new Point(132, 289);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(300, 23);
            dtpFechaFactura.TabIndex = 21;
            // 
            // cboxEquipoFactura
            // 
            cboxEquipoFactura.Font = new Font("Arial", 10.2F);
            cboxEquipoFactura.FormattingEnabled = true;
            cboxEquipoFactura.Location = new Point(132, 218);
            cboxEquipoFactura.Name = "cboxEquipoFactura";
            cboxEquipoFactura.Size = new Size(300, 24);
            cboxEquipoFactura.TabIndex = 20;
            // 
            // cboxClienteFactura
            // 
            cboxClienteFactura.BackColor = SystemColors.Window;
            cboxClienteFactura.Font = new Font("Arial", 10.2F);
            cboxClienteFactura.FormattingEnabled = true;
            cboxClienteFactura.Location = new Point(132, 148);
            cboxClienteFactura.Name = "cboxClienteFactura";
            cboxClienteFactura.Size = new Size(300, 24);
            cboxClienteFactura.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F);
            label8.Location = new Point(132, 340);
            label8.Name = "label8";
            label8.Size = new Size(122, 16);
            label8.TabIndex = 18;
            label8.Text = "IMPORTE TOTAL:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 10F);
            label13.Location = new Point(132, 266);
            label13.Name = "label13";
            label13.Size = new Size(138, 16);
            label13.TabIndex = 17;
            label13.Text = "FECHA DE EMISIÓN:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 10F);
            label14.Location = new Point(132, 195);
            label14.Name = "label14";
            label14.Size = new Size(63, 16);
            label14.TabIndex = 16;
            label14.Text = "EQUIPO:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 10F);
            label15.Location = new Point(132, 125);
            label15.Name = "label15";
            label15.Size = new Size(68, 16);
            label15.TabIndex = 15;
            label15.Text = "CLIENTE:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(455, 62);
            label16.Name = "label16";
            label16.Size = new Size(100, 22);
            label16.TabIndex = 14;
            label16.Text = "FACTURA";
            // 
            // tpInventario
            // 
            tpInventario.Controls.Add(numericPrecio);
            tpInventario.Controls.Add(numericStock);
            tpInventario.Controls.Add(btnModificarRepuestos);
            tpInventario.Controls.Add(dgvRepuestos);
            tpInventario.Controls.Add(btnGuardarRepuestos);
            tpInventario.Controls.Add(label27);
            tpInventario.Controls.Add(cboxFamiliaRepuesto);
            tpInventario.Controls.Add(txtDescripcionRepuesto);
            tpInventario.Controls.Add(txtNombreRepuesto);
            tpInventario.Controls.Add(label26);
            tpInventario.Controls.Add(label25);
            tpInventario.Controls.Add(label24);
            tpInventario.Controls.Add(label23);
            tpInventario.Controls.Add(label22);
            tpInventario.Location = new Point(4, 25);
            tpInventario.Margin = new Padding(3, 2, 3, 2);
            tpInventario.Name = "tpInventario";
            tpInventario.Size = new Size(1061, 664);
            tpInventario.TabIndex = 2;
            tpInventario.Text = "Inventario";
            tpInventario.UseVisualStyleBackColor = true;
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Location = new Point(134, 459);
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(261, 23);
            numericPrecio.TabIndex = 15;
            // 
            // numericStock
            // 
            numericStock.Location = new Point(136, 396);
            numericStock.Name = "numericStock";
            numericStock.Size = new Size(259, 23);
            numericStock.TabIndex = 14;
            // 
            // btnModificarRepuestos
            // 
            btnModificarRepuestos.Location = new Point(277, 539);
            btnModificarRepuestos.Name = "btnModificarRepuestos";
            btnModificarRepuestos.Size = new Size(163, 48);
            btnModificarRepuestos.TabIndex = 13;
            btnModificarRepuestos.Text = "MODIFICAR";
            btnModificarRepuestos.UseVisualStyleBackColor = true;
            // 
            // dgvRepuestos
            // 
            dgvRepuestos.AllowUserToAddRows = false;
            dgvRepuestos.AllowUserToDeleteRows = false;
            dgvRepuestos.BackgroundColor = Color.Gainsboro;
            dgvRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepuestos.Location = new Point(497, 78);
            dgvRepuestos.Name = "dgvRepuestos";
            dgvRepuestos.ReadOnly = true;
            dgvRepuestos.RowHeadersWidth = 51;
            dgvRepuestos.Size = new Size(487, 499);
            dgvRepuestos.TabIndex = 12;
            // 
            // btnGuardarRepuestos
            // 
            btnGuardarRepuestos.Location = new Point(74, 539);
            btnGuardarRepuestos.Name = "btnGuardarRepuestos";
            btnGuardarRepuestos.Size = new Size(148, 48);
            btnGuardarRepuestos.TabIndex = 11;
            btnGuardarRepuestos.Text = "GUARDAR";
            btnGuardarRepuestos.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(134, 437);
            label27.Name = "label27";
            label27.Size = new Size(129, 16);
            label27.TabIndex = 10;
            label27.Text = "PRECIO UNITARIO:";
            // 
            // cboxFamiliaRepuesto
            // 
            cboxFamiliaRepuesto.FormattingEnabled = true;
            cboxFamiliaRepuesto.Location = new Point(134, 327);
            cboxFamiliaRepuesto.Name = "cboxFamiliaRepuesto";
            cboxFamiliaRepuesto.Size = new Size(259, 24);
            cboxFamiliaRepuesto.TabIndex = 9;
            // 
            // txtDescripcionRepuesto
            // 
            txtDescripcionRepuesto.Location = new Point(134, 163);
            txtDescripcionRepuesto.Multiline = true;
            txtDescripcionRepuesto.Name = "txtDescripcionRepuesto";
            txtDescripcionRepuesto.Size = new Size(261, 122);
            txtDescripcionRepuesto.TabIndex = 6;
            // 
            // txtNombreRepuesto
            // 
            txtNombreRepuesto.Location = new Point(134, 100);
            txtNombreRepuesto.Name = "txtNombreRepuesto";
            txtNombreRepuesto.Size = new Size(261, 23);
            txtNombreRepuesto.TabIndex = 5;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(132, 374);
            label26.Name = "label26";
            label26.Size = new Size(63, 16);
            label26.TabIndex = 4;
            label26.Text = "STOCK: ";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(132, 305);
            label25.Name = "label25";
            label25.Size = new Size(66, 16);
            label25.TabIndex = 3;
            label25.Text = "FAMILIA: ";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(134, 141);
            label24.Name = "label24";
            label24.Size = new Size(104, 16);
            label24.TabIndex = 2;
            label24.Text = "DESCRIPCIÓN:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(134, 78);
            label23.Name = "label23";
            label23.Size = new Size(74, 16);
            label23.TabIndex = 1;
            label23.Text = "NOMBRE: ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(460, 21);
            label22.Name = "label22";
            label22.Size = new Size(129, 22);
            label22.TabIndex = 0;
            label22.Text = "REPUESTOS";
            // 
            // tpClienteYEquipo
            // 
            tpClienteYEquipo.Controls.Add(cboxEquipoCliente);
            tpClienteYEquipo.Controls.Add(label3);
            tpClienteYEquipo.Controls.Add(dgvMostrarClientesYEquipos);
            tpClienteYEquipo.Controls.Add(txtDescripcionDelProblemaEquipo);
            tpClienteYEquipo.Controls.Add(cboxTipoDEEquipo);
            tpClienteYEquipo.Controls.Add(btnRegistrarEquipo);
            tpClienteYEquipo.Controls.Add(txtNumeroDESerieEquipo);
            tpClienteYEquipo.Controls.Add(txtModeloEquipo);
            tpClienteYEquipo.Controls.Add(label9);
            tpClienteYEquipo.Controls.Add(label10);
            tpClienteYEquipo.Controls.Add(label11);
            tpClienteYEquipo.Controls.Add(label12);
            tpClienteYEquipo.Controls.Add(btnRegistrarCliente);
            tpClienteYEquipo.Controls.Add(txtEmailCliente);
            tpClienteYEquipo.Controls.Add(txtTelefonoCliente);
            tpClienteYEquipo.Controls.Add(txtDireccionCliente);
            tpClienteYEquipo.Controls.Add(txtNombreCliente);
            tpClienteYEquipo.Controls.Add(label7);
            tpClienteYEquipo.Controls.Add(label6);
            tpClienteYEquipo.Controls.Add(label5);
            tpClienteYEquipo.Controls.Add(label4);
            tpClienteYEquipo.Controls.Add(label2);
            tpClienteYEquipo.Controls.Add(label1);
            tpClienteYEquipo.Location = new Point(4, 25);
            tpClienteYEquipo.Margin = new Padding(3, 2, 3, 2);
            tpClienteYEquipo.Name = "tpClienteYEquipo";
            tpClienteYEquipo.Padding = new Padding(3, 2, 3, 2);
            tpClienteYEquipo.Size = new Size(1061, 664);
            tpClienteYEquipo.TabIndex = 1;
            tpClienteYEquipo.Text = "Cliente y Equipo";
            tpClienteYEquipo.UseVisualStyleBackColor = true;
            // 
            // cboxEquipoCliente
            // 
            cboxEquipoCliente.FormattingEnabled = true;
            cboxEquipoCliente.Location = new Point(83, 416);
            cboxEquipoCliente.Name = "cboxEquipoCliente";
            cboxEquipoCliente.Size = new Size(151, 24);
            cboxEquipoCliente.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.Location = new Point(83, 383);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 58;
            label3.Text = "EQUIPO:";
            // 
            // dgvMostrarClientesYEquipos
            // 
            dgvMostrarClientesYEquipos.AllowUserToAddRows = false;
            dgvMostrarClientesYEquipos.AllowUserToDeleteRows = false;
            dgvMostrarClientesYEquipos.BackgroundColor = Color.LightGray;
            dgvMostrarClientesYEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarClientesYEquipos.GridColor = Color.DimGray;
            dgvMostrarClientesYEquipos.Location = new Point(658, 81);
            dgvMostrarClientesYEquipos.Margin = new Padding(3, 2, 3, 2);
            dgvMostrarClientesYEquipos.Name = "dgvMostrarClientesYEquipos";
            dgvMostrarClientesYEquipos.ReadOnly = true;
            dgvMostrarClientesYEquipos.RowHeadersWidth = 51;
            dgvMostrarClientesYEquipos.Size = new Size(354, 494);
            dgvMostrarClientesYEquipos.TabIndex = 57;
            // 
            // txtDescripcionDelProblemaEquipo
            // 
            txtDescripcionDelProblemaEquipo.Font = new Font("Arial", 10F);
            txtDescripcionDelProblemaEquipo.Location = new Point(343, 331);
            txtDescripcionDelProblemaEquipo.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionDelProblemaEquipo.Multiline = true;
            txtDescripcionDelProblemaEquipo.Name = "txtDescripcionDelProblemaEquipo";
            txtDescripcionDelProblemaEquipo.Size = new Size(257, 166);
            txtDescripcionDelProblemaEquipo.TabIndex = 56;
            // 
            // cboxTipoDEEquipo
            // 
            cboxTipoDEEquipo.Font = new Font("Arial", 10F);
            cboxTipoDEEquipo.FormattingEnabled = true;
            cboxTipoDEEquipo.Location = new Point(338, 113);
            cboxTipoDEEquipo.Margin = new Padding(3, 2, 3, 2);
            cboxTipoDEEquipo.Name = "cboxTipoDEEquipo";
            cboxTipoDEEquipo.Size = new Size(196, 24);
            cboxTipoDEEquipo.TabIndex = 55;
            // 
            // btnRegistrarEquipo
            // 
            btnRegistrarEquipo.Font = new Font("Arial", 10F);
            btnRegistrarEquipo.Location = new Point(385, 517);
            btnRegistrarEquipo.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarEquipo.Name = "btnRegistrarEquipo";
            btnRegistrarEquipo.Size = new Size(179, 58);
            btnRegistrarEquipo.TabIndex = 54;
            btnRegistrarEquipo.Text = "REGISTRAR EQUIPO";
            btnRegistrarEquipo.UseVisualStyleBackColor = true;
            // 
            // txtNumeroDESerieEquipo
            // 
            txtNumeroDESerieEquipo.Font = new Font("Arial", 10F);
            txtNumeroDESerieEquipo.Location = new Point(343, 261);
            txtNumeroDESerieEquipo.Margin = new Padding(3, 2, 3, 2);
            txtNumeroDESerieEquipo.Name = "txtNumeroDESerieEquipo";
            txtNumeroDESerieEquipo.Size = new Size(196, 23);
            txtNumeroDESerieEquipo.TabIndex = 53;
            // 
            // txtModeloEquipo
            // 
            txtModeloEquipo.Font = new Font("Arial", 10F);
            txtModeloEquipo.Location = new Point(343, 187);
            txtModeloEquipo.Margin = new Padding(3, 2, 3, 2);
            txtModeloEquipo.Name = "txtModeloEquipo";
            txtModeloEquipo.Size = new Size(196, 23);
            txtModeloEquipo.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10F);
            label9.Location = new Point(343, 299);
            label9.Name = "label9";
            label9.Size = new Size(214, 16);
            label9.TabIndex = 51;
            label9.Text = "DESCRIPCIÓN DEL PROBLEMA:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F);
            label10.Location = new Point(338, 228);
            label10.Name = "label10";
            label10.Size = new Size(93, 16);
            label10.TabIndex = 50;
            label10.Text = "N° DE SERIE:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10F);
            label11.Location = new Point(338, 155);
            label11.Name = "label11";
            label11.Size = new Size(71, 16);
            label11.TabIndex = 49;
            label11.Text = "MODELO:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10F);
            label12.Location = new Point(345, 81);
            label12.Name = "label12";
            label12.Size = new Size(122, 16);
            label12.TabIndex = 48;
            label12.Text = "TIPO DE EQUIPO:";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Enabled = false;
            btnRegistrarCliente.Font = new Font("Arial", 10F);
            btnRegistrarCliente.Location = new Point(83, 515);
            btnRegistrarCliente.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(184, 60);
            btnRegistrarCliente.TabIndex = 47;
            btnRegistrarCliente.Text = "REGISTRAR CLIENTE";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Font = new Font("Arial", 10F);
            txtEmailCliente.Location = new Point(83, 334);
            txtEmailCliente.Margin = new Padding(3, 2, 3, 2);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(156, 23);
            txtEmailCliente.TabIndex = 46;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Font = new Font("Arial", 10F);
            txtTelefonoCliente.Location = new Point(83, 261);
            txtTelefonoCliente.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(156, 23);
            txtTelefonoCliente.TabIndex = 45;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Font = new Font("Arial", 10F);
            txtDireccionCliente.Location = new Point(83, 187);
            txtDireccionCliente.Margin = new Padding(3, 2, 3, 2);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(156, 23);
            txtDireccionCliente.TabIndex = 44;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Arial", 10F);
            txtNombreCliente.Location = new Point(83, 113);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(156, 23);
            txtNombreCliente.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F);
            label7.Location = new Point(83, 301);
            label7.Name = "label7";
            label7.Size = new Size(51, 16);
            label7.TabIndex = 42;
            label7.Text = "EMAIL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F);
            label6.Location = new Point(83, 229);
            label6.Name = "label6";
            label6.Size = new Size(86, 16);
            label6.TabIndex = 41;
            label6.Text = "TELÉFONO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F);
            label5.Location = new Point(83, 155);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 40;
            label5.Text = "DIRECCIÓN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.Location = new Point(83, 81);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 39;
            label4.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(391, 27);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 38;
            label2.Text = "EQUIPO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 27);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 37;
            label1.Text = "CLIENTE";
            // 
            // tpAdministrador
            // 
            tpAdministrador.Controls.Add(btnGuardar);
            tpAdministrador.Controls.Add(btnModificarUsuario);
            tpAdministrador.Controls.Add(bntAnadirUsuario);
            tpAdministrador.Controls.Add(cboxRolUsuario);
            tpAdministrador.Controls.Add(txtContrasenaUsuario);
            tpAdministrador.Controls.Add(txtNombreUsuario);
            tpAdministrador.Controls.Add(label21);
            tpAdministrador.Controls.Add(label20);
            tpAdministrador.Controls.Add(label19);
            tpAdministrador.Controls.Add(dgvVerUsuarios);
            tpAdministrador.Controls.Add(label18);
            tpAdministrador.Controls.Add(label17);
            tpAdministrador.Location = new Point(4, 25);
            tpAdministrador.Margin = new Padding(3, 2, 3, 2);
            tpAdministrador.Name = "tpAdministrador";
            tpAdministrador.Padding = new Padding(3, 2, 3, 2);
            tpAdministrador.Size = new Size(1061, 664);
            tpAdministrador.TabIndex = 0;
            tpAdministrador.Text = "Administrador";
            tpAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(118, 418);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(189, 46);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Enabled = false;
            btnModificarUsuario.Location = new Point(118, 490);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(189, 46);
            btnModificarUsuario.TabIndex = 10;
            btnModificarUsuario.Text = "MODIFICAR";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // bntAnadirUsuario
            // 
            bntAnadirUsuario.Location = new Point(118, 341);
            bntAnadirUsuario.Name = "bntAnadirUsuario";
            bntAnadirUsuario.Size = new Size(189, 49);
            bntAnadirUsuario.TabIndex = 9;
            bntAnadirUsuario.Text = "AÑADIR USUARIO";
            bntAnadirUsuario.UseVisualStyleBackColor = true;
            bntAnadirUsuario.Click += bntAnadirUsuario_Click;
            // 
            // cboxRolUsuario
            // 
            cboxRolUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxRolUsuario.FormattingEnabled = true;
            cboxRolUsuario.Items.AddRange(new object[] { "Administrador", "Cajero", "Tecnico" });
            cboxRolUsuario.Location = new Point(83, 266);
            cboxRolUsuario.Name = "cboxRolUsuario";
            cboxRolUsuario.Size = new Size(256, 24);
            cboxRolUsuario.TabIndex = 8;
            // 
            // txtContrasenaUsuario
            // 
            txtContrasenaUsuario.Location = new Point(83, 202);
            txtContrasenaUsuario.Name = "txtContrasenaUsuario";
            txtContrasenaUsuario.Size = new Size(256, 23);
            txtContrasenaUsuario.TabIndex = 7;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(79, 134);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(260, 23);
            txtNombreUsuario.TabIndex = 6;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(83, 244);
            label21.Name = "label21";
            label21.Size = new Size(44, 16);
            label21.TabIndex = 5;
            label21.Text = "ROL: ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(79, 180);
            label20.Name = "label20";
            label20.Size = new Size(110, 16);
            label20.TabIndex = 4;
            label20.Text = "CONTRASEÑA: ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(79, 112);
            label19.Name = "label19";
            label19.Size = new Size(161, 16);
            label19.TabIndex = 3;
            label19.Text = "NOMBRE DE USUARIO: ";
            // 
            // dgvVerUsuarios
            // 
            dgvVerUsuarios.BackgroundColor = Color.LightGray;
            dgvVerUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerUsuarios.Location = new Point(420, 143);
            dgvVerUsuarios.Name = "dgvVerUsuarios";
            dgvVerUsuarios.RowHeadersWidth = 51;
            dgvVerUsuarios.Size = new Size(536, 463);
            dgvVerUsuarios.TabIndex = 2;
            dgvVerUsuarios.SelectionChanged += dgvVerUsuarios_SelectionChanged_1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label18.Location = new Point(567, 89);
            label18.Name = "label18";
            label18.Size = new Size(152, 22);
            label18.TabIndex = 1;
            label18.Text = "VER USUARIOS";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label17.Location = new Point(394, 25);
            label17.Name = "label17";
            label17.Size = new Size(171, 22);
            label17.TabIndex = 0;
            label17.Text = "AÑADIR USUARIO";
            // 
            // tabInicio
            // 
            tabInicio.Controls.Add(tpAdministrador);
            tabInicio.Controls.Add(tpClienteYEquipo);
            tabInicio.Controls.Add(tpInventario);
            tabInicio.Controls.Add(tpFactura);
            tabInicio.Dock = DockStyle.Fill;
            tabInicio.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabInicio.Location = new Point(0, 0);
            tabInicio.Margin = new Padding(3, 2, 3, 2);
            tabInicio.Name = "tabInicio";
            tabInicio.SelectedIndex = 0;
            tabInicio.Size = new Size(1069, 693);
            tabInicio.TabIndex = 1;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 693);
            Controls.Add(tabInicio);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += FrmInicio_Load;
            tpFactura.ResumeLayout(false);
            tpFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            tpInventario.ResumeLayout(false);
            tpInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRepuestos).EndInit();
            tpClienteYEquipo.ResumeLayout(false);
            tpClienteYEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarClientesYEquipos).EndInit();
            tpAdministrador.ResumeLayout(false);
            tpAdministrador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVerUsuarios).EndInit();
            tabInicio.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpFactura;
        private TabPage tpInventario;
        private TabPage tpClienteYEquipo;
        private TabPage tpAdministrador;
        private TabControl tabInicio;
        private Label label3;
        private DataGridView dgvMostrarClientesYEquipos;
        private TextBox txtDescripcionDelProblemaEquipo;
        private ComboBox cboxTipoDEEquipo;
        private Button btnRegistrarEquipo;
        private TextBox txtNumeroDESerieEquipo;
        private TextBox txtModeloEquipo;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnRegistrarCliente;
        private TextBox txtEmailCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtNombreCliente;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtFactura;
        private Button btnExportarFactura;
        private Button btnEmitirFactura;
        private DateTimePicker dtpFechaFactura;
        private ComboBox cboxEquipoFactura;
        private ComboBox cboxClienteFactura;
        private Label label8;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label label17;
        private Label label20;
        private Label label19;
        private DataGridView dgvVerUsuarios;
        private Label label21;
        private Button bntAnadirUsuario;
        private ComboBox cboxRolUsuario;
        private TextBox txtContrasenaUsuario;
        private TextBox txtNombreUsuario;
        private Label label22;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private TextBox txtDescripcionRepuesto;
        private TextBox txtNombreRepuesto;
        private Label label27;
        private ComboBox cboxFamiliaRepuesto;
        private Button btnGuardarRepuestos;
        private DataGridView dgvRepuestos;
        private Button btnModificarRepuestos;
        private Button btnGuardar;
        private NumericUpDown numericPrecio;
        private NumericUpDown numericStock;
        private NumericUpDown numericTotal;
        private ComboBox cboxEquipoCliente;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private TabPage tabPage1;
        private Button btnModificarUsuario;
    }
}