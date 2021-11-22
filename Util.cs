using oblig_csharp_2021_frontend_win.RecursosGraficos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oblig_csharp_2021_frontend_win.ServicioSoap;
using System.Text.RegularExpressions;

namespace oblig_csharp_2021_frontend_win
{
    public class Util
    {
        EntidadModo entidadModo = EntidadModo.Listar;
        public static ServicioSoap.MusicUDE_SericeSoapClient consultaWS = new ServicioSoap.MusicUDE_SericeSoapClient();


        public static String getMsg(String in_Code)
        {

            return TextosEnPantalla.ResourceManager.GetString(in_Code);

        }

        public static int getBandaIdByName(String bandaName)
        {
            int idReturn = 0;
            VOBanda[] vOBandas = consultaWS.BandaListado();
            foreach (VOBanda item in vOBandas)
            {
                if (item.Nombre.Trim().ToLower() == bandaName.Trim().ToLower())
                {
                    idReturn = item.Id;
                    break;
                }
            }
            return idReturn;
        }

        public static int getIntegranteIdByNameAndLastName(String integranteNameAndLastName)
        {
            int idReturn = 0;
            String text1 = integranteNameAndLastName.Trim().ToLower();
            String text2 = "";
            VOIntegrante[] vOIntegrantes = consultaWS.IntegrantesListado();
            foreach (VOIntegrante item in vOIntegrantes)
            {
                text2 = item.Persona.Nombre + " " + item.Persona.Apellido;
                text2 = text2.Trim().ToLower();
                if (text1 == text2)
                {
                    idReturn = item.Id;
                    break;
                }
            }
            return idReturn;
        }


        public static int getFirstBandaId()
        {
            int idReturn = 0;
            VOBanda[] vOBandas = consultaWS.BandaListado();
            foreach (VOBanda item in vOBandas)
            {
                idReturn = item.Id;
                break;
            }
            return idReturn;
        }

        public static int getLastBandaId()
        {
            int idReturn = 0;
            VOBanda[] vOBandas = consultaWS.BandaListado();
            foreach (VOBanda item in vOBandas)
            {
                idReturn = item.Id;
            }
            return idReturn;
        }

        public static int getFirstAlbumId()
        {
            int idReturn = 0;
            VOAlbum[] vOAlbums = consultaWS.AlbumListado();
            foreach (VOAlbum item in vOAlbums)
            {
                idReturn = item.Id;
                break;
            }
            return idReturn;
        }

        public static int getLastAlbumId()
        {
            int idReturn = 0;
            VOAlbum[] vOAlbums = consultaWS.AlbumListado();
            foreach (VOAlbum item in vOAlbums)
            {
                idReturn = item.Id;
            }
            return idReturn;
        }


        public static int getFirstCancionId()
        {
            int idReturn = 0;
            VOCancion[] vOCancions = consultaWS.CancionListado();
            foreach (VOCancion item in vOCancions)
            {
                idReturn = item.Id;
                break;
            }
            return idReturn;
        }

        public static int getLastCancionId()
        {
            int idReturn = 0;
            VOCancion[] vOCancions = consultaWS.CancionListado();
            foreach (VOCancion item in vOCancions)
            {
                idReturn = item.Id;
            }
            return idReturn;
        }


        public static int getFirstIntegrateId()
        {
            int idReturn = 0;
            VOIntegrante[] vOIntegrantes = consultaWS.IntegrantesListado();
            foreach (VOIntegrante item in vOIntegrantes)
            {
                idReturn = item.Id;
                break;
            }
            return idReturn;
        }

        public static int getLastIntegrateId()
        {
            int idReturn = 0;
            VOIntegrante[] vOIntegrantes = consultaWS.IntegrantesListado();
            foreach (VOIntegrante item in vOIntegrantes)
            {
                idReturn = item.Id;
            }
            return idReturn;
        }


        public static int getFirstGeneroMusicalId()
        {
            int idReturn = 0;

            VOGeneroMusical[] vOGeneroMusicals = consultaWS.GeneroMusicalListado();
            foreach (VOGeneroMusical item in vOGeneroMusicals)
            {
                idReturn = item.Id;
                break;
            }
            return idReturn;
        }

        public static int getLastGeneroMusicalId()
        {
            int idReturn = 0;
            VOGeneroMusical[] vOGeneroMusicals = consultaWS.GeneroMusicalListado();
            foreach (VOGeneroMusical item in vOGeneroMusicals)
            {
                idReturn = item.Id;
            }
            return idReturn;
        }

        public static String CapitalizeFirstLetter(String textToChange)
        {
            string strReturn = "";

            textToChange = Regex.Replace(textToChange, @"(^\w)|(\s\w)", m => m.Value.ToUpper());

            strReturn = textToChange;

            //if (textToChange.Length == 0)
            //    System.Console.WriteLine("Empty String");
            //else if (textToChange.Length == 1)
            //   strReturn = char.ToUpper(textToChange[0]).ToString();
            //else
            //strReturn = char.ToUpper(textToChange[0]).ToString() + textToChange.Substring(1).ToString();

            return strReturn;
        }


        public static void BorrarBaseDeDatos()
        {


        }

        public static void CargaInicial()
        {



        }

    }
}
