using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentVE : Form
    {
        public VentVE()
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
        private void checkOCO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOCO.Checked)
            {
                campoOCO.Visible = true;
                campoOCO.Clear();
            }
            else
            {
                campoOCO.Visible = false;
                campoOCO.Clear();
            }
        }

        private void checkNano_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNano.Checked)
            {
                campoNano.Visible = true;
                campoNano.Clear();
            }
            else
            {
                campoNano.Visible = false;
                campoNano.Clear();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validacionesTexto())
            {
                //establecimiento de datos de cabecera de MAD
                String cabecera = "";

                if (checkNano.Checked)
                {
                    if (checkOCO.Checked)
                    {
                        cabecera = "Enviar " + campoNano.Text + " SIM en blanco\n" +
                                   "RUT: " + campoRUT.Text + "\n" +
                                   "OC: " + campoOCO.Text + "\n" + "\n";
                    }
                    else
                    {
                        cabecera = "Enviar " + campoNano.Text + " SIM en blanco\n" +
                                   "RUT: " + campoRUT.Text + "\n" + "\n";
                    }
                }
                else
                {
                    if (checkOCO.Checked)
                    {
                        cabecera = "RUT: " + campoRUT.Text + "\n" +
                                   "OC: " + campoOCO.Text + "\n" + "\n";
                    }
                    else
                    {
                        cabecera = "RUT: " + campoRUT.Text + "\n" + "\n";
                    }
                }
                //fin datos cabecera

                //obtiene los valores del datagridview
                String datos = "";
                String[,] mat = new String[dataVE.RowCount, 3];
                List<String> filas1 = new List<string>();
                List<String> cuentas = new List<string>();


                for (int i = 0; i <= dataVE.RowCount - 1; i++)
                {
                    String filacantidad = "";
                    String filamodelo = "";
                    String filavalor = "";

                    if (dataVE["Cuenta", i].Value != null)
                    {
                        if (dataVE["Cantidad", i].Value != null)
                        {
                            filacantidad = "Cantidad: " + dataVE["Cantidad", i].Value.ToString() + "\n";
                        }
                        if (dataVE["Modelo", i].Value != null)
                        {
                            String marcamodelo = dataVE["Modelo", i].Value.ToString().Remove(dataVE["Modelo", i].Value.ToString().Length - 7);
                            String codigo = dataVE["Modelo", i].Value.ToString().Substring(dataVE["Modelo", i].Value.ToString().Length - 6);
                            filamodelo = "Código: " + codigo + "\n" + "Modelo: " + marcamodelo + "\n";
                        }
                        if (dataVE["Valor", i].Value != null)
                        {
                            filavalor = "Valor: $" + dataVE["Valor", i].Value.ToString() + "\n";
                        }
                        if (dataVE["Cuenta", i].Value != null)
                        {
                            mat[i, 2] = dataVE["Cuenta", i].Value.ToString();
                            cuentas.Add(dataVE["Cuenta", i].Value.ToString());
                        }

                        mat[i, 0] = dataVE["Cuenta", i].Value.ToString();
                        mat[i, 1] = filacantidad + filamodelo + filavalor;

                        filas1.Add(dataVE["Cuenta", i].Value.ToString());
                    }
                }

                IEnumerable<String> distinctcuentas = cuentas.AsQueryable().Distinct();
                IEnumerable<String> distinctfilas1 = filas1.AsQueryable().Distinct();
                foreach (String elemento in distinctfilas1)
                {
                    String acum = "";
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        if (mat[i, 1] != null)
                        {
                            if (mat[i, 0].Equals(elemento))
                            {
                                acum = acum + mat[i, 1] + "\n";
                            }
                        }

                    }
                    datos = datos + "Cuenta: " + elemento + "\n" + acum;
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

                //String pie = "Datos de contacto: " + "\n" + campoDatos.Text.Trim() +
                //"\n\n" + comboEjecutivo.Text + datosEjec;

                String pie = "";
                if (checkNano.Checked)
                {
                    pie = "Datos de contacto: " + "\n" + campoDatos.Text.Trim() + "\n" +
                          "SIM_" + campoNano.Text + "//\n" +
                          "\n" + comboEjecutivo.Text + datosEjec;
                }
                else
                {
                    pie = "Datos de contacto: " + "\n" + campoDatos.Text.Trim() +
                          "\n\n" + comboEjecutivo.Text + datosEjec;
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

                switch (distinctcuentas.Count())
                {
                    case 0:
                        break;
                    case 1:
                        labelVE.Text = "VE";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        labelVE.Text = "VE2";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        labelVE.Text = "VE3";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("Se han ingresado más de 3 cuentas distintas. Por favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btnCopiaProy_Click(object sender, EventArgs e)
        {
            List<String> cuentas = new List<string>();
            IEnumerable<String> distinctcuentas = cuentas.AsQueryable().Distinct();

            for (int i = 0; i <= dataVE.RowCount - 1; i++)
            {
                if (dataVE["Cantidad", i].Value != null)
                {
                    if (dataVE["Cuenta", i].Value != null)
                    {
                        cuentas.Add(dataVE["Cuenta", i].Value.ToString());
                    }
                }
            }

            switch (distinctcuentas.Count())
            {
                case 0:
                    break;
                case 1:
                    labelVE.Text = "VE";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelVE.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelVE.Text);
                    break;
                case 2:
                    labelVE.Text = "VE2";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelVE.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelVE.Text);
                    break;
                case 3:
                    labelVE.Text = "VE3";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelVE.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelVE.Text);
                    break;
                default:
                    MessageBox.Show("Se han ingresado más de 3 cuentas distintas. Por favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void dataVE_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataVE.Rows.Count > 10)
            {
                this.dataVE.AllowUserToAddRows = false;
            }
        }

        private void dataVE_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataVE.RowCount < 10)
            {
                this.dataVE.AllowUserToAddRows = true;
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
            if (campoOCO.TextLength == 0 && checkOCO.Checked)
            {
                MessageBox.Show("Debe llenar los datos de OC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoOCO.Focus();
                return false;
            }
            if (campoDatos.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los datos de despacho", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoDatos.Focus();
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
            int totalfilas = dataVE.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataVE["Cuenta", i].Value != null)
                {
                    ult = dataVE["Cuenta", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataVE.RowCount - 1; i++)
            {
                if (dataVE["Cantidad", i].Value != null)
                {
                    if (dataVE["Cuenta", i].Value == null)
                    {
                        dataVE["Cuenta", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia modelo
        private void btnCopiaModelo_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataVE.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataVE["Modelo", i].Value != null)
                {
                    ult = dataVE["Modelo", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataVE.RowCount - 1; i++)
            {
                if (dataVE["Cantidad", i].Value != null)
                {
                    if (dataVE["Modelo", i].Value == null)
                    {
                        dataVE["Modelo", i].Value = ult;
                    }
                }
            }
        }//fin boton copia modelo

        //evento boton copia valores
        private void btnCopiaValor_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataVE.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataVE["Valor", i].Value != null)
                {
                    ult = dataVE["Valor", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataVE.RowCount - 1; i++)
            {
                if (dataVE["Cantidad", i].Value != null)
                {
                    if (dataVE["Valor", i].Value == null)
                    {
                        dataVE["Valor", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataVE.Rows.Clear();
            dataVE.Refresh();
            campoRUT.Clear();
            campoOCO.Clear();
            campoDatos.Clear();
            campoObs.Clear();
            checkOCO.Checked = false;
        }

        private void dataVE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }
    }
}
