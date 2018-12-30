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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clienteLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.textBuscarSucursal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clienteLabel);
            this.panel1.Controls.Add(this.comboCliente);
            this.panel1.Controls.Add(this.textBuscarSucursal);
            this.panel1.Controls.Add(this.SearchIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 35);
            this.panel1.TabIndex = 5;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.Location = new System.Drawing.Point(22, 8);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(54, 17);
            this.clienteLabel.TabIndex = 14;
            this.clienteLabel.Text = "Cliente";
            // 
            // comboCliente
            // 
            this.comboCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.comboCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(82, 8);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(275, 21);
            this.comboCliente.TabIndex = 13;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // textBuscarSucursal
            // 
            this.textBuscarSucursal.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBuscarSucursal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBuscarSucursal.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.textBuscarSucursal.BorderThickness = 1;
            this.textBuscarSucursal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscarSucursal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBuscarSucursal.isPassword = false;
            this.textBuscarSucursal.Location = new System.Drawing.Point(468, 7);
            this.textBuscarSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscarSucursal.Name = "textBuscarSucursal";
            this.textBuscarSucursal.Size = new System.Drawing.Size(202, 18);
            this.textBuscarSucursal.TabIndex = 12;
            this.textBuscarSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBuscarSucursal.OnValueChanged += new System.EventHandler(this.textBuscarTecnico_OnValueChanged);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonEliminarSucursal);
            this.panel2.Controls.Add(this.buttonEditarSucursal);
            this.panel2.Controls.Add(this.BotonAgregarSucursal);
            this.panel2.Controls.Add(this.tablaSucursales);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 527);
            this.panel2.TabIndex = 8;
            // 
            // BotonEliminarSucursal
            // 
            this.BotonEliminarSucursal.ActiveBorderThickness = 1;
            this.BotonEliminarSucursal.ActiveCornerRadius = 20;
            this.BotonEliminarSucursal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.ActiveForecolor = System.Drawing.Color.White;
            this.BotonEliminarSucursal.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.BackColor = System.Drawing.Color.Gainsboro;
            this.BotonEliminarSucursal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonEliminarSucursal.BackgroundImage")));
            this.BotonEliminarSucursal.ButtonText = "Eliminar Sucursal";
            this.BotonEliminarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEliminarSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.IdleBorderThickness = 1;
            this.BotonEliminarSucursal.IdleCornerRadius = 20;
            this.BotonEliminarSucursal.IdleFillColor = System.Drawing.Color.White;
            this.BotonEliminarSucursal.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.Location = new System.Drawing.Point(155, 477);
            this.BotonEliminarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEliminarSucursal.Name = "BotonEliminarSucursal";
            this.BotonEliminarSucursal.Size = new System.Drawing.Size(122, 33);
            this.BotonEliminarSucursal.TabIndex = 17;
            this.BotonEliminarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonEliminarSucursal.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // buttonEditarSucursal
            // 
            this.buttonEditarSucursal.ActiveBorderThickness = 1;
            this.buttonEditarSucursal.ActiveCornerRadius = 20;
            this.buttonEditarSucursal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.ActiveForecolor = System.Drawing.Color.White;
            this.buttonEditarSucursal.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEditarSucursal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditarSucursal.BackgroundImage")));
            this.buttonEditarSucursal.ButtonText = "Editar Sucursal";
            this.buttonEditarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.IdleBorderThickness = 1;
            this.buttonEditarSucursal.IdleCornerRadius = 20;
            this.buttonEditarSucursal.IdleFillColor = System.Drawing.Color.White;
            this.buttonEditarSucursal.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.Location = new System.Drawing.Point(285, 477);
            this.buttonEditarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditarSucursal.Name = "buttonEditarSucursal";
            this.buttonEditarSucursal.Size = new System.Drawing.Size(122, 33);
            this.buttonEditarSucursal.TabIndex = 16;
            this.buttonEditarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEditarSucursal.Click += new System.EventHandler(this.ButtonEditarSucursal_Click);
            // 
            // BotonAgregarSucursal
            // 
            this.BotonAgregarSucursal.ActiveBorderThickness = 1;
            this.BotonAgregarSucursal.ActiveCornerRadius = 20;
            this.BotonAgregarSucursal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarSucursal.ActiveForecolor = System.Drawing.Color.White;
            this.BotonAgregarSucursal.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarSucursal.BackColor = System.Drawing.Color.Gainsboro;
            this.BotonAgregarSucursal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonAgregarSucursal.BackgroundImage")));
            this.BotonAgregarSucursal.ButtonText = "Agregar Sucursal";
            this.BotonAgregarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgregarSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarSucursal.IdleBorderThickness = 1;
            this.BotonAgregarSucursal.IdleCornerRadius = 20;
            this.BotonAgregarSucursal.IdleFillColor = System.Drawing.Color.White;
            this.BotonAgregarSucursal.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarSucursal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarSucursal.Location = new System.Drawing.Point(25, 477);
            this.BotonAgregarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAgregarSucursal.Name = "BotonAgregarSucursal";
            this.BotonAgregarSucursal.Size = new System.Drawing.Size(122, 33);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaSucursales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaSucursales.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tablaSucursales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaSucursales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.tablaSucursales.DoubleBuffered = true;
            this.tablaSucursales.EnableHeadersVisualStyles = false;
            this.tablaSucursales.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.tablaSucursales.HeaderForeColor = System.Drawing.Color.Black;
            this.tablaSucursales.Location = new System.Drawing.Point(25, 17);
            this.tablaSucursales.MultiSelect = false;
            this.tablaSucursales.Name = "tablaSucursales";
            this.tablaSucursales.ReadOnly = true;
            this.tablaSucursales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaSucursales.RowHeadersVisible = false;
            this.tablaSucursales.RowHeadersWidth = 90;
            this.tablaSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaSucursales.ShowCellErrors = false;
            this.tablaSucursales.ShowCellToolTips = false;
            this.tablaSucursales.ShowEditingIcon = false;
            this.tablaSucursales.ShowRowErrors = false;
            this.tablaSucursales.Size = new System.Drawing.Size(686, 420);
            this.tablaSucursales.TabIndex = 5;
            this.tablaSucursales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaSucursal_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 78;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 79;
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
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            this.provincia.Width = 87;
            // 
            // ABM_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
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
        private Bunifu.Framework.UI.BunifuMetroTextbox textBuscarSucursal;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaSucursales;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminarSucursal;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonEditarSucursal;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonAgregarSucursal;
        private System.Windows.Forms.ComboBox comboCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel clienteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
    }
}
