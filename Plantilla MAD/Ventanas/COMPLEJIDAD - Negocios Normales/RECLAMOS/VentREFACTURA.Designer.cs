﻿namespace Plantilla_MAD.Ventanas
{
    partial class VentREFACTURA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentREFACTURA));
            this.lblObs = new System.Windows.Forms.Label();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.btnCopiaSIM = new System.Windows.Forms.Button();
            this.btnCopiaCuentas = new System.Windows.Forms.Button();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblProy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.dataDatos = new System.Windows.Forms.DataGridView();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Glosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiaGlosa = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(175, 419);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(108, 13);
            this.lblObs.TabIndex = 69;
            this.lblObs.Text = "Información Adicional";
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(178, 435);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(189, 114);
            this.campoObs.TabIndex = 68;
            this.campoObs.Text = "";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(463, 526);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 67;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(444, 478);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 66;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // comboEjecutivo
            // 
            this.comboEjecutivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEjecutivo.FormattingEnabled = true;
            this.comboEjecutivo.Items.AddRange(new object[] {
            "Andres Arias O.",
            "Andrea Hinojosa G.",
            "Angelica Silva S.",
            "Carol Rios G.",
            "Carolina Arellano D.",
            "Claudia Sola G.",
            "Danitza Leyton M.",
            "Danitza Rendich O.",
            "Elizabeth Pavez S.",
            "Felipe Figueroa L.",
            "Gabriela Guzman C.",
            "Julia Dominguez L.",
            "Karin Sothers B.",
            "Kimberly Moraga G.",
            "Lorena Garcia N.",
            "Lorena Jimenez M.",
            "Loreto Barriga R.",
            "Luz Gaete Ch.",
            "Maria Jose Marchant V.",
            "Maria Loreto Caceres A.",
            "Maria Renata Ramirez A.",
            "Mirtha Castro C.",
            "Oscar Illanes R.",
            "Paula Sola G.",
            "Philipp Gallardo G.",
            "Romina Saez G.",
            "Sandra Lazcano A.",
            "Simon Segura B.",
            "Vladimir Cubillos R."});
            this.comboEjecutivo.Location = new System.Drawing.Point(440, 435);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 64;
            // 
            // btnCopiaSIM
            // 
            this.btnCopiaSIM.Location = new System.Drawing.Point(307, 111);
            this.btnCopiaSIM.Name = "btnCopiaSIM";
            this.btnCopiaSIM.Size = new System.Drawing.Size(80, 23);
            this.btnCopiaSIM.TabIndex = 61;
            this.btnCopiaSIM.Text = "Copia Monto";
            this.btnCopiaSIM.UseVisualStyleBackColor = true;
            this.btnCopiaSIM.Click += new System.EventHandler(this.btnCopiaMonto_Click);
            // 
            // btnCopiaCuentas
            // 
            this.btnCopiaCuentas.Location = new System.Drawing.Point(204, 111);
            this.btnCopiaCuentas.Name = "btnCopiaCuentas";
            this.btnCopiaCuentas.Size = new System.Drawing.Size(84, 23);
            this.btnCopiaCuentas.TabIndex = 59;
            this.btnCopiaCuentas.Text = "Copia Cuenta";
            this.btnCopiaCuentas.UseVisualStyleBackColor = true;
            this.btnCopiaCuentas.Click += new System.EventHandler(this.btnCopiaCuenta_Click);
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menúToolStripMenuItem.Text = "Ayuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblProy
            // 
            this.lblProy.AutoSize = true;
            this.lblProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProy.Location = new System.Drawing.Point(553, 42);
            this.lblProy.Name = "lblProy";
            this.lblProy.Size = new System.Drawing.Size(81, 13);
            this.lblProy.TabIndex = 52;
            this.lblProy.Text = "REFACTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 50;
            this.label3.Text = "Reclamos Servicios Móviles - Tarifas Incorrectas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(100, 76);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 56;
            // 
            // dataDatos
            // 
            this.dataDatos.AllowUserToResizeRows = false;
            this.dataDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.Cuenta,
            this.Monto,
            this.Glosa});
            this.dataDatos.Location = new System.Drawing.Point(32, 137);
            this.dataDatos.Name = "dataDatos";
            this.dataDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataDatos.Size = new System.Drawing.Size(692, 272);
            this.dataDatos.TabIndex = 53;
            this.dataDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_CellClick);
            this.dataDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_CellClick);
            this.dataDatos.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_RowLeave);
            this.dataDatos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataDatos_RowsRemoved);
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura ";
            this.Factura.Name = "Factura";
            this.Factura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.Width = 140;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 70;
            // 
            // Glosa
            // 
            this.Glosa.HeaderText = "Glosa";
            this.Glosa.Name = "Glosa";
            this.Glosa.Width = 340;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "REFACTURA";
            // 
            // btnCopiaGlosa
            // 
            this.btnCopiaGlosa.Location = new System.Drawing.Point(525, 111);
            this.btnCopiaGlosa.Name = "btnCopiaGlosa";
            this.btnCopiaGlosa.Size = new System.Drawing.Size(78, 23);
            this.btnCopiaGlosa.TabIndex = 90;
            this.btnCopiaGlosa.Text = "Copia Glosa";
            this.btnCopiaGlosa.UseVisualStyleBackColor = true;
            this.btnCopiaGlosa.Click += new System.EventHandler(this.btnCopiaGlosa_Click);
            // 
            // VentREFACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(755, 580);
            this.Controls.Add(this.btnCopiaGlosa);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.btnCopiaSIM);
            this.Controls.Add(this.btnCopiaCuentas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblProy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.dataDatos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentREFACTURA";
            this.Text = "REFACTURA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Button btnCopiaSIM;
        private System.Windows.Forms.Button btnCopiaCuentas;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblProy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.DataGridView dataDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopiaGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Glosa;
    }
}