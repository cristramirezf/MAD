﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentMIGPPSS : Form
    {
        public VentMIGPPSS()
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
                String[,] mat = new String[dataMIGPPSS.RowCount, 3];
                List<String> filas1 = new List<string>();
                List<String> cuentas = new List<string>();

                for (int i = 0; i <= dataMIGPPSS.RowCount - 1; i++)
                {
                    String filacuenta = "";
                    String filaplan = "";

                    if (dataMIGPPSS["Movil", i].Value != null)
                    {
                        if (dataMIGPPSS["Cuenta", i].Value != null)
                        {
                            filacuenta = "Cuenta: " + dataMIGPPSS["Cuenta", i].Value.ToString() + "\n";
                        }
                        if (dataMIGPPSS["Plan", i].Value != null)
                        {
                            filaplan = "Plan: " + dataMIGPPSS["Plan", i].Value.ToString() + "\n" + "Móviles: \n";
                        }

                        mat[i, 0] = dataMIGPPSS["Movil", i].Value.ToString();
                        mat[i, 1] = filaplan;
                        mat[i, 2] = dataMIGPPSS["Cuenta", i].Value.ToString();
                        filas1.Add(filaplan);
                        cuentas.Add(dataMIGPPSS["Cuenta", i].Value.ToString());

                    }
                }

                IEnumerable<String> distinctfilas1 = filas1.AsQueryable().Distinct();
                IEnumerable<String> distinctcuentas = cuentas.AsQueryable().Distinct();

                foreach (String elemento in distinctcuentas)
                {
                    String temp = "Cuenta: " + elemento + "\n";
                    foreach (String elemento1 in distinctfilas1)
                    {
                        String acum = "";
                        for (int i = 0; i < mat.GetLength(0); i++)
                        {
                            if ((mat[i, 1] != null) && (mat[i, 1].Equals(elemento1)) && (mat[i, 2].Equals(elemento)))
                            {
                                acum = acum + mat[i, 0] + "\n";
                            }
                        }
                        if (!"".Equals(acum))
                        {
                            temp = temp + elemento1 + acum + "\n";
                        }
                    }
                    datos = datos + temp;
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
if (comboEjecutivo.Text.Equals("Oscar Magallanes R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 993235193" + "\nEmail:OMAGALLANES@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Philipp Gallardo G.")) {datosEjec = "\nAnexo: 32915" + "\nMóvil: 998359021" + "\nEmail: PGGALLARDO@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Romina Saez G.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 956813727" + "\nEmail: RSAEZ@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Sandra Bustos A.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 993264132" + "\nEmail: SBUSTOSR@ENTEL.CL"; }
if (comboEjecutivo.Text.Equals("Sandra Lazcano A.")) {datosEjec = "\nAnexo: 38262" + "\nMóvil: 998289233" + "\nEmail: SLAZCANO@ENTEL.CL"; }
if (comboEjecutivo.Text.Equals("Simon Segura B.")) {datosEjec = "\nAnexo: 33219" + "\nMóvil: 985586068" + "\nEmail: SBSEGURA@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Vladimir Cubillos R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 990704094" + "\nEmail: VCUBILLOS@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Ximena Valdes V.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 999687998" + "\nEmail: XVALDES@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Yerko Campos R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 955229513" + "\nEmail: YCAMPOSR@ENTEL.CL";}
                
                //fin datos ejecutivos

                String pie = "";

                if (campoServicios.Text.Equals(""))
                {
                    pie = comboEjecutivo.Text + datosEjec;

                }
                else
                {
                    pie = "Servicios a activar/bloquear: " + "\n" + campoServicios.Text + "\n\n" + comboEjecutivo.Text + datosEjec;

                }

                //une los textos 
                String texto = cabecera + datos + pie;
                Clipboard.SetDataObject(texto.Trim());
                MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCopiaProy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(labelMIGPPSS.Text);
            MessageBox.Show("Se copió el nombre de proyecto " + labelMIGPPSS.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataMIGPPSS_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataMIGPPSS.Rows.Count > 10)
            {
                this.dataMIGPPSS.AllowUserToAddRows = false;
            }
        }

        private void dataMIGPPSS_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataMIGPPSS.RowCount < 10)
            {
                this.dataMIGPPSS.AllowUserToAddRows = true;
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
            if (campoServicios.Text.Equals(""))
            {
                MessageBox.Show("No se activarán servicios adicionales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGrabar.Focus();
                return true;
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
            int totalfilas = dataMIGPPSS.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataMIGPPSS["Cuenta", i].Value != null)
                {
                    ult = dataMIGPPSS["Cuenta", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataMIGPPSS.RowCount - 1; i++)
            {
                if (dataMIGPPSS["Movil", i].Value != null)
                {
                    if (dataMIGPPSS["Cuenta", i].Value == null)
                    {
                        dataMIGPPSS["Cuenta", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia plan
        private void btnCopiaPlan_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataMIGPPSS.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataMIGPPSS["Plan", i].Value != null)
                {
                    ult = dataMIGPPSS["Plan", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataMIGPPSS.RowCount - 1; i++)
            {
                if (dataMIGPPSS["Movil", i].Value != null)
                {
                    if (dataMIGPPSS["Plan", i].Value == null)
                    {
                        dataMIGPPSS["Plan", i].Value = ult;
                    }
                }
            }
        }//fin boton copia plan

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataMIGPPSS.Rows.Clear();
            dataMIGPPSS.Refresh();
            campoRUT.Clear();
            campoServicios.Clear();
        }

        private void dataMIGPPSS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }

    }
}