﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentMHL : Form
    {
        public VentMHL()
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

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            Excel.Application app = null;
            Excel.Workbooks books = null;
            Excel.Workbook book = null;
            Excel.Sheets sheets = null;
            Excel.Worksheet sheet = null;
            Excel.Range range1 = null;
            Excel.Range range2 = null;
            Excel.Range range3 = null;
            Excel.Range range4 = null;
            Excel.Range range5 = null;
            try
            {
                String docsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MAD\\";

                if (!(Directory.Exists(docsDir)))
                {
                    Directory.CreateDirectory(docsDir);
                    MessageBox.Show("Se creó el directorio para guardar los Excel en " + docsDir, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                app = new Excel.Application();
                books = app.Workbooks;
                book = books.Add();
                sheets = book.Sheets;
                sheet = sheets.Add();
                range1 = sheet.Range["A1"];
                range1.Value = "Cantidad";
                range2 = sheet.Range["B1"];
                range2.Value = "Cuenta";
                range3 = sheet.Range["C1"];
                range3.Value = "Código SIM";
                range4 = sheet.Range["D1"];
                range4.Value = "Valor";
                range4 = sheet.Range["E1"];
                range4.Value = "Plan";
                sheet.Columns.AutoFit();
                try
                {
                    book.SaveAs(@docsDir + "HL_MASIVO_" + DateTime.Now.ToString("HHmmss_ddMMyy") + ".xlsx");
                    MessageBox.Show("Se guardó el archivo HL_MASIVO_" + DateTime.Now.ToString("HHmmss_ddMMyy") + ".xlsx \n\nEn " + docsDir, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }
                book.Close();
                app.Quit();
            }
            finally
            {
                if (range1 != null) Marshal.ReleaseComObject(range1);
                if (range2 != null) Marshal.ReleaseComObject(range2);
                if (range3 != null) Marshal.ReleaseComObject(range3);
                if (range4 != null) Marshal.ReleaseComObject(range4);
                if (range5 != null) Marshal.ReleaseComObject(range5);
                if (sheet != null) Marshal.ReleaseComObject(sheet);
                if (sheets != null) Marshal.ReleaseComObject(sheets);
                if (book != null) Marshal.ReleaseComObject(book);
                if (books != null) Marshal.ReleaseComObject(books);
                if (app != null) Marshal.ReleaseComObject(app);
            }
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validacionesTexto())
            {
                //establecimiento de datos de cabecera de MAD
                String cabecera = "";

                if (checkOCO.Checked)
                {
                    cabecera = "RUT: " + campoRUT.Text + "\n" +
                               "OC: " + campoOCO.Text + "\n" + "\n";
                }
                else
                {
                    cabecera = "RUT: " + campoRUT.Text + "\n" + "\n";
                }

                //fin datos cabecera

                String datos = "Se adjunta planilla Excel con datos.\n\n";

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

                String pie = "Datos de contacto: " + "\n" + campoDatos.Text.Trim() +
                             "\n\n" + comboEjecutivo.Text + datosEjec;

                //une los textos 
                String texto = cabecera + datos + pie;
                Clipboard.SetDataObject(texto.Trim());
                MessageBox.Show("Se ha copiado exitosamente el texto del MAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCopiaProy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(lblNomProy.Text);
            MessageBox.Show("Se copió el nombre de proyecto " + lblNomProy.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Debe llenar los datos ejecutivo SAC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboEjecutivo.Focus();
                return false;
            }
            return true;
        }

    }
}


