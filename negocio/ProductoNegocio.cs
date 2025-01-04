using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ProductoNegocio
    {
        private static ProductoNegocio instancia = null;
        public ProductoNegocio()
        {
        }
        public static ProductoNegocio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ProductoNegocio();
                }
                return instancia;
            }
        }

        public List<Producto> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Producto> oLista = new List<Producto>();

           

            return oLista;
        }

        public int Existe(string codigo, int defaultid, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            
            return respuesta;
        }

        public int Guardar(Producto objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

           

            return respuesta;
        }

        public int Editar(Producto objeto, out string mensaje)
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
