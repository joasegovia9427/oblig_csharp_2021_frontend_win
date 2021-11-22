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
using System.Net;
using System.IO;

namespace oblig_csharp_2021_frontend_win.Cancion
{
    public partial class CancionListar : Form
    {
        EntidadModo entidadModo = EntidadModo.Listar;
        ServicioSoap.MusicUDE_SericeSoapClient consultaWS = new ServicioSoap.MusicUDE_SericeSoapClient();

        public CancionListar()
        {
            InitializeComponent();
        }

        private void CargarLista_Load(object sender, EventArgs e)
        {
            cargarLista();
            pictureBoxData.ImageLocation = "https://cdn.iconscout.com/icon/free/png-256/apple-music-3521279-2944783.png";
            textBoxBuscarPorID.Text = Util.getFirstCancionId().ToString();
            buscarPorID();
        }

        private void buttonRefrescarLista_Click(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            String temp = textBoxAtt2.Text;
            cargarComboBoxGeneroMusical();
            textBoxAtt2.Text = temp;

            temp = textBoxAtt5.Text;
            cargarComboBoxIntegrantes();
            textBoxAtt5.Text = temp;

            listView.Clear();
            msg_Info(Util.getMsg("Recargando"));
            Thread.Sleep(1000);
            //Task.Delay(1000);


            ////DEFINIR FORMATO DE LINEAS AL LIST VIEW
            //listView.View = View.Details;
            //listView.GridLines = true;
            //listView.FullRowSelect = true;

            ////ASIGNAR COLUMNAS, RESPECTIVOS NOMBRES Y TAMAÑOS DE RENGLÓN
            listView.Columns.Add(Util.getMsg("CancionID"), 70);
            listView.Columns.Add(Util.getMsg("Nombre"), 150);
            listView.Columns.Add(Util.getMsg("ACreacion"), 150);
            listView.Columns.Add(Util.getMsg("Duracion"), 70);
            //listView.Columns.Add(Util.getMsg("AlbumID"), 100);
            listView.Columns.Add(Util.getMsg("GenMus"), 150);
            listView.Columns.Add(Util.getMsg("CantantePrincipal"), 150);
            listView.Columns.Add(Util.getMsg("DatoCancion"), 150);

            String[] elementosFila = new string[7];
            ListViewItem elementoListViewROW;

            VOCancion[] vOCancions = consultaWS.CancionListado();

            foreach (VOCancion item in vOCancions)
            {
                elementosFila[0] = item.Id.ToString();
                elementosFila[1] = item.Nombre.ToString();
                elementosFila[2] = item.Anio.ToString();
                elementosFila[3] = item.Duracion.ToString();
                elementosFila[4] = item.Genero; // "Genero Musical"; //item.AlbumId.ToString();

                VOIntegrante[] vOIntegrantes = consultaWS.IntegrantesListado();
                foreach (VOIntegrante item2 in vOIntegrantes)
                {
                    if (item2.Id == item.IntegranteId)
                    {
                        elementosFila[5] = item2.Persona.Nombre + " " + item2.Persona.Apellido + "  ( Id:" + item.IntegranteId.ToString() + " )";
                        break;
                    }
                }
                elementosFila[6] = item.Dato;

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
                VOCancion[] vOCancions = consultaWS.CancionListado();

                foreach (VOCancion item in vOCancions)
                {
                    if (item.Id.ToString() == textBoxBuscarPorID.Text.Trim())
                    {
                        textBoxAtt1.Text = item.Nombre.ToString();
                        textBoxAtt2.Text = Util.CapitalizeFirstLetter(item.Genero.ToString());
                        textBoxAtt3.Text = item.Anio.ToString();
                        textBoxAtt4.Text = item.Duracion.ToString();
                        VOIntegrante vOIntegrante = consultaWS.IntegranteObtener(item.IntegranteId);
                        textBoxAtt5.Text = vOIntegrante.Persona.Nombre + " " + vOIntegrante.Persona.Apellido;
                        //textBoxAtt6.Text = item.AlbumId.ToString();
                        textBoxAtt7.Text = item.Dato.ToString();
                        //pictureBoxData.Text = true;
                        pictureBoxData.ImageLocation = item.Dato.ToString();

                        //Dato.Text = item.Dato;

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
                    labelAtt5.Visible = true;
                    //labelAtt6.Visible = true;
                    labelAtt7.Visible = true;

                    textBoxAtt1.Visible = true;
                    textBoxAtt2.Visible = true;
                    textBoxAtt3.Visible = true;
                    textBoxAtt4.Visible = true;
                    textBoxAtt5.Visible = true;
                    //textBoxAtt6.Visible = true;
                    textBoxAtt7.Visible = true;
                    pictureBoxData.Visible = true;

                    textBoxAtt1.Enabled = false;
                    textBoxAtt2.Enabled = false;
                    textBoxAtt3.Enabled = false;
                    textBoxAtt4.Enabled = false;
                    textBoxAtt5.Enabled = false;
                    textBoxAtt6.Enabled = false;
                    textBoxAtt7.Enabled = false;
                    pictureBoxData.Enabled = false;

                    msg_Success(Util.getMsg("DatosRecCancionOk") + textBoxBuscarPorID.Text.Trim());
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
                    labelAtt5.Visible = false;
                    labelAtt6.Visible = false;
                    labelAtt7.Visible = false;

                    textBoxAtt1.Visible = false;
                    textBoxAtt2.Visible = false;
                    textBoxAtt3.Visible = false;
                    textBoxAtt4.Visible = false;
                    textBoxAtt5.Visible = false;
                    textBoxAtt6.Visible = false;
                    textBoxAtt7.Visible = false;
                    pictureBoxData.Visible = false;

                    textBoxAtt1.Text = "";
                    textBoxAtt2.Text = "";
                    textBoxAtt3.Text = "";
                    textBoxAtt4.Text = "";
                    textBoxAtt5.Text = "";
                    textBoxAtt6.Text = "";
                    textBoxAtt7.Text = "";

                    textBoxAtt1.Enabled = false;
                    textBoxAtt2.Enabled = false;
                    textBoxAtt3.Enabled = false;
                    textBoxAtt4.Enabled = false;
                    textBoxAtt5.Enabled = false;
                    textBoxAtt6.Enabled = false;
                    textBoxAtt7.Enabled = false;
                    pictureBoxData.Enabled = false;

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
            labelAtt5.Visible = true;
            //labelAtt6.Visible = true;
            labelAtt7.Visible = true;

            textBoxAtt1.Visible = true;
            textBoxAtt2.Visible = true;
            textBoxAtt3.Visible = true;
            textBoxAtt4.Visible = true;
            textBoxAtt5.Visible = true;
            //textBoxAtt6.Visible = true;
            textBoxAtt7.Visible = true;
            pictureBoxData.Visible = true;

            textBoxAtt1.Enabled = true;
            textBoxAtt2.Enabled = true;
            textBoxAtt3.Enabled = true;
            textBoxAtt4.Enabled = true;
            textBoxAtt5.Enabled = true;
            //textBoxAtt6.Enabled = true;
            textBoxAtt7.Enabled = true;
            pictureBoxData.Enabled = true;

            pictureBoxData.ImageLocation = "https://cdn.iconscout.com/icon/free/png-256/apple-music-3521279-2944783.png";

            msg_Info(Util.getMsg("ConfirmarIngresoCancion"));

            
        }


        private void buttonModificar_Click(object sender, EventArgs e)
        {
            entidadModo = EntidadModo.Modificar;

            textBoxAtt1.Enabled = true;
            textBoxAtt2.Enabled = true;
            textBoxAtt3.Enabled = true;
            textBoxAtt4.Enabled = true;
            textBoxAtt5.Enabled = true;
            //textBoxAtt6.Enabled = true;
            textBoxAtt7.Enabled = true;
            pictureBoxData.Enabled = true;

            buttonConfirmar.Visible = true;
            buttonConfirmar.Text = Util.getMsg("ConfModif");

            msg_Info(Util.getMsg("PuedeModificarCancion") + textBoxBuscarPorID.Text.Trim());
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
            VOCancion voCancionNueva;

            switch (entidadModo)
            {
                case EntidadModo.Listar:

                    break;
                case EntidadModo.Insertar:

                    voCancionNueva = new VOCancion();
                    voCancionNueva.Nombre = textBoxAtt1.Text.Trim();
                    voCancionNueva.Genero = textBoxAtt2.Text.Trim();
                    voCancionNueva.Anio = Convert.ToInt32(textBoxAtt3.Text.Trim());
                    voCancionNueva.Duracion = Convert.ToInt32(textBoxAtt4.Text.Trim());
                    voCancionNueva.IntegranteId = Util.getIntegranteIdByNameAndLastName(textBoxAtt5.Text.Trim());
                    voCancionNueva.Dato = textBoxAtt7.Text.Trim();
                    //if (textBoxAtt6.Text != null & textBoxAtt6.Text.Length > 0)
                    //{
                    //    voCancionNueva.AlbumId = Convert.ToInt32(textBoxAtt6.Text.Trim());
                    //}
                    
                    resultado = consultaWS.CancionAlta(voCancionNueva);

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
                    voCancionNueva = new VOCancion();
                    voCancionNueva.Id = idAux;
                    voCancionNueva.Nombre = textBoxAtt1.Text.Trim();
                    voCancionNueva.Genero = textBoxAtt2.Text.Trim();
                    voCancionNueva.Anio = Convert.ToInt32(textBoxAtt3.Text.Trim());
                    voCancionNueva.Duracion = Convert.ToInt32(textBoxAtt4.Text.Trim());
                    voCancionNueva.IntegranteId = Util.getIntegranteIdByNameAndLastName(textBoxAtt5.Text.Trim());
                    voCancionNueva.Dato = textBoxAtt7.Text.Trim(); //Util.getMsg("Dato");// "DatoCancion";
                    //if (textBoxAtt6.Text != null & textBoxAtt6.Text.Length > 0)
                    //{
                    //    voCancionNueva.AlbumId = Convert.ToInt32(textBoxAtt6.Text.Trim());
                    //}

                    resultado = consultaWS.CancionModificacion(voCancionNueva);

                    if (resultado)
                    {

                        //resultado = consultaWS.AlbumCancionAlta(voCancionNueva.AlbumId, idAux);
                        //if (resultado)
                        //{
                            msg_Success(Util.getMsg("ConfUpdate"));
                            cargarLista();
                        //}
                        //else
                        //    msg_Error(Util.getMsg("ErrorProcedimiento"));
                    }
                    else
                        msg_Error(Util.getMsg("ErrorProcedimiento"));

                    break;
                case EntidadModo.Eliminar:
                    idAux = Convert.ToInt32(textBoxBuscarPorID.Text.Trim());
                    resultado = consultaWS.CancionBaja(idAux);
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

        private void textBoxAtt7_TextChanged(object sender, EventArgs e)
        {
            pictureBoxData.ImageLocation = textBoxAtt7.Text.ToString().Trim();
        }


        public void cargarComboBoxGeneroMusical()
        {
            textBoxAtt2.Items.Clear();
            VOGeneroMusical[] vOGeneroMusicals = consultaWS.GeneroMusicalListado();
            foreach (VOGeneroMusical item in vOGeneroMusicals)
            {
                textBoxAtt2.Items.Add(item.genero);
            }
            textBoxAtt2.Sorted = true;

            foreach (String item in textBoxAtt2.Items)
            {
                textBoxAtt2.Text = item;
                break;
            }
        }


        public void cargarComboBoxIntegrantes()
        {
            textBoxAtt5.Items.Clear();
            VOIntegrante[] vOIntegrantes = consultaWS.IntegrantesListado();
            foreach (VOIntegrante item in vOIntegrantes)
            {
                textBoxAtt5.Items.Add(item.Persona.Nombre + " " + item.Persona.Apellido);
            }
            textBoxAtt5.Sorted = true;

            foreach (String item in textBoxAtt5.Items)
            {
                textBoxAtt5.Text = item;
                break;
            }
        }



        private void buttonPageFirst_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getFirstCancionId().ToString();
            buscarPorID();
        }

        private void buttonPageLast_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getLastCancionId().ToString();
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
            if (num <= Util.getLastCancionId())
            {
                textBoxBuscarPorID.Text = num.ToString();
                buscarPorID();
            }
        }



    }
}
