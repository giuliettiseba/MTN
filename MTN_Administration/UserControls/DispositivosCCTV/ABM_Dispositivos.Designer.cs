namespace MTN_Administration.Tabs
{
    partial class ABM_Dispositivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Dispositivos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clienteLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablaSucursales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idSuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroSuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaGrabadoresDigitales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewImageColumn();
            this.BotonEliminarSucursal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonEditarSucursal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonAgregarDispositivoCCTV = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrabadoresDigitales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clienteLabel);
            this.panel1.Controls.Add(this.comboCliente);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tablaSucursales);
            this.panel2.Controls.Add(this.tablaGrabadoresDigitales);
            this.panel2.Controls.Add(this.BotonEliminarSucursal);
            this.panel2.Controls.Add(this.buttonEditarSucursal);
            this.panel2.Controls.Add(this.BotonAgregarDispositivoCCTV);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 527);
            this.panel2.TabIndex = 8;
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
            this.idSuc,
            this.numeroSuc,
            this.nombreSuc});
            this.tablaSucursales.DoubleBuffered = true;
            this.tablaSucursales.EnableHeadersVisualStyles = false;
            this.tablaSucursales.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.tablaSucursales.HeaderForeColor = System.Drawing.Color.Black;
            this.tablaSucursales.Location = new System.Drawing.Point(13, 44);
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
            this.tablaSucursales.Size = new System.Drawing.Size(234, 384);
            this.tablaSucursales.TabIndex = 18;
            this.tablaSucursales.SelectionChanged += new System.EventHandler(this.tablaSucursales_SelectionChanged);
            // 
            // idSuc
            // 
            this.idSuc.HeaderText = "#";
            this.idSuc.Name = "idSuc";
            this.idSuc.ReadOnly = true;
            this.idSuc.Width = 40;
            // 
            // numeroSuc
            // 
            this.numeroSuc.HeaderText = "Numero";
            this.numeroSuc.Name = "numeroSuc";
            this.numeroSuc.ReadOnly = true;
            this.numeroSuc.Width = 78;
            // 
            // nombreSuc
            // 
            this.nombreSuc.HeaderText = "Nombre";
            this.nombreSuc.Name = "nombreSuc";
            this.nombreSuc.ReadOnly = true;
            this.nombreSuc.Width = 79;
            // 
            // tablaGrabadoresDigitales
            // 
            this.tablaGrabadoresDigitales.AllowUserToAddRows = false;
            this.tablaGrabadoresDigitales.AllowUserToDeleteRows = false;
            this.tablaGrabadoresDigitales.AllowUserToResizeColumns = false;
            this.tablaGrabadoresDigitales.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaGrabadoresDigitales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaGrabadoresDigitales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaGrabadoresDigitales.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tablaGrabadoresDigitales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaGrabadoresDigitales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaGrabadoresDigitales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaGrabadoresDigitales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGrabadoresDigitales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.modelo,
            this.marca,
            this.estado});
            this.tablaGrabadoresDigitales.DoubleBuffered = true;
            this.tablaGrabadoresDigitales.EnableHeadersVisualStyles = false;
            this.tablaGrabadoresDigitales.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.tablaGrabadoresDigitales.HeaderForeColor = System.Drawing.Color.Black;
            this.tablaGrabadoresDigitales.Location = new System.Drawing.Point(253, 44);
            this.tablaGrabadoresDigitales.MultiSelect = false;
            this.tablaGrabadoresDigitales.Name = "tablaGrabadoresDigitales";
            this.tablaGrabadoresDigitales.ReadOnly = true;
            this.tablaGrabadoresDigitales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaGrabadoresDigitales.RowHeadersVisible = false;
            this.tablaGrabadoresDigitales.RowHeadersWidth = 90;
            this.tablaGrabadoresDigitales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaGrabadoresDigitales.ShowCellErrors = false;
            this.tablaGrabadoresDigitales.ShowCellToolTips = false;
            this.tablaGrabadoresDigitales.ShowEditingIcon = false;
            this.tablaGrabadoresDigitales.ShowRowErrors = false;
            this.tablaGrabadoresDigitales.Size = new System.Drawing.Size(454, 384);
            this.tablaGrabadoresDigitales.TabIndex = 5;
            this.tablaGrabadoresDigitales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaSucursal_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 79;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 77;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 70;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 52;
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
            this.BotonEliminarSucursal.ButtonText = "Eliminar Dispositivo";
            this.BotonEliminarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEliminarSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.IdleBorderThickness = 1;
            this.BotonEliminarSucursal.IdleCornerRadius = 20;
            this.BotonEliminarSucursal.IdleFillColor = System.Drawing.Color.White;
            this.BotonEliminarSucursal.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonEliminarSucursal.Location = new System.Drawing.Point(311, 435);
            this.BotonEliminarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEliminarSucursal.Name = "BotonEliminarSucursal";
            this.BotonEliminarSucursal.Size = new System.Drawing.Size(145, 33);
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
            this.buttonEditarSucursal.ButtonText = "Editar Dispositivo";
            this.buttonEditarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.IdleBorderThickness = 1;
            this.buttonEditarSucursal.IdleCornerRadius = 20;
            this.buttonEditarSucursal.IdleFillColor = System.Drawing.Color.White;
            this.buttonEditarSucursal.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEditarSucursal.Location = new System.Drawing.Point(172, 435);
            this.buttonEditarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditarSucursal.Name = "buttonEditarSucursal";
            this.buttonEditarSucursal.Size = new System.Drawing.Size(131, 33);
            this.buttonEditarSucursal.TabIndex = 16;
            this.buttonEditarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEditarSucursal.Click += new System.EventHandler(this.buttonEditarDispositivo_Click);
            // 
            // BotonAgregarDispositivoCCTV
            // 
            this.BotonAgregarDispositivoCCTV.ActiveBorderThickness = 1;
            this.BotonAgregarDispositivoCCTV.ActiveCornerRadius = 20;
            this.BotonAgregarDispositivoCCTV.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarDispositivoCCTV.ActiveForecolor = System.Drawing.Color.White;
            this.BotonAgregarDispositivoCCTV.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarDispositivoCCTV.BackColor = System.Drawing.Color.Gainsboro;
            this.BotonAgregarDispositivoCCTV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonAgregarDispositivoCCTV.BackgroundImage")));
            this.BotonAgregarDispositivoCCTV.ButtonText = "Agregar Dispositivo";
            this.BotonAgregarDispositivoCCTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgregarDispositivoCCTV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarDispositivoCCTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarDispositivoCCTV.IdleBorderThickness = 1;
            this.BotonAgregarDispositivoCCTV.IdleCornerRadius = 20;
            this.BotonAgregarDispositivoCCTV.IdleFillColor = System.Drawing.Color.White;
            this.BotonAgregarDispositivoCCTV.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarDispositivoCCTV.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BotonAgregarDispositivoCCTV.Location = new System.Drawing.Point(25, 435);
            this.BotonAgregarDispositivoCCTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAgregarDispositivoCCTV.Name = "BotonAgregarDispositivoCCTV";
            this.BotonAgregarDispositivoCCTV.Size = new System.Drawing.Size(139, 33);
            this.BotonAgregarDispositivoCCTV.TabIndex = 15;
            this.BotonAgregarDispositivoCCTV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonAgregarDispositivoCCTV.Click += new System.EventHandler(this.BotonAgregarDispotivo_Click);
            // 
            // ABM_Dispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ABM_Dispositivos";
            this.Size = new System.Drawing.Size(727, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrabadoresDigitales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaGrabadoresDigitales;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminarSucursal;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonEditarSucursal;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonAgregarDispositivoCCTV;
        private System.Windows.Forms.ComboBox comboCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel clienteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewImageColumn estado;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaSucursales;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroSuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSuc;
    }
}
