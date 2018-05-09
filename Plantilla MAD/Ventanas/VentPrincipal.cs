using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plantilla_MAD.Ventanas
{
    public partial class VentPrincipal : Form
    {
        public VentPrincipal()
        {
            InitializeComponent();
        }

        private void comboMundo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboProyecto.Visible = true;
            lblDesea.Visible = true;
            if (Convert.ToString(comboMundo.Text).Equals("Agilidad"))
            {
                comboProyecto.Items.Clear();
                comboProyecto.Items.Add("-- CAMBIO DE EQUIPO --");
                comboProyecto.Items.Add("Cambio de equipo");
                comboProyecto.Items.Add("Cambio de equipo plan Autogestión");
                comboProyecto.Items.Add("Cambio de equipo plan Multimedia");
                comboProyecto.Items.Add("-- HABILITACIÓN DE LÍNEA --");
                comboProyecto.Items.Add("Habilitación de línea nueva");
                comboProyecto.Items.Add("Habilitación de línea plan Autogestión");
                comboProyecto.Items.Add("Habilitación de línea plan Multimedia");
                comboProyecto.Items.Add("Habilitación línea suc. S106");
                comboProyecto.Items.Add("-- CAMBIO DE SIMCARD --");
                comboProyecto.Items.Add("Cambio de simcard");
                comboProyecto.Items.Add("Cambio de simcard suc. S106");
                comboProyecto.Items.Add("-- MIGRACIÓN --");
                comboProyecto.Items.Add("Migrar líneas a prepago");
                comboProyecto.Items.Add("Migrar líneas a plan");
                comboProyecto.Items.Add("-- OTRAS --");
                comboProyecto.Items.Add("Venta de equipo sin suscripción");
                comboProyecto.Items.Add("Portabilidad");
            }
            else
            {
                comboProyecto.Items.Clear();
                comboProyecto.Items.Add("-- PLANES/SERVICIOS --");
                comboProyecto.Items.Add("Activación/desactivación de bolsas o servicios");
                comboProyecto.Items.Add("Activación/desactivación de correo");
                comboProyecto.Items.Add("Cambio de plan");
                comboProyecto.Items.Add("Cambio de condiciones comerciales");
                comboProyecto.Items.Add("Cambio a SIM nueva (contingencia)");
                comboProyecto.Items.Add("Renuncia de líneas");
                comboProyecto.Items.Add("Reversa de renuncia");
                comboProyecto.Items.Add("-- CESIONES/TRASPASOS --");
                comboProyecto.Items.Add("Cesión de líneas y/o equipos");
                comboProyecto.Items.Add("Traspaso de líneas y/o equipos");
                comboProyecto.Items.Add("-- ADMINISTRATIVAS --");
                comboProyecto.Items.Add("Creación de giro");
                comboProyecto.Items.Add("Detalle de tráfico");
                comboProyecto.Items.Add("Cambio de datos cliente");
                comboProyecto.Items.Add("Cambio de razón social");
                comboProyecto.Items.Add("Información del cliente");
                comboProyecto.Items.Add("Enrolamiento CAT Corp");
                comboProyecto.Items.Add("Envio/creación clave portal Administrador");
                comboProyecto.Items.Add("Creación de nueva cuenta");
                comboProyecto.Items.Add("Foto servicios");
                comboProyecto.Items.Add("-- EMISIÓN DOCUMENTOS --");
                comboProyecto.Items.Add("Emisión nota de crédito");
                comboProyecto.Items.Add("Emisión nota de crédito aclaratoria");
                comboProyecto.Items.Add("Emisión refactura");
                comboProyecto.Items.Add("Solicitud de vale vista por multa");
                comboProyecto.Items.Add("Ingreso nueva OCC");
                comboProyecto.Items.Add("Modificación OCC");
                comboProyecto.Items.Add("Emisión de factura manual");
                comboProyecto.Items.Add("-- ANÁLISIS --");
                comboProyecto.Items.Add("Análisis factura");
                comboProyecto.Items.Add("Análisis con nota de crédito");
                comboProyecto.Items.Add("Análisis fraude");
                comboProyecto.Items.Add("-- EQUIPOS --");
                comboProyecto.Items.Add("Anulación de equipo");
                comboProyecto.Items.Add("Anulación virtual de negocio");
                comboProyecto.Items.Add("Aceleración de equipos");
                comboProyecto.Items.Add("Amarre/desamarre línea y equipo");

            }
        }

        private void comboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            String opcPCE = Convert.ToString(comboProyecto.Text);
            checkMasivo.Checked = false;
            checkMasivo.Enabled = true;
            checkMasivo.Visible = true;
            if (
                opcPCE.Equals("Cambio de datos cliente") ||
                opcPCE.Equals("Cambio de condiciones comerciales") ||
                opcPCE.Equals("Creación de giro") ||
                opcPCE.Equals("Detalle de tráfico") ||
                opcPCE.Equals("Información del cliente") ||
                opcPCE.Equals("Foto servicios") ||
                opcPCE.Equals("Reversa de renuncia") ||
                opcPCE.Equals("Emisión nota de crédito") ||
                opcPCE.Equals("Emisión nota de crédito aclaratoria") ||
                opcPCE.Equals("Emisión refactura") ||
                opcPCE.Equals("Ingreso nueva OCC") ||
                opcPCE.Equals("Modificación OCC") ||
                opcPCE.Equals("Enrolamiento CAT Corp") ||
                opcPCE.Equals("Envio/creación clave portal Administrador") ||
                opcPCE.Equals("Creación de nueva cuenta") ||
                opcPCE.Equals("Análisis factura") ||
                opcPCE.Equals("Análisis con nota de crédito") ||
                opcPCE.Equals("Análisis fraude") ||
                opcPCE.Equals("Anulación de equipo") ||
                opcPCE.Equals("Anulación virtual de negocio") ||
                opcPCE.Equals("Cambio de razón social") ||
                opcPCE.Equals("Solicitud de vale vista por multa") ||
                opcPCE.Equals("Emisión de factura manual") ||
                opcPCE.Equals("Aceleración de equipos")
                )
            {
                checkMasivo.Enabled = false;
            }
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String opcion = Convert.ToString(comboProyecto.Text);
            if (!checkMasivo.Checked)
            {
                switch (opcion)
                {
                    case "Cambio de equipo":
                        VentCEQ CEQ = new VentCEQ();
                        CEQ.Show();
                        break;
                    case "Cambio de simcard":
                        VentCS CS = new VentCS();
                        CS.Show();
                        break;
                    case "Habilitación de línea nueva":
                        VentHL HL = new VentHL();
                        HL.Show();
                        break;
                    case "Migrar líneas a prepago":
                        VentMIGSSPP MIGSSPP = new VentMIGSSPP();
                        MIGSSPP.Show();
                        break;
                    case "Migrar líneas a plan":
                        VentMIGPPSS MIGPPSS = new VentMIGPPSS();
                        MIGPPSS.Show();
                        break;
                    case "Habilitación línea suc. S106":
                        VentHLS106 HLS106 = new VentHLS106();
                        HLS106.Show();
                        break;
                    case "Cambio de simcard suc. S106":
                        VentCSS106 CSS106 = new VentCSS106();
                        CSS106.Show();
                        break;
                    case "Habilitación de línea plan Autogestión":
                        VentHMMPA HMMPA = new VentHMMPA();
                        HMMPA.Show();
                        break;
                    case "Habilitación de línea plan Multimedia":
                        VentHMM HMM = new VentHMM();
                        HMM.Show();
                        break;
                    case "Cambio de equipo plan Autogestión":
                        VentCEQMMPA CEQMMPA = new VentCEQMMPA();
                        CEQMMPA.Show();
                        break;
                    case "Cambio de equipo plan Multimedia":
                        VentCEQMM CEQMM = new VentCEQMM();
                        CEQMM.Show();
                        break;
                    case "Venta de equipo sin suscripción":
                        VentVE VE = new VentVE();
                        VE.Show();
                        break;
                    case "Portabilidad":
                        VentPORTA PORTA = new VentPORTA();
                        PORTA.Show();
                        break;
                    //aquí empiezan los proyectos de OTROS
                    case "Activación/desactivación de bolsas o servicios":
                        VentSERVICIOS SERVICIOS = new VentSERVICIOS();
                        SERVICIOS.Show();
                        break;
                    case "Activación/desactivación de correo":
                        VentCORREO CORREO = new VentCORREO();
                        CORREO.Show();
                        break;
                    case "Cambio de plan":
                        VentCAMBIODEPLAN PLAN = new VentCAMBIODEPLAN();
                        PLAN.Show();
                        break;
                    case "Cambio de datos cliente":
                        VentCAMBIODEDATOS DATOS = new VentCAMBIODEDATOS();
                        DATOS.Show();
                        break;
                    case "Cambio de condiciones comerciales":
                        VentCONDCOMERCIALES COND = new VentCONDCOMERCIALES();
                        COND.Show();
                        break;
                    case "Cambio a SIM nueva (contingencia)":
                        VentCONTINGENCIA CONT = new VentCONTINGENCIA();
                        CONT.Show();
                        break;
                    case "Creación de giro":
                        VentCREACIONDEGIRO CG = new VentCREACIONDEGIRO();
                        CG.Show();
                        break;
                    case "Detalle de tráfico":
                        VentTRAFICO TRAF = new VentTRAFICO();
                        TRAF.Show();
                        break;
                    case "Información del cliente":
                        VentINFOCLIENTE INFO = new VentINFOCLIENTE();
                        INFO.Show();
                        break;
                    case "Foto servicios":
                        VentFOTO FOTO = new VentFOTO();
                        FOTO.Show();
                        break;
                    case "Renuncia de líneas":
                        VentRENUNCIA RENUNCIA = new VentRENUNCIA();
                        RENUNCIA.Show();
                        break;
                    case "Reversa de renuncia":
                        VentRECUPERACION RECUP = new VentRECUPERACION();
                        RECUP.Show();
                        break;
                    case "Emisión nota de crédito":
                        VentNC NC = new VentNC();
                        NC.Show();
                        break;
                    case "Emisión nota de crédito aclaratoria":
                        VentNCACLARATORIA NCA = new VentNCACLARATORIA();
                        NCA.Show();
                        break;
                    case "Emisión refactura":
                        VentREFACTURA REF = new VentREFACTURA();
                        REF.Show();
                        break;
                    case "Ingreso nueva OCC":
                        VentOCC OCC = new VentOCC();
                        OCC.Show();
                        break;
                    case "Modificación OCC":
                        VentMANTENCIONOCC MOCC = new VentMANTENCIONOCC();
                        MOCC.Show();
                        break;
                    case "Enrolamiento CAT Corp":
                        VentENROL ENROL = new VentENROL();
                        ENROL.Show();
                        break;
                    case "Envio/creación clave portal Administrador":
                        VentPORTAL PORTAL = new VentPORTAL();
                        PORTAL.Show();
                        break;
                    case "Creación de nueva cuenta":
                        VentNUEVACUENTA NCTA = new VentNUEVACUENTA();
                        NCTA.Show();
                        break;
                    case "Cesión de líneas y/o equipos":
                        VentCESIONES CES = new VentCESIONES();
                        CES.Show();
                        break;
                    case "Traspaso de líneas y/o equipos":
                        VentTRASPASO TRAS = new VentTRASPASO();
                        TRAS.Show();
                        break;
                    case "Análisis factura":
                        VentANALISIS ANA = new VentANALISIS();
                        ANA.Show();
                        break;
                    case "Análisis con nota de crédito":
                        VentANALISIS ANA2 = new VentANALISIS();
                        ANA2.Show();
                        break;
                    case "Análisis fraude":
                        VentANALISIS ANA3 = new VentANALISIS();
                        ANA3.Show();
                        break;
                    case "Anulación de equipo":
                        VentANULACION ANU = new VentANULACION();
                        ANU.Show();
                        break;
                    case "Anulación virtual de negocio":
                        VentANULACIONVIRTUAL ANUV = new VentANULACIONVIRTUAL();
                        ANUV.Show();
                        break;
                    case "Aceleración de equipos":
                        VentACOC ACOC = new VentACOC();
                        ACOC.Show();
                        break;
                    case "Amarre/desamarre línea y equipo":
                        VentAMARRE AMARRE = new VentAMARRE();
                        AMARRE.Show();
                        break;
                    case "Cambio de razón social":
                        VentCAMBIORS CRS = new VentCAMBIORS();
                        CRS.Show();
                        break;
                    case "Solicitud de vale vista por multa":
                        VentVVM VVM = new VentVVM();
                        VVM.Show();
                        break;
                    case "Emisión de factura manual":
                        VentFM FM = new VentFM();
                        FM.Show();
                        break;
                    default:
                        break;
                }
            }
            //AQUI EMPIEZAN LOS MASIVOS
            else
            {
                switch (opcion)
                {
                    //MASIVOS DE PCE
                    case "Cambio de equipo":
                        VentMCEQ MCEQ = new VentMCEQ();
                        MCEQ.Show();
                        break;
                    case "Cambio de simcard":
                        VentMCS MCS = new VentMCS();
                        MCS.Show();
                        break;
                    case "Habilitación de línea nueva":
                        VentMHL MHL = new VentMHL();
                        MHL.Show();
                        break;
                    case "Migrar líneas a prepago":
                        VentMMIGSSPP MMIGSSPP = new VentMMIGSSPP();
                        MMIGSSPP.Show();
                        break;
                    case "Migrar líneas a plan":
                        VentMMIGPPSS MMIGPPSS = new VentMMIGPPSS();
                        MMIGPPSS.Show();
                        break;
                    case "Habilitación línea suc. S106":
                        VentMHLS106 MHLS106 = new VentMHLS106();
                        MHLS106.Show();
                        break;
                    case "Cambio de simcard suc. S106":
                        VentMCSS106 MCSS106 = new VentMCSS106();
                        MCSS106.Show();
                        break;
                    case "Habilitación de línea plan Autogestión":
                        VentMHMMPA MHMMPA = new VentMHMMPA();
                        MHMMPA.Show();
                        break;
                    case "Habilitación de línea plan Multimedia":
                        VentMHMM MHMM = new VentMHMM();
                        MHMM.Show();
                        break;
                    case "Cambio de equipo plan Autogestión":
                        VentMCEQMMPA MCEQMMPA = new VentMCEQMMPA();
                        MCEQMMPA.Show();
                        break;
                    case "Cambio de equipo plan Multimedia":
                        VentMCEQMM MCEQMM = new VentMCEQMM();
                        MCEQMM.Show();
                        break;
                    case "Venta de equipo sin suscripción":
                        VentMVE MVE = new VentMVE();
                        MVE.Show();
                        break;
                    case "Portabilidad":
                        VentMPORTA MPORTA = new VentMPORTA();
                        MPORTA.Show();
                        break;
                    //MASIVOS DE OTROS
                    case "Activación/desactivación de bolsas o servicios":
                        VentMSERVICIOS MSERVICIOS = new VentMSERVICIOS();
                        MSERVICIOS.Show();
                        break;
                    case "Activación/desactivación de correo":
                        VentMCORREO MCORREO = new VentMCORREO();
                        MCORREO.Show();
                        break;
                    case "Cambio de plan":
                        VentMCAMBIODEPLAN MCAMBIODEPLAN = new VentMCAMBIODEPLAN();
                        MCAMBIODEPLAN.Show();
                        break;
                    case "Cambio de condiciones comerciales":
                        VentMCONDCOMERCIALES MCONDCOMERCIALES = new VentMCONDCOMERCIALES();
                        MCONDCOMERCIALES.Show();
                        break;
                    case "Cambio a SIM nueva (contingencia)":
                        VentMCONTINGENCIA MCONTINGENCIA = new VentMCONTINGENCIA();
                        MCONTINGENCIA.Show();
                        break;
                    case "Renuncia de líneas":
                        VentMRENUNCIA MRENUNCIA = new VentMRENUNCIA();
                        MRENUNCIA.Show();
                        break;
                    case "Cesión de líneas y/o equipos":
                        VentMCESION MCESION = new VentMCESION();
                        MCESION.Show();
                        break;
                    case "Traspaso de líneas y/o equipos":
                        VentMTRASPASO MTRASPASO = new VentMTRASPASO();
                        MTRASPASO.Show();
                        break;
                    case "Amarre/desamarre línea y equipo":
                        VentMAMARRE MAMARRE = new VentMAMARRE();
                        MAMARRE.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void pictureEntel_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://www.google.cl");
            VentLogo Logo = new VentLogo();
            Logo.ShowDialog();
        }
    }
}
