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
using oblig_csharp_2021_frontend_win.ServicioSoap;

namespace oblig_csharp_2021_frontend_win.Banda
{
    public partial class BandaListado : Form
    {
        EntidadModo entidadModo = EntidadModo.Listar;
        ServicioSoap.MusicUDE_SericeSoapClient consultaWS = new ServicioSoap.MusicUDE_SericeSoapClient();

        public BandaListado()
        {
            InitializeComponent();
        }

        private void CargarLista_Load(object sender, EventArgs e)
        {
            cargarLista();
            textBoxBuscarPorID.Text = Util.getFirstBandaId().ToString();
            buscarPorID();
        }

        private void buttonRefrescarLista_Click(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            String temp = textBoxAtt3.Text;
            cargarComboBoxGeneroMusical();
            textBoxAtt3.Text = temp;

            listView.Clear();
            msg_Info(Util.getMsg("Recargando"));
            Thread.Sleep(1000);
            //Task.Delay(1000);

            ////DEFINIR FORMATO DE LINEAS AL LIST VIEW
            //listView.View = View.Details;
            //listView.GridLines = true;
            //listView.FullRowSelect = true;

            ////ASIGNAR COLUMNAS, RESPECTIVOS NOMBRES Y TAMAÑOS DE RENGLÓN
            listView.Columns.Add(Util.getMsg("BandaID"), 70);
            listView.Columns.Add(Util.getMsg("Nombre"), 150);
            listView.Columns.Add(Util.getMsg("ACreacion"), 150);
            listView.Columns.Add(Util.getMsg("ASeparacion"), 150);
            listView.Columns.Add(Util.getMsg("GenMus"), 150);
            listView.Columns.Add(Util.getMsg("CantIntegs"), 100);
            listView.Columns.Add(Util.getMsg("CantAlbumes"), 100);

            String[] elementosFila = new string[7];
            ListViewItem elementoListViewROW;

            VOBanda[] listaVOBanda = consultaWS.BandaListado();

            foreach (VOBanda item in listaVOBanda)
            {

                elementosFila[0] = item.Id.ToString(); 
                elementosFila[1] = item.Nombre;
                elementosFila[2] = item.AnioCreacion.ToString();
                elementosFila[3] = item.AnioSeparacion.ToString();

                VOGeneroMusical[] vOGeneroMusicals = consultaWS.GeneroMusicalListado();

                foreach (VOGeneroMusical item2 in vOGeneroMusicals)
                {
                    if (item2.genero == item.Genero)
                    {
                        elementosFila[4] = item2.genero + "  ( Id:" + item2.Id.ToString() + " )";
                        break;
                    }
                }

                elementosFila[5] = item.Integrantes.Length.ToString();

                VOAlbum[] vOAlbums = consultaWS.BandaAlbumListado(item.Id);
                elementosFila[6] = vOAlbums.Count().ToString().Trim();

                elementoListViewROW = new ListViewItem(elementosFila);

                listView.Items.Add(elementoListViewROW);
            }

            msg_Success(Util.getMsg("CargaCorrecta"));
        }

        private void msg_Void()
        {
            labelOutPutMessage.Hide();
            labelOutPutMessage.Text = " ";
            labelOutPutMessage.BackColor = System.Drawing.SystemColors.Control;
            labelOutPutMessage.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void msg_Info(String inText)
        {
            msg_Void();

            labelOutPutMessage.Text = Util.getMsg("Info") + inText.Trim();
            labelOutPutMessage.BackColor = Color.RoyalBlue;
            labelOutPutMessage.ForeColor = Color.White;
            labelOutPutMessage.Show();
        }

        private void msg_Success(String inText)
        {
            msg_Void();
            labelOutPutMessage.Text = Util.getMsg("Success") + inText.Trim();
            labelOutPutMessage.BackColor = Color.ForestGreen;
            labelOutPutMessage.ForeColor = Color.White;
            labelOutPutMessage.Show();
        }

        private void msg_Warning(String inText)
        {
            msg_Void();
            labelOutPutMessage.Text = Util.getMsg("Warning") + inText.Trim();
            labelOutPutMessage.BackColor = Color.DarkOrange;
            labelOutPutMessage.ForeColor = Color.White;
            labelOutPutMessage.Show();
        }

        private void msg_Error(String inText)
        {
            msg_Void();

            labelOutPutMessage.Text = Util.getMsg("Error") + inText.Trim();
            labelOutPutMessage.BackColor = Color.Gold;
            labelOutPutMessage.ForeColor = Color.Red;
            labelOutPutMessage.Show();
        }

        private void buttonBuscarPorID_Click(object sender, EventArgs e)
        {
            buscarPorID();
        }

        private void buscarPorID()
        {
            if (textBoxBuscarPorID.Text.Trim() == "")
            {
                msg_Error(Util.getMsg("IngreseIDParaBuscar"));
            }
            else
            {
                bool isEncontro = false;

                VOBanda[] listaVOBanda = consultaWS.BandaListado();

                foreach (VOBanda item in listaVOBanda)
                {
                    if (item.Id.ToString() == textBoxBuscarPorID.Text.Trim())
                    {
                        textBoxAtt1.Text = item.Nombre.ToString();
                        textBoxAtt2.Text = item.AnioCreacion.ToString();
                        textBoxAtt3.Text = item.Genero.ToString();
                        textBoxAtt4.Text = item.AnioSeparacion.ToString();
                        isEncontro = true;
                        break;
                    }
                }

                if (isEncontro)
                {
                    buttonModificar.Visible = true;
                    buttonEliminar.Visible = true;
                    buttonConfirmar.Visible = false;

                    labelAtt1.Visible = true;
                    labelAtt2.Visible = true;
                    labelAtt3.Visible = true;
                    labelAtt4.Visible = true;

                    textBoxAtt1.Visible = true;
                    textBoxAtt2.Visible = true;
                    textBoxAtt3.Visible = true;
                    textBoxAtt4.Visible = true;

                    textBoxAtt1.Enabled = false;
                    textBoxAtt2.Enabled = false;
                    textBoxAtt3.Enabled = false;
                    textBoxAtt4.Enabled = false;

                    msg_Success(Util.getMsg("DatosRecBandaOk") + textBoxBuscarPorID.Text.Trim());
                }
                else
                {
                    buttonModificar.Visible = false;
                    buttonEliminar.Visible = false;
                    buttonConfirmar.Visible = false;

                    labelAtt1.Visible = false;
                    labelAtt2.Visible = false;
                    labelAtt3.Visible = false;
                    labelAtt4.Visible = false;

                    textBoxAtt1.Visible = false;
                    textBoxAtt2.Visible = false;
                    textBoxAtt3.Visible = false;
                    textBoxAtt4.Visible = false;

                    textBoxAtt1.Text = "";
                    textBoxAtt2.Text = "";
                    textBoxAtt3.Text = "";
                    textBoxAtt4.Text = "0";

                    textBoxAtt1.Enabled = false;
                    textBoxAtt2.Enabled = false;
                    textBoxAtt3.Enabled = false;
                    textBoxAtt4.Enabled = false;

                    msg_Error(Util.getMsg("IngreseIDParaBuscar"));
                }
            }
        }


        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            entidadModo = EntidadModo.Insertar;

            buttonModificar.Visible = false;
            buttonEliminar.Visible = false;

            textBoxBuscarPorID.Text = "";
            buttonConfirmar.Visible = true;

            buttonConfirmar.Text = Util.getMsg("ConfirmarIngreso");

            labelAtt1.Visible = true;
            labelAtt2.Visible = true;
            labelAtt3.Visible = true;
            labelAtt4.Visible = true;

            textBoxAtt1.Visible = true;
            textBoxAtt2.Visible = true;
            textBoxAtt3.Visible = true;
            textBoxAtt4.Visible = true;
            textBoxAtt4.Text = "0";

            textBoxAtt1.Enabled = true;
            textBoxAtt2.Enabled = true;
            textBoxAtt3.Enabled = true;
            textBoxAtt4.Enabled = true;

            msg_Info(Util.getMsg("ConfirmarIngresoBanda"));

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            entidadModo = EntidadModo.Modificar;

            textBoxAtt1.Enabled = true;
            textBoxAtt2.Enabled = true;
            textBoxAtt3.Enabled = true;
            textBoxAtt4.Enabled = true;

            buttonConfirmar.Visible = true;
            buttonConfirmar.Text = Util.getMsg("ConfModif");

            msg_Info(Util.getMsg("PuedeModificarBanda") + textBoxBuscarPorID.Text.Trim());
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            msg_Warning(Util.getMsg("ConfirmarEliminacion"));

            buttonConfirmar.Visible = true;
            buttonConfirmar.Text = Util.getMsg("ConfirmarEliminacionBTN");
            entidadModo = EntidadModo.Eliminar;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            int idAux;
            bool resultado;
            VOBanda voBanadaNueva;

            switch (entidadModo)
            {
                case EntidadModo.Listar:

                    break;
                case EntidadModo.Insertar:

                    voBanadaNueva = new VOBanda();
                    voBanadaNueva.Nombre = textBoxAtt1.Text.Trim();
                    voBanadaNueva.AnioCreacion = Convert.ToInt32(textBoxAtt2.Text.Trim());
                    voBanadaNueva.Genero = textBoxAtt3.Text.Trim(); 
                    voBanadaNueva.AnioSeparacion = Convert.ToInt32(textBoxAtt4.Text.Trim());
                    

                    resultado = consultaWS.BandaAlta(voBanadaNueva);

                    if (resultado)
                    {
                        msg_Success(Util.getMsg("ConfInsert"));
                        cargarLista();
                    }
                    else
                        msg_Error(Util.getMsg("ErrorIngreso"));

                    break;
                case EntidadModo.Modificar:
                    idAux = Convert.ToInt32(textBoxBuscarPorID.Text.Trim());
                    voBanadaNueva = new VOBanda();
                    voBanadaNueva.Id = idAux;
                    voBanadaNueva.Nombre = textBoxAtt1.Text.Trim();
                    voBanadaNueva.AnioCreacion = Convert.ToInt32(textBoxAtt2.Text.Trim());
                    voBanadaNueva.Genero = textBoxAtt3.Text.Trim();
                    voBanadaNueva.AnioSeparacion = Convert.ToInt32(textBoxAtt4.Text.Trim());

                    resultado = consultaWS.BandaModificar(voBanadaNueva);

                    if (resultado)
                    {
                        msg_Success(Util.getMsg("ConfUpdate"));
                        cargarLista();
                    }
                    else
                        msg_Error(Util.getMsg("ErrorProcedimiento"));

                    break;
                case EntidadModo.Eliminar:
                    idAux = Convert.ToInt32(textBoxBuscarPorID.Text.Trim());
                    resultado = consultaWS.BandaBaja(idAux);
                    if (resultado)
                    {
                        msg_Success(Util.getMsg("ConfDelete"));
                        cargarLista();
                    }
                    else
                        msg_Error(Util.getMsg("ErrorProcedimiento"));
                    break;
                default:
                    break;
            }
           
        }

        public void cargarComboBoxGeneroMusical()
        {
            textBoxAtt3.Items.Clear();
            VOGeneroMusical[] vOGeneroMusicals = consultaWS.GeneroMusicalListado();
            foreach (VOGeneroMusical item in vOGeneroMusicals)
            {
                textBoxAtt3.Items.Add(item.genero);
            }
            textBoxAtt3.Sorted = true;

            foreach (String item in textBoxAtt3.Items)
            {
                textBoxAtt3.Text = item;
                break;
            }
        }


        private void buttonPageFirst_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getFirstBandaId().ToString();
            buscarPorID();
        }

        private void buttonPageLast_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getLastBandaId().ToString();
            buscarPorID();
        }

        private void buttonPagePrevious_Click(object sender, EventArgs e)
        {
            String aux = textBoxBuscarPorID.Text;
            int num = Convert.ToInt32(aux) - 1;
            if (num>=0)
            {
                textBoxBuscarPorID.Text = num.ToString();
                buscarPorID();
            }
            
        }

        private void buttonPageNext_Click(object sender, EventArgs e)
        {
            String aux = textBoxBuscarPorID.Text;
            int num = Convert.ToInt32(aux) + 1;
            if (num <= Util.getLastBandaId())
            {
                textBoxBuscarPorID.Text = num.ToString();
                buscarPorID();
            }
        }



       
    }
}
