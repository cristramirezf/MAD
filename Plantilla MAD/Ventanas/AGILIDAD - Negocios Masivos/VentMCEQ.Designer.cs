namespace Plantilla_MAD.Ventanas
{
    partial class VentMCEQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentMCEQ));
            this.btnPlanilla = new System.Windows.Forms.Button();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomProy = new System.Windows.Forms.Label();
            this.campoNano = new System.Windows.Forms.TextBox();
            this.checkOCO = new System.Windows.Forms.CheckBox();
            this.campoOCO = new System.Windows.Forms.TextBox();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.checkNano = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlanilla
            // 
            this.btnPlanilla.Location = new System.Drawing.Point(348, 87);
            this.btnPlanilla.Name = "btnPlanilla";
            this.btnPlanilla.Size = new System.Drawing.Size(179, 72);
            this.btnPlanilla.TabIndex = 0;
            this.btnPlanilla.Text = "CREAR PLANILLA";
            this.btnPlanilla.UseVisualStyleBackColor = true;
            this.btnPlanilla.Click += new System.EventHandler(this.btnPlanilla_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "CAMBIO DE EQUIPO (MASIVO)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // lblNomProy
            // 
            this.lblNomProy.AutoSize = true;
            this.lblNomProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProy.Location = new System.Drawing.Point(473, 40);
            this.lblNomProy.Name = "lblNomProy";
            this.lblNomProy.Size = new System.Drawing.Size(83, 13);
            this.lblNomProy.TabIndex = 31;
            this.lblNomProy.Text = "CEQ MASIVO";
            // 
            // campoNano
            // 
            this.campoNano.Location = new System.Drawing.Point(133, 151);
            this.campoNano.Name = "campoNano";
            this.campoNano.Size = new System.Drawing.Size(35, 20);
            this.campoNano.TabIndex = 48;
            this.campoNano.Visible = false;
            // 
            // checkOCO
            // 
            this.checkOCO.AutoSize = true;
            this.checkOCO.Location = new System.Drawing.Point(26, 116);
            this.checkOCO.Name = "checkOCO";
            this.checkOCO.Size = new System.Drawing.Size(92, 17);
            this.checkOCO.TabIndex = 33;
            this.checkOCO.Text = "Necesita OC?";
            this.checkOCO.UseVisualStyleBackColor = true;
            this.checkOCO.CheckedChanged += new System.EventHandler(this.checkOCO_CheckedChanged);
            // 
            // campoOCO
            // 
            this.campoOCO.Location = new System.Drawing.Point(119, 114);
            this.campoOCO.Name = "campoOCO";
            this.campoOCO.Size = new System.Drawing.Size(100, 20);
            this.campoOCO.TabIndex = 34;
            this.campoOCO.Visible = false;
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(94, 78);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "RUT Cliente";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(29, 221);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(222, 96);
            this.campoDatos.TabIndex = 37;
            this.campoDatos.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Datos de contacto";
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
            this.comboEjecutivo.Location = new System.Drawing.Point(296, 221);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(493, 219);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 41;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(514, 278);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 42;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // checkNano
            // 
            this.checkNano.AutoSize = true;
            this.checkNano.Location = new System.Drawing.Point(26, 152);
            this.checkNano.Name = "checkNano";
            this.checkNano.Size = new System.Drawing.Size(101, 17);
            this.checkNano.TabIndex = 47;
            this.checkNano.Text = "SIM en blanco?";
            this.checkNano.UseVisualStyleBackColor = true;
            this.checkNano.CheckedChanged += new System.EventHandler(this.checkNano_CheckedChanged);
            // 
            // VentMCEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(658, 349);
            this.Controls.Add(this.campoNano);
            this.Controls.Add(this.checkNano);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.campoOCO);
            this.Controls.Add(this.checkOCO);
            this.Controls.Add(this.lblNomProy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPlanilla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentMCEQ";
            this.Text = "CAMBIO DE EQUIPO MASIVO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlanilla;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomProy;
        private System.Windows.Forms.TextBox campoNano;
        private System.Windows.Forms.CheckBox checkOCO;
        private System.Windows.Forms.TextBox campoOCO;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox campoDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.CheckBox checkNano;
    }
}