using oblig_csharp_2021_frontend_win.ServicioSoap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig_csharp_2021_frontend_win.ServiciosWebs
{
    class WebServiceStub
    {
        ServicioSoap.MusicUDE_SericeSoapClient llamada = new ServicioSoap.MusicUDE_SericeSoapClient();

       public void otro(int inTexto)
        {
            VOBanda voBandaWS = llamada.BandaObtener(inTexto);

            //ws.BandaAlta

        }


        //int anio creacion, int fechaseparacion, string genero, VoIntegrantes[] integrantes, string nombre
        public VOBanda BandaObtener(int inbanda) 
        {
             VOBanda voBandaWS = llamada.BandaObtener(inbanda);
             return voBandaWS;
        }
        //int anio creacion, int fechaseparacion, string genero, VoIntegrantes[] integrantes, string nombre
        public bool BandaAlta(string nombre, int anioCreacion, int anioSeparacion, string genero)
        {
            VOBanda vo = new VOBanda
            {
                Nombre = nombre,
                AnioCreacion = anioCreacion,
                AnioSeparacion = anioSeparacion,
                Genero = genero
            };
            return llamada.BandaAlta(vo);
            
        }
        public bool BajaBanda(int in_nombreBanda)
        {
            return llamada.BandaBaja(in_nombreBanda);

        }

        public bool BandaModificar(string nombre, int anioCreacion, int anioSeparacion, string genero )
        {
            VOBanda vo = new VOBanda
            {
                Nombre = nombre,
                AnioCreacion = anioCreacion,
                AnioSeparacion = anioSeparacion,
                Genero = genero
            };
            return llamada.BandaModificar(vo);

        }
        public VOBanda[] BandaListado()
        {
            VOBanda[] vOBandas = llamada.BandaListado();
            return vOBandas;
        }






    }


}



