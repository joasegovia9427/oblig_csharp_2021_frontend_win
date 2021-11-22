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

namespace oblig_csharp_2021_frontend_win.Banda_Integrante
{
    public partial class BandaIntegranteListar : Form
    {
        EntidadModo entidadModo = EntidadModo.Listar;
        ServicioSoap.MusicUDE_SericeSoapClient consultaWS = new ServicioSoap.MusicUDE_SericeSoapClient();

        int idAux = 0;
        int idAux2 = 0;
        bool resultado = false;

        public BandaIntegranteListar()
        {
            InitializeComponent();
        }

        private void BandaIntegranteListar_Load(object sender, EventArgs e)
        {
            msg_Info(Util.getMsg("IngreseBandaIDParaIntegrantes"));
            textBoxBuscarPorID.Text = Util.getFirstBandaId().ToString();
            buscarPorID();
        }

        private void cargarLista()
        {
            labelTituloDetalle.Visible = false;
            labelIntegranteID.Visible = false;
            textBoxIntegranteID.Visible = false;
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

                VOBanda[] listaVOBanda = consultaWS.BandaListado();

                foreach (VOBanda item in listaVOBanda)
                {
                    if (item.Id.ToString() == textBoxBuscarPorID.Text.Trim())
                    {
                        ////ASIGNAR COLUMNAS, RESPECTIVOS NOMBRES Y TAMAÑOS DE RENGLÓN
                        listView.Columns.Add(Util.getMsg("BandaID"), 70);
                        listView.Columns.Add("Banda " + Util.getMsg("Nombre"), 150);
                        listView.Columns.Add(Util.getMsg("IntegranteID"), 150);
                        listView.Columns.Add("Integrante " + Util.getMsg("Nombre"), 150);

                        String[] elementosFila = new string[4];
                        ListViewItem elementoListViewROW; 
                        
                        elementosFila[0] = item.Id.ToString();
                        elementosFila[1] = item.Nombre;

                        foreach (VOIntegrante item2 in item.Integrantes)
                        {
                            elementosFila[2] = item2.Id.ToString();
                            elementosFila[3] = item2.Persona.Nombre + " " + item2.Persona.Apellido;

                            elementoListViewROW = new ListViewItem(elementosFila);
                            listView.Items.Add(elementoListViewROW);
                        }

                        msg_Success(Util.getMsg("CargaCorrecta"));
                        //labelTituloDetalle.Visible = true;
                        //labelIntegranteID.Visible = true;
                        //textBoxIntegranteID.Visible = true;
                        //buttonInsertar.Visible = true;
                        //buttonEliminar.Visible = true;

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
            //msg_Success(Util.getMsg("DatosRecBandaOk") + textBoxBuscarPorID.Text.Trim());
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            idAux = Convert.ToInt32(textBoxBuscarPorID.Text.Trim());
            idAux2 = Convert.ToInt32(textBoxIntegranteID.Text.Trim());
            
            resultado = consultaWS.BandaIntegranteAlta(idAux, idAux2);

            if (resultado)
            {
                msg_Success(Util.getMsg("ConfInsert"));
                cargarLista();
            }
            else
                msg_Error(Util.getMsg("ErrorIngreso"));

            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            idAux2 = Convert.ToInt32(textBoxIntegranteID.Text.Trim());

            resultado = consultaWS.BandaIntegranteBaja(idAux2);

            if (resultado)
            {
                msg_Success(Util.getMsg("ConfDelete"));
                cargarLista();
            }
            else
                msg_Error(Util.getMsg("ErrorIngreso")); 
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
            if (num <= Util.getLastBandaId())
            {
                textBoxBuscarPorID.Text = num.ToString();
                buscarPorID();
            }
        }
    }
}
