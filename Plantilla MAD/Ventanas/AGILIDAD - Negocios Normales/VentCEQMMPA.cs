using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentCEQMMPA : Form
    {
        public VentCEQMMPA()
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

                string col = "";
                string separador = " - ";
                //sección que obtiene los cabeceras de columna
                for (int j = 0; j < dataCEQMMPA.ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        col = col + dataCEQMMPA.Columns[j].HeaderText;
                    }

                    else
                    {
                        col = col + separador + dataCEQMMPA.Columns[j].HeaderText;
                    }
                }//fin obtencion cabeceras

                //establecimiento de datos de cabecera de MAD
                string cabecera = "";

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

                //bool primero = true;

                //obtiene los valores del datagridview
                String datos = "";
                String[,] mat = new String[dataCEQMMPA.RowCount, 3];
                List<String> filas1 = new List<string>();
                List<String> cuentas = new List<string>();

                for (int i = 0; i <= dataCEQMMPA.RowCount - 1; i++)
                {
                    String filacuenta = "";
                    String filacondicion = "";
                    String filamodelo = "";
                    String filavalor = "";

                    if (dataCEQMMPA["Movil", i].Value != null)
                    {
                        if (dataCEQMMPA["Cuenta", i].Value != null)
                        {
                            filacuenta = "Cuenta: " + dataCEQMMPA["Cuenta", i].Value.ToString() + "\n";
                        }
                        if (dataCEQMMPA["Modelo", i].Value != null)
                        {
                            String marcamodelo = dataCEQMMPA["Modelo", i].Value.ToString().Remove(dataCEQMMPA["Modelo", i].Value.ToString().Length - 7);
                            String codigo = dataCEQMMPA["Modelo", i].Value.ToString().Substring(dataCEQMMPA["Modelo", i].Value.ToString().Length - 6);
                            filamodelo = "Código: " + codigo + "\n" + "Modelo: " + marcamodelo + "\n";
                        }
                        if (dataCEQMMPA["Valor", i].Value != null)
                        {
                            filavalor = "Valor: $" + dataCEQMMPA["Valor", i].Value.ToString() + "\n";
                        }
                        if (dataCEQMMPA["Condicion", i].Value != null)
                        {
                            filacondicion = "Condicion: " + dataCEQMMPA["Condicion", i].Value.ToString() + "\n" + "Móviles: \n";
                        }
                        if (dataCEQMMPA["Cuenta", i].Value != null)
                        {
                            mat[i, 2] = dataCEQMMPA["Cuenta", i].Value.ToString();
                            cuentas.Add(dataCEQMMPA["Cuenta", i].Value.ToString());
                        }

                        mat[i, 0] = dataCEQMMPA["Movil", i].Value.ToString();
                        mat[i, 1] = filamodelo + filavalor + filacondicion;
                        filas1.Add(filamodelo + filavalor + filacondicion);
                    }
                }

                IEnumerable<String> distinctfilas1 = filas1.AsQueryable().Distinct();
                IEnumerable<String> distinctcuentas = cuentas.AsQueryable().Distinct();

                foreach (String elemento in distinctcuentas)
                {
                    String temp = "Cuenta: " + elemento + "\n\n";
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

                if (comboEjecutivo.Text.Equals("Andrea Hinojosa G."))
                {
                    datosEjec = "\nAnexo: 34245" + "\nMóvil: 999189283" + "\nEmail: AHINOJOSA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Angelica Silva S."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 984275460" + "\nEmail: ASSILVA2@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Carol Rios G."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 993123561" + "\nEmail: APL_CRIOS@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Carolina Arellano D."))
                {
                    datosEjec = "\nAnexo: 36357" + "\nMóvil: 988292366" + "\nEmail: CARELLANOS@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Carolina Ayal E."))
                {
                    datosEjec = "\nAnexo: 34656" + "\nMóvil: 998250882" + "\nEmail: MAYAL@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Catherine Torres B."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 997652058" + "\nEmail: APL_CBTORRES@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Claudia Sola G."))
                {
                    datosEjec = "\nAnexo: 32529" + "\nMóvil: 998884917" + "\nEmail: CSOLA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Danitza Leyton M."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 966682805" + "\nEmail: DLEYTON.ESE@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Danitza Rendich O."))
                {
                    datosEjec = "\nAnexo: 35591" + "\nMóvil: 990897764" + "\nEmail: DRENDICH@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Elizabeth Pavez S."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 987591003" + "\nEmail: EPAVEZ@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Felipe Figueroa L."))
                {
                    datosEjec = "\nAnexo: 33863" + "\nMóvil: 944600119" + "\nEmail: FAFIGUEROA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Francisca Garcia B."))
                {
                    datosEjec = "\nAnexo: 36349" + "\nMóvil: 976164611" + "\nEmail: FBGARCIA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Francisco Castillo S."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 998883913" + "\nEmail: FJCASTILLO@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Javier Beroiza A."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 942163076" + "\nEmail: JABEROIZA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Javiera Molina G."))
                {
                    datosEjec = "\nAnexo: 36349" + "\nMóvil: 0" + "\nEmail: APL_JMOLINA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Julia Dominguez L."))
                {
                    datosEjec = "\nAnexo: 34666" + "\nMóvil: 944067016" + "\nEmail: JDOMINGUEZ@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Kimberly Moraga G."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 0" + "\nEmail: APL_KMORAGA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Lorena Garcia N."))
                {
                    datosEjec = "\nAnexo: 34507" + "\nMóvil: 979778533" + "\nEmail: LNGARCIA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Lorena Jiménez M."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 0" + "\nEmail: APL_LJIMENEZ@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Loreto Barriga R."))
                {
                    datosEjec = "\nAnexo: 34520" + "\nMóvil: 998884047" + "\nEmail: LBARRIGA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Luz Gaete Ch."))
                {
                    datosEjec = "\nAnexo: 32389" + "\nMóvil: 996193243" + "\nEmail: LGAETE@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("María Loreto Caceres A."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 983641836" + "\nEmail: MCACERES@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Maria Renata Ramirez A."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 981989047" + "\nEmail: MAVRAMIREZ@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Maria Jose Marchant V."))
                {
                    datosEjec = "\nAnexo: 34951" + "\nMóvil: 956393483" + "\nEmail: MVMARCHANT@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Mario Santibañez M."))
                {
                    datosEjec = "\nAnexo: 36487" + "\nMóvil: 993183858" + "\nEmail: MMSANTIBANEZ@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Matias Brito A."))
                {
                    datosEjec = "\nAnexo: 38317" + "\nMóvil: 977584518" + "\nEmail: MABRITO@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Mirtha Castro C."))
                {
                    datosEjec = "\nAnexo: 37336" + "\nMóvil: 988284813" + "\nEmail: MCCASTRO@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Paloma Parra G."))
                {
                    datosEjec = "\nAnexo: 34245" + "\nMóvil: 0" + "\nEmail: APL_PPARRA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Paula Sola G."))
                {
                    datosEjec = "\nAnexo: 38304" + "\nMóvil: 999174324" + "\nEmail: PSOLA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Sandra Lazcano A."))
                {
                    datosEjec = "\nAnexo: 38262" + "\nMóvil: 998289233" + "\nEmail: SLAZCANO@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Simon Segura B."))
                {
                    datosEjec = "\nAnexo: 33219" + "\nMóvil: 985586068" + "\nEmail: SBSEGURA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Vladimir Cubillos R."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 990704094" + "\nEmail: VCUBILLOS@ENTEL.CL";
                }
                //fin datos ejecutivos

                String pie = "";
                if (checkNano.Checked)
                {
                    pie = "Datos de contacto: " + "\n" + campoDatos.Text.Trim() + "\n" +
                          "sim_" + campoNano.Text + "//\n" +
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
                        labelCEQMMPA.Text = "CEQMMPA";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        labelCEQMMPA.Text = "CEQMMPA2";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        labelCEQMMPA.Text = "CEQMMPA3";
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

            for (int i = 0; i <= dataCEQMMPA.RowCount - 1; i++)
            {
                if (dataCEQMMPA["Movil", i].Value != null)
                {
                    if (dataCEQMMPA["Cuenta", i].Value != null)
                    {
                        cuentas.Add(dataCEQMMPA["Cuenta", i].Value.ToString());
                    }
                }
            }

            switch (distinctcuentas.Count())
            {
                case 0:
                    break;
                case 1:
                    labelCEQMMPA.Text = "CEQMMPA";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelCEQMMPA.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelCEQMMPA.Text);
                    break;
                case 2:
                    labelCEQMMPA.Text = "CEQMMPA2";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelCEQMMPA.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelCEQMMPA.Text);
                    break;
                case 3:
                    labelCEQMMPA.Text = "CEQMMPA3";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelCEQMMPA.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelCEQMMPA.Text);
                    break;
                default:
                    MessageBox.Show("Se han ingresado más de 3 cuentas distintas. Por favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void dataCEQMMPA_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataCEQMMPA.Rows.Count > 10)
            {
                this.dataCEQMMPA.AllowUserToAddRows = false;
            }
        }

        private void dataCEQMMPA_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataCEQMMPA.RowCount < 10)
            {
                this.dataCEQMMPA.AllowUserToAddRows = true;
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
                MessageBox.Show("Debe llenar los datos OCO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoOCO.Focus();
                return false;
            }
            if (campoNano.TextLength == 0 && checkNano.Checked)
            {
                MessageBox.Show("Debe indicar cantidad de nanoSIM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoNano.Focus();
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
                MessageBox.Show("Debe llenar los datos ejecutivo SAC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboEjecutivo.Focus();
                return false;
            }
            return true;
        }

        //evento boton copia cuentas hacia abajo
        private void btnCopiaCuentas_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCEQMMPA.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCEQMMPA["Cuenta", i].Value != null)
                {
                    ult = dataCEQMMPA["Cuenta", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCEQMMPA.RowCount - 1; i++)
            {
                if (dataCEQMMPA["Movil", i].Value != null)
                {
                    if (dataCEQMMPA["Cuenta", i].Value == null)
                    {
                        dataCEQMMPA["Cuenta", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia equipos
        private void btnCopiaEquipos_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCEQMMPA.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCEQMMPA["Modelo", i].Value != null)
                {
                    ult = dataCEQMMPA["Modelo", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCEQMMPA.RowCount - 1; i++)
            {
                if (dataCEQMMPA["Movil", i].Value != null)
                {
                    if (dataCEQMMPA["Modelo", i].Value == null)
                    {
                        dataCEQMMPA["Modelo", i].Value = ult;
                    }
                }
            }
        }//fin boton copia equipos

        //evento boton copia valores
        private void btnCopiaValor_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCEQMMPA.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCEQMMPA["Valor", i].Value != null)
                {
                    ult = dataCEQMMPA["Valor", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCEQMMPA.RowCount - 1; i++)
            {
                if (dataCEQMMPA["Movil", i].Value != null)
                {
                    if (dataCEQMMPA["Valor", i].Value == null)
                    {
                        dataCEQMMPA["Valor", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        //evento boton copia condiciones comerciales
        private void btnCopiaCondicion_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCEQMMPA.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCEQMMPA["Condicion", i].Value != null)
                {
                    ult = dataCEQMMPA["Condicion", i].Value.ToString();
                    break;
                }
            }
            // MessageBox.Show(ultimacuenta);
            for (int i = 1; i <= dataCEQMMPA.RowCount - 1; i++)
            {
                if (dataCEQMMPA["Movil", i].Value != null)
                {
                    if (dataCEQMMPA["Condicion", i].Value == null)
                    {
                        dataCEQMMPA["Condicion", i].Value = ult;
                    }
                }
            }
        }//fin copia condicones comerciales

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataCEQMMPA.Rows.Clear();
            dataCEQMMPA.Refresh();
            campoRUT.Clear();
            campoOCO.Clear();
            campoNano.Clear();
            campoDatos.Clear();
            campoObs.Clear();
            checkOCO.Checked = false;
            checkNano.Checked = false;
        }

        private void dataCEQMMPA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }
    }
}
