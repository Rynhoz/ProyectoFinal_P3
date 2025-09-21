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
            menuStrip1 = new MenuStrip();
            administradorToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            equpoToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            repuestoToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem1 = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { administradorToolStripMenuItem, clienteToolStripMenuItem, equpoToolStripMenuItem, inventarioToolStripMenuItem, repuestoToolStripMenuItem, inventarioToolStripMenuItem1, facturaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(897, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            administradorToolStripMenuItem.Size = new Size(118, 24);
            administradorToolStripMenuItem.Text = "Administrador";
            administradorToolStripMenuItem.Visible = false;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(69, 24);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // equpoToolStripMenuItem
            // 
            equpoToolStripMenuItem.Name = "equpoToolStripMenuItem";
            equpoToolStripMenuItem.Size = new Size(70, 24);
            equpoToolStripMenuItem.Text = "Equipo";
            equpoToolStripMenuItem.Click += equpoToolStripMenuItem_Click;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(139, 24);
            inventarioToolStripMenuItem.Text = "Orden de Trabajo";
            // 
            // repuestoToolStripMenuItem
            // 
            repuestoToolStripMenuItem.Name = "repuestoToolStripMenuItem";
            repuestoToolStripMenuItem.Size = new Size(85, 24);
            repuestoToolStripMenuItem.Text = "Repuesto";
            repuestoToolStripMenuItem.Click += repuestoToolStripMenuItem_Click;
            // 
            // inventarioToolStripMenuItem1
            // 
            inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            inventarioToolStripMenuItem1.Size = new Size(89, 24);
            inventarioToolStripMenuItem1.Text = "Inventario";
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(70, 24);
            facturaToolStripMenuItem.Text = "Factura";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 616);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem equpoToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem repuestoToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem1;
        private ToolStripMenuItem facturaToolStripMenuItem;
    }
}