namespace Plantilla_MAD.Ventanas
{
    partial class VentCEQMMPA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentCEQMMPA));
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.campoOCO = new System.Windows.Forms.TextBox();
            this.checkOCO = new System.Windows.Forms.CheckBox();
            this.dataCEQMMPA = new System.Windows.Forms.DataGridView();
            this.labelCEQMMPA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiaCondicion = new System.Windows.Forms.Button();
            this.btnCopiaValor = new System.Windows.Forms.Button();
            this.btnCopiaEquipos = new System.Windows.Forms.Button();
            this.btnCopiaCuentas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campoNano = new System.Windows.Forms.TextBox();
            this.checkNano = new System.Windows.Forms.CheckBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCEQMMPA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(96, 69);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 26;
            // 
            // campoOCO
            // 
            this.campoOCO.Location = new System.Drawing.Point(370, 69);
            this.campoOCO.Name = "campoOCO";
            this.campoOCO.Size = new System.Drawing.Size(100, 20);
            this.campoOCO.TabIndex = 25;
            this.campoOCO.Visible = false;
            // 
            // checkOCO
            // 
            this.checkOCO.AutoSize = true;
            this.checkOCO.Location = new System.Drawing.Point(264, 69);
            this.checkOCO.Name = "checkOCO";
            this.checkOCO.Size = new System.Drawing.Size(92, 17);
            this.checkOCO.TabIndex = 24;
            this.checkOCO.Text = "Necesita OC?";
            this.checkOCO.UseVisualStyleBackColor = true;
            this.checkOCO.CheckedChanged += new System.EventHandler(this.checkOCO_CheckedChanged);
            // 
            // dataCEQMMPA
            // 
            this.dataCEQMMPA.AllowUserToResizeRows = false;
            this.dataCEQMMPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCEQMMPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCEQMMPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movil,
            this.Cuenta,
            this.Modelo,
            this.Valor,
            this.Condicion});
            this.dataCEQMMPA.Location = new System.Drawing.Point(28, 130);
            this.dataCEQMMPA.Name = "dataCEQMMPA";
            this.dataCEQMMPA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataCEQMMPA.Size = new System.Drawing.Size(697, 272);
            this.dataCEQMMPA.TabIndex = 23;
            this.dataCEQMMPA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCEQMMPA_CellClick);
            this.dataCEQMMPA.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCEQMMPA_CellClick);
            this.dataCEQMMPA.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCEQMMPA_RowLeave);
            this.dataCEQMMPA.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataCEQMMPA_RowsRemoved);
            // 
            // labelCEQMMPA
            // 
            this.labelCEQMMPA.AutoSize = true;
            this.labelCEQMMPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEQMMPA.Location = new System.Drawing.Point(557, 42);
            this.labelCEQMMPA.Name = "labelCEQMMPA";
            this.labelCEQMMPA.Size = new System.Drawing.Size(68, 13);
            this.labelCEQMMPA.TabIndex = 22;
            this.labelCEQMMPA.Text = "CEQMMPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "CAMBIO DE EQUIPO PA";
            // 
            // btnCopiaCondicion
            // 
            this.btnCopiaCondicion.Location = new System.Drawing.Point(596, 102);
            this.btnCopiaCondicion.Name = "btnCopiaCondicion";
            this.btnCopiaCondicion.Size = new System.Drawing.Size(110, 23);
            this.btnCopiaCondicion.TabIndex = 38;
            this.btnCopiaCondicion.Text = "Copia Condiciones";
            this.btnCopiaCondicion.UseVisualStyleBackColor = true;
            this.btnCopiaCondicion.Click += new System.EventHandler(this.btnCopiaCondicion_Click);
            // 
            // btnCopiaValor
            // 
            this.btnCopiaValor.Location = new System.Drawing.Point(500, 102);
            this.btnCopiaValor.Name = "btnCopiaValor";
            this.btnCopiaValor.Size = new System.Drawing.Size(73, 23);
            this.btnCopiaValor.TabIndex = 37;
            this.btnCopiaValor.Text = "Copia Valor";
            this.btnCopiaValor.UseVisualStyleBackColor = true;
            this.btnCopiaValor.Click += new System.EventHandler(this.btnCopiaValor_Click);
            // 
            // btnCopiaEquipos
            // 
            this.btnCopiaEquipos.Location = new System.Drawing.Point(337, 102);
            this.btnCopiaEquipos.Name = "btnCopiaEquipos";
            this.btnCopiaEquipos.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaEquipos.TabIndex = 36;
            this.btnCopiaEquipos.Text = "Copia Equipo";
            this.btnCopiaEquipos.UseVisualStyleBackColor = true;
            this.btnCopiaEquipos.Click += new System.EventHandler(this.btnCopiaEquipos_Click);
            // 
            // btnCopiaCuentas
            // 
            this.btnCopiaCuentas.Location = new System.Drawing.Point(157, 102);
            this.btnCopiaCuentas.Name = "btnCopiaCuentas";
            this.btnCopiaCuentas.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaCuentas.TabIndex = 35;
            this.btnCopiaCuentas.Text = "Copia Cuenta";
            this.btnCopiaCuentas.UseVisualStyleBackColor = true;
            this.btnCopiaCuentas.Click += new System.EventHandler(this.btnCopiaCuentas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
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
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // campoNano
            // 
            this.campoNano.Location = new System.Drawing.Point(662, 68);
            this.campoNano.Name = "campoNano";
            this.campoNano.Size = new System.Drawing.Size(35, 20);
            this.campoNano.TabIndex = 41;
            this.campoNano.Visible = false;
            // 
            // checkNano
            // 
            this.checkNano.AutoSize = true;
            this.checkNano.Location = new System.Drawing.Point(558, 69);
            this.checkNano.Name = "checkNano";
            this.checkNano.Size = new System.Drawing.Size(101, 17);
            this.checkNano.TabIndex = 40;
            this.checkNano.Text = "SIM en blanco?";
            this.checkNano.UseVisualStyleBackColor = true;
            this.checkNano.CheckedChanged += new System.EventHandler(this.checkNano_CheckedChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(302, 411);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(78, 13);
            this.lblObs.TabIndex = 49;
            this.lblObs.Text = "Observaciones";
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(305, 427);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(189, 114);
            this.campoObs.TabIndex = 48;
            this.campoObs.Text = "";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(597, 518);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 47;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(578, 470);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 46;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 45;
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
            "Paula Sola G.",
            "Philipp Gallardo G.",
            "Romina Saez G.",
            "Sandra Lazcano A.",
            "Simon Segura B.",
            "Vladimir Cubillos R."});
            this.comboEjecutivo.Location = new System.Drawing.Point(574, 427);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Datos de contacto";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(46, 427);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(189, 114);
            this.campoDatos.TabIndex = 42;
            this.campoDatos.Text = "";
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
            "ALC PIXI 3 4,0 BLACK \t126156",
            "ALC PIXI 4 4,0 BLACK \t126171",
            "ALC PIXI 4 5,0 4G BLACK \t126177",
            "ALC U5 BLACK \t126186",
            "APL IPHONE 6 32GB SPACE GREY \t136205",
            "APL IPHONE 6S 128GB SPACE GRAY \t136133",
            "APL IPHONE 6S 16GB GOLD \t136129",
            "APL IPHONE 6S 16GB SILVER \t136128",
            "APL IPHONE 6S 16GB SPACE GRAY \t136127",
            "APL IPHONE 6S 32GB SPACE GREY \t136189",
            "APL IPHONE 6S 64GB SILVER \t136132",
            "APL IPHONE 6S PLUS 16GB SPACE GRAY \t136134",
            "APL IPHONE 6S PLUS 64GB SPACE GRAY \t136138",
            "APL IPHONE 7 128GB BLACK \t136167",
            "APL IPHONE 7 128GB JET BLACK \t136164",
            "APL IPHONE 7 256GB BLACK \t136172",
            "APL IPHONE 7 256GB JET BLACK \t136169",
            "APL IPHONE 7 32GB BLACK \t136162",
            "APL IPHONE 7 32GB ROSE GOLD \t136160",
            "APL IPHONE 7 PLUS 128GB BLACK \t136182",
            "APL IPHONE 7 PLUS 128GB JET BLACK \t136179",
            "APL IPHONE 7 PLUS 32GB BLACK \t136177",
            "APL IPHONE SE SILVER 16GB \t136145",
            "APL IPHONE SE SILVER 64GB \t136149",
            "APL IPHONE SE SPACE GRAY 16GB \t136144",
            "APL IPHONE SE SPACE GRAY 64GB \t136148",
            "APPLE IPHONE 5S 16GB SPC GRAY \t136067",
            "APPLE IPHONE 6 16 GB SPACE GRAY \t136085",
            "APPLE IPHONE 6 16GB SILVER \t136086",
            "APPLE IPHONE 6 64 GB SPACE GRAY \t136082",
            "APPLE IPHONE 6 64GB SILVER \t136083",
            "APPLE IPHONE 6 PLUS 16GB SPC GRAY \t136092",
            "APPLE IPHONE 6S 64GB SPACE GRAY \t136131",
            "APPLE IPHONE 6S PLUS 16GB SILVER \t136135",
            "APPLE IPHONE 8 256GB SILVER\t136236",
            "APPLE IPHONE 8 256GB SPACE GRAY\t136235",
            "APPLE IPHONE 8 64GB SILVER\t136233",
            "APPLE IPHONE 8 64GB SPACE GRAY\t136232",
            "APPLE IPHONE 8 PLUS 256GB SPACE GRAY\t136241",
            "APPLE IPHONE 8 PLUS 64GB SILVER\t136239",
            "APPLE IPHONE 8 PLUS 64GB SPACE GRAY\t136238",
            "APPLE IPHONE X 256GB SPACE GRAY\t136246",
            "APPLE IPHONE X 64GB SILVER\t136245",
            "APPLE IPHONE X 64GB SPACE GRAY\t136244",
            "CALAMP LMU 3030 GPS\t165002",
            "ENFORA MT-Gu GSM2358 \t122009",
            "HUA P10 BLACK \t133171",
            "HUA P9 LITE 2017 BLACK \t133173",
            "HUA VALLEY Y635 BLACK \t133126",
            "HUAWEI B68L HSPA+ \t133120",
            "HUAWEI E3131 HSPA+ WHT \t133112",
            "HUAWEI E3276s BLANCO LTE  \t133098",
            "HUAWEI E3372 LTE \t133132",
            "HUAWEI E5573 MIFI \t133133",
            "HUAWEI E5776s NEGRO LTE    \t133099",
            "HUAWEI E8231 HSPA+WIFI \t133131",
            "HUAWEI E8372H LTE \t133167",
            "HUAWEI F317 FIJO BLANCO \t133123",
            "HUAWEI GR5 BLACK \t133143",
            "HUAWEI MATE 9 BLACK \t133165",
            "HUAWEI P8 LITE (ALICE) BLACK \t133134",
            "HUAWEI P9 BLACK \t133150",
            "HUAWEI P9 GOLD \t133151",
            "HUAWEI P9 LITE BLACK \t133152",
            "HUAWEI P9 LITE SMART GRAY\t133177",
            "HUAWEI P9 LITE WHITE \t133153",
            "HUAWEI ROUTER B310LTE EMPRE WHT \t133161",
            "HUAWEI ROUTER LTE B310 \t133130",
            "HUAWEI ROUTER LTE B310 BAFI V2 WHITE \t133168",
            "HUAWEI Y6 II BLACK \t133163",
            "HUAWEI Y7 BLACK\t133180",
            "LG G4 STYLUS BLACK \t124203",
            "LG G4 STYLUS WHITE \t124204",
            "LG K10 2017 BLACK\t124233",
            "LG K10 LTE BLACK \t124205",
            "LG K4 BROWN \t124229",
            "LG MAGNA LTE BLACK \t124195",
            "LG PROMO G5 + BATTERY BLACK \t124213",
            "LG X CAM BLACK \t124211",
            "LG X STYLE BLACK \t124225",
            "MOT MOTO Z PLAY LUNAR GREY \t104137",
            "MOTOROLA MOTO E4 PLUS GRAY\t104142",
            "MOTOROLA MOTO G 3RA GEN BLACK \t104123",
            "MOTOROLA MOTO G 4TA GEN BLACK \t104128",
            "MOTOROLA MOTO X PLAY BLACK \t104125",
            "NOKIA 220 BLK \t105337",
            "NOKIA LUMIA 520 BLK \t105317",
            "NOKIA LUMIA 520 WHT \t105316",
            "NOKIA LUMIA 630 WHT \t105343",
            "NOKIA LUMIA 635 BLK \t105348",
            "OWN F1035 3G BLACK \t162050",
            "OWN F1035 3G WHITE \t162051",
            "OWN FUN BLACK \t162038",
            "OWN ONE BLACK \t162056",
            "OWN S4035 4G BLACK \t162048",
            "QUECLINK GV300 GPS \t166001",
            "SAM ACE 4 NEO BLACK \t106504",
            "SAM CORE PRIME (G360G) BLACK \t106495",
            "SAM GALAXY J1 ACE LTE BLACK \t106538",
            "SAM GALAXY J1 ACE LTE VE BLACK \t106551",
            "SAM GALAXY J1 ACE LTE VE WHITE \t106552",
            "SAM GALAXY J2 BLACK \t106561",
            "SAM GALAXY J2 PRIME BLACK \t106597",
            "SAM GALAXY J5 2016 BLACK \t106583",
            "SAM GALAXY J5 BLACK \t106526",
            "SAM GALAXY J5 WHITE \t106527",
            "SAM GALAXY J7 2016 BLACK \t106586",
            "SAM GALAXY J7 2016 GOLD \t106587",
            "SAM GALAXY J7 BLACK \t106540",
            "SAM GALAXY S6 BLACK \t106518",
            "SAM GALAXY S6 EDGE BLACK \t106520",
            "SAM GALAXY S6 EDGE GOLD \t106525",
            "SAM GALAXY S6 EDGE PLUS BLACK \t106543",
            "SAM GALAXY S6 EDGE PLUS GOLD \t106544",
            "SAM GALAXY S7 + VR BLACK \t106563",
            "SAM GALAXY S7 BLACK \t106553",
            "SAM GALAXY S7 EDGE + VR BLACK \t106566",
            "SAM GALAXY S7 EDGE + VR SILVER \t106567",
            "SAM GALAXY S7 EDGE BLACK \t106556",
            "SAM GALAXY S7 EDGE GOLD \t106558",
            "SAM GALAXY S7 EDGE SILVER \t106557",
            "SAM GALAXY S7 SILVER \t106554",
            "SAM GALAXY S8 BLACK \t106616",
            "SAM GALAXY S8 GOLD \t106617",
            "SAM GALAXY S8 ORCHID GREY\t106618",
            "SAM GALAXY S8 PLUS BLACK \t106620",
            "SAM GALAXY S8 PLUS GOLD \t106621",
            "SAM GLXY A5 (A500) BLACK \t106497",
            "SAM GRAND PRIME LTE (D530)U BLACK \t106522",
            "SAM SAM GALAXY J7 GOLD \t106541",
            "SAMSUNG GALAXY J7 NEO BLACK\t106643",
            "SAMSUNG GALAXY J7 NEO GOLD\t106644",
            "SAMSUNG GALAXY J7 NEO SILVER\t106645",
            "SAMSUNG GALAXY J7 PRO BLACK\t106633",
            "SAMSUNG GALAXY J7 PRO GOLD\t106632",
            "SAMSUNG GALAXY NOTE 8 + DEX BLACK\t106642",
            "SAMSUNG GALAXY NOTE 8 BLACK\t106636",
            "SAMSUNG GALAXY NOTE 8 BLACK\t106636",
            "SAMSUNG GEAR VR ACC \t106572",
            "SAMSUNG GLX NT 3 NEO N7505 BLK \t106441",
            "SAMSUNG J5 BLACK + CARCASA \t106592",
            "SAMSUNG J5 WHITE + CARCASA \t106593",
            "SAMSUNG J7 GOLD + CARCASA \t106596",
            "SONY XPERIA E4G BLCK \t102319",
            "SONY XPERIA M4 AQUA BLACK \t102317",
            "SONY XPERIA M4 AQUA WHITE \t102318",
            "SONY XPERIA M5 BLACK \t102325",
            "SONY XPERIA X BLACK \t102334",
            "SONY XPERIA XA ULTRA BLACK \t102336"});
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
            // VentCEQMMPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(766, 556);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.campoNano);
            this.Controls.Add(this.checkNano);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCopiaCondicion);
            this.Controls.Add(this.btnCopiaValor);
            this.Controls.Add(this.btnCopiaEquipos);
            this.Controls.Add(this.btnCopiaCuentas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.campoOCO);
            this.Controls.Add(this.checkOCO);
            this.Controls.Add(this.dataCEQMMPA);
            this.Controls.Add(this.labelCEQMMPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentCEQMMPA";
            this.Text = "CAMBIO DE EQUIPO PA";
            ((System.ComponentModel.ISupportInitialize)(this.dataCEQMMPA)).EndInit();
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
        private System.Windows.Forms.DataGridView dataCEQMMPA;
        private System.Windows.Forms.Label labelCEQMMPA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopiaCondicion;
        private System.Windows.Forms.Button btnCopiaValor;
        private System.Windows.Forms.Button btnCopiaEquipos;
        private System.Windows.Forms.Button btnCopiaCuentas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox campoNano;
        private System.Windows.Forms.CheckBox checkNano;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox campoDatos;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
    }
}