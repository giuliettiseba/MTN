namespace MTN_Administration.Tabs
{
    partial class Ver_Mantenimiento
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_Mantenimiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.transiciones = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Incidente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tablaIncidentes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dipositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textTecnico2_Rango = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textTecnico2_Apellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textTecnico2_nombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textTecnico1_Rango = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textTecnico1_Apellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textTecnico1_nombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textHoraFin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textHoraInicio = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textTipoMantenimiento = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TextObservaciones = new MTN_Administration.CustomTextBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelCliente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textSucursalCiudad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textSucursalProvincia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textSucursal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labelSucursal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textCliente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonVerIncidente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textEstado = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIncidentes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cerrar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(480, 659);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 54;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Incidente
            // 
            this.Incidente.AutoSize = true;
            this.transiciones.SetDecoration(this.Incidente, BunifuAnimatorNS.DecorationType.None);
            this.Incidente.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.Incidente.ForeColor = System.Drawing.Color.Silver;
            this.Incidente.Location = new System.Drawing.Point(23, 468);
            this.Incidente.Name = "Incidente";
            this.Incidente.Size = new System.Drawing.Size(137, 30);
            this.Incidente.TabIndex = 75;
            this.Incidente.Text = "Incidentes";
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
            this.tablaIncidentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIncidentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaIncidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIncidentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipo,
            this.dipositivo,
            this.camara,
            this.criticidad,
            this.estado,
            this.asignado});
            this.transiciones.SetDecoration(this.tablaIncidentes, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaIncidentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaIncidentes.DoubleBuffered = true;
            this.tablaIncidentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaIncidentes.EnableHeadersVisualStyles = false;
            this.tablaIncidentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.tablaIncidentes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.tablaIncidentes.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaIncidentes.Location = new System.Drawing.Point(20, 514);
            this.tablaIncidentes.Name = "tablaIncidentes";
            this.tablaIncidentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIncidentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaIncidentes.RowHeadersVisible = false;
            this.tablaIncidentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaIncidentes.ShowCellErrors = false;
            this.tablaIncidentes.ShowCellToolTips = false;
            this.tablaIncidentes.ShowEditingIcon = false;
            this.tablaIncidentes.ShowRowErrors = false;
            this.tablaIncidentes.Size = new System.Drawing.Size(1186, 137);
            this.tablaIncidentes.TabIndex = 82;
            this.tablaIncidentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaIncidentes_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // dipositivo
            // 
            this.dipositivo.HeaderText = "Dispositivo";
            this.dipositivo.Name = "dipositivo";
            // 
            // camara
            // 
            this.camara.HeaderText = "Camara";
            this.camara.Name = "camara";
            // 
            // criticidad
            // 
            this.criticidad.HeaderText = "Criticidad";
            this.criticidad.Name = "criticidad";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // asignado
            // 
            this.asignado.HeaderText = "Asignado";
            this.asignado.Name = "asignado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textTecnico2_Rango);
            this.panel1.Controls.Add(this.textTecnico2_Apellido);
            this.panel1.Controls.Add(this.textTecnico2_nombre);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.textTecnico1_Rango);
            this.panel1.Controls.Add(this.textTecnico1_Apellido);
            this.panel1.Controls.Add(this.textTecnico1_nombre);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.textHoraFin);
            this.panel1.Controls.Add(this.textHoraInicio);
            this.panel1.Controls.Add(this.textTipoMantenimiento);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.bunifuCustomLabel13);
            this.panel1.Controls.Add(this.bunifuCustomLabel12);
            this.panel1.Controls.Add(this.TextObservaciones);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Controls.Add(this.textSucursalCiudad);
            this.panel1.Controls.Add(this.textSucursalProvincia);
            this.panel1.Controls.Add(this.textSucursal);
            this.panel1.Controls.Add(this.labelSucursal);
            this.panel1.Controls.Add(this.textEstado);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.textCliente);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.tablaIncidentes);
            this.panel1.Controls.Add(this.Incidente);
            this.panel1.Controls.Add(this.buttonVerIncidente);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.transiciones.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 705);
            this.panel1.TabIndex = 97;
            // 
            // textTecnico2_Rango
            // 
            this.textTecnico2_Rango.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico2_Rango.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textTecnico2_Rango.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico2_Rango.BorderThickness = 1;
            this.textTecnico2_Rango.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textTecnico2_Rango, BunifuAnimatorNS.DecorationType.None);
            this.textTecnico2_Rango.Enabled = false;
            this.textTecnico2_Rango.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textTecnico2_Rango.ForeColor = System.Drawing.Color.Coral;
            this.textTecnico2_Rango.isPassword = false;
            this.textTecnico2_Rango.Location = new System.Drawing.Point(875, 313);
            this.textTecnico2_Rango.Margin = new System.Windows.Forms.Padding(4);
            this.textTecnico2_Rango.Name = "textTecnico2_Rango";
            this.textTecnico2_Rango.Size = new System.Drawing.Size(321, 35);
            this.textTecnico2_Rango.TabIndex = 121;
            this.textTecnico2_Rango.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textTecnico2_Apellido
            // 
            this.textTecnico2_Apellido.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico2_Apellido.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textTecnico2_Apellido.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico2_Apellido.BorderThickness = 1;
            this.textTecnico2_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textTecnico2_Apellido, BunifuAnimatorNS.DecorationType.None);
            this.textTecnico2_Apellido.Enabled = false;
            this.textTecnico2_Apellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textTecnico2_Apellido.ForeColor = System.Drawing.Color.Coral;
            this.textTecnico2_Apellido.isPassword = false;
            this.textTecnico2_Apellido.Location = new System.Drawing.Point(522, 313);
            this.textTecnico2_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.textTecnico2_Apellido.Name = "textTecnico2_Apellido";
            this.textTecnico2_Apellido.Size = new System.Drawing.Size(321, 35);
            this.textTecnico2_Apellido.TabIndex = 120;
            this.textTecnico2_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textTecnico2_nombre
            // 
            this.textTecnico2_nombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico2_nombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textTecnico2_nombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico2_nombre.BorderThickness = 1;
            this.textTecnico2_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textTecnico2_nombre, BunifuAnimatorNS.DecorationType.None);
            this.textTecnico2_nombre.Enabled = false;
            this.textTecnico2_nombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textTecnico2_nombre.ForeColor = System.Drawing.Color.Coral;
            this.textTecnico2_nombre.isPassword = false;
            this.textTecnico2_nombre.Location = new System.Drawing.Point(169, 313);
            this.textTecnico2_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.textTecnico2_nombre.Name = "textTecnico2_nombre";
            this.textTecnico2_nombre.Size = new System.Drawing.Size(321, 35);
            this.textTecnico2_nombre.TabIndex = 119;
            this.textTecnico2_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(20, 315);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(129, 30);
            this.bunifuCustomLabel2.TabIndex = 118;
            this.bunifuCustomLabel2.Text = "Tecnico 2";
            // 
            // textTecnico1_Rango
            // 
            this.textTecnico1_Rango.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico1_Rango.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textTecnico1_Rango.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico1_Rango.BorderThickness = 1;
            this.textTecnico1_Rango.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textTecnico1_Rango, BunifuAnimatorNS.DecorationType.None);
            this.textTecnico1_Rango.Enabled = false;
            this.textTecnico1_Rango.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textTecnico1_Rango.ForeColor = System.Drawing.Color.Coral;
            this.textTecnico1_Rango.isPassword = false;
            this.textTecnico1_Rango.Location = new System.Drawing.Point(875, 261);
            this.textTecnico1_Rango.Margin = new System.Windows.Forms.Padding(4);
            this.textTecnico1_Rango.Name = "textTecnico1_Rango";
            this.textTecnico1_Rango.Size = new System.Drawing.Size(321, 35);
            this.textTecnico1_Rango.TabIndex = 117;
            this.textTecnico1_Rango.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textTecnico1_Apellido
            // 
            this.textTecnico1_Apellido.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico1_Apellido.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textTecnico1_Apellido.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico1_Apellido.BorderThickness = 1;
            this.textTecnico1_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textTecnico1_Apellido, BunifuAnimatorNS.DecorationType.None);
            this.textTecnico1_Apellido.Enabled = false;
            this.textTecnico1_Apellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textTecnico1_Apellido.ForeColor = System.Drawing.Color.Coral;
            this.textTecnico1_Apellido.isPassword = false;
            this.textTecnico1_Apellido.Location = new System.Drawing.Point(522, 261);
            this.textTecnico1_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.textTecnico1_Apellido.Name = "textTecnico1_Apellido";
            this.textTecnico1_Apellido.Size = new System.Drawing.Size(321, 35);
            this.textTecnico1_Apellido.TabIndex = 116;
            this.textTecnico1_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textTecnico1_nombre
            // 
            this.textTecnico1_nombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico1_nombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textTecnico1_nombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTecnico1_nombre.BorderThickness = 1;
            this.textTecnico1_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textTecnico1_nombre, BunifuAnimatorNS.DecorationType.None);
            this.textTecnico1_nombre.Enabled = false;
            this.textTecnico1_nombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textTecnico1_nombre.ForeColor = System.Drawing.Color.Coral;
            this.textTecnico1_nombre.isPassword = false;
            this.textTecnico1_nombre.Location = new System.Drawing.Point(169, 261);
            this.textTecnico1_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.textTecnico1_nombre.Name = "textTecnico1_nombre";
            this.textTecnico1_nombre.Size = new System.Drawing.Size(321, 35);
            this.textTecnico1_nombre.TabIndex = 115;
            this.textTecnico1_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 263);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(129, 30);
            this.bunifuCustomLabel1.TabIndex = 114;
            this.bunifuCustomLabel1.Text = "Tecnico 1";
            // 
            // textHoraFin
            // 
            this.textHoraFin.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textHoraFin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textHoraFin.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textHoraFin.BorderThickness = 1;
            this.textHoraFin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textHoraFin, BunifuAnimatorNS.DecorationType.None);
            this.textHoraFin.Enabled = false;
            this.textHoraFin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textHoraFin.ForeColor = System.Drawing.Color.Coral;
            this.textHoraFin.isPassword = false;
            this.textHoraFin.Location = new System.Drawing.Point(545, 195);
            this.textHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.textHoraFin.Name = "textHoraFin";
            this.textHoraFin.Size = new System.Drawing.Size(142, 35);
            this.textHoraFin.TabIndex = 113;
            this.textHoraFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textHoraInicio
            // 
            this.textHoraInicio.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textHoraInicio.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textHoraInicio.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textHoraInicio.BorderThickness = 1;
            this.textHoraInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textHoraInicio, BunifuAnimatorNS.DecorationType.None);
            this.textHoraInicio.Enabled = false;
            this.textHoraInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textHoraInicio.ForeColor = System.Drawing.Color.Coral;
            this.textHoraInicio.isPassword = false;
            this.textHoraInicio.Location = new System.Drawing.Point(169, 195);
            this.textHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.textHoraInicio.Name = "textHoraInicio";
            this.textHoraInicio.Size = new System.Drawing.Size(146, 35);
            this.textHoraInicio.TabIndex = 112;
            this.textHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textTipoMantenimiento
            // 
            this.textTipoMantenimiento.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTipoMantenimiento.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textTipoMantenimiento.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textTipoMantenimiento.BorderThickness = 1;
            this.textTipoMantenimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textTipoMantenimiento, BunifuAnimatorNS.DecorationType.None);
            this.textTipoMantenimiento.Enabled = false;
            this.textTipoMantenimiento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textTipoMantenimiento.ForeColor = System.Drawing.Color.Coral;
            this.textTipoMantenimiento.isPassword = false;
            this.textTipoMantenimiento.Location = new System.Drawing.Point(304, 31);
            this.textTipoMantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.textTipoMantenimiento.Name = "textTipoMantenimiento";
            this.textTipoMantenimiento.Size = new System.Drawing.Size(321, 35);
            this.textTipoMantenimiento.TabIndex = 111;
            this.textTipoMantenimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fecha
            // 
            this.fecha.BackColor = System.Drawing.Color.SeaGreen;
            this.fecha.BorderRadius = 0;
            this.transiciones.SetDecoration(this.fecha, BunifuAnimatorNS.DecorationType.None);
            this.fecha.Enabled = false;
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fecha.FormatCustom = null;
            this.fecha.Location = new System.Drawing.Point(875, 195);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(321, 35);
            this.fecha.TabIndex = 110;
            this.fecha.Value = new System.DateTime(2019, 1, 9, 0, 27, 17, 599);
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(755, 197);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(88, 30);
            this.bunifuCustomLabel13.TabIndex = 109;
            this.bunifuCustomLabel13.Text = "Fecha";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(20, 363);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(193, 30);
            this.bunifuCustomLabel12.TabIndex = 108;
            this.bunifuCustomLabel12.Text = "Observaciones";
            // 
            // TextObservaciones
            // 
            this.TextObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.TextObservaciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.TextObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transiciones.SetDecoration(this.TextObservaciones, BunifuAnimatorNS.DecorationType.None);
            this.TextObservaciones.Enabled = false;
            this.TextObservaciones.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TextObservaciones.ForeColor = System.Drawing.Color.Coral;
            this.TextObservaciones.Location = new System.Drawing.Point(20, 407);
            this.TextObservaciones.Multiline = true;
            this.TextObservaciones.Name = "TextObservaciones";
            this.TextObservaciones.ReadOnly = true;
            this.TextObservaciones.Size = new System.Drawing.Size(1169, 49);
            this.TextObservaciones.TabIndex = 107;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(430, 197);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(108, 30);
            this.bunifuCustomLabel11.TabIndex = 106;
            this.bunifuCustomLabel11.Text = "Hora Fin";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(20, 197);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(140, 30);
            this.bunifuCustomLabel10.TabIndex = 105;
            this.bunifuCustomLabel10.Text = "Hora Inicio";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.transiciones.SetDecoration(this.labelCliente, BunifuAnimatorNS.DecorationType.None);
            this.labelCliente.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.Silver;
            this.labelCliente.Location = new System.Drawing.Point(20, 31);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(253, 30);
            this.labelCliente.TabIndex = 90;
            this.labelCliente.Text = "Tipo Mantenimiento";
            // 
            // textSucursalCiudad
            // 
            this.textSucursalCiudad.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textSucursalCiudad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textSucursalCiudad.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textSucursalCiudad.BorderThickness = 1;
            this.textSucursalCiudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textSucursalCiudad, BunifuAnimatorNS.DecorationType.None);
            this.textSucursalCiudad.Enabled = false;
            this.textSucursalCiudad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textSucursalCiudad.ForeColor = System.Drawing.Color.Coral;
            this.textSucursalCiudad.isPassword = false;
            this.textSucursalCiudad.Location = new System.Drawing.Point(875, 141);
            this.textSucursalCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.textSucursalCiudad.Name = "textSucursalCiudad";
            this.textSucursalCiudad.Size = new System.Drawing.Size(321, 35);
            this.textSucursalCiudad.TabIndex = 89;
            this.textSucursalCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textSucursalProvincia
            // 
            this.textSucursalProvincia.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textSucursalProvincia.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textSucursalProvincia.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textSucursalProvincia.BorderThickness = 1;
            this.textSucursalProvincia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textSucursalProvincia, BunifuAnimatorNS.DecorationType.None);
            this.textSucursalProvincia.Enabled = false;
            this.textSucursalProvincia.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textSucursalProvincia.ForeColor = System.Drawing.Color.Coral;
            this.textSucursalProvincia.isPassword = false;
            this.textSucursalProvincia.Location = new System.Drawing.Point(522, 141);
            this.textSucursalProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.textSucursalProvincia.Name = "textSucursalProvincia";
            this.textSucursalProvincia.Size = new System.Drawing.Size(321, 35);
            this.textSucursalProvincia.TabIndex = 88;
            this.textSucursalProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textSucursal
            // 
            this.textSucursal.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textSucursal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textSucursal.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textSucursal.BorderThickness = 1;
            this.textSucursal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textSucursal, BunifuAnimatorNS.DecorationType.None);
            this.textSucursal.Enabled = false;
            this.textSucursal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textSucursal.ForeColor = System.Drawing.Color.Coral;
            this.textSucursal.isPassword = false;
            this.textSucursal.Location = new System.Drawing.Point(169, 141);
            this.textSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.textSucursal.Name = "textSucursal";
            this.textSucursal.Size = new System.Drawing.Size(321, 35);
            this.textSucursal.TabIndex = 87;
            this.textSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.transiciones.SetDecoration(this.labelSucursal, BunifuAnimatorNS.DecorationType.None);
            this.labelSucursal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSucursal.ForeColor = System.Drawing.Color.Silver;
            this.labelSucursal.Location = new System.Drawing.Point(20, 143);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(110, 30);
            this.labelSucursal.TabIndex = 86;
            this.labelSucursal.Text = "Sucursal";
            // 
            // textCliente
            // 
            this.textCliente.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textCliente.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textCliente.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textCliente.BorderThickness = 1;
            this.textCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textCliente, BunifuAnimatorNS.DecorationType.None);
            this.textCliente.Enabled = false;
            this.textCliente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textCliente.ForeColor = System.Drawing.Color.Coral;
            this.textCliente.isPassword = false;
            this.textCliente.Location = new System.Drawing.Point(169, 94);
            this.textCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(321, 35);
            this.textCliente.TabIndex = 85;
            this.textCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(20, 96);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(100, 30);
            this.bunifuCustomLabel7.TabIndex = 84;
            this.bunifuCustomLabel7.Text = "Cliente";
            // 
            // buttonVerIncidente
            // 
            this.buttonVerIncidente.ActiveBorderThickness = 1;
            this.buttonVerIncidente.ActiveCornerRadius = 20;
            this.buttonVerIncidente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonVerIncidente.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonVerIncidente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonVerIncidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonVerIncidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVerIncidente.BackgroundImage")));
            this.buttonVerIncidente.ButtonText = "Ver Incidente";
            this.buttonVerIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.buttonVerIncidente, BunifuAnimatorNS.DecorationType.None);
            this.buttonVerIncidente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerIncidente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonVerIncidente.IdleBorderThickness = 1;
            this.buttonVerIncidente.IdleCornerRadius = 20;
            this.buttonVerIncidente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonVerIncidente.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.buttonVerIncidente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonVerIncidente.Location = new System.Drawing.Point(721, 659);
            this.buttonVerIncidente.Margin = new System.Windows.Forms.Padding(5);
            this.buttonVerIncidente.Name = "buttonVerIncidente";
            this.buttonVerIncidente.Size = new System.Drawing.Size(181, 41);
            this.buttonVerIncidente.TabIndex = 54;
            this.buttonVerIncidente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonVerIncidente.Click += new System.EventHandler(this.buttonVerIncidente_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(755, 54);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(92, 30);
            this.bunifuCustomLabel3.TabIndex = 84;
            this.bunifuCustomLabel3.Text = "Estado";
            // 
            // textEstado
            // 
            this.textEstado.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textEstado.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textEstado.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textEstado.BorderThickness = 1;
            this.textEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.textEstado, BunifuAnimatorNS.DecorationType.None);
            this.textEstado.Enabled = false;
            this.textEstado.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstado.ForeColor = System.Drawing.Color.Coral;
            this.textEstado.isPassword = false;
            this.textEstado.Location = new System.Drawing.Point(876, 24);
            this.textEstado.Margin = new System.Windows.Forms.Padding(4);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(313, 88);
            this.textEstado.TabIndex = 85;
            this.textEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Ver_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel1);
            this.transiciones.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Ver_Mantenimiento";
            this.Size = new System.Drawing.Size(1240, 705);
            ((System.ComponentModel.ISupportInitialize)(this.tablaIncidentes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition transiciones;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel Incidente;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaIncidentes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_mantenible;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_criticidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado_incidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dipositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn camara;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel labelCliente;
        private Bunifu.Framework.UI.BunifuMetroTextbox textSucursalCiudad;
        private Bunifu.Framework.UI.BunifuMetroTextbox textSucursalProvincia;
        private Bunifu.Framework.UI.BunifuMetroTextbox textSucursal;
        private Bunifu.Framework.UI.BunifuCustomLabel labelSucursal;
        private Bunifu.Framework.UI.BunifuMetroTextbox textCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMetroTextbox textHoraFin;
        private Bunifu.Framework.UI.BunifuMetroTextbox textHoraInicio;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTipoMantenimiento;
        private Bunifu.Framework.UI.BunifuDatepicker fecha;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private CustomTextBox TextObservaciones;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTecnico2_Rango;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTecnico2_Apellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTecnico2_nombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTecnico1_Rango;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTecnico1_Apellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTecnico1_nombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonVerIncidente;
        private Bunifu.Framework.UI.BunifuMetroTextbox textEstado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}
