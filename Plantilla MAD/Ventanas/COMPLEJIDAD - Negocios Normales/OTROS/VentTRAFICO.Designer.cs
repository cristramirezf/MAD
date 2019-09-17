namespace Plantilla_MAD.Ventanas
{
    partial class VentTRAFICO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentTRAFICO));
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnCopiaCuenta = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.dataDatos = new System.Windows.Forms.DataGridView();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkExcel = new System.Windows.Forms.CheckBox();
            this.checkPDF = new System.Windows.Forms.CheckBox();
            this.checkSADE = new System.Windows.Forms.CheckBox();
            this.checkMag = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.btnCopiaTipo = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(49, 473);
            this.campoObs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(251, 139);
            this.campoObs.TabIndex = 52;
            this.campoObs.Text = "";
            // 
            // btnCopiaCuenta
            // 
            this.btnCopiaCuenta.Location = new System.Drawing.Point(653, 87);
            this.btnCopiaCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaCuenta.Name = "btnCopiaCuenta";
            this.btnCopiaCuenta.Size = new System.Drawing.Size(121, 28);
            this.btnCopiaCuenta.TabIndex = 45;
            this.btnCopiaCuenta.Text = "Copia Cuenta";
            this.btnCopiaCuenta.UseVisualStyleBackColor = true;
            this.btnCopiaCuenta.Click += new System.EventHandler(this.btnCopiaCuenta_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(45, 454);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(103, 17);
            this.lblObs.TabIndex = 53;
            this.lblObs.Text = "Observaciones";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(673, 529);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(133, 28);
            this.btnGrabar.TabIndex = 44;
            this.btnGrabar.Text = "Copiar AC";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(647, 473);
            this.btnCopiaProy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(183, 28);
            this.btnCopiaProy.TabIndex = 43;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Visible = false;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 509);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // comboEjecutivo
            // 
            this.comboEjecutivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEjecutivo.FormattingEnabled = true;
            this.comboEjecutivo.Items.AddRange(new object[] {
"Andres Arias O.",
"Carolina Arellano D.",
"Claudia Sola G.",
"Danitza Leyton M.",
"Danitza Rendich O.",
"Elizabeth Pavez S.",
"Felipe Figueroa L.",
"Gabriela Guzman C.",
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
"Oscar Magallanes R.",
"Philipp Gallardo G.",
"Romina Saez G.",
"Sandra Bustos R.",
"Sandra Lazcano A.",
"Simon Segura B.",
"Vladimir Cubillos R.",
"Ximena Valdes V."});
            this.comboEjecutivo.Location = new System.Drawing.Point(369, 529);
            this.comboEjecutivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(193, 24);
            this.comboEjecutivo.TabIndex = 41;
            // 
            // dataDatos
            // 
            this.dataDatos.AllowUserToResizeRows = false;
            this.dataDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doc,
            this.Tipo,
            this.Cuenta});
            this.dataDatos.Location = new System.Drawing.Point(265, 121);
            this.dataDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataDatos.Name = "dataDatos";
            this.dataDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataDatos.Size = new System.Drawing.Size(563, 299);
            this.dataDatos.TabIndex = 34;
            this.dataDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_CellClick);
            this.dataDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_CellClick);
            this.dataDatos.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_RowLeave);
            this.dataDatos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataDatos_RowsRemoved);
            // 
            // Doc
            // 
            this.Doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Doc.Frozen = true;
            this.Doc.HeaderText = "Nº Documento";
            this.Doc.Name = "Doc";
            this.Doc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Doc.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.AutoComplete = false;
            this.Tipo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Tipo.HeaderText = "Tipo Doc.";
            this.Tipo.Items.AddRange(new object[] {
            "",
            "FS",
            "FV",
            "NC",
            "ND"});
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tipo.Width = 80;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.Width = 180;
            // 
            // lblProy
            // 
            this.lblProy.AutoSize = true;
            this.lblProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProy.Location = new System.Drawing.Point(617, 49);
            this.lblProy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProy.Name = "lblProy";
            this.lblProy.Size = new System.Drawing.Size(74, 17);
            this.lblProy.TabIndex = 33;
            this.lblProy.Text = "TRAFICO";
            this.lblProy.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - Otros";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "TRÁFICO";
            // 
            // checkExcel
            // 
            this.checkExcel.AutoSize = true;
            this.checkExcel.Location = new System.Drawing.Point(67, 242);
            this.checkExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkExcel.Name = "checkExcel";
            this.checkExcel.Size = new System.Drawing.Size(63, 21);
            this.checkExcel.TabIndex = 56;
            this.checkExcel.Text = "Excel";
            this.checkExcel.UseVisualStyleBackColor = true;
            // 
            // checkPDF
            // 
            this.checkPDF.AutoSize = true;
            this.checkPDF.Location = new System.Drawing.Point(67, 271);
            this.checkPDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkPDF.Name = "checkPDF";
            this.checkPDF.Size = new System.Drawing.Size(57, 21);
            this.checkPDF.TabIndex = 57;
            this.checkPDF.Text = "PDF";
            this.checkPDF.UseVisualStyleBackColor = true;
            // 
            // checkSADE
            // 
            this.checkSADE.AutoSize = true;
            this.checkSADE.Location = new System.Drawing.Point(67, 299);
            this.checkSADE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkSADE.Name = "checkSADE";
            this.checkSADE.Size = new System.Drawing.Size(67, 21);
            this.checkSADE.TabIndex = 58;
            this.checkSADE.Text = "SADE";
            this.checkSADE.UseVisualStyleBackColor = true;
            // 
            // checkMag
            // 
            this.checkMag.AutoSize = true;
            this.checkMag.Location = new System.Drawing.Point(67, 327);
            this.checkMag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkMag.Name = "checkMag";
            this.checkMag.Size = new System.Drawing.Size(95, 21);
            this.checkMag.TabIndex = 59;
            this.checkMag.Text = "Magnético";
            this.checkMag.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Escoger formatos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(65, 140);
            this.campoRUT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(132, 22);
            this.campoRUT.TabIndex = 61;
            // 
            // btnCopiaTipo
            // 
            this.btnCopiaTipo.Location = new System.Drawing.Point(485, 87);
            this.btnCopiaTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaTipo.Name = "btnCopiaTipo";
            this.btnCopiaTipo.Size = new System.Drawing.Size(96, 28);
            this.btnCopiaTipo.TabIndex = 63;
            this.btnCopiaTipo.Text = "Copia Tipo";
            this.btnCopiaTipo.UseVisualStyleBackColor = true;
            this.btnCopiaTipo.Click += new System.EventHandler(this.btnCopiaTipo_Click);
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
            this.menuStrip2.Size = new System.Drawing.Size(881, 28);
            this.menuStrip2.TabIndex = 122;
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
            // VentTRAFICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(881, 646);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnCopiaTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkMag);
            this.Controls.Add(this.checkSADE);
            this.Controls.Add(this.checkPDF);
            this.Controls.Add(this.checkExcel);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnCopiaCuenta);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.dataDatos);
            this.Controls.Add(this.lblProy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VentTRAFICO";
            this.Text = "TRÁFICO";
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Button btnCopiaCuenta;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.DataGridView dataDatos;
        private System.Windows.Forms.Label lblProy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkExcel;
        private System.Windows.Forms.CheckBox checkPDF;
        private System.Windows.Forms.CheckBox checkSADE;
        private System.Windows.Forms.CheckBox checkMag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.Button btnCopiaTipo;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
    }
}