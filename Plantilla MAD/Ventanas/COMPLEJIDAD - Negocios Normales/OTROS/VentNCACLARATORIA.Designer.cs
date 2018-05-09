namespace Plantilla_MAD.Ventanas
{
    partial class VentNCACLARATORIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentNCACLARATORIA));
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoGiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.campoComuna = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.campoCiudad = new System.Windows.Forms.TextBox();
            this.dataDatos = new System.Windows.Forms.DataGridView();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(485, 278);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 125;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(465, 232);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 124;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 123;
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
            this.comboEjecutivo.Location = new System.Drawing.Point(457, 129);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 122;
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(245, 92);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 132;
            this.label5.Text = "Giro (máx. 20 caracteres)";
            // 
            // campoGiro
            // 
            this.campoGiro.Location = new System.Drawing.Point(245, 142);
            this.campoGiro.MaxLength = 20;
            this.campoGiro.Name = "campoGiro";
            this.campoGiro.Size = new System.Drawing.Size(155, 20);
            this.campoGiro.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 130;
            this.label6.Text = "RUT Cliente";
            // 
            // lblProy
            // 
            this.lblProy.AutoSize = true;
            this.lblProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProy.Location = new System.Drawing.Point(475, 42);
            this.lblProy.Name = "lblProy";
            this.lblProy.Size = new System.Drawing.Size(114, 13);
            this.lblProy.TabIndex = 121;
            this.lblProy.Text = "NC ACLARATORIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - Otros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "NC ACLARATORIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 134;
            this.label8.Text = "Dirección";
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(245, 194);
            this.campoDireccion.MaxLength = 2147483647;
            this.campoDireccion.Multiline = true;
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(155, 64);
            this.campoDireccion.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 136;
            this.label9.Text = "Comuna";
            // 
            // campoComuna
            // 
            this.campoComuna.Location = new System.Drawing.Point(245, 288);
            this.campoComuna.MaxLength = 2147483647;
            this.campoComuna.Name = "campoComuna";
            this.campoComuna.Size = new System.Drawing.Size(155, 20);
            this.campoComuna.TabIndex = 135;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 138;
            this.label10.Text = "Ciudad";
            // 
            // campoCiudad
            // 
            this.campoCiudad.Location = new System.Drawing.Point(245, 336);
            this.campoCiudad.MaxLength = 2147483647;
            this.campoCiudad.Name = "campoCiudad";
            this.campoCiudad.Size = new System.Drawing.Size(155, 20);
            this.campoCiudad.TabIndex = 137;
            // 
            // dataDatos
            // 
            this.dataDatos.AllowUserToResizeRows = false;
            this.dataDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura});
            this.dataDatos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataDatos.Location = new System.Drawing.Point(47, 99);
            this.dataDatos.Name = "dataDatos";
            this.dataDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataDatos.Size = new System.Drawing.Size(142, 243);
            this.dataDatos.TabIndex = 139;
            this.dataDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_CellClick);
            this.dataDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_CellClick);
            this.dataDatos.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_RowLeave);
            this.dataDatos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataDatos_RowsRemoved);
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Facturas";
            this.Factura.Name = "Factura";
            this.Factura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(662, 24);
            this.menuStrip2.TabIndex = 140;
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
            // VentNCACLARATORIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(662, 403);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.campoCiudad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.campoComuna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.campoDireccion);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoGiro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentNCACLARATORIA";
            this.Text = "NC ACLARATORIA";
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoGiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox campoComuna;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campoCiudad;
        private System.Windows.Forms.DataGridView dataDatos;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
    }
}