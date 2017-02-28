using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentHL : Form
    {
        public VentHL()
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
                String[,] mat = new String[30, 4];
                List<String> filas1 = new List<string>();
                List<String> cuentas = new List<string>();
                List<String> tipo = new List<string>();

                for (int i = 0; i <= dataHL.RowCount - 1; i++)
                {
                    String filacantidad = "";
                    String filaSIM = "";
                    String filavalor = "";
                    String filaplan = "";
                    String filamodelo = "";
                    String filavaloreq = "";
                    String filacondicion = "";

                    //obtencion datos dgv HL
                    if (dataHL["Cuenta", i].Value != null)
                    {
                        if (dataHL["Cantidad", i].Value != null)
                        {
                            filacantidad = "Cantidad: " + dataHL["Cantidad", i].Value.ToString() + "\n";
                        }
                        if (dataHL["SIM", i].Value != null)
                        {
                            filaSIM = "SIM: " + dataHL["SIM", i].Value.ToString() + "\n";
                        }
                        if (dataHL["Valor", i].Value != null)
                        {
                            filavalor = "Valor SIM: $" + dataHL["Valor", i].Value.ToString() + "\n";
                        }
                        if (dataHL["Plan", i].Value != null)
                        {
                            filaplan = "Plan: " + dataHL["Plan", i].Value.ToString() + "\n";
                        }
                        if (dataHL["Modelo", i].Value != null)
                        {
                            String marcamodelo = dataHL["Modelo", i].Value.ToString().Remove(dataHL["Modelo", i].Value.ToString().Length - 7);
                            String codigo = dataHL["Modelo", i].Value.ToString().Substring(dataHL["Modelo", i].Value.ToString().Length - 6);
                            filamodelo = "Código: " + codigo + "\n" + "Modelo: " + marcamodelo + "\n";

                            if (dataHL["ValorEq", i].Value != null)
                            {
                                filavaloreq = "Valor Equipo: $" + dataHL["ValorEq", i].Value.ToString() + "\n";
                            }
                            if (dataHL["Condicion", i].Value != null)
                            {
                                filacondicion = "Condicion: " + dataHL["Condicion", i].Value.ToString() + "\n";
                            }
                        }

                        mat[i, 0] = "Habilitación de Línea";

                        mat[i, 1] = dataHL["Cuenta", i].Value.ToString();

                        // mat[i, 2] = dataHL["Movil", i].Value.ToString();

                        mat[i, 3] = filacantidad + filaSIM + filavalor + filaplan + filamodelo + filavaloreq + filacondicion;
                        cuentas.Add(dataHL["Cuenta", i].Value.ToString());
                        filas1.Add(filacantidad + filaSIM + filavalor + filaplan + filamodelo + filavaloreq + filacondicion);
                        tipo.Add("Habilitación de Línea");
                    }
                }
                //fin obtencion datos dgv hl

                //obtiene los valores del datagridview
                for (int i = 0; i <= dataCEQ.RowCount - 1; i++)
                {
                    String filacuenta = "";
                    String filacondicion = "";
                    String filamodelo = "";
                    String filavalor = "";

                    if (dataCEQ["MovilCEQ", i].Value != null)
                    {
                        if (dataCEQ["CuentaCEQ", i].Value != null)
                        {
                            filacuenta = "Cuenta: " + dataCEQ["CuentaCEQ", i].Value.ToString() + "\n";
                        }
                        if (dataCEQ["ModeloCEQ", i].Value != null)
                        {
                            String marcamodelo = dataCEQ["ModeloCEQ", i].Value.ToString().Remove(dataCEQ["ModeloCEQ", i].Value.ToString().Length - 7);
                            String codigo = dataCEQ["ModeloCEQ", i].Value.ToString().Substring(dataCEQ["ModeloCEQ", i].Value.ToString().Length - 6);
                            filamodelo = "Código: " + codigo + "\n" + "Modelo: " + marcamodelo + "\n";
                        }
                        if (dataCEQ["ValorCEQ", i].Value != null)
                        {
                            filavalor = "Valor Eq.: $" + dataCEQ["ValorCEQ", i].Value.ToString() + "\n";
                        }
                        if (dataCEQ["CondicionCEQ", i].Value != null)
                        {
                            filacondicion = "Condicion: " + dataCEQ["CondicionCEQ", i].Value.ToString() + "\n" + "Móviles: \n";
                        }
                        if (dataCEQ["CuentaCEQ", i].Value != null)
                        {
                            mat[10 + i, 2] = dataCEQ["MovilCEQ", i].Value.ToString();

                            cuentas.Add(dataCEQ["CuentaCEQ", i].Value.ToString());
                        }
                        mat[10 + i, 0] = "Cambio de Equipo";

                        mat[10 + i, 1] = dataCEQ["CuentaCEQ", i].Value.ToString();

                        mat[10 + i, 3] = filamodelo + filavalor + filacondicion;
                        filas1.Add(filamodelo + filavalor + filacondicion);
                        tipo.Add("Cambio de Equipo");

                    }
                }

                //obtiene los valores del datagridview
                for (int i = 0; i <= dataCS.RowCount - 1; i++)
                {
                    String filacuenta = "";
                    String filasim = "";
                    String filavalor = "";

                    if (dataCS["MovilCS", i].Value != null)
                    {
                        if (dataCS["CuentaCS", i].Value != null)
                        {
                            filacuenta = "Cuenta: " + dataCS["CuentaCS", i].Value.ToString() + "\n";
                        }
                        if (dataCS["SIMCS", i].Value != null)
                        {
                            filasim = "SIM: " + dataCS["SIMCS", i].Value.ToString() + "\n";
                        }
                        if (dataCS["ValorCS", i].Value != null)
                        {
                            filavalor = "Valor: $" + dataCS["ValorCS", i].Value.ToString() + "\n" + "Móviles: \n";
                        }
                        if (dataCS["CuentaCS", i].Value != null)
                        {
                            mat[20 + i, 1] = dataCS["CuentaCS", i].Value.ToString();

                            cuentas.Add(dataCS["CuentaCS", i].Value.ToString());
                        }
                        mat[20 + i, 0] = "Cambio de Simcard";

                        mat[20 + i, 1] = dataCS["CuentaCS", i].Value.ToString();

                        mat[20 + i, 2] = dataCS["MovilCS", i].Value.ToString();

                        mat[20 + i, 3] = filasim + filavalor;
                        filas1.Add(filasim + filavalor);
                        tipo.Add("Cambio de Simcard");

                    }
                }

                IEnumerable<String> distinctfilas1 = filas1.AsQueryable().Distinct();
                IEnumerable<String> distinctcuentas = cuentas.AsQueryable().Distinct();
                IEnumerable<String> distincttipo = tipo.AsQueryable().Distinct();

                foreach (String cta in distinctcuentas)
                {
                    String temp = "Cuenta: " + cta + "\n";
                    String tempHL = "";
                    String tempCEQ = "";
                    String tempCS = "";
                    String acumulaHL = "";
                    String acumulaCEQ = "";
                    String acumulaCS = "";

                    for (int i = 0; i <= dataHL.RowCount - 1; i++)
                    {
                        if ((dataHL["Cuenta", i].Value != null) && (dataHL["Cuenta", i].Value.ToString().Equals(cta)))
                        {
                            tempHL = "COMO HABILITACION DE LINEA" + "\n\n";
                        }
                    }

                    for (int i = 0; i <= dataCEQ.RowCount - 1; i++)
                    {
                        if ((dataCEQ["CuentaCEQ", i].Value != null) && (dataCEQ["CuentaCEQ", i].Value.ToString().Equals(cta)))
                        {
                            tempCEQ = "COMO CAMBIO DE EQUIPO" + "\n\n";
                        }
                    }

                    for (int i = 0; i <= dataCS.RowCount - 1; i++)
                    {
                        if ((dataCS["CuentaCS", i].Value != null) && (dataCS["CuentaCS", i].Value.ToString().Equals(cta)))
                        {
                            tempCS = "COMO CAMBIO DE SIMCARD" + "\n\n";
                        }
                    }

                    foreach (String fila in distinctfilas1)
                    {
                        String acum = "";
                        for (int i = 0; i < mat.GetLength(0); i++)
                        {
                            if ((mat[i, 3] != null) && (mat[i, 3].Equals(fila)) && (mat[i, 1].Equals(cta)) && (mat[i, 1] != null))
                            {
                                acum = acum + mat[i, 2] + "\n";
                            }
                        }
                        if (!fila.Equals(""))
                        {
                            if (!"".Equals(acum))
                            {
                                if (fila.Contains(" SIMCARD "))
                                {
                                    acumulaCS = acumulaCS + fila + acum + "\n";
                                }
                                else if (fila.Contains("Valor Eq.:"))
                                {
                                    acumulaCEQ = acumulaCEQ + fila + acum + "\n";
                                }
                                else
                                {
                                    acumulaHL = acumulaHL + fila + "\n";
                                }
                            }
                        }
                    }
                    if (!"".Equals(acumulaHL))
                    {
                        tempHL = tempHL + acumulaHL;
                    }
                    if (!"".Equals(acumulaCEQ))
                    {
                        tempCEQ = tempCEQ + acumulaCEQ;
                    }
                    if (!"".Equals(acumulaCS))
                    {
                        tempCS = tempCS + acumulaCS;
                    }
                    temp = temp + tempHL + tempCEQ + tempCS;
                    datos = datos + temp;
                }
                //fin obtiene valores dgv

                //0 = tipo mad
                //1 = Cuenta
                //2 = movil
                //3 = resto

                //a continuación declaro los datos de los ejecutivos
                String datosEjec = "";

                if (comboEjecutivo.Text.Equals("Andrea Hinojosa G."))
                {
                    datosEjec = "\nAnexo: 34245" + "\nMóvil: 999189283" + "\nEmail: AHINOJOSA@ENTEL.CL";
                }
                if (comboEjecutivo.Text.Equals("Angelica Silva S."))
                {
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 984275460" + "\nEmail: APSSILVA@ENTEL.CL";
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
                    datosEjec = "\nAnexo: 0" + "\nMóvil: 981470397" + "\nEmail: LMJIMENEZ@ENTEL.CL";
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
                        lblProy2.Text = "HL";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        lblProy2.Text = "HL2";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        lblProy2.Text = "HL3";
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

            for (int i = 0; i <= dataHL.RowCount - 1; i++)
            {
                if (dataHL["Cantidad", i].Value != null)
                {
                    if (dataHL["Cuenta", i].Value != null)
                    {
                        cuentas.Add(dataHL["Cuenta", i].Value.ToString());
                    }
                }
            }

            for (int i = 0; i <= dataCEQ.RowCount - 1; i++)
            {
                if (dataCEQ["MovilCEQ", i].Value != null)
                {
                    if (dataCEQ["CuentaCEQ", i].Value != null)
                    {
                        cuentas.Add(dataCEQ["CuentaCEQ", i].Value.ToString());
                    }
                }
            }

            for (int i = 0; i <= dataCS.RowCount - 1; i++)
            {
                if (dataCS["MovilCS", i].Value != null)
                {
                    if (dataCS["CuentaCS", i].Value != null)
                    {
                        cuentas.Add(dataCS["CuentaCS", i].Value.ToString());
                    }
                }
            }

            switch (distinctcuentas.Count())
            {
                case 0:
                    break;
                case 1:
                    lblProy2.Text = "HL";
                    MessageBox.Show("Se copió el nombre de proyecto " + lblProy2.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(lblProy2.Text);
                    break;
                case 2:
                    lblProy2.Text = "HL2";
                    MessageBox.Show("Se copió el nombre de proyecto " + lblProy2.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(lblProy2.Text);
                    break;
                case 3:
                    lblProy2.Text = "HL3";
                    MessageBox.Show("Se copió el nombre de proyecto " + lblProy2.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(lblProy2.Text);
                    break;
                default:
                    MessageBox.Show("Se han ingresado más de 3 cuentas distintas. Por favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        //validaciones de 10 entradas en cada DGV
        private void dataHL_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataHL.Rows.Count > 10)
            {
                this.dataHL.AllowUserToAddRows = false;
            }
        }

        private void dataHL_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataHL.RowCount < 10)
            {
                this.dataHL.AllowUserToAddRows = true;
            }
        }

        private void dataCEQ_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataCEQ.Rows.Count > 10)
            {
                this.dataCEQ.AllowUserToAddRows = false;
            }
        }

        private void dataCEQ_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataCEQ.RowCount < 10)
            {
                this.dataCEQ.AllowUserToAddRows = true;
            }
        }

        private void dataCS_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataCS.Rows.Count > 10)
            {
                this.dataCS.AllowUserToAddRows = false;
            }
        }

        private void dataCS_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataCS.RowCount < 10)
            {
                this.dataCS.AllowUserToAddRows = true;
            }
        }
        //fin validaciones DGV

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

        //*************BOTONES DEL DATAGRIDVIEW HL***********
        //evento boton copia cuentas hacia abajo
        private void btnCopiaCuentas_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHL.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHL["Cuenta", i].Value != null)
                {
                    ult = dataHL["Cuenta", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHL.RowCount - 1; i++)
            {
                if (dataHL["Cantidad", i].Value != null)
                {
                    if (dataHL["Cuenta", i].Value == null)
                    {
                        dataHL["Cuenta", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia sim
        private void btnCopiaSIM_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHL.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHL["SIM", i].Value != null)
                {
                    ult = dataHL["SIM", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHL.RowCount - 1; i++)
            {
                if (dataHL["Cantidad", i].Value != null)
                {
                    if (dataHL["SIM", i].Value == null)
                    {
                        dataHL["SIM", i].Value = ult;
                    }
                }
            }
        }//fin boton copia sim

        //evento boton copia valores
        private void btnCopiaValor_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHL.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHL["Valor", i].Value != null)
                {
                    ult = dataHL["Valor", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHL.RowCount - 1; i++)
            {
                if (dataHL["Cantidad", i].Value != null)
                {
                    if (dataHL["Valor", i].Value == null)
                    {
                        dataHL["Valor", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        //evento boton copia plan
        private void btnCopiaPlan_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHL.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHL["Plan", i].Value != null)
                {
                    ult = dataHL["Plan", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHL.RowCount - 1; i++)
            {
                if (dataHL["Cantidad", i].Value != null)
                {
                    if (dataHL["Plan", i].Value == null)
                    {
                        dataHL["Plan", i].Value = ult;
                    }
                }
            }
        }//fin copia condicones plan

        //evento boton copia equipos
        private void btnCopiaEquipos_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHL.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHL["Modelo", i].Value != null)
                {
                    ult = dataHL["Modelo", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHL.RowCount - 1; i++)
            {
                if (dataHL["Cantidad", i].Value != null)
                {
                    if (dataHL["Modelo", i].Value == null)
                    {
                        dataHL["Modelo", i].Value = ult;
                    }
                }
            }
        }//fin boton copia equipos


        //evento boton copia valores
        private void btnCopiaValorEq_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHL.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHL["ValorEq", i].Value != null)
                {
                    ult = dataHL["ValorEq", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHL.RowCount - 1; i++)
            {
                if (dataHL["Cantidad", i].Value != null)
                {
                    if (dataHL["ValorEq", i].Value == null)
                    {
                        dataHL["ValorEq", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        //evento boton copia condiciones comerciales
        private void btnCopiaCondicion_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHL.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHL["Condicion", i].Value != null)
                {
                    ult = dataHL["Condicion", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHL.RowCount - 1; i++)
            {
                if (dataHL["Cantidad", i].Value != null)
                {
                    if (dataHL["Condicion", i].Value == null)
                    {
                        dataHL["Condicion", i].Value = ult;
                    }
                }
            }
        }//fin copia condicones comerciales
         //****************FIN BOTONES DATAGRIDVIEW HL*****************


        //***BOTONES CEQ
        //evento boton copia cuentas hacia abajo
        private void btnCopiaCuentasCEQ_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCEQ.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCEQ["CuentaCEQ", i].Value != null)
                {
                    ult = dataCEQ["CuentaCEQ", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCEQ.RowCount - 1; i++)
            {
                if (dataCEQ["MovilCEQ", i].Value != null)
                {
                    if (dataCEQ["CuentaCEQ", i].Value == null)
                    {
                        dataCEQ["CuentaCEQ", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia equipos
        private void btnCopiaEquiposCEQ_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCEQ.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCEQ["ModeloCEQ", i].Value != null)
                {
                    ult = dataCEQ["ModeloCEQ", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCEQ.RowCount - 1; i++)
            {
                if (dataCEQ["MovilCEQ", i].Value != null)
                {
                    if (dataCEQ["ModeloCEQ", i].Value == null)
                    {
                        dataCEQ["ModeloCEQ", i].Value = ult;
                    }
                }
            }
        }//fin boton copia equipos

        //evento boton copia valores
        private void btnCopiaValorCEQ_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCEQ.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCEQ["ValorCEQ", i].Value != null)
                {
                    ult = dataCEQ["ValorCEQ", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCEQ.RowCount - 1; i++)
            {
                if (dataCEQ["MovilCEQ", i].Value != null)
                {
                    if (dataCEQ["ValorCEQ", i].Value == null)
                    {
                        dataCEQ["ValorCEQ", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        //evento boton copia condiciones comerciales
        private void btnCopiaCondicionCEQ_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCEQ.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCEQ["CondicionCEQ", i].Value != null)
                {
                    ult = dataCEQ["CondicionCEQ", i].Value.ToString();
                    break;
                }
            }
            // MessageBox.Show(ultimacuenta);
            for (int i = 1; i <= dataCEQ.RowCount - 1; i++)
            {
                if (dataCEQ["MovilCEQ", i].Value != null)
                {
                    if (dataCEQ["CondicionCEQ", i].Value == null)
                    {
                        dataCEQ["CondicionCEQ", i].Value = ult;
                    }
                }
            }
        }//fin copia condicones comerciales

        //***FIN BOTONES CEQ

        //***BOTONES CS

        //evento boton copia cuentas hacia abajo
        private void btnCopiaCuentasCS_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCS.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCS["CuentaCS", i].Value != null)
                {
                    ult = dataCS["CuentaCS", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCS.RowCount - 1; i++)
            {
                if (dataCS["MovilCS", i].Value != null)
                {
                    if (dataCS["CuentaCS", i].Value == null)
                    {
                        dataCS["CuentaCS", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia sim hacia abajo
        private void btnCopiaSIMCS_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCS.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCS["SIMCS", i].Value != null)
                {
                    ult = dataCS["SIMCS", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCS.RowCount - 1; i++)
            {
                if (dataCS["MovilCS", i].Value != null)
                {
                    if (dataCS["SIMCS", i].Value == null)
                    {
                        dataCS["SIMCS", i].Value = ult;
                    }
                }
            }
        }//fin evento copia sim

        //evento boton copia valores
        private void btnCopiaValorCS_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataCS.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataCS["ValorCS", i].Value != null)
                {
                    ult = dataCS["ValorCS", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataCS.RowCount - 1; i++)
            {
                if (dataCS["MovilCS", i].Value != null)
                {
                    if (dataCS["ValorCS", i].Value == null)
                    {
                        dataCS["ValorCS", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        //***FIN BOTONES CS

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataHL.Rows.Clear();
            dataHL.Refresh();
            dataCEQ.Rows.Clear();
            dataCEQ.Refresh();
            dataCS.Rows.Clear();
            dataCS.Refresh();
            campoRUT.Clear();
            campoOCO.Clear();
            campoDatos.Clear();
            campoObs.Clear();
            checkOCO.Checked = false;
        }

        private void TabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            String pestana = tabControl1.SelectedTab.Name.ToString();
            switch (pestana)
            {
                case ("tabHL"):
                    lblRuta1.Location = new Point(389, 29);
                    lblRuta2.Location = new Point(389, 42);
                    lblProy1.Location = new Point(838, 29);
                    lblProy2.Location = new Point(838, 42);
                    lblDatos.Location = new Point(163, 441);
                    campoDatos.Location = new Point(163, 457);
                    lblObs.Location = new Point(448, 441);
                    campoObs.Location = new Point(448, 457);
                    lblEjecutivo.Location = new Point(725, 441);
                    comboEjecutivo.Location = new Point(725, 457);
                    btnCopiaProy.Location = new Point(732, 500);
                    btnGrabar.Location = new Point(751, 548);
                    this.Size = new Size(1070, 630);
                    tabControl1.Size = new Size(1007, 305);
                    break;
                case ("tabCEQ"):
                    lblRuta1.Location = new Point(250, 29);
                    lblRuta2.Location = new Point(250, 42);
                    lblProy1.Location = new Point(550, 29);
                    lblProy2.Location = new Point(550, 42);
                    lblDatos.Location = new Point(50, 441);
                    campoDatos.Location = new Point(50, 457);
                    lblObs.Location = new Point(300, 441);
                    campoObs.Location = new Point(300, 457);
                    lblEjecutivo.Location = new Point(550, 441);
                    comboEjecutivo.Location = new Point(550, 457);
                    btnCopiaProy.Location = new Point(555, 500);
                    btnGrabar.Location = new Point(575, 548);
                    this.Size = new Size(770, 630);
                    tabControl1.Size = new Size(710, 305);
                    break;
                case ("tabCS"):
                    lblRuta1.Location = new Point(210, 29);
                    lblRuta2.Location = new Point(210, 42);
                    lblProy1.Location = new Point(480, 29);
                    lblProy2.Location = new Point(480, 42);
                    lblDatos.Location = new Point(40, 441);
                    campoDatos.Location = new Point(40, 457);
                    lblObs.Location = new Point(265, 441);
                    campoObs.Location = new Point(265, 457);
                    lblEjecutivo.Location = new Point(490, 441);
                    comboEjecutivo.Location = new Point(490, 457);
                    btnCopiaProy.Location = new Point(495, 500);
                    btnGrabar.Location = new Point(515, 548);
                    this.Size = new Size(690, 630);
                    tabControl1.Size = new Size(633, 305);
                    break;
            }
        }

        private void dataHL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void dataCEQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void dataCS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }
    }
}

