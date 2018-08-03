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
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(757, 28);
            this.menuStrip2.TabIndex = 256;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 24);
            this.toolStripMenuItem1.Text = "Ayuda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 26);
            this.toolStripMenuItem2.Text = "Acerca de";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(150, 26);
            this.toolStripMenuItem3.Text = "Salir";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 255;
            this.label8.Text = "Monto neto";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // campoMonto
            // 
            this.campoMonto.Location = new System.Drawing.Point(65, 310);
            this.campoMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoMonto.MaxLength = 200;
            this.campoMonto.Name = "campoMonto";
            this.campoMonto.Size = new System.Drawing.Size(132, 22);
            this.campoMonto.TabIndex = 254;
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(424, 134);
            this.campoObs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(271, 106);
            this.campoObs.TabIndex = 252;
            this.campoObs.Text = "";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(420, 116);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(103, 17);
            this.lblObs.TabIndex = 253;
            this.lblObs.Text = "Observaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 356);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 251;
            this.label9.Text = "Glosa";
            // 
            // campoGlosa
            // 
            this.campoGlosa.Location = new System.Drawing.Point(65, 375);
            this.campoGlosa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoGlosa.MaxLength = 2147483647;
            this.campoGlosa.Multiline = true;
            this.campoGlosa.Name = "campoGlosa";
            this.campoGlosa.Size = new System.Drawing.Size(265, 84);
            this.campoGlosa.TabIndex = 250;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(500, 404);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(133, 28);
            this.btnGrabar.TabIndex = 245;
            this.btnGrabar.Text = "Copiar AC";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(473, 364);
            this.btnCopiaProy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(183, 28);
            this.btnCopiaProy.TabIndex = 244;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Visible = false;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 243;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // comboEjecutivo
            // 
            this.comboEjecutivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEjecutivo.FormattingEnabled = true;
            this.comboEjecutivo.Items.AddRange(new object[] {
            "Andres Arias O.",

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

            "Oscar Illanes R.",
            "Paula Sola G.",
            "Philipp Gallardo G.",
            "Romina Saez G.",
            "Sandra Lazcano A.",
            "Simon Segura B.",
            "Vladimir Cubillos R."});
            this.comboEjecutivo.Location = new System.Drawing.Point(464, 302);
            this.comboEjecutivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(193, 24);
            this.comboEjecutivo.TabIndex = 242;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 249;
            this.label5.Text = "Cuenta";
            // 
            // campoCuenta
            // 
            this.campoCuenta.Location = new System.Drawing.Point(65, 245);
            this.campoCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoCuenta.MaxLength = 2147483647;
            this.campoCuenta.Name = "campoCuenta";
            this.campoCuenta.Size = new System.Drawing.Size(265, 22);
            this.campoCuenta.TabIndex = 248;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 247;
            this.label6.Text = "RUT Cliente";
            // 
            // lblProy
            // 
            this.lblProy.AutoSize = true;
            this.lblProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProy.Location = new System.Drawing.Point(507, 52);
            this.lblProy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProy.Name = "lblProy";
            this.lblProy.Size = new System.Drawing.Size(147, 17);
            this.lblProy.TabIndex = 241;
            this.lblProy.Text = "FACTURA MANUAL";
            this.lblProy.Visible = false;
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(65, 137);
            this.campoRUT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(132, 22);
            this.campoRUT.TabIndex = 246;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 240;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 37);
            this.label3.TabIndex = 239;
            this.label3.Text = "Solicitudes Servicios Móviles - Correccion en Sistemas Móviles";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 17);
            this.label2.TabIndex = 238;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 52);
            this.label1.TabIndex = 237;
            this.label1.Text = "FACTURA MANUAL";
            // 
            // VentFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(757, 494);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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