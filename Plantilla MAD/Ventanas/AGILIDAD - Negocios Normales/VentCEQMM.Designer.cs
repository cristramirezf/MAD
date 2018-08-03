﻿namespace Plantilla_MAD.Ventanas
{
    partial class VentCEQMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentCEQMM));
            this.checkNano = new System.Windows.Forms.CheckBox();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campoNano = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopiaCondicion = new System.Windows.Forms.Button();
            this.btnCopiaValor = new System.Windows.Forms.Button();
            this.btnCopiaEquipos = new System.Windows.Forms.Button();
            this.btnCopiaCuentas = new System.Windows.Forms.Button();
            this.labelCEQMM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.campoOCO = new System.Windows.Forms.TextBox();
            this.checkOCO = new System.Windows.Forms.CheckBox();
            this.dataCEQMM = new System.Windows.Forms.DataGridView();
            this.lblObs = new System.Windows.Forms.Label();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            this.lblFraude = new System.Windows.Forms.Label();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCEQMM)).BeginInit();
            this.SuspendLayout();
            // 
            // checkNano
            // 
            this.checkNano.AutoSize = true;
            this.checkNano.Location = new System.Drawing.Point(733, 84);
            this.checkNano.Margin = new System.Windows.Forms.Padding(4);
            this.checkNano.Name = "checkNano";
            this.checkNano.Size = new System.Drawing.Size(135, 21);
            this.checkNano.TabIndex = 63;
            this.checkNano.Text = "¿SIM en blanco?";
            this.checkNano.UseVisualStyleBackColor = true;
            this.checkNano.CheckedChanged += new System.EventHandler(this.checkNano_CheckedChanged);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
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
            // campoNano
            // 
            this.campoNano.Location = new System.Drawing.Point(876, 82);
            this.campoNano.Margin = new System.Windows.Forms.Padding(4);
            this.campoNano.Name = "campoNano";
            this.campoNano.Size = new System.Drawing.Size(45, 22);
            this.campoNano.TabIndex = 64;
            this.campoNano.Visible = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1016, 28);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // btnCopiaCondicion
            // 
            this.btnCopiaCondicion.Location = new System.Drawing.Point(797, 156);
            this.btnCopiaCondicion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopiaCondicion.Name = "btnCopiaCondicion";
            this.btnCopiaCondicion.Size = new System.Drawing.Size(147, 28);
            this.btnCopiaCondicion.TabIndex = 61;
            this.btnCopiaCondicion.Text = "Copia Condiciones";
            this.btnCopiaCondicion.UseVisualStyleBackColor = true;
            this.btnCopiaCondicion.Click += new System.EventHandler(this.btnCopiaCondicion_Click);
            // 
            // btnCopiaValor
            // 
            this.btnCopiaValor.Location = new System.Drawing.Point(665, 156);
            this.btnCopiaValor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopiaValor.Name = "btnCopiaValor";
            this.btnCopiaValor.Size = new System.Drawing.Size(97, 28);
            this.btnCopiaValor.TabIndex = 60;
            this.btnCopiaValor.Text = "Copia Valor";
            this.btnCopiaValor.UseVisualStyleBackColor = true;
            this.btnCopiaValor.Click += new System.EventHandler(this.btnCopiaValor_Click);
            // 
            // btnCopiaEquipos
            // 
            this.btnCopiaEquipos.Location = new System.Drawing.Point(447, 156);
            this.btnCopiaEquipos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopiaEquipos.Name = "btnCopiaEquipos";
            this.btnCopiaEquipos.Size = new System.Drawing.Size(121, 28);
            this.btnCopiaEquipos.TabIndex = 59;
            this.btnCopiaEquipos.Text = "Copia Equipo";
            this.btnCopiaEquipos.UseVisualStyleBackColor = true;
            this.btnCopiaEquipos.Click += new System.EventHandler(this.btnCopiaEquipos_Click);
            // 
            // btnCopiaCuentas
            // 
            this.btnCopiaCuentas.Location = new System.Drawing.Point(209, 156);
            this.btnCopiaCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopiaCuentas.Name = "btnCopiaCuentas";
            this.btnCopiaCuentas.Size = new System.Drawing.Size(121, 28);
            this.btnCopiaCuentas.TabIndex = 58;
            this.btnCopiaCuentas.Text = "Copia Cuenta";
            this.btnCopiaCuentas.UseVisualStyleBackColor = true;
            this.btnCopiaCuentas.Click += new System.EventHandler(this.btnCopiaCuentas_Click);
            // 
            // labelCEQMM
            // 
            this.labelCEQMM.AutoSize = true;
            this.labelCEQMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEQMM.Location = new System.Drawing.Point(745, 50);
            this.labelCEQMM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCEQMM.Name = "labelCEQMM";
            this.labelCEQMM.Size = new System.Drawing.Size(64, 17);
            this.labelCEQMM.TabIndex = 46;
            this.labelCEQMM.Text = "CEQMM";
            this.labelCEQMM.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "CAMBIO DE EQUIPO MM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(128, 84);
            this.campoRUT.Margin = new System.Windows.Forms.Padding(4);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(132, 22);
            this.campoRUT.TabIndex = 50;
            // 
            // campoOCO
            // 
            this.campoOCO.Location = new System.Drawing.Point(505, 84);
            this.campoOCO.Margin = new System.Windows.Forms.Padding(4);
            this.campoOCO.Name = "campoOCO";
            this.campoOCO.Size = new System.Drawing.Size(132, 22);
            this.campoOCO.TabIndex = 49;
            this.campoOCO.Visible = false;
            // 
            // checkOCO
            // 
            this.checkOCO.AutoSize = true;
            this.checkOCO.Location = new System.Drawing.Point(355, 84);
            this.checkOCO.Margin = new System.Windows.Forms.Padding(4);
            this.checkOCO.Name = "checkOCO";
            this.checkOCO.Size = new System.Drawing.Size(148, 21);
            this.checkOCO.TabIndex = 48;
            this.checkOCO.Text = "¿Necesita OC/NP?";
            this.checkOCO.UseVisualStyleBackColor = true;
            this.checkOCO.CheckedChanged += new System.EventHandler(this.checkOCO_CheckedChanged);
            // 
            // dataCEQMM
            // 
            this.dataCEQMM.AllowUserToResizeRows = false;
            this.dataCEQMM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCEQMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCEQMM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movil,
            this.Cuenta,
            this.Modelo,
            this.Valor,
            this.Condicion});
            this.dataCEQMM.Location = new System.Drawing.Point(37, 191);
            this.dataCEQMM.Margin = new System.Windows.Forms.Padding(4);
            this.dataCEQMM.Name = "dataCEQMM";
            this.dataCEQMM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataCEQMM.Size = new System.Drawing.Size(929, 335);
            this.dataCEQMM.TabIndex = 47;
            this.dataCEQMM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCEQMM_CellClick);
            this.dataCEQMM.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCEQMM_CellClick);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(407, 542);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(103, 17);
            this.lblObs.TabIndex = 72;
            this.lblObs.Text = "Observaciones";
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(411, 561);
            this.campoObs.Margin = new System.Windows.Forms.Padding(4);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(251, 139);
            this.campoObs.TabIndex = 71;
            this.campoObs.Text = "";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(788, 645);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(133, 28);
            this.btnGrabar.TabIndex = 70;
            this.btnGrabar.Text = "Copiar AC";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(763, 614);
            this.btnCopiaProy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(183, 28);
            this.btnCopiaProy.TabIndex = 69;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Visible = false;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 542);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 68;
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
            this.comboEjecutivo.Location = new System.Drawing.Point(757, 561);
            this.comboEjecutivo.Margin = new System.Windows.Forms.Padding(4);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(193, 24);
            this.comboEjecutivo.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 542);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Datos de contacto";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(57, 561);
            this.campoDatos.Margin = new System.Windows.Forms.Padding(4);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(251, 139);
            this.campoDatos.TabIndex = 65;
            this.campoDatos.Text = "";
            // 
            // lblFraude
            // 
            this.lblFraude.AutoSize = true;
            this.lblFraude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraude.ForeColor = System.Drawing.Color.Red;
            this.lblFraude.Location = new System.Drawing.Point(33, 124);
            this.lblFraude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFraude.Name = "lblFraude";
            this.lblFraude.Size = new System.Drawing.Size(530, 17);
            this.lblFraude.TabIndex = 166;
            this.lblFraude.Text = "Recordar: equipos MM salen a valor PCE, de acuerdo a plan contratado";
            // 
            // Movil
            // 
            this.Movil.HeaderText = "Móvil";
            this.Movil.Name = "Movil";
            this.Movil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Movil.Width = 70;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.Width = 126;
            // 
            // Modelo
            // 
            this.Modelo.AutoComplete = false;
            this.Modelo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Items.AddRange(new object[] {
            "--",
            "ALC PIXI 3 4,0 BLACK                                                             " +
                "                                       126156",
            "ALC PIXI 4 4,0 BLACK                                                             " +
                "                                       126171",
            "ALC PIXI 4 5,0 4G BLACK                                                          " +
                "                                          126177",
            "ALC U5 BLACK                                                                     " +
                "                               126186",
            "APL IPHONE 6 32GB SPACE GREY                                                     " +
                "                                               136205",
            "APL IPHONE 6S 128GB SPACE GRAY                                                   " +
                "                                                 136133",
            "APL IPHONE 6S 16GB GOLD                                                          " +
                "                                          136129",
            "APL IPHONE 6S 16GB SILVER                                                        " +
                "                                            136128",
            "APL IPHONE 6S 16GB SPACE GRAY                                                    " +
                "                                                136127",
            "APL IPHONE 6S 32GB SPACE GREY                                                    " +
                "                                                136189",
            "APL IPHONE 6S 64GB SILVER                                                        " +
                "                                            136132",
            "APL IPHONE 6S PLUS 16GB SPACE GRAY                                               " +
                "                                                     136134",
            "APL IPHONE 6S PLUS 64GB SPACE GRAY                                               " +
                "                                                     136138",
            "APL IPHONE 7 128GB BLACK                                                         " +
                "                                           136167",
            "APL IPHONE 7 128GB JET BLACK                                                     " +
                "                                               136164",
            "APL IPHONE 7 256GB BLACK                                                         " +
                "                                           136172",
            "APL IPHONE 7 256GB JET BLACK                                                     " +
                "                                               136169",
            "APL IPHONE 7 32GB BLACK                                                          " +
                "                                          136162",
            "APL IPHONE 7 32GB ROSE GOLD                                                      " +
                "                                              136160",
            "APL IPHONE 7 PLUS 128GB BLACK                                                    " +
                "                                                136182",
            "APL IPHONE 7 PLUS 128GB JET BLACK                                                " +
                "                                                    136179",
            "APL IPHONE 7 PLUS 32GB BLACK                                                     " +
                "                                               136177",
            "APL IPHONE SE SILVER 16GB                                                        " +
                "                                            136145",
            "APL IPHONE SE SILVER 64GB                                                        " +
                "                                            136149",
            "APL IPHONE SE SPACE GRAY 16GB                                                    " +
                "                                                136144",
            "APL IPHONE SE SPACE GRAY 64GB                                                    " +
                "                                                136148",
            "APPLE IPHONE 5S 16GB SPC GRAY                                                    " +
                "                                                136067",
            "APPLE IPHONE 6 16 GB SPACE GRAY                                                  " +
                "                                                  136085",
            "APPLE IPHONE 6 16GB SILVER                                                       " +
                "                                             136086",
            "APPLE IPHONE 6 64 GB SPACE GRAY                                                  " +
                "                                                  136082",
            "APPLE IPHONE 6 64GB SILVER                                                       " +
                "                                             136083",
            "APPLE IPHONE 6 PLUS 16GB SPC GRAY                                                " +
                "                                                    136092",
            "APPLE IPHONE 6S 64GB SPACE GRAY                                                  " +
                "                                                  136131",
            "APPLE IPHONE 6S PLUS 16GB SILVER                                                 " +
                "                                                   136135",
            "APPLE IPHONE 8 256GB SILVER                                                      " +
                "                                              136236",
            "APPLE IPHONE 8 256GB SPACE GRAY                                                  " +
                "                                                  136235",
            "APPLE IPHONE 8 64GB SILVER                                                       " +
                "                                             136233",
            "APPLE IPHONE 8 64GB SPACE GRAY                                                   " +
                "                                                 136232",
            "APPLE IPHONE 8 PLUS 256GB SPACE GRAY                                             " +
                "                                                       136241",
            "APPLE IPHONE 8 PLUS 64GB SILVER                                                  " +
                "                                                  136239",
            "APPLE IPHONE 8 PLUS 64GB SPACE GRAY                                              " +
                "                                                      136238",
            "APPLE IPHONE X 256GB SPACE GRAY                                                  " +
                "                                                  136246",
            "APPLE IPHONE X 64GB SILVER                                                       " +
                "                                             136245",
            "APPLE IPHONE X 64GB SPACE GRAY                                                   " +
                "                                                 136244",
            "CALAMP LMU 3030 GPS                                                              " +
                "                                      165002",
            "ENFORA MT-Gu GSM2358                                                             " +
                "                                       122009",
            "HUA P10 BLACK                                                                    " +
                "                                133171",
            "HUA P9 LITE 2017 BLACK                                                           " +
                "                                         133173",
            "HUA VALLEY Y635 BLACK                                                            " +
                "                                        133126",
            "HUAWEI B68L HSPA+                                                                " +
                "                                    133120",
            "HUAWEI E3131 HSPA+ WHT                                                           " +
                "                                         133112",
            "HUAWEI E3276s BLANCO LTE                                                         " +
                "                                           133098",
            "HUAWEI E3372 LTE                                                                 " +
                "                                   133132",
            "HUAWEI E5573 MIFI                                                                " +
                "                                    133133",
            "HUAWEI E5776s NEGRO LTE                                                          " +
                "                                          133099",
            "HUAWEI E8231 HSPA+WIFI                                                           " +
                "                                         133131",
            "HUAWEI E8372H LTE                                                                " +
                "                                    133167",
            "HUAWEI F317 FIJO BLANCO                                                          " +
                "                                          133123",
            "HUAWEI GR5 BLACK                                                                 " +
                "                                   133143",
            "HUAWEI MATE 10 LITE BLACK                                                        " +
                "                                            133185",
            "HUAWEI MATE 10 PRO GREY                                                          " +
                "                                          133188",
            "HUAWEI MATE 9 BLACK                                                              " +
                "                                      133165",
            "HUAWEI P SMART                                                                   " +
                "                                 133197",
            "HUAWEI P20                                                                       " +
                "                             133201",
            "HUAWEI P20 BLACK + SEGURO                                                        " +
                "                                            133201",
            "HUAWEI P8 LITE (ALICE) BLACK                                                     " +
                "                                               133134",
            "HUAWEI P9 BLACK                                                                  " +
                "                                  133150",
            "HUAWEI P9 GOLD                                                                   " +
                "                                 133151",
            "HUAWEI P9 LITE BLACK                                                             " +
                "                                       133152",
            "HUAWEI P9 LITE SMART GRAY                                                        " +
                "                                            133177",
            "HUAWEI P9 LITE WHITE                                                             " +
                "                                       133153",
            "HUAWEI ROUTER B310LTE EMPRE WHT                                                  " +
                "                                                  133161",
            "HUAWEI ROUTER B612 BAFI BLANCO                                                   " +
                "                                                 133176",
            "HUAWEI ROUTER LTE B310                                                           " +
                "                                         133130",
            "HUAWEI ROUTER LTE B310 BAFI V2 WHITE                                             " +
                "                                                       133168",
            "HUAWEI Y5 2018 BLACK                                                             " +
                "                                       133193",
            "HUAWEI Y6 2018 BLACK                                                             " +
                "                                       133192",
            "HUAWEI Y6 II BLACK                                                               " +
                "                                     133163",
            "HUAWEI Y7 2018 BLACK                                                             " +
                "                                       133194",
            "HUAWEI Y7 BLACK                                                                  " +
                "                                  133180",
            "HUAWEI Y7 2018 BLACK                                                             " +
                "                                       133194",
            "LG G4 STYLUS BLACK                                                               " +
                "                                     124203",
            "LG G4 STYLUS WHITE                                                               " +
                "                                     124204",
            "LG K10 2017 BLACK                                                                " +
                "                                    124233",
            "LG K10 LTE BLACK                                                                 " +
                "                                   124205",
            "LG K4 BROWN                                                                      " +
                "                              124229",
            "LG MAGNA LTE BLACK                                                               " +
                "                                     124195",
            "LG PROMO G5 + BATTERY BLACK                                                      " +
                "                                              124213",
            "LG X CAM BLACK                                                                   " +
                "                                 124211",
            "LG X STYLE BLACK                                                                 " +
                "                                   124225",
            "MOT MOTO Z PLAY LUNAR GREY                                                       " +
                "                                             104137",
            "MOTOROLA MOTO E4 PLUS GRAY                                                       " +
                "                                             104142",
            "MOTOROLA MOTO E4 PLUS GRAY                                                       " +
                "                                             104142",
            "MOTOROLA MOTO E5 FLASH GREY                                                      " +
                "                                              104153",
            "MOTOROLA MOTO G 3RA GEN BLACK                                                    " +
                "                                                104123",
            "MOTOROLA MOTO G6 PLAY DEEP INDIGO                                                " +
                "                                                    104155",
            "MOTOROLA MOTO G 4TA GEN BLACK                                                    " +
                "                                                104128",
            "MOTOROLA MOTO G 5S LUNAR GRAY                                                    " +
                "                                                104145",
            "MOTOROLA MOTO X PLAY BLACK                                                       " +
                "                                             104125",
            "NOKIA 6 BLACK                                                                    " +
                "                                105353",
            "NOKIA 6 BLUE                                                                     " +
                "                               105355",
            "NOKIA 220 BLK                                                                    " +
                "                                105337",
            "NOKIA LUMIA 520 BLK                                                              " +
                "                                      105317",
            "NOKIA LUMIA 520 WHT                                                              " +
                "                                      105316",
            "NOKIA LUMIA 630 WHT                                                              " +
                "                                      105343",
            "NOKIA LUMIA 635 BLK                                                              " +
                "                                      105348",
            "OWN F1035 3G BLACK                                                               " +
                "                                     162050",
            "OWN F1035 3G WHITE                                                               " +
                "                                     162051",
            "OWN FUN 6 BLACK                                                                  " +
                "                                  162109",
            "OWN FUN BLACK                                                                    " +
                "                                162038",
            "OWN ONE BLACK                                                                    " +
                "                                162056",
            "OWN S4035 4G BLACK                                                               " +
                "                                     162048",
            "QUECLINK GV300 GPS                                                               " +
                "                                     166001",
            "SAM ACE 4 NEO BLACK                                                              " +
                "                                      106504",
            "SAM CORE PRIME (G360G) BLACK                                                     " +
                "                                               106495",
            "SAM GALAXY J1 ACE LTE BLACK                                                      " +
                "                                              106538",
            "SAM GALAXY J1 ACE LTE VE BLACK                                                   " +
                "                                                 106551",
            "SAM GALAXY J1 ACE LTE VE WHITE                                                   " +
                "                                                 106552",
            "SAM GALAXY J2 BLACK                                                              " +
                "                                      106561",
            "SAM GALAXY J2 PRIME BLACK                                                        " +
                "                                            106597",
            "SAM GALAXY J5 2016 BLACK                                                         " +
                "                                           106583",
            "SAM GALAXY J5 BLACK                                                              " +
                "                                      106526",
            "SAM GALAXY J5 WHITE                                                              " +
                "                                      106527",
            "SAM GALAXY J7 2016 BLACK                                                         " +
                "                                           106586",
            "SAM GALAXY J7 2016 GOLD                                                          " +
                "                                          106587",
            "SAM GALAXY J7 BLACK                                                              " +
                "                                      106540",
            "SAM GALAXY S6 BLACK                                                              " +
                "                                      106518",
            "SAM GALAXY S6 EDGE BLACK                                                         " +
                "                                           106520",
            "SAM GALAXY S6 EDGE GOLD                                                          " +
                "                                          106525",
            "SAM GALAXY S6 EDGE PLUS BLACK                                                    " +
                "                                                106543",
            "SAM GALAXY S6 EDGE PLUS GOLD                                                     " +
                "                                               106544",
            "SAM GALAXY S7 + VR BLACK                                                         " +
                "                                           106563",
            "SAM GALAXY S7 BLACK                                                              " +
                "                                      106553",
            "SAM GALAXY S7 EDGE + VR BLACK                                                    " +
                "                                                106566",
            "SAM GALAXY S7 EDGE + VR SILVER                                                   " +
                "                                                 106567",
            "SAM GALAXY S7 EDGE BLACK                                                         " +
                "                                           106556",
            "SAM GALAXY S7 EDGE GOLD                                                          " +
                "                                          106558",
            "SAM GALAXY S7 EDGE SILVER                                                        " +
                "                                            106557",
            "SAM GALAXY S7 SILVER                                                             " +
                "                                       106554",
            "SAM GALAXY S8 BLACK                                                              " +
                "                                      106616",
            "SAM GALAXY S8 GOLD                                                               " +
                "                                     106617",
            "SAM GALAXY S8 ORCHID GREY                                                        " +
                "                                            106618",
            "SAM GALAXY S8 PLUS BLACK                                                         " +
                "                                           106620",
            "SAM GALAXY S8 PLUS GOLD                                                          " +
                "                                          106621",
            "SAM GLXY A5 (A500) BLACK                                                         " +
                "                                           106497",
            "SAM GRAND PRIME LTE (D530)U BLACK                                                " +
                "                                                    106522",
            "SAM SAM GALAXY J7 GOLD                                                           " +
                "                                         106541",
            "SAMSUNG GALAXY J4 BLACK                                                          " +
                "                                          106664",
            "SAMSUNG GALAXY J6 BLACK                                                          " +
                "                                          106666",
            "SAMSUNG GALAXY J7 NEO BLACK                                                      " +
                "                                              106643",
            "SAMSUNG GALAXY J7 NEO GOLD                                                       " +
                "                                             106644",
            "SAMSUNG GALAXY J7 NEO SILVER                                                     " +
                "                                               106645",
            "SAMSUNG GALAXY J7 PRO BLACK                                                      " +
                "                                              106633",
            "SAMSUNG GALAXY J7 PRO GOLD                                                       " +
                "                                             106632",
            "SAMSUNG GALAXY NOTE 8 + DEX BLACK                                                " +
                "                                                    106642",
            "SAMSUNG GALAXY NOTE 8 BLACK                                                      " +
                "                                              106636",
            "SAMSUNG GALAXY NOTE 8 BLACK                                                      " +
                "                                              106636",
            "SAMSUNG GALAXY S9 BLACK                                                          " +
                "                                          106646",
            "SAMSUNG GALAXY S9 LILA PURPLE                                                    " +
                "                                                106648",
            "SAMSUNG GALAXY S9+ BLACK                                                         " +
                "                                           106649",
            "SAMSUNG GALAXY S9+ LILA PURPLE                                                   " +
                "                                                 106651",
            "SAMSUNG GEAR VR ACC                                                              " +
                "                                      106572",
            "SAMSUNG GLX NT 3 NEO N7505 BLK                                                   " +
                "                                                 106441",
            "SAMSUNG J5 BLACK + CARCASA                                                       " +
                "                                             106592",
            "SAMSUNG J5 WHITE + CARCASA                                                       " +
                "                                             106593",
            "SAMSUNG J7 GOLD + CARCASA                                                        " +
                "                                            106596",
            "SONY XPERIA E4G BLCK                                                             " +
                "                                       102319",
            "SONY XPERIA M4 AQUA BLACK                                                        " +
                "                                            102317",
            "SONY XPERIA M4 AQUA WHITE                                                        " +
                "                                            102318",
            "SONY XPERIA M5 BLACK                                                             " +
                "                                       102325",
            "SONY XPERIA X BLACK                                                              " +
                "                                      102334",
            "SONY XPERIA XA ULTRA BLACK                                                       " +
                "                                             102336"});
            this.Modelo.Name = "Modelo";
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modelo.Width = 230;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor Neto";
            this.Valor.Name = "Valor";
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.Width = 80;
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Condición Comercial";
            this.Condicion.Name = "Condicion";
            this.Condicion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Condicion.Width = 150;
            // 
            // VentCEQMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1016, 731);
            this.Controls.Add(this.lblFraude);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.checkNano);
            this.Controls.Add(this.campoNano);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCopiaCondicion);
            this.Controls.Add(this.btnCopiaValor);
            this.Controls.Add(this.btnCopiaEquipos);
            this.Controls.Add(this.btnCopiaCuentas);
            this.Controls.Add(this.labelCEQMM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.campoOCO);
            this.Controls.Add(this.checkOCO);
            this.Controls.Add(this.dataCEQMM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VentCEQMM";
            this.Text = "CAMBIO DE EQUIPO MM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCEQMM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkNano;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.TextBox campoNano;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCopiaCondicion;
        private System.Windows.Forms.Button btnCopiaValor;
        private System.Windows.Forms.Button btnCopiaEquipos;
        private System.Windows.Forms.Button btnCopiaCuentas;
        private System.Windows.Forms.Label labelCEQMM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.TextBox campoOCO;
        private System.Windows.Forms.CheckBox checkOCO;
        private System.Windows.Forms.DataGridView dataCEQMM;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox campoDatos;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.Label lblFraude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
    }
}