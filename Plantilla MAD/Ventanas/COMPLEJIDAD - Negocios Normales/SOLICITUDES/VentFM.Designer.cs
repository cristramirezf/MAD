﻿namespace Plantilla_MAD.Ventanas
{
    partial class VentFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentFM));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.campoMonto = new System.Windows.Forms.TextBox();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.campoGlosa = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoCuenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProy = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(568, 24);
            this.menuStrip2.TabIndex = 256;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Ayuda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem2.Text = "Acerca de";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem3.Text = "Salir";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 255;
            this.label8.Text = "Monto neto";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // campoMonto
            // 
            this.campoMonto.Location = new System.Drawing.Point(49, 252);
            this.campoMonto.MaxLength = 200;
            this.campoMonto.Name = "campoMonto";
            this.campoMonto.Size = new System.Drawing.Size(100, 20);
            this.campoMonto.TabIndex = 254;
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(318, 109);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(204, 87);
            this.campoObs.TabIndex = 252;
            this.campoObs.Text = "";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(315, 94);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(78, 13);
            this.lblObs.TabIndex = 253;
            this.lblObs.Text = "Observaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 251;
            this.label9.Text = "Glosa";
            // 
            // campoGlosa
            // 
            this.campoGlosa.Location = new System.Drawing.Point(49, 305);
            this.campoGlosa.MaxLength = 2147483647;
            this.campoGlosa.Multiline = true;
            this.campoGlosa.Name = "campoGlosa";
            this.campoGlosa.Size = new System.Drawing.Size(200, 69);
            this.campoGlosa.TabIndex = 250;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(375, 342);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 245;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(355, 296);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 244;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 243;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // comboEjecutivo
            // 
            this.comboEjecutivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEjecutivo.FormattingEnabled = true;
            this.comboEjecutivo.Items.AddRange(new object[] {
"Andrea Hinojosa G.",
"Andres Arias O.",
"Angelica Silva S.",
"Carol Rios G.",
"Carolina Arellano D.",
"Claudia Sola G.",
"Danitza Leyton M.",
"Danitza Rendich O.",
"Elizabeth Pavez S.",
"Felipe Figueroa L.",
"Francisca Garcia B.",
"Francisco Castillo S.",
"Gabriela Guzman C.",
"Javier Beroiza A.",
"Julia Dominguez L.",
"Karin Sothers B.",
"Kimberly Moraga G.",
"Lorena Garcia N.",
"Lorena Jimenez M.",
"Loreto Barriga R.",
"Luz Gaete Ch.",
"Maria Jose Marchant V.",
"Maria Loreto Caceres A.",
"Maria Pinto D.",
"Maria Renata Ramirez A.",
"Matias Brito A.",
"Mirtha Castro C.",
"Paula Sola G.",
"Philipp Gallardo G.",
"Sandra Lazcano A.",
"Simon Segura B.",
"Vladimir Cubillos R."});
            this.comboEjecutivo.Location = new System.Drawing.Point(348, 245);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 242;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 249;
            this.label5.Text = "Cuenta";
            // 
            // campoCuenta
            // 
            this.campoCuenta.Location = new System.Drawing.Point(49, 199);
            this.campoCuenta.MaxLength = 2147483647;
            this.campoCuenta.Name = "campoCuenta";
            this.campoCuenta.Size = new System.Drawing.Size(200, 20);
            this.campoCuenta.TabIndex = 248;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 247;
            this.label6.Text = "RUT Cliente";
            // 
            // lblProy
            // 
            this.lblProy.AutoSize = true;
            this.lblProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProy.Location = new System.Drawing.Point(380, 42);
            this.lblProy.Name = "lblProy";
            this.lblProy.Size = new System.Drawing.Size(119, 13);
            this.lblProy.TabIndex = 241;
            this.lblProy.Text = "FACTURA MANUAL";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(49, 111);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 246;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 240;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 30);
            this.label3.TabIndex = 239;
            this.label3.Text = "Solicitudes Servicios Móviles - Correccion en Sistemas Móviles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 238;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 42);
            this.label1.TabIndex = 237;
            this.label1.Text = "FACTURA MANUAL";
            // 
            // VentFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(568, 401);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.campoMonto);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.campoGlosa);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoCuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProy);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentFM";
            this.Text = "FACTURA MANUAL";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campoMonto;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox campoGlosa;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProy;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}