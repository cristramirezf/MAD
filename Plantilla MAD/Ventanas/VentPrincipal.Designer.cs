namespace Plantilla_MAD.Ventanas
{
    partial class VentPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentPrincipal));
            this.comboMundo = new System.Windows.Forms.ComboBox();
            this.comboProyecto = new System.Windows.Forms.ComboBox();
            this.checkMasivo = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesea = new System.Windows.Forms.Label();
            this.pictureEntel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEntel)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMundo
            // 
            this.comboMundo.BackColor = System.Drawing.SystemColors.Menu;
            this.comboMundo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMundo.FormattingEnabled = true;
            this.comboMundo.Items.AddRange(new object[] {
            "Agilidad",
            "Complejidad"});
            this.comboMundo.Location = new System.Drawing.Point(167, 242);
            this.comboMundo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboMundo.Name = "comboMundo";
            this.comboMundo.Size = new System.Drawing.Size(148, 24);
            this.comboMundo.TabIndex = 0;
            this.comboMundo.SelectedIndexChanged += new System.EventHandler(this.comboMundo_SelectedIndexChanged);
            // 
            // comboProyecto
            // 
            this.comboProyecto.BackColor = System.Drawing.SystemColors.Menu;
            this.comboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProyecto.FormattingEnabled = true;
            this.comboProyecto.Location = new System.Drawing.Point(80, 326);
            this.comboProyecto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboProyecto.Name = "comboProyecto";
            this.comboProyecto.Size = new System.Drawing.Size(327, 24);
            this.comboProyecto.TabIndex = 1;
            this.comboProyecto.Visible = false;
            this.comboProyecto.SelectedIndexChanged += new System.EventHandler(this.comboProyecto_SelectedIndexChanged);
            // 
            // checkMasivo
            // 
            this.checkMasivo.AutoSize = true;
            this.checkMasivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkMasivo.BackgroundImage")));
            this.checkMasivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkMasivo.Location = new System.Drawing.Point(209, 391);
            this.checkMasivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkMasivo.Name = "checkMasivo";
            this.checkMasivo.Size = new System.Drawing.Size(77, 22);
            this.checkMasivo.TabIndex = 5;
            this.checkMasivo.Text = "Masivo";
            this.checkMasivo.UseVisualStyleBackColor = true;
            this.checkMasivo.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(193, 457);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Siguiente";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccionar línea de negocio";
            // 
            // lblDesea
            // 
            this.lblDesea.AutoSize = true;
            this.lblDesea.Location = new System.Drawing.Point(175, 306);
            this.lblDesea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesea.Name = "lblDesea";
            this.lblDesea.Size = new System.Drawing.Size(134, 17);
            this.lblDesea.TabIndex = 8;
            this.lblDesea.Text = "¿Qué desea hacer?";
            this.lblDesea.Visible = false;
            // 
            // pictureEntel
            // 
            this.pictureEntel.Image = ((System.Drawing.Image)(resources.GetObject("pictureEntel.Image")));
            this.pictureEntel.Location = new System.Drawing.Point(141, 15);
            this.pictureEntel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureEntel.Name = "pictureEntel";
            this.pictureEntel.Size = new System.Drawing.Size(203, 193);
            this.pictureEntel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEntel.TabIndex = 9;
            this.pictureEntel.TabStop = false;
            this.pictureEntel.Click += new System.EventHandler(this.pictureEntel_Click);
            // 
            // VentPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 527);
            this.Controls.Add(this.pictureEntel);
            this.Controls.Add(this.lblDesea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.checkMasivo);
            this.Controls.Add(this.comboProyecto);
            this.Controls.Add(this.comboMundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VentPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AC App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEntel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMundo;
        private System.Windows.Forms.ComboBox comboProyecto;
        private System.Windows.Forms.CheckBox checkMasivo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesea;
        private System.Windows.Forms.PictureBox pictureEntel;
    }
}