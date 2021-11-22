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

namespace oblig_csharp_2021_frontend_win.Integrante
{
    public partial class IntegranteListar : Form
    {
        EntidadModo entidadModo = EntidadModo.Listar;
        ServicioSoap.MusicUDE_SericeSoapClient consultaWS = new ServicioSoap.MusicUDE_SericeSoapClient();

        int personaID_Aux;
        public IntegranteListar()
        {
            InitializeComponent();
        }


        private void CargarLista_Load(object sender, EventArgs e)
        {
            cargarLista();
            textBoxBuscarPorID.Text = Util.getFirstIntegrateId().ToString();
            buscarPorID();
        }

        private void buttonRefrescarLista_Click(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            String temp = textBoxAtt4.Text;
            cargarComboBoxBanda();
            textBoxAtt4.Text = temp; 
            
            listView.Clear();
            msg_Info(Util.getMsg("Recargando"));
            Thread.Sleep(1000);
            //Task.Delay(1000);


            ////DEFINIR FORMATO DE LINEAS AL LIST VIEW
            //listView.View = View.Details;
            //listView.GridLines = true;
            //listView.FullRowSelect = true;

            ////ASIGNAR COLUMNAS, RESPECTIVOS NOMBRES Y TAMAÑOS DE RENGLÓN
            listView.Columns.Add(Util.getMsg("IntegranteID"), 80); 
            listView.Columns.Add(Util.getMsg("Nombre"), 150);
            listView.Columns.Add(Util.getMsg("Apellido"), 150);
            listView.Columns.Add(Util.getMsg("FechaNacimiento"), 150);
            listView.Columns.Add(Util.getMsg("BandaIDIntegrante"), 150);
            listView.Columns.Add(Util.getMsg("DatoIntegrante"), 150);
            listView.Columns.Add(Util.getMsg("PersonaID"), 70);

            String[] elementosFila = new string[7];
            ListViewItem elementoListViewROW;

            VOIntegrante[] vOIntegrantes = consultaWS.IntegrantesListado();

            foreach (VOIntegrante item in vOIntegrantes)
            {
                elementosFila[0] = item.Id.ToString(); 
                elementosFila[1] = item.Persona.Apellido;
                elementosFila[2] = item.Persona.Nombre.ToString();
                elementosFila[3] = item.FechaNacimiento.ToShortDateString();
                VOBanda vOBanda = consultaWS.BandaObtener(item.BandaId);
                elementosFila[4] = vOBanda.Nombre.ToString() + " - ( Id: " + item.BandaId.ToString() + " )";
                elementosFila[5] = item.Foto;
                elementosFila[6] = item.Persona.Id.ToString();

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
                VOIntegrante[] vOIntegrantes = consultaWS.IntegrantesListado();

                foreach (VOIntegrante item in vOIntegrantes)
                {
                    if (item.Id.ToString() == textBoxBuscarPorID.Text.Trim())
                    {
                        personaID_Aux    = item.Persona.Id;
                        textBoxAtt1.Text = item.Persona.Nombre.ToString();
                        textBoxAtt2.Text = item.Persona.Apellido;
                        textBoxAtt3.Text = item.FechaNacimiento.ToShortDateString();
                        VOBanda vOBanda = consultaWS.BandaObtener(item.BandaId);
                        textBoxAtt4.Text = vOBanda.Nombre;
                        textBoxAtt5.Text = item.Foto;
                        pictureBoxData.ImageLocation = item.Foto.ToString();

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

                    textBoxAtt1.Visible = true;
                    textBoxAtt2.Visible = true;
                    textBoxAtt3.Visible = true;
                    textBoxAtt4.Visible = true;
                    textBoxAtt5.Visible = true;
                    pictureBoxData.Visible = true;

                    textBoxAtt1.Enabled = false;
                    textBoxAtt2.Enabled = false;
                    textBoxAtt3.Enabled = false;
                    textBoxAtt4.Enabled = false;
                    textBoxAtt5.Enabled = false;
                    pictureBoxData.Enabled = false;

                    msg_Success(Util.getMsg("DatosRecIntegranteOk") + textBoxBuscarPorID.Text.Trim());
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

                    textBoxAtt1.Visible = false;
                    textBoxAtt2.Visible = false;
                    textBoxAtt3.Visible = false;
                    textBoxAtt4.Visible = false;
                    textBoxAtt5.Visible = false;
                    pictureBoxData.Visible = false;

                    textBoxAtt1.Text = "";
                    textBoxAtt2.Text = "";
                    textBoxAtt3.Text = "";
                    textBoxAtt4.Text = "";
                    textBoxAtt5.Text = "";

                    textBoxAtt1.Enabled = false;
                    textBoxAtt2.Enabled = false;
                    textBoxAtt3.Enabled = false;
                    textBoxAtt4.Enabled = false;
                    textBoxAtt5.Enabled = false;
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

            textBoxAtt1.Visible = true;
            textBoxAtt2.Visible = true;
            textBoxAtt3.Visible = true;
            textBoxAtt4.Visible = true;
            textBoxAtt5.Visible = true;
            pictureBoxData.Visible = true;

            textBoxAtt1.Enabled = true;
            textBoxAtt2.Enabled = true;
            textBoxAtt3.Enabled = true;
            textBoxAtt4.Enabled = true;
            textBoxAtt5.Enabled = true;
            pictureBoxData.Enabled = true;

            pictureBoxData.ImageLocation = "https://cdn.salla.sa/OD0vGJs8njhThdiW5KgmgPcP8yAsWBn95nRrDOrn.png";

            msg_Info(Util.getMsg("ConfirmarIngresoIntegrante"));


        }


        private void buttonModificar_Click(object sender, EventArgs e)
        {
            entidadModo = EntidadModo.Modificar;

            textBoxAtt1.Enabled = true;
            textBoxAtt2.Enabled = true;
            textBoxAtt3.Enabled = true;
            textBoxAtt4.Enabled = true;
            textBoxAtt5.Enabled = true;
            pictureBoxData.Enabled = true;

            buttonConfirmar.Visible = true;
            buttonConfirmar.Text = Util.getMsg("ConfModif");

            msg_Info(Util.getMsg("PuedeModificarIntegrante") + textBoxBuscarPorID.Text.Trim());
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
            VOIntegrante voIntegrante; 
            
            switch (entidadModo)
            {
                case EntidadModo.Listar:

                    break;
                case EntidadModo.Insertar:

                    voIntegrante                    = new VOIntegrante();
                    voIntegrante.Persona            = new VOPersona();
                    //voIntegrante.Persona.Id       = personaID_Aux;
                    voIntegrante.Persona.Nombre     = textBoxAtt1.Text.ToString().Trim();
                    voIntegrante.Persona.Apellido   = textBoxAtt2.Text.ToString().Trim();
                    //voIntegrante.Id = 
                    voIntegrante.FechaNacimiento    = Convert.ToDateTime(textBoxAtt3.Text.Trim());
                    voIntegrante.BandaId = Util.getBandaIdByName(textBoxAtt4.Text);

                    voIntegrante.Foto               = textBoxAtt5.Text.Trim();

                    resultado = consultaWS.IntegranteAlta(voIntegrante);

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

                    voIntegrante = new VOIntegrante();
                    voIntegrante.Persona = new VOPersona();
                    voIntegrante.Persona.Id = personaID_Aux;
                    voIntegrante.Persona.Nombre = textBoxAtt1.Text.Trim();
                    voIntegrante.Persona.Apellido = textBoxAtt2.Text.Trim();
                    voIntegrante.Id = idAux;
                    voIntegrante.FechaNacimiento = Convert.ToDateTime(textBoxAtt3.Text.Trim());
                    voIntegrante.BandaId = Util.getBandaIdByName(textBoxAtt4.Text);
                    voIntegrante.Foto = textBoxAtt5.Text.Trim();

                    resultado = consultaWS.IntegranteModificacion(voIntegrante);

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
                    resultado = consultaWS.IntegranteBaja(idAux);
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

        private void textBoxAtt5_TextChanged(object sender, EventArgs e)
        {
            pictureBoxData.ImageLocation = textBoxAtt5.Text.ToString().Trim();
        }


        public void cargarComboBoxBanda()
        {
            textBoxAtt4.Items.Clear();
            VOBanda[] vOBandas = consultaWS.BandaListado();
            foreach (VOBanda item in vOBandas)
            {
                textBoxAtt4.Items.Add(item.Nombre);
            }
            textBoxAtt4.Sorted = true;

            foreach (String item in textBoxAtt4.Items)
            {
                textBoxAtt4.Text = item;
                break;
            }
        }


        private void buttonPageFirst_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getFirstIntegrateId().ToString();
            buscarPorID();
        }

        private void buttonPageLast_Click(object sender, EventArgs e)
        {
            textBoxBuscarPorID.Text = Util.getLastIntegrateId().ToString();
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
            if (num <= Util.getLastIntegrateId())
            {
                textBoxBuscarPorID.Text = num.ToString();
                buscarPorID();
            }
        }
    }
}
