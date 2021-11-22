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

namespace oblig_csharp_2021_frontend_win.AlbumCancion
{
    public partial class AlbumCancionListar : Form
    {
        EntidadModo entidadModo = EntidadModo.Listar;
        ServicioSoap.MusicUDE_SericeSoapClient consultaWS = new ServicioSoap.MusicUDE_SericeSoapClient();

        int idAux = 0;
        int idAux2 = 0;
        bool resultado = false;

        public AlbumCancionListar()
        {
            InitializeComponent();
        }

        private void AlbumCancionesListar_Load(object sender, EventArgs e)
        {
            msg_Info(Util.getMsg("IngreseAlbumIDParaCanciones"));
            textBoxBuscarPorID.Text = Util.getFirstAlbumId().ToString();
            buscarPorID();
        }


        private void CargarLista_Load(object sender, EventArgs e)
        {
            cargarLista();
        }


        private void cargarLista()
        {
            labelTituloDetalle.Visible = false;
            labelSubElementoID.Visible = false;
            textBoxSubElementoID.Visible = false;
            buttonInsertar.Visible = false;
            buttonEliminar.Visible = false;

            if (textBoxBuscarPorID.Text.Trim() == "")
            {
                msg_Error(Util.getMsg("IngreseIDParaBuscar"));
            }
            else
            {
                listView.Clear();
                msg_Info(Util.getMsg("Recargando"));
                Thread.Sleep(1000);
                //Task.Delay(1000);

                ////DEFINIR FORMATO DE LINEAS AL LIST VIEW
                //listView.View = View.Details;
                //listView.GridLines = true;
                //listView.FullRowSelect = true;

                VOAlbum[] listaVOAlbum = consultaWS.AlbumListado();

                foreach (VOAlbum item in listaVOAlbum)
                {
                    if (item.Id.ToString() == textBoxBuscarPorID.Text.Trim())
                    {
                        ////ASIGNAR COLUMNAS, RESPECTIVOS NOMBRES Y TAMAÑOS DE RENGLÓN
                        listView.Columns.Add(Util.getMsg("AlbumID"), 70);
                        listView.Columns.Add("Album " + Util.getMsg("Nombre"), 150);
                        listView.Columns.Add(Util.getMsg("CancionID"), 150);
                        listView.Columns.Add("Canción " + Util.getMsg("Nombre"), 150);

                        String[] elementosFila = new string[4];
                        ListViewItem elementoListViewROW;

                        elementosFila[0] = item.Id.ToString();
                        elementosFila[1] = item.Nombre;

                        VOCancion[] vOCancions = consultaWS.AlbumCancionListado(item.Id);

                        foreach (VOCancion item2 in vOCancions)
                        {
                            elementosFila[2] = item2.Id.ToString();
                            elementosFila[3] = item2.Nombre.ToString();

                            elementoListViewROW = new ListViewItem(elementosFila);
                            listView.Items.Add(elementoListViewROW);
                        }

                        //VOCancion[] vOCancions = consultaWS.CancionListado();
                        //foreach (VOCancion item2 in vOCancions)
                        //{
                        //    if (item.Id == item2.AlbumId)
                        //    {
                        //        elementosFila[2] = item2.Id.ToString();
                        //        elementosFila[3] = item2.Nombre.ToString();

                        //        elementoListViewROW = new ListViewItem(elementosFila);
                        //        listView.Items.Add(elementoListViewROW);

                        //    }

                        //}

                        msg_Success(Util.getMsg("CargaCorrecta"));
                        labelTituloDetalle.Visible = true;
                        labelSubElementoID.Visible = true;
                        textBoxSubElementoID.Visible = true;
                        buttonInsertar.Visible = true;
                        buttonEliminar.Visible = true;

                        break;
                    }
                    else
                    {
                        msg_Error(Util.getMsg("IngreseIDParaBuscar"));
                    }
                }

            }
            
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
            cargarLista();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            idAux = Convert.ToInt32(textBoxBuscarPorID.Text.Trim());
            idAux2 = Convert.ToInt32(textBoxSubElementoID.Text.Trim());

            resultado = consultaWS.AlbumCancionAlta(idAux, idAux2);

            if (resultado)
            {
                msg_Success(Util.getMsg("ConfInsert"));
                cargarLista();
            }
            else
                msg_Error(Util.getMsg("ErrorProcedimiento"));
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            idAux = Convert.ToInt32(textBoxBuscarPorID.Text.Trim());
            idAux2 = Convert.ToInt32(textBoxSubElementoID.Text.Trim());

            resultado = consultaWS.AlbumCancionBaja(idAux, idAux2);

            if (resultado)
            {
                msg_Success(Util.getMsg("ConfDelete"));
                cargarLista();
            }
            else
                msg_Error(Util.getMsg("ErrorProcedimiento"));

            
        }


        private void buttonPageFirst_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getFirstAlbumId().ToString();
            buscarPorID();
        }

        private void buttonPageLast_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getLastAlbumId().ToString();
            buscarPorID();
        }

        private void buttonPagePrevious_Click(object sender, EventArgs e)
        {
            String aux = textBoxBuscarPorID.Text;
            int num = Convert.ToInt32(aux) - 1;
            if (num >= 0)
            {
                textBoxBuscarPorID.Text = num.ToString();
                buscarPorID();
            }
        }

        private void buttonPageNext_Click(object sender, EventArgs e)
        {
            String aux = textBoxBuscarPorID.Text;
            int num = Convert.ToInt32(aux) + 1;
            if (num <= Util.getLastAlbumId())
            {
                textBoxBuscarPorID.Text = num.ToString();
                buscarPorID();
            }
        }


    }
}
