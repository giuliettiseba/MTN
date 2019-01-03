namespace MTN_Administration.Tabs
{
    partial class ABM_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBuscarCliente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonEliminarCliente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonEditarCliente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonAgregarCliente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tablaClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBuscarCliente);
            this.panel1.Controls.Add(this.SearchIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 35);
            this.panel1.TabIndex = 5;
            // 
            // textBuscarTecnico
            // 
            this.textBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.textBuscarCliente.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBuscarCliente.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textBuscarCliente.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.textBuscarCliente.BorderThickness = 1;
            this.textBuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarCliente.ForeColor = System.Drawing.Color.Coral;
            this.textBuscarCliente.isPassword = false;
            this.textBuscarCliente.Location = new System.Drawing.Point(371, 5);
            this.textBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscarCliente.Name = "textBuscarTecnico";
            this.textBuscarCliente.Size = new System.Drawing.Size(299, 26);
            this.textBuscarCliente.TabIndex = 12;
            this.textBuscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBuscarCliente.OnValueChanged += new System.EventHandler(this.TextBuscarTecnico_OnValueChanged);
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = global::MTN_Administration.Properties.Resources._029_search;
            this.SearchIcon.Location = new System.Drawing.Point(678, 6);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(33, 25);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 11;
            this.SearchIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonEliminarCliente);
            this.panel2.Controls.Add(this.buttonEditarCliente);
            this.panel2.Controls.Add(this.BotonAgregarCliente);
            this.panel2.Controls.Add(this.tablaClientes);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 527);
            this.panel2.TabIndex = 8;
            // 
            // BotonEliminarCliente
            // 
            this.BotonEliminarCliente.ActiveBorderThickness = 1;
            this.BotonEliminarCliente.ActiveCornerRadius = 20;
            this.BotonEliminarCliente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarCliente.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonEliminarCliente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonEliminarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonEliminarCliente.BackgroundImage")));
            this.BotonEliminarCliente.ButtonText = "Eliminar Cliente";
            this.BotonEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarCliente.IdleBorderThickness = 1;
            this.BotonEliminarCliente.IdleCornerRadius = 20;
            this.BotonEliminarCliente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonEliminarCliente.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonEliminarCliente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarCliente.Location = new System.Drawing.Point(271, 477);
            this.BotonEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEliminarCliente.Name = "BotonEliminarCliente";
            this.BotonEliminarCliente.Size = new System.Drawing.Size(181, 41);
            this.BotonEliminarCliente.TabIndex = 17;
            this.BotonEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonEliminarCliente.Click += new System.EventHandler(this.BotonEliminarCliente_Click);
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.ActiveBorderThickness = 1;
            this.buttonEditarCliente.ActiveCornerRadius = 20;
            this.buttonEditarCliente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarCliente.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEditarCliente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonEditarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditarCliente.BackgroundImage")));
            this.buttonEditarCliente.ButtonText = "Editar Cliente";
            this.buttonEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarCliente.IdleBorderThickness = 1;
            this.buttonEditarCliente.IdleCornerRadius = 20;
            this.buttonEditarCliente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonEditarCliente.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonEditarCliente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarCliente.Location = new System.Drawing.Point(507, 477);
            this.buttonEditarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(181, 41);
            this.buttonEditarCliente.TabIndex = 16;
            this.buttonEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEditarCliente.Click += new System.EventHandler(this.ButtonEditarCliente_Click);
            // 
            // BotonAgregarCliente
            // 
            this.BotonAgregarCliente.ActiveBorderThickness = 1;
            this.BotonAgregarCliente.ActiveCornerRadius = 20;
            this.BotonAgregarCliente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarCliente.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonAgregarCliente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonAgregarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonAgregarCliente.BackgroundImage")));
            this.BotonAgregarCliente.ButtonText = "Agregar Cliente";
            this.BotonAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgregarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarCliente.IdleBorderThickness = 1;
            this.BotonAgregarCliente.IdleCornerRadius = 20;
            this.BotonAgregarCliente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonAgregarCliente.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonAgregarCliente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarCliente.Location = new System.Drawing.Point(35, 477);
            this.BotonAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAgregarCliente.Name = "BotonAgregarCliente";
            this.BotonAgregarCliente.Size = new System.Drawing.Size(181, 41);
            this.BotonAgregarCliente.TabIndex = 15;
            this.BotonAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonAgregarCliente.Click += new System.EventHandler(this.BotonAgregarCliente_Click);
            // 
            // tablaClientes
            // 
            this.tablaClientes.AllowUserToAddRows = false;
            this.tablaClientes.AllowUserToDeleteRows = false;
            this.tablaClientes.AllowUserToResizeColumns = false;
            this.tablaClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tablaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.razonSocial,
            this.cuit,
            this.direccion,
            this.localidad,
            this.provincia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaClientes.DoubleBuffered = true;
            this.tablaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaClientes.EnableHeadersVisualStyles = false;
            this.tablaClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.tablaClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.tablaClientes.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaClientes.Location = new System.Drawing.Point(16, 7);
            this.tablaClientes.MultiSelect = false;
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaClientes.RowHeadersVisible = false;
            this.tablaClientes.RowHeadersWidth = 90;
            this.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaClientes.ShowCellErrors = false;
            this.tablaClientes.ShowCellToolTips = false;
            this.tablaClientes.ShowEditingIcon = false;
            this.tablaClientes.ShowRowErrors = false;
            this.tablaClientes.Size = new System.Drawing.Size(695, 463);
            this.tablaClientes.TabIndex = 5;
            this.tablaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ButtonEditarCliente_Click);
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
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
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            // 
            // ABM_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ABM_Clientes";
            this.Size = new System.Drawing.Size(727, 561);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBuscarCliente;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaClientes;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminarCliente;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonEditarCliente;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonAgregarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
    }
}
