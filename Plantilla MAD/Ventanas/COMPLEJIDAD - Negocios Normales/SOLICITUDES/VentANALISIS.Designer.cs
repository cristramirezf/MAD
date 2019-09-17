namespace Plantilla_MAD.Ventanas
{
    partial class VentANALISIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentANALISIS));
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdAnalisis = new System.Windows.Forms.RadioButton();
            this.rdAnalisisNC = new System.Windows.Forms.RadioButton();
            this.rdFraude = new System.Windows.Forms.RadioButton();
            this.campoFacturas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFraude = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.comboEjecutivo.Location = new System.Drawing.Point(648, 219);
            this.comboEjecutivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(193, 24);
            this.comboEjecutivo.TabIndex = 149;
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(48, 165);
            this.campoRUT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(172, 22);
            this.campoRUT.TabIndex = 156;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(292, 146);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(142, 17);
            this.lblObs.TabIndex = 155;
            this.lblObs.Text = "Información Adicional";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(683, 352);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(133, 28);
            this.btnGrabar.TabIndex = 152;
            this.btnGrabar.Text = "Copiar AC";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(656, 319);
            this.btnCopiaProy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(183, 28);
            this.btnCopiaProy.TabIndex = 151;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Visible = false;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(296, 165);
            this.campoObs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(287, 266);
            this.campoObs.TabIndex = 154;
            this.campoObs.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 150;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // lblProy
            // 
            this.lblProy.AutoSize = true;
            this.lblProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProy.Location = new System.Drawing.Point(633, 52);
            this.lblProy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProy.Name = "lblProy";
            this.lblProy.Size = new System.Drawing.Size(76, 17);
            this.lblProy.TabIndex = 148;
            this.lblProy.Text = "ANALISIS";
            this.lblProy.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 147;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            this.label4.Visible = false;
            // 
            // lblRuta
            // 
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(233, 52);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(273, 41);
            this.lblRuta.TabIndex = 146;
            this.lblRuta.Text = "Solicitudes Servicios Móviles - Analisis de cliente";
            this.lblRuta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 17);
            this.label2.TabIndex = 145;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 144;
            this.label1.Text = "ANALISIS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 157;
            this.label6.Text = "RUT Cliente";
            // 
            // rdAnalisis
            // 
            this.rdAnalisis.AutoSize = true;
            this.rdAnalisis.Location = new System.Drawing.Point(48, 101);
            this.rdAnalisis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdAnalisis.Name = "rdAnalisis";
            this.rdAnalisis.Size = new System.Drawing.Size(77, 21);
            this.rdAnalisis.TabIndex = 158;
            this.rdAnalisis.TabStop = true;
            this.rdAnalisis.Text = "Análisis";
            this.rdAnalisis.UseVisualStyleBackColor = true;
            this.rdAnalisis.CheckedChanged += new System.EventHandler(this.rdAnalisis_CheckedChanged);
            // 
            // rdAnalisisNC
            // 
            this.rdAnalisisNC.AutoSize = true;
            this.rdAnalisisNC.Location = new System.Drawing.Point(215, 101);
            this.rdAnalisisNC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdAnalisisNC.Name = "rdAnalisisNC";
            this.rdAnalisisNC.Size = new System.Drawing.Size(112, 21);
            this.rdAnalisisNC.TabIndex = 159;
            this.rdAnalisisNC.TabStop = true;
            this.rdAnalisisNC.Text = "Análisis + NC";
            this.rdAnalisisNC.UseVisualStyleBackColor = true;
            this.rdAnalisisNC.CheckedChanged += new System.EventHandler(this.rdAnalisisNC_CheckedChanged);
            // 
            // rdFraude
            // 
            this.rdFraude.AutoSize = true;
            this.rdFraude.Location = new System.Drawing.Point(401, 101);
            this.rdFraude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdFraude.Name = "rdFraude";
            this.rdFraude.Size = new System.Drawing.Size(74, 21);
            this.rdFraude.TabIndex = 160;
            this.rdFraude.TabStop = true;
            this.rdFraude.Text = "Fraude";
            this.rdFraude.UseVisualStyleBackColor = true;
            this.rdFraude.CheckedChanged += new System.EventHandler(this.rdFraude_CheckedChanged);
            // 
            // campoFacturas
            // 
            this.campoFacturas.Location = new System.Drawing.Point(48, 229);
            this.campoFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoFacturas.Multiline = true;
            this.campoFacturas.Name = "campoFacturas";
            this.campoFacturas.Size = new System.Drawing.Size(172, 202);
            this.campoFacturas.TabIndex = 161;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 162;
            this.label5.Text = "Facturas";
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
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 163;
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
            // lblFraude
            // 
            this.lblFraude.AutoSize = true;
            this.lblFraude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraude.ForeColor = System.Drawing.Color.Red;
            this.lblFraude.Location = new System.Drawing.Point(501, 102);
            this.lblFraude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFraude.Name = "lblFraude";
            this.lblFraude.Size = new System.Drawing.Size(331, 17);
            this.lblFraude.TabIndex = 164;
            this.lblFraude.Text = "No olvide adjuntar informe de fraude al MAD";
            this.lblFraude.Visible = false;
            // 
            // VentANALISIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(893, 474);
            this.Controls.Add(this.lblFraude);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.campoFacturas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdFraude);
            this.Controls.Add(this.rdAnalisisNC);
            this.Controls.Add(this.rdAnalisis);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblProy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VentANALISIS";
            this.Text = "ANALISIS";
            this.Load += new System.EventHandler(this.VentANALISIS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdAnalisis;
        private System.Windows.Forms.RadioButton rdAnalisisNC;
        private System.Windows.Forms.RadioButton rdFraude;
        private System.Windows.Forms.TextBox campoFacturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.Label lblFraude;
    }
}