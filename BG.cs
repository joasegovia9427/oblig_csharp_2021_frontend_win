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

namespace oblig_csharp_2021_frontend_win
{
    public partial class BG : Form
    {

        public BG()
        {
            InitializeComponent();
            pictureBoxFlecha.Visible = true;

            

        }

        private void BG_Load(object sender, EventArgs e)
        {
            if (InicioMenuPrincipal.inicioDeAppCont == 1)
            {
                pictureBoxFlecha.Image = Image.FromFile(@"..\..\RecursosGraficos\flechaArriba50msV2.gif");
                //pictureBoxFlecha.Image = Image.FromFile(@"E:\00GoogleDrive\UDE\25-Nuevas tecnologias\ObligatorioVersionado\oblig_csharp_2021_frontend_win\RecursosGraficos\flechaArriba.gif");
                pictureBoxFlecha.SizeMode = PictureBoxSizeMode.Zoom;

                InicioMenuPrincipal.inicioDeAppCont += 1;
            }
            

            
        }




    }
}
