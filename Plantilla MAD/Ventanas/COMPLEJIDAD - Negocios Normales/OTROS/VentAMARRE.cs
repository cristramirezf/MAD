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
    public partial class VentAMARRE : Form
    {
        public VentAMARRE()
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

        //evento boton copia valores
        private void btnCopiaNegocio_Click(object sender, EventArgs e)
        {
            String ult = "";
            int totalfilas = dataDatos.Rows.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {
                if (dataDatos["Negocio", i].Value != null)
                {
                    ult = dataDatos["Negocio", i].Value.ToString();
                    break;
                }
            }
            for (int i = 1; i <= dataDatos.RowCount - 1; i++)
            {
                if (dataDatos["Movil", i].Value != null)
                {
                    if (dataDatos["Negocio", i].Value == null)
                    {
                        dataDatos["Negocio", i].Value = ult;
                    }
                }
            }
        }//fin copia valores

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
                String[,] mat = new String[dataDatos.RowCount, 2];
                List<String> negocio = new List<string>();


                for (int i = 0; i <= dataDatos.RowCount - 1; i++)
                {
                    if (dataDatos["IMEIA", i].Value != null)
                    {
                        negocio.Add(dataDatos["Negocio", i].Value.ToString());
                    }
                }

                IEnumerable<String> distinctnegocio = negocio.AsQueryable().Distinct();
                foreach (String elemento in distinctnegocio)
                {
                    String acum = "";
                    for (int i = 0; i <= dataDatos.RowCount - 1; i++)
                    {
                        if ((dataDatos["IMEIA", i].Value != null) && (dataDatos["IMEIN", i].Value != null) &&
                            (dataDatos["Movil", i].Value != null) && (dataDatos["Negocio", i].Value.ToString().Equals(elemento)))
                        {
                            acum = acum + "IMEI Antiguo: " + dataDatos["IMEIA", i].Value.ToString() + "\n" +
                                          "Móvil: " + dataDatos["Movil", i].Value.ToString() + "\n" +
                                          "IMEI Nuevo: " + dataDatos["IMEIN", i].Value.ToString() + "\n\n"; ;
                        }
                    }
                    datos = datos + "Negocio: " + elemento + "\n" + acum;
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
