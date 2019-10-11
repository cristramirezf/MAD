using System;
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
    public partial class VentNC : Form
    {
        public VentNC()
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

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataDatos.Rows.Clear();
            dataDatos.Refresh();
            campoRUT.Clear();
            campoObs.Clear();
        }
        //fin barra menú

        //se debe aplicar en CellClick y CellEnter
        private void dataDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
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

        //validaciones de 10 entradas en cada DGV
        private void dataDatos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataDatos.Rows.Count > 10)
            {
                this.dataDatos.AllowUserToAddRows = false;
            }
        }

        private void dataDatos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataDatos.RowCount < 10)
            {
                this.dataDatos.AllowUserToAddRows = true;
            }
        }
        //fin validaciones DGV

        //evento boton copia movil
        private void btnCopiaMovil_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataDatos.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataDatos["Movil", i].Value != null)
                {
                    ult = dataDatos["Movil", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataDatos.RowCount - 1; i++)
            {
                if (dataDatos["Factura", i].Value != null)
                {
                    if (dataDatos["Movil", i].Value == null)
                    {
                        dataDatos["Movil", i].Value = ult;
                    }
                }
            }
        }//fin copia movil

        //evento boton copia monto
        private void btnCopiaMonto_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataDatos.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataDatos["Monto", i].Value != null)
                {
                    ult = dataDatos["Monto", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataDatos.RowCount - 1; i++)
            {
                if (dataDatos["Factura", i].Value != null)
                {
                    if (dataDatos["Monto", i].Value == null)
                    {
                        dataDatos["Monto", i].Value = ult;
                    }
                }
            }
        }//fin copia monto

        private void btnCopiaProy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se copió el nombre de proyecto " + lblProy.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetDataObject(lblProy.Text);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validacionesTexto())
            {
                //establecimiento de datos de cabecera de MAD
                String cabecera = "RUT: " + campoRUT.Text + "\n" + "\n";

                //obtiene los valores del datagridview
                String datos = "";

                for (int i = 0; i <= dataDatos.RowCount - 1; i++)
                {
                    if (dataDatos["Factura", i].Value != null)
                    {
                        if (dataDatos["Movil", i].Value != null)
                        {
                            if (dataDatos["Monto", i].Value != null)
                            {
                                datos = datos + 
                                        "Factura: " + dataDatos["Factura", i].Value.ToString() + "\n" +
                                        "Movil: " + dataDatos["Movil", i].Value.ToString() + "\n" +
                                        "Monto (neto): $" + dataDatos["Monto", i].Value.ToString() + "\n\n";
                            }
                        }
                    }
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

    }


}
