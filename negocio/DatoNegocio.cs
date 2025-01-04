using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class DatoNegocio
    {

        private static DatoNegocio instancia = null;
        public DatoNegocio()
        {
        }
        public static DatoNegocio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new DatoNegocio();
                }
                return instancia;
            }
        }

        public Datos Obtener()
        {
            Datos obj = new Datos();
            return obj;
        }


        public int Guardar(Datos objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            return respuesta;
        }

        public int ActualizarLogo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

               
            return respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] obj = new byte[0];
            return obj;
        }
    }
}
