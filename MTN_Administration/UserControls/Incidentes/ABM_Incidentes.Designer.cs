namespace MTN_Administration.Tabs
{
    partial class ABM_Incidentes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Incidentes));
            this.Header = new System.Windows.Forms.Panel();
            this.headerIncidentePicture = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.Label();
            this.TituloHeader = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTabla = new System.Windows.Forms.Panel();
            this.tablaIncidentes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoIncidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonVerIncidente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonAgregarIncidente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelSwitches = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.switchEstadoIncidenteCancelado = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.switchCriticidadMuyAlta = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.LabelswitchEstadoIncidenteCerrado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBuscarTecnico = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LabelSwitchEstadoIncidenteProceso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.switchCriticidadBaja = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchEstadoIncidenteProceso = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchAlarmas = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchCriticidadMedia = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchEstadoIncidenteCerrado = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchCCTV = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchCriticidadAlta = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchEstadoIncidenteAbierto = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.filtroCCTV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filtroAlarmas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transiciones = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.buttonReabrir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonCancelarIncidente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.switchEstadoIncidenteReabierto = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerIncidentePicture)).BeginInit();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIncidentes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSwitches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.headerIncidentePicture);
            this.Header.Controls.Add(this.minimize);
            this.Header.Controls.Add(this.TituloHeader);
            this.Header.Controls.Add(this.close);
            this.transiciones.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1240, 35);
            this.Header.TabIndex = 15;
            // 
            // headerIncidentePicture
            // 
            this.transiciones.SetDecoration(this.headerIncidentePicture, BunifuAnimatorNS.DecorationType.None);
            this.headerIncidentePicture.Image = global::MTN_Administration.Properties.Resources._027_report;
            this.headerIncidentePicture.Location = new System.Drawing.Point(37, 8);
            this.headerIncidentePicture.Name = "headerIncidentePicture";
            this.headerIncidentePicture.Size = new System.Drawing.Size(20, 20);
            this.headerIncidentePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerIncidentePicture.TabIndex = 84;
            this.headerIncidentePicture.TabStop = false;
            this.headerIncidentePicture.Visible = false;
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.SystemColors.Window;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.minimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.minimize.Location = new System.Drawing.Point(1189, 9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(12, 17);
            this.minimize.TabIndex = 63;
            this.minimize.Text = "-";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // TituloHeader
            // 
            this.TituloHeader.AutoSize = true;
            this.TituloHeader.BackColor = System.Drawing.SystemColors.Window;
            this.transiciones.SetDecoration(this.TituloHeader, BunifuAnimatorNS.DecorationType.None);
            this.TituloHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.TituloHeader.Location = new System.Drawing.Point(96, 9);
            this.TituloHeader.Name = "TituloHeader";
            this.TituloHeader.Size = new System.Drawing.Size(238, 21);
            this.TituloHeader.TabIndex = 83;
            this.TituloHeader.Text = "Administracion de Incidentes";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.SystemColors.Window;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.close.Location = new System.Drawing.Point(1212, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 17);
            this.close.TabIndex = 62;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.tablaIncidentes);
            this.panelTabla.Controls.Add(this.panel1);
            this.panelTabla.Controls.Add(this.panel3);
            this.panelTabla.Controls.Add(this.panel2);
            this.panelTabla.Controls.Add(this.panelSwitches);
            this.transiciones.SetDecoration(this.panelTabla, BunifuAnimatorNS.DecorationType.None);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 35);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1240, 705);
            this.panelTabla.TabIndex = 61;
            // 
            // tablaIncidentes
            // 
            this.tablaIncidentes.AllowUserToAddRows = false;
            this.tablaIncidentes.AllowUserToDeleteRows = false;
            this.tablaIncidentes.AllowUserToResizeColumns = false;
            this.tablaIncidentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tablaIncidentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaIncidentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaIncidentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaIncidentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaIncidentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIncidentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaIncidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIncidentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.sucursal,
            this.tipoDispositivo,
            this.Dispositivo,
            this.Camara,
            this.estado,
            this.criticidad,
            this.asignado,
            this.estadoIncidente});
            this.transiciones.SetDecoration(this.tablaIncidentes, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaIncidentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaIncidentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaIncidentes.DoubleBuffered = true;
            this.tablaIncidentes.EnableHeadersVisualStyles = false;
            this.tablaIncidentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.tablaIncidentes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.tablaIncidentes.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaIncidentes.Location = new System.Drawing.Point(194, 20);
            this.tablaIncidentes.MultiSelect = false;
            this.tablaIncidentes.Name = "tablaIncidentes";
            this.tablaIncidentes.ReadOnly = true;
            this.tablaIncidentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaIncidentes.RowHeadersVisible = false;
            this.tablaIncidentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaIncidentes.ShowCellErrors = false;
            this.tablaIncidentes.ShowCellToolTips = false;
            this.tablaIncidentes.ShowEditingIcon = false;
            this.tablaIncidentes.ShowRowErrors = false;
            this.tablaIncidentes.Size = new System.Drawing.Size(1021, 630);
            this.tablaIncidentes.TabIndex = 70;
            this.tablaIncidentes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaIncidentes_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.FillWeight = 150F;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // sucursal
            // 
            this.sucursal.HeaderText = "Sucursal";
            this.sucursal.Name = "sucursal";
            this.sucursal.ReadOnly = true;
            // 
            // tipoDispositivo
            // 
            this.tipoDispositivo.HeaderText = "Tipo Dispositivo";
            this.tipoDispositivo.Name = "tipoDispositivo";
            this.tipoDispositivo.ReadOnly = true;
            // 
            // Dispositivo
            // 
            this.Dispositivo.HeaderText = "Dispositivo";
            this.Dispositivo.Name = "Dispositivo";
            this.Dispositivo.ReadOnly = true;
            // 
            // Camara
            // 
            this.Camara.HeaderText = "Camara";
            this.Camara.Name = "Camara";
            this.Camara.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado Disp/Cam";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // criticidad
            // 
            this.criticidad.HeaderText = "Criticidad";
            this.criticidad.Name = "criticidad";
            this.criticidad.ReadOnly = true;
            // 
            // asignado
            // 
            this.asignado.HeaderText = "Programado";
            this.asignado.Name = "asignado";
            this.asignado.ReadOnly = true;
            // 
            // estadoIncidente
            // 
            this.estadoIncidente.FillWeight = 50F;
            this.estadoIncidente.HeaderText = "Estado Incidente";
            this.estadoIncidente.Name = "estadoIncidente";
            this.estadoIncidente.ReadOnly = true;
            // 
            // panel1
            // 
            this.transiciones.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 20);
            this.panel1.TabIndex = 85;
            // 
            // panel3
            // 
            this.transiciones.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1215, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 650);
            this.panel3.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonReabrir);
            this.panel2.Controls.Add(this.buttonCancelarIncidente);
            this.panel2.Controls.Add(this.BotonVerIncidente);
            this.panel2.Controls.Add(this.BotonAgregarIncidente);
            this.transiciones.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(194, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 55);
            this.panel2.TabIndex = 83;
            // 
            // BotonVerIncidente
            // 
            this.BotonVerIncidente.ActiveBorderThickness = 1;
            this.BotonVerIncidente.ActiveCornerRadius = 20;
            this.BotonVerIncidente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonVerIncidente.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonVerIncidente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonVerIncidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonVerIncidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonVerIncidente.BackgroundImage")));
            this.BotonVerIncidente.ButtonText = "Ver Incidente";
            this.BotonVerIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.BotonVerIncidente, BunifuAnimatorNS.DecorationType.None);
            this.BotonVerIncidente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerIncidente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonVerIncidente.IdleBorderThickness = 1;
            this.BotonVerIncidente.IdleCornerRadius = 20;
            this.BotonVerIncidente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonVerIncidente.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonVerIncidente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonVerIncidente.Location = new System.Drawing.Point(250, 4);
            this.BotonVerIncidente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonVerIncidente.Name = "BotonVerIncidente";
            this.BotonVerIncidente.Size = new System.Drawing.Size(181, 41);
            this.BotonVerIncidente.TabIndex = 62;
            this.BotonVerIncidente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonVerIncidente.Click += new System.EventHandler(this.BotonVerIncidente_Click);
            // 
            // BotonAgregarIncidente
            // 
            this.BotonAgregarIncidente.ActiveBorderThickness = 1;
            this.BotonAgregarIncidente.ActiveCornerRadius = 20;
            this.BotonAgregarIncidente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarIncidente.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonAgregarIncidente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarIncidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonAgregarIncidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonAgregarIncidente.BackgroundImage")));
            this.BotonAgregarIncidente.ButtonText = "Agregar Incidente";
            this.BotonAgregarIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.BotonAgregarIncidente, BunifuAnimatorNS.DecorationType.None);
            this.BotonAgregarIncidente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarIncidente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarIncidente.IdleBorderThickness = 1;
            this.BotonAgregarIncidente.IdleCornerRadius = 20;
            this.BotonAgregarIncidente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonAgregarIncidente.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonAgregarIncidente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarIncidente.Location = new System.Drawing.Point(7, 4);
            this.BotonAgregarIncidente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAgregarIncidente.Name = "BotonAgregarIncidente";
            this.BotonAgregarIncidente.Size = new System.Drawing.Size(181, 41);
            this.BotonAgregarIncidente.TabIndex = 61;
            this.BotonAgregarIncidente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonAgregarIncidente.Click += new System.EventHandler(this.BotonAgregarIncidente_Click);
            // 
            // panelSwitches
            // 
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel5);
            this.panelSwitches.Controls.Add(this.switchEstadoIncidenteReabierto);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel7);
            this.panelSwitches.Controls.Add(this.switchEstadoIncidenteCancelado);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel4);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel3);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel2);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel1);
            this.panelSwitches.Controls.Add(this.switchCriticidadMuyAlta);
            this.panelSwitches.Controls.Add(this.SearchIcon);
            this.panelSwitches.Controls.Add(this.LabelswitchEstadoIncidenteCerrado);
            this.panelSwitches.Controls.Add(this.textBuscarTecnico);
            this.panelSwitches.Controls.Add(this.LabelSwitchEstadoIncidenteProceso);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel6);
            this.panelSwitches.Controls.Add(this.switchCriticidadBaja);
            this.panelSwitches.Controls.Add(this.switchEstadoIncidenteProceso);
            this.panelSwitches.Controls.Add(this.switchAlarmas);
            this.panelSwitches.Controls.Add(this.switchCriticidadMedia);
            this.panelSwitches.Controls.Add(this.switchEstadoIncidenteCerrado);
            this.panelSwitches.Controls.Add(this.switchCCTV);
            this.panelSwitches.Controls.Add(this.switchCriticidadAlta);
            this.panelSwitches.Controls.Add(this.switchEstadoIncidenteAbierto);
            this.panelSwitches.Controls.Add(this.filtroCCTV);
            this.panelSwitches.Controls.Add(this.filtroAlarmas);
            this.transiciones.SetDecoration(this.panelSwitches, BunifuAnimatorNS.DecorationType.None);
            this.panelSwitches.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSwitches.Location = new System.Drawing.Point(0, 0);
            this.panelSwitches.Name = "panelSwitches";
            this.panelSwitches.Size = new System.Drawing.Size(194, 705);
            this.panelSwitches.TabIndex = 82;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(83, 419);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(82, 17);
            this.bunifuCustomLabel7.TabIndex = 89;
            this.bunifuCustomLabel7.Text = "Cancelado";
            // 
            // switchEstadoIncidenteCancelado
            // 
            this.switchEstadoIncidenteCancelado.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoIncidenteCancelado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoIncidenteCancelado.BackgroundImage")));
            this.switchEstadoIncidenteCancelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoIncidenteCancelado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoIncidenteCancelado, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoIncidenteCancelado.Location = new System.Drawing.Point(38, 417);
            this.switchEstadoIncidenteCancelado.Name = "switchEstadoIncidenteCancelado";
            this.switchEstadoIncidenteCancelado.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoIncidenteCancelado.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoIncidenteCancelado.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoIncidenteCancelado.TabIndex = 88;
            this.switchEstadoIncidenteCancelado.Value = false;
            this.switchEstadoIncidenteCancelado.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(81, 271);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(36, 17);
            this.bunifuCustomLabel4.TabIndex = 86;
            this.bunifuCustomLabel4.Text = "Baja";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(81, 243);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel3.TabIndex = 85;
            this.bunifuCustomLabel3.Text = "Normal";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(81, 215);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(34, 17);
            this.bunifuCustomLabel2.TabIndex = 84;
            this.bunifuCustomLabel2.Text = "Alta";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(81, 187);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel1.TabIndex = 83;
            this.bunifuCustomLabel1.Text = "Muy Alta";
            // 
            // switchCriticidadMuyAlta
            // 
            this.switchCriticidadMuyAlta.BackColor = System.Drawing.Color.Transparent;
            this.switchCriticidadMuyAlta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchCriticidadMuyAlta.BackgroundImage")));
            this.switchCriticidadMuyAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCriticidadMuyAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchCriticidadMuyAlta, BunifuAnimatorNS.DecorationType.None);
            this.switchCriticidadMuyAlta.Location = new System.Drawing.Point(36, 184);
            this.switchCriticidadMuyAlta.Name = "switchCriticidadMuyAlta";
            this.switchCriticidadMuyAlta.OffColor = System.Drawing.Color.Gray;
            this.switchCriticidadMuyAlta.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchCriticidadMuyAlta.Size = new System.Drawing.Size(35, 20);
            this.switchCriticidadMuyAlta.TabIndex = 80;
            this.switchCriticidadMuyAlta.Value = true;
            this.switchCriticidadMuyAlta.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // SearchIcon
            // 
            this.transiciones.SetDecoration(this.SearchIcon, BunifuAnimatorNS.DecorationType.None);
            this.SearchIcon.Image = global::MTN_Administration.Properties.Resources._029_search;
            this.SearchIcon.Location = new System.Drawing.Point(150, 22);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(21, 22);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 76;
            this.SearchIcon.TabStop = false;
            // 
            // LabelswitchEstadoIncidenteCerrado
            // 
            this.LabelswitchEstadoIncidenteCerrado.AutoSize = true;
            this.transiciones.SetDecoration(this.LabelswitchEstadoIncidenteCerrado, BunifuAnimatorNS.DecorationType.None);
            this.LabelswitchEstadoIncidenteCerrado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LabelswitchEstadoIncidenteCerrado.ForeColor = System.Drawing.Color.Silver;
            this.LabelswitchEstadoIncidenteCerrado.Location = new System.Drawing.Point(82, 362);
            this.LabelswitchEstadoIncidenteCerrado.Name = "LabelswitchEstadoIncidenteCerrado";
            this.LabelswitchEstadoIncidenteCerrado.Size = new System.Drawing.Size(62, 17);
            this.LabelswitchEstadoIncidenteCerrado.TabIndex = 69;
            this.LabelswitchEstadoIncidenteCerrado.Text = "Resuelto";
            // 
            // textBuscarTecnico
            // 
            this.textBuscarTecnico.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBuscarTecnico.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textBuscarTecnico.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.textBuscarTecnico.BorderThickness = 1;
            this.textBuscarTecnico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textBuscarTecnico, BunifuAnimatorNS.DecorationType.None);
            this.textBuscarTecnico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBuscarTecnico.isPassword = false;
            this.textBuscarTecnico.Location = new System.Drawing.Point(21, 22);
            this.textBuscarTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscarTecnico.Name = "textBuscarTecnico";
            this.textBuscarTecnico.Size = new System.Drawing.Size(119, 22);
            this.textBuscarTecnico.TabIndex = 77;
            this.textBuscarTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LabelSwitchEstadoIncidenteProceso
            // 
            this.LabelSwitchEstadoIncidenteProceso.AutoSize = true;
            this.transiciones.SetDecoration(this.LabelSwitchEstadoIncidenteProceso, BunifuAnimatorNS.DecorationType.None);
            this.LabelSwitchEstadoIncidenteProceso.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LabelSwitchEstadoIncidenteProceso.ForeColor = System.Drawing.Color.Silver;
            this.LabelSwitchEstadoIncidenteProceso.Location = new System.Drawing.Point(82, 391);
            this.LabelSwitchEstadoIncidenteProceso.Name = "LabelSwitchEstadoIncidenteProceso";
            this.LabelSwitchEstadoIncidenteProceso.Size = new System.Drawing.Size(59, 17);
            this.LabelSwitchEstadoIncidenteProceso.TabIndex = 68;
            this.LabelSwitchEstadoIncidenteProceso.Text = "Proceso";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(82, 333);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(60, 17);
            this.bunifuCustomLabel6.TabIndex = 67;
            this.bunifuCustomLabel6.Text = "Abiertos";
            // 
            // switchCriticidadBaja
            // 
            this.switchCriticidadBaja.BackColor = System.Drawing.Color.Transparent;
            this.switchCriticidadBaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchCriticidadBaja.BackgroundImage")));
            this.switchCriticidadBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCriticidadBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchCriticidadBaja, BunifuAnimatorNS.DecorationType.None);
            this.switchCriticidadBaja.Location = new System.Drawing.Point(36, 271);
            this.switchCriticidadBaja.Name = "switchCriticidadBaja";
            this.switchCriticidadBaja.OffColor = System.Drawing.Color.Gray;
            this.switchCriticidadBaja.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchCriticidadBaja.Size = new System.Drawing.Size(35, 20);
            this.switchCriticidadBaja.TabIndex = 66;
            this.switchCriticidadBaja.Value = true;
            this.switchCriticidadBaja.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // switchEstadoIncidenteProceso
            // 
            this.switchEstadoIncidenteProceso.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoIncidenteProceso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoIncidenteProceso.BackgroundImage")));
            this.switchEstadoIncidenteProceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoIncidenteProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoIncidenteProceso, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoIncidenteProceso.Location = new System.Drawing.Point(37, 389);
            this.switchEstadoIncidenteProceso.Name = "switchEstadoIncidenteProceso";
            this.switchEstadoIncidenteProceso.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoIncidenteProceso.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoIncidenteProceso.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoIncidenteProceso.TabIndex = 66;
            this.switchEstadoIncidenteProceso.Value = false;
            this.switchEstadoIncidenteProceso.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // switchAlarmas
            // 
            this.switchAlarmas.BackColor = System.Drawing.Color.Transparent;
            this.switchAlarmas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchAlarmas.BackgroundImage")));
            this.switchAlarmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchAlarmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchAlarmas, BunifuAnimatorNS.DecorationType.None);
            this.switchAlarmas.Enabled = false;
            this.switchAlarmas.Location = new System.Drawing.Point(37, 118);
            this.switchAlarmas.Name = "switchAlarmas";
            this.switchAlarmas.OffColor = System.Drawing.Color.Gray;
            this.switchAlarmas.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchAlarmas.Size = new System.Drawing.Size(35, 20);
            this.switchAlarmas.TabIndex = 65;
            this.switchAlarmas.Value = false;
            // 
            // switchCriticidadMedia
            // 
            this.switchCriticidadMedia.BackColor = System.Drawing.Color.Transparent;
            this.switchCriticidadMedia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchCriticidadMedia.BackgroundImage")));
            this.switchCriticidadMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCriticidadMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchCriticidadMedia, BunifuAnimatorNS.DecorationType.None);
            this.switchCriticidadMedia.Location = new System.Drawing.Point(36, 242);
            this.switchCriticidadMedia.Name = "switchCriticidadMedia";
            this.switchCriticidadMedia.OffColor = System.Drawing.Color.Gray;
            this.switchCriticidadMedia.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchCriticidadMedia.Size = new System.Drawing.Size(35, 20);
            this.switchCriticidadMedia.TabIndex = 65;
            this.switchCriticidadMedia.Value = true;
            this.switchCriticidadMedia.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // switchEstadoIncidenteCerrado
            // 
            this.switchEstadoIncidenteCerrado.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoIncidenteCerrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoIncidenteCerrado.BackgroundImage")));
            this.switchEstadoIncidenteCerrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoIncidenteCerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoIncidenteCerrado, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoIncidenteCerrado.Location = new System.Drawing.Point(37, 360);
            this.switchEstadoIncidenteCerrado.Name = "switchEstadoIncidenteCerrado";
            this.switchEstadoIncidenteCerrado.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoIncidenteCerrado.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoIncidenteCerrado.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoIncidenteCerrado.TabIndex = 65;
            this.switchEstadoIncidenteCerrado.Value = false;
            this.switchEstadoIncidenteCerrado.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // switchCCTV
            // 
            this.switchCCTV.BackColor = System.Drawing.Color.Transparent;
            this.switchCCTV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchCCTV.BackgroundImage")));
            this.switchCCTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCCTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchCCTV, BunifuAnimatorNS.DecorationType.None);
            this.switchCCTV.Location = new System.Drawing.Point(37, 90);
            this.switchCCTV.Name = "switchCCTV";
            this.switchCCTV.OffColor = System.Drawing.Color.Gray;
            this.switchCCTV.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchCCTV.Size = new System.Drawing.Size(35, 20);
            this.switchCCTV.TabIndex = 64;
            this.switchCCTV.Value = true;
            // 
            // switchCriticidadAlta
            // 
            this.switchCriticidadAlta.BackColor = System.Drawing.Color.Transparent;
            this.switchCriticidadAlta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchCriticidadAlta.BackgroundImage")));
            this.switchCriticidadAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCriticidadAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchCriticidadAlta, BunifuAnimatorNS.DecorationType.None);
            this.switchCriticidadAlta.Location = new System.Drawing.Point(36, 213);
            this.switchCriticidadAlta.Name = "switchCriticidadAlta";
            this.switchCriticidadAlta.OffColor = System.Drawing.Color.Gray;
            this.switchCriticidadAlta.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchCriticidadAlta.Size = new System.Drawing.Size(35, 20);
            this.switchCriticidadAlta.TabIndex = 64;
            this.switchCriticidadAlta.Value = true;
            this.switchCriticidadAlta.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // switchEstadoIncidenteAbierto
            // 
            this.switchEstadoIncidenteAbierto.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoIncidenteAbierto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoIncidenteAbierto.BackgroundImage")));
            this.switchEstadoIncidenteAbierto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoIncidenteAbierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoIncidenteAbierto, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoIncidenteAbierto.Location = new System.Drawing.Point(37, 331);
            this.switchEstadoIncidenteAbierto.Name = "switchEstadoIncidenteAbierto";
            this.switchEstadoIncidenteAbierto.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoIncidenteAbierto.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoIncidenteAbierto.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoIncidenteAbierto.TabIndex = 64;
            this.switchEstadoIncidenteAbierto.Value = true;
            this.switchEstadoIncidenteAbierto.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // filtroCCTV
            // 
            this.filtroCCTV.Activecolor = System.Drawing.Color.Transparent;
            this.filtroCCTV.BackColor = System.Drawing.Color.Transparent;
            this.filtroCCTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroCCTV.BorderRadius = 0;
            this.filtroCCTV.ButtonText = "CCTV";
            this.filtroCCTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.filtroCCTV, BunifuAnimatorNS.DecorationType.None);
            this.filtroCCTV.DisabledColor = System.Drawing.Color.Gray;
            this.filtroCCTV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroCCTV.ForeColor = System.Drawing.Color.Silver;
            this.filtroCCTV.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroCCTV.Iconimage = null;
            this.filtroCCTV.Iconimage_right = null;
            this.filtroCCTV.Iconimage_right_Selected = null;
            this.filtroCCTV.Iconimage_Selected = null;
            this.filtroCCTV.IconMarginLeft = 0;
            this.filtroCCTV.IconMarginRight = 0;
            this.filtroCCTV.IconRightVisible = true;
            this.filtroCCTV.IconRightZoom = 0D;
            this.filtroCCTV.IconVisible = true;
            this.filtroCCTV.IconZoom = 90D;
            this.filtroCCTV.IsTab = false;
            this.filtroCCTV.Location = new System.Drawing.Point(82, 93);
            this.filtroCCTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroCCTV.Name = "filtroCCTV";
            this.filtroCCTV.Normalcolor = System.Drawing.Color.Transparent;
            this.filtroCCTV.OnHovercolor = System.Drawing.Color.Transparent;
            this.filtroCCTV.OnHoverTextColor = System.Drawing.Color.Coral;
            this.filtroCCTV.selected = false;
            this.filtroCCTV.Size = new System.Drawing.Size(50, 17);
            this.filtroCCTV.TabIndex = 78;
            this.filtroCCTV.Text = "CCTV";
            this.filtroCCTV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroCCTV.Textcolor = System.Drawing.Color.Silver;
            this.filtroCCTV.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // filtroAlarmas
            // 
            this.filtroAlarmas.Activecolor = System.Drawing.Color.Transparent;
            this.filtroAlarmas.BackColor = System.Drawing.Color.Transparent;
            this.filtroAlarmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroAlarmas.BorderRadius = 0;
            this.filtroAlarmas.ButtonText = "Alarmas";
            this.filtroAlarmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.filtroAlarmas, BunifuAnimatorNS.DecorationType.None);
            this.filtroAlarmas.DisabledColor = System.Drawing.Color.Gray;
            this.filtroAlarmas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAlarmas.ForeColor = System.Drawing.Color.Silver;
            this.filtroAlarmas.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroAlarmas.Iconimage = null;
            this.filtroAlarmas.Iconimage_right = null;
            this.filtroAlarmas.Iconimage_right_Selected = null;
            this.filtroAlarmas.Iconimage_Selected = null;
            this.filtroAlarmas.IconMarginLeft = 0;
            this.filtroAlarmas.IconMarginRight = 0;
            this.filtroAlarmas.IconRightVisible = true;
            this.filtroAlarmas.IconRightZoom = 0D;
            this.filtroAlarmas.IconVisible = true;
            this.filtroAlarmas.IconZoom = 90D;
            this.filtroAlarmas.IsTab = false;
            this.filtroAlarmas.Location = new System.Drawing.Point(82, 118);
            this.filtroAlarmas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroAlarmas.Name = "filtroAlarmas";
            this.filtroAlarmas.Normalcolor = System.Drawing.Color.Transparent;
            this.filtroAlarmas.OnHovercolor = System.Drawing.Color.Transparent;
            this.filtroAlarmas.OnHoverTextColor = System.Drawing.Color.Coral;
            this.filtroAlarmas.selected = false;
            this.filtroAlarmas.Size = new System.Drawing.Size(72, 17);
            this.filtroAlarmas.TabIndex = 73;
            this.filtroAlarmas.Text = "Alarmas";
            this.filtroAlarmas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroAlarmas.Textcolor = System.Drawing.Color.Silver;
            this.filtroAlarmas.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // transiciones
            // 
            this.transiciones.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transiciones.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transiciones.DefaultAnimation = animation1;
            // 
            // buttonReabrir
            // 
            this.buttonReabrir.ActiveBorderThickness = 1;
            this.buttonReabrir.ActiveCornerRadius = 20;
            this.buttonReabrir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonReabrir.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonReabrir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonReabrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonReabrir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReabrir.BackgroundImage")));
            this.buttonReabrir.ButtonText = "Reabir Incidente";
            this.buttonReabrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.buttonReabrir, BunifuAnimatorNS.DecorationType.None);
            this.buttonReabrir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReabrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonReabrir.IdleBorderThickness = 1;
            this.buttonReabrir.IdleCornerRadius = 20;
            this.buttonReabrir.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonReabrir.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonReabrir.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonReabrir.Location = new System.Drawing.Point(737, 7);
            this.buttonReabrir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReabrir.Name = "buttonReabrir";
            this.buttonReabrir.Size = new System.Drawing.Size(166, 41);
            this.buttonReabrir.TabIndex = 93;
            this.buttonReabrir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelarIncidente
            // 
            this.buttonCancelarIncidente.ActiveBorderThickness = 1;
            this.buttonCancelarIncidente.ActiveCornerRadius = 20;
            this.buttonCancelarIncidente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelarIncidente.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCancelarIncidente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelarIncidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonCancelarIncidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelarIncidente.BackgroundImage")));
            this.buttonCancelarIncidente.ButtonText = "Cancelar Incidente";
            this.buttonCancelarIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.buttonCancelarIncidente, BunifuAnimatorNS.DecorationType.None);
            this.buttonCancelarIncidente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarIncidente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonCancelarIncidente.IdleBorderThickness = 1;
            this.buttonCancelarIncidente.IdleCornerRadius = 20;
            this.buttonCancelarIncidente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonCancelarIncidente.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonCancelarIncidente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelarIncidente.Location = new System.Drawing.Point(496, 10);
            this.buttonCancelarIncidente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelarIncidente.Name = "buttonCancelarIncidente";
            this.buttonCancelarIncidente.Size = new System.Drawing.Size(166, 41);
            this.buttonCancelarIncidente.TabIndex = 92;
            this.buttonCancelarIncidente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(83, 449);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(82, 17);
            this.bunifuCustomLabel5.TabIndex = 91;
            this.bunifuCustomLabel5.Text = "Cancelado";
            // 
            // switchEstadoIncidenteReabierto
            // 
            this.switchEstadoIncidenteReabierto.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoIncidenteReabierto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoIncidenteReabierto.BackgroundImage")));
            this.switchEstadoIncidenteReabierto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoIncidenteReabierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoIncidenteReabierto, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoIncidenteReabierto.Location = new System.Drawing.Point(38, 447);
            this.switchEstadoIncidenteReabierto.Name = "switchEstadoIncidenteReabierto";
            this.switchEstadoIncidenteReabierto.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoIncidenteReabierto.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoIncidenteReabierto.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoIncidenteReabierto.TabIndex = 90;
            this.switchEstadoIncidenteReabierto.Value = false;
            this.switchEstadoIncidenteReabierto.OnValueChange += new System.EventHandler(this.RefreshTablaIncidentes);
            // 
            // ABM_Incidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1240, 740);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.Header);
            this.transiciones.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_Incidentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerIncidentePicture)).EndInit();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaIncidentes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelSwitches.ResumeLayout(false);
            this.panelSwitches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn severidad;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTabla;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonAgregarIncidente;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox headerIncidentePicture;
        private System.Windows.Forms.Label TituloHeader;
        private System.Windows.Forms.Panel panelSwitches;
        private System.Windows.Forms.PictureBox SearchIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelswitchEstadoIncidenteCerrado;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBuscarTecnico;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelSwitchEstadoIncidenteProceso;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchCriticidadBaja;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoIncidenteProceso;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchAlarmas;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchCriticidadMedia;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoIncidenteCerrado;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchCCTV;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchCriticidadAlta;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoIncidenteAbierto;
        private Bunifu.Framework.UI.BunifuFlatButton filtroCCTV;
        private Bunifu.Framework.UI.BunifuFlatButton filtroAlarmas;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchCriticidadMuyAlta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private BunifuAnimatorNS.BunifuTransition transiciones;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaIncidentes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonVerIncidente;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoIncidenteCancelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camara;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoIncidente;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonReabrir;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonCancelarIncidente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoIncidenteReabierto;
    }
}
