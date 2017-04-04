namespace Plantilla_MAD.Ventanas
{
    partial class VentCEQ
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentCEQ));
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.campoOCO = new System.Windows.Forms.TextBox();
            this.checkOCO = new System.Windows.Forms.CheckBox();
            this.lblProy2 = new System.Windows.Forms.Label();
            this.lblProy1 = new System.Windows.Forms.Label();
            this.lblRuta2 = new System.Windows.Forms.Label();
            this.lblRuta1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblObs = new System.Windows.Forms.Label();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.lblEjecutivo = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCEQ = new System.Windows.Forms.TabPage();
            this.btnCopiaCondicionCEQ = new System.Windows.Forms.Button();
            this.dataCEQ = new System.Windows.Forms.DataGridView();
            this.btnCopiaValorCEQ = new System.Windows.Forms.Button();
            this.btnCopiaCuentasCEQ = new System.Windows.Forms.Button();
            this.btnCopiaEquiposCEQ = new System.Windows.Forms.Button();
            this.tabCS = new System.Windows.Forms.TabPage();
            this.btnCopiaSIMCS = new System.Windows.Forms.Button();
            this.btnCopiaValorCS = new System.Windows.Forms.Button();
            this.btnCopiaCuentasCS = new System.Windows.Forms.Button();
            this.dataCS = new System.Windows.Forms.DataGridView();
            this.MovilCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIMCS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValorCS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.campoNano = new System.Windows.Forms.TextBox();
            this.checkNano = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MovilCEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaCEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloCEQ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValorCEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionCEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCEQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCEQ)).BeginInit();
            this.tabCS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCS)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(90, 68);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 26;
            // 
            // campoOCO
            // 
            this.campoOCO.Location = new System.Drawing.Point(339, 68);
            this.campoOCO.Name = "campoOCO";
            this.campoOCO.Size = new System.Drawing.Size(100, 20);
            this.campoOCO.TabIndex = 25;
            this.campoOCO.Visible = false;
            // 
            // checkOCO
            // 
            this.checkOCO.AutoSize = true;
            this.checkOCO.Location = new System.Drawing.Point(233, 68);
            this.checkOCO.Name = "checkOCO";
            this.checkOCO.Size = new System.Drawing.Size(92, 17);
            this.checkOCO.TabIndex = 24;
            this.checkOCO.Text = "Necesita OC?";
            this.checkOCO.UseVisualStyleBackColor = true;
            this.checkOCO.CheckedChanged += new System.EventHandler(this.checkOCO_CheckedChanged);
            // 
            // lblProy2
            // 
            this.lblProy2.AutoSize = true;
            this.lblProy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProy2.Location = new System.Drawing.Point(534, 42);
            this.lblProy2.Name = "lblProy2";
            this.lblProy2.Size = new System.Drawing.Size(32, 13);
            this.lblProy2.TabIndex = 22;
            this.lblProy2.Text = "CEQ";
            // 
            // lblProy1
            // 
            this.lblProy1.AutoSize = true;
            this.lblProy1.Location = new System.Drawing.Point(534, 29);
            this.lblProy1.Name = "lblProy1";
            this.lblProy1.Size = new System.Drawing.Size(166, 13);
            this.lblProy1.TabIndex = 21;
            this.lblProy1.Text = "Y el nombre de proyecto debe ser";
            // 
            // lblRuta2
            // 
            this.lblRuta2.AutoSize = true;
            this.lblRuta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta2.Location = new System.Drawing.Point(223, 42);
            this.lblRuta2.Name = "lblRuta2";
            this.lblRuta2.Size = new System.Drawing.Size(247, 13);
            this.lblRuta2.TabIndex = 20;
            this.lblRuta2.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            // 
            // lblRuta1
            // 
            this.lblRuta1.AutoSize = true;
            this.lblRuta1.Location = new System.Drawing.Point(223, 29);
            this.lblRuta1.Name = "lblRuta1";
            this.lblRuta1.Size = new System.Drawing.Size(221, 13);
            this.lblRuta1.TabIndex = 19;
            this.lblRuta1.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(36, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 13);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "CAMBIO DE EQUIPO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 36;
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
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(301, 441);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(78, 13);
            this.lblObs.TabIndex = 51;
            this.lblObs.Text = "Observaciones";
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(301, 457);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(189, 114);
            this.campoObs.TabIndex = 50;
            this.campoObs.Text = "";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(591, 548);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 49;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(572, 500);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 48;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // lblEjecutivo
            // 
            this.lblEjecutivo.AutoSize = true;
            this.lblEjecutivo.Location = new System.Drawing.Point(565, 441);
            this.lblEjecutivo.Name = "lblEjecutivo";
            this.lblEjecutivo.Size = new System.Drawing.Size(75, 13);
            this.lblEjecutivo.TabIndex = 47;
            this.lblEjecutivo.Text = "Ejecutivo SAC";
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
            this.comboEjecutivo.Location = new System.Drawing.Point(565, 457);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 46;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(41, 441);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(95, 13);
            this.lblDatos.TabIndex = 45;
            this.lblDatos.Text = "Datos de contacto";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(41, 457);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(189, 114);
            this.campoDatos.TabIndex = 44;
            this.campoDatos.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCEQ);
            this.tabControl1.Controls.Add(this.tabCS);
            this.tabControl1.Location = new System.Drawing.Point(22, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 305);
            this.tabControl1.TabIndex = 52;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabCEQ
            // 
            this.tabCEQ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCEQ.Controls.Add(this.btnCopiaCondicionCEQ);
            this.tabCEQ.Controls.Add(this.dataCEQ);
            this.tabCEQ.Controls.Add(this.btnCopiaValorCEQ);
            this.tabCEQ.Controls.Add(this.btnCopiaCuentasCEQ);
            this.tabCEQ.Controls.Add(this.btnCopiaEquiposCEQ);
            this.tabCEQ.Location = new System.Drawing.Point(4, 22);
            this.tabCEQ.Name = "tabCEQ";
            this.tabCEQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabCEQ.Size = new System.Drawing.Size(700, 279);
            this.tabCEQ.TabIndex = 1;
            this.tabCEQ.Text = "Cambio de Equipo";
            // 
            // btnCopiaCondicionCEQ
            // 
            this.btnCopiaCondicionCEQ.Location = new System.Drawing.Point(569, 6);
            this.btnCopiaCondicionCEQ.Name = "btnCopiaCondicionCEQ";
            this.btnCopiaCondicionCEQ.Size = new System.Drawing.Size(110, 23);
            this.btnCopiaCondicionCEQ.TabIndex = 57;
            this.btnCopiaCondicionCEQ.Text = "Copia Condiciones";
            this.btnCopiaCondicionCEQ.UseVisualStyleBackColor = true;
            this.btnCopiaCondicionCEQ.Click += new System.EventHandler(this.btnCopiaCondicionCEQ_Click);
            // 
            // dataCEQ
            // 
            this.dataCEQ.AllowUserToResizeRows = false;
            this.dataCEQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCEQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCEQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovilCEQ,
            this.CuentaCEQ,
            this.ModeloCEQ,
            this.ValorCEQ,
            this.CondicionCEQ});
            this.dataCEQ.Location = new System.Drawing.Point(0, 34);
            this.dataCEQ.Name = "dataCEQ";
            this.dataCEQ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataCEQ.Size = new System.Drawing.Size(698, 272);
            this.dataCEQ.TabIndex = 53;
            this.dataCEQ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCEQ_CellClick);
            this.dataCEQ.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCEQ_CellClick);
            this.dataCEQ.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCEQ_RowLeave);
            this.dataCEQ.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataCEQ_RowsRemoved);
            // 
            // btnCopiaValorCEQ
            // 
            this.btnCopiaValorCEQ.Location = new System.Drawing.Point(464, 6);
            this.btnCopiaValorCEQ.Name = "btnCopiaValorCEQ";
            this.btnCopiaValorCEQ.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaValorCEQ.TabIndex = 56;
            this.btnCopiaValorCEQ.Text = "Copia Valor";
            this.btnCopiaValorCEQ.UseVisualStyleBackColor = true;
            this.btnCopiaValorCEQ.Click += new System.EventHandler(this.btnCopiaValorCEQ_Click);
            // 
            // btnCopiaCuentasCEQ
            // 
            this.btnCopiaCuentasCEQ.Location = new System.Drawing.Point(132, 6);
            this.btnCopiaCuentasCEQ.Name = "btnCopiaCuentasCEQ";
            this.btnCopiaCuentasCEQ.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaCuentasCEQ.TabIndex = 54;
            this.btnCopiaCuentasCEQ.Text = "Copia Cuenta";
            this.btnCopiaCuentasCEQ.UseVisualStyleBackColor = true;
            this.btnCopiaCuentasCEQ.Click += new System.EventHandler(this.btnCopiaCuentasCEQ_Click);
            // 
            // btnCopiaEquiposCEQ
            // 
            this.btnCopiaEquiposCEQ.Location = new System.Drawing.Point(306, 6);
            this.btnCopiaEquiposCEQ.Name = "btnCopiaEquiposCEQ";
            this.btnCopiaEquiposCEQ.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaEquiposCEQ.TabIndex = 55;
            this.btnCopiaEquiposCEQ.Text = "Copia Equipo";
            this.btnCopiaEquiposCEQ.UseVisualStyleBackColor = true;
            this.btnCopiaEquiposCEQ.Click += new System.EventHandler(this.btnCopiaEquiposCEQ_Click);
            // 
            // tabCS
            // 
            this.tabCS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCS.Controls.Add(this.btnCopiaSIMCS);
            this.tabCS.Controls.Add(this.btnCopiaValorCS);
            this.tabCS.Controls.Add(this.btnCopiaCuentasCS);
            this.tabCS.Controls.Add(this.dataCS);
            this.tabCS.Location = new System.Drawing.Point(4, 22);
            this.tabCS.Name = "tabCS";
            this.tabCS.Padding = new System.Windows.Forms.Padding(3);
            this.tabCS.Size = new System.Drawing.Size(700, 279);
            this.tabCS.TabIndex = 2;
            this.tabCS.Text = "Cambio de Simcard";
            // 
            // btnCopiaSIMCS
            // 
            this.btnCopiaSIMCS.Location = new System.Drawing.Point(370, 6);
            this.btnCopiaSIMCS.Name = "btnCopiaSIMCS";
            this.btnCopiaSIMCS.Size = new System.Drawing.Size(110, 23);
            this.btnCopiaSIMCS.TabIndex = 43;
            this.btnCopiaSIMCS.Text = "Copia SIM";
            this.btnCopiaSIMCS.UseVisualStyleBackColor = true;
            this.btnCopiaSIMCS.Click += new System.EventHandler(this.btnCopiaSIMCS_Click);
            // 
            // btnCopiaValorCS
            // 
            this.btnCopiaValorCS.Location = new System.Drawing.Point(526, 6);
            this.btnCopiaValorCS.Name = "btnCopiaValorCS";
            this.btnCopiaValorCS.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaValorCS.TabIndex = 42;
            this.btnCopiaValorCS.Text = "Copia Valor";
            this.btnCopiaValorCS.UseVisualStyleBackColor = true;
            this.btnCopiaValorCS.Click += new System.EventHandler(this.btnCopiaValorCS_Click);
            // 
            // btnCopiaCuentasCS
            // 
            this.btnCopiaCuentasCS.Location = new System.Drawing.Point(185, 6);
            this.btnCopiaCuentasCS.Name = "btnCopiaCuentasCS";
            this.btnCopiaCuentasCS.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaCuentasCS.TabIndex = 41;
            this.btnCopiaCuentasCS.Text = "Copia Cuenta";
            this.btnCopiaCuentasCS.UseVisualStyleBackColor = true;
            this.btnCopiaCuentasCS.Click += new System.EventHandler(this.btnCopiaCuentasCS_Click);
            // 
            // dataCS
            // 
            this.dataCS.AllowUserToResizeRows = false;
            this.dataCS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovilCS,
            this.CuentaCS,
            this.SIMCS,
            this.ValorCS});
            this.dataCS.Location = new System.Drawing.Point(0, 34);
            this.dataCS.Name = "dataCS";
            this.dataCS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataCS.Size = new System.Drawing.Size(622, 272);
            this.dataCS.TabIndex = 40;
            this.dataCS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCS_CellClick);
            this.dataCS.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCS_CellClick);
            this.dataCS.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCS_RowLeave);
            this.dataCS.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataCS_RowsRemoved);
            // 
            // MovilCS
            // 
            this.MovilCS.HeaderText = "Móvil";
            this.MovilCS.Name = "MovilCS";
            this.MovilCS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CuentaCS
            // 
            this.CuentaCS.HeaderText = "Cuenta";
            this.CuentaCS.Name = "CuentaCS";
            this.CuentaCS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaCS.Width = 180;
            // 
            // SIMCS
            // 
            this.SIMCS.AutoComplete = false;
            this.SIMCS.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SIMCS.HeaderText = "Código SIM";
            this.SIMCS.Items.AddRange(new object[] {
            "",
            "349 SIMCARD M2M",
            "365 SIMCARD SS 4G",
            "366 SIMCARD SS NANO 4G"});
            this.SIMCS.Name = "SIMCS";
            this.SIMCS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SIMCS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SIMCS.Width = 200;
            // 
            // ValorCS
            // 
            this.ValorCS.AutoComplete = false;
            this.ValorCS.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ValorCS.HeaderText = "Valor Neto";
            this.ValorCS.Items.AddRange(new object[] {
            "",
            "0",
            "832",
            "2101"});
            this.ValorCS.Name = "ValorCS";
            this.ValorCS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorCS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // campoNano
            // 
            this.campoNano.Location = new System.Drawing.Point(653, 66);
            this.campoNano.Name = "campoNano";
            this.campoNano.Size = new System.Drawing.Size(35, 20);
            this.campoNano.TabIndex = 54;
            this.campoNano.Visible = false;
            // 
            // checkNano
            // 
            this.checkNano.AutoSize = true;
            this.checkNano.Location = new System.Drawing.Point(546, 67);
            this.checkNano.Name = "checkNano";
            this.checkNano.Size = new System.Drawing.Size(101, 17);
            this.checkNano.TabIndex = 53;
            this.checkNano.Text = "SIM en blanco?";
            this.checkNano.UseVisualStyleBackColor = true;
            this.checkNano.CheckedChanged += new System.EventHandler(this.checkNano_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MovilCEQ
            // 
            this.MovilCEQ.HeaderText = "Móvil";
            this.MovilCEQ.Name = "MovilCEQ";
            this.MovilCEQ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MovilCEQ.Width = 70;
            // 
            // CuentaCEQ
            // 
            this.CuentaCEQ.HeaderText = "Cuenta";
            this.CuentaCEQ.Name = "CuentaCEQ";
            this.CuentaCEQ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaCEQ.Width = 126;
            // 
            // ModeloCEQ
            // 
            this.ModeloCEQ.AutoComplete = false;
            this.ModeloCEQ.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ModeloCEQ.HeaderText = "Modelo";
            this.ModeloCEQ.Items.AddRange(new object[] {
            "",
            "ALC 1052 BLACK 126160",
            "ALC PIXI 3 4,0 BLACK 126156",
            "ALC PIXI 4 4,0 BLACK 126171",
            "ALC PIXI 4 5,0 4G BLACK 126177",
            "APL IPHONE 6 32GB SPACE GREY 136205",
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
            "HUA P10 BLACK 133171",
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
            this.ModeloCEQ.Name = "ModeloCEQ";
            this.ModeloCEQ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ModeloCEQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ModeloCEQ.Width = 230;
            // 
            // ValorCEQ
            // 
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.ValorCEQ.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorCEQ.HeaderText = "Valor Neto";
            this.ValorCEQ.Name = "ValorCEQ";
            this.ValorCEQ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorCEQ.Width = 80;
            // 
            // CondicionCEQ
            // 
            this.CondicionCEQ.HeaderText = "Condición Comercial";
            this.CondicionCEQ.Name = "CondicionCEQ";
            this.CondicionCEQ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CondicionCEQ.Width = 150;
            // 
            // VentCEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(755, 592);
            this.Controls.Add(this.campoNano);
            this.Controls.Add(this.checkNano);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.lblEjecutivo);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.campoOCO);
            this.Controls.Add(this.checkOCO);
            this.Controls.Add(this.lblProy2);
            this.Controls.Add(this.lblProy1);
            this.Controls.Add(this.lblRuta2);
            this.Controls.Add(this.lblRuta1);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentCEQ";
            this.Text = "CAMBIO DE EQUIPO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCEQ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCEQ)).EndInit();
            this.tabCS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.TextBox campoOCO;
        private System.Windows.Forms.CheckBox checkOCO;
        private System.Windows.Forms.Label lblProy2;
        private System.Windows.Forms.Label lblProy1;
        private System.Windows.Forms.Label lblRuta2;
        private System.Windows.Forms.Label lblRuta1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label lblEjecutivo;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.RichTextBox campoDatos;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCEQ;
        private System.Windows.Forms.TabPage tabCS;
        private System.Windows.Forms.Button btnCopiaCondicionCEQ;
        private System.Windows.Forms.DataGridView dataCEQ;
        private System.Windows.Forms.Button btnCopiaValorCEQ;
        private System.Windows.Forms.Button btnCopiaCuentasCEQ;
        private System.Windows.Forms.Button btnCopiaEquiposCEQ;
        private System.Windows.Forms.Button btnCopiaSIMCS;
        private System.Windows.Forms.Button btnCopiaValorCS;
        private System.Windows.Forms.Button btnCopiaCuentasCS;
        private System.Windows.Forms.DataGridView dataCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovilCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaCS;
        private System.Windows.Forms.DataGridViewComboBoxColumn SIMCS;
        private System.Windows.Forms.DataGridViewComboBoxColumn ValorCS;
        private System.Windows.Forms.TextBox campoNano;
        private System.Windows.Forms.CheckBox checkNano;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovilCEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaCEQ;
        private System.Windows.Forms.DataGridViewComboBoxColumn ModeloCEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionCEQ;
    }
}