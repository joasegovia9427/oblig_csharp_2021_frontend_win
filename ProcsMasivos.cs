using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oblig_csharp_2021_frontend_win.ServicioSoap;

namespace oblig_csharp_2021_frontend_win
{
    public partial class ProcsMasivos : Form
    {
        EntidadModo entidadModo = EntidadModo.Listar;
        ServicioSoap.MusicUDE_SericeSoapClient consultaWS = new ServicioSoap.MusicUDE_SericeSoapClient();


        public ProcsMasivos()
        {
            InitializeComponent();
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


        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            entidadModo = EntidadModo.Insertar;
            buttonConfirmar.Visible = true;
            buttonConfirmar.Text = Util.getMsg("ConfirmarInicializar");
            msg_Info(Util.getMsg("ConfirmarInicializar"));
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            entidadModo = EntidadModo.Eliminar; 
            buttonConfirmar.Visible = true;
            buttonConfirmar.Text = Util.getMsg("ConfirmarLimpieza");
            msg_Warning(Util.getMsg("ConfirmarLimpieza"));
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            int idAux;
            bool resultado;

            switch (entidadModo)
            {
                case EntidadModo.Insertar:

                    //resultado = consultaWS.BandaAlta(voBanadaNueva);

                    //if (resultado)
                    //{
                    msg_Success(Util.getMsg("ConfInicializar"));
                    buttonConfirmar.Visible = false;
                    //}
                    //else
                    //    msg_Error(Util.getMsg("ErrorProcedimiento"));

                    break;
                case EntidadModo.Eliminar:
                    //idAux = Convert.ToInt32(textBoxBuscarPorID.Text.Trim());
                    //resultado = consultaWS.BandaBaja(idAux);
                    //if (resultado)
                    //{
                    msg_Success(Util.getMsg("ConfLimpieza"));
                    buttonConfirmar.Visible = false;
                    //}
                    //else
                    //    msg_Error(Util.getMsg("ErrorProcedimiento"));
                    break;
                default:
                    break;
            }

            
        }

    }
}
