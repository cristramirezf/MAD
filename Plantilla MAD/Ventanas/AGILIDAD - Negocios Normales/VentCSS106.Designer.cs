namespace Plantilla_MAD.Ventanas
{
    partial class VentCSS106
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentCSS106));
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.campoOCO = new System.Windows.Forms.TextBox();
            this.checkOCO = new System.Windows.Forms.CheckBox();
            this.dataCSS106 = new System.Windows.Forms.DataGridView();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.labelCSS106 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiaSIM = new System.Windows.Forms.Button();
            this.btnCopiaValor = new System.Windows.Forms.Button();
            this.btnCopiaCuentas = new System.Windows.Forms.Button();
            this.radioMoto = new System.Windows.Forms.RadioButton();
            this.radioPatente = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCSS106)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(144, 79);
            this.campoRUT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(132, 22);
            this.campoRUT.TabIndex = 43;
            // 
            // campoOCO
            // 
            this.campoOCO.Location = new System.Drawing.Point(469, 78);
            this.campoOCO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoOCO.Name = "campoOCO";
            this.campoOCO.Size = new System.Drawing.Size(99, 22);
            this.campoOCO.TabIndex = 42;
            this.campoOCO.Visible = false;
            // 
            // checkOCO
            // 
            this.checkOCO.AutoSize = true;
            this.checkOCO.Location = new System.Drawing.Point(319, 79);
            this.checkOCO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkOCO.Name = "checkOCO";
            this.checkOCO.Size = new System.Drawing.Size(148, 21);
            this.checkOCO.TabIndex = 41;
            this.checkOCO.Text = "¿Necesita OC/NP?";
            this.checkOCO.UseVisualStyleBackColor = true;
            this.checkOCO.CheckedChanged += new System.EventHandler(this.checkOCO_CheckedChanged);
            // 
            // dataCSS106
            // 
            this.dataCSS106.AllowUserToResizeRows = false;
            this.dataCSS106.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCSS106.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCSS106.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movil,
            this.Patente,
            this.Cuenta,
            this.SIM,
            this.Valor});
            this.dataCSS106.Location = new System.Drawing.Point(53, 156);
            this.dataCSS106.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataCSS106.Name = "dataCSS106";
            this.dataCSS106.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataCSS106.Size = new System.Drawing.Size(829, 335);
            this.dataCSS106.TabIndex = 40;
            this.dataCSS106.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCSS106_CellClick);
            this.dataCSS106.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCSS106_CellClick);
            this.dataCSS106.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCSS106_RowLeave);
            this.dataCSS106.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataCSS106_RowsRemoved);
            // 
            // Movil
            // 
            this.Movil.HeaderText = "Móvil";
            this.Movil.Name = "Movil";
            this.Movil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Patente.Width = 80;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.Width = 150;
            // 
            // SIM
            // 
            this.SIM.AutoComplete = false;
            this.SIM.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SIM.HeaderText = "Código SIM";
            this.SIM.Items.AddRange(new object[] {
            "",
            "349 SIMCARD M2M",
            "365 SIMCARD SS 4G",
            "366 SIMCARD SS NANO 4G"});
            this.SIM.Name = "SIM";
            this.SIM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SIM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SIM.Width = 150;
            // 
            // Valor
            // 
            this.Valor.AutoComplete = false;
            this.Valor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Valor.HeaderText = "Valor Neto";
            this.Valor.Items.AddRange(new object[] {
            "",
            "0",
            "832",
            "2101"});
            this.Valor.Name = "Valor";
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelCSS106
            // 
            this.labelCSS106.AutoSize = true;
            this.labelCSS106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCSS106.Location = new System.Drawing.Point(660, 46);
            this.labelCSS106.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCSS106.Name = "labelCSS106";
            this.labelCSS106.Size = new System.Drawing.Size(65, 17);
            this.labelCSS106.TabIndex = 39;
            this.labelCSS106.Text = "CSS106";
            this.labelCSS106.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "CAMBIO DE SIMCARD S106";
            // 
            // btnCopiaSIM
            // 
            this.btnCopiaSIM.Location = new System.Drawing.Point(599, 122);
            this.btnCopiaSIM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaSIM.Name = "btnCopiaSIM";
            this.btnCopiaSIM.Size = new System.Drawing.Size(101, 28);
            this.btnCopiaSIM.TabIndex = 54;
            this.btnCopiaSIM.Text = "Copia SIM";
            this.btnCopiaSIM.UseVisualStyleBackColor = true;
            this.btnCopiaSIM.Click += new System.EventHandler(this.btnCopiaSIM_Click);
            // 
            // btnCopiaValor
            // 
            this.btnCopiaValor.Location = new System.Drawing.Point(756, 122);
            this.btnCopiaValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaValor.Name = "btnCopiaValor";
            this.btnCopiaValor.Size = new System.Drawing.Size(121, 28);
            this.btnCopiaValor.TabIndex = 53;
            this.btnCopiaValor.Text = "Copia Valor";
            this.btnCopiaValor.UseVisualStyleBackColor = true;
            this.btnCopiaValor.Click += new System.EventHandler(this.btnCopiaValor_Click);
            // 
            // btnCopiaCuentas
            // 
            this.btnCopiaCuentas.Location = new System.Drawing.Point(389, 122);
            this.btnCopiaCuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaCuentas.Name = "btnCopiaCuentas";
            this.btnCopiaCuentas.Size = new System.Drawing.Size(121, 28);
            this.btnCopiaCuentas.TabIndex = 52;
            this.btnCopiaCuentas.Text = "Copia Cuenta";
            this.btnCopiaCuentas.UseVisualStyleBackColor = true;
            this.btnCopiaCuentas.Click += new System.EventHandler(this.btnCopiaCuentas_Click);
            // 
            // radioMoto
            // 
            this.radioMoto.AutoSize = true;
            this.radioMoto.Location = new System.Drawing.Point(807, 79);
            this.radioMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioMoto.Name = "radioMoto";
            this.radioMoto.Size = new System.Drawing.Size(60, 21);
            this.radioMoto.TabIndex = 55;
            this.radioMoto.TabStop = true;
            this.radioMoto.Text = "Moto";
            this.radioMoto.UseVisualStyleBackColor = true;
            this.radioMoto.CheckedChanged += new System.EventHandler(this.radioMoto_CheckedChanged);
            // 
            // radioPatente
            // 
            this.radioPatente.AutoSize = true;
            this.radioPatente.Location = new System.Drawing.Point(724, 79);
            this.radioPatente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPatente.Name = "radioPatente";
            this.radioPatente.Size = new System.Drawing.Size(78, 21);
            this.radioPatente.TabIndex = 56;
            this.radioPatente.TabStop = true;
            this.radioPatente.Text = "Patente";
            this.radioPatente.UseVisualStyleBackColor = true;
            this.radioPatente.CheckedChanged += new System.EventHandler(this.radioPatente_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.menúToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.label8.Location = new System.Drawing.Point(591, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Seleccionar envío";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(361, 508);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(103, 17);
            this.lblObs.TabIndex = 66;
            this.lblObs.Text = "Observaciones";
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(365, 528);
            this.campoObs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(251, 139);
            this.campoObs.TabIndex = 65;
            this.campoObs.Text = "";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(713, 613);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(133, 28);
            this.btnGrabar.TabIndex = 64;
            this.btnGrabar.Text = "Copiar AC";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(688, 581);
            this.btnCopiaProy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(183, 28);
            this.btnCopiaProy.TabIndex = 63;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Visible = false;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 508);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 62;
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
            this.comboEjecutivo.Location = new System.Drawing.Point(683, 528);
            this.comboEjecutivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(193, 24);
            this.comboEjecutivo.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 508);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Datos de contacto";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(60, 528);
            this.campoDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(251, 139);
            this.campoDatos.TabIndex = 59;
            this.campoDatos.Text = "";
            // 
            // VentCSS106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(953, 686);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.radioPatente);
            this.Controls.Add(this.radioMoto);
            this.Controls.Add(this.btnCopiaSIM);
            this.Controls.Add(this.btnCopiaValor);
            this.Controls.Add(this.btnCopiaCuentas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.campoOCO);
            this.Controls.Add(this.checkOCO);
            this.Controls.Add(this.dataCSS106);
            this.Controls.Add(this.labelCSS106);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VentCSS106";
            this.Text = "CAMBIO DE SIMCARD S106";
            this.Load += new System.EventHandler(this.VentCSS106_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCSS106)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.TextBox campoOCO;
        private System.Windows.Forms.CheckBox checkOCO;
        private System.Windows.Forms.DataGridView dataCSS106;
        private System.Windows.Forms.Label labelCSS106;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopiaSIM;
        private System.Windows.Forms.Button btnCopiaValor;
        private System.Windows.Forms.Button btnCopiaCuentas;
        private System.Windows.Forms.RadioButton radioMoto;
        private System.Windows.Forms.RadioButton radioPatente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn SIM;
        private System.Windows.Forms.DataGridViewComboBoxColumn Valor;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox campoDatos;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
    }
}