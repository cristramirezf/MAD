namespace Plantilla_MAD.Ventanas
{
    partial class VentHMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentHMM));
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopiaCondicion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCopiaEquipos = new System.Windows.Forms.Button();
            this.btnCopiaPlan = new System.Windows.Forms.Button();
            this.btnCopiaValor = new System.Windows.Forms.Button();
            this.btnCopiaSIM = new System.Windows.Forms.Button();
            this.btnCopiaCuentas = new System.Windows.Forms.Button();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataHMM = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.campoOCO = new System.Windows.Forms.TextBox();
            this.checkOCO = new System.Windows.Forms.CheckBox();
            this.labelHMM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            this.lblFraude = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValorEq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHMM)).BeginInit();
            this.SuspendLayout();
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
            // btnCopiaCondicion
            // 
            this.btnCopiaCondicion.Location = new System.Drawing.Point(894, 97);
            this.btnCopiaCondicion.Name = "btnCopiaCondicion";
            this.btnCopiaCondicion.Size = new System.Drawing.Size(110, 23);
            this.btnCopiaCondicion.TabIndex = 67;
            this.btnCopiaCondicion.Text = "Copia Condiciones";
            this.btnCopiaCondicion.UseVisualStyleBackColor = true;
            this.btnCopiaCondicion.Click += new System.EventHandler(this.btnCopiaCondicion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Copia Valor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCopiaValorEq_Click);
            // 
            // btnCopiaEquipos
            // 
            this.btnCopiaEquipos.Location = new System.Drawing.Point(626, 97);
            this.btnCopiaEquipos.Name = "btnCopiaEquipos";
            this.btnCopiaEquipos.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaEquipos.TabIndex = 65;
            this.btnCopiaEquipos.Text = "Copia Equipo";
            this.btnCopiaEquipos.UseVisualStyleBackColor = true;
            this.btnCopiaEquipos.Click += new System.EventHandler(this.btnCopiaEquipos_Click);
            // 
            // btnCopiaPlan
            // 
            this.btnCopiaPlan.Location = new System.Drawing.Point(420, 98);
            this.btnCopiaPlan.Name = "btnCopiaPlan";
            this.btnCopiaPlan.Size = new System.Drawing.Size(110, 23);
            this.btnCopiaPlan.TabIndex = 64;
            this.btnCopiaPlan.Text = "Copia Plan";
            this.btnCopiaPlan.UseVisualStyleBackColor = true;
            this.btnCopiaPlan.Click += new System.EventHandler(this.btnCopiaPlan_Click);
            // 
            // btnCopiaValor
            // 
            this.btnCopiaValor.Location = new System.Drawing.Point(302, 98);
            this.btnCopiaValor.Name = "btnCopiaValor";
            this.btnCopiaValor.Size = new System.Drawing.Size(69, 23);
            this.btnCopiaValor.TabIndex = 63;
            this.btnCopiaValor.Text = "Copia Valor";
            this.btnCopiaValor.UseVisualStyleBackColor = true;
            this.btnCopiaValor.Click += new System.EventHandler(this.btnCopiaValor_Click);
            // 
            // btnCopiaSIM
            // 
            this.btnCopiaSIM.Location = new System.Drawing.Point(233, 98);
            this.btnCopiaSIM.Name = "btnCopiaSIM";
            this.btnCopiaSIM.Size = new System.Drawing.Size(70, 23);
            this.btnCopiaSIM.TabIndex = 62;
            this.btnCopiaSIM.Text = "Copia SIM";
            this.btnCopiaSIM.UseVisualStyleBackColor = true;
            this.btnCopiaSIM.Click += new System.EventHandler(this.btnCopiaSIM_Click);
            // 
            // btnCopiaCuentas
            // 
            this.btnCopiaCuentas.Location = new System.Drawing.Point(135, 99);
            this.btnCopiaCuentas.Name = "btnCopiaCuentas";
            this.btnCopiaCuentas.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaCuentas.TabIndex = 61;
            this.btnCopiaCuentas.Text = "Copia Cuenta";
            this.btnCopiaCuentas.UseVisualStyleBackColor = true;
            this.btnCopiaCuentas.Click += new System.EventHandler(this.btnCopiaCuentas_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // dataHMM
            // 
            this.dataHMM.AllowUserToResizeRows = false;
            this.dataHMM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHMM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Cuenta,
            this.SIM,
            this.Valor,
            this.Plan,
            this.Modelo,
            this.ValorEq,
            this.Condicion});
            this.dataHMM.Location = new System.Drawing.Point(22, 125);
            this.dataHMM.Name = "dataHMM";
            this.dataHMM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataHMM.Size = new System.Drawing.Size(997, 272);
            this.dataHMM.TabIndex = 59;
            this.dataHMM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHMM_CellClick);
            this.dataHMM.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHMM_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(90, 66);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 51;
            // 
            // campoOCO
            // 
            this.campoOCO.Location = new System.Drawing.Point(339, 66);
            this.campoOCO.Name = "campoOCO";
            this.campoOCO.Size = new System.Drawing.Size(100, 20);
            this.campoOCO.TabIndex = 50;
            this.campoOCO.Visible = false;
            // 
            // checkOCO
            // 
            this.checkOCO.AutoSize = true;
            this.checkOCO.Location = new System.Drawing.Point(233, 66);
            this.checkOCO.Name = "checkOCO";
            this.checkOCO.Size = new System.Drawing.Size(92, 17);
            this.checkOCO.TabIndex = 49;
            this.checkOCO.Text = "Necesita OC?";
            this.checkOCO.UseVisualStyleBackColor = true;
            this.checkOCO.CheckedChanged += new System.EventHandler(this.checkOCO_CheckedChanged);
            // 
            // labelHMM
            // 
            this.labelHMM.AutoSize = true;
            this.labelHMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHMM.Location = new System.Drawing.Point(838, 40);
            this.labelHMM.Name = "labelHMM";
            this.labelHMM.Size = new System.Drawing.Size(36, 13);
            this.labelHMM.TabIndex = 48;
            this.labelHMM.Text = "HMM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "HABILITACIÓN DE LÍNEA MM";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(462, 412);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(78, 13);
            this.lblObs.TabIndex = 75;
            this.lblObs.Text = "Observaciones";
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(465, 428);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(189, 114);
            this.campoObs.TabIndex = 74;
            this.campoObs.Text = "";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(765, 519);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 73;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(746, 471);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 72;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(739, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // comboEjecutivo
            // 
            this.comboEjecutivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEjecutivo.FormattingEnabled = true;
            this.comboEjecutivo.Items.AddRange(new object[] {
            "Andrea Hinojosa G.",
            "Angelica Silva S.",
            "Carol Rios G.",
            "Carolina Arellano D.",
            "Carolina Ayal E.",
            "Catherine Torres B.",
            "Claudia Sola G.",
            "Danitza Leyton M.",
            "Danitza Rendich O.",
            "Elizabeth Pavez S.",
            "Felipe Figueroa L.",
            "Francisca Garcia B.",
            "Francisco Castillo S.",
            "Javier Beroiza A.",
            "Javiera Molina G.",
            "Julia Dominguez L.",
            "Kimberly Moraga G.",
            "Lorena Garcia N.",
            "Lorena Jiménez M.",
            "Loreto Barriga R.",
            "Luz Gaete Ch.",
            "Maria Jose Marchant V.",
            "María Loreto Caceres A.",
            "Maria Renata Ramirez A.",
            "Mario Santibañez M.",
            "Matias Brito A.",
            "Mirtha Castro C.",
            "Paloma Parra G.",
            "Paula Sola G.",
            "Sandra Lazcano A.",
            "Simon Segura B.",
            "Vladimir Cubillos R."});
            this.comboEjecutivo.Location = new System.Drawing.Point(742, 428);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Datos de contacto";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(180, 428);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(189, 114);
            this.campoDatos.TabIndex = 68;
            this.campoDatos.Text = "";
            // 
            // lblFraude
            // 
            this.lblFraude.AutoSize = true;
            this.lblFraude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraude.ForeColor = System.Drawing.Color.Red;
            this.lblFraude.Location = new System.Drawing.Point(588, 66);
            this.lblFraude.Name = "lblFraude";
            this.lblFraude.Size = new System.Drawing.Size(416, 13);
            this.lblFraude.TabIndex = 167;
            this.lblFraude.Text = "Recordar: equipos MM salen a valor PCE, de acuerdo a plan contratado";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.Width = 60;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.Width = 120;
            // 
            // SIM
            // 
            this.SIM.AutoComplete = false;
            this.SIM.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SIM.HeaderText = "SIM";
            this.SIM.Items.AddRange(new object[] {
            "",
            "349",
            "365",
            "366"});
            this.SIM.Name = "SIM";
            this.SIM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SIM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SIM.Width = 50;
            // 
            // Valor
            // 
            this.Valor.AutoComplete = false;
            this.Valor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Valor.HeaderText = "Valor SIM";
            this.Valor.Items.AddRange(new object[] {
            "0",
            "832",
            "2101"});
            this.Valor.Name = "Valor";
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Valor.Width = 80;
            // 
            // Plan
            // 
            this.Plan.AutoComplete = false;
            this.Plan.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Plan.HeaderText = "Plan";
            this.Plan.Items.AddRange(new object[] {
            "",
            "ALC PIXI 3 4,0 BLACK 126156",
            "ALC PIXI 4 4,0 BLACK 126171",
            "ALC PIXI 4 5,0 4G BLACK 126177",
            "APL IPHONE 6S 128GB SPACE GRAY 136133",
            "APL IPHONE 6S 16GB GOLD 136129",
            "APL IPHONE 6S 16GB SPACE GRAY 136127",
            "APL IPHONE 6S 32GB SPACE GREY 136189",
            "APL IPHONE 6S 64GB SILVER 136132",
            "APL IPHONE 6S PLUS 16GB SPACE GRAY 136134",
            "APL IPHONE 6S PLUS 64GB SPACE GRAY 136138",
            "APL IPHONE 7 128GB BLACK 136167",
            "APL IPHONE 7 128GB JET BLACK 136164",
            "APL IPHONE 7 256GB BLACK 136172",
            "APL IPHONE 7 32GB BLACK 136162",
            "APL IPHONE 7 32GB ROSE GOLD 136160",
            "APL IPHONE 7 PLUS 128GB BLACK 136182",
            "APL IPHONE 7 PLUS 128GB JET BLACK 136179",
            "APL IPHONE 7 PLUS 32GB BLACK 136177",
            "APL IPHONE SE SILVER 16GB 136145",
            "APL IPHONE SE SILVER 64GB 136149",
            "APL IPHONE SE SPACE GRAY 16GB 136144",
            "APL IPHONE SE SPACE GRAY 64GB 136148",
            "APPLE IPHONE 5S 16GB SPC GRAY 136067",
            "APPLE IPHONE 6 16 GB SPACE GRAY 136085",
            "APPLE IPHONE 6 16GB SILVER 136086",
            "APPLE IPHONE 6 64 GB SPACE GRAY 136082",
            "APPLE IPHONE 6 64GB SILVER 136083",
            "APPLE IPHONE 6 PLUS 16GB SPC GRAY 136092",
            "APPLE IPHONE 6S 64GB SPACE GRAY 136131",
            "APPLE IPHONE 6S PLUS 16GB SILVER 136135",
            "ENFORA MT-Gu GSM2358 122009",
            "HUA VALLEY Y635 BLACK 133126",
            "HUAWEI B68L HSPA+ 133120",
            "HUAWEI E3131 HSPA+ WHT 133112",
            "HUAWEI E3276s BLANCO LTE  133098",
            "HUAWEI E3372 LTE 133132",
            "HUAWEI E5573 MIFI 133133",
            "HUAWEI E5776s NEGRO LTE    133099",
            "HUAWEI E8231 HSPA+WIFI 133131",
            "HUAWEI F317 FIJO BLANCO 133123",
            "HUAWEI GR5 BLACK 133143",
            "HUAWEI MATE 9 BLACK 133165",
            "HUAWEI P8 LITE (ALICE) BLACK 133134",
            "HUAWEI P9 BLACK 133150",
            "HUAWEI P9 GOLD 133151",
            "HUAWEI P9 LITE BLACK 133152",
            "HUAWEI P9 LITE WHITE 133153",
            "HUAWEI ROUTER B310LTE EMPRE WHT 133161",
            "HUAWEI ROUTER LTE B310 133130",
            "HUAWEI Y6 II BLACK 133163",
            "LG G4 STYLUS BLACK 124203",
            "LG G4 STYLUS WHITE 124204",
            "LG K10 LTE BLACK 124205",
            "LG MAGNA LTE BLACK 124195",
            "LG PROMO G5 + BATTERY BLACK 124213",
            "LG X CAM BLACK 124211",
            "LG X STYLE BLACK 124225",
            "MOTOROLA MOTO G 3RA GEN BLACK 104123",
            "MOTOROLA MOTO G 4TA GEN BLACK 104128",
            "MOTOROLA MOTO X PLAY BLACK 104125",
            "NOKIA 220 BLK 105337",
            "NOKIA LUMIA 520 BLK 105317",
            "NOKIA LUMIA 520 WHT 105316",
            "NOKIA LUMIA 630 WHT 105343",
            "NOKIA LUMIA 635 BLK 105348",
            "OWN F1035 3G BLACK 162050",
            "OWN F1035 3G WHITE 162051",
            "OWN FUN BLACK 162038",
            "OWN ONE BLACK 162056",
            "OWN S4035 4G BLACK 162048",
            "QUECLINK GV300 GPS 166001",
            "SAM ACE 4 NEO BLACK 106504",
            "SAM CORE PRIME (G360G) BLACK 106495",
            "SAM GALAXY J1 ACE LTE BLACK 106538",
            "SAM GALAXY J1 ACE LTE VE BLACK 106551",
            "SAM GALAXY J1 ACE LTE VE WHITE 106552",
            "SAM GALAXY J2 BLACK 106561",
            "SAM GALAXY J2 PRIME BLACK 106597",
            "SAM GALAXY J5 2016 BLACK 106583",
            "SAM GALAXY J5 BLACK 106526",
            "SAM GALAXY J5 WHITE 106527",
            "SAM GALAXY J7 2016 BLACK 106586",
            "SAM GALAXY J7 2016 GOLD 106587",
            "SAM GALAXY J7 BLACK 106540",
            "SAM GALAXY S6 BLACK 106518",
            "SAM GALAXY S6 EDGE BLACK 106520",
            "SAM GALAXY S6 EDGE GOLD 106525",
            "SAM GALAXY S6 EDGE PLUS BLACK 106543",
            "SAM GALAXY S6 EDGE PLUS GOLD 106544",
            "SAM GALAXY S7 + VR BLACK 106563",
            "SAM GALAXY S7 BLACK 106553",
            "SAM GALAXY S7 EDGE + VR BLACK 106566",
            "SAM GALAXY S7 EDGE + VR SILVER 106567",
            "SAM GALAXY S7 EDGE BLACK 106556",
            "SAM GALAXY S7 EDGE GOLD 106558",
            "SAM GALAXY S7 EDGE SILVER 106557",
            "SAM GALAXY S7 SILVER 106554",
            "SAM GLXY A5 (A500) BLACK 106497",
            "SAM GRAND PRIME LTE (D530)U BLACK 106522",
            "SAM SAM GALAXY J7 GOLD 106541",
            "SAMSUNG GEAR VR ACC 106572",
            "SAMSUNG GLX NT 3 NEO N7505 BLK 106441",
            "SAMSUNG J5 BLACK + CARCASA 106592",
            "SAMSUNG J5 WHITE + CARCASA 106593",
            "SAMSUNG J7 GOLD + CARCASA 106596",
            "SONY XPERIA E4G BLCK 102319",
            "SONY XPERIA M4 AQUA BLACK 102317",
            "SONY XPERIA M4 AQUA WHITE 102318",
            "SONY XPERIA M5 BLACK 102325",
            "SONY XPERIA X BLACK 102334",
            "SONY XPERIA XA ULTRA BLACK 102336"});
            this.Plan.Name = "Plan";
            this.Plan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Plan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Plan.Width = 200;
            // 
            // Modelo
            // 
            this.Modelo.AutoComplete = false;
            this.Modelo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Items.AddRange(new object[] {
            "",
            "ALC PIXI 3 4,0 BLACK 126156",
            "ALC PIXI 4 4,0 BLACK 126171",
            "ALC PIXI 4 5,0 4G BLACK 126177",
            "APL IPHONE 6S 128GB SPACE GRAY 136133",
            "APL IPHONE 6S 16GB GOLD 136129",
            "APL IPHONE 6S 16GB SPACE GRAY 136127",
            "APL IPHONE 6S 32GB SPACE GREY 136189",
            "APL IPHONE 6S 64GB SILVER 136132",
            "APL IPHONE 6S PLUS 16GB SPACE GRAY 136134",
            "APL IPHONE 6S PLUS 64GB SPACE GRAY 136138",
            "APL IPHONE 7 128GB BLACK 136167",
            "APL IPHONE 7 128GB JET BLACK 136164",
            "APL IPHONE 7 256GB BLACK 136172",
            "APL IPHONE 7 32GB BLACK 136162",
            "APL IPHONE 7 32GB ROSE GOLD 136160",
            "APL IPHONE 7 PLUS 128GB BLACK 136182",
            "APL IPHONE 7 PLUS 128GB JET BLACK 136179",
            "APL IPHONE 7 PLUS 32GB BLACK 136177",
            "APL IPHONE SE SILVER 16GB 136145",
            "APL IPHONE SE SILVER 64GB 136149",
            "APL IPHONE SE SPACE GRAY 16GB 136144",
            "APL IPHONE SE SPACE GRAY 64GB 136148",
            "APPLE IPHONE 5S 16GB SPC GRAY 136067",
            "APPLE IPHONE 6 16 GB SPACE GRAY 136085",
            "APPLE IPHONE 6 16GB SILVER 136086",
            "APPLE IPHONE 6 64 GB SPACE GRAY 136082",
            "APPLE IPHONE 6 64GB SILVER 136083",
            "APPLE IPHONE 6 PLUS 16GB SPC GRAY 136092",
            "APPLE IPHONE 6S 64GB SPACE GRAY 136131",
            "APPLE IPHONE 6S PLUS 16GB SILVER 136135",
            "ENFORA MT-Gu GSM2358 122009",
            "HUA VALLEY Y635 BLACK 133126",
            "HUAWEI B68L HSPA+ 133120",
            "HUAWEI E3131 HSPA+ WHT 133112",
            "HUAWEI E3276s BLANCO LTE  133098",
            "HUAWEI E3372 LTE 133132",
            "HUAWEI E5573 MIFI 133133",
            "HUAWEI E5776s NEGRO LTE    133099",
            "HUAWEI E8231 HSPA+WIFI 133131",
            "HUAWEI F317 FIJO BLANCO 133123",
            "HUAWEI GR5 BLACK 133143",
            "HUAWEI MATE 9 BLACK 133165",
            "HUAWEI P8 LITE (ALICE) BLACK 133134",
            "HUAWEI P9 BLACK 133150",
            "HUAWEI P9 GOLD 133151",
            "HUAWEI P9 LITE BLACK 133152",
            "HUAWEI P9 LITE WHITE 133153",
            "HUAWEI ROUTER LTE B310 133130",
            "HUAWEI Y6 II BLACK 133163",
            "LG G4 STYLUS BLACK 124203",
            "LG G4 STYLUS WHITE 124204",
            "LG K10 LTE BLACK 124205",
            "LG MAGNA LTE BLACK 124195",
            "LG PROMO G5 + BATTERY BLACK 124213",
            "LG X CAM BLACK 124211",
            "LG X STYLE BLACK 124225",
            "MOTOROLA MOTO G 3RA GEN BLACK 104123",
            "MOTOROLA MOTO G 4TA GEN BLACK 104128",
            "MOTOROLA MOTO X PLAY BLACK 104125",
            "NOKIA 220 BLK 105337",
            "NOKIA LUMIA 520 BLK 105317",
            "NOKIA LUMIA 520 WHT 105316",
            "NOKIA LUMIA 630 WHT 105343",
            "NOKIA LUMIA 635 BLK 105348",
            "OWN F1035 3G BLACK 162050",
            "OWN F1035 3G WHITE 162051",
            "OWN FUN BLACK 162038",
            "OWN ONE BLACK 162056",
            "OWN S4035 4G BLACK 162048",
            "QUECLINK GV300 GPS 166001",
            "SAM ACE 4 NEO BLACK 106504",
            "SAM CORE PRIME (G360G) BLACK 106495",
            "SAM GALAXY J1 ACE LTE BLACK 106538",
            "SAM GALAXY J1 ACE LTE VE BLACK 106551",
            "SAM GALAXY J1 ACE LTE VE WHITE 106552",
            "SAM GALAXY J2 BLACK 106561",
            "SAM GALAXY J2 PRIME BLACK 106597",
            "SAM GALAXY J5 2016 BLACK 106583",
            "SAM GALAXY J5 BLACK 106526",
            "SAM GALAXY J5 WHITE 106527",
            "SAM GALAXY J7 2016 BLACK 106586",
            "SAM GALAXY J7 2016 GOLD 106587",
            "SAM GALAXY J7 BLACK 106540",
            "SAM GALAXY S6 BLACK 106518",
            "SAM GALAXY S6 EDGE BLACK 106520",
            "SAM GALAXY S6 EDGE GOLD 106525",
            "SAM GALAXY S6 EDGE PLUS BLACK 106543",
            "SAM GALAXY S6 EDGE PLUS GOLD 106544",
            "SAM GALAXY S7 + VR BLACK 106563",
            "SAM GALAXY S7 BLACK 106553",
            "SAM GALAXY S7 EDGE + VR BLACK 106566",
            "SAM GALAXY S7 EDGE + VR SILVER 106567",
            "SAM GALAXY S7 EDGE BLACK 106556",
            "SAM GALAXY S7 EDGE GOLD 106558",
            "SAM GALAXY S7 EDGE SILVER 106557",
            "SAM GALAXY S7 SILVER 106554",
            "SAM GLXY A5 (A500) BLACK 106497",
            "SAM GRAND PRIME LTE (D530)U BLACK 106522",
            "SAM SAM GALAXY J7 GOLD 106541",
            "SAMSUNG GEAR VR ACC 106572",
            "SAMSUNG GLX NT 3 NEO N7505 BLK 106441",
            "SAMSUNG J5 BLACK + CARCASA 106592",
            "SAMSUNG J5 WHITE + CARCASA 106593",
            "SAMSUNG J7 GOLD + CARCASA 106596",
            "SONY XPERIA E4G BLCK 102319",
            "SONY XPERIA M4 AQUA BLACK 102317",
            "SONY XPERIA M4 AQUA WHITE 102318",
            "SONY XPERIA M5 BLACK 102325",
            "SONY XPERIA X BLACK 102334",
            "SONY XPERIA XA ULTRA BLACK 102336"});
            this.Modelo.Name = "Modelo";
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modelo.Width = 230;
            // 
            // ValorEq
            // 
            this.ValorEq.HeaderText = "Valor Equipo";
            this.ValorEq.Name = "ValorEq";
            this.ValorEq.Width = 90;
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Cond. Comercial";
            this.Condicion.Name = "Condicion";
            this.Condicion.Width = 125;
            // 
            // VentHMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 560);
            this.Controls.Add(this.lblFraude);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.btnCopiaCondicion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCopiaEquipos);
            this.Controls.Add(this.btnCopiaPlan);
            this.Controls.Add(this.btnCopiaValor);
            this.Controls.Add(this.btnCopiaSIM);
            this.Controls.Add(this.btnCopiaCuentas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataHMM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.campoOCO);
            this.Controls.Add(this.checkOCO);
            this.Controls.Add(this.labelHMM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentHMM";
            this.Text = "HABILITACIÓN DE LÍNEA MM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHMM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnCopiaCondicion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCopiaEquipos;
        private System.Windows.Forms.Button btnCopiaPlan;
        private System.Windows.Forms.Button btnCopiaValor;
        private System.Windows.Forms.Button btnCopiaSIM;
        private System.Windows.Forms.Button btnCopiaCuentas;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataHMM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.TextBox campoOCO;
        private System.Windows.Forms.CheckBox checkOCO;
        private System.Windows.Forms.Label labelHMM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn SIM;
        private System.Windows.Forms.DataGridViewComboBoxColumn Valor;
        private System.Windows.Forms.DataGridViewComboBoxColumn Plan;
        private System.Windows.Forms.DataGridViewComboBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
    }
}