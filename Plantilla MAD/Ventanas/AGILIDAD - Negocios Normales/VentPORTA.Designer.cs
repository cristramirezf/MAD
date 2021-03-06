﻿namespace Plantilla_MAD.Ventanas
{
    partial class VentPORTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentPORTA));
            this.label5 = new System.Windows.Forms.Label();
            this.campoDatos = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPorta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataPorta = new System.Windows.Forms.DataGridView();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.campoCuenta = new System.Windows.Forms.TextBox();
            this.campoDonante = new System.Windows.Forms.TextBox();
            this.campoMMF = new System.Windows.Forms.TextBox();
            this.comboPlan = new System.Windows.Forms.ComboBox();
            this.campoRUT = new System.Windows.Forms.TextBox();
            this.campoServicios = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.campoFecha = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopiaModelo = new System.Windows.Forms.Button();
            this.btnCopiaValor = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.campoObs = new System.Windows.Forms.RichTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCopiaProy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEjecutivo = new System.Windows.Forms.ComboBox();
            this.lblFraude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPorta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Datos de contacto";
            // 
            // campoDatos
            // 
            this.campoDatos.Location = new System.Drawing.Point(28, 433);
            this.campoDatos.Name = "campoDatos";
            this.campoDatos.Size = new System.Drawing.Size(155, 106);
            this.campoDatos.TabIndex = 28;
            this.campoDatos.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "RUT Cliente";
            // 
            // labelPorta
            // 
            this.labelPorta.AutoSize = true;
            this.labelPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorta.Location = new System.Drawing.Point(566, 36);
            this.labelPorta.Name = "labelPorta";
            this.labelPorta.Size = new System.Drawing.Size(49, 13);
            this.labelPorta.TabIndex = 22;
            this.labelPorta.Text = "PORTA";
            this.labelPorta.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Y el nombre de proyecto debe ser";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Venta/Post-Venta Servicios Móviles - PCE";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Esta solicitud debe ser ingresada a través de ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PORTABILIDAD";
            // 
            // dataPorta
            // 
            this.dataPorta.AllowUserToResizeRows = false;
            this.dataPorta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPorta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPorta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movil,
            this.Modelo,
            this.Valor});
            this.dataPorta.Location = new System.Drawing.Point(339, 117);
            this.dataPorta.Name = "dataPorta";
            this.dataPorta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataPorta.Size = new System.Drawing.Size(392, 272);
            this.dataPorta.TabIndex = 23;
            this.dataPorta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPorta_CellClick);
            this.dataPorta.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPorta_CellClick);
            this.dataPorta.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPorta_RowLeave);
            this.dataPorta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataPorta_RowsRemoved);
            // 
            // Movil
            // 
            this.Movil.HeaderText = "Móvil";
            this.Movil.Name = "Movil";
            this.Movil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Movil.Width = 70;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo/Serie";
            this.Modelo.Name = "Modelo";
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.Width = 200;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor Neto";
            this.Valor.Name = "Valor";
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.Width = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cuenta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Empresa donante";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "MMF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Fecha a portar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Plan";
            // 
            // campoCuenta
            // 
            this.campoCuenta.Location = new System.Drawing.Point(46, 124);
            this.campoCuenta.Name = "campoCuenta";
            this.campoCuenta.Size = new System.Drawing.Size(137, 20);
            this.campoCuenta.TabIndex = 40;
            // 
            // campoDonante
            // 
            this.campoDonante.Location = new System.Drawing.Point(46, 174);
            this.campoDonante.Name = "campoDonante";
            this.campoDonante.Size = new System.Drawing.Size(117, 20);
            this.campoDonante.TabIndex = 41;
            // 
            // campoMMF
            // 
            this.campoMMF.Location = new System.Drawing.Point(46, 223);
            this.campoMMF.Name = "campoMMF";
            this.campoMMF.Size = new System.Drawing.Size(117, 20);
            this.campoMMF.TabIndex = 42;
            // 
            // comboPlan
            // 
            this.comboPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlan.FormattingEnabled = true;
            this.comboPlan.Items.AddRange(new object[] {
            "--",
            "1 ECONOMICO POS",
            "10 PCS 200",
            "100 CUENTA CONTROLADA 15950",
            "104 PLAN GLOBAL 65",
            "1050 MULTIMEDIA 115",
            "1051 MULTIMEDIA 140",
            "1052 MULTIMEDIA 200",
            "1053 MULTIMEDIA 300",
            "1054 MULTIMEDIA 420",
            "1055 MULTIMEDIA 500",
            "1056 MULTIMEDIA 800",
            "1057 MULTIMEDIA RED 800",
            "1058 MULTIMEDIA RED 1200",
            "1059 BAM CHILE COMUNICADO 1MBP",
            "1061 BAM MULTIMEDIA 3GB",
            "1062 BAM EMPRESAS PRO 1GB RE",
            "1063 BAM EMPRESAS PRO 3GB RE",
            "1069 BLACKBERRY MULTIMEDIA 500",
            "107 BAM",
            "1073 MULTIMEDIA RED TOTAL 20",
            "1074 MULTIMEDIA RED TOTAL 50",
            "1075 MULTIMEDIA RED TOTAL 50 P",
            "1076 MULTIMEDIA RED TOTAL 100",
            "1077 MULTIMEDIA RED TOTAL 200",
            "1078 MULTIMEDIA RED TOTAL 500",
            "108 CUENTA CONTROLADA 13740",
            "11 PCS 300",
            "112 PLAN TARIFA UNICA 300",
            "1129 M2M ILIMITADO",
            "113 PLAN TARIFA UNICA 100",
            "114 PLAN TARIFA UNICA 200",
            "115 PLAN TARIFA UNICA 400",
            "116 PLAN TARIFA UNICA 600",
            "117 TARIFA UNICA JOVEN",
            "118 TARIFA UNICA 70",
            "120 BAM",
            "1207 MI PYME 2",
            "121 BAM",
            "1219 PLAN BLACKBERRY RED 770",
            "122 PLAN TARIFA UNICA 55",
            "1221 MI PYME 3",
            "1222 MI PYME 4",
            "1223 MI PYME 5",
            "1224 MI PYME 6",
            "1225 MI PYME 7",
            "1226 MI PYME 8",
            "1227 MI PYME 9",
            "1228 MI PYME 10",
            "1229 MI PYME 11",
            "1230 MI PYME 12",
            "1231 MI PYME 13",
            "1232 MI PYME 14",
            "1233 MI PYME 15",
            "1234 MI PYME 20",
            "1235 MI PYME 25",
            "1236 MI PYME 30",
            "1239 MI PYME SMARTPHONE 500",
            "124 CUENTA CONTROLADA 15950",
            "1241 MI PYME BLACKBERRY 250",
            "125 CUENTA CONTROLADA 18150",
            "1252 BLACKBERRY MULTIMEDIA 100",
            "1253 MULTIMEDIA 100",
            "126 CUENTA CONTROLADA 22000",
            "1261 BAM CONTROLADO 7GB",
            "1262 BAM CONTROLADO 15GB",
            "1263 BAM CONTROLADO 1GB",
            "1270 BAM CONTROLADO 2GB",
            "1328 BAM EMPRESAS 2GB",
            "1329 BAM EMPRESAS 3GB",
            "1330 BAM EMPRESAS 5GB",
            "1331 BAM EMPRESAS 10G",
            "1331 BAM EMPRESAS PRO 10GB",
            "1332 BAM EMPRESAS 1GB",
            "1336 BAM EMPRESAS 2G",
            "1336 BAM EMPRESAS PRO 2G",
            "1337 BAM EMPRESAS 4G",
            "1337 BAM EMPRESAS PRO 4GB",
            "1338 BAM EMPRESAS 6G",
            "1338 BAM EMPRESAS PRO 6GB",
            "1339 BAM EMPRESAS PRO 15GB",
            "1339 BAM EMPRESAS15G",
            "1340 MULTIMEDIA 1000",
            "14 PCS MPP 400",
            "1402 MULTIMEDIA CC 13.990",
            "141 CUENTA CONTROLADA 27500",
            "1425 MULTIMEDIA RED 150",
            "1426 MULTIMEDIA RED 270",
            "1442 MI PYME SMARTPHONE 800",
            "1443 MI PYME SMARTPHONE 1.000",
            "1444 MI PYME CORREO 100",
            "1445 SMARTPHONE TD 200",
            "1446 SMARTPHONE TD 320",
            "1447 SMARTPHONE TD 500",
            "1448 SMARTPHONE TD 1000",
            "145 TARIFA UNICA 200 + 30 SMS",
            "1452 BAM PRO 4GB NORMAL",
            "1453 BAM PRO 8GB NORMAL",
            "1454 BAM PRO 12GB NORMAL",
            "1455 BAM PRO 20GB NORMAL",
            "1456 BAM PRO 30GB NORMAL",
            "1461 M2M CORPORACIONES SENS",
            "1466 MULTIMEDIA RED 500",
            "1467 MULTIMEDIA RED 1000",
            "1470 MULTIMEDIA FULL 1.5 GB",
            "1471 MULTIMEDIA FULL 2 GB",
            "1471 MULTIMEDIA FULL 2 GB",
            "1472 MULTIMEDIA FULL 3 GB",
            "1472 MULTIMEDIA FULL 3 GB",
            "1473 MULTIMEDIA FULL 4.5 GB",
            "1473 MULTIMEDIA FULL 4.5 GB",
            "1474 MULTIMEDIA FULL 6 GB",
            "1474 MULTIMEDIA FULL 6 GB",
            "1475 MULTIMEDIA FULL 7.5 GB",
            "1475 MULTIMEDIA FULL 7.5 GB",
            "1476 MULTIMEDIA FULL 10 GB",
            "1477 MULTIMEDIA RED FULL 1 GB",
            "1480 M2M CORPORACIONES GAMM",
            "1488 MULTIMEDIA CC 16.990",
            "1489 MULTIMEDIA CC $20.990",
            "1489 MULTIMEDIA CC 20.990",
            "1490 MI EMPRESA SMARTPHONE 5",
            "1491 MI EMPRESA SMARTPHONE 6",
            "1492 MI EMPRESA SMARTPHONE 7",
            "1493 MI EMPRESA SMARTPHONE 8",
            "1494 MI EMPRESA SMARTPHONE 9",
            "1495 MI EMPRESA SMARTPHONE 10",
            "1496 MI EMPRESA SMARTPHONE 15",
            "1497 MI EMPRESA SMARTPHONE 20",
            "1498 MI EMPRESA SMARTPHONE 30",
            "1499 EMPRESA SMARTPHONE PRO5",
            "15 PCS 800",
            "15 PCS 800 R",
            "1500 EMPRESA SMARTPHONE PRO6",
            "1501 EMPRESA SMARTPHONE PRO7",
            "1502 EMPRESA SMARTPHONE PRO8",
            "1503 EMPRESA SMARTPHONE PRO9",
            "1504 EMPRESA SMARTPHONE PRO10",
            "1514 CTA CONTROLADA $17.500",
            "1520 CTA. CONTROLADA $6.900",
            "1521 ACCESO XG 1",
            "1522 ACCESO XG 2",
            "1523 BAM CONTROLADO CORP 6GB",
            "1524 BAM CONTROLADO CORP 12GB",
            "1525 BAM CONTROLADO CORP 18GB",
            "1526 BAM CONTROLADO CORP 30GB",
            "1527 BAM CONTROLADO CORP 45GB",
            "1528 BAM CONTROLADO CORP 90GB",
            "1529 M2M ALTO",
            "1535 M2M BAJO",
            "1536 M2M MEDIO",
            "1539 MULTIMEDIA CTA CDA $6.990",
            "1540 MULTIMEDIA CTA CDA $9.990",
            "1541 MULTIMEDIA CTA CDA $12.990",
            "1542 MULTIMEDIA CTA CDA $14.990",
            "1543 MI PRIMER MULTI $6.990",
            "1544 MI PRIMER MULTI. $9.990",
            "1556 TODO DESTINO 280",
            "1559 DATOS EMPRESA 2GB",
            "1560 DATOS EMPRESA 4GB",
            "1561 DATOS EMPRESA 10GB",
            "1568 PLAN ALTO TRAFICO 8.000",
            "1569 PLAN ALTO TRAFICO 5.000",
            "1570 PLAN ALTO TRAFICO 2.000",
            "1571 PLAN ALTO TRAFICO 500",
            "1573 AUTOGESTION PLUS 600MB 36",
            "1574 AUTOGESTION PLUS 600MB 34",
            "1575 AUTOGESTION PLUS 600MB 32",
            "1576 AUTOGESTION PLUS 600MB 30",
            "1576 AUTOGESTION PLUS 600MB 30?",
            "1577 AUTOGESTION PLUS 600MB 28",
            "1578 AUTOGESTION PLUS 600MB 26",
            "1579 AUTOGESTION PLUS 600MB 24",
            "1580 AUTOGESTION PLUS 600MB 22",
            "1581 AUTOGESTION PLUS 600MB 20",
            "1582 AUTOGESTION PLUS 600MB 18",
            "1583 AUTOGESTION PLUS 2GB 36",
            "1584 AUTOGESTION PLUS 2GB 34",
            "1585 AUTOGESTION PLUS 2GB 32",
            "1586 AUTOGESTION PLUS 2GB 30",
            "1587 AUTOGESTION PLUS 2GB 28",
            "1588 AUTOGESTION PLUS 2GB 26",
            "1589 AUTOGESTION PLUS 2GB 24",
            "1590 AUTOGESTION PLUS 2GB 22",
            "1591 AUTOGESTION PLUS 2GB 20",
            "1592 AUTOGESTION PLUS 2GB 18",
            "1594 BAM EMPRESAS 8 GB",
            "1595 BAM EMPRESAS 12 GB",
            "1596 BAM EMPRESAS 16 GB",
            "1597 BAM EMPRESAS 1 GB RET",
            "1606 MULTIMEDIA CTA CDA $17.990",
            "1614 VOZ ILIMITADA",
            "162 CTA CONTROLADA LIBRE 16500",
            "1624 CTA. CONTROLADA $13.900",
            "1625 CTA CONTROLADA $8.900",
            "1630 BAM CC 400 MB",
            "1631 BAM CC 600 MB",
            "1633 BAM CC 1 GB",
            "1635 BAM CC 1,5 GB",
            "1636 BAM CC 2 GB",
            "1637 BAM CC 3,5 GB",
            "1638 BAM CC 5 GB",
            "1639 BAM CC 6,5 GB",
            "164 CTA CONTROLADA LIBRE 22000",
            "1640 BAM CC 10 GB",
            "1641 BAM CC 8 GB",
            "1643 BAM MI PRIMER PLAN 400MB",
            "1644 BAM MI PRIMER PLAN 600MB",
            "165 CTA CONTROLADA LIBRE 27500",
            "1652 MULTI SMART 2 GB $25.990",
            "1653 MULTI SMART 3 GB $29.990",
            "1654 MULTI SMART 4.5 GB $39.990",
            "1655 MULTI SMART 6 GB $49.990",
            "1656 MULTI SMART 7.5 GB $59.990",
            "1657 MULTI SMART 10 GB $69.990",
            "166 TARIFA UNICA 60",
            "1663 AUTOGESTION PLUS 36",
            "1664 AUTOGESTION PLUS 34",
            "1665 AUTOGESTION PLUS 18",
            "1665 AUTOGESTION PLUS 20",
            "1665 AUTOGESTION PLUS 22",
            "1665 AUTOGESTION PLUS 24",
            "1665 AUTOGESTION PLUS 26",
            "1665 AUTOGESTION PLUS 28",
            "1665 AUTOGESTION PLUS 30",
            "1665 AUTOGESTION PLUS 32",
            "1666 AUTOGESTION PLUS 30",
            "1667 AUTOGESTION PLUS 28",
            "1668 AUTOGESTION PLUS 26",
            "1669 AUTOGESTION PLUS 24",
            "1670 AUTOGESTION PLUS 22",
            "1671 AUTOGESTION PLUS 20",
            "1672 AUTOGESTION PLUS 18",
            "1673 AUTOGESTION PLUS 1GB 36",
            "1674 AUTOGESTION PLUS 1GB 34",
            "1675 AUTOGESTION PLUS 1GB 32",
            "1676 AUTOGESTION PLUS 1GB 30",
            "1677 AUTOGESTION PLUS 1GB 28",
            "1678 AUTOGESTION PLUS 1GB 26",
            "1679 AUTOGESTION PLUS 1GB 24",
            "168 TARIFA UNICA 120",
            "1680 AUTOGESTION PLUS 1GB 22",
            "1681 AUTOGESTION PLUS 1GB 20",
            "1682 AUTOGESTION PLUS 1GB 18",
            "1683 AUTOGESTION PLUS 1.5GB 36",
            "1684 AUTOGESTION PLUS 1.5GB 34",
            "1685 AUTOGESTION PLUS 1.5GB 32",
            "1686 AUTOGESTION PLUS 1.5GB 30",
            "1687 AUTOGESTION PLUS 1.5GB 28",
            "1688 AUTOGESTION PLUS 1.5GB 26",
            "1689 AUTOGESTION PLUS 1.5GB 24",
            "1690 AUTOGESTION PLUS 1.5GB 22",
            "1691 AUTOGESTION PLUS 1.5GB 20",
            "1692 AUTOGESTION PLUS 1.5GB 18",
            "1693 AUTOGESTION PLUS 3GBFULL",
            "1694 AUTOGESTION PLUS 4GBFULL",
            "1695 AUTOGESTION PLUS 6GBFULL",
            "1696 AUTOGESTION PLUS 8GBFULL",
            "1697 AUTOGESTION PLUS 10GBFULL",
            "1698 AUTOGESTION PLUS 12GBFULL",
            "170 PLAN TARIFA UNICA 400",
            "171 PLAN TARIFA UNICA 600",
            "1734 M2M CONTINGENCIA MINSAL",
            "1735 MULTIMEDIA CC 15.990",
            "1738 BAM PRO 2GB CORP 18",
            "1739 BAM PRO 4GB CORP 18",
            "1740 BAM PRO 6GB CORP 18",
            "1741 BAM PRO 8GB CORP 18",
            "1742 BAM PRO 10GB CORP 18",
            "1743 AUTOGESTION PLUS 38",
            "1744 AUTOGESTION PLUS 40",
            "1745 AUTOGESTION PLUS 42",
            "1746 AUTOGESTION PLUS 44",
            "1747 AUTOGESTION PLUS 600MB 38",
            "1748 AUTOGESTION PLUS 600MB 40",
            "1749 AUTOGESTION PLUS 600MB 42",
            "1750 AUTOGESTION PLUS 600MB 44",
            "1751 AUTOGESTION PLUS 1GB 38",
            "1752 AUTOGESTION PLUS 1GB 40",
            "1753 AUTOGESTION PLUS 1GB 42",
            "1754 AUTOGESTION PLUS 1GB 44",
            "1755 AUTOGESTION PLUS 1.5GB 38",
            "1756 AUTOGESTION PLUS 1.5GB 40",
            "1757 AUTOGESTION PLUS 1.5GB 42",
            "1758 AUTOGESTION PLUS 1.5GB 44",
            "1759 AUTOGESTION PLUS 2GB 38",
            "1760 AUTOGESTION PLUS 2GB 40",
            "1761 AUTOGESTION PLUS 2GB 42",
            "1762 AUTOGESTION PLUS 2GB 44",
            "1763 BAM CC 3 GB",
            "1764 M2M UBI UNO",
            "181 CUENTA CONTROLADA RED",
            "182 CUENTA CONTROLADA RED",
            "183 CUENTA CONTROLADA RED",
            "184 CUENTA CONTROLADA RED",
            "185 CTA CONTROLADA PLANO 11000",
            "1850 AUTOGESTION PLUS 600MB",
            "1851 AUTOGESTION PLUS 1GB",
            "1852 AUTOGESTION PLUS 1,5GB",
            "1853 AUTOGESTION PLUS 2GB",
            "1854 AUTOGESTION PLUS 3GB",
            "1855 AUTOGESTION PLUS 4GB",
            "1856 AUTOGESTION PLUS 6GB",
            "1857 AUTOGESTION PLUS 8GB",
            "1858 AUTOGESTION PLUS 10GB",
            "1859 AUTOGESTION PLUS 12GB",
            "186 CTA CONTROLADA PLANO 13690",
            "1860 AUTOGESTION PLUS 16GB",
            "1861 AUTOGESTION PLUS 20GB",
            "187 CTA CONTROLADA PLANO 16490",
            "188 CTA CONTROLADA PLANO 21990",
            "189 CTA CONTROLADA PLANO 27390",
            "190 TARIFA UNICA 85",
            "191 TARIFA UNICA 150",
            "192 TARIFA UNICA 250",
            "194 TARIFA UNICA 150",
            "195 TARIFA UNICA 250",
            "1952 AUTOGESTION ULTRA 2GB",
            "1954 AUTOGESTION ULTRA 3GB",
            "1955 AUTOGESTION ULTRA 6GB",
            "1956 AUTOGESTION ULTRA 8GB",
            "196 PLAN UNICO 4290",
            "1971 CORP SMART SE 1GB",
            "1972 CORP SMART SE 3GB",
            "1973 CORP SMART SE 5GB",
            "1974 CORP SMART SE 8GB",
            "1975 CORP SMART SE 12GB",
            "1976 CORP SMART SE 20GB",
            "1977 CORP SMART SE 30GB",
            "1978 CORP SMART SE HD",
            "1979 CORP SMART 1GB",
            "1980 CORP SMART 3GB",
            "1981 CORP SMART 5GB",
            "1982 CORP SMART 8GB",
            "1983 CORP SMART 12GB",
            "1984 CORP SMART 16GB",
            "1985 CORP SMART 20GB",
            "1986 CORP SMART 30GB",
            "1987 CORP SMART HD",
            "1998 AUTOGESTION ULTRA MMF 1GB",
            "1999 AUTOGESTION ULTRA 1GB",
            "2 SUPERECONOMICO POS",
            "2000 AUTOGESTION ULTRA MMF 2GB",
            "2001 AUTOGESTION ULTRA 4GB",
            "2003 AUTOGESTION ULTRA 12GB",
            "2004 AUTOGESTION ULTRA 16GB",
            "2005 AUTOGESTION ULTRA 30GB",
            "2030 CONVIENE VOZ",
            "2031 PLAN CONVIENE 10GB",
            "2032 PLAN CONVIENE 20GB",
            "2033 PLAN CONVIENE 30GB",
            "2034 PLAN CONVIENE 15GB",
            "2035 PLAN CONVIENE 25GB",
            "2036 PLAN CONVIENE 35GB",
            "2037 CONVIENE ILIMITADO",
            "2038 PLAN PUENTE",
            "2050 EMP CONECTADA PRO",
            "2058 AUTOGESTIÓN ULTRA 10GB",
            "2059 AUTOGESTIÓN ULTRA SE MMF 1GB",
            "2060 AUTOGESTIÓN ULTRA SE 1GB",
            "2061 AUTOGESTIÓN ULTRA SE MMF 2GB",
            "2062 AUTOGESTIÓN ULTRA SE 2GB",
            "2063 AUTOGESTIÓN ULTRA SE 3GB",
            "2064 AUTOGESTIÓN ULTRA SE 4GB",
            "2065 AUTOGESTIÓN ULTRA SE 6GB",
            "2066 AUTOGESTIÓN ULTRA SE 8GB",
            "2067 AUTOGESTIÓN ULTRA SE 10GB",
            "2068 AUTOGESTIÓN ULTRA SE 12GB",
            "2069 AUTOGESTIÓN ULTRA SE 16GB",
            "2070 AUTOGESTIÓN ULTRA SE 30GB",
            "2086 CONVIENE VOZ RRSS",
            "2094 CORP MAS SE 1GB",
            "2095 CORP MAS SE 5GB",
            "2096 CORP MAS SE 10GB",
            "2097 CORP MAS SE 15GB",
            "2098 CORP MAS SE 20GB",
            "2099 CORP MAS SE 30GB",
            "2100 CORP MAS SE 40GB",
            "2101 CORP MAS SE HD",
            "2102 CORP MAS 5GB",
            "2103 CORP MAS 10GB",
            "2104 CORP MAS 15GB",
            "2105 CORP MAS 20GB",
            "2106 CORP MAS 30GB",
            "2107 CORP MAS 40GB",
            "2108 CORP MAS HD",
            "2117 EMP. EXTRA PRO",
            "2118 EMP. EXTRA PRO",
            "2119 EMP. EXTRA PRO",
            "2120 EMP. EXTRA PRO",
            "2121 EMP. EXTRA PRO",
            "2130 BAM EMPRESAS PLUS 12 GB",
            "2131 BAM EMPRESAS PLUS 20 GB",
            "2132 BAM EMPRESAS PLUS 35 GB",
            "2133 BAM EMPRESAS PLUS 60 GB",
            "2134 BAM EMPRESAS PLUS 80 GB",
            "2135 BAM EMPRESAS PLUS 100 GB",
            "2136 BAM EMPRESAS PLUS 120 GB",
            "2138 PLAN CONVIENE VOZ RET",
            "2139 PLAN CONVIENE 10GB RET",
            "2140 PLAN CONVIENE 20GB RET",
            "2141 PLAN CONVIENE 30GB RET",
            "2142 PLAN CONVIENE 15GB RET",
            "2143 PLAN CONVIENE 25GB RET",
            "2144 PLAN CONVIENE 35GB RET",
            "2145 CONVIENE LIBRE RET",
            "2146 CONVIENE VOZ RRSS RET",
            "2165 CONVIENE LIBRE HD",
            "2175 CORP PRO VOZ 300 SE",
            "2176 CORP PRO VOZ LIBRE SE",
            "2185 CORP PRO SILVER SE",
            "2186 CORP PRO GOLD SE",
            "2187 CORP PRO BLACK SE",
            "2204 CONVIENE MAS VOZ",
            "2206 CONVIENE MAS 15GB",
            "2207 CONVIENE MAS 25GB",
            "2208 CONVIENE MAS 35GB",
            "2210 EMPRESA EXTRA 10 GB SIM",
            "2215 CORP PRO 15 GB SE",
            "2216 CORP PRO 30 GB SE",
            "2217 CORP PRO 45 GB SE",
            "2218 CORP PRO VOZ 300",
            "2219 CORP PRO VOZ LIBRE",
            "2220 CORP PRO 15 GB",
            "2221 CORP PRO 30 GB",
            "2222 CORP PRO 45 GB",
            "2223 CORP PRO SILVER",
            "2224 CORP PRO GOLD",
            "2225 CORP PRO BLACK",
            "2227 CORP PRO CC 2 GB 600 MIN",
            "2228 CORP PRO MM 5 GB",
            "2229 CORP PRO MM 15 GB",
            "2230 CORP PRO CC 2GB 600MIN SE",
            "2231 CORP PRO MM 5 GB SE",
            "2232 CORP PRO MM 20 GB SE",
            "213 BAM CONTROLADO 1,5GB",
            "214 BAM CONTROLADO 3GB",
            "218 BAM MASCONECTADO 1GB",
            "246 BAM 700KBPS NETBOOK",
            "260 BAM XI,XII,IDP 200KBPS PER",
            "261 BAM XI,XII,IDP 700KBPS PER",
            "262 BAM MASCONECTADO 10GB",
            "290 CTA CONTROLADA RED 6990",
            "291 CTA CONTROLADA RED 8990",
            "292 CTA CONTROLADA RED 11990",
            "307 ECORP 5400 SEGUNDOS",
            "308 ECORP 24000 SEGUNDOS",
            "310 ECORP 96000S",
            "313 ECORP 7200 SEGUNDOS",
            "314 ECORP 14400 SEGUNDOS",
            "323 ECORPS",
            "327 AFINIDAD CTA CONTROLADA 1",
            "331 ECORP VIP 100",
            "334 ECORP VIP 600",
            "335 ECORP VIP 800",
            "336 ECORP VIP 1000",
            "337 ECORP VIP 1500",
            "338 ECORP CC",
            "339 ECORP 15450",
            "340 ECORP CC",
            "35 PCS 60S",
            "36 PCS 1200S",
            "361 ECORP 210",
            "363 ECORP 480",
            "4 PROMEDIO",
            "400 PCS RENT CPP",
            "401 PCS RENT MPP",
            "403 PCS RENT MPP",
            "404 PCS RENT MPP",
            "405 DATOS",
            "405 PLAN PCS RENT CPP",
            "406 M2M EMPRESA",
            "408 TELEMETRIA",
            "410 PLAN SMS RED",
            "412 SMS WEB",
            "413 PLAN DEMO LOCALIZACION",
            "414 LOCALIZACION ENTEL GPS",
            "415 LOCALIZACION ENTEL GPS",
            "416 SMS EMPRESAS",
            "417 M2M EMPRESA",
            "44 RED PCS 80 S",
            "448 CUENTA OPTIMIZADA",
            "449 SUPER P. OPTIMIZACION RED",
            "460 PLAN OPTIMIZACION RPV",
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
            "490 PCS 100 VOZ S",
            "491 PCS 100 DATO S",
            "492 DEMO SMS EMPRESAS",
            "494 PLAN REDS",
            "495 PLAN CONVERSOR",
            "496 PLAN CONVERSOR",
            "497 RED CONVERSOR",
            "498 PLAN REDS",
            "510 ADT RESPALDO 10KB",
            "511 ADT RESPALDO 100KB",
            "512 ADT RESPALDO 200KB",
            "517 BAM EMPRESA",
            "518 M2M CTA. OPTIMIZADA",
            "519 BAM EMPRESAS PRO",
            "520 BAM EMPRESA",
            "521 PLAN EMPRESAS NORMAL",
            "526 BAM EMPRESAS PRO",
            "529 BAM EMPRESAS PRO 1GB",
            "530 BAM 2GB EMP",
            "534 SGO",
            "534 SGOS",
            "536 SGO",
            "538 SGO",
            "539 PLAN DATOS M2M",
            "548 CPP EMPRESAS",
            "550 CPP EMPRESAS",
            "552 CPP EMPRESAS",
            "560 BAM 200KBPS NACIONAL EMP",
            "570 SGO",
            "571 SGO",
            "573 SGO",
            "574 SGO",
            "575 SGO",
            "576 SGO",
            "577 SGO",
            "578 SGO",
            "579 SGO",
            "586 CPP EMPRESAS S",
            "587 CPP EMPRESAS S",
            "59 PCS 440S",
            "590 CPP EMPRESAS S",
            "591 CPP EMPRESAS S",
            "592 CPP EMPRESAS S",
            "593 CPP EMPRESAS S",
            "594 MI EMPRESA SGO",
            "595 MI EMPRESA SGO",
            "597 MI EMPRESA SGO",
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
            "621 TARIFA PLANA",
            "622 TARIFA PLANA",
            "623 TARIFA PLANA",
            "624 TARIFA PLANA",
            "625 TARIFA PLANA",
            "626 SGO",
            "63 PLAN GLOBAL 80",
            "631 PLANO PLUS",
            "633 SGO",
            "639 BLACKBERRY PROFESIONAL EMP",
            "64 PLAN GLOBAL 120",
            "640 BLACKBERRY CORPORATIVO",
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
            "700 PLAN WHERIFONE",
            "701 BAM EMPRESA",
            "703 BAM PRO DEALERS",
            "704 BAM PRO DEALERS",
            "705 BAM PRO DEALERS",
            "706 BAM MASCONECTADO 3GB",
            "707 BAM MASCONECTADO 6GB",
            "708 BAM",
            "708 BAM EMPRESAS PRO 3GB",
            "709 BAM",
            "709 BAM EMPRESAS PRO 6GB",
            "710 BAM PLAN ROUTER",
            "710 PLAN RED 440",
            "711 BAM XI,XII,IDP 400KBPS PER",
            "711 PLAN RED 660",
            "712 BAM CONTROLADO 2 GB",
            "712 PLAN RED 1100",
            "713 BAM CONTROLADO 5GB",
            "714 BAM CONTROLADO 7GB",
            "714 PLAN RED 1000",
            "716 BAM CONTROLADO 500 MB",
            "72 PCS GLOBAL S",
            "722 TARIFA UNICA 170",
            "724 TARIFA UNICA 450",
            "725 TARIFA UNICA 700",
            "740 TODO DESTINO 150",
            "741 TODO DESTINO 230",
            "742 TODO DESTINO 300",
            "744 TODO DESTINO 750",
            "745 TODO DESTINO 1000",
            "750 ECORP 90",
            "751 ECORP 110 + 100 SMS",
            "756 ECORP CC 22450",
            "767 BAM CONTROLADO 15GB",
            "768 BAM",
            "768 BAM 22 MBPS",
            "780 CUENTA CONTROLADA 24990",
            "8 PERSONAL PROMOCION",
            "80 PLUS 480S",
            "801 SGO",
            "806 VIP CAMARA 1",
            "807 VIP CAMARA 2",
            "813 CONSOLIDADO",
            "814 SGO",
            "815 SGO",
            "816 SGO",
            "818 SGO",
            "819 CONS0LIDADO",
            "819 SGO",
            "820 SGO",
            "822 SGO",
            "822 VIP RPV CPPS",
            "823 CONSOLIDADO",
            "825 SGO",
            "826 RED CONSOLIDADO",
            "826 SGO",
            "827 CONSOLIDADOS",
            "827 SGO",
            "829 SGO",
            "831 RED CONSOLIDADOS",
            "834 CUENTA OPTIMIZADA NO",
            "834 SGO CTA OPTIMIZADA NO",
            "840 SGO",
            "842 CONSOLIDADO S",
            "843 SGO",
            "844 SGO",
            "845 RED CONSOLIDADOS",
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
            "CTA. CONTROLADA PLANA $10.500",
            "CTA. CONTROLADA PLANA $12.990",
            "CTA. CONTROLADA PLANA $15.990",
            "CTA. CONTROLADA PLANA $19.500",
            "DEMO SMS EMPRESAS",
            "EMPRESA GES DATOS 1,5GB",
            "EMPRESA GES DATOS 10GB +",
            "EMPRESA GES DATOS 160MBCP",
            "EMPRESA GES DATOS 1GB",
            "EMPRESA GES DATOS 1GB RET",
            "EMPRESA GES DATOS 2GB",
            "EMPRESA GES DATOS 2GBND",
            "EMPRESA GES DATOS 3GB +",
            "EMPRESA GES DATOS 400MB",
            "EMPRESA GES DATOS 4GB +",
            "EMPRESA GES DATOS 600MB",
            "EMPRESA GES DATOS 6GB +",
            "EMPRESA GES DATOS 8GB +",
            "EMPRESA SMARTPHONE 10GB",
            "EMPRESA SMARTPHONE 1GB",
            "EMPRESA SMARTPHONE 2GB",
            "EMPRESA SMARTPHONE 3GB",
            "EMPRESA SMARTPHONE 4GB",
            "EMPRESA SMARTPHONE 6GB",
            "EMPRESA SMARTPHONE 8GB",
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
            "GPS LITE AUTOINSTALABLE",
            "GPS LITE INSTALABLE",
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
            "MM PRUEBAS CC 16.990",
            "PLAN ADT 120 SMS",
            "PLAN ADT 37 SMS",
            "PLAN ADT 80 SMS",
            "PLAN CANJE 400",
            "PLAN CC QUADRANTE",
            "PLAN DEMO ROAMING",
            "PLAN DEMOSTRACION",
            "PLAN ENTELGPS AVANZADO",
            "PLAN ENTELGPS BASICO",
            "PLAN MOBILE CAM",
            "PLAN REPETIDOR",
            "PLAN VIAJERO CC",
            "Z_NOUSO_1460 M2M CORP SENS",
            "Z_NOUSO_PORT_EMP GES DAT 4GB +A"});
            this.comboPlan.Location = new System.Drawing.Point(46, 320);
            this.comboPlan.Name = "comboPlan";
            this.comboPlan.Size = new System.Drawing.Size(245, 21);
            this.comboPlan.TabIndex = 44;
            // 
            // campoRUT
            // 
            this.campoRUT.Location = new System.Drawing.Point(96, 63);
            this.campoRUT.Name = "campoRUT";
            this.campoRUT.Size = new System.Drawing.Size(100, 20);
            this.campoRUT.TabIndex = 26;
            // 
            // campoServicios
            // 
            this.campoServicios.Location = new System.Drawing.Point(208, 433);
            this.campoServicios.Name = "campoServicios";
            this.campoServicios.Size = new System.Drawing.Size(155, 106);
            this.campoServicios.TabIndex = 45;
            this.campoServicios.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(205, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Servicios a activar/bloquear";
            // 
            // campoFecha
            // 
            this.campoFecha.CustomFormat = "";
            this.campoFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.campoFecha.Location = new System.Drawing.Point(46, 272);
            this.campoFecha.Name = "campoFecha";
            this.campoFecha.Size = new System.Drawing.Size(87, 20);
            this.campoFecha.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
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
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // btnCopiaModelo
            // 
            this.btnCopiaModelo.Location = new System.Drawing.Point(510, 90);
            this.btnCopiaModelo.Name = "btnCopiaModelo";
            this.btnCopiaModelo.Size = new System.Drawing.Size(91, 23);
            this.btnCopiaModelo.TabIndex = 75;
            this.btnCopiaModelo.Text = "Copia Modelo";
            this.btnCopiaModelo.UseVisualStyleBackColor = true;
            this.btnCopiaModelo.Click += new System.EventHandler(this.btnCopiaModelo_Click);
            // 
            // btnCopiaValor
            // 
            this.btnCopiaValor.Location = new System.Drawing.Point(656, 90);
            this.btnCopiaValor.Name = "btnCopiaValor";
            this.btnCopiaValor.Size = new System.Drawing.Size(71, 23);
            this.btnCopiaValor.TabIndex = 76;
            this.btnCopiaValor.Text = "Copia Valor";
            this.btnCopiaValor.UseVisualStyleBackColor = true;
            this.btnCopiaValor.Click += new System.EventHandler(this.btnCopiaValor_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(384, 417);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(78, 13);
            this.lblObs.TabIndex = 82;
            this.lblObs.Text = "Observaciones";
            // 
            // campoObs
            // 
            this.campoObs.Location = new System.Drawing.Point(387, 433);
            this.campoObs.Name = "campoObs";
            this.campoObs.Size = new System.Drawing.Size(177, 106);
            this.campoObs.TabIndex = 81;
            this.campoObs.Text = "";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(622, 495);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 80;
            this.btnGrabar.Text = "Copiar AC";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCopiaProy
            // 
            this.btnCopiaProy.Location = new System.Drawing.Point(603, 468);
            this.btnCopiaProy.Name = "btnCopiaProy";
            this.btnCopiaProy.Size = new System.Drawing.Size(137, 23);
            this.btnCopiaProy.TabIndex = 79;
            this.btnCopiaProy.Text = "Copiar Nombre Proyecto";
            this.btnCopiaProy.UseVisualStyleBackColor = true;
            this.btnCopiaProy.Visible = false;
            this.btnCopiaProy.Click += new System.EventHandler(this.btnCopiaProy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Ejecutivo SAC";
            // 
            // comboEjecutivo
            // 
            this.comboEjecutivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEjecutivo.FormattingEnabled = true;
            this.comboEjecutivo.Items.AddRange(new object[] {
"Andres Arias O.",
"Carolina Arellano D.",
"Claudia Sola G.",
"Danitza Leyton M.",
"Danitza Rendich O.",
"Elizabeth Pavez S.",
"Felipe Figueroa L.",
"Gabriela Guzman C.",
"Karin Sothers B.",
"Kimberly Moraga G.",
"Lorena Garcia N.",
"Lorena Jimenez M.",
"Loreto Barriga R.",
"Luz Gaete Ch.",
"Maria Jose Marchant V.",
"Maria Loreto Caceres A.",
"Maria Renata Ramirez A.",
"Oscar Illanes R.",
"Oscar Magallanes R.",
"Philipp Gallardo G.",
"Romina Saez G.",
"Sandra Bustos R.",
"Sandra Lazcano A.",
"Simon Segura B.",
"Vladimir Cubillos R.",
"Ximena Valdes V.",
"Yerko Campos R."});
            this.comboEjecutivo.Location = new System.Drawing.Point(596, 433);
            this.comboEjecutivo.Name = "comboEjecutivo";
            this.comboEjecutivo.Size = new System.Drawing.Size(146, 21);
            this.comboEjecutivo.TabIndex = 77;
            // 
            // lblFraude
            // 
            this.lblFraude.AutoSize = true;
            this.lblFraude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraude.ForeColor = System.Drawing.Color.Red;
            this.lblFraude.Location = new System.Drawing.Point(326, 63);
            this.lblFraude.Name = "lblFraude";
            this.lblFraude.Size = new System.Drawing.Size(406, 13);
            this.lblFraude.TabIndex = 168;
            this.lblFraude.Text = "Recordar: negocios se realizaran en separado por modelos de equipos";
            // 
            // VentPORTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 559);
            this.Controls.Add(this.lblFraude);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.campoObs);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCopiaProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEjecutivo);
            this.Controls.Add(this.btnCopiaValor);
            this.Controls.Add(this.btnCopiaModelo);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoRUT);
            this.Controls.Add(this.labelPorta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataPorta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentPORTA";
            this.Text = "PORTABILIDAD";
            ((System.ComponentModel.ISupportInitialize)(this.dataPorta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox campoDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPorta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataPorta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox campoCuenta;
        private System.Windows.Forms.TextBox campoDonante;
        private System.Windows.Forms.TextBox campoMMF;
        private System.Windows.Forms.ComboBox comboPlan;
        private System.Windows.Forms.TextBox campoRUT;
        private System.Windows.Forms.RichTextBox campoServicios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker campoFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnCopiaModelo;
        private System.Windows.Forms.Button btnCopiaValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox campoObs;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCopiaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEjecutivo;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.Label lblFraude;
    }
}