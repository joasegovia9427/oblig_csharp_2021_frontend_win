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

namespace oblig_csharp_2021_frontend_win.GeneroMusical
{
    public partial class GeneroMusicalListar : Form
    {
        EntidadModo entidadModo = EntidadModo.Listar;
        ServicioSoap.MusicUDE_SericeSoapClient consultaWS = new ServicioSoap.MusicUDE_SericeSoapClient();

        public GeneroMusicalListar()
        {
            InitializeComponent();
        }


        private void CargarLista_Load(object sender, EventArgs e)
        {
            cargarLista();
            textBoxBuscarPorID.Text = Util.getFirstGeneroMusicalId().ToString();
            buscarPorID();
        }

        private void buttonRefrescarLista_Click(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            listView.Clear();
            msg_Info(Util.getMsg("Recargando"));
            Thread.Sleep(1000);
            //Task.Delay(1000);


            ////DEFINIR FORMATO DE LINEAS AL LIST VIEW
            //listView.View = View.Details;
            //listView.GridLines = true;
            //listView.FullRowSelect = true;

            ////ASIGNAR COLUMNAS, RESPECTIVOS NOMBRES Y TAMAÑOS DE RENGLÓN
            listView.Columns.Add(Util.getMsg("GeneroMusicalID"), 150);
            listView.Columns.Add(Util.getMsg("Nombre"), 150);
            //listView.Columns.Add(Util.getMsg("GenMusCantBandas"), 150);
            //listView.Columns.Add(Util.getMsg("GenMusCantAlbumes"), 70);
            //listView.Columns.Add(Util.getMsg("GenMusCantCanciones"), 150);


            String[] elementosFila = new string[2];
            ListViewItem elementoListViewROW;

            VOGeneroMusical[] vOGeneroMusicals = consultaWS.GeneroMusicalListado();

            foreach (VOGeneroMusical item in vOGeneroMusicals)
            {
                elementosFila[0] = item.Id.ToString();
                elementosFila[1] = Util.CapitalizeFirstLetter( item.genero.ToString() );
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
                VOGeneroMusical[] vOGeneroMusicals = consultaWS.GeneroMusicalListado();

                foreach (VOGeneroMusical item in vOGeneroMusicals)
                {
                    if (item.Id.ToString() == textBoxBuscarPorID.Text.Trim())
                    {
                        textBoxAtt1.Text = Util.CapitalizeFirstLetter(item.genero.ToString());
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
                    textBoxAtt1.Visible = true;
                    textBoxAtt1.Enabled = false;

                    msg_Success(Util.getMsg("DatosRecGeneroMusOk") + textBoxBuscarPorID.Text.Trim());
                }
                else {
                    buttonModificar.Visible = false;
                    buttonEliminar.Visible = false;
                    buttonConfirmar.Visible = false;

                    textBoxAtt1.Text = "";
                    labelAtt1.Visible = false;
                    textBoxAtt1.Visible = false;
                    textBoxAtt1.Enabled = false;

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

            textBoxAtt1.Visible = true;

            textBoxAtt1.Enabled = true;

            msg_Info(Util.getMsg("ConfirmarIngresoGenMusical"));

        }


        private void buttonModificar_Click(object sender, EventArgs e)
        {
            entidadModo = EntidadModo.Modificar;

            textBoxAtt1.Enabled = true;

            buttonConfirmar.Visible = true;
            buttonConfirmar.Text = Util.getMsg("ConfModif");

            msg_Info(Util.getMsg("PuedeModificarGenMusical") + textBoxBuscarPorID.Text.Trim());
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

            switch (entidadModo)
            {
                case EntidadModo.Listar:

                    break;
                case EntidadModo.Insertar:
                    resultado = consultaWS.GeneroMusicalAlta(textBoxAtt1.Text.Trim());
                    if (resultado)
                    {
                        msg_Success(Util.getMsg("ConfInsert"));
                        cargarLista();
                    }
                    else
                        msg_Error(Util.getMsg("ErrorProcedimiento"));
                    break;
                case EntidadModo.Modificar:
                    idAux = Convert.ToInt32(textBoxBuscarPorID.Text.Trim());
                    String nuevoNombre = textBoxAtt1.Text.Trim().ToLower();
                    resultado = consultaWS.GeneroMusicalModificacion(idAux, nuevoNombre);
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
                    resultado = consultaWS.GeneroMusicalBaja(idAux);
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


        private void buttonPageFirst_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getFirstGeneroMusicalId().ToString();
            buscarPorID();
        }

        private void buttonPageLast_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getLastGeneroMusicalId().ToString();
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
            if (num <= Util.getLastGeneroMusicalId())
            {
                textBoxBuscarPorID.Text = num.ToString();
                buscarPorID();
            }
        }

    }
}
