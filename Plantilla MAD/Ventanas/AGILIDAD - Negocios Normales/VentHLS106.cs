using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentHLS106 : Form
    {
        public VentHLS106()
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

                //fin cabecera

                //obtiene los valores del datagridview
                String datos = "";
                String[,] mat = new String[dataHLS106.RowCount, 3];
                List<String> filas1 = new List<string>();
                List<String> cuentas = new List<string>();


                for (int i = 0; i <= dataHLS106.RowCount - 1; i++)
                {
                    String filacuenta = "";
                    String filaSIM = "";
                    String filavalor = "";
                    String filaplan = "";

                    if (dataHLS106["Patente", i].Value != null)
                    {
                        if (dataHLS106["Cuenta", i].Value != null)
                        {
                            filacuenta = "Cuenta: " + dataHLS106["Cuenta", i].Value.ToString() + "\n";
                        }
                        if (dataHLS106["SIM", i].Value != null)
                        {
                            filaSIM = "SIM: " + dataHLS106["SIM", i].Value.ToString() + "\n";
                        }
                        if (dataHLS106["Valor", i].Value != null)
                        {
                            filavalor = "Valor: $" + dataHLS106["Valor", i].Value.ToString() + "\n";
                        }
                        if (dataHLS106["Plan", i].Value != null)
                        {
                            filaplan = "Plan: " + dataHLS106["Plan", i].Value.ToString() + "\n" + "Patentes: \n";
                        }
                        if (dataHLS106["Cuenta", i].Value != null)
                        {
                            mat[i, 2] = dataHLS106["Cuenta", i].Value.ToString();
                            cuentas.Add(dataHLS106["Cuenta", i].Value.ToString());
                        }

                        mat[i, 0] = dataHLS106["Patente", i].Value.ToString();
                        mat[i, 1] = filaSIM + filavalor + filaplan;

                        filas1.Add(filaSIM + filavalor + filaplan);

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
                if (comboEjecutivo.Text.Equals("Oscar Illanes R.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 997483484" + "\nEmail:OILLANES@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Paula Sola G.")) { datosEjec = "\nAnexo: 38304" + "\nMóvil: 999174324" + "\nEmail: PSOLA@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Philipp Gallardo G.")) { datosEjec = "\nAnexo: 32915" + "\nMóvil: 998359021" + "\nEmail: PGGALLARDO@ENTEL.CL"; }
                if (comboEjecutivo.Text.Equals("Romina Saez G.")) { datosEjec = "\nAnexo: 0" + "\nMóvil: 956813727" + "\nEmail: RSAEZ@ENTEL.CL"; }
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
                        labelHLS106.Text = "HLS106";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        labelHLS106.Text = "HLS0162";
                        Clipboard.SetDataObject(texto.Trim());
                        MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        labelHLS106.Text = "HLS1063";
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

            for (int i = 0; i <= dataHLS106.RowCount - 1; i++)
            {
                if (dataHLS106["Patente", i].Value != null)
                {
                    if (dataHLS106["Cuenta", i].Value != null)
                    {
                        cuentas.Add(dataHLS106["Cuenta", i].Value.ToString());
                    }
                }
            }

            switch (distinctcuentas.Count())
            {
                case 0:
                    break;
                case 1:
                    labelHLS106.Text = "HLS106";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelHLS106.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelHLS106.Text);
                    break;
                case 2:
                    labelHLS106.Text = "HLS0162";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelHLS106.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelHLS106.Text);
                    break;
                case 3:
                    labelHLS106.Text = "HLS1063";
                    MessageBox.Show("Se copió el nombre de proyecto " + labelHLS106.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetDataObject(labelHLS106.Text);
                    break;
                default:
                    MessageBox.Show("Se han ingresado más de 3 cuentas distintas. Por favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void dataHLS106_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataHLS106.Rows.Count > 10)
            {
                this.dataHLS106.AllowUserToAddRows = false;
            }
        }

        private void dataHLS106_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataHLS106.RowCount < 10)
            {
                this.dataHLS106.AllowUserToAddRows = true;
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
            int totalfilas = dataHLS106.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHLS106["Cuenta", i].Value != null)
                {
                    ult = dataHLS106["Cuenta", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHLS106.RowCount - 1; i++)
            {
                if (dataHLS106["Patente", i].Value != null)
                {
                    if (dataHLS106["Cuenta", i].Value == null)
                    {
                        dataHLS106["Cuenta", i].Value = ult;
                    }
                }
            }
        }//fin evento copia cuentas

        //evento boton copia sim
        private void btnCopiaSIM_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHLS106.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHLS106["SIM", i].Value != null)
                {
                    ult = dataHLS106["SIM", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHLS106.RowCount - 1; i++)
            {
                if (dataHLS106["Patente", i].Value != null)
                {
                    if (dataHLS106["SIM", i].Value == null)
                    {
                        dataHLS106["SIM", i].Value = ult;
                    }
                }
            }
        }//fin boton copia sim

        //evento boton copia valores
        private void btnCopiaValor_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHLS106.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHLS106["Valor", i].Value != null)
                {
                    ult = dataHLS106["Valor", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHLS106.RowCount - 1; i++)
            {
                if (dataHLS106["Patente", i].Value != null)
                {
                    if (dataHLS106["Valor", i].Value == null)
                    {
                        dataHLS106["Valor", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

        //evento boton copia plan
        private void btnCopiaPlan_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataHLS106.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataHLS106["Plan", i].Value != null)
                {
                    ult = dataHLS106["Plan", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataHLS106.RowCount - 1; i++)
            {
                if (dataHLS106["Patente", i].Value != null)
                {
                    if (dataHLS106["Plan", i].Value == null)
                    {
                        dataHLS106["Plan", i].Value = ult;
                    }
                }
            }
        }//fin copia condicones plan

        private void VentHLS106_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Recordar que este tipo de " +
                "solicitud solo aplica para regiones", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (System.Windows.Forms.DialogResult.Cancel.Equals(dr))
            {
                this.Close();
            }
        }

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataHLS106.Rows.Clear();
            dataHLS106.Refresh();
            campoRUT.Clear();
            campoDatos.Clear();
            campoObs.Clear();
        }

        private void dataHLS106_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{F2}");
        }
    }
}