using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ProveedorNegocio
    {

        private static ProveedorNegocio instancia = null;
        public ProveedorNegocio()
        {
        }
        public static ProveedorNegocio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ProveedorNegocio();
                }
                return instancia;
            }
        }

        public List<Proveedor> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Proveedor> oLista = new List<Proveedor>();

           
            return oLista;
        }

        public int Existe(string numero, int defaultid, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            
            return respuesta;
        }

        public int Guardar(Proveedor objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

          
            return respuesta;
        }

        public int Editar(Proveedor objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

          

            return respuesta;
        }


        public int Eliminar(int id)
        {
            int respuesta = 0;
           
            return respuesta;
        }


    }
}
