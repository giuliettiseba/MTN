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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Incidentes));
            this.tablaTecnicos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonCerrarIncidente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonEditarInicidente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonAgregarIncidente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filtroSeveridadTodas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filtroSeveridadBaja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filtroCCTV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBuscarTecnico = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.filtroSeveridadMedia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filtroSeveridadAlta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filtroAlarmas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sliderFiltroTecnicos = new System.Windows.Forms.PictureBox();
            this.filtroTodo = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTecnicos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFiltroTecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaTecnicos
            // 
            this.tablaTecnicos.AllowUserToAddRows = false;
            this.tablaTecnicos.AllowUserToDeleteRows = false;
            this.tablaTecnicos.AllowUserToResizeColumns = false;
            this.tablaTecnicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaTecnicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTecnicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tablaTecnicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaTecnicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTecnicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.sucursal,
            this.tipoDispositivo,
            this.Dispositivo,
            this.estado,
            this.severidad,
            this.asignado});
            this.tablaTecnicos.DoubleBuffered = true;
            this.tablaTecnicos.EnableHeadersVisualStyles = false;
            this.tablaTecnicos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.tablaTecnicos.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaTecnicos.Location = new System.Drawing.Point(0, 34);
            this.tablaTecnicos.MultiSelect = false;
            this.tablaTecnicos.Name = "tablaTecnicos";
            this.tablaTecnicos.ReadOnly = true;
            this.tablaTecnicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaTecnicos.RowHeadersVisible = false;
            this.tablaTecnicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTecnicos.ShowCellErrors = false;
            this.tablaTecnicos.ShowCellToolTips = false;
            this.tablaTecnicos.ShowEditingIcon = false;
            this.tablaTecnicos.ShowRowErrors = false;
            this.tablaTecnicos.Size = new System.Drawing.Size(724, 491);
            this.tablaTecnicos.TabIndex = 16;
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 74;
            // 
            // sucursal
            // 
            this.sucursal.HeaderText = "Sucursal";
            this.sucursal.Name = "sucursal";
            this.sucursal.ReadOnly = true;
            this.sucursal.Width = 80;
            // 
            // tipoDispositivo
            // 
            this.tipoDispositivo.HeaderText = "Tipo Dispositivo";
            this.tipoDispositivo.Name = "tipoDispositivo";
            this.tipoDispositivo.ReadOnly = true;
            this.tipoDispositivo.Width = 123;
            // 
            // Dispositivo
            // 
            this.Dispositivo.HeaderText = "Dispositivo";
            this.Dispositivo.Name = "Dispositivo";
            this.Dispositivo.ReadOnly = true;
            this.Dispositivo.Width = 96;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 71;
            // 
            // severidad
            // 
            this.severidad.HeaderText = "Severidad";
            this.severidad.Name = "severidad";
            this.severidad.ReadOnly = true;
            this.severidad.Width = 93;
            // 
            // asignado
            // 
            this.asignado.HeaderText = "Asignado";
            this.asignado.Name = "asignado";
            this.asignado.ReadOnly = true;
            this.asignado.Width = 87;
            // 
            // BotonCerrarIncidente
            // 
            this.BotonCerrarIncidente.ActiveBorderThickness = 1;
            this.BotonCerrarIncidente.ActiveCornerRadius = 20;
            this.BotonCerrarIncidente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonCerrarIncidente.ActiveForecolor = System.Drawing.Color.White;
            this.BotonCerrarIncidente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonCerrarIncidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonCerrarIncidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonCerrarIncidente.BackgroundImage")));
            this.BotonCerrarIncidente.ButtonText = "Cerrar Incidente";
            this.BotonCerrarIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrarIncidente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarIncidente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonCerrarIncidente.IdleBorderThickness = 1;
            this.BotonCerrarIncidente.IdleCornerRadius = 20;
            this.BotonCerrarIncidente.IdleFillColor = System.Drawing.Color.White;
            this.BotonCerrarIncidente.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonCerrarIncidente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonCerrarIncidente.Location = new System.Drawing.Point(286, 532);
            this.BotonCerrarIncidente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonCerrarIncidente.Name = "BotonCerrarIncidente";
            this.BotonCerrarIncidente.Size = new System.Drawing.Size(122, 33);
            this.BotonCerrarIncidente.TabIndex = 19;
            this.BotonCerrarIncidente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonEditarInicidente
            // 
            this.BotonEditarInicidente.ActiveBorderThickness = 1;
            this.BotonEditarInicidente.ActiveCornerRadius = 20;
            this.BotonEditarInicidente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEditarInicidente.ActiveForecolor = System.Drawing.Color.White;
            this.BotonEditarInicidente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEditarInicidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonEditarInicidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonEditarInicidente.BackgroundImage")));
            this.BotonEditarInicidente.ButtonText = "Editar Incidente";
            this.BotonEditarInicidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEditarInicidente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEditarInicidente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEditarInicidente.IdleBorderThickness = 1;
            this.BotonEditarInicidente.IdleCornerRadius = 20;
            this.BotonEditarInicidente.IdleFillColor = System.Drawing.Color.White;
            this.BotonEditarInicidente.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEditarInicidente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEditarInicidente.Location = new System.Drawing.Point(537, 532);
            this.BotonEditarInicidente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEditarInicidente.Name = "BotonEditarInicidente";
            this.BotonEditarInicidente.Size = new System.Drawing.Size(122, 33);
            this.BotonEditarInicidente.TabIndex = 18;
            this.BotonEditarInicidente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonAgregarIncidente
            // 
            this.BotonAgregarIncidente.ActiveBorderThickness = 1;
            this.BotonAgregarIncidente.ActiveCornerRadius = 20;
            this.BotonAgregarIncidente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarIncidente.ActiveForecolor = System.Drawing.Color.White;
            this.BotonAgregarIncidente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarIncidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonAgregarIncidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonAgregarIncidente.BackgroundImage")));
            this.BotonAgregarIncidente.ButtonText = "Agregar Incidente";
            this.BotonAgregarIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgregarIncidente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarIncidente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarIncidente.IdleBorderThickness = 1;
            this.BotonAgregarIncidente.IdleCornerRadius = 20;
            this.BotonAgregarIncidente.IdleFillColor = System.Drawing.Color.White;
            this.BotonAgregarIncidente.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarIncidente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarIncidente.Location = new System.Drawing.Point(25, 532);
            this.BotonAgregarIncidente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAgregarIncidente.Name = "BotonAgregarIncidente";
            this.BotonAgregarIncidente.Size = new System.Drawing.Size(132, 33);
            this.BotonAgregarIncidente.TabIndex = 17;
            this.BotonAgregarIncidente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonAgregarIncidente.Click += new System.EventHandler(this.BotonAgregarIncidente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filtroSeveridadTodas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.filtroSeveridadBaja);
            this.panel1.Controls.Add(this.filtroCCTV);
            this.panel1.Controls.Add(this.textBuscarTecnico);
            this.panel1.Controls.Add(this.SearchIcon);
            this.panel1.Controls.Add(this.filtroSeveridadMedia);
            this.panel1.Controls.Add(this.filtroSeveridadAlta);
            this.panel1.Controls.Add(this.filtroAlarmas);
            this.panel1.Controls.Add(this.sliderFiltroTecnicos);
            this.panel1.Controls.Add(this.filtroTodo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 35);
            this.panel1.TabIndex = 15;
            // 
            // filtroSeveridadTodas
            // 
            this.filtroSeveridadTodas.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadTodas.BackColor = System.Drawing.Color.Transparent;
            this.filtroSeveridadTodas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroSeveridadTodas.BorderRadius = 0;
            this.filtroSeveridadTodas.ButtonText = "Todos";
            this.filtroSeveridadTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroSeveridadTodas.DisabledColor = System.Drawing.Color.Gray;
            this.filtroSeveridadTodas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroSeveridadTodas.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroSeveridadTodas.Iconimage = null;
            this.filtroSeveridadTodas.Iconimage_right = null;
            this.filtroSeveridadTodas.Iconimage_right_Selected = null;
            this.filtroSeveridadTodas.Iconimage_Selected = null;
            this.filtroSeveridadTodas.IconMarginLeft = 0;
            this.filtroSeveridadTodas.IconMarginRight = 0;
            this.filtroSeveridadTodas.IconRightVisible = true;
            this.filtroSeveridadTodas.IconRightZoom = 0D;
            this.filtroSeveridadTodas.IconVisible = true;
            this.filtroSeveridadTodas.IconZoom = 90D;
            this.filtroSeveridadTodas.IsTab = false;
            this.filtroSeveridadTodas.Location = new System.Drawing.Point(238, 9);
            this.filtroSeveridadTodas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroSeveridadTodas.Name = "filtroSeveridadTodas";
            this.filtroSeveridadTodas.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadTodas.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadTodas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroSeveridadTodas.selected = false;
            this.filtroSeveridadTodas.Size = new System.Drawing.Size(50, 16);
            this.filtroSeveridadTodas.TabIndex = 16;
            this.filtroSeveridadTodas.Text = "Todos";
            this.filtroSeveridadTodas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroSeveridadTodas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroSeveridadTodas.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pictureBox1.Location = new System.Drawing.Point(236, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 3);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // filtroSeveridadBaja
            // 
            this.filtroSeveridadBaja.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadBaja.BackColor = System.Drawing.Color.Transparent;
            this.filtroSeveridadBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroSeveridadBaja.BorderRadius = 0;
            this.filtroSeveridadBaja.ButtonText = "Baja";
            this.filtroSeveridadBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroSeveridadBaja.DisabledColor = System.Drawing.Color.Gray;
            this.filtroSeveridadBaja.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroSeveridadBaja.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroSeveridadBaja.Iconimage = null;
            this.filtroSeveridadBaja.Iconimage_right = null;
            this.filtroSeveridadBaja.Iconimage_right_Selected = null;
            this.filtroSeveridadBaja.Iconimage_Selected = null;
            this.filtroSeveridadBaja.IconMarginLeft = 0;
            this.filtroSeveridadBaja.IconMarginRight = 0;
            this.filtroSeveridadBaja.IconRightVisible = true;
            this.filtroSeveridadBaja.IconRightZoom = 0D;
            this.filtroSeveridadBaja.IconVisible = true;
            this.filtroSeveridadBaja.IconZoom = 90D;
            this.filtroSeveridadBaja.IsTab = false;
            this.filtroSeveridadBaja.Location = new System.Drawing.Point(404, 9);
            this.filtroSeveridadBaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroSeveridadBaja.Name = "filtroSeveridadBaja";
            this.filtroSeveridadBaja.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadBaja.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadBaja.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroSeveridadBaja.selected = false;
            this.filtroSeveridadBaja.Size = new System.Drawing.Size(63, 16);
            this.filtroSeveridadBaja.TabIndex = 14;
            this.filtroSeveridadBaja.Text = "Baja";
            this.filtroSeveridadBaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroSeveridadBaja.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroSeveridadBaja.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // filtroCCTV
            // 
            this.filtroCCTV.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroCCTV.BackColor = System.Drawing.Color.Transparent;
            this.filtroCCTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroCCTV.BorderRadius = 0;
            this.filtroCCTV.ButtonText = "CCTV";
            this.filtroCCTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroCCTV.DisabledColor = System.Drawing.Color.Gray;
            this.filtroCCTV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.filtroCCTV.Location = new System.Drawing.Point(67, 9);
            this.filtroCCTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroCCTV.Name = "filtroCCTV";
            this.filtroCCTV.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroCCTV.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroCCTV.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroCCTV.selected = false;
            this.filtroCCTV.Size = new System.Drawing.Size(50, 17);
            this.filtroCCTV.TabIndex = 13;
            this.filtroCCTV.Text = "CCTV";
            this.filtroCCTV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroCCTV.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroCCTV.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textBuscarTecnico
            // 
            this.textBuscarTecnico.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBuscarTecnico.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBuscarTecnico.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.textBuscarTecnico.BorderThickness = 1;
            this.textBuscarTecnico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscarTecnico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBuscarTecnico.isPassword = false;
            this.textBuscarTecnico.Location = new System.Drawing.Point(468, 5);
            this.textBuscarTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscarTecnico.Name = "textBuscarTecnico";
            this.textBuscarTecnico.Size = new System.Drawing.Size(202, 18);
            this.textBuscarTecnico.TabIndex = 12;
            this.textBuscarTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = global::MTN_Administration.Properties.Resources._029_search;
            this.SearchIcon.Location = new System.Drawing.Point(678, 6);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(21, 22);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 11;
            this.SearchIcon.TabStop = false;
            // 
            // filtroSeveridadMedia
            // 
            this.filtroSeveridadMedia.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadMedia.BackColor = System.Drawing.Color.Transparent;
            this.filtroSeveridadMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroSeveridadMedia.BorderRadius = 0;
            this.filtroSeveridadMedia.ButtonText = "Media";
            this.filtroSeveridadMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroSeveridadMedia.DisabledColor = System.Drawing.Color.Gray;
            this.filtroSeveridadMedia.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroSeveridadMedia.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroSeveridadMedia.Iconimage = null;
            this.filtroSeveridadMedia.Iconimage_right = null;
            this.filtroSeveridadMedia.Iconimage_right_Selected = null;
            this.filtroSeveridadMedia.Iconimage_Selected = null;
            this.filtroSeveridadMedia.IconMarginLeft = 0;
            this.filtroSeveridadMedia.IconMarginRight = 0;
            this.filtroSeveridadMedia.IconRightVisible = true;
            this.filtroSeveridadMedia.IconRightZoom = 0D;
            this.filtroSeveridadMedia.IconVisible = true;
            this.filtroSeveridadMedia.IconZoom = 90D;
            this.filtroSeveridadMedia.IsTab = false;
            this.filtroSeveridadMedia.Location = new System.Drawing.Point(341, 9);
            this.filtroSeveridadMedia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroSeveridadMedia.Name = "filtroSeveridadMedia";
            this.filtroSeveridadMedia.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadMedia.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadMedia.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroSeveridadMedia.selected = false;
            this.filtroSeveridadMedia.Size = new System.Drawing.Size(63, 16);
            this.filtroSeveridadMedia.TabIndex = 8;
            this.filtroSeveridadMedia.Text = "Media";
            this.filtroSeveridadMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroSeveridadMedia.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroSeveridadMedia.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // filtroSeveridadAlta
            // 
            this.filtroSeveridadAlta.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadAlta.BackColor = System.Drawing.Color.Transparent;
            this.filtroSeveridadAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroSeveridadAlta.BorderRadius = 0;
            this.filtroSeveridadAlta.ButtonText = "Alta";
            this.filtroSeveridadAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroSeveridadAlta.DisabledColor = System.Drawing.Color.Gray;
            this.filtroSeveridadAlta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroSeveridadAlta.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroSeveridadAlta.Iconimage = null;
            this.filtroSeveridadAlta.Iconimage_right = null;
            this.filtroSeveridadAlta.Iconimage_right_Selected = null;
            this.filtroSeveridadAlta.Iconimage_Selected = null;
            this.filtroSeveridadAlta.IconMarginLeft = 0;
            this.filtroSeveridadAlta.IconMarginRight = 0;
            this.filtroSeveridadAlta.IconRightVisible = true;
            this.filtroSeveridadAlta.IconRightZoom = 0D;
            this.filtroSeveridadAlta.IconVisible = true;
            this.filtroSeveridadAlta.IconZoom = 90D;
            this.filtroSeveridadAlta.IsTab = false;
            this.filtroSeveridadAlta.Location = new System.Drawing.Point(285, 9);
            this.filtroSeveridadAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroSeveridadAlta.Name = "filtroSeveridadAlta";
            this.filtroSeveridadAlta.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadAlta.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroSeveridadAlta.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroSeveridadAlta.selected = false;
            this.filtroSeveridadAlta.Size = new System.Drawing.Size(56, 16);
            this.filtroSeveridadAlta.TabIndex = 7;
            this.filtroSeveridadAlta.Text = "Alta";
            this.filtroSeveridadAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroSeveridadAlta.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroSeveridadAlta.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // filtroAlarmas
            // 
            this.filtroAlarmas.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroAlarmas.BackColor = System.Drawing.Color.Transparent;
            this.filtroAlarmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroAlarmas.BorderRadius = 0;
            this.filtroAlarmas.ButtonText = "Alarmas";
            this.filtroAlarmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroAlarmas.DisabledColor = System.Drawing.Color.Gray;
            this.filtroAlarmas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.filtroAlarmas.Location = new System.Drawing.Point(124, 9);
            this.filtroAlarmas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroAlarmas.Name = "filtroAlarmas";
            this.filtroAlarmas.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroAlarmas.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroAlarmas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroAlarmas.selected = false;
            this.filtroAlarmas.Size = new System.Drawing.Size(72, 17);
            this.filtroAlarmas.TabIndex = 6;
            this.filtroAlarmas.Text = "Alarmas";
            this.filtroAlarmas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroAlarmas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroAlarmas.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // sliderFiltroTecnicos
            // 
            this.sliderFiltroTecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.sliderFiltroTecnicos.Location = new System.Drawing.Point(10, 25);
            this.sliderFiltroTecnicos.Name = "sliderFiltroTecnicos";
            this.sliderFiltroTecnicos.Size = new System.Drawing.Size(50, 3);
            this.sliderFiltroTecnicos.TabIndex = 5;
            this.sliderFiltroTecnicos.TabStop = false;
            // 
            // filtroTodo
            // 
            this.filtroTodo.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroTodo.BackColor = System.Drawing.Color.Transparent;
            this.filtroTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroTodo.BorderRadius = 0;
            this.filtroTodo.ButtonText = "Todos";
            this.filtroTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroTodo.DisabledColor = System.Drawing.Color.Gray;
            this.filtroTodo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodo.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroTodo.Iconimage = null;
            this.filtroTodo.Iconimage_right = null;
            this.filtroTodo.Iconimage_right_Selected = null;
            this.filtroTodo.Iconimage_Selected = null;
            this.filtroTodo.IconMarginLeft = 0;
            this.filtroTodo.IconMarginRight = 0;
            this.filtroTodo.IconRightVisible = true;
            this.filtroTodo.IconRightZoom = 0D;
            this.filtroTodo.IconVisible = true;
            this.filtroTodo.IconZoom = 90D;
            this.filtroTodo.IsTab = false;
            this.filtroTodo.Location = new System.Drawing.Point(10, 9);
            this.filtroTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroTodo.Name = "filtroTodo";
            this.filtroTodo.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroTodo.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroTodo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroTodo.selected = false;
            this.filtroTodo.Size = new System.Drawing.Size(50, 16);
            this.filtroTodo.TabIndex = 0;
            this.filtroTodo.Text = "Todos";
            this.filtroTodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroTodo.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroTodo.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ABM_Incidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.tablaTecnicos);
            this.Controls.Add(this.BotonCerrarIncidente);
            this.Controls.Add(this.BotonEditarInicidente);
            this.Controls.Add(this.BotonAgregarIncidente);
            this.Controls.Add(this.panel1);
            this.Name = "ABM_Incidentes";
            this.Size = new System.Drawing.Size(727, 561);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTecnicos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFiltroTecnicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaTecnicos;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonCerrarIncidente;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEditarInicidente;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonAgregarIncidente;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton filtroCCTV;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBuscarTecnico;
        private System.Windows.Forms.PictureBox SearchIcon;
        private Bunifu.Framework.UI.BunifuFlatButton filtroSeveridadMedia;
        private Bunifu.Framework.UI.BunifuFlatButton filtroSeveridadAlta;
        private Bunifu.Framework.UI.BunifuFlatButton filtroAlarmas;
        private System.Windows.Forms.PictureBox sliderFiltroTecnicos;
        private Bunifu.Framework.UI.BunifuFlatButton filtroTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn severidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton filtroSeveridadBaja;
        private Bunifu.Framework.UI.BunifuFlatButton filtroSeveridadTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignado;
    }
}
