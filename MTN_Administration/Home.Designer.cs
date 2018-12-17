namespace MTN_Administration
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TecnicosButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SucuralesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ClientesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DashBoardButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerClientePicture = new System.Windows.Forms.PictureBox();
            this.headerTecnicoPicture = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.TituloHeader = new System.Windows.Forms.Label();
            this.headerDashboardPicture = new System.Windows.Forms.PictureBox();
            this.dashboard1 = new MTN_Administration.Tabs.Dashboard();
            this.amB_Tecnicos1 = new MTN_Administration.AMB_Tecnicos();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerClientePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTecnicoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerDashboardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.TecnicosButton);
            this.sidePanel.Controls.Add(this.SucuralesButton);
            this.sidePanel.Controls.Add(this.ClientesButton);
            this.sidePanel.Controls.Add(this.DashBoardButton);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(236, 600);
            this.sidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 66);
            this.panel1.TabIndex = 5;
            // 
            // TecnicosButton
            // 
            this.TecnicosButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.TecnicosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.TecnicosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TecnicosButton.BorderRadius = 0;
            this.TecnicosButton.ButtonText = "Tecnicos";
            this.TecnicosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TecnicosButton.DisabledColor = System.Drawing.Color.Gray;
            this.TecnicosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TecnicosButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TecnicosButton.Iconcolor = System.Drawing.Color.Transparent;
            this.TecnicosButton.Iconimage = null;
            this.TecnicosButton.Iconimage_right = null;
            this.TecnicosButton.Iconimage_right_Selected = null;
            this.TecnicosButton.Iconimage_Selected = null;
            this.TecnicosButton.IconMarginLeft = 0;
            this.TecnicosButton.IconMarginRight = 0;
            this.TecnicosButton.IconRightVisible = true;
            this.TecnicosButton.IconRightZoom = 0D;
            this.TecnicosButton.IconVisible = true;
            this.TecnicosButton.IconZoom = 90D;
            this.TecnicosButton.IsTab = true;
            this.TecnicosButton.Location = new System.Drawing.Point(0, 183);
            this.TecnicosButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TecnicosButton.Name = "TecnicosButton";
            this.TecnicosButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.TecnicosButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.TecnicosButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.TecnicosButton.selected = false;
            this.TecnicosButton.Size = new System.Drawing.Size(236, 48);
            this.TecnicosButton.TabIndex = 4;
            this.TecnicosButton.Text = "Tecnicos";
            this.TecnicosButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TecnicosButton.Textcolor = System.Drawing.Color.LightGray;
            this.TecnicosButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TecnicosButton.Click += new System.EventHandler(this.TecnicosButton_Click);
            // 
            // SucuralesButton
            // 
            this.SucuralesButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SucuralesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SucuralesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SucuralesButton.BorderRadius = 0;
            this.SucuralesButton.ButtonText = "Sucursales";
            this.SucuralesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SucuralesButton.DisabledColor = System.Drawing.Color.Gray;
            this.SucuralesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SucuralesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SucuralesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SucuralesButton.Iconimage = null;
            this.SucuralesButton.Iconimage_right = null;
            this.SucuralesButton.Iconimage_right_Selected = null;
            this.SucuralesButton.Iconimage_Selected = null;
            this.SucuralesButton.IconMarginLeft = 0;
            this.SucuralesButton.IconMarginRight = 0;
            this.SucuralesButton.IconRightVisible = true;
            this.SucuralesButton.IconRightZoom = 0D;
            this.SucuralesButton.IconVisible = true;
            this.SucuralesButton.IconZoom = 90D;
            this.SucuralesButton.IsTab = true;
            this.SucuralesButton.Location = new System.Drawing.Point(0, 135);
            this.SucuralesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SucuralesButton.Name = "SucuralesButton";
            this.SucuralesButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SucuralesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SucuralesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.SucuralesButton.selected = false;
            this.SucuralesButton.Size = new System.Drawing.Size(236, 48);
            this.SucuralesButton.TabIndex = 3;
            this.SucuralesButton.Text = "Sucursales";
            this.SucuralesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SucuralesButton.Textcolor = System.Drawing.Color.LightGray;
            this.SucuralesButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ClientesButton
            // 
            this.ClientesButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ClientesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientesButton.BorderRadius = 0;
            this.ClientesButton.ButtonText = "Clientes";
            this.ClientesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientesButton.DisabledColor = System.Drawing.Color.Gray;
            this.ClientesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ClientesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ClientesButton.Iconimage = null;
            this.ClientesButton.Iconimage_right = null;
            this.ClientesButton.Iconimage_right_Selected = null;
            this.ClientesButton.Iconimage_Selected = null;
            this.ClientesButton.IconMarginLeft = 0;
            this.ClientesButton.IconMarginRight = 0;
            this.ClientesButton.IconRightVisible = true;
            this.ClientesButton.IconRightZoom = 0D;
            this.ClientesButton.IconVisible = true;
            this.ClientesButton.IconZoom = 90D;
            this.ClientesButton.IsTab = true;
            this.ClientesButton.Location = new System.Drawing.Point(0, 87);
            this.ClientesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ClientesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.ClientesButton.selected = false;
            this.ClientesButton.Size = new System.Drawing.Size(236, 48);
            this.ClientesButton.TabIndex = 2;
            this.ClientesButton.Text = "Clientes";
            this.ClientesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClientesButton.Textcolor = System.Drawing.Color.LightGray;
            this.ClientesButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // DashBoardButton
            // 
            this.DashBoardButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.DashBoardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.DashBoardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashBoardButton.BorderRadius = 0;
            this.DashBoardButton.ButtonText = "Dashboard";
            this.DashBoardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashBoardButton.DisabledColor = System.Drawing.Color.Gray;
            this.DashBoardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoardButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DashBoardButton.Iconimage = null;
            this.DashBoardButton.Iconimage_right = null;
            this.DashBoardButton.Iconimage_right_Selected = null;
            this.DashBoardButton.Iconimage_Selected = null;
            this.DashBoardButton.IconMarginLeft = 0;
            this.DashBoardButton.IconMarginRight = 0;
            this.DashBoardButton.IconRightVisible = true;
            this.DashBoardButton.IconRightZoom = 0D;
            this.DashBoardButton.IconVisible = true;
            this.DashBoardButton.IconZoom = 90D;
            this.DashBoardButton.IsTab = true;
            this.DashBoardButton.Location = new System.Drawing.Point(0, 39);
            this.DashBoardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DashBoardButton.Name = "DashBoardButton";
            this.DashBoardButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DashBoardButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.DashBoardButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.DashBoardButton.selected = true;
            this.DashBoardButton.Size = new System.Drawing.Size(236, 48);
            this.DashBoardButton.TabIndex = 1;
            this.DashBoardButton.Text = "Dashboard";
            this.DashBoardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DashBoardButton.Textcolor = System.Drawing.Color.LightGray;
            this.DashBoardButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(236, 39);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.headerClientePicture);
            this.headerPanel.Controls.Add(this.headerTecnicoPicture);
            this.headerPanel.Controls.Add(this.minimize);
            this.headerPanel.Controls.Add(this.close);
            this.headerPanel.Controls.Add(this.TituloHeader);
            this.headerPanel.Controls.Add(this.headerDashboardPicture);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(236, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(739, 39);
            this.headerPanel.TabIndex = 1;
            // 
            // headerClientePicture
            // 
            this.headerClientePicture.Image = global::MTN_Administration.Properties.Resources._036_suitcase;
            this.headerClientePicture.Location = new System.Drawing.Point(6, 9);
            this.headerClientePicture.Name = "headerClientePicture";
            this.headerClientePicture.Size = new System.Drawing.Size(20, 20);
            this.headerClientePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerClientePicture.TabIndex = 6;
            this.headerClientePicture.TabStop = false;
            this.headerClientePicture.Visible = false;
            // 
            // headerTecnicoPicture
            // 
            this.headerTecnicoPicture.Image = global::MTN_Administration.Properties.Resources._008_friend;
            this.headerTecnicoPicture.Location = new System.Drawing.Point(6, 9);
            this.headerTecnicoPicture.Name = "headerTecnicoPicture";
            this.headerTecnicoPicture.Size = new System.Drawing.Size(20, 20);
            this.headerTecnicoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerTecnicoPicture.TabIndex = 5;
            this.headerTecnicoPicture.TabStop = false;
            this.headerTecnicoPicture.Visible = false;
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.SystemColors.Window;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.minimize.Location = new System.Drawing.Point(670, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(12, 17);
            this.minimize.TabIndex = 4;
            this.minimize.Text = "-";
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.SystemColors.Window;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.close.Location = new System.Drawing.Point(693, 12);
            this.close.Name = "Close";
            this.close.Size = new System.Drawing.Size(16, 17);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TituloHeader
            // 
            this.TituloHeader.AutoSize = true;
            this.TituloHeader.BackColor = System.Drawing.SystemColors.Window;
            this.TituloHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.TituloHeader.Location = new System.Drawing.Point(63, 9);
            this.TituloHeader.Name = "TituloHeader";
            this.TituloHeader.Size = new System.Drawing.Size(97, 21);
            this.TituloHeader.TabIndex = 2;
            this.TituloHeader.Text = "Dashboard";
            // 
            // headerDashboardPicture
            // 
            this.headerDashboardPicture.Image = global::MTN_Administration.Properties.Resources._030_setting;
            this.headerDashboardPicture.Location = new System.Drawing.Point(6, 9);
            this.headerDashboardPicture.Name = "headerDashboardPicture";
            this.headerDashboardPicture.Size = new System.Drawing.Size(20, 20);
            this.headerDashboardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerDashboardPicture.TabIndex = 1;
            this.headerDashboardPicture.TabStop = false;
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(236, 39);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(739, 561);
            this.dashboard1.TabIndex = 3;
            // 
            // amB_Tecnicos1
            // 
            this.amB_Tecnicos1.BackColor = System.Drawing.Color.Gainsboro;
            this.amB_Tecnicos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amB_Tecnicos1.Location = new System.Drawing.Point(236, 39);
            this.amB_Tecnicos1.Name = "amB_Tecnicos1";
            this.amB_Tecnicos1.Size = new System.Drawing.Size(739, 561);
            this.amB_Tecnicos1.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(975, 600);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.amB_Tecnicos1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerClientePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTecnicoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerDashboardPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private Bunifu.Framework.UI.BunifuFlatButton DashBoardButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton SucuralesButton;
        private Bunifu.Framework.UI.BunifuFlatButton ClientesButton;
        private System.Windows.Forms.Label TituloHeader;
        private System.Windows.Forms.PictureBox headerDashboardPicture;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label close;
        private Bunifu.Framework.UI.BunifuFlatButton TecnicosButton;
        private System.Windows.Forms.Panel panel1;
        private AMB_Tecnicos amB_Tecnicos1;
        private Tabs.Dashboard dashboard1;
        private System.Windows.Forms.PictureBox headerTecnicoPicture;
        private System.Windows.Forms.PictureBox headerClientePicture;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

