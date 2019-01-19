using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTN_Administration
{

    public partial class Splash : Form
    {
        List<Color> colors = new List<Color>();



        public Splash()
        {
            colors.Add(Color.FromArgb(0, 158, 71));
            colors.Add(Color.FromArgb(112, 191, 83));
            colors.Add(Color.FromArgb(216, 155, 40));
            colors.Add(Color.FromArgb(217, 102, 41));
            colors.Add(Color.FromArgb(217, 102, 41));
            colors.Add(Color.FromArgb(235, 83, 104));
            colors.Add(Color.FromArgb(223, 128, 255));
            colors.Add(Color.FromArgb(112, 48, 160));
            colors.Add(Color.FromArgb(107, 122, 187));
            colors.Add(Color.FromArgb(95, 136, 176));
            colors.Add(Color.FromArgb(70, 175, 227));
            colors.Add(Color.FromArgb(0, 158, 71));



            this.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height /2);
            this.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width /2);
            InitializeComponent();
        }


        int curcol = 0;
        int loop = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            if (curcol < colors.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(loop, colors[curcol], colors[curcol + 1]);
                if (loop < 100)
                {
                    loop++;
                }
                else
                {
                    loop = 0;
                    curcol++;
                }
                timer.Enabled = true;
            }
            else curcol = 0;
        }
    }

}

