namespace MTN_Administration.Tabs
{
    partial class ABM_Mantenimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Mantenimientos));
            this.Header = new System.Windows.Forms.Panel();
            this.headerIncidentePicture = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.Label();
            this.TituloHeader = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTabla = new System.Windows.Forms.Panel();
            this.tablaMantenimientos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCerrarMantenimiento = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonReprogramarMantenimiento = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonVerMantenimiento = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonAgregarMantenimiento = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelSwitches = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.switchEstadoMantenimeintoCerrado = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.switchEstadoMantenimeintoCancelado = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LabelswitchEstadoIncidenteCerrado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBuscarTecnico = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LabelSwitchEstadoIncidenteProceso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.switchEstadoMantenimeintoProgreso = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchEstadoMantenimeintoAsignado = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchEstadoMantenimeintoDemorado = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switchEstadoMantenimeintoAbierto = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.espaciadorTop = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transiciones = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerIncidentePicture)).BeginInit();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMantenimientos)).BeginInit();
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
            this.headerIncidentePicture.Image = global::MTN_Administration.Properties.Resources.settings_8;
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
            this.TituloHeader.Location = new System.Drawing.Point(94, 8);
            this.TituloHeader.Name = "TituloHeader";
            this.TituloHeader.Size = new System.Drawing.Size(283, 21);
            this.TituloHeader.TabIndex = 83;
            this.TituloHeader.Text = "Administracion de Mantenimientos";
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
            this.panelTabla.Controls.Add(this.tablaMantenimientos);
            this.panelTabla.Controls.Add(this.panel3);
            this.panelTabla.Controls.Add(this.panel2);
            this.panelTabla.Controls.Add(this.panelSwitches);
            this.panelTabla.Controls.Add(this.espaciadorTop);
            this.transiciones.SetDecoration(this.panelTabla, BunifuAnimatorNS.DecorationType.None);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 35);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1240, 705);
            this.panelTabla.TabIndex = 61;
            // 
            // tablaMantenimientos
            // 
            this.tablaMantenimientos.AllowUserToAddRows = false;
            this.tablaMantenimientos.AllowUserToDeleteRows = false;
            this.tablaMantenimientos.AllowUserToResizeColumns = false;
            this.tablaMantenimientos.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tablaMantenimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaMantenimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMantenimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaMantenimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMantenimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMantenimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablaMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMantenimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.sucursal,
            this.tipoMantenimiento,
            this.tecnico,
            this.estadoMantenimiento});
            this.transiciones.SetDecoration(this.tablaMantenimientos, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaMantenimientos.DefaultCellStyle = dataGridViewCellStyle12;
            this.tablaMantenimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaMantenimientos.DoubleBuffered = true;
            this.tablaMantenimientos.EnableHeadersVisualStyles = false;
            this.tablaMantenimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.tablaMantenimientos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.tablaMantenimientos.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaMantenimientos.Location = new System.Drawing.Point(194, 24);
            this.tablaMantenimientos.MultiSelect = false;
            this.tablaMantenimientos.Name = "tablaMantenimientos";
            this.tablaMantenimientos.ReadOnly = true;
            this.tablaMantenimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaMantenimientos.RowHeadersVisible = false;
            this.tablaMantenimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMantenimientos.ShowCellErrors = false;
            this.tablaMantenimientos.ShowCellToolTips = false;
            this.tablaMantenimientos.ShowEditingIcon = false;
            this.tablaMantenimientos.ShowRowErrors = false;
            this.tablaMantenimientos.Size = new System.Drawing.Size(1021, 626);
            this.tablaMantenimientos.TabIndex = 70;
            this.tablaMantenimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMantenimientos_CellDoubleClick);
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
            // tipoMantenimiento
            // 
            this.tipoMantenimiento.HeaderText = "Tipo Mantenimiento";
            this.tipoMantenimiento.Name = "tipoMantenimiento";
            this.tipoMantenimiento.ReadOnly = true;
            // 
            // tecnico
            // 
            this.tecnico.HeaderText = "Tecnico";
            this.tecnico.Name = "tecnico";
            this.tecnico.ReadOnly = true;
            // 
            // estadoMantenimiento
            // 
            this.estadoMantenimiento.FillWeight = 50F;
            this.estadoMantenimiento.HeaderText = "Estado";
            this.estadoMantenimiento.Name = "estadoMantenimiento";
            this.estadoMantenimiento.ReadOnly = true;
            // 
            // panel3
            // 
            this.transiciones.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1215, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 626);
            this.panel3.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCerrarMantenimiento);
            this.panel2.Controls.Add(this.buttonReprogramarMantenimiento);
            this.panel2.Controls.Add(this.BotonVerMantenimiento);
            this.panel2.Controls.Add(this.BotonAgregarMantenimiento);
            this.transiciones.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(194, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 55);
            this.panel2.TabIndex = 83;
            // 
            // buttonCerrarMantenimiento
            // 
            this.buttonCerrarMantenimiento.ActiveBorderThickness = 1;
            this.buttonCerrarMantenimiento.ActiveCornerRadius = 20;
            this.buttonCerrarMantenimiento.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCerrarMantenimiento.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCerrarMantenimiento.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCerrarMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonCerrarMantenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCerrarMantenimiento.BackgroundImage")));
            this.buttonCerrarMantenimiento.ButtonText = "Cerrar Mantenimiento";
            this.buttonCerrarMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.buttonCerrarMantenimiento, BunifuAnimatorNS.DecorationType.None);
            this.buttonCerrarMantenimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonCerrarMantenimiento.IdleBorderThickness = 1;
            this.buttonCerrarMantenimiento.IdleCornerRadius = 20;
            this.buttonCerrarMantenimiento.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonCerrarMantenimiento.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonCerrarMantenimiento.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCerrarMantenimiento.Location = new System.Drawing.Point(718, 7);
            this.buttonCerrarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCerrarMantenimiento.Name = "buttonCerrarMantenimiento";
            this.buttonCerrarMantenimiento.Size = new System.Drawing.Size(181, 41);
            this.buttonCerrarMantenimiento.TabIndex = 62;
            this.buttonCerrarMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCerrarMantenimiento.Click += new System.EventHandler(this.buttonCerrarMantenimiento_Click);
            // 
            // buttonReprogramarMantenimiento
            // 
            this.buttonReprogramarMantenimiento.ActiveBorderThickness = 1;
            this.buttonReprogramarMantenimiento.ActiveCornerRadius = 20;
            this.buttonReprogramarMantenimiento.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonReprogramarMantenimiento.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonReprogramarMantenimiento.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonReprogramarMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonReprogramarMantenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReprogramarMantenimiento.BackgroundImage")));
            this.buttonReprogramarMantenimiento.ButtonText = "Reprogramar Mantenimiento";
            this.buttonReprogramarMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.buttonReprogramarMantenimiento, BunifuAnimatorNS.DecorationType.None);
            this.buttonReprogramarMantenimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReprogramarMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonReprogramarMantenimiento.IdleBorderThickness = 1;
            this.buttonReprogramarMantenimiento.IdleCornerRadius = 20;
            this.buttonReprogramarMantenimiento.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonReprogramarMantenimiento.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonReprogramarMantenimiento.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonReprogramarMantenimiento.Location = new System.Drawing.Point(502, 7);
            this.buttonReprogramarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReprogramarMantenimiento.Name = "buttonReprogramarMantenimiento";
            this.buttonReprogramarMantenimiento.Size = new System.Drawing.Size(181, 41);
            this.buttonReprogramarMantenimiento.TabIndex = 62;
            this.buttonReprogramarMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonReprogramarMantenimiento.Click += new System.EventHandler(this.buttonReprogramarMantenimiento_Click);
            // 
            // BotonVerMantenimiento
            // 
            this.BotonVerMantenimiento.ActiveBorderThickness = 1;
            this.BotonVerMantenimiento.ActiveCornerRadius = 20;
            this.BotonVerMantenimiento.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonVerMantenimiento.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonVerMantenimiento.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonVerMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonVerMantenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonVerMantenimiento.BackgroundImage")));
            this.BotonVerMantenimiento.ButtonText = "Ver Mantenimiento";
            this.BotonVerMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.BotonVerMantenimiento, BunifuAnimatorNS.DecorationType.None);
            this.BotonVerMantenimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonVerMantenimiento.IdleBorderThickness = 1;
            this.BotonVerMantenimiento.IdleCornerRadius = 20;
            this.BotonVerMantenimiento.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonVerMantenimiento.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonVerMantenimiento.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonVerMantenimiento.Location = new System.Drawing.Point(255, 7);
            this.BotonVerMantenimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonVerMantenimiento.Name = "BotonVerMantenimiento";
            this.BotonVerMantenimiento.Size = new System.Drawing.Size(181, 41);
            this.BotonVerMantenimiento.TabIndex = 62;
            this.BotonVerMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonVerMantenimiento.Click += new System.EventHandler(this.BotonVerMantenimiento_Click);
            // 
            // BotonAgregarMantenimiento
            // 
            this.BotonAgregarMantenimiento.ActiveBorderThickness = 1;
            this.BotonAgregarMantenimiento.ActiveCornerRadius = 20;
            this.BotonAgregarMantenimiento.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarMantenimiento.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonAgregarMantenimiento.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonAgregarMantenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonAgregarMantenimiento.BackgroundImage")));
            this.BotonAgregarMantenimiento.ButtonText = "Agregar Mantenimiento";
            this.BotonAgregarMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.BotonAgregarMantenimiento, BunifuAnimatorNS.DecorationType.None);
            this.BotonAgregarMantenimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarMantenimiento.IdleBorderThickness = 1;
            this.BotonAgregarMantenimiento.IdleCornerRadius = 20;
            this.BotonAgregarMantenimiento.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonAgregarMantenimiento.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonAgregarMantenimiento.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarMantenimiento.Location = new System.Drawing.Point(29, 7);
            this.BotonAgregarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAgregarMantenimiento.Name = "BotonAgregarMantenimiento";
            this.BotonAgregarMantenimiento.Size = new System.Drawing.Size(181, 41);
            this.BotonAgregarMantenimiento.TabIndex = 61;
            this.BotonAgregarMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonAgregarMantenimiento.Click += new System.EventHandler(this.BotonAgregarMantenimiento_Click);
            // 
            // panelSwitches
            // 
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel2);
            this.panelSwitches.Controls.Add(this.switchEstadoMantenimeintoCerrado);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel1);
            this.panelSwitches.Controls.Add(this.switchEstadoMantenimeintoCancelado);
            this.panelSwitches.Controls.Add(this.SearchIcon);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel3);
            this.panelSwitches.Controls.Add(this.LabelswitchEstadoIncidenteCerrado);
            this.panelSwitches.Controls.Add(this.textBuscarTecnico);
            this.panelSwitches.Controls.Add(this.LabelSwitchEstadoIncidenteProceso);
            this.panelSwitches.Controls.Add(this.bunifuCustomLabel6);
            this.panelSwitches.Controls.Add(this.switchEstadoMantenimeintoProgreso);
            this.panelSwitches.Controls.Add(this.switchEstadoMantenimeintoAsignado);
            this.panelSwitches.Controls.Add(this.switchEstadoMantenimeintoDemorado);
            this.panelSwitches.Controls.Add(this.switchEstadoMantenimeintoAbierto);
            this.transiciones.SetDecoration(this.panelSwitches, BunifuAnimatorNS.DecorationType.None);
            this.panelSwitches.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSwitches.Location = new System.Drawing.Point(0, 24);
            this.panelSwitches.Name = "panelSwitches";
            this.panelSwitches.Size = new System.Drawing.Size(194, 681);
            this.panelSwitches.TabIndex = 82;
            this.panelSwitches.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(85, 180);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(62, 17);
            this.bunifuCustomLabel2.TabIndex = 81;
            this.bunifuCustomLabel2.Text = "Cerrado";
            // 
            // switchEstadoMantenimeintoCerrado
            // 
            this.switchEstadoMantenimeintoCerrado.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoMantenimeintoCerrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoMantenimeintoCerrado.BackgroundImage")));
            this.switchEstadoMantenimeintoCerrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoMantenimeintoCerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoMantenimeintoCerrado, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoMantenimeintoCerrado.Location = new System.Drawing.Point(40, 178);
            this.switchEstadoMantenimeintoCerrado.Name = "switchEstadoMantenimeintoCerrado";
            this.switchEstadoMantenimeintoCerrado.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoMantenimeintoCerrado.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoMantenimeintoCerrado.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoMantenimeintoCerrado.TabIndex = 80;
            this.switchEstadoMantenimeintoCerrado.Value = false;
            this.switchEstadoMantenimeintoCerrado.OnValueChange += new System.EventHandler(this.RefreshTabla);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(85, 146);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 17);
            this.bunifuCustomLabel1.TabIndex = 79;
            this.bunifuCustomLabel1.Text = "Cancelado";
            // 
            // switchEstadoMantenimeintoCancelado
            // 
            this.switchEstadoMantenimeintoCancelado.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoMantenimeintoCancelado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoMantenimeintoCancelado.BackgroundImage")));
            this.switchEstadoMantenimeintoCancelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoMantenimeintoCancelado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoMantenimeintoCancelado, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoMantenimeintoCancelado.Location = new System.Drawing.Point(40, 144);
            this.switchEstadoMantenimeintoCancelado.Name = "switchEstadoMantenimeintoCancelado";
            this.switchEstadoMantenimeintoCancelado.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoMantenimeintoCancelado.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoMantenimeintoCancelado.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoMantenimeintoCancelado.TabIndex = 78;
            this.switchEstadoMantenimeintoCancelado.Value = false;
            this.switchEstadoMantenimeintoCancelado.OnValueChange += new System.EventHandler(this.RefreshTabla);
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
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(85, 243);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 17);
            this.bunifuCustomLabel3.TabIndex = 69;
            this.bunifuCustomLabel3.Text = "Progreso";
            // 
            // LabelswitchEstadoIncidenteCerrado
            // 
            this.LabelswitchEstadoIncidenteCerrado.AutoSize = true;
            this.transiciones.SetDecoration(this.LabelswitchEstadoIncidenteCerrado, BunifuAnimatorNS.DecorationType.None);
            this.LabelswitchEstadoIncidenteCerrado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LabelswitchEstadoIncidenteCerrado.ForeColor = System.Drawing.Color.Silver;
            this.LabelswitchEstadoIncidenteCerrado.Location = new System.Drawing.Point(85, 213);
            this.LabelswitchEstadoIncidenteCerrado.Name = "LabelswitchEstadoIncidenteCerrado";
            this.LabelswitchEstadoIncidenteCerrado.Size = new System.Drawing.Size(79, 17);
            this.LabelswitchEstadoIncidenteCerrado.TabIndex = 69;
            this.LabelswitchEstadoIncidenteCerrado.Text = "Demorado";
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
            this.LabelSwitchEstadoIncidenteProceso.Location = new System.Drawing.Point(85, 112);
            this.LabelSwitchEstadoIncidenteProceso.Name = "LabelSwitchEstadoIncidenteProceso";
            this.LabelSwitchEstadoIncidenteProceso.Size = new System.Drawing.Size(69, 17);
            this.LabelSwitchEstadoIncidenteProceso.TabIndex = 68;
            this.LabelSwitchEstadoIncidenteProceso.Text = "Asignado";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(85, 79);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(55, 17);
            this.bunifuCustomLabel6.TabIndex = 67;
            this.bunifuCustomLabel6.Text = "Abierto";
            // 
            // switchEstadoMantenimeintoProgreso
            // 
            this.switchEstadoMantenimeintoProgreso.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoMantenimeintoProgreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoMantenimeintoProgreso.BackgroundImage")));
            this.switchEstadoMantenimeintoProgreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoMantenimeintoProgreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoMantenimeintoProgreso, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoMantenimeintoProgreso.Location = new System.Drawing.Point(40, 241);
            this.switchEstadoMantenimeintoProgreso.Name = "switchEstadoMantenimeintoProgreso";
            this.switchEstadoMantenimeintoProgreso.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoMantenimeintoProgreso.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoMantenimeintoProgreso.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoMantenimeintoProgreso.TabIndex = 65;
            this.switchEstadoMantenimeintoProgreso.Value = false;
            this.switchEstadoMantenimeintoProgreso.OnValueChange += new System.EventHandler(this.RefreshTabla);
            // 
            // switchEstadoMantenimeintoAsignado
            // 
            this.switchEstadoMantenimeintoAsignado.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoMantenimeintoAsignado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoMantenimeintoAsignado.BackgroundImage")));
            this.switchEstadoMantenimeintoAsignado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoMantenimeintoAsignado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoMantenimeintoAsignado, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoMantenimeintoAsignado.Location = new System.Drawing.Point(40, 110);
            this.switchEstadoMantenimeintoAsignado.Name = "switchEstadoMantenimeintoAsignado";
            this.switchEstadoMantenimeintoAsignado.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoMantenimeintoAsignado.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoMantenimeintoAsignado.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoMantenimeintoAsignado.TabIndex = 66;
            this.switchEstadoMantenimeintoAsignado.Value = false;
            this.switchEstadoMantenimeintoAsignado.OnValueChange += new System.EventHandler(this.RefreshTabla);
            // 
            // switchEstadoMantenimeintoDemorado
            // 
            this.switchEstadoMantenimeintoDemorado.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoMantenimeintoDemorado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoMantenimeintoDemorado.BackgroundImage")));
            this.switchEstadoMantenimeintoDemorado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoMantenimeintoDemorado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoMantenimeintoDemorado, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoMantenimeintoDemorado.Location = new System.Drawing.Point(40, 211);
            this.switchEstadoMantenimeintoDemorado.Name = "switchEstadoMantenimeintoDemorado";
            this.switchEstadoMantenimeintoDemorado.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoMantenimeintoDemorado.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoMantenimeintoDemorado.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoMantenimeintoDemorado.TabIndex = 65;
            this.switchEstadoMantenimeintoDemorado.Value = false;
            this.switchEstadoMantenimeintoDemorado.OnValueChange += new System.EventHandler(this.RefreshTabla);
            // 
            // switchEstadoMantenimeintoAbierto
            // 
            this.switchEstadoMantenimeintoAbierto.BackColor = System.Drawing.Color.Transparent;
            this.switchEstadoMantenimeintoAbierto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEstadoMantenimeintoAbierto.BackgroundImage")));
            this.switchEstadoMantenimeintoAbierto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEstadoMantenimeintoAbierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.switchEstadoMantenimeintoAbierto, BunifuAnimatorNS.DecorationType.None);
            this.switchEstadoMantenimeintoAbierto.Location = new System.Drawing.Point(40, 77);
            this.switchEstadoMantenimeintoAbierto.Name = "switchEstadoMantenimeintoAbierto";
            this.switchEstadoMantenimeintoAbierto.OffColor = System.Drawing.Color.Gray;
            this.switchEstadoMantenimeintoAbierto.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.switchEstadoMantenimeintoAbierto.Size = new System.Drawing.Size(35, 20);
            this.switchEstadoMantenimeintoAbierto.TabIndex = 64;
            this.switchEstadoMantenimeintoAbierto.Value = true;
            this.switchEstadoMantenimeintoAbierto.OnValueChange += new System.EventHandler(this.RefreshTabla);
            // 
            // espaciadorTop
            // 
            this.transiciones.SetDecoration(this.espaciadorTop, BunifuAnimatorNS.DecorationType.None);
            this.espaciadorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.espaciadorTop.Location = new System.Drawing.Point(0, 0);
            this.espaciadorTop.Name = "espaciadorTop";
            this.espaciadorTop.Size = new System.Drawing.Size(1240, 24);
            this.espaciadorTop.TabIndex = 82;
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
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.transiciones.DefaultAnimation = animation4;
            // 
            // ABM_Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1240, 740);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.Header);
            this.transiciones.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_Mantenimientos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerIncidentePicture)).EndInit();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMantenimientos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelSwitches.ResumeLayout(false);
            this.panelSwitches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn severidad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTabla;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonAgregarMantenimiento;
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
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoMantenimeintoAsignado;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoMantenimeintoDemorado;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoMantenimeintoAbierto;
        private BunifuAnimatorNS.BunifuTransition transiciones;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaMantenimientos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonVerMantenimiento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoMantenimeintoCerrado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoMantenimeintoCancelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMantenimiento;
        private System.Windows.Forms.Panel espaciadorTop;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonReprogramarMantenimiento;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonCerrarMantenimiento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEstadoMantenimeintoProgreso;
    }
}
