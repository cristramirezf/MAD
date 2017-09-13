namespace Plantilla_MAD.Ventanas
{
    partial class VentHMMPA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentHMMPA));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataHMMPA = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.campoOCO = new System.Windows.Forms.TextBox();
            this.labelHMMPA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCopiaEquipos = new System.Windows.Forms.Button();
            this.btnCopiaPlan = new System.Windows.Forms.Button();
            this.btnCopiaValor = new System.Windows.Forms.Button();
            this.btnCopiaSIM = new System.Windows.Forms.Button();
            this.btnCopiaCuentas = new System.Windows.Forms.Button();
            this.btnCopiaCondicion = new System.Windows.Forms.Button();
            this.checkOCO = new System.Windows.Forms.CheckBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValorEq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHMMPA)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 84;
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
            // dataHMMPA
            // 
            this.dataHMMPA.AllowUserToResizeRows = false;
            this.dataHMMPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHMMPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHMMPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Cuenta,
            this.SIM,
            this.Valor,
            this.Plan,
            this.Modelo,
            this.ValorEq,
            this.Condicion});
            this.dataHMMPA.Location = new System.Drawing.Point(22, 125);
            this.dataHMMPA.Name = "dataHMMPA";
            this.dataHMMPA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataHMMPA.Size = new System.Drawing.Size(997, 272);
            this.dataHMMPA.TabIndex = 83;
            this.dataHMMPA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHMMPA_CellClick);
            this.dataHMMPA.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHMMPA_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(90, 66);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 75;
            // 
            // campoOCO
            // 
            this.campoOCO.Location = new System.Drawing.Point(339, 66);
            this.campoOCO.Name = "campoOCO";
            this.campoOCO.Size = new System.Drawing.Size(100, 20);
            this.campoOCO.TabIndex = 74;
            this.campoOCO.Visible = false;
            // 
            // labelHMMPA
            // 
            this.labelHMMPA.AutoSize = true;
            this.labelHMMPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHMMPA.Location = new System.Drawing.Point(838, 40);
            this.labelHMMPA.Name = "labelHMMPA";
            this.labelHMMPA.Size = new System.Drawing.Size(52, 13);
            this.labelHMMPA.TabIndex = 72;
            this.labelHMMPA.Text = "HMMPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "HABILITACIÓN DE LÍNEA PA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(803, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Copia Valor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCopiaValorEq_Click);
            // 
            // btnCopiaEquipos
            // 
            this.btnCopiaEquipos.Location = new System.Drawing.Point(643, 97);
            this.btnCopiaEquipos.Name = "btnCopiaEquipos";
            this.btnCopiaEquipos.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaEquipos.TabIndex = 89;
            this.btnCopiaEquipos.Text = "Copia Equipo";
            this.btnCopiaEquipos.UseVisualStyleBackColor = true;
            this.btnCopiaEquipos.Click += new System.EventHandler(this.btnCopiaEquipos_Click);
            // 
            // btnCopiaPlan
            // 
            this.btnCopiaPlan.Location = new System.Drawing.Point(420, 98);
            this.btnCopiaPlan.Name = "btnCopiaPlan";
            this.btnCopiaPlan.Size = new System.Drawing.Size(110, 23);
            this.btnCopiaPlan.TabIndex = 88;
            this.btnCopiaPlan.Text = "Copia Plan";
            this.btnCopiaPlan.UseVisualStyleBackColor = true;
            this.btnCopiaPlan.Click += new System.EventHandler(this.btnCopiaPlan_Click);
            // 
            // btnCopiaValor
            // 
            this.btnCopiaValor.Location = new System.Drawing.Point(302, 98);
            this.btnCopiaValor.Name = "btnCopiaValor";
            this.btnCopiaValor.Size = new System.Drawing.Size(69, 23);
            this.btnCopiaValor.TabIndex = 87;
            this.btnCopiaValor.Text = "Copia Valor";
            this.btnCopiaValor.UseVisualStyleBackColor = true;
            this.btnCopiaValor.Click += new System.EventHandler(this.btnCopiaValor_Click);
            // 
            // btnCopiaSIM
            // 
            this.btnCopiaSIM.Location = new System.Drawing.Point(233, 98);
            this.btnCopiaSIM.Name = "btnCopiaSIM";
            this.btnCopiaSIM.Size = new System.Drawing.Size(70, 23);
            this.btnCopiaSIM.TabIndex = 86;
            this.btnCopiaSIM.Text = "Copia SIM";
            this.btnCopiaSIM.UseVisualStyleBackColor = true;
            this.btnCopiaSIM.Click += new System.EventHandler(this.btnCopiaSIM_Click);
            // 
            // btnCopiaCuentas
            // 
            this.btnCopiaCuentas.Location = new System.Drawing.Point(135, 99);
            this.btnCopiaCuentas.Name = "btnCopiaCuentas";
            this.btnCopiaCuentas.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaCuentas.TabIndex = 85;
            this.btnCopiaCuentas.Text = "Copia Cuenta";
            this.btnCopiaCuentas.UseVisualStyleBackColor = true;
            this.btnCopiaCuentas.Click += new System.EventHandler(this.btnCopiaCuentas_Click);
            // 
            // btnCopiaCondicion
            // 
            this.btnCopiaCondicion.Location = new System.Drawing.Point(902, 97);
            this.btnCopiaCondicion.Name = "btnCopiaCondicion";
            this.btnCopiaCondicion.Size = new System.Drawing.Size(110, 23);
            this.btnCopiaCondicion.TabIndex = 91;
            this.btnCopiaCondicion.Text = "Copia Condiciones";
            this.btnCopiaCondicion.UseVisualStyleBackColor = true;
            this.btnCopiaCondicion.Click += new System.EventHandler(this.btnCopiaCondicion_Click);
            // 
            // checkOCO
            // 
            this.checkOCO.AutoSize = true;
            this.checkOCO.Location = new System.Drawing.Point(233, 66);
            this.checkOCO.Name = "checkOCO";
            this.checkOCO.Size = new System.Drawing.Size(92, 17);
            this.checkOCO.TabIndex = 73;
            this.checkOCO.Text = "Necesita OC?";
            this.checkOCO.UseVisualStyleBackColor = true;
            this.checkOCO.CheckedChanged += new System.EventHandler(this.checkOCO_CheckedChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(448, 409);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(78, 13);
            this.lblObs.TabIndex = 99;
            this.lblObs.Text = "Observaciones";
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(451, 425);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(189, 114);
            this.campoObs.TabIndex = 98;
            this.campoObs.Text = "";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(751, 516);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 97;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(732, 468);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 96;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 95;
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
            this.comboEjecutivo.Location = new System.Drawing.Point(728, 425);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Datos de contacto";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(166, 425);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(189, 114);
            this.campoDatos.TabIndex = 92;
            this.campoDatos.Text = "";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
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
            "1 ECONOMICO POS",
            "10 PCS 200",
            "100 CUENTA CONTROLADA 15950",
            "104 PLAN GLOBAL 65",
            "1050 MULTIMEDIA 115",
            "1051 MULTIMEDIA 140",
            "1052 MULTIMEDIA 200",
            "1053 MULTIMEDIA 300",
            "1054 MULTIMEDIA 420",
            "1055 MULTIMEDIA 500",
            "1056 MULTIMEDIA 800",
            "1057 MULTIMEDIA RED 800",
            "1058 MULTIMEDIA RED 1200",
            "1059 BAM CHILE COMUNICADO 1MBP",
            "1061 BAM MULTIMEDIA 3GB",
            "1062 BAM EMPRESAS PRO 1GB RE",
            "1063 BAM EMPRESAS PRO 3GB RE",
            "1069 BLACKBERRY MULTIMEDIA 500",
            "107 BAM",
            "1073 MULTIMEDIA RED TOTAL 20",
            "1074 MULTIMEDIA RED TOTAL 50",
            "1075 MULTIMEDIA RED TOTAL 50 P",
            "1076 MULTIMEDIA RED TOTAL 100",
            "1077 MULTIMEDIA RED TOTAL 200",
            "1078 MULTIMEDIA RED TOTAL 500",
            "108 CUENTA CONTROLADA 13740",
            "11 PCS 300",
            "112 PLAN TARIFA UNICA 300",
            "1129 M2M ILIMITADO",
            "113 PLAN TARIFA UNICA 100",
            "114 PLAN TARIFA UNICA 200",
            "115 PLAN TARIFA UNICA 400",
            "116 PLAN TARIFA UNICA 600",
            "117 TARIFA UNICA JOVEN",
            "118 TARIFA UNICA 70",
            "120 BAM",
            "1207 MI PYME 2",
            "121 BAM",
            "1219 PLAN BLACKBERRY RED 770",
            "122 PLAN TARIFA UNICA 55",
            "1221 MI PYME 3",
            "1222 MI PYME 4",
            "1223 MI PYME 5",
            "1224 MI PYME 6",
            "1225 MI PYME 7",
            "1226 MI PYME 8",
            "1227 MI PYME 9",
            "1228 MI PYME 10",
            "1229 MI PYME 11",
            "1230 MI PYME 12",
            "1231 MI PYME 13",
            "1232 MI PYME 14",
            "1233 MI PYME 15",
            "1234 MI PYME 20",
            "1235 MI PYME 25",
            "1236 MI PYME 30",
            "1239 MI PYME SMARTPHONE 500",
            "124 CUENTA CONTROLADA 15950",
            "1241 MI PYME BLACKBERRY 250",
            "125 CUENTA CONTROLADA 18150",
            "1252 BLACKBERRY MULTIMEDIA 100",
            "1253 MULTIMEDIA 100",
            "126 CUENTA CONTROLADA 22000",
            "1261 BAM CONTROLADO 7GB",
            "1262 BAM CONTROLADO 15GB",
            "1263 BAM CONTROLADO 1GB",
            "1270 BAM CONTROLADO 2GB",
            "1328 BAM EMPRESAS 2GB",
            "1329 BAM EMPRESAS 3GB",
            "1330 BAM EMPRESAS 5GB",
            "1331 BAM EMPRESAS 10G",
            "1331 BAM EMPRESAS PRO 10GB",
            "1332 BAM EMPRESAS 1GB",
            "1336 BAM EMPRESAS 2G",
            "1336 BAM EMPRESAS PRO 2G",
            "1337 BAM EMPRESAS 4G",
            "1337 BAM EMPRESAS PRO 4GB",
            "1338 BAM EMPRESAS 6G",
            "1338 BAM EMPRESAS PRO 6GB",
            "1339 BAM EMPRESAS PRO 15GB",
            "1339 BAM EMPRESAS15G",
            "1340 MULTIMEDIA 1000",
            "14 PCS MPP 400",
            "1402 MULTIMEDIA CC 13.990",
            "141 CUENTA CONTROLADA 27500",
            "1425 MULTIMEDIA RED 150",
            "1426 MULTIMEDIA RED 270",
            "1442 MI PYME SMARTPHONE 800",
            "1443 MI PYME SMARTPHONE 1.000",
            "1444 MI PYME CORREO 100",
            "1445 SMARTPHONE TD 200",
            "1446 SMARTPHONE TD 320",
            "1447 SMARTPHONE TD 500",
            "1448 SMARTPHONE TD 1000",
            "145 TARIFA UNICA 200 + 30 SMS",
            "1452 BAM PRO 2GB NORMAL",
            "1453 BAM PRO 4GB NORMAL",
            "1454 BAM PRO 6GB NORMAL",
            "1455 BAM PRO 10GB NORMAL",
            "1456 BAM PRO 15GB NORMAL",
            "1461 M2M CORPORACIONES SENS",
            "1466 MULTIMEDIA RED 500",
            "1467 MULTIMEDIA RED 1000",
            "1470 MULTIMEDIA FULL 1.5 GB",
            "1471 MULTIMEDIA FULL 2 GB",
            "1471 MULTIMEDIA FULL 2 GB ",
            "1472 MULTIMEDIA FULL 3 GB",
            "1472 MULTIMEDIA FULL 3 GB ",
            "1473 MULTIMEDIA FULL 4.5 GB",
            "1473 MULTIMEDIA FULL 4.5 GB ",
            "1474 MULTIMEDIA FULL 6 GB",
            "1474 MULTIMEDIA FULL 6 GB ",
            "1475 MULTIMEDIA FULL 7.5 GB",
            "1475 MULTIMEDIA FULL 7.5 GB ",
            "1476 MULTIMEDIA FULL 10 GB",
            "1477 MULTIMEDIA RED FULL 1 GB",
            "1480 M2M CORPORACIONES GAMM",
            "1488 MULTIMEDIA CC 16.990",
            "1489 MULTIMEDIA CC $20.990",
            "1489 MULTIMEDIA CC 20.990",
            "1490 MI EMPRESA SMARTPHONE 5",
            "1491 MI EMPRESA SMARTPHONE 6",
            "1492 MI EMPRESA SMARTPHONE 7",
            "1493 MI EMPRESA SMARTPHONE 8",
            "1494 MI EMPRESA SMARTPHONE 9",
            "1495 MI EMPRESA SMARTPHONE 10",
            "1496 MI EMPRESA SMARTPHONE 15",
            "1497 MI EMPRESA SMARTPHONE 20",
            "1498 MI EMPRESA SMARTPHONE 30",
            "1499 EMPRESA SMARTPHONE PRO5",
            "15 PCS 800",
            "15 PCS 800 R",
            "1500 EMPRESA SMARTPHONE PRO6",
            "1501 EMPRESA SMARTPHONE PRO7",
            "1502 EMPRESA SMARTPHONE PRO8",
            "1503 EMPRESA SMARTPHONE PRO9",
            "1504 EMPRESA SMARTPHONE PRO10",
            "1514 CTA CONTROLADA $17.500 ",
            "1520 CTA. CONTROLADA $6.900 ",
            "1521 ACCESO XG 1",
            "1522 ACCESO XG 2",
            "1523 BAM CONTROLADO CORP 2GB",
            "1524 BAM CONTROLADO CORP 4GB",
            "1525 BAM CONTROLADO CORP 6GB",
            "1526 BAM CONTROLADO CORP 10GB",
            "1527 BAM CONTROLADO CORP 15GB",
            "1528 BAM CONTROLADO CORP 30GB",
            "1529 M2M ALTO ",
            "1535 M2M BAJO ",
            "1536 M2M MEDIO",
            "1539 MULTIMEDIA CTA CDA $6.990 ",
            "1540 MULTIMEDIA CTA CDA $9.990 ",
            "1541 MULTIMEDIA CTA CDA $12.990 ",
            "1542 MULTIMEDIA CTA CDA $14.990 ",
            "1543 MI PRIMER MULTI $6.990 ",
            "1544 MI PRIMER MULTI. $9.990 ",
            "1556 TODO DESTINO 280",
            "1559 DATOS EMPRESA 2GB",
            "1560 DATOS EMPRESA 4GB",
            "1561 DATOS EMPRESA 10GB",
            "1568 PLAN ALTO TRAFICO 8.000",
            "1569 PLAN ALTO TRAFICO 5.000",
            "1570 PLAN ALTO TRAFICO 2.000",
            "1571 PLAN ALTO TRAFICO 500",
            "1573 AUTOGESTION PLUS 600MB 36",
            "1574 AUTOGESTION PLUS 600MB 34",
            "1575 AUTOGESTION PLUS 600MB 32",
            "1576 AUTOGESTION PLUS 600MB 30",
            "1576 AUTOGESTION PLUS 600MB 30 ",
            "1577 AUTOGESTION PLUS 600MB 28",
            "1578 AUTOGESTION PLUS 600MB 26",
            "1579 AUTOGESTION PLUS 600MB 24",
            "1580 AUTOGESTION PLUS 600MB 22",
            "1580 AUTOGESTION PLUS 600MB 22 ",
            "1581 AUTOGESTION PLUS 600MB 20",
            "1581 AUTOGESTION PLUS 600MB 20 ",
            "1582 AUTOGESTION PLUS 600MB 18",
            "1582 AUTOGESTION PLUS 600MB 18  ",
            "1583 AUTOGESTION PLUS 2GB 36",
            "1584 AUTOGESTION PLUS 2GB 34",
            "1585 AUTOGESTION PLUS 2GB 32",
            "1586 AUTOGESTION PLUS 2GB 30",
            "1587 AUTOGESTION PLUS 2GB 28",
            "1588 AUTOGESTION PLUS 2GB 26",
            "1589 AUTOGESTION PLUS 2GB 24",
            "1590 AUTOGESTION PLUS 2GB 22",
            "1591 AUTOGESTION PLUS 2GB 20",
            "1592 AUTOGESTION PLUS 2GB 18",
            "1594 BAM EMPRESAS 8 GB",
            "1595 BAM EMPRESAS 12 GB",
            "1596 BAM EMPRESAS 16 GB",
            "1597 BAM EMPRESAS 1 GB RET",
            "1606 MULTIMEDIA CTA CDA $17.990",
            "1614 VOZ ILIMITADA",
            "162 CTA CONTROLADA LIBRE 16500",
            "1624 CTA. CONTROLADA $13.900",
            "1625 CTA CONTROLADA $8.900",
            "1630 BAM CC 400 MB ",
            "1631 BAM CC 600 MB ",
            "1633 BAM CC 1 GB ",
            "1635 BAM CC 1,5 GB ",
            "1636 BAM CC 2 GB ",
            "1637 BAM CC 3,5 GB ",
            "1638 BAM CC 5 GB ",
            "1639 BAM CC 6,5 GB ",
            "164 CTA CONTROLADA LIBRE 22000",
            "1640 BAM CC 10 GB",
            "1641 BAM CC 8 GB ",
            "1643 BAM MI PRIMER PLAN 400MB ",
            "1644 BAM MI PRIMER PLAN 600MB",
            "165 CTA CONTROLADA LIBRE 27500",
            "1652 MULTI SMART 2 GB $25.990 ",
            "1653 MULTI SMART 3 GB $29.990 ",
            "1654 MULTI SMART 4.5 GB $39.990 ",
            "1655 MULTI SMART 6 GB $49.990 ",
            "1656 MULTI SMART 7.5 GB $59.990 ",
            "1657 MULTI SMART 10 GB $69.990 ",
            "166 TARIFA UNICA 60",
            "1663 AUTOGESTION PLUS 36",
            "1664 AUTOGESTION PLUS 34",
            "1665 AUTOGESTION PLUS 18",
            "1665 AUTOGESTION PLUS 20",
            "1665 AUTOGESTION PLUS 22",
            "1665 AUTOGESTION PLUS 24",
            "1665 AUTOGESTION PLUS 26",
            "1665 AUTOGESTION PLUS 28",
            "1665 AUTOGESTION PLUS 30",
            "1665 AUTOGESTION PLUS 32",
            "1666 AUTOGESTION PLUS 30",
            "1667 AUTOGESTION PLUS 28",
            "1668 AUTOGESTION PLUS 26",
            "1669 AUTOGESTION PLUS 24",
            "1670 AUTOGESTION PLUS 22",
            "1671 AUTOGESTION PLUS 20",
            "1672 AUTOGESTION PLUS 18",
            "1673 AUTOGESTION PLUS 1GB 36",
            "1674 AUTOGESTION PLUS 1GB 34",
            "1675 AUTOGESTION PLUS 1GB 32",
            "1676 AUTOGESTION PLUS 1GB 30",
            "1677 AUTOGESTION PLUS 1GB 28",
            "1678 AUTOGESTION PLUS 1GB 26",
            "1678 AUTOGESTION PLUS 1GB 26 ",
            "1679 AUTOGESTION PLUS 1GB 24",
            "1679 AUTOGESTION PLUS 1GB 24 ",
            "168 TARIFA UNICA 120",
            "1680 AUTOGESTION PLUS 1GB 22",
            "1680 AUTOGESTION PLUS 1GB 22 ",
            "1681 AUTOGESTION PLUS 1GB 20",
            "1681 AUTOGESTION PLUS 1GB 20 ",
            "1682 AUTOGESTION PLUS 1GB 18",
            "1682 AUTOGESTION PLUS 1GB 18 ",
            "1683 AUTOGESTION PLUS 1.5GB 36",
            "1684 AUTOGESTION PLUS 1.5GB 34",
            "1685 AUTOGESTION PLUS 1.5GB 32",
            "1686 AUTOGESTION PLUS 1.5GB 30",
            "1687 AUTOGESTION PLUS 1.5GB 28",
            "1688 AUTOGESTION PLUS 1.5GB 26",
            "1689 AUTOGESTION PLUS 1.5GB 24",
            "1690 AUTOGESTION PLUS 1.5GB 22",
            "1691 AUTOGESTION PLUS 1.5GB 20",
            "1692 AUTOGESTION PLUS 1.5GB 18",
            "1693 AUTOGESTION PLUS 3GBFULL",
            "1694 AUTOGESTION PLUS 4GBFULL",
            "1695 AUTOGESTION PLUS 6GBFULL",
            "1696 AUTOGESTION PLUS 8GBFULL",
            "1697 AUTOGESTION PLUS 10GBFULL",
            "1698 AUTOGESTION PLUS 12GBFULL",
            "170 PLAN TARIFA UNICA 400",
            "171 PLAN TARIFA UNICA 600",
            "1734 M2M CONTINGENCIA MINSAL",
            "1735 MULTIMEDIA CC 15.990",
            "1738 BAM PRO 1GB CORP 18",
            "1740 BAM PRO 3GB CORP 18",
            "1743 AUTOGESTION PLUS 38",
            "1744 AUTOGESTION PLUS 40",
            "1745 AUTOGESTION PLUS 42",
            "1746 AUTOGESTION PLUS 44",
            "1747 AUTOGESTION PLUS 600MB 38",
            "1748 AUTOGESTION PLUS 600MB 40",
            "1749 AUTOGESTION PLUS 600MB 42",
            "1750 AUTOGESTION PLUS 600MB 44",
            "1751 AUTOGESTION PLUS 1GB 38",
            "1752 AUTOGESTION PLUS 1GB 40",
            "1753 AUTOGESTION PLUS 1GB 42",
            "1754 AUTOGESTION PLUS 1GB 44",
            "1755 AUTOGESTION PLUS 1.5GB 38",
            "1756 AUTOGESTION PLUS 1.5GB 40",
            "1757 AUTOGESTION PLUS 1.5GB 42",
            "1758 AUTOGESTION PLUS 1.5GB 44",
            "1759 AUTOGESTION PLUS 2GB 38",
            "1760 AUTOGESTION PLUS 2GB 40",
            "1761 AUTOGESTION PLUS 2GB 42",
            "1762 AUTOGESTION PLUS 2GB 44",
            "1763 BAM CC 3 GB ",
            "1764 M2M UBI UNO",
            "181 CUENTA CONTROLADA RED",
            "182 CUENTA CONTROLADA RED",
            "183 CUENTA CONTROLADA RED",
            "184 CUENTA CONTROLADA RED",
            "1850 AUTOGESTION PLUS 600MB",
            "1851 AUTOGESTION PLUS 1GB",
            "1852 AUTOGESTION PLUS 1,5GB",
            "1853 AUTOGESTION PLUS 2GB",
            "1854 AUTOGESTION PLUS 3GB ",
            "1855 AUTOGESTION PLUS 4GB ",
            "1856 AUTOGESTION PLUS 6GB ",
            "1857 AUTOGESTION PLUS 8GB ",
            "1858 AUTOGESTION PLUS 10GB ",
            "1859 AUTOGESTION PLUS 12GB ",
            "1860 AUTOGESTION PLUS 16GB ",
            "1861 AUTOGESTION PLUS 20GB ",
            "185 CTA CONTROLADA PLANO 11000",
            "186 CTA CONTROLADA PLANO 13690",
            "187 CTA CONTROLADA PLANO 16490",
            "188 CTA CONTROLADA PLANO 21990",
            "189 CTA CONTROLADA PLANO 27390",
            "190 TARIFA UNICA 85",
            "191 TARIFA UNICA 150",
            "192 TARIFA UNICA 250",
            "194 TARIFA UNICA 150",
            "195 TARIFA UNICA 250",
            "196 PLAN UNICO 4290",
            "2 SUPERECONOMICO POS",
            "213 BAM CONTROLADO 1,5GB",
            "214 BAM CONTROLADO 3GB",
            "218 BAM MASCONECTADO 1GB",
            "246 BAM 700KBPS NETBOOK",
            "260 BAM XI,XII,IDP 200KBPS PER",
            "261 BAM XI,XII,IDP 700KBPS PER",
            "262 BAM MASCONECTADO 10GB",
            "290 CTA CONTROLADA RED 6990",
            "291 CTA CONTROLADA RED 8990",
            "292 CTA CONTROLADA RED 11990",
            "307 ECORP 5400 SEGUNDOS",
            "308 ECORP 24000 SEGUNDOS",
            "310 ECORP 96000S",
            "313 ECORP 7200 SEGUNDOS",
            "314 ECORP 14400 SEGUNDOS",
            "323 ECORPS",
            "327 AFINIDAD CTA CONTROLADA 1",
            "331 ECORP VIP 100",
            "334 ECORP VIP 600",
            "335 ECORP VIP 800",
            "336 ECORP VIP 1000",
            "337 ECORP VIP 1500",
            "338 ECORP CC",
            "339 ECORP 15450",
            "340 ECORP CC",
            "35 PCS 60S",
            "36 PCS 1200S",
            "361 ECORP 210",
            "363 ECORP 480",
            "4 PROMEDIO",
            "400 PCS RENT CPP",
            "401 PCS RENT MPP",
            "403 PCS RENT MPP",
            "404 PCS RENT MPP",
            "405 DATOS",
            "405 PLAN PCS RENT CPP",
            "406 M2M EMPRESA",
            "408 TELEMETRIA",
            "410 PLAN SMS RED",
            "412 SMS WEB",
            "413 PLAN DEMO LOCALIZACION",
            "414 LOCALIZACION ENTEL GPS",
            "415 LOCALIZACION ENTEL GPS",
            "416 SMS EMPRESAS",
            "417 M2M EMPRESA",
            "44 RED PCS 80 S",
            "448 CUENTA OPTIMIZADA",
            "449 SUPER P. OPTIMIZACION RED",
            "460 PLAN OPTIMIZACION RPV",
            "461 PLAN CONVERSOR",
            "462 PLAN CONVERSOR",
            "463 RED",
            "465 CUENTA CONTROLADA",
            "466 CUENTA OPTIMIZADA",
            "468 SGO",
            "469 SGO",
            "476 RED",
            "477 RED",
            "478 RED",
            "487 SGO",
            "489 PLAN ADT",
            "490 PCS 100 VOZ S",
            "491 PCS 100 DATO S",
            "492 DEMO SMS EMPRESAS",
            "494 PLAN REDS",
            "495 PLAN CONVERSOR",
            "496 PLAN CONVERSOR",
            "497 RED CONVERSOR",
            "498 PLAN REDS",
            "510 ADT RESPALDO 10KB",
            "511 ADT RESPALDO 100KB",
            "512 ADT RESPALDO 200KB",
            "517 BAM EMPRESA",
            "518 M2M CTA. OPTIMIZADA",
            "519 BAM EMPRESAS PRO",
            "520 BAM EMPRESA",
            "521 PLAN EMPRESAS NORMAL",
            "526 BAM EMPRESAS PRO",
            "529 BAM EMPRESAS PRO 1GB",
            "530 BAM 2GB EMP",
            "534 SGO",
            "534 SGOS",
            "536 SGO",
            "538 SGO",
            "539 PLAN DATOS M2M",
            "548 CPP EMPRESAS",
            "550 CPP EMPRESAS",
            "552 CPP EMPRESAS",
            "560 BAM 200KBPS NACIONAL EMP",
            "570 SGO",
            "571 SGO",
            "573 SGO",
            "574 SGO",
            "575 SGO",
            "576 SGO",
            "577 SGO",
            "578 SGO",
            "579 SGO",
            "586 CPP EMPRESAS S",
            "587 CPP EMPRESAS S",
            "59 PCS 440S",
            "590 CPP EMPRESAS S",
            "591 CPP EMPRESAS S",
            "592 CPP EMPRESAS S",
            "593 CPP EMPRESAS S",
            "594 MI EMPRESA SGO",
            "595 MI EMPRESA SGO",
            "597 MI EMPRESA SGO",
            "598 SGO",
            "601 SGO",
            "603 SGO",
            "606 SGO",
            "607 SGO",
            "613 INTEGRADOR",
            "614 SGO",
            "615 CONVERSOR",
            "616 CUENTA CONTROLADA",
            "617 CUENTA CONTROLADA",
            "618 CUENTA CONTROLADA",
            "619 CUENTA CONTROLADA",
            "620 CUENTA CONTROLADA",
            "621 TARIFA PLANA",
            "622 TARIFA PLANA",
            "623 TARIFA PLANA",
            "624 TARIFA PLANA",
            "625 TARIFA PLANA",
            "626 SGO",
            "63 PLAN GLOBAL 80",
            "631 PLANO PLUS",
            "633 SGO",
            "639 BLACKBERRY PROFESIONAL EMP",
            "64 PLAN GLOBAL 120",
            "640 BLACKBERRY CORPORATIVO",
            "641 BAM EMPRESA",
            "642 BAM EMPRESA",
            "643 TELEMETRIA 1",
            "644 TELEMETRIA 2",
            "645 LOCALIZACION ENTEL GPS",
            "646 LOC ENTEL GPS ILIMITADO",
            "647 LOCALIZACION ENTEL GPS",
            "65 PLAN GLOBAL 210",
            "654 CC 7000 RETENCION",
            "656 LOC ENTEL GPS",
            "657 LOC ENTELGPS ILIMITADO",
            "658 PLAN DATOS M2M RECARGA",
            "659 DATOS M2M INTEGRADORES",
            "663 RIDER",
            "665 SGO",
            "669 CC 9000 RETENCION",
            "67 PLAN GLOBAL 430",
            "670 TARIFA PLANA 400",
            "671 TARIFA PLANA 600",
            "672 TARIFA PLANA 1000",
            "68 PLAN GLOBAL 710",
            "681 CC 11500 RETENCION",
            "682 CUENTA CONTROLADA FLAT",
            "683 CUENTA CONTROLADA FLAT",
            "684 RIDER",
            "685 RIDER",
            "686 RIDER",
            "69 CUENTA CONTROLADA 15530",
            "690 DATOS",
            "691 DEMO OFICINA MOVIL",
            "693 BAM OPTIMO EMPRESA",
            "698 CC 14500 RETENCION",
            "699 CC 17500 RETENCION",
            "700 PLAN WHERIFONE",
            "701 BAM EMPRESA",
            "703 BAM PRO DEALERS",
            "704 BAM PRO DEALERS",
            "705 BAM PRO DEALERS",
            "706 BAM MASCONECTADO 3GB",
            "707 BAM MASCONECTADO 6GB",
            "708 BAM",
            "708 BAM EMPRESAS PRO 3GB",
            "709 BAM",
            "709 BAM EMPRESAS PRO 6GB",
            "710 BAM PLAN ROUTER",
            "710 PLAN RED 440",
            "711 BAM XI,XII,IDP 400KBPS PER",
            "711 PLAN RED 660",
            "712 BAM CONTROLADO 2 GB",
            "712 PLAN RED 1100",
            "713 BAM CONTROLADO 5GB",
            "714 BAM CONTROLADO 7GB",
            "714 PLAN RED 1000",
            "716 BAM CONTROLADO 500 MB",
            "72 PCS GLOBAL S",
            "722 TARIFA UNICA 170",
            "724 TARIFA UNICA 450",
            "725 TARIFA UNICA 700",
            "740 TODO DESTINO 150",
            "741 TODO DESTINO 230",
            "742 TODO DESTINO 300",
            "744 TODO DESTINO 750",
            "745 TODO DESTINO 1000",
            "750 ECORP 90",
            "751 ECORP 110 + 100 SMS",
            "756 ECORP CC 22450",
            "767 BAM CONTROLADO 15GB",
            "768 BAM",
            "768 BAM 22 MBPS",
            "780 CUENTA CONTROLADA 24990",
            "8 PERSONAL PROMOCION",
            "80 PLUS 480S",
            "801 SGO",
            "806 VIP CAMARA 1",
            "807 VIP CAMARA 2",
            "813 CONSOLIDADO",
            "814 SGO",
            "815 SGO",
            "816 SGO",
            "818 SGO",
            "819 CONS0LIDADO",
            "819 SGO",
            "820 SGO",
            "822 SGO",
            "822 VIP RPV CPPS",
            "823 CONSOLIDADO",
            "825 SGO",
            "826 RED CONSOLIDADO",
            "826 SGO",
            "827 CONSOLIDADOS",
            "827 SGO",
            "829 SGO",
            "831 RED CONSOLIDADOS",
            "834 CUENTA OPTIMIZADA NO",
            "834 SGO CTA OPTIMIZADA NO",
            "840 SGO",
            "842 CONSOLIDADO S",
            "843 SGO",
            "844 SGO",
            "845 RED CONSOLIDADOS",
            "846 SGO",
            "847 CONSOLIDADO RED",
            "848 SGO",
            "849 CONSOLIDADO",
            "849 SGO",
            "850 SGO",
            "851 CONSOLIDADO INTRARED",
            "851 SGO",
            "852 CONSOLIDADO INTRARED",
            "852 SGO",
            "853 CONSOLIDADO INTRARED",
            "853 SGO",
            "854 CONSOLIDADO INTRARED",
            "854 SGO",
            "855 CONSOLIDADO INTRARED",
            "855 SGO",
            "856 CONSOLIDADO INTRARED",
            "856 SGO",
            "857 CONSOLIDADO INTRARED",
            "857 SGO",
            "858 CONSOLIDADO",
            "858 SGO",
            "859 CONSOLIDADO",
            "859 SGO",
            "860 SGO",
            "861 CONSOLIDADO",
            "861 SGO",
            "862 SGO",
            "863 SGO",
            "864 SGO",
            "865 SGO",
            "866 CONSOLIDADO INTRARED",
            "866 SGO",
            "867 CONSOLIDADO",
            "867 SGO",
            "868 RED CONSOLIDADO",
            "869 RED CONSOLIDADO",
            "870 SGO",
            "871 SGO",
            "874 SGO",
            "876 PLAN CONSOLIDADO SGO",
            "877 PLAN CONSOLIDADO SGO",
            "878 PLAN CONSOLIDADO SGO",
            "879 PLAN CONSOLIDADO SGO",
            "880 PLAN CONSOLIDADO SGO",
            "881 PLAN CONSOLIDADO SGO",
            "882 SGO",
            "883 SGO",
            "884 SGO",
            "885 SGO",
            "886 SGO",
            "887 SGO",
            "888 SGO",
            "889 SGO",
            "890 SGO",
            "891 SGO",
            "892 SGO",
            "895 SGO",
            "896 SGO",
            "897 SGO",
            "898 SGO",
            "899 SGO",
            "9 PCS 100",
            "900 SGO",
            "CTA. CONTROLADA PLANA $10.500",
            "CTA. CONTROLADA PLANA $12.990",
            "CTA. CONTROLADA PLANA $15.990",
            "CTA. CONTROLADA PLANA $19.500",
            "DEMO SMS EMPRESAS",
            "EMPRESA GES DATOS 1,5GB",
            "EMPRESA GES DATOS 10GB +",
            "EMPRESA GES DATOS 160MBCP",
            "EMPRESA GES DATOS 1GB",
            "EMPRESA GES DATOS 1GB RET",
            "EMPRESA GES DATOS 2GB",
            "EMPRESA GES DATOS 2GBND",
            "EMPRESA GES DATOS 3GB +",
            "EMPRESA GES DATOS 400MB",
            "EMPRESA GES DATOS 4GB +",
            "EMPRESA GES DATOS 600MB",
            "EMPRESA GES DATOS 6GB +",
            "EMPRESA GES DATOS 8GB +",
            "EMPRESA SMARTPHONE 10GB",
            "EMPRESA SMARTPHONE 1GB",
            "EMPRESA SMARTPHONE 2GB",
            "EMPRESA SMARTPHONE 3GB",
            "EMPRESA SMARTPHONE 4GB",
            "EMPRESA SMARTPHONE 6GB",
            "EMPRESA SMARTPHONE 8GB",
            "FA200 FACT DIFEREN 200",
            "FA400 FACT DIFEREN 400",
            "FA800 FACT DIFEREN 800",
            "FB100 FACT DIFEREN 100",
            "FB200 FACT DIFEREN 200",
            "FB250 FACT DIFEREN 250",
            "FB300 FACT DIFEREN 300",
            "FB800 FACT DIFEREN 800",
            "FC100 FACT DIFEREN 100",
            "FE500 FACT DIFEREN 500",
            "GPS LITE AUTOINSTALABLE",
            "GPS LITE INSTALABLE",
            "M2M BAJO TRAFICO",
            "M2M ILIMITADO",
            "M2M TRAFICO MEDIO",
            "ME 1000 SGO",
            "ME 1500 SGO",
            "ME 2000 SGO",
            "ME 3000 SGO",
            "ME 4000 SGO",
            "ME 500 SGO",
            "ME 5000 SGO",
            "ME 600 SGO",
            "ME 6000 SGO",
            "MM PRUEBAS CC 16.990",
            "PLAN ADT 120 SMS",
            "PLAN ADT 37 SMS",
            "PLAN ADT 80 SMS",
            "PLAN CANJE 400",
            "PLAN CC QUADRANTE",
            "PLAN DEMO ROAMING",
            "PLAN DEMOSTRACION",
            "PLAN ENTELGPS AVANZADO",
            "PLAN ENTELGPS BASICO",
            "PLAN MOBILE CAM",
            "PLAN REPETIDOR",
            "PLAN VIAJERO CC",
            "Z_NOUSO_1460 M2M CORP SENS",
            "Z_NOUSO_PORT_EMP GES DAT 4GB +"});
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
            "-",
            "ALC PIXI 3 4,0 BLACK 126156",
            "ALC PIXI 4 4,0 BLACK 126171",
            "ALC PIXI 4 5,0 4G BLACK 126177",
            "ALC U5 BLACK 126186",
            "APL IPHONE 6 32GB SPACE GREY 136205",
            "APL IPHONE 6S 128GB SPACE GRAY 136133",
            "APL IPHONE 6S 16GB GOLD 136129",
            "APL IPHONE 6S 16GB SILVER 136128",
            "APL IPHONE 6S 16GB SPACE GRAY 136127",
            "APL IPHONE 6S 32GB SPACE GREY 136189",
            "APL IPHONE 6S 64GB SILVER 136132",
            "APL IPHONE 6S PLUS 16GB SPACE GRAY 136134",
            "APL IPHONE 6S PLUS 64GB SPACE GRAY 136138",
            "APL IPHONE 7 128GB BLACK 136167",
            "APL IPHONE 7 128GB JET BLACK 136164",
            "APL IPHONE 7 256GB BLACK 136172",
            "APL IPHONE 7 256GB JET BLACK 136169",
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
            "HUA P10 BLACK 133171",
            "HUA P9 LITE 2017 BLACK 133173",
            "HUA VALLEY Y635 BLACK 133126",
            "HUAWEI B68L HSPA+ 133120",
            "HUAWEI E3131 HSPA+ WHT 133112",
            "HUAWEI E3276s BLANCO LTE  133098",
            "HUAWEI E3372 LTE 133132",
            "HUAWEI E5573 MIFI 133133",
            "HUAWEI E5776s NEGRO LTE    133099",
            "HUAWEI E8231 HSPA+WIFI 133131",
            "HUAWEI E8372H LTE 133167",
            "HUAWEI F317 FIJO BLANCO 133123",
            "HUAWEI GR5 BLACK 133143",
            "HUAWEI MATE 9 BLACK 133165",
            "HUAWEI P8 LITE (ALICE) BLACK 133134",
            "HUAWEI P9 BLACK 133150",
            "HUAWEI P9 GOLD 133151",
            "HUAWEI P9 LITE BLACK 133152",
            "HUAWEI P9 LITE SMART GRAY\t133177",
            "HUAWEI P9 LITE WHITE 133153",
            "HUAWEI ROUTER B310LTE EMPRE WHT 133161",
            "HUAWEI ROUTER LTE B310 133130",
            "HUAWEI ROUTER LTE B310 BAFI V2 WHITE 133168",
            "HUAWEI Y6 II BLACK 133163",
            "LG G4 STYLUS BLACK 124203",
            "LG G4 STYLUS WHITE 124204",
            "LG K10 LTE BLACK 124205",
            "LG K4 BROWN 124229",
            "LG MAGNA LTE BLACK 124195",
            "LG PROMO G5 + BATTERY BLACK 124213",
            "LG X CAM BLACK 124211",
            "LG X STYLE BLACK 124225",
            "MOT MOTO Z PLAY LUNAR GREY 104137",
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
            "SAM GALAXY S8 BLACK 106616",
            "SAM GALAXY S8 GOLD 106617",
            "SAM GALAXY S8 PLUS BLACK 106620",
            "SAM GALAXY S8 PLUS GOLD 106621",
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
            // VentHMMPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 556);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataHMMPA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.campoOCO);
            this.Controls.Add(this.labelHMMPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCopiaEquipos);
            this.Controls.Add(this.btnCopiaPlan);
            this.Controls.Add(this.btnCopiaValor);
            this.Controls.Add(this.btnCopiaSIM);
            this.Controls.Add(this.btnCopiaCuentas);
            this.Controls.Add(this.btnCopiaCondicion);
            this.Controls.Add(this.checkOCO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentHMMPA";
            this.Text = "HABILITACIÓN DE LÍNEA PA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHMMPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataHMMPA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.TextBox campoOCO;
        private System.Windows.Forms.Label labelHMMPA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCopiaEquipos;
        private System.Windows.Forms.Button btnCopiaPlan;
        private System.Windows.Forms.Button btnCopiaValor;
        private System.Windows.Forms.Button btnCopiaSIM;
        private System.Windows.Forms.Button btnCopiaCuentas;
        private System.Windows.Forms.Button btnCopiaCondicion;
        private System.Windows.Forms.CheckBox checkOCO;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox campoDatos;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
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