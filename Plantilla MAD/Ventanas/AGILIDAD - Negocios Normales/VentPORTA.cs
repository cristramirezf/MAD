using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentPORTA : Form
    {
        public VentPORTA()
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

        //copia nombre de proyecto
        private void btnCopiaProy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(labelPorta.Text);
            MessageBox.Show("Se copió el nombre de proyecto " + labelPorta.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//fin copia nombre proyecto

        //control de máximo 10 líneas en datagridview
        private void dataPorta_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataPorta.Rows.Count > 10)
            {
                this.dataPorta.AllowUserToAddRows = false;
            }
        }

        private void dataPorta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataPorta.RowCount < 10)
            {
                this.dataPorta.AllowUserToAddRows = true;
            }
        }//fin control 10 líneas datagridview


        private bool validacionesTexto()
        {
            if (campoRUT.TextLength == 0)
            {
                MessageBox.Show("Debe llenar los datos de RUT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoRUT.Focus();
                return false;
            }
            if (campoCuenta.TextLength == 0)
            {
                MessageBox.Show("Debe llenar los datos de cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoCuenta.Focus();
                return false;
            }
            if (campoDonante.TextLength == 0)
            {
                MessageBox.Show("Debe llenar los datos de empresa donante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoDonante.Focus();
                return false;
            }
            if (campoMMF.TextLength == 0)
            {
                MessageBox.Show("Debe llenar los datos de MMF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoMMF.Focus();
                return false;
            }
            if (comboPlan.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los datos de plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboPlan.Focus();
                return false;
            }
            if (campoDatos.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los datos de despacho", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoDatos.Focus();
                return false;
            }
            if (campoServicios.Text.Equals(""))
            {
                MessageBox.Show("No se activarán servicios adicionales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboPlan.Focus();
                return true;
            }
            if (comboEjecutivo.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los datos ejecutivo SAC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboEjecutivo.Focus();
                return false;
            }
            return true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validacionesTexto())
            {
                string col = "";
                string separador = " - ";
                //sección que obtiene los cabeceras de columna
                for (int j = 0; j < dataPorta.ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        col = col + dataPorta.Columns[j].HeaderText;
                    }

                    else
                    {
                        col = col + separador + dataPorta.Columns[j].HeaderText;
                    }
                }//fin obtencion cabeceras

                String cabecera = "RUT: " + campoRUT.Text + "\n\n" + "Cuenta: " + campoCuenta.Text + "\n" +
                       "Donante: " + campoDonante.Text + "\n" + "MMF: $" + campoMMF.Text + "\n" + "Fecha portación: " +
                       campoFecha.Value.ToString("dd-MM") + "\n" + "Plan: " + comboPlan.Text + "\n\n" + col + "\n";

                // bool primero = true;

                String datos = "";
                for (int i = 0; i < dataPorta.RowCount - 1; i++)
                {
                    List<String> lista = new List<String>();
                    String filamovil = "";
                    String filamodelo = "";
                    String filavalor = "";


                    if (dataPorta["Movil", i].Value != null)
                    {
                        if (dataPorta["Modelo", i].Value != null)
                        {
                            if (dataPorta["Valor", i].Value != null)
                            {
                                filamovil = dataPorta["Movil", i].Value.ToString();
                                filamodelo = dataPorta["Modelo", i].Value.ToString();
                                filavalor = "$" + dataPorta["Valor", i].Value.ToString();
                            }
                        }
                    }

                    lista.Add(filamovil + separador + filamodelo + separador + filavalor + "\n\n");

                    for (int j = 0; j < lista.Count; j++)
                    {
                        datos = datos + lista[j];
                    }
                }

                //fin obtención valores

                //a continuación declaro los datos de los ejecutivos
                String datosEjec = "";

                if (comboEjecutivo.Text.Equals("Andrea Hinojosa G.")) { datosEjec = "\nAnexo: 34245" + "\nMóvil: 999189283" + "\nEmail: AHINOJOSA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Andres Arias O.")) { datosEjec = "\nAnexo: 36487" + "\nMóvil: 0" + "\nEmail: AOARIAS@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Angelica Silva S.")) { datosEjec = "\nAnexo: 32789" + "\nMóvil: 984275460" + "\nEmail: APSSILVA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Carol Rios G.")) { datosEjec = "\nAnexo: 34951" + "\nMóvil: 993123561" + "\nEmail: CERIOS@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Carolina Arellano D.")) { datosEjec = "\nAnexo: 36357" + "\nMóvil: 988292366" + "\nEmail: CARELLANOS@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Claudia Sola G.")) { datosEjec = "\nAnexo: 32529" + "\nMóvil: 998884917" + "\nEmail: CSOLA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Danitza Leyton M.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 966682805" + "\nEmail: DLEYTON.ESE@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Danitza Rendich O.")) { datosEjec = "\nAnexo: 35591" + "\nMóvil: 990897764" + "\nEmail: DRENDICH@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Elizabeth Pavez S.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 987591003" + "\nEmail: EPAVEZ@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Felipe Figueroa L.")) { datosEjec = "\nAnexo: 33863" + "\nMóvil: 944600119" + "\nEmail: FAFIGUEROA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Gabriela Guzman C.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 944749268" + "\nEmail: GCGUZMAN@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Julia Dominguez L.")) { datosEjec = "\nAnexo: 34666" + "\nMóvil: 944067016" + "\nEmail: JDOMINGUEZ@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Karin Sothers B.")) { datosEjec = "\nAnexo: 33102" + "\nMóvil: 996192669" + "\nEmail: KSOTHERS@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Kimberly Moraga G.")) { datosEjec = "\nAnexo: 31764" + "\nMóvil: 0" + "\nEmail: KMORAGA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Lorena Garcia N.")) { datosEjec = "\nAnexo: 34507" + "\nMóvil: 979778533" + "\nEmail: LNGARCIA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Lorena Jimenez M.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 940198086" + "\nEmail: LMJIMENEZ@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Loreto Barriga R.")) { datosEjec = "\nAnexo: 34520" + "\nMóvil: 998884047" + "\nEmail: LBARRIGA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Luz Gaete Ch.")) { datosEjec = "\nAnexo: 32389" + "\nMóvil: 996193243" + "\nEmail: LGAETE@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Maria Jose Marchant V.")) { datosEjec = "\nAnexo: 34951" + "\nMóvil: 956393483" + "\nEmail: MVMARCHANT@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Maria Loreto Caceres A.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 983641836" + "\nEmail: MCACERES@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Maria Renata Ramirez A.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 981989047" + "\nEmail: MAVRAMIREZ@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Mirtha Castro C.")) { datosEjec = "\nAnexo: 37336" + "\nMóvil: 988284813" + "\nEmail: MCCASTRO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Oscar Illanes R.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 997483484" + "\nEmail: OILLANES@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Paula Sola G.")) { datosEjec = "\nAnexo: 38304" + "\nMóvil: 999174324" + "\nEmail: PSOLA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Philipp Gallardo G.")) { datosEjec = "\nAnexo: 32915" + "\nMóvil: 998359021" + "\nEmail: PGGALLARDO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Romina Saez G.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 956813727" + "\nEmail: RSAEZ@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Sandra Lazcano A.")) { datosEjec = "\nAnexo: 38262" + "\nMóvil: 998289233" + "\nEmail: SLAZCANO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Simon Segura B.")) { datosEjec = "\nAnexo: 33219" + "\nMóvil: 985586068" + "\nEmail: SBSEGURA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Vladimir Cubillos R.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 990704094" + "\nEmail: VCUBILLOS@ENTEL.CL"; }
                
                //fin datos ejecutivos

                String pie = "";
                if (!campoServicios.Text.Equals(""))
                {
                    pie = "Servicios a activar: " + "\n" + campoServicios.Text.Trim() +
                          "\n\n" + "Datos de contacto: " + "\n" + campoDatos.Text.Trim() + "\n\n" +
                          comboEjecutivo.Text + datosEjec;
                }
                else
                {
                    pie = "Datos de contacto: " + "\n" + campoDatos.Text.Trim() + "\n\n" +
                          comboEjecutivo.Text + datosEjec;
                }

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

        private void btnCopiaModelo_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataPorta.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataPorta["Modelo", i].Value != null)
                {
                    ult = dataPorta["Modelo", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataPorta.RowCount - 1; i++)
            {
                if (dataPorta["Movil", i].Value != null)
                {
                    if (dataPorta["Modelo", i].Value == null)
                    {
                        dataPorta["Modelo", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas


        private void btnCopiaValor_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataPorta.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataPorta["Valor", i].Value != null)
                {
                    ult = dataPorta["Valor", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataPorta.RowCount - 1; i++)
            {
                if (dataPorta["Movil", i].Value != null)
                {
                    if (dataPorta["Valor", i].Value == null)
                    {
                        dataPorta["Valor", i].Value = ult;
                    }
                }
            }
        }

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataPorta.Rows.Clear();
            dataPorta.Refresh();
            campoRUT.Clear();
            campoCuenta.Clear();
            campoDonante.Clear();
            campoMMF.Clear();
            campoDatos.Clear();
            campoServicios.Clear();
            campoObs.Clear();
            comboPlan.SelectedIndex = -1;

        }

        private void dataPorta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }
    }
}
