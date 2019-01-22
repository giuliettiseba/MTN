namespace MTN_Administration.Tabs
{
    partial class Cerrar_Mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cerrar_Mantenimiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.transiciones = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tablaIncidentesResueltos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispositivo_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camara_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticidad_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignado_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaIncidentesAsignados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TextBuscarIncidente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Incidente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextDetalles = new MTN_Administration.CustomTextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIncidentesResueltos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIncidentesAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(45, 461);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(193, 30);
            this.bunifuCustomLabel4.TabIndex = 95;
            this.bunifuCustomLabel4.Text = "Observaciones";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.bunifuMetroTextbox1);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.bunifuCustomLabel7);
            this.panel.Controls.Add(this.tablaIncidentesResueltos);
            this.panel.Controls.Add(this.tablaIncidentesAsignados);
            this.panel.Controls.Add(this.TextBuscarIncidente);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.Incidente);
            this.panel.Controls.Add(this.TextDetalles);
            this.panel.Controls.Add(this.bunifuCustomLabel4);
            this.panel.Controls.Add(this.buttonGuardar);
            this.panel.Controls.Add(this.buttonCancelar);
            this.transiciones.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1240, 745);
            this.panel.TabIndex = 40;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.bunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.Coral;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(952, 33);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(208, 43);
            this.bunifuMetroTextbox1.TabIndex = 104;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.transiciones.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::MTN_Administration.Properties.Resources._029_search;
            this.pictureBox1.Location = new System.Drawing.Point(1183, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.transiciones.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(652, 46);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(246, 30);
            this.bunifuCustomLabel7.TabIndex = 102;
            this.bunifuCustomLabel7.Text = "Incidente Resueltos";
            // 
            // tablaIncidentesResueltos
            // 
            this.tablaIncidentesResueltos.AllowUserToAddRows = false;
            this.tablaIncidentesResueltos.AllowUserToDeleteRows = false;
            this.tablaIncidentesResueltos.AllowUserToResizeColumns = false;
            this.tablaIncidentesResueltos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tablaIncidentesResueltos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaIncidentesResueltos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaIncidentesResueltos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaIncidentesResueltos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaIncidentesResueltos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIncidentesResueltos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaIncidentesResueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIncidentesResueltos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_asignado,
            this.tipo_asignado,
            this.dispositivo_asignado,
            this.camara_asignado,
            this.criticidad_asignado,
            this.estado_asignado,
            this.asignado_asignado});
            this.transiciones.SetDecoration(this.tablaIncidentesResueltos, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaIncidentesResueltos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaIncidentesResueltos.DoubleBuffered = true;
            this.tablaIncidentesResueltos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaIncidentesResueltos.EnableHeadersVisualStyles = false;
            this.tablaIncidentesResueltos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.tablaIncidentesResueltos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.tablaIncidentesResueltos.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaIncidentesResueltos.Location = new System.Drawing.Point(645, 88);
            this.tablaIncidentesResueltos.Name = "tablaIncidentesResueltos";
            this.tablaIncidentesResueltos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIncidentesResueltos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaIncidentesResueltos.RowHeadersVisible = false;
            this.tablaIncidentesResueltos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaIncidentesResueltos.ShowCellErrors = false;
            this.tablaIncidentesResueltos.ShowCellToolTips = false;
            this.tablaIncidentesResueltos.ShowEditingIcon = false;
            this.tablaIncidentesResueltos.ShowRowErrors = false;
            this.tablaIncidentesResueltos.Size = new System.Drawing.Size(580, 345);
            this.tablaIncidentesResueltos.TabIndex = 101;
            this.tablaIncidentesResueltos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaIncidentesResueltos_CellDoubleClick);
            // 
            // id_asignado
            // 
            this.id_asignado.HeaderText = "Id";
            this.id_asignado.Name = "id_asignado";
            // 
            // tipo_asignado
            // 
            this.tipo_asignado.HeaderText = "Tipo";
            this.tipo_asignado.Name = "tipo_asignado";
            // 
            // dispositivo_asignado
            // 
            this.dispositivo_asignado.HeaderText = "Dispositivo";
            this.dispositivo_asignado.Name = "dispositivo_asignado";
            // 
            // camara_asignado
            // 
            this.camara_asignado.HeaderText = "Camara";
            this.camara_asignado.Name = "camara_asignado";
            // 
            // criticidad_asignado
            // 
            this.criticidad_asignado.HeaderText = "Criticidad";
            this.criticidad_asignado.Name = "criticidad_asignado";
            // 
            // estado_asignado
            // 
            this.estado_asignado.HeaderText = "Estado";
            this.estado_asignado.Name = "estado_asignado";
            // 
            // asignado_asignado
            // 
            this.asignado_asignado.HeaderText = "Asignado";
            this.asignado_asignado.Name = "asignado_asignado";
            this.asignado_asignado.Visible = false;
            // 
            // tablaIncidentesAsignados
            // 
            this.tablaIncidentesAsignados.AllowUserToAddRows = false;
            this.tablaIncidentesAsignados.AllowUserToDeleteRows = false;
            this.tablaIncidentesAsignados.AllowUserToResizeColumns = false;
            this.tablaIncidentesAsignados.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tablaIncidentesAsignados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaIncidentesAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaIncidentesAsignados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaIncidentesAsignados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaIncidentesAsignados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIncidentesAsignados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaIncidentesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIncidentesAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipo,
            this.dispositivo,
            this.camara,
            this.criticidad,
            this.estado,
            this.asignado});
            this.transiciones.SetDecoration(this.tablaIncidentesAsignados, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaIncidentesAsignados.DefaultCellStyle = dataGridViewCellStyle7;
            this.tablaIncidentesAsignados.DoubleBuffered = true;
            this.tablaIncidentesAsignados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaIncidentesAsignados.EnableHeadersVisualStyles = false;
            this.tablaIncidentesAsignados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.tablaIncidentesAsignados.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.tablaIncidentesAsignados.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaIncidentesAsignados.Location = new System.Drawing.Point(19, 92);
            this.tablaIncidentesAsignados.Name = "tablaIncidentesAsignados";
            this.tablaIncidentesAsignados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIncidentesAsignados.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaIncidentesAsignados.RowHeadersVisible = false;
            this.tablaIncidentesAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaIncidentesAsignados.ShowCellErrors = false;
            this.tablaIncidentesAsignados.ShowCellToolTips = false;
            this.tablaIncidentesAsignados.ShowEditingIcon = false;
            this.tablaIncidentesAsignados.ShowRowErrors = false;
            this.tablaIncidentesAsignados.Size = new System.Drawing.Size(580, 345);
            this.tablaIncidentesAsignados.TabIndex = 100;
            this.tablaIncidentesAsignados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaIncidentesAsignados_CellDoubleClick);
            // 
            // TextBuscarIncidente
            // 
            this.TextBuscarIncidente.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.TextBuscarIncidente.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.TextBuscarIncidente.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.TextBuscarIncidente.BorderThickness = 1;
            this.TextBuscarIncidente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transiciones.SetDecoration(this.TextBuscarIncidente, BunifuAnimatorNS.DecorationType.None);
            this.TextBuscarIncidente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TextBuscarIncidente.ForeColor = System.Drawing.Color.Coral;
            this.TextBuscarIncidente.isPassword = false;
            this.TextBuscarIncidente.Location = new System.Drawing.Point(314, 33);
            this.TextBuscarIncidente.Margin = new System.Windows.Forms.Padding(4);
            this.TextBuscarIncidente.Name = "TextBuscarIncidente";
            this.TextBuscarIncidente.Size = new System.Drawing.Size(208, 43);
            this.TextBuscarIncidente.TabIndex = 99;
            this.TextBuscarIncidente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.transiciones.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::MTN_Administration.Properties.Resources._029_search;
            this.pictureBox2.Location = new System.Drawing.Point(545, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
            // 
            // Incidente
            // 
            this.Incidente.AutoSize = true;
            this.transiciones.SetDecoration(this.Incidente, BunifuAnimatorNS.DecorationType.None);
            this.Incidente.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.Incidente.ForeColor = System.Drawing.Color.Silver;
            this.Incidente.Location = new System.Drawing.Point(14, 46);
            this.Incidente.Name = "Incidente";
            this.Incidente.Size = new System.Drawing.Size(256, 30);
            this.Incidente.TabIndex = 97;
            this.Incidente.Text = "Incidente Asignados";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ActiveBorderThickness = 1;
            this.buttonGuardar.ActiveCornerRadius = 20;
            this.buttonGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonGuardar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonGuardar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.ButtonText = "Cerrar Mantenimiento";
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.buttonGuardar, BunifuAnimatorNS.DecorationType.None);
            this.buttonGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonGuardar.IdleBorderThickness = 1;
            this.buttonGuardar.IdleCornerRadius = 20;
            this.buttonGuardar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonGuardar.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.buttonGuardar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonGuardar.Location = new System.Drawing.Point(657, 659);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(200, 41);
            this.buttonGuardar.TabIndex = 55;
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ActiveBorderThickness = 1;
            this.buttonCancelar.ActiveCornerRadius = 20;
            this.buttonCancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCancelar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.ButtonText = "Cancelar";
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transiciones.SetDecoration(this.buttonCancelar, BunifuAnimatorNS.DecorationType.None);
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonCancelar.IdleBorderThickness = 1;
            this.buttonCancelar.IdleCornerRadius = 20;
            this.buttonCancelar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonCancelar.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.buttonCancelar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelar.Location = new System.Drawing.Point(261, 659);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(181, 41);
            this.buttonCancelar.TabIndex = 54;
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            // dispositivo
            // 
            this.dispositivo.HeaderText = "Dispositivo";
            this.dispositivo.Name = "dispositivo";
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
            this.asignado.Visible = false;
            // 
            // TextDetalles
            // 
            this.TextDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.TextDetalles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.TextDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transiciones.SetDecoration(this.TextDetalles, BunifuAnimatorNS.DecorationType.None);
            this.TextDetalles.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TextDetalles.ForeColor = System.Drawing.Color.Coral;
            this.TextDetalles.Location = new System.Drawing.Point(50, 509);
            this.TextDetalles.Multiline = true;
            this.TextDetalles.Name = "TextDetalles";
            this.TextDetalles.Size = new System.Drawing.Size(1171, 124);
            this.TextDetalles.TabIndex = 96;
            // 
            // Cerrar_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel);
            this.transiciones.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Cerrar_Mantenimiento";
            this.Size = new System.Drawing.Size(1240, 705);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIncidentesResueltos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIncidentesAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition transiciones;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonGuardar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private CustomTextBox TextDetalles;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonCancelar;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaIncidentesResueltos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispositivo_asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn camara_asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticidad_asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignado_asignado;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaIncidentesAsignados;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextBuscarIncidente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel Incidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn camara;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignado;
    }
}
