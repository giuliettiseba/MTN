﻿namespace MTN_Administration
{
    partial class ABM_Tecnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Tecnicos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.filtroJefes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBuscarTecnico = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.filtroAnalistas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filtroLideres = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filtroSupervisores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sliderFiltroTecnicos = new System.Windows.Forms.PictureBox();
            this.filtroTodosTecnicos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonEditarTecnico = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.SearchIcon);
            this.panel1.Controls.Add(this.filtroJefes);
            this.panel1.Controls.Add(this.textBuscarTecnico);
            this.panel1.Controls.Add(this.filtroAnalistas);
            this.panel1.Controls.Add(this.filtroLideres);
            this.panel1.Controls.Add(this.filtroSupervisores);
            this.panel1.Controls.Add(this.sliderFiltroTecnicos);
            this.panel1.Controls.Add(this.filtroTodosTecnicos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 35);
            this.panel1.TabIndex = 4;
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = global::MTN_Administration.Properties.Resources._029_search;
            this.SearchIcon.Location = new System.Drawing.Point(678, 8);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(33, 25);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 17;
            this.SearchIcon.TabStop = false;
            // 
            // filtroJefes
            // 
            this.filtroJefes.Activecolor = System.Drawing.Color.Transparent;
            this.filtroJefes.BackColor = System.Drawing.Color.Transparent;
            this.filtroJefes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroJefes.BorderRadius = 0;
            this.filtroJefes.ButtonText = "Jefes";
            this.filtroJefes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroJefes.DisabledColor = System.Drawing.Color.Gray;
            this.filtroJefes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroJefes.ForeColor = System.Drawing.Color.Silver;
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
            this.filtroJefes.Normalcolor = System.Drawing.Color.Transparent;
            this.filtroJefes.OnHovercolor = System.Drawing.Color.Transparent;
            this.filtroJefes.OnHoverTextColor = System.Drawing.Color.Coral;
            this.filtroJefes.selected = false;
            this.filtroJefes.Size = new System.Drawing.Size(74, 16);
            this.filtroJefes.TabIndex = 13;
            this.filtroJefes.Text = "Jefes";
            this.filtroJefes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroJefes.Textcolor = System.Drawing.Color.Silver;
            this.filtroJefes.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroJefes.Click += new System.EventHandler(this.FiltroJefes_Click);
            // 
            // textBuscarTecnico
            // 
            this.textBuscarTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.textBuscarTecnico.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBuscarTecnico.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textBuscarTecnico.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.textBuscarTecnico.BorderThickness = 1;
            this.textBuscarTecnico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscarTecnico.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBuscarTecnico.ForeColor = System.Drawing.Color.Coral;
            this.textBuscarTecnico.isPassword = false;
            this.textBuscarTecnico.Location = new System.Drawing.Point(421, 6);
            this.textBuscarTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscarTecnico.Name = "textBuscarTecnico";
            this.textBuscarTecnico.Size = new System.Drawing.Size(254, 26);
            this.textBuscarTecnico.TabIndex = 12;
            this.textBuscarTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBuscarTecnico.OnValueChanged += new System.EventHandler(this.TextBuscarTecnico_OnValueChanged);
            // 
            // filtroAnalistas
            // 
            this.filtroAnalistas.Activecolor = System.Drawing.Color.Transparent;
            this.filtroAnalistas.BackColor = System.Drawing.Color.Transparent;
            this.filtroAnalistas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroAnalistas.BorderRadius = 0;
            this.filtroAnalistas.ButtonText = "Analistas";
            this.filtroAnalistas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroAnalistas.DisabledColor = System.Drawing.Color.Gray;
            this.filtroAnalistas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAnalistas.ForeColor = System.Drawing.Color.Silver;
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
            this.filtroAnalistas.Normalcolor = System.Drawing.Color.Transparent;
            this.filtroAnalistas.OnHovercolor = System.Drawing.Color.Transparent;
            this.filtroAnalistas.OnHoverTextColor = System.Drawing.Color.Coral;
            this.filtroAnalistas.selected = false;
            this.filtroAnalistas.Size = new System.Drawing.Size(74, 16);
            this.filtroAnalistas.TabIndex = 8;
            this.filtroAnalistas.Text = "Analistas";
            this.filtroAnalistas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroAnalistas.Textcolor = System.Drawing.Color.Silver;
            this.filtroAnalistas.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAnalistas.Click += new System.EventHandler(this.FiltroAnalistas_Click);
            // 
            // filtroLideres
            // 
            this.filtroLideres.Activecolor = System.Drawing.Color.Transparent;
            this.filtroLideres.BackColor = System.Drawing.Color.Transparent;
            this.filtroLideres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroLideres.BorderRadius = 0;
            this.filtroLideres.ButtonText = "Lideres";
            this.filtroLideres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroLideres.DisabledColor = System.Drawing.Color.Gray;
            this.filtroLideres.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroLideres.ForeColor = System.Drawing.Color.Silver;
            this.filtroLideres.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroLideres.Iconimage = null;
            this.filtroLideres.Iconimage_right = null;
            this.filtroLideres.Iconimage_right_Selected = null;
            this.filtroLideres.Iconimage_Selected = null;
            this.filtroLideres.IconMarginLeft = 0;
            this.filtroLideres.IconMarginRight = 0;
            this.filtroLideres.IconRightVisible = true;
            this.filtroLideres.IconRightZoom = 0D;
            this.filtroLideres.IconVisible = true;
            this.filtroLideres.IconZoom = 90D;
            this.filtroLideres.IsTab = false;
            this.filtroLideres.Location = new System.Drawing.Point(265, 9);
            this.filtroLideres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroLideres.Name = "filtroLideres";
            this.filtroLideres.Normalcolor = System.Drawing.Color.Transparent;
            this.filtroLideres.OnHovercolor = System.Drawing.Color.Transparent;
            this.filtroLideres.OnHoverTextColor = System.Drawing.Color.Coral;
            this.filtroLideres.selected = false;
            this.filtroLideres.Size = new System.Drawing.Size(63, 16);
            this.filtroLideres.TabIndex = 7;
            this.filtroLideres.Text = "Lideres";
            this.filtroLideres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroLideres.Textcolor = System.Drawing.Color.Silver;
            this.filtroLideres.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroLideres.Click += new System.EventHandler(this.FiltroLideres_Click);
            // 
            // filtroSupervisores
            // 
            this.filtroSupervisores.Activecolor = System.Drawing.Color.Transparent;
            this.filtroSupervisores.BackColor = System.Drawing.Color.Transparent;
            this.filtroSupervisores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroSupervisores.BorderRadius = 0;
            this.filtroSupervisores.ButtonText = "Supervisores";
            this.filtroSupervisores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroSupervisores.DisabledColor = System.Drawing.Color.Gray;
            this.filtroSupervisores.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroSupervisores.ForeColor = System.Drawing.Color.Silver;
            this.filtroSupervisores.Iconcolor = System.Drawing.Color.Transparent;
            this.filtroSupervisores.Iconimage = null;
            this.filtroSupervisores.Iconimage_right = null;
            this.filtroSupervisores.Iconimage_right_Selected = null;
            this.filtroSupervisores.Iconimage_Selected = null;
            this.filtroSupervisores.IconMarginLeft = 0;
            this.filtroSupervisores.IconMarginRight = 0;
            this.filtroSupervisores.IconRightVisible = true;
            this.filtroSupervisores.IconRightZoom = 0D;
            this.filtroSupervisores.IconVisible = true;
            this.filtroSupervisores.IconZoom = 90D;
            this.filtroSupervisores.IsTab = false;
            this.filtroSupervisores.Location = new System.Drawing.Point(165, 9);
            this.filtroSupervisores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroSupervisores.Name = "filtroSupervisores";
            this.filtroSupervisores.Normalcolor = System.Drawing.Color.Transparent;
            this.filtroSupervisores.OnHovercolor = System.Drawing.Color.Transparent;
            this.filtroSupervisores.OnHoverTextColor = System.Drawing.Color.Coral;
            this.filtroSupervisores.selected = false;
            this.filtroSupervisores.Size = new System.Drawing.Size(92, 16);
            this.filtroSupervisores.TabIndex = 6;
            this.filtroSupervisores.Text = "Supervisores";
            this.filtroSupervisores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroSupervisores.Textcolor = System.Drawing.Color.Silver;
            this.filtroSupervisores.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroSupervisores.Click += new System.EventHandler(this.FiltroSupervisores_Click);
            // 
            // sliderFiltroTecnicos
            // 
            this.sliderFiltroTecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.sliderFiltroTecnicos.Location = new System.Drawing.Point(25, 25);
            this.sliderFiltroTecnicos.Name = "sliderFiltroTecnicos";
            this.sliderFiltroTecnicos.Size = new System.Drawing.Size(50, 3);
            this.sliderFiltroTecnicos.TabIndex = 5;
            this.sliderFiltroTecnicos.TabStop = false;
            // 
            // filtroTodosTecnicos
            // 
            this.filtroTodosTecnicos.Activecolor = System.Drawing.Color.Transparent;
            this.filtroTodosTecnicos.BackColor = System.Drawing.Color.Transparent;
            this.filtroTodosTecnicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtroTodosTecnicos.BorderRadius = 0;
            this.filtroTodosTecnicos.ButtonText = "Todos";
            this.filtroTodosTecnicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroTodosTecnicos.DisabledColor = System.Drawing.Color.Gray;
            this.filtroTodosTecnicos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosTecnicos.ForeColor = System.Drawing.Color.Silver;
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
            this.filtroTodosTecnicos.Normalcolor = System.Drawing.Color.Transparent;
            this.filtroTodosTecnicos.OnHovercolor = System.Drawing.Color.Transparent;
            this.filtroTodosTecnicos.OnHoverTextColor = System.Drawing.Color.Coral;
            this.filtroTodosTecnicos.selected = false;
            this.filtroTodosTecnicos.Size = new System.Drawing.Size(50, 16);
            this.filtroTodosTecnicos.TabIndex = 0;
            this.filtroTodosTecnicos.Text = "Todos";
            this.filtroTodosTecnicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtroTodosTecnicos.Textcolor = System.Drawing.Color.Silver;
            this.filtroTodosTecnicos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosTecnicos.Click += new System.EventHandler(this.FiltroTodosTecnicos_Click);
            // 
            // buttonEditarTecnico
            // 
            this.buttonEditarTecnico.ActiveBorderThickness = 1;
            this.buttonEditarTecnico.ActiveCornerRadius = 20;
            this.buttonEditarTecnico.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarTecnico.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEditarTecnico.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonEditarTecnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditarTecnico.BackgroundImage")));
            this.buttonEditarTecnico.ButtonText = "Editar Tecnico";
            this.buttonEditarTecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarTecnico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarTecnico.IdleBorderThickness = 1;
            this.buttonEditarTecnico.IdleCornerRadius = 20;
            this.buttonEditarTecnico.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonEditarTecnico.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonEditarTecnico.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarTecnico.Location = new System.Drawing.Point(278, 477);
            this.buttonEditarTecnico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditarTecnico.Name = "buttonEditarTecnico";
            this.buttonEditarTecnico.Size = new System.Drawing.Size(181, 41);
            this.buttonEditarTecnico.TabIndex = 13;
            this.buttonEditarTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEditarTecnico.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // ButtonAgregarTecnico
            // 
            this.ButtonAgregarTecnico.ActiveBorderThickness = 1;
            this.ButtonAgregarTecnico.ActiveCornerRadius = 20;
            this.ButtonAgregarTecnico.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.ButtonAgregarTecnico.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAgregarTecnico.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.ButtonAgregarTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ButtonAgregarTecnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAgregarTecnico.BackgroundImage")));
            this.ButtonAgregarTecnico.ButtonText = "Agregar Tecnico";
            this.ButtonAgregarTecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAgregarTecnico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAgregarTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonAgregarTecnico.IdleBorderThickness = 1;
            this.ButtonAgregarTecnico.IdleCornerRadius = 20;
            this.ButtonAgregarTecnico.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.ButtonAgregarTecnico.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.ButtonAgregarTecnico.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.ButtonAgregarTecnico.Location = new System.Drawing.Point(35, 477);
            this.ButtonAgregarTecnico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAgregarTecnico.Name = "ButtonAgregarTecnico";
            this.ButtonAgregarTecnico.Size = new System.Drawing.Size(181, 41);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tablaTecnicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaTecnicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTecnicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaTecnicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaTecnicos.DefaultCellStyle = dataGridViewCellStyle9;
            this.tablaTecnicos.DoubleBuffered = true;
            this.tablaTecnicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaTecnicos.EnableHeadersVisualStyles = false;
            this.tablaTecnicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.tablaTecnicos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.tablaTecnicos.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaTecnicos.Location = new System.Drawing.Point(16, 7);
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
            this.tablaTecnicos.Size = new System.Drawing.Size(695, 463);
            this.tablaTecnicos.TabIndex = 5;
            this.tablaTecnicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaTecnicos_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            // 
            // tipo_empleado
            // 
            this.tipo_empleado.HeaderText = "Puesto";
            this.tipo_empleado.Name = "tipo_empleado";
            this.tipo_empleado.ReadOnly = true;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.tablaTecnicos);
            this.panel2.Controls.Add(this.BotonEliminarTecnico);
            this.panel2.Controls.Add(this.buttonEditarTecnico);
            this.panel2.Controls.Add(this.ButtonAgregarTecnico);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 526);
            this.panel2.TabIndex = 7;
            // 
            // BotonEliminarTecnico
            // 
            this.BotonEliminarTecnico.ActiveBorderThickness = 1;
            this.BotonEliminarTecnico.ActiveCornerRadius = 20;
            this.BotonEliminarTecnico.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarTecnico.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonEliminarTecnico.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonEliminarTecnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonEliminarTecnico.BackgroundImage")));
            this.BotonEliminarTecnico.ButtonText = "Eliminar Tecnico";
            this.BotonEliminarTecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEliminarTecnico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarTecnico.IdleBorderThickness = 1;
            this.BotonEliminarTecnico.IdleCornerRadius = 20;
            this.BotonEliminarTecnico.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonEliminarTecnico.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonEliminarTecnico.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarTecnico.Location = new System.Drawing.Point(515, 477);
            this.BotonEliminarTecnico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEliminarTecnico.Name = "BotonEliminarTecnico";
            this.BotonEliminarTecnico.Size = new System.Drawing.Size(181, 41);
            this.BotonEliminarTecnico.TabIndex = 14;
            this.BotonEliminarTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonEliminarTecnico.Click += new System.EventHandler(this.BotonEliminarTecnico_Click);
            // 
            // ABM_Tecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ABM_Tecnicos";
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
        private Bunifu.Framework.UI.BunifuFlatButton filtroLideres;
        private Bunifu.Framework.UI.BunifuFlatButton filtroSupervisores;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBuscarTecnico;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaTecnicos;
        
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonEditarTecnico;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminarTecnico;
        private Bunifu.Framework.UI.BunifuFlatButton filtroJefes;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
    }
}
