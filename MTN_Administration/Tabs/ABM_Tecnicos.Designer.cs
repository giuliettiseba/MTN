namespace MTN_Administration
{
    partial class AMB_Tecnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMB_Tecnicos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filtroJefes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBuscarTecnico = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.filtroAnalistas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FiltroLideres = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FiltroSupervisores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sliderFiltroTecnicos = new System.Windows.Forms.PictureBox();
            this.filtroTodosTecnicos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonAgregarTecnico = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tablaTecnicos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonEliminarTecnico = new Bunifu.Framework.UI.BunifuThinButton2();
            
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFiltroTecnicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTecnicos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filtroJefes);
            this.panel1.Controls.Add(this.textBuscarTecnico);
            this.panel1.Controls.Add(this.SearchIcon);
            this.panel1.Controls.Add(this.filtroAnalistas);
            this.panel1.Controls.Add(this.FiltroLideres);
            this.panel1.Controls.Add(this.FiltroSupervisores);
            this.panel1.Controls.Add(this.sliderFiltroTecnicos);
            this.panel1.Controls.Add(this.filtroTodosTecnicos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 35);
            this.panel1.TabIndex = 4;
            // 
            // filtroJefes
            // 
            this.filtroJefes.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroJefes.BackColor = System.Drawing.Color.Gainsboro;
            this.filtroJefes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroJefes.BorderRadius = 0;
            this.filtroJefes.ButtonText = "Jefes";
            this.filtroJefes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroJefes.DisabledColor = System.Drawing.Color.Gray;
            this.filtroJefes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroJefes.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroJefes.Iconimage = null;
            this.filtroJefes.Iconimage_right = null;
            this.filtroJefes.Iconimage_right_Selected = null;
            this.filtroJefes.Iconimage_Selected = null;
            this.filtroJefes.IconMarginLeft = 0;
            this.filtroJefes.IconMarginRight = 0;
            this.filtroJefes.IconRightVisible = true;
            this.filtroJefes.IconRightZoom = 0D;
            this.filtroJefes.IconVisible = true;
            this.filtroJefes.IconZoom = 90D;
            this.filtroJefes.IsTab = false;
            this.filtroJefes.Location = new System.Drawing.Point(83, 9);
            this.filtroJefes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroJefes.Name = "filtroJefes";
            this.filtroJefes.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroJefes.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroJefes.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroJefes.selected = false;
            this.filtroJefes.Size = new System.Drawing.Size(74, 16);
            this.filtroJefes.TabIndex = 13;
            this.filtroJefes.Text = "Jefes";
            this.filtroJefes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroJefes.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroJefes.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroJefes.Click += new System.EventHandler(this.FiltroJefes_Click);
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
            this.textBuscarTecnico.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBuscarTecnico_KeyDown);
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
            // filtroAnalistas
            // 
            this.filtroAnalistas.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroAnalistas.BackColor = System.Drawing.Color.Gainsboro;
            this.filtroAnalistas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroAnalistas.BorderRadius = 0;
            this.filtroAnalistas.ButtonText = "Analistas";
            this.filtroAnalistas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroAnalistas.DisabledColor = System.Drawing.Color.Gray;
            this.filtroAnalistas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAnalistas.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroAnalistas.Iconimage = null;
            this.filtroAnalistas.Iconimage_right = null;
            this.filtroAnalistas.Iconimage_right_Selected = null;
            this.filtroAnalistas.Iconimage_Selected = null;
            this.filtroAnalistas.IconMarginLeft = 0;
            this.filtroAnalistas.IconMarginRight = 0;
            this.filtroAnalistas.IconRightVisible = true;
            this.filtroAnalistas.IconRightZoom = 0D;
            this.filtroAnalistas.IconVisible = true;
            this.filtroAnalistas.IconZoom = 90D;
            this.filtroAnalistas.IsTab = false;
            this.filtroAnalistas.Location = new System.Drawing.Point(336, 9);
            this.filtroAnalistas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroAnalistas.Name = "filtroAnalistas";
            this.filtroAnalistas.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroAnalistas.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroAnalistas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroAnalistas.selected = false;
            this.filtroAnalistas.Size = new System.Drawing.Size(74, 16);
            this.filtroAnalistas.TabIndex = 8;
            this.filtroAnalistas.Text = "Analistas";
            this.filtroAnalistas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroAnalistas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroAnalistas.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAnalistas.Click += new System.EventHandler(this.FiltroAnalistas_Click);
            // 
            // FiltroLideres
            // 
            this.FiltroLideres.Activecolor = System.Drawing.Color.Gainsboro;
            this.FiltroLideres.BackColor = System.Drawing.Color.Gainsboro;
            this.FiltroLideres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiltroLideres.BorderRadius = 0;
            this.FiltroLideres.ButtonText = "Lideres";
            this.FiltroLideres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiltroLideres.DisabledColor = System.Drawing.Color.Gray;
            this.FiltroLideres.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLideres.Iconcolor = System.Drawing.Color.Transparent;
            this.FiltroLideres.Iconimage = null;
            this.FiltroLideres.Iconimage_right = null;
            this.FiltroLideres.Iconimage_right_Selected = null;
            this.FiltroLideres.Iconimage_Selected = null;
            this.FiltroLideres.IconMarginLeft = 0;
            this.FiltroLideres.IconMarginRight = 0;
            this.FiltroLideres.IconRightVisible = true;
            this.FiltroLideres.IconRightZoom = 0D;
            this.FiltroLideres.IconVisible = true;
            this.FiltroLideres.IconZoom = 90D;
            this.FiltroLideres.IsTab = false;
            this.FiltroLideres.Location = new System.Drawing.Point(265, 9);
            this.FiltroLideres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiltroLideres.Name = "FiltroLideres";
            this.FiltroLideres.Normalcolor = System.Drawing.Color.Gainsboro;
            this.FiltroLideres.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.FiltroLideres.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.FiltroLideres.selected = false;
            this.FiltroLideres.Size = new System.Drawing.Size(63, 16);
            this.FiltroLideres.TabIndex = 7;
            this.FiltroLideres.Text = "Lideres";
            this.FiltroLideres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FiltroLideres.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.FiltroLideres.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLideres.Click += new System.EventHandler(this.FiltroLideres_Click);
            // 
            // FiltroSupervisores
            // 
            this.FiltroSupervisores.Activecolor = System.Drawing.Color.Gainsboro;
            this.FiltroSupervisores.BackColor = System.Drawing.Color.Gainsboro;
            this.FiltroSupervisores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiltroSupervisores.BorderRadius = 0;
            this.FiltroSupervisores.ButtonText = "Supervisores";
            this.FiltroSupervisores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiltroSupervisores.DisabledColor = System.Drawing.Color.Gray;
            this.FiltroSupervisores.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroSupervisores.Iconcolor = System.Drawing.Color.Transparent;
            this.FiltroSupervisores.Iconimage = null;
            this.FiltroSupervisores.Iconimage_right = null;
            this.FiltroSupervisores.Iconimage_right_Selected = null;
            this.FiltroSupervisores.Iconimage_Selected = null;
            this.FiltroSupervisores.IconMarginLeft = 0;
            this.FiltroSupervisores.IconMarginRight = 0;
            this.FiltroSupervisores.IconRightVisible = true;
            this.FiltroSupervisores.IconRightZoom = 0D;
            this.FiltroSupervisores.IconVisible = true;
            this.FiltroSupervisores.IconZoom = 90D;
            this.FiltroSupervisores.IsTab = false;
            this.FiltroSupervisores.Location = new System.Drawing.Point(165, 9);
            this.FiltroSupervisores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiltroSupervisores.Name = "FiltroSupervisores";
            this.FiltroSupervisores.Normalcolor = System.Drawing.Color.Gainsboro;
            this.FiltroSupervisores.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.FiltroSupervisores.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.FiltroSupervisores.selected = false;
            this.FiltroSupervisores.Size = new System.Drawing.Size(92, 16);
            this.FiltroSupervisores.TabIndex = 6;
            this.FiltroSupervisores.Text = "Supervisores";
            this.FiltroSupervisores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FiltroSupervisores.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.FiltroSupervisores.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroSupervisores.Click += new System.EventHandler(this.FiltroSupervisores_Click);
            // 
            // sliderFiltroTecnicos
            // 
            this.sliderFiltroTecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.sliderFiltroTecnicos.Location = new System.Drawing.Point(25, 25);
            this.sliderFiltroTecnicos.Name = "sliderFiltroTecnicos";
            this.sliderFiltroTecnicos.Size = new System.Drawing.Size(50, 3);
            this.sliderFiltroTecnicos.TabIndex = 5;
            this.sliderFiltroTecnicos.TabStop = false;
            // 
            // filtroTodosTecnicos
            // 
            this.filtroTodosTecnicos.Activecolor = System.Drawing.Color.Gainsboro;
            this.filtroTodosTecnicos.BackColor = System.Drawing.Color.Gainsboro;
            this.filtroTodosTecnicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroTodosTecnicos.BorderRadius = 0;
            this.filtroTodosTecnicos.ButtonText = "Todos";
            this.filtroTodosTecnicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroTodosTecnicos.DisabledColor = System.Drawing.Color.Gray;
            this.filtroTodosTecnicos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosTecnicos.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroTodosTecnicos.Iconimage = null;
            this.filtroTodosTecnicos.Iconimage_right = null;
            this.filtroTodosTecnicos.Iconimage_right_Selected = null;
            this.filtroTodosTecnicos.Iconimage_Selected = null;
            this.filtroTodosTecnicos.IconMarginLeft = 0;
            this.filtroTodosTecnicos.IconMarginRight = 0;
            this.filtroTodosTecnicos.IconRightVisible = true;
            this.filtroTodosTecnicos.IconRightZoom = 0D;
            this.filtroTodosTecnicos.IconVisible = true;
            this.filtroTodosTecnicos.IconZoom = 90D;
            this.filtroTodosTecnicos.IsTab = false;
            this.filtroTodosTecnicos.Location = new System.Drawing.Point(25, 9);
            this.filtroTodosTecnicos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroTodosTecnicos.Name = "filtroTodosTecnicos";
            this.filtroTodosTecnicos.Normalcolor = System.Drawing.Color.Gainsboro;
            this.filtroTodosTecnicos.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.filtroTodosTecnicos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtroTodosTecnicos.selected = false;
            this.filtroTodosTecnicos.Size = new System.Drawing.Size(50, 16);
            this.filtroTodosTecnicos.TabIndex = 0;
            this.filtroTodosTecnicos.Text = "Todos";
            this.filtroTodosTecnicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroTodosTecnicos.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.filtroTodosTecnicos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosTecnicos.Click += new System.EventHandler(this.FiltroTodosTecnicos_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.ActiveBorderThickness = 1;
            this.buttonEditar.ActiveCornerRadius = 20;
            this.buttonEditar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditar.ActiveForecolor = System.Drawing.Color.White;
            this.buttonEditar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.ButtonText = "Editar Tecnico";
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditar.IdleBorderThickness = 1;
            this.buttonEditar.IdleCornerRadius = 20;
            this.buttonEditar.IdleFillColor = System.Drawing.Color.White;
            this.buttonEditar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditar.Location = new System.Drawing.Point(285, 476);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(122, 33);
            this.buttonEditar.TabIndex = 13;
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // ButtonAgregarTecnico
            // 
            this.ButtonAgregarTecnico.ActiveBorderThickness = 1;
            this.ButtonAgregarTecnico.ActiveCornerRadius = 20;
            this.ButtonAgregarTecnico.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonAgregarTecnico.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonAgregarTecnico.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonAgregarTecnico.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonAgregarTecnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAgregarTecnico.BackgroundImage")));
            this.ButtonAgregarTecnico.ButtonText = "Agregar Tecnico";
            this.ButtonAgregarTecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAgregarTecnico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAgregarTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonAgregarTecnico.IdleBorderThickness = 1;
            this.ButtonAgregarTecnico.IdleCornerRadius = 20;
            this.ButtonAgregarTecnico.IdleFillColor = System.Drawing.Color.White;
            this.ButtonAgregarTecnico.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonAgregarTecnico.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonAgregarTecnico.Location = new System.Drawing.Point(25, 476);
            this.ButtonAgregarTecnico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAgregarTecnico.Name = "ButtonAgregarTecnico";
            this.ButtonAgregarTecnico.Size = new System.Drawing.Size(122, 33);
            this.ButtonAgregarTecnico.TabIndex = 10;
            this.ButtonAgregarTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAgregarTecnico.Click += new System.EventHandler(this.ButtonAgregarTecnico_Click);
            // 
            // tablaTecnicos
            // 
            this.tablaTecnicos.AllowUserToAddRows = false;
            this.tablaTecnicos.AllowUserToDeleteRows = false;
            this.tablaTecnicos.AllowUserToResizeColumns = false;
            this.tablaTecnicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaTecnicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTecnicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tablaTecnicos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tablaTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaTecnicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTecnicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.legajo,
            this.nombre,
            this.apellido,
            this.direccion,
            this.localidad,
            this.tipo_empleado,
            this.provincia});
            this.tablaTecnicos.DoubleBuffered = true;
            this.tablaTecnicos.EnableHeadersVisualStyles = false;
            this.tablaTecnicos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.tablaTecnicos.HeaderForeColor = System.Drawing.Color.Black;
            this.tablaTecnicos.Location = new System.Drawing.Point(24, 18);
            this.tablaTecnicos.MultiSelect = false;
            this.tablaTecnicos.Name = "tablaTecnicos";
            this.tablaTecnicos.ReadOnly = true;
            this.tablaTecnicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaTecnicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTecnicos.ShowCellErrors = false;
            this.tablaTecnicos.ShowCellToolTips = false;
            this.tablaTecnicos.ShowEditingIcon = false;
            this.tablaTecnicos.ShowRowErrors = false;
            this.tablaTecnicos.Size = new System.Drawing.Size(686, 451);
            this.tablaTecnicos.TabIndex = 5;
            this.tablaTecnicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaTecnicos_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Width = 72;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 79;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 81;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 89;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            this.localidad.Width = 91;
            // 
            // tipo_empleado
            // 
            this.tipo_empleado.HeaderText = "Puesto";
            this.tipo_empleado.Name = "tipo_empleado";
            this.tipo_empleado.ReadOnly = true;
            this.tipo_empleado.Width = 71;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            this.provincia.Width = 87;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonEliminarTecnico);
            this.panel2.Controls.Add(this.buttonEditar);
            this.panel2.Controls.Add(this.tablaTecnicos);
            this.panel2.Controls.Add(this.ButtonAgregarTecnico);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 526);
            this.panel2.TabIndex = 7;
            // 
            // BotonEliminarTecnico
            // 
            this.BotonEliminarTecnico.ActiveBorderThickness = 1;
            this.BotonEliminarTecnico.ActiveCornerRadius = 20;
            this.BotonEliminarTecnico.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarTecnico.ActiveForecolor = System.Drawing.Color.White;
            this.BotonEliminarTecnico.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarTecnico.BackColor = System.Drawing.Color.Gainsboro;
            this.BotonEliminarTecnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonEliminarTecnico.BackgroundImage")));
            this.BotonEliminarTecnico.ButtonText = "Eliminar Tecnico";
            this.BotonEliminarTecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEliminarTecnico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarTecnico.IdleBorderThickness = 1;
            this.BotonEliminarTecnico.IdleCornerRadius = 20;
            this.BotonEliminarTecnico.IdleFillColor = System.Drawing.Color.White;
            this.BotonEliminarTecnico.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarTecnico.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarTecnico.Location = new System.Drawing.Point(155, 476);
            this.BotonEliminarTecnico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEliminarTecnico.Name = "BotonEliminarTecnico";
            this.BotonEliminarTecnico.Size = new System.Drawing.Size(122, 33);
            this.BotonEliminarTecnico.TabIndex = 14;
            this.BotonEliminarTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonEliminarTecnico.Click += new System.EventHandler(this.BotonEliminarTecnico_Click);
        
            // 
            // AMB_Tecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
             this.Name = "AMB_Tecnicos";
            this.Size = new System.Drawing.Size(727, 561);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFiltroTecnicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTecnicos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton filtroTodosTecnicos;
        private System.Windows.Forms.PictureBox sliderFiltroTecnicos;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonAgregarTecnico;
        private Bunifu.Framework.UI.BunifuFlatButton filtroAnalistas;
        private Bunifu.Framework.UI.BunifuFlatButton FiltroLideres;
        private Bunifu.Framework.UI.BunifuFlatButton FiltroSupervisores;
        private System.Windows.Forms.PictureBox SearchIcon;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBuscarTecnico;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaTecnicos;
        
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_empleado;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminarTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private Bunifu.Framework.UI.BunifuFlatButton filtroJefes;
    }
}
