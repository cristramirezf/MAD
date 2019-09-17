using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentMSERVICIOS : Form
    {
        public VentMSERVICIOS()
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

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            Excel.Application app = null;
            Excel.Workbooks books = null;
            Excel.Workbook book = null;
            Excel.Sheets sheets = null;
            Excel.Worksheet sheet = null;
            Excel.Range range1 = null;
            Excel.Range range2 = null;
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
                range1.Value = "Móvil";
                range2 = sheet.Range["B1"];
                range2.Value = "Servicios a activar/desactivar";
                sheet.Columns.AutoFit();
                try
                {
                    book.SaveAs(@docsDir + "SERVICIOS_MASIVO_" + DateTime.Now.ToString("HHmmss_ddMMyy") + ".xlsx");
                    MessageBox.Show("Se guardó el archivo SERVICIOS_MASIVO_" + DateTime.Now.ToString("HHmmss_ddMMyy") + ".xlsx \n\nEn " + docsDir, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }
                book.Close();
                app.Quit();
            }
            finally
            {
                if (range1 != null) Marshal.ReleaseComObject(range1);
                if (range2 != null) Marshal.ReleaseComObject(range2);
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
                String cabecera = "RUT: " + campoRUT.Text + "\n" + "\n";

                //fin datos cabecera

                String datos = "Se adjunta planilla Excel con datos.\n\n";

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
if (comboEjecutivo.Text.Equals("Oscar Magallanes R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 993235193" + "\nEmail: OMAGALLANES@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Philipp Gallardo G.")) {datosEjec = "\nAnexo: 32915" + "\nMóvil: 998359021" + "\nEmail: PGGALLARDO@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Romina Saez G.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 956813727" + "\nEmail: RSAEZ@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Sandra Bustos R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 993264132" + "\nEmail: SBUSTOSR@ENTEL.CL"; }
if (comboEjecutivo.Text.Equals("Sandra Lazcano A.")) {datosEjec = "\nAnexo: 38262" + "\nMóvil: 998289233" + "\nEmail: SLAZCANO@ENTEL.CL"; }
if (comboEjecutivo.Text.Equals("Simon Segura B.")) {datosEjec = "\nAnexo: 33219" + "\nMóvil: 985586068" + "\nEmail: SBSEGURA@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Vladimir Cubillos R.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 990704094" + "\nEmail: VCUBILLOS@ENTEL.CL";}
if (comboEjecutivo.Text.Equals("Ximena Valdes V.")) {datosEjec = "\nAnexo: 0" + "\nMóvil: 999687998" + "\nEmail: XVALDES@ENTEL.CL";}

                //fin datos ejecutivos

                String pie = comboEjecutivo.Text + datosEjec;

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
