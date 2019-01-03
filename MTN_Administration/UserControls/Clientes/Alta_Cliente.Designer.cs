namespace MTN_Administration
{
    partial class Alta_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Cliente));
            this.buttonCancelarAlta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonGuardarAlta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelCuit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textCUIT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labelProvincia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelDireccion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textDireccion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.botonCargarFoto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBoxProvincia = new MTN_Administration.CustomComboBox();
            this.comboBoxLocalidad = new MTN_Administration.CustomComboBox();
            this.labelLocalidad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textRazonSocial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labelRazonSocial = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelarAlta
            // 
            this.buttonCancelarAlta.ActiveBorderThickness = 1;
            this.buttonCancelarAlta.ActiveCornerRadius = 20;
            this.buttonCancelarAlta.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelarAlta.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCancelarAlta.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelarAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonCancelarAlta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelarAlta.BackgroundImage")));
            this.buttonCancelarAlta.ButtonText = "Cancelar";
            this.buttonCancelarAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarAlta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonCancelarAlta.IdleBorderThickness = 1;
            this.buttonCancelarAlta.IdleCornerRadius = 20;
            this.buttonCancelarAlta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonCancelarAlta.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonCancelarAlta.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonCancelarAlta.Location = new System.Drawing.Point(435, 484);
            this.buttonCancelarAlta.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelarAlta.Name = "buttonCancelarAlta";
            this.buttonCancelarAlta.Size = new System.Drawing.Size(181, 41);
            this.buttonCancelarAlta.TabIndex = 11;
            this.buttonCancelarAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCancelarAlta.Click += new System.EventHandler(this.ButtonCancelarAltaTecnico_Click);
            // 
            // buttonGuardarAlta
            // 
            this.buttonGuardarAlta.ActiveBorderThickness = 1;
            this.buttonGuardarAlta.ActiveCornerRadius = 20;
            this.buttonGuardarAlta.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonGuardarAlta.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonGuardarAlta.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonGuardarAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.buttonGuardarAlta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardarAlta.BackgroundImage")));
            this.buttonGuardarAlta.ButtonText = "Guardar";
            this.buttonGuardarAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardarAlta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonGuardarAlta.IdleBorderThickness = 1;
            this.buttonGuardarAlta.IdleCornerRadius = 20;
            this.buttonGuardarAlta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.buttonGuardarAlta.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.buttonGuardarAlta.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.buttonGuardarAlta.Location = new System.Drawing.Point(109, 484);
            this.buttonGuardarAlta.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGuardarAlta.Name = "buttonGuardarAlta";
            this.buttonGuardarAlta.Size = new System.Drawing.Size(181, 41);
            this.buttonGuardarAlta.TabIndex = 10;
            this.buttonGuardarAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonGuardarAlta.Click += new System.EventHandler(this.ButtonGuardarAltaCliente_Click);
            // 
            // labelCuit
            // 
            this.labelCuit.AutoSize = true;
            this.labelCuit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuit.ForeColor = System.Drawing.Color.Silver;
            this.labelCuit.Location = new System.Drawing.Point(16, 120);
            this.labelCuit.Name = "labelCuit";
            this.labelCuit.Size = new System.Drawing.Size(35, 17);
            this.labelCuit.TabIndex = 15;
            this.labelCuit.Text = "CUIT";
            // 
            // textCUIT
            // 
            this.textCUIT.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textCUIT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textCUIT.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textCUIT.BorderThickness = 1;
            this.textCUIT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCUIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCUIT.ForeColor = System.Drawing.Color.Coral;
            this.textCUIT.isPassword = false;
            this.textCUIT.Location = new System.Drawing.Point(16, 151);
            this.textCUIT.Margin = new System.Windows.Forms.Padding(4);
            this.textCUIT.Name = "textCUIT";
            this.textCUIT.Size = new System.Drawing.Size(404, 29);
            this.textCUIT.TabIndex = 3;
            this.textCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvincia.ForeColor = System.Drawing.Color.Silver;
            this.labelProvincia.Location = new System.Drawing.Point(16, 194);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(68, 17);
            this.labelProvincia.TabIndex = 18;
            this.labelProvincia.Text = "Provincia";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.Color.Silver;
            this.labelDireccion.Location = new System.Drawing.Point(16, 342);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(69, 17);
            this.labelDireccion.TabIndex = 20;
            this.labelDireccion.Text = "Direccion";
            // 
            // textDireccion
            // 
            this.textDireccion.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textDireccion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textDireccion.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textDireccion.BorderThickness = 1;
            this.textDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.ForeColor = System.Drawing.Color.Coral;
            this.textDireccion.isPassword = false;
            this.textDireccion.Location = new System.Drawing.Point(16, 373);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(404, 29);
            this.textDireccion.TabIndex = 8;
            this.textDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureFoto
            // 
            this.pictureFoto.Image = global::MTN_Administration.Properties.Resources._036_suitcase;
            this.pictureFoto.Location = new System.Drawing.Point(452, 46);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(253, 208);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFoto.TabIndex = 16;
            this.pictureFoto.TabStop = false;
            // 
            // botonCargarFoto
            // 
            this.botonCargarFoto.ActiveBorderThickness = 1;
            this.botonCargarFoto.ActiveCornerRadius = 20;
            this.botonCargarFoto.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.botonCargarFoto.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonCargarFoto.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.botonCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.botonCargarFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCargarFoto.BackgroundImage")));
            this.botonCargarFoto.ButtonText = "Cargar Foto";
            this.botonCargarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCargarFoto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCargarFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.botonCargarFoto.IdleBorderThickness = 1;
            this.botonCargarFoto.IdleCornerRadius = 20;
            this.botonCargarFoto.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.botonCargarFoto.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.botonCargarFoto.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.botonCargarFoto.Location = new System.Drawing.Point(452, 262);
            this.botonCargarFoto.Margin = new System.Windows.Forms.Padding(5);
            this.botonCargarFoto.Name = "botonCargarFoto";
            this.botonCargarFoto.Size = new System.Drawing.Size(253, 30);
            this.botonCargarFoto.TabIndex = 9;
            this.botonCargarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonCargarFoto.Click += new System.EventHandler(this.BotonCargarFoto_click);
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboBoxProvincia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.comboBoxProvincia.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.comboBoxProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProvincia.ForeColor = System.Drawing.Color.Coral;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(16, 225);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(404, 29);
            this.comboBoxProvincia.TabIndex = 6;
            this.comboBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProvincia_onItemSelected);
            // 
            // comboBoxLocalidad
            // 
            this.comboBoxLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboBoxLocalidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.comboBoxLocalidad.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.comboBoxLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLocalidad.ForeColor = System.Drawing.Color.Coral;
            this.comboBoxLocalidad.FormattingEnabled = true;
            this.comboBoxLocalidad.Location = new System.Drawing.Point(16, 299);
            this.comboBoxLocalidad.Name = "comboBoxLocalidad";
            this.comboBoxLocalidad.Size = new System.Drawing.Size(404, 29);
            this.comboBoxLocalidad.TabIndex = 7;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalidad.ForeColor = System.Drawing.Color.Silver;
            this.labelLocalidad.Location = new System.Drawing.Point(16, 268);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(73, 17);
            this.labelLocalidad.TabIndex = 19;
            this.labelLocalidad.Text = "Localidad";
            // 
            // textRazonSocial
            // 
            this.textRazonSocial.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textRazonSocial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.textRazonSocial.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textRazonSocial.BorderThickness = 1;
            this.textRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRazonSocial.ForeColor = System.Drawing.Color.Coral;
            this.textRazonSocial.isPassword = false;
            this.textRazonSocial.Location = new System.Drawing.Point(16, 77);
            this.textRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.textRazonSocial.Name = "textRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(404, 29);
            this.textRazonSocial.TabIndex = 0;
            this.textRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazonSocial.ForeColor = System.Drawing.Color.Silver;
            this.labelRazonSocial.Location = new System.Drawing.Point(16, 46);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(90, 17);
            this.labelRazonSocial.TabIndex = 12;
            this.labelRazonSocial.Text = "Razon Social";
            // 
            // Alta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.comboBoxLocalidad);
            this.Controls.Add(this.botonCargarFoto);
            this.Controls.Add(this.pictureFoto);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.textCUIT);
            this.Controls.Add(this.labelLocalidad);
            this.Controls.Add(this.labelCuit);
            this.Controls.Add(this.textRazonSocial);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.buttonCancelarAlta);
            this.Controls.Add(this.buttonGuardarAlta);
            this.Name = "Alta_Cliente";
            this.Size = new System.Drawing.Size(727, 561);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 buttonGuardarAlta;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonCancelarAlta;
        private Bunifu.Framework.UI.BunifuCustomLabel labelCuit;
        private Bunifu.Framework.UI.BunifuMetroTextbox textCUIT;
        private Bunifu.Framework.UI.BunifuCustomLabel labelProvincia;
        private Bunifu.Framework.UI.BunifuCustomLabel labelDireccion;
        private Bunifu.Framework.UI.BunifuMetroTextbox textDireccion;
        private System.Windows.Forms.PictureBox pictureFoto;
        private Bunifu.Framework.UI.BunifuThinButton2 botonCargarFoto;
        private CustomComboBox comboBoxProvincia;
        private CustomComboBox comboBoxLocalidad;
        private Bunifu.Framework.UI.BunifuCustomLabel labelLocalidad;
        private Bunifu.Framework.UI.BunifuMetroTextbox textRazonSocial;
        private Bunifu.Framework.UI.BunifuCustomLabel labelRazonSocial;
    }
}
