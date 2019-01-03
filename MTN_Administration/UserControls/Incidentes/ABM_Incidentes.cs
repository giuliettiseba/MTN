using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTN_RestAPI.Models;

namespace MTN_Administration.Tabs
{
    public partial class ABM_Incidentes : UserControl
    {
        APIHelper aPIHelper;
        private panelFondo alta_Incidentes;

        public ABM_Incidentes(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
        }





        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

       

        }

        private void BotonAgregarIncidente_Click(object sender, EventArgs e)
        {
        /*    this.alta_Incidentes = new Alta_Incidentes(aPIHelper);
            this.alta_Incidentes.Location = new System.Drawing.Point(0, 0);
            this.alta_Incidentes.Name = "alta_Cliente";
            this.alta_Incidentes.Size = new System.Drawing.Size(727, 561);
            this.alta_Incidentes.TabIndex = 6;
            this.Controls.Add(this.alta_Incidentes);
            this.alta_Incidentes.BringToFront();*/

            alta_Incidentes = new panelFondo(aPIHelper);
            //alta_Incidentes.Dock = System.Windows.Forms.DockStyle.Fill;
            alta_Incidentes.Location = new System.Drawing.Point(0, 0);
            alta_Incidentes.Name = "alta_Incidentes";
            alta_Incidentes.Size = new System.Drawing.Size(739, 561);
            alta_Incidentes.TabIndex = 2;
            Controls.Add(this.alta_Incidentes);
            alta_Incidentes.BringToFront();


        }
    }
}
