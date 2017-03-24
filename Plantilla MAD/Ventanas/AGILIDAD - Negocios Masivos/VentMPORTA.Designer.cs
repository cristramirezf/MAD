﻿namespace Plantilla_MAD.Ventanas
{
    partial class VentMPORTA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentMPORTA));
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.campoFecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.campoServicios = new System.Windows.Forms.RichTextBox();
            this.comboPlan = new System.Windows.Forms.ComboBox();
            this.campoMMF = new System.Windows.Forms.TextBox();
            this.campoDonante = new System.Windows.Forms.TextBox();
            this.campoCuenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.lblNomProy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlanilla = new System.Windows.Forms.Button();
            this.lblFraude = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menúToolStripMenuItem.Text = "Ayuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 103;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // campoFecha
            // 
            this.campoFecha.CustomFormat = "";
            this.campoFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.campoFecha.Location = new System.Drawing.Point(46, 270);
            this.campoFecha.Name = "campoFecha";
            this.campoFecha.Size = new System.Drawing.Size(87, 20);
            this.campoFecha.TabIndex = 102;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 101;
            this.label13.Text = "Servicios a activar/bloquear";
            // 
            // campoServicios
            // 
            this.campoServicios.Location = new System.Drawing.Point(222, 389);
            this.campoServicios.Name = "campoServicios";
            this.campoServicios.Size = new System.Drawing.Size(172, 96);
            this.campoServicios.TabIndex = 100;
            this.campoServicios.Text = "";
            // 
            // comboPlan
            // 
            this.comboPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlan.FormattingEnabled = true;
            this.comboPlan.Items.AddRange(new object[] {
            "",
            "1 Economico POS",
            "10 PCS 200",
            "100 CUENTA CONTROLADA 15950",
            "104 PLAN GLOBAL 65",
            "1050 Multimedia 115",
            "1051 Multimedia 140",
            "1052 Multimedia 200",
            "1053 Multimedia 300",
            "1054 Multimedia 420",
            "1055 Multimedia 500",
            "1056 Multimedia 800",
            "1057 Multimedia Red 800",
            "1058 Multimedia Red 1200",
            "1059 BAM Chile Comunicado 1Mbp",
            "1061 BAM Multimedia 3GB",
            "1062 BAM Empresas Pro 1GB RE",
            "1063 BAM Empresas Pro 3GB RE",
            "1069 BlackBerry Multimedia 500",
            "107 BAM",
            "1073 Multimedia Red Total 20",
            "1074 Multimedia Red Total 50",
            "1075 Multimedia Red Total 50 P",
            "1076 Multimedia Red Total 100",
            "1077 Multimedia Red Total 200",
            "1078 Multimedia Red Total 500",
            "108 CUENTA CONTROLADA 13740",
            "11 PCS 300",
            "112 Plan Tarifa Unica 300",
            "1129 M2M ILIMITADO",
            "113 Plan Tarifa Unica 100",
            "114 Plan Tarifa Unica 200",
            "115 Plan Tarifa Unica 400",
            "116 Plan Tarifa Unica 600",
            "117 Tarifa Unica Joven",
            "118 Tarifa Unica 70",
            "120 BAM",
            "1207 Mi Pyme 2",
            "121 BAM",
            "1219 Plan Blackberry Red 770",
            "122 Plan Tarifa Unica 55",
            "1221 Mi Pyme 3",
            "1222 Mi Pyme 4",
            "1223 Mi Pyme 5",
            "1224 Mi Pyme 6",
            "1225 Mi Pyme 7",
            "1226 Mi Pyme 8",
            "1227 Mi Pyme 9",
            "1228 Mi Pyme 10",
            "1229 Mi Pyme 11",
            "1230 Mi Pyme 12",
            "1231 Mi Pyme 13",
            "1232 Mi Pyme 14",
            "1233 Mi Pyme 15",
            "1234 Mi Pyme 20",
            "1235 Mi Pyme 25",
            "1236 Mi Pyme 30",
            "1239 Mi Pyme Smartphone 500",
            "124 CUENTA CONTROLADA 15950",
            "1241 Mi Pyme Blackberry 250",
            "125 CUENTA CONTROLADA 18150",
            "1252 Blackberry Multimedia 100",
            "1253 Multimedia 100",
            "126 CUENTA CONTROLADA 22000",
            "1261 BAM Controlado 7GB",
            "1262 BAM Controlado 15GB",
            "1263 BAM Controlado 1GB",
            "1270 BAM Controlado 2GB",
            "1328 BAM Empresas 2GB",
            "1329 BAM Empresas 3GB",
            "1330 BAM Empresas 5GB",
            "1331 BAM Empresas 10G",
            "1331 BAM Empresas Pro 10GB",
            "1332 BAM Empresas 1GB",
            "1336 BAM Empresas 2G",
            "1336 BAM Empresas Pro 2G",
            "1337 BAM Empresas 4G",
            "1337 BAM Empresas Pro 4GB",
            "1338 BAM Empresas 6G",
            "1338 BAM Empresas Pro 6GB",
            "1339 BAM Empresas Pro 15GB",
            "1339 BAM Empresas15G",
            "1340 Multimedia 1000",
            "14 PCS MPP 400",
            "1402 Multimedia CC 13.990",
            "141 CUENTA CONTROLADA 27500",
            "1425 Multimedia Red 150",
            "1426 Multimedia Red 270",
            "1442 Mi Pyme Smartphone 800",
            "1443 Mi Pyme Smartphone 1.000",
            "1444 Mi Pyme Correo 100",
            "1445 Smartphone TD 200",
            "1446 Smartphone TD 320",
            "1447 Smartphone TD 500",
            "1448 Smartphone TD 1000",
            "145 TARIFA UNICA 200 + 30 SMS",
            "1452 BAM Pro 2GB Normal",
            "1453 BAM Pro 4GB Normal",
            "1454 BAM Pro 6GB Normal",
            "1455 BAM Pro 10GB Normal",
            "1456 BAM Pro 15GB Normal",
            "1461 M2M Corporaciones Sens",
            "1466 Multimedia Red 500",
            "1467 Multimedia Red 1000",
            "1470 Multimedia Full 1.5 GB",
            "1471 Multimedia Full 2 GB",
            "1471 Multimedia Full 2 GB ",
            "1472 Multimedia Full 3 GB",
            "1472 Multimedia Full 3 GB ",
            "1473 Multimedia Full 4.5 GB",
            "1473 Multimedia Full 4.5 GB ",
            "1474 Multimedia Full 6 GB",
            "1474 Multimedia Full 6 GB ",
            "1475 Multimedia Full 7.5 GB",
            "1475 Multimedia Full 7.5 GB ",
            "1476 Multimedia Full 10 GB",
            "1477 Multimedia Red Full 1 GB",
            "1480 M2M Corporaciones Gamm",
            "1488 Multimedia CC 16.990",
            "1489 Multimedia CC $20.990",
            "1489 Multimedia CC 20.990",
            "1490 Mi Empresa Smartphone 5",
            "1491 Mi Empresa Smartphone 6",
            "1492 Mi Empresa Smartphone 7",
            "1493 Mi Empresa Smartphone 8",
            "1494 Mi Empresa Smartphone 9",
            "1495 Mi Empresa Smartphone 10",
            "1496 Mi Empresa Smartphone 15",
            "1497 Mi Empresa Smartphone 20",
            "1498 Mi Empresa Smartphone 30",
            "1499 Empresa Smartphone Pro5",
            "15 PCS 800",
            "15 PCS 800 R",
            "1500 Empresa Smartphone Pro6",
            "1501 Empresa Smartphone Pro7",
            "1502 Empresa Smartphone Pro8",
            "1503 Empresa Smartphone Pro9",
            "1504 Empresa Smartphone Pro10",
            "1514 Cta Controlada $17.500 ",
            "1520 Cta. Controlada $6.900  ",
            "1521 Acceso XG 1",
            "1522 Acceso XG 2",
            "1523 BAM Controlado Corp 2GB",
            "1524 BAM Controlado Corp 4GB",
            "1525 BAM Controlado Corp 6GB",
            "1526 BAM Controlado Corp 10GB",
            "1527 BAM Controlado Corp 15GB",
            "1528 BAM Controlado Corp 30GB",
            "1529 M2M ALTO ",
            "1535 M2M BAJO ",
            "1536 M2M MEDIO",
            "1539 Multimedia Cta Cda $6.990  ",
            "1540 Multimedia Cta Cda $9.990  ",
            "1541 Multimedia Cta Cda $12.990 ",
            "1542 Multimedia Cta Cda $14.990 ",
            "1543 Mi Primer Multi $6.990  ",
            "1544 Mi Primer Multi. $9.990 ",
            "1556 Todo Destino 280",
            "1559 Datos Empresa 2gb",
            "1560 Datos Empresa 4gb",
            "1561 Datos Empresa 10gb",
            "1568 Plan Alto Trafico 8.000",
            "1569 Plan Alto Trafico 5.000",
            "1570 Plan Alto Trafico 2.000",
            "1571 Plan Alto Trafico 500",
            "1573 AUTOGESTION CORP 600MB 36",
            "1574 AUTOGESTION CORP 600MB 34",
            "1575 AUTOGESTION CORP 600MB 32",
            "1576 AUTOGESTION CORP 600MB 30",
            "1576 AUTOGESTION CORP 600MB 30 ",
            "1577 AUTOGESTION CORP 600MB 28",
            "1578 AUTOGESTION CORP 600MB 26",
            "1579 AUTOGESTION CORP 600MB 24",
            "1580 AUTOGESTION CORP 600MB 22",
            "1580 AUTOGESTION CORP 600MB 22 ",
            "1581 AUTOGESTION CORP 600MB 20",
            "1581 AUTOGESTION CORP 600MB 20 ",
            "1582 AUTOGESTION CORP 600MB 18",
            "1582 AUTOGESTION CORP 600MB 18  ",
            "1583 AUTOGESTION CORP 2GB 36",
            "1584 AUTOGESTION CORP 2GB 34",
            "1585 AUTOGESTION CORP 2GB 32",
            "1586 AUTOGESTION CORP 2GB 30",
            "1587 AUTOGESTION CORP 2GB 28",
            "1588 AUTOGESTION CORP 2GB 26",
            "1589 AUTOGESTION CORP 2GB 24",
            "1590 AUTOGESTION CORP 2GB 22",
            "1591 AUTOGESTION CORP 2GB 20",
            "1592 AUTOGESTION CORP 2GB 18",
            "1594 BAM Empresas 8 GB",
            "1595 BAM Empresas 12 GB",
            "1596 BAM Empresas 16 GB",
            "1597 BAM Empresas 1 GB RET",
            "1606 Multimedia Cta Cda $17.990",
            "1614 Voz Ilimitada",
            "162 CTA CONTROLADA LIBRE 16500",
            "1624 Cta. Controlada $13.900",
            "1625 Cta Controlada $8.900",
            "1630 BAM CC 400 MB ",
            "1631 BAM CC 600 MB  ",
            "1633 BAM CC 1 GB  ",
            "1635 BAM CC 1,5 GB ",
            "1636 BAM CC 2 GB ",
            "1637 BAM CC 3,5 GB ",
            "1638 BAM CC 5 GB ",
            "1639 BAM CC 6,5 GB ",
            "164 CTA CONTROLADA LIBRE 22000",
            "1640 BAM CC 10 GB",
            "1641 BAM CC 8 GB ",
            "1643 BAM Mi Primer Plan 400MB ",
            "1644 BAM Mi Primer Plan 600MB",
            "165 CTA CONTROLADA LIBRE 27500",
            "1652 Multi Smart 2 GB $25.990 ",
            "1653 Multi Smart 3 GB $29.990 ",
            "1654 Multi Smart 4.5 GB $39.990 ",
            "1655 Multi Smart 6 GB $49.990 ",
            "1656 Multi Smart 7.5 GB $59.990 ",
            "1657 Multi Smart 10 GB $69.990 ",
            "166 TARIFA UNICA 60",
            "1663 AUTOGESTION CORP 36",
            "1664 AUTOGESTION CORP 34",
            "1665 Autogestion Corp 18",
            "1665 Autogestion Corp 20",
            "1665 Autogestion Corp 22",
            "1665 Autogestion Corp 24",
            "1665 Autogestion Corp 26",
            "1665 Autogestion Corp 28",
            "1665 Autogestion Corp 30",
            "1665 AUTOGESTION CORP 32",
            "1666 AUTOGESTION CORP 30",
            "1667 AUTOGESTION CORP 28",
            "1668 AUTOGESTION CORP 26",
            "1669 AUTOGESTION CORP 24",
            "1670 AUTOGESTION CORP 22",
            "1671 AUTOGESTION CORP 20",
            "1672 AUTOGESTION CORP 18",
            "1673 AUTOGESTION CORP 1GB 36",
            "1674 AUTOGESTION CORP 1GB 34",
            "1675 AUTOGESTION CORP 1GB 32",
            "1676 AUTOGESTION CORP 1GB 30",
            "1677 AUTOGESTION CORP 1GB 28",
            "1678 AUTOGESTION CORP 1GB 26",
            "1678 AUTOGESTION CORP 1GB 26 ",
            "1679 AUTOGESTION CORP 1GB 24",
            "1679 AUTOGESTION CORP 1GB 24 ",
            "168 TARIFA UNICA 120",
            "1680 AUTOGESTION CORP 1GB 22",
            "1680 AUTOGESTION CORP 1GB 22 ",
            "1681 AUTOGESTION CORP 1GB 20",
            "1681 AUTOGESTION CORP 1GB 20 ",
            "1682 AUTOGESTION CORP 1GB 18",
            "1682 AUTOGESTION CORP 1GB 18 ",
            "1683 AUTOGESTION CORP 1.5GB 36",
            "1684 AUTOGESTION CORP 1.5GB 34",
            "1685 AUTOGESTION CORP 1.5GB 32",
            "1686 AUTOGESTION CORP 1.5GB 30",
            "1687 AUTOGESTION CORP 1.5GB 28",
            "1688 AUTOGESTION CORP 1.5GB 26",
            "1689 AUTOGESTION CORP 1.5GB 24",
            "1690 AUTOGESTION CORP 1.5GB 22",
            "1691 AUTOGESTION CORP 1.5GB 20",
            "1692 AUTOGESTION CORP 1.5GB 18",
            "1693 AUTOGESTION CORP 3GBFULL",
            "1694 AUTOGESTION CORP 4GBFULL",
            "1695 AUTOGESTION CORP 6GBFULL",
            "1696 AUTOGESTION CORP 8GBFULL",
            "1697 AUTOGESTION CORP 10GBFULL",
            "1698 AUTOGESTION CORP 12GBFULL",
            "170 Plan Tarifa Unica 400",
            "171 Plan Tarifa unica 600",
            "1734 M2M Contingencia Minsal",
            "1735 Multimedia CC 15.990",
            "1738 BAM Pro 1GB Corp 18",
            "1740 BAM Pro 3GB Corp 18",
            "1743 AUTOGESTION CORP 38",
            "1744 AUTOGESTION CORP 40",
            "1745 AUTOGESTION CORP 42",
            "1746 AUTOGESTION CORP 44",
            "1747 AUTOGESTION CORP 600MB 38",
            "1748 AUTOGESTION CORP 600MB 40",
            "1749 AUTOGESTION CORP 600MB 42",
            "1750 AUTOGESTION CORP 600MB 44",
            "1751 AUTOGESTION CORP 1GB 38",
            "1752 AUTOGESTION CORP 1GB 40",
            "1753 AUTOGESTION CORP 1GB 42",
            "1754 AUTOGESTION CORP 1GB 44",
            "1755 AUTOGESTION CORP 1.5GB 38",
            "1756 AUTOGESTION CORP 1.5GB 40",
            "1757 AUTOGESTION CORP 1.5GB 42",
            "1758 AUTOGESTION CORP 1.5GB 44",
            "1759 AUTOGESTION CORP 2GB 38",
            "1760 AUTOGESTION CORP 2GB 40",
            "1761 AUTOGESTION CORP 2GB 42",
            "1762 AUTOGESTION CORP 2GB 44",
            "1763 BAM CC 3 GB ",
            "1764 M2M UBI Uno",
            "181 CUENTA CONTROLADA RED",
            "182 CUENTA CONTROLADA RED",
            "183 CUENTA CONTROLADA RED",
            "184 CUENTA CONTROLADA RED",
            "186 CTA CONTROLADA PLANO 13690",
            "191 TARIFA UNICA 150",
            "192 TARIFA UNICA 250",
            "194 TARIFA UNICA 150",
            "195 TARIFA UNICA 250",
            "196 PLAN UNICO 4290",
            "2 Supereconomico POS",
            "213 BAM Controlado 1,5GB",
            "214 BAM Controlado 3GB",
            "218 BAM MasConectado 1GB",
            "246 BAM 700kbps Netbook",
            "260 BAM XI,XII,IDP 200Kbps PER",
            "261 BAM XI,XII,IDP 700Kbps PER",
            "262 BAM MasConectado 10GB",
            "290 CTA CONTROLADA RED 6990",
            "291 CTA CONTROLADA RED 8990",
            "292 CTA CONTROLADA RED 11990",
            "307 ECORP 5400 SEGUNDOS",
            "308 ECORP 24000 SEGUNDOS",
            "310 ECORP 96000s",
            "313 ECORP 7200 SEGUNDOS",
            "314 ECORP 14400 SEGUNDOS",
            "323 ECORPs",
            "327 AFINIDAD CTA CONTROLADA 1",
            "331 ECORP VIP 100",
            "334 ECORP VIP 600",
            "335 ECORP VIP 800",
            "336 ECORP VIP 1000",
            "337 ECORP VIP 1500",
            "338 ECORP CC",
            "339 ECORP 15450",
            "340 ECORP CC",
            "35 PCS 60s",
            "36 PCS 1200s",
            "361 ECORP 210",
            "363 ECORP 480",
            "4 Promedio",
            "400 PCS RENT CPP",
            "401 PCS RENT MPP",
            "403 PCS RENT MPP",
            "404 PCS RENT MPP",
            "405 DATOS",
            "405 PLAN PCS RENT CPP",
            "406 M2M Empresa",
            "408 TELEMETRIA",
            "410 PLAN SMS RED",
            "412 SMS WEB",
            "413 PLAN DEMO LOCALIZACION",
            "414 LOCALIZACION ENTEL GPS",
            "415 LOCALIZACION ENTEL GPS",
            "416 SMS Empresas",
            "417 M2M Empresa",
            "44 RED PCS 80 s",
            "448 Cuenta Optimizada",
            "449 Super P. Optimizacion RED",
            "460 Plan Optimizacion RPV",
            "461 PLAN CONVERSOR",
            "462 PLAN CONVERSOR",
            "463 RED",
            "465 CUENTA CONTROLADA",
            "466 CUENTA OPTIMIZADA",
            "468 SGO",
            "469 SGO",
            "476 RED",
            "477 RED",
            "478 RED",
            "487 SGO",
            "489 PLAN ADT",
            "490 PCS 100 VOZ s",
            "491 PCS 100 DATO s",
            "492 DEMO SMS EMPRESAS",
            "494 PLAN REDs",
            "495 PLAN CONVERSOR",
            "496 PLAN CONVERSOR",
            "497 RED CONVERSOR",
            "498 PLAN REDs",
            "510 ADT RESPALDO 10KB",
            "511 ADT RESPALDO 100KB",
            "512 ADT RESPALDO 200KB",
            "517 BAM EMPRESA",
            "518 M2M Cta. Optimizada",
            "519 BAM Empresas Pro",
            "520 BAM EMPRESA",
            "521 Plan Empresas Normal",
            "526 BAM Empresas Pro",
            "529 BAM Empresas Pro 1GB",
            "530 BAM 2GB EMP",
            "534 SGO",
            "534 SGOs",
            "536 SGO",
            "538 SGO",
            "539 PLAN DATOS M2M",
            "548 CPP EMPRESAS",
            "550 CPP EMPRESAS",
            "552 CPP EMPRESAS",
            "560 BAM 200kbps Nacional EMP",
            "570 SGO",
            "571 SGO",
            "573 SGO",
            "574 SGO",
            "575 SGO",
            "576 SGO",
            "577 SGO",
            "578 SGO",
            "579 SGO",
            "586 CPP EMPRESAS s",
            "587 CPP EMPRESAS s",
            "59 PCS 440s",
            "590 CPP EMPRESAS s",
            "591 CPP EMPRESAS s",
            "592 CPP EMPRESAS s",
            "593 CPP EMPRESAS s",
            "594 Mi Empresa SGO",
            "595 Mi Empresa SGO",
            "597 Mi Empresa SGO",
            "598 SGO",
            "601 SGO",
            "603 SGO",
            "606 SGO",
            "607 SGO",
            "613 INTEGRADOR",
            "614 SGO",
            "615 CONVERSOR",
            "616 CUENTA CONTROLADA",
            "617 CUENTA CONTROLADA",
            "618 CUENTA CONTROLADA",
            "619 CUENTA CONTROLADA",
            "620 CUENTA CONTROLADA",
            "621 Tarifa Plana",
            "622 Tarifa Plana",
            "623 Tarifa Plana",
            "624 Tarifa Plana",
            "625 Tarifa Plana",
            "626 SGO",
            "63 PLAN GLOBAL 80",
            "631 PLANO PLUS",
            "633 SGO",
            "639 BlackBerry Profesional Emp",
            "64 PLAN GLOBAL 120",
            "640 BlackBerry Corporativo",
            "641 BAM EMPRESA",
            "642 BAM EMPRESA",
            "643 TELEMETRIA 1",
            "644 TELEMETRIA 2",
            "645 LOCALIZACION ENTEL GPS",
            "646 LOC ENTEL GPS ILIMITADO",
            "647 LOCALIZACION ENTEL GPS",
            "65 PLAN GLOBAL 210",
            "654 CC 7000 RETENCION",
            "656 LOC ENTEL GPS",
            "657 LOC ENTELGPS ILIMITADO",
            "658 PLAN DATOS M2M RECARGA",
            "659 DATOS M2M INTEGRADORES",
            "663 RIDER",
            "665 SGO",
            "669 CC 9000 RETENCION",
            "67 PLAN GLOBAL 430",
            "670 TARIFA PLANA 400",
            "671 TARIFA PLANA 600",
            "672 TARIFA PLANA 1000",
            "68 PLAN GLOBAL 710",
            "681 CC 11500 RETENCION",
            "682 CUENTA CONTROLADA FLAT",
            "683 CUENTA CONTROLADA FLAT",
            "684 RIDER",
            "685 RIDER",
            "686 RIDER",
            "69 CUENTA CONTROLADA 15530",
            "690 DATOS",
            "691 DEMO OFICINA MOVIL",
            "693 BAM OPTIMO EMPRESA",
            "698 CC 14500 RETENCION",
            "699 CC 17500 RETENCION",
            "700 Plan Wherifone",
            "701 BAM EMPRESA",
            "703 BAM Pro DEALERS",
            "704 BAM Pro DEALERS",
            "705 BAM Pro DEALERS",
            "706 BAM MasConectado 3GB",
            "707 BAM MasConectado 6GB",
            "708 BAM",
            "708 BAM Empresas Pro 3GB",
            "709 BAM",
            "709 BAM Empresas Pro 6GB",
            "710 BAM Plan Router",
            "710 PLAN RED 440",
            "711 BAM XI,XII,IDP 400Kbps PER",
            "711 PLAN RED 660",
            "712 BAM Controlado 2 Gb",
            "712 PLAN RED 1100",
            "713 BAM Controlado 5GB",
            "714 BAM Controlado 7GB",
            "714 PLAN RED 1000",
            "716 BAM Controlado 500 Mb",
            "72 PCS GLOBAL s",
            "722 Tarifa Unica 170",
            "724 Tarifa Unica 450",
            "725 Tarifa Unica 700",
            "740 Todo Destino 150",
            "741 Todo Destino 230",
            "742 Todo Destino 300",
            "744 Todo Destino 750",
            "745 Todo Destino 1000",
            "750 ECORP 90",
            "751 ECORP 110 + 100 SMS",
            "756 ECORP CC 22450",
            "767 BAM Controlado 15GB",
            "768 BAM",
            "768 BAM 22 Mbps",
            "780 CUENTA CONTROLADA 24990",
            "8 Personal Promocion",
            "80 Plus 480s",
            "801 SGO",
            "806 VIP Camara 1",
            "807 VIP Camara 2",
            "813 CONSOLIDADO",
            "814 SGO",
            "815 SGO",
            "816 SGO",
            "818 SGO",
            "819 CONS0LIDADO",
            "819 SGO",
            "820 SGO",
            "822 SGO",
            "822 VIP RPV CPPs",
            "823 CONSOLIDADO",
            "825 SGO",
            "826 RED CONSOLIDADO",
            "826 SGO",
            "827 CONSOLIDADOs",
            "827 SGO",
            "829 SGO",
            "831 RED CONSOLIDADOs",
            "834 CUENTA OPTIMIZADA NO",
            "834 SGO CTA OPTIMIZADA NO",
            "840 SGO",
            "842 CONSOLIDADO s",
            "843 SGO",
            "844 SGO",
            "845 RED CONSOLIDADOs",
            "846 SGO",
            "847 CONSOLIDADO RED",
            "848 SGO",
            "849 CONSOLIDADO",
            "849 SGO",
            "850 SGO",
            "851 CONSOLIDADO INTRARED",
            "851 SGO",
            "852 CONSOLIDADO INTRARED",
            "852 SGO",
            "853 CONSOLIDADO INTRARED",
            "853 SGO",
            "854 CONSOLIDADO INTRARED",
            "854 SGO",
            "855 CONSOLIDADO INTRARED",
            "855 SGO",
            "856 CONSOLIDADO INTRARED",
            "856 SGO",
            "857 CONSOLIDADO INTRARED",
            "857 SGO",
            "858 CONSOLIDADO",
            "858 SGO",
            "859 CONSOLIDADO",
            "859 SGO",
            "860 SGO",
            "861 CONSOLIDADO",
            "861 SGO",
            "862 SGO",
            "863 SGO",
            "864 SGO",
            "865 SGO",
            "866 CONSOLIDADO INTRARED",
            "866 SGO",
            "867 CONSOLIDADO",
            "867 SGO",
            "868 RED CONSOLIDADO",
            "869 RED CONSOLIDADO",
            "870 SGO",
            "871 SGO",
            "874 SGO",
            "876 PLAN CONSOLIDADO SGO",
            "877 PLAN CONSOLIDADO SGO",
            "878 PLAN CONSOLIDADO SGO",
            "879 PLAN CONSOLIDADO SGO",
            "880 PLAN CONSOLIDADO SGO",
            "881 PLAN CONSOLIDADO SGO",
            "882 SGO",
            "883 SGO",
            "884 SGO",
            "885 SGO",
            "886 SGO",
            "887 SGO",
            "888 SGO",
            "889 SGO",
            "890 SGO",
            "891 SGO",
            "892 SGO",
            "895 SGO",
            "896 SGO",
            "897 SGO",
            "898 SGO",
            "899 SGO",
            "9 PCS 100",
            "900 SGO",
            "Cta. Controlada Plana $10.500",
            "Cta. Controlada Plana $12.990",
            "Cta. Controlada Plana $15.990",
            "Cta. Controlada Plana $19.500",
            "DEMO SMS EMPRESAs",
            "Empresa Ges Datos 1,5GB",
            "Empresa Ges Datos 10GB +",
            "Empresa Ges Datos 160MBCP",
            "Empresa Ges Datos 1GB",
            "Empresa Ges Datos 1GB RET",
            "Empresa Ges Datos 2GB",
            "Empresa Ges Datos 2GBND",
            "Empresa Ges Datos 3GB +",
            "Empresa Ges Datos 400MB",
            "Empresa Ges Datos 4GB +",
            "Empresa Ges Datos 600MB",
            "Empresa Ges Datos 6GB +",
            "Empresa Ges Datos 8GB +",
            "Empresa Smartphone 10GB",
            "Empresa Smartphone 1GB",
            "Empresa Smartphone 2GB",
            "Empresa Smartphone 3GB",
            "Empresa Smartphone 4GB",
            "Empresa Smartphone 6GB",
            "Empresa Smartphone 8GB",
            "FA200 FACT DIFEREN 200",
            "FA400 FACT DIFEREN 400",
            "FA800 FACT DIFEREN 800",
            "FB100 FACT DIFEREN 100",
            "FB200 FACT DIFEREN 200",
            "FB250 FACT DIFEREN 250",
            "FB300 FACT DIFEREN 300",
            "FB800 FACT DIFEREN 800",
            "FC100 FACT DIFEREN 100",
            "FE500 FACT DIFEREN 500",
            "GPS Lite Autoinstalable",
            "GPS Lite Instalable",
            "M2M BAJO TRAFICO",
            "M2M ILIMITADO",
            "M2M TRAFICO MEDIO",
            "ME 1000 SGO",
            "ME 1500 SGO",
            "ME 2000 SGO",
            "ME 3000 SGO",
            "ME 4000 SGO",
            "ME 500 SGO",
            "ME 5000 SGO",
            "ME 600 SGO",
            "ME 6000 SGO",
            "MM Pruebas CC 16.990",
            "Plan ADT 120 SMS",
            "Plan ADT 37 SMS",
            "Plan ADT 80 SMS",
            "Plan Canje 400",
            "PLAN CC QUADRANTE",
            "PLAN DEMO ROAMING",
            "PLAN DEMOSTRACION",
            "Plan EntelGPS Avanzado",
            "Plan EntelGPS Basico",
            "Plan Mobile Cam",
            "Plan Repetidor",
            "PLAN VIAJERO CC",
            "Z_NoUso_1460 M2M Corp Sens",
            "Z_NoUso_PORT_Emp Ges Dat 4GB +"});
            this.comboPlan.Location = new System.Drawing.Point(46, 318);
            this.comboPlan.Name = "comboPlan";
            this.comboPlan.Size = new System.Drawing.Size(223, 21);
            this.comboPlan.TabIndex = 99;
            // 
            // campoMMF
            // 
            this.campoMMF.Location = new System.Drawing.Point(46, 221);
            this.campoMMF.Name = "campoMMF";
            this.campoMMF.Size = new System.Drawing.Size(117, 20);
            this.campoMMF.TabIndex = 98;
            // 
            // campoDonante
            // 
            this.campoDonante.Location = new System.Drawing.Point(46, 172);
            this.campoDonante.Name = "campoDonante";
            this.campoDonante.Size = new System.Drawing.Size(117, 20);
            this.campoDonante.TabIndex = 97;
            // 
            // campoCuenta
            // 
            this.campoCuenta.Location = new System.Drawing.Point(46, 122);
            this.campoCuenta.Name = "campoCuenta";
            this.campoCuenta.Size = new System.Drawing.Size(137, 20);
            this.campoCuenta.TabIndex = 96;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 95;
            this.label12.Text = "Plan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Fecha a portar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "MMF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Empresa donante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Cuenta";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(586, 450);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(137, 23);
            this.btnGrabar.TabIndex = 90;
            this.btnGrabar.Text = "Copiar MAD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(586, 389);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 89;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // comboEjecutivo
            // 
            this.comboEjecutivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEjecutivo.FormattingEnabled = true;
            this.comboEjecutivo.Items.AddRange(new object[] {
            "Andrea Hinojosa G.",
            "Angelica Silva S.",
            "Carol Rios G.",
            "Carolina Arellano D.",
            "Carolina Ayal E.",
            "Catherine Torres B.",
            "Claudia Sola G.",
            "Danitza Leyton M.",
            "Danitza Rendich O.",
            "Elizabeth Pavez S.",
            "Felipe Figueroa L.",
            "Francisca Garcia B.",
            "Francisco Castillo S.",
            "Javier Beroiza A.",
            "Javiera Molina G.",
            "Julia Dominguez L.",
            "Kimberly Moraga G.",
            "Lorena Garcia N.",
            "Lorena Jiménez M.",
            "Loreto Barriga R.",
            "Luz Gaete Ch.",
            "Maria Jose Marchant V.",
            "María Loreto Caceres A.",
            "Maria Renata Ramirez A.",
            "Mario Santibañez M.",
            "Matias Brito A.",
            "Mirtha Castro C.",
            "Paloma Parra G.",
            "Paula Sola G.",
            "Sandra Lazcano A.",
            "Simon Segura B.",
            "Vladimir Cubillos R."});
            this.comboEjecutivo.Location = new System.Drawing.Point(426, 391);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(125, 21);
            this.comboEjecutivo.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Datos de contacto";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(28, 389);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(168, 96);
            this.campoDatos.TabIndex = 85;
            this.campoDatos.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "RUT Cliente";
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(96, 67);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 83;
            // 
            // lblNomProy
            // 
            this.lblNomProy.AutoSize = true;
            this.lblNomProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProy.Location = new System.Drawing.Point(527, 40);
            this.lblNomProy.Name = "lblNomProy";
            this.lblNomProy.Size = new System.Drawing.Size(100, 13);
            this.lblNomProy.TabIndex = 81;
            this.lblNomProy.Text = "PORTA MASIVO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "PORTABILIDAD (MASIVO)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            // 
            // btnPlanilla
            // 
            this.btnPlanilla.Location = new System.Drawing.Point(378, 157);
            this.btnPlanilla.Name = "btnPlanilla";
            this.btnPlanilla.Size = new System.Drawing.Size(222, 107);
            this.btnPlanilla.TabIndex = 125;
            this.btnPlanilla.Text = "CREAR PLANILLA";
            this.btnPlanilla.UseVisualStyleBackColor = true;
            this.btnPlanilla.Click += new System.EventHandler(this.btnPlanilla_Click);
            // 
            // lblFraude
            // 
            this.lblFraude.AutoSize = true;
            this.lblFraude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraude.ForeColor = System.Drawing.Color.Red;
            this.lblFraude.Location = new System.Drawing.Point(277, 67);
            this.lblFraude.Name = "lblFraude";
            this.lblFraude.Size = new System.Drawing.Size(406, 13);
            this.lblFraude.TabIndex = 167;
            this.lblFraude.Text = "Recordar: negocios se realizaran en separado por modelos de equipos";
            // 
            // VentMPORTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 508);
            this.Controls.Add(this.lblFraude);
            this.Controls.Add(this.btnPlanilla);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.campoFecha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.campoServicios);
            this.Controls.Add(this.comboPlan);
            this.Controls.Add(this.campoMMF);
            this.Controls.Add(this.campoDonante);
            this.Controls.Add(this.campoCuenta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.lblNomProy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentMPORTA";
            this.Text = "PORTABILIDAD MASIVO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker campoFecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox campoServicios;
        private System.Windows.Forms.ComboBox comboPlan;
        private System.Windows.Forms.TextBox campoMMF;
        private System.Windows.Forms.TextBox campoDonante;
        private System.Windows.Forms.TextBox campoCuenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox campoDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.Label lblNomProy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlanilla;
        private System.Windows.Forms.Label lblFraude;
    }
}