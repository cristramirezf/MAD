using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentHMM : Form
    {
        public VentHMM()
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validacionesTexto())
            {
                //establecimiento de datos de cabecera de MAD
                string cabecera = "";

                if (checkOCO.Checked)
                {
                    cabecera = "RUT: " + campoRUT.Text + "\n" +
                               "OC: " + campoOCO.Text + "\n" + "\n";
                }
                else
                {
                    cabecera = "RUT: " + campoRUT.Text + "\n" + "\n";
                }

                //bool primero = true;

                //obtiene los valores del datagridview
                String datos = "";
                String[,] mat = new String[dataHMM.RowCount, 3];
                List<String> filas1 = new List<string>();
                List<String> cuentas = new List<string>();

                for (int i = 0; i <= dataHMM.RowCount - 1; i++)
                {
                    String filacantidad = "";
                    String filaSIM = "";
                    String filavalor = "";
                    String filaplan = "";
                    String filamodelo = "";
                    String filavaloreq = "";
                    String filacondicion = "";

                    if (dataHMM["Cuenta", i].Value != null)
                    {
                        if (dataHMM["Cantidad", i].Value != null)
                        {
                            filacantidad = "Cantidad: " + dataHMM["Cantidad", i].Value.ToString() + "\n";
                        }
                        if (dataHMM["SIM", i].Value != null)
                        {
                            filaSIM = "SIM: " + dataHMM["SIM", i].Value.ToString() + "\n";
                        }
                        if (dataHMM["Valor", i].Value != null)
                        {
                            filavalor = "Valor SIM: $" + dataHMM["Valor", i].Value.ToString() + "\n";
                        }
                        if (dataHMM["Plan", i].Value != null)
                        {
                            filaplan = "Plan: " + dataHMM["Plan", i].Value.ToString() + "\n";
                        }
                        if (dataHMM["Modelo", i].Value != null)
                        {
                            if (dataHMM["Modelo", i].Value.ToString().Length > 1)
                            {
                                String marcamodelo = dataHMM["Modelo", i].Value.ToString().Remove(dataHMM["Modelo", i].Value.ToString().Length - 7);
                                String codigo = dataHMM["Modelo", i].Value.ToString().Substring(dataHMM["Modelo", i].Value.ToString().Length - 6);
                                filamodelo = "Código: " + codigo + "\n" + "Modelo: " + marcamodelo + "\n";

                                if (dataHMM["ValorEq", i].Value != null)
                                {
                                    filavaloreq = "Valor Equipo: $" + dataHMM["ValorEq", i].Value.ToString() + "\n";
                                }
                                if (dataHMM["Condicion", i].Value != null)
                                {
                                    filacondicion = "Condicion: " + dataHMM["Condicion", i].Value.ToString() + "\n";
                                }
                            }
                        }


                        mat[i, 0] = dataHMM["Cuenta", i].Value.ToString();
                        mat[i, 1] = filacantidad + filaSIM + filavalor + filaplan + filamodelo + filavaloreq + filacondicion;
                        cuentas.Add(dataHMM["Cuenta", i].Value.ToString());
                        filas1.Add(dataHMM["Cuenta", i].Value.ToString());
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
                if (comboEjecutivo.Text.Equals("Francisca Garcia B.")) { datosEjec = "\nAnexo: 36349" + "\nMóvil: 976164611" + "\nEmail: FBGARCIA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Francisco Castillo S.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 998883913" + "\nEmail: FJCASTILLO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Gabriela Guzman C.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 944749268" + "\nEmail: GCGUZMAN@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Javier Beroiza A.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 942163076" + "\nEmail: JABEROIZA@ENTEL.CL"; }
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
                if (comboEjecutivo.Text.Equals("Maria Pinto D.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 0" + "\nEmail: APL_MPINTO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Matias Brito A.")) { datosEjec = "\nAnexo: 38317" + "\nMóvil: 977584518" + "\nEmail: MABRITO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Mirtha Castro C.")) { datosEjec = "\nAnexo: 37336" + "\nMóvil: 988284813" + "\nEmail: MCCASTRO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Paula Sola G.")) { datosEjec = "\nAnexo: 38304" + "\nMóvil: 999174324" + "\nEmail: PSOLA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Philipp Gallardo G.")) { datosEjec = "\nAnexo: 32915" + "\nMóvil: 998359021" + "\nEmail: PGGALLARDO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Sandra Lazcano A.")) { datosEjec = "\nAnexo: 38262" + "\nMóvil: 998289233" + "\nEmail: SLAZCANO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Simon Segura B.")) { datosEjec = "\nAnexo: 33219" + "\nMóvil: 985586068" + "\nEmail: SBSEGURA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Vladimir Cubillos R.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 990704094" + "\nEmail: VCUBILLOS@ENTEL.CL"; }
                //fin datos ejecutivos

                String pie = "Datos de contacto: " + "\n" + campoDatos.Text.Trim() +
                "\n\n" + comboEjecutivo.Text + datosEjec;

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
                        labelHMM.Text = "HMM";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        labelHMM.Text = "HMM2";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        labelHMM.Text = "HMM3";
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

            for (int i = 0; i <= dataHMM.RowCount - 1; i++)
            {
                if (dataHMM["Cantidad", i].Value != null)
                {
                    if (dataHMM["Cuenta", i].Value != null)
                    {
                        cuentas.Add(dataHMM["Cuenta", i].Value.ToString());
                    }
                }
            }

            switch (distinctcuentas.Count())
            {
                case 0:
                    break;
                case 1:
                    labelHMM.Text = "HMM";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelHMM.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelHMM.Text);
                    break;
                case 2:
                    labelHMM.Text = "HMM2";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelHMM.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelHMM.Text);
                    break;
                case 3:
                    labelHMM.Text = "HMM3";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelHMM.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelHMM.Text);
                    break;
                default:
                    MessageBox.Show("Se han ingresado más de 3 cuentas distintas. Por favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void dataHMM_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataHMM.Rows.Count > 10)
            {
                this.dataHMM.AllowUserToAddRows = false;
            }
        }

        private void dataHMM_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataHMM.RowCount < 10)
            {
                this.dataHMM.AllowUserToAddRows = true;
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
            int totalfilas = dataHMM.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHMM["Cuenta", i].Value != null)
                {
                    ult = dataHMM["Cuenta", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHMM.RowCount - 1; i++)
            {
                if (dataHMM["Cantidad", i].Value != null)
                {
                    if (dataHMM["Cuenta", i].Value == null)
                    {
                        dataHMM["Cuenta", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia sim
        private void btnCopiaSIM_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHMM.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHMM["SIM", i].Value != null)
                {
                    ult = dataHMM["SIM", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHMM.RowCount - 1; i++)
            {
                if (dataHMM["Cantidad", i].Value != null)
                {
                    if (dataHMM["SIM", i].Value == null)
                    {
                        dataHMM["SIM", i].Value = ult;
                    }
                }
            }
        }//fin boton copia sim

        //evento boton copia valores
        private void btnCopiaValor_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHMM.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHMM["Valor", i].Value != null)
                {
                    ult = dataHMM["Valor", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHMM.RowCount - 1; i++)
            {
                if (dataHMM["Cantidad", i].Value != null)
                {
                    if (dataHMM["Valor", i].Value == null)
                    {
                        dataHMM["Valor", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        //evento boton copia plan
        private void btnCopiaPlan_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHMM.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHMM["Plan", i].Value != null)
                {
                    ult = dataHMM["Plan", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHMM.RowCount - 1; i++)
            {
                if (dataHMM["Cantidad", i].Value != null)
                {
                    if (dataHMM["Plan", i].Value == null)
                    {
                        dataHMM["Plan", i].Value = ult;
                    }
                }
            }
        }//fin copia condicones plan

        //evento boton copia equipos
        private void btnCopiaEquipos_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHMM.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHMM["Modelo", i].Value != null)
                {
                    ult = dataHMM["Modelo", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHMM.RowCount - 1; i++)
            {
                if (dataHMM["Cantidad", i].Value != null)
                {
                    if (dataHMM["Modelo", i].Value == null)
                    {
                        dataHMM["Modelo", i].Value = ult;
                    }
                }
            }
        }//fin boton copia equipos


        //evento boton copia valores
        private void btnCopiaValorEq_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHMM.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHMM["ValorEq", i].Value != null)
                {
                    ult = dataHMM["ValorEq", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHMM.RowCount - 1; i++)
            {
                if (dataHMM["Cantidad", i].Value != null)
                {
                    if (dataHMM["ValorEq", i].Value == null)
                    {
                        dataHMM["ValorEq", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        //evento boton copia condiciones comerciales
        private void btnCopiaCondicion_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHMM.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHMM["Condicion", i].Value != null)
                {
                    ult = dataHMM["Condicion", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHMM.RowCount - 1; i++)
            {
                if (dataHMM["Cantidad", i].Value != null)
                {
                    if (dataHMM["Condicion", i].Value == null)
                    {
                        dataHMM["Condicion", i].Value = ult;
                    }
                }
            }
        }//fin copia condicones comerciales

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataHMM.Rows.Clear();
            dataHMM.Refresh();
            campoRUT.Clear();
            campoOCO.Clear();
            campoDatos.Clear();
            campoObs.Clear();
            checkOCO.Checked = false;
        }

        private void dataHMM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }

    }
}