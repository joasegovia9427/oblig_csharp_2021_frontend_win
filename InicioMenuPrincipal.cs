using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using oblig_csharp_2021_frontend_win.Album;
using oblig_csharp_2021_frontend_win.AlbumCancion;
using oblig_csharp_2021_frontend_win.Banda;
using oblig_csharp_2021_frontend_win.Banda_Integrante;
using oblig_csharp_2021_frontend_win.Cancion;
using oblig_csharp_2021_frontend_win.Integrante;
using oblig_csharp_2021_frontend_win.GeneroMusical;


namespace oblig_csharp_2021_frontend_win
{
    public partial class InicioMenuPrincipal : Form
    {
        //BG form_BG = new BG();
        //AlbumListar form_AlbumListar = new AlbumListar();
        //AlbumCancionListar form_AlbumCancionListar = new AlbumCancionListar();
        //BandaListado form_BandaListar = new BandaListado();
        //BandaAlbumesListar form_BandaAlbumesListar = new BandaAlbumesListar();
        //BandaIntegranteListar form_BandaIntegranteListar = new BandaIntegranteListar();
        //CancionListar form_CancionListar = new CancionListar();
        //IntegranteListar form_IntegranteListar = new IntegranteListar();
        //GeneroMusicalListar form_GeneroMusicalListar = new GeneroMusicalListar();

        BG                          form_BG;
        AlbumListar                 form_AlbumListar;
        AlbumCancionListar          form_AlbumCancionListar;
        BandaListado                form_BandaListar;
        BandaAlbumesListar          form_BandaAlbumesListar;
        BandaIntegranteListar       form_BandaIntegranteListar;
        CancionListar               form_CancionListar;
        IntegranteListar            form_IntegranteListar;
        GeneroMusicalListar         form_GeneroMusicalListar;
        ProcsMasivos                form_ProcsMasivos;

        public static int inicioDeAppCont = 1;

        public InicioMenuPrincipal()
        {
            InitializeComponent();
            CrearTodasLasVentanasNew();
        }
        public void CrearTodasLasVentanasNew()
        {
            form_BG                         = new BG();
            form_AlbumListar                = new AlbumListar();
            form_AlbumCancionListar         = new AlbumCancionListar();
            form_BandaListar                = new BandaListado();
            form_BandaAlbumesListar         = new BandaAlbumesListar();
            form_BandaIntegranteListar      = new BandaIntegranteListar();
            form_CancionListar              = new CancionListar();
            form_IntegranteListar           = new IntegranteListar();
            form_GeneroMusicalListar        = new GeneroMusicalListar();
            form_ProcsMasivos               = new ProcsMasivos();
        }

        private void InicioMenuPrincipal_Load(object sender, EventArgs e)
        {
            form_BG.TopLevel = false;
            PanelFrame.Controls.Add(form_BG);
            form_BG.Show();
            form_BG.Dock = DockStyle.Fill;


            //OcultarTodasLasVentanasInternas();
            //form_BandaListar.TopLevel = false;
            //PanelFrame.Controls.Add(form_BandaListar);
            //form_BandaListar.Show();
            //form_BandaListar.Dock = DockStyle.Fill;

            //labelOutPutMessage.Text = labelOutPutMessage.Text + ".";
            //labelOutPutMessage.BackColor = Color.RoyalBlue;//System.Drawing.SystemColors.MenuHighlight;//Color.MenuHi;
            //labelOutPutMessage.ForeColor = Color.White;//System.Drawing.SystemColors.Window;

        }

        public void OcultarTodasLasVentanasInternas()
        {
            form_BG.Hide();
            form_AlbumListar.Hide();
            form_AlbumCancionListar.Hide();
            form_BandaListar.Hide();
            form_BandaIntegranteListar.Hide();
            form_BandaAlbumesListar.Hide();
            form_CancionListar.Hide();
            form_IntegranteListar.Hide();
            form_GeneroMusicalListar.Hide();
            form_ProcsMasivos.Hide();
        }

        public void CerrarTodasLasVentanasInternas()
        {
            form_BG.Close();
            form_AlbumListar.Close();
            form_AlbumCancionListar.Close();
            form_BandaListar.Close();
            form_BandaIntegranteListar.Close();
            form_BandaAlbumesListar.Close();
            form_CancionListar.Close();
            form_IntegranteListar.Close();
            form_GeneroMusicalListar.Close();
            form_ProcsMasivos.Close();

            CrearTodasLasVentanasNew();
        }


        private void AlbumListar_click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_AlbumListar.TopLevel = false;
            PanelFrame.Controls.Add(form_AlbumListar);
            form_AlbumListar.Show();
            form_AlbumListar.Dock = DockStyle.Fill;


        }



        private void AlbumCancionListar_click(object sender, EventArgs e)
        {
            
        }

        private void BandaListar_click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_BandaListar.TopLevel = false;
            PanelFrame.Controls.Add(form_BandaListar);
            form_BandaListar.Show();
            form_BandaListar.Dock = DockStyle.Fill;


        }


        private void BandaIntegranteListar_click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_BandaIntegranteListar.TopLevel = false;
            PanelFrame.Controls.Add(form_BandaIntegranteListar);
            form_BandaIntegranteListar.Show();
            form_BandaIntegranteListar.Dock = DockStyle.Fill;
        }

        private void BandaAlbumesListar_click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_BandaAlbumesListar.TopLevel = false;
            PanelFrame.Controls.Add(form_BandaAlbumesListar);
            form_BandaAlbumesListar.Show();
            form_BandaAlbumesListar.Dock = DockStyle.Fill;
        }



        private void CancionListar_click(object sender, EventArgs e)
        {
           
        }




        private void IntegranteListar_click(object sender, EventArgs e)
        {
            

        }


        private void AboutUs_click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanasInternas();
            form_BG.TopLevel = false;
            PanelFrame.Controls.Add(form_BG);
            form_BG.Show();
            form_BG.Dock = DockStyle.Fill;

            
        }

        


        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_IntegranteListar.TopLevel = false;
            PanelFrame.Controls.Add(form_IntegranteListar);
            form_IntegranteListar.Show();
            form_IntegranteListar.Dock = DockStyle.Fill;
        }

        private void cancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_CancionListar.TopLevel = false;
            PanelFrame.Controls.Add(form_CancionListar);
            form_CancionListar.Show();
            form_CancionListar.Dock = DockStyle.Fill;

        }

        private void listarCancionesDeAlbumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_AlbumCancionListar.TopLevel = false;
            PanelFrame.Controls.Add(form_AlbumCancionListar);
            form_AlbumCancionListar.Show();
            form_AlbumCancionListar.Dock = DockStyle.Fill;

        }

        private void generoMusicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_GeneroMusicalListar.TopLevel = false;
            PanelFrame.Controls.Add(form_GeneroMusicalListar);
            form_GeneroMusicalListar.Show();
            form_GeneroMusicalListar.Dock = DockStyle.Fill;
        }

        private void listarAlbumesDeBandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_BandaAlbumesListar.TopLevel = false;
            PanelFrame.Controls.Add(form_BandaAlbumesListar);
            form_BandaAlbumesListar.Show();
            form_BandaAlbumesListar.Dock = DockStyle.Fill;
        }

        private void cancionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_CancionListar.TopLevel = false;
            PanelFrame.Controls.Add(form_CancionListar);
            form_CancionListar.Show();
            form_CancionListar.Dock = DockStyle.Fill;
        }

       

        private void cargasMasivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarTodasLasVentanasInternas();
            form_ProcsMasivos.TopLevel = false;
            PanelFrame.Controls.Add(form_ProcsMasivos);
            form_ProcsMasivos.Show();
            form_ProcsMasivos.Dock = DockStyle.Fill;
        }
    }
}
