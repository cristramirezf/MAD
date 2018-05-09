namespace Plantilla_MAD.Ventanas
{
    partial class VentMIGSSPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentMIGSSPP));
            this.dataMIGSSPP = new System.Windows.Forms.DataGridView();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.lblProy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopiaCuentas = new System.Windows.Forms.Button();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMIGSSPP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataMIGSSPP
            // 
            this.dataMIGSSPP.AllowUserToResizeRows = false;
            this.dataMIGSSPP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataMIGSSPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMIGSSPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movil,
            this.Cuenta,
            this.Serie});
            this.dataMIGSSPP.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataMIGSSPP.Location = new System.Drawing.Point(27, 130);
            this.dataMIGSSPP.Name = "dataMIGSSPP";
            this.dataMIGSSPP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataMIGSSPP.Size = new System.Drawing.Size(402, 272);
            this.dataMIGSSPP.TabIndex = 52;
            this.dataMIGSSPP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMIGSSPP_CellClick);
            this.dataMIGSSPP.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMIGSSPP_CellClick);
            this.dataMIGSSPP.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMIGSSPP_RowLeave);
            this.dataMIGSSPP.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataMIGSSPP_RowsRemoved);
            // 
            // Movil
            // 
            this.Movil.HeaderText = "Móvil";
            this.Movil.Name = "Movil";
            this.Movil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Movil.Width = 80;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.Width = 140;
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.Width = 140;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(527, 374);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 51;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(507, 321);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 49;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 48;
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
            this.comboEjecutivo.Location = new System.Drawing.Point(498, 255);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(92, 68);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 43;
            // 
            // lblProy
            // 
            this.lblProy.AutoSize = true;
            this.lblProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProy.Location = new System.Drawing.Point(504, 41);
            this.lblProy.Name = "lblProy";
            this.lblProy.Size = new System.Drawing.Size(72, 13);
            this.lblProy.TabIndex = 40;
            this.lblProy.Text = "MIG SS/PP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - Migración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "MIGRACIÓN A PREPAGO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 73;
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
            // btnCopiaCuentas
            // 
            this.btnCopiaCuentas.Location = new System.Drawing.Point(174, 102);
            this.btnCopiaCuentas.Name = "btnCopiaCuentas";
            this.btnCopiaCuentas.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaCuentas.TabIndex = 74;
            this.btnCopiaCuentas.Text = "Copia Cuenta";
            this.btnCopiaCuentas.UseVisualStyleBackColor = true;
            this.btnCopiaCuentas.Click += new System.EventHandler(this.btnCopiaCuentas_Click);
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(479, 104);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(183, 112);
            this.campoObs.TabIndex = 75;
            this.campoObs.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(476, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "Observaciones";
            // 
            // VentMIGSSPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 431);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnCopiaCuentas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataMIGSSPP);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.lblProy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentMIGSSPP";
            this.Text = "MIGRACIÓN A PREPAGO";
            ((System.ComponentModel.ISupportInitialize)(this.dataMIGSSPP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.Label lblProy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataMIGSSPP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnCopiaCuentas;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
    }
}