using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentLogo : Form
    {
        public VentLogo()
        {
            InitializeComponent();
        }

        private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "mailto:CFRamirez@entel.cl?subject=MAD app";
            proc.Start();
        }

    }
}
