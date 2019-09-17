﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentMIGSSPP : Form
    {
        public VentMIGSSPP()
        {
            InitializeComponent();
        }

        //declaraciones de barra de menú
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentLogo Logo = new VentLogo();
            Logo.Show();
        }
        //fin barra menú

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validacionesTexto())
            {
                //establecimiento de datos de cabecera de MAD
                String cabecera = "RUT: " + campoRUT.Text + "\n" + "\n";

                //fin datos cabecera

                //obtiene los valores del datagridview
                String datos = "";
                String[,] mat = new String[dataMIGSSPP.RowCount, 2];
                List<String> filas1 = new List<string>();

                for (int i = 0; i <= dataMIGSSPP.RowCount - 1; i++)
                {
                    String filacuenta = "";

                    if (dataMIGSSPP["Movil", i].Value != null)
                    {
                        if (dataMIGSSPP["Cuenta", i].Value != null)
                        {
                            filacuenta = "Cuenta: " + dataMIGSSPP["Cuenta", i].Value.ToString() + "\n" + "Móvil - Rut Usuario - Serie: \n";
                        }
                        if (dataMIGSSPP["Serie", i].Value != null)
                        {
                            if (dataMIGSSPP["RUT", i].Value != null)
                            { 
                                mat[i, 0] = dataMIGSSPP["Movil", i].Value.ToString() + " - " + dataMIGSSPP["RUT", i].Value.ToString() + " - " + dataMIGSSPP["Serie", i].Value.ToString();
                            }
                            else
                            {
                                mat[i, 0] = dataMIGSSPP["Movil", i].Value.ToString() + " - SIN RUT - " + dataMIGSSPP["Serie", i].Value.ToString();
                            }
                        }
                        else
                        {
                            if (dataMIGSSPP["RUT", i].Value != null)
                            {
                                mat[i, 0] = dataMIGSSPP["Movil", i].Value.ToString() + " - " + dataMIGSSPP["RUT", i].Value.ToString() + " - 0";
                            }
                            else
                            {
                                mat[i, 0] = dataMIGSSPP["Movil", i].Value.ToString() + " - SIN RUT - 0";
                            }
                        }
                        mat[i, 1] = filacuenta;

                        filas1.Add(filacuenta);
                    }
                }

                IEnumerable<String> distinctfilas1 = filas1.AsQueryable().Distinct();
                foreach (String elemento in distinctfilas1)
                {
                    String acum = "";
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        if (mat[i, 1] != null)
                        {
                            if (mat[i, 1].Equals(elemento))
                            {
                                acum = acum + mat[i, 0] + "\n";
                            }
                        }

                    }
                    datos = datos + elemento + acum + "\n";
                }

                //fin obtiene valores dgv

                //a continuación declaro los datos de los ejecutivos
                String datosEjec = "";

if (comboEjecutivo.Text.Equals("Andres Arias O.")) {datosEjec = "\nAnexo: 36487" + "\nMóvil: 0" + "\nEmail: AOARIAS@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Carolina Arellano D.")) {datosEjec = "\nAnexo: 36357" + "\nMóvil: 988292366" + "\nEmail: CARELLANOS@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Claudia Sola G.")) {datosEjec = "\nAnexo: 32529" + "\nMóvil: 998884917" + "\nEmail: CSOLA@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Danitza Leyton M.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 966682805" + "\nEmail: DLEYTON.ESE@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Danitza Rendich O.")) {datosEjec = "\nAnexo: 35591" + "\nMóvil: 990897764" + "\nEmail: DRENDICH@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Elizabeth Pavez S.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 987591003" + "\nEmail: EPAVEZ@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Felipe Figueroa L.")) {datosEjec = "\nAnexo: 33863" + "\nMóvil: 944600119" + "\nEmail: FAFIGUEROA@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Gabriela Guzman C.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 944749268" + "\nEmail: GCGUZMAN@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Karin Sothers B.")) {datosEjec = "\nAnexo: 33102" + "\nMóvil: 996192669" + "\nEmail: KSOTHERS@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Kimberly Moraga G.")) {datosEjec = "\nAnexo: 31764" + "\nMóvil: 0" + "\nEmail: KMORAGA@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Lorena Garcia N.")) {datosEjec = "\nAnexo: 34507" + "\nMóvil: 979778533" + "\nEmail: LNGARCIA@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Lorena Jimenez M.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 940198086" + "\nEmail: LMJIMENEZ@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Loreto Barriga R.")) {datosEjec = "\nAnexo: 34520" + "\nMóvil: 998884047" + "\nEmail: LBARRIGA@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Luz Gaete Ch.")) {datosEjec = "\nAnexo: 32389" + "\nMóvil: 996193243" + "\nEmail: LGAETE@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Maria Jose Marchant V.")) {datosEjec = "\nAnexo: 34951" + "\nMóvil: 956393483" + "\nEmail: MVMARCHANT@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Maria Loreto Caceres A.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 983641836" + "\nEmail: MCACERES@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Maria Renata Ramirez A.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 981989047" + "\nEmail: MAVRAMIREZ@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Oscar Illanes R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 997483484" + "\nEmail:OILLANES@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Oscar Magallanes R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 993235193" + "\nEmail: OMAGALLANES@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Philipp Gallardo G.")) {datosEjec = "\nAnexo: 32915" + "\nMóvil: 998359021" + "\nEmail: PGGALLARDO@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Romina Saez G.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 956813727" + "\nEmail: RSAEZ@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Sandra Bustos R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 993264132" + "\nEmail: SBUSTOSR@ENTEL.CL"; }
if (comboEjecutivo.Text.Equals("Sandra Lazcano A.")) {datosEjec = "\nAnexo: 38262" + "\nMóvil: 998289233" + "\nEmail: SLAZCANO@ENTEL.CL"; }
if (comboEjecutivo.Text.Equals("Simon Segura B.")) {datosEjec = "\nAnexo: 33219" + "\nMóvil: 985586068" + "\nEmail: SBSEGURA@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Vladimir Cubillos R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 990704094" + "\nEmail: VCUBILLOS@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Ximena Valdes V.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 999687998" + "\nEmail: XVALDES@ENTEL.CL";}
                
                //fin datos ejecutivos

                String pie = comboEjecutivo.Text + datosEjec;

                //une los textos 

                String texto = "";

                if (campoObs.Text.Equals(""))
                {
                    texto = cabecera + datos + pie;
                }
                else
                {
                    texto = "Obs: " + campoObs.Text.Trim() + "\n\n" + cabecera + datos + pie;
                }

                Clipboard.SetDataObject(texto.Trim());
                MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCopiaProy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(lblProy.Text);
            MessageBox.Show("Se copió el nombre de proyecto " + lblProy.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataMIGSSPP_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataMIGSSPP.Rows.Count > 10)
            {
                this.dataMIGSSPP.AllowUserToAddRows = false;
            }
        }

        private void dataMIGSSPP_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataMIGSSPP.RowCount < 10)
            {
                this.dataMIGSSPP.AllowUserToAddRows = true;
            }
        }

        private bool validacionesTexto()
        {
            if (campoRUT.TextLength == 0)
            {
                MessageBox.Show("Debe llenar los datos de RUT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoRUT.Focus();
                return false;
            }
            if (comboEjecutivo.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los datos de ejecutivo SAC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboEjecutivo.Focus();
                return false;
            }
            return true;
        }

        //evento boton copia cuentas hacia abajo
        private void btnCopiaCuentas_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataMIGSSPP.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataMIGSSPP["Cuenta", i].Value != null)
                {
                    ult = dataMIGSSPP["Cuenta", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataMIGSSPP.RowCount - 1; i++)
            {
                if (dataMIGSSPP["Movil", i].Value != null)
                {
                    if (dataMIGSSPP["Cuenta", i].Value == null)
                    {
                        dataMIGSSPP["Cuenta", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia ruts hacia abajo
        private void btnCopiaRut_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataMIGSSPP.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataMIGSSPP["RUT", i].Value != null)
                {
                    ult = dataMIGSSPP["RUT", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataMIGSSPP.RowCount - 1; i++)
            {
                if (dataMIGSSPP["Movil", i].Value != null)
                {
                    if (dataMIGSSPP["RUT", i].Value == null)
                    {
                        dataMIGSSPP["RUT", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataMIGSSPP.Rows.Clear();
            dataMIGSSPP.Refresh();
            campoRUT.Clear();
            campoObs.Clear();
        }

        private void dataMIGSSPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }
    }
}