﻿namespace IngSoft.Interfaces
{
    partial class Principal
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
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.grvClientes = new System.Windows.Forms.DataGridView();
            this.btnNuevaV = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGerente = new System.Windows.Forms.Label();
            this.btnPagos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvClientes)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarsesion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.Location = new System.Drawing.Point(611, 359);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(111, 30);
            this.btnCerrarsesion.TabIndex = 4;
            this.btnCerrarsesion.Text = "Cerrar Sesión";
            this.btnCerrarsesion.UseVisualStyleBackColor = true;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            this.btnCerrarsesion.MouseLeave += new System.EventHandler(this.btnCerrarsesion_MouseLeave);
            this.btnCerrarsesion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarsesion_MouseMove);
            // 
            // grvClientes
            // 
            this.grvClientes.BackgroundColor = System.Drawing.Color.Silver;
            this.grvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvClientes.Location = new System.Drawing.Point(12, 53);
            this.grvClientes.Name = "grvClientes";
            this.grvClientes.Size = new System.Drawing.Size(450, 246);
            this.grvClientes.TabIndex = 4;
            // 
            // btnNuevaV
            // 
            this.btnNuevaV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaV.Location = new System.Drawing.Point(3, 343);
            this.btnNuevaV.Name = "btnNuevaV";
            this.btnNuevaV.Size = new System.Drawing.Size(103, 31);
            this.btnNuevaV.TabIndex = 3;
            this.btnNuevaV.Text = "Nueva Venta";
            this.btnNuevaV.UseVisualStyleBackColor = true;
            this.btnNuevaV.Click += new System.EventHandler(this.btnNuevaV_Click);
            this.btnNuevaV.MouseLeave += new System.EventHandler(this.btnNuevaV_MouseLeave);
            this.btnNuevaV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNuevaV_MouseMove);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightGray;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(12, 9);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(248, 25);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarToolStripMenuItem.Text = "Lista";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click_1);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaPorMesToolStripMenuItem,
            this.deudasToolStripMenuItem,
            this.productosVendidosToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventaPorMesToolStripMenuItem
            // 
            this.ventaPorMesToolStripMenuItem.Name = "ventaPorMesToolStripMenuItem";
            this.ventaPorMesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ventaPorMesToolStripMenuItem.Text = "Venta por mes";
            this.ventaPorMesToolStripMenuItem.Click += new System.EventHandler(this.ventaPorMesToolStripMenuItem_Click);
            // 
            // deudasToolStripMenuItem
            // 
            this.deudasToolStripMenuItem.Name = "deudasToolStripMenuItem";
            this.deudasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.deudasToolStripMenuItem.Text = "Deudas";
            this.deudasToolStripMenuItem.Click += new System.EventHandler(this.deudasToolStripMenuItem_Click);
            // 
            // productosVendidosToolStripMenuItem
            // 
            this.productosVendidosToolStripMenuItem.Name = "productosVendidosToolStripMenuItem";
            this.productosVendidosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.productosVendidosToolStripMenuItem.Text = "Productos vendidos";
            this.productosVendidosToolStripMenuItem.Click += new System.EventHandler(this.productosVendidosToolStripMenuItem_Click);
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerente.ForeColor = System.Drawing.Color.White;
            this.lblGerente.Location = new System.Drawing.Point(267, 350);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(16, 17);
            this.lblGerente.TabIndex = 5;
            this.lblGerente.Text = "  ";
            // 
            // btnPagos
            // 
            this.btnPagos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Location = new System.Drawing.Point(560, 39);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(74, 32);
            this.btnPagos.TabIndex = 2;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            this.btnPagos.MouseLeave += new System.EventHandler(this.btnPagos_MouseLeave);
            this.btnPagos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPagos_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IngSoft.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(468, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 179);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(733, 401);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.lblGerente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.btnCerrarsesion);
            this.Controls.Add(this.btnNuevaV);
            this.Controls.Add(this.grvClientes);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Principal";
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvClientes)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.DataGridView grvClientes;
        private System.Windows.Forms.Button btnNuevaV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosVendidosToolStripMenuItem;
        private System.Windows.Forms.Label lblGerente;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
    }
}