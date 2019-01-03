namespace MTN_Administration.Tabs
{
    partial class ABM_Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Sucursales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.textBuscar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.clienteLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonEliminarSucursal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonEditarSucursal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonAgregarSucursal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tablaSucursales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboCliente = new MTN_Administration.CustomComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.SearchIcon);
            this.panel1.Controls.Add(this.textBuscar);
            this.panel1.Controls.Add(this.clienteLabel);
            this.panel1.Controls.Add(this.comboCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 35);
            this.panel1.TabIndex = 5;
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = global::MTN_Administration.Properties.Resources._029_search;
            this.SearchIcon.Location = new System.Drawing.Point(678, 8);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(33, 25);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 16;
            this.SearchIcon.TabStop = false;
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.textBuscar.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBuscar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textBuscar.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.textBuscar.BorderThickness = 1;
            this.textBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.ForeColor = System.Drawing.Color.Coral;
            this.textBuscar.isPassword = false;
            this.textBuscar.Location = new System.Drawing.Point(372, 6);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(299, 26);
            this.textBuscar.TabIndex = 15;
            this.textBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBuscar.OnValueChanged += new System.EventHandler(this.textBuscar_OnValueChanged);
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.ForeColor = System.Drawing.Color.Silver;
            this.clienteLabel.Location = new System.Drawing.Point(22, 8);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(54, 17);
            this.clienteLabel.TabIndex = 14;
            this.clienteLabel.Text = "Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.BotonEliminarSucursal);
            this.panel2.Controls.Add(this.buttonEditarSucursal);
            this.panel2.Controls.Add(this.BotonAgregarSucursal);
            this.panel2.Controls.Add(this.tablaSucursales);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 527);
            this.panel2.TabIndex = 8;
            // 
            // BotonEliminarSucursal
            // 
            this.BotonEliminarSucursal.ActiveBorderThickness = 1;
            this.BotonEliminarSucursal.ActiveCornerRadius = 20;
            this.BotonEliminarSucursal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarSucursal.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonEliminarSucursal.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonEliminarSucursal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonEliminarSucursal.BackgroundImage")));
            this.BotonEliminarSucursal.ButtonText = "Eliminar Sucursal";
            this.BotonEliminarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEliminarSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.IdleBorderThickness = 1;
            this.BotonEliminarSucursal.IdleCornerRadius = 20;
            this.BotonEliminarSucursal.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonEliminarSucursal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonEliminarSucursal.Location = new System.Drawing.Point(271, 477);
            this.BotonEliminarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEliminarSucursal.Name = "BotonEliminarSucursal";
            this.BotonEliminarSucursal.Size = new System.Drawing.Size(181, 41);
            this.BotonEliminarSucursal.TabIndex = 17;
            this.BotonEliminarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonEliminarSucursal.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // buttonEditarSucursal
            // 
            this.buttonEditarSucursal.ActiveBorderThickness = 1;
            this.buttonEditarSucursal.ActiveCornerRadius = 20;
            this.buttonEditarSucursal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarSucursal.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEditarSucursal.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonEditarSucursal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditarSucursal.BackgroundImage")));
            this.buttonEditarSucursal.ButtonText = "Editar Sucursal";
            this.buttonEditarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.IdleBorderThickness = 1;
            this.buttonEditarSucursal.IdleCornerRadius = 20;
            this.buttonEditarSucursal.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonEditarSucursal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonEditarSucursal.Location = new System.Drawing.Point(507, 477);
            this.buttonEditarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditarSucursal.Name = "buttonEditarSucursal";
            this.buttonEditarSucursal.Size = new System.Drawing.Size(181, 41);
            this.buttonEditarSucursal.TabIndex = 16;
            this.buttonEditarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEditarSucursal.Click += new System.EventHandler(this.ButtonEditarSucursal_Click);
            // 
            // BotonAgregarSucursal
            // 
            this.BotonAgregarSucursal.ActiveBorderThickness = 1;
            this.BotonAgregarSucursal.ActiveCornerRadius = 20;
            this.BotonAgregarSucursal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarSucursal.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonAgregarSucursal.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BotonAgregarSucursal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonAgregarSucursal.BackgroundImage")));
            this.BotonAgregarSucursal.ButtonText = "Agregar Sucursal";
            this.BotonAgregarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgregarSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarSucursal.IdleBorderThickness = 1;
            this.BotonAgregarSucursal.IdleCornerRadius = 20;
            this.BotonAgregarSucursal.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.BotonAgregarSucursal.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.BotonAgregarSucursal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.BotonAgregarSucursal.Location = new System.Drawing.Point(35, 477);
            this.BotonAgregarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAgregarSucursal.Name = "BotonAgregarSucursal";
            this.BotonAgregarSucursal.Size = new System.Drawing.Size(181, 41);
            this.BotonAgregarSucursal.TabIndex = 15;
            this.BotonAgregarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonAgregarSucursal.Click += new System.EventHandler(this.BotonAgregarSucursal_Click);
            // 
            // tablaSucursales
            // 
            this.tablaSucursales.AllowUserToAddRows = false;
            this.tablaSucursales.AllowUserToDeleteRows = false;
            this.tablaSucursales.AllowUserToResizeColumns = false;
            this.tablaSucursales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tablaSucursales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaSucursales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tablaSucursales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaSucursales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.numero,
            this.nombre,
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
            this.tablaSucursales.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaSucursales.DoubleBuffered = true;
            this.tablaSucursales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaSucursales.EnableHeadersVisualStyles = false;
            this.tablaSucursales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.tablaSucursales.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.tablaSucursales.HeaderForeColor = System.Drawing.Color.Silver;
            this.tablaSucursales.Location = new System.Drawing.Point(16, 7);
            this.tablaSucursales.MultiSelect = false;
            this.tablaSucursales.Name = "tablaSucursales";
            this.tablaSucursales.ReadOnly = true;
            this.tablaSucursales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSucursales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaSucursales.RowHeadersVisible = false;
            this.tablaSucursales.RowHeadersWidth = 90;
            this.tablaSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaSucursales.ShowCellErrors = false;
            this.tablaSucursales.ShowCellToolTips = false;
            this.tablaSucursales.ShowEditingIcon = false;
            this.tablaSucursales.ShowRowErrors = false;
            this.tablaSucursales.Size = new System.Drawing.Size(695, 463);
            this.tablaSucursales.TabIndex = 5;
            this.tablaSucursales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaSucursales_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
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
            // comboCliente
            // 
            this.comboCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.comboCliente.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.comboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCliente.ForeColor = System.Drawing.Color.Silver;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(82, 8);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(275, 25);
            this.comboCliente.TabIndex = 13;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged_1);
            // 
            // ABM_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ABM_Sucursales";
            this.Size = new System.Drawing.Size(727, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaSucursales;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminarSucursal;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonEditarSucursal;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonAgregarSucursal;

        private CustomComboBox comboCliente;

        private Bunifu.Framework.UI.BunifuCustomLabel clienteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBuscar;
        private System.Windows.Forms.PictureBox SearchIcon;
    }
}
