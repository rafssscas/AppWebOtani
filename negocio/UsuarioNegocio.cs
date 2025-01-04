using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class UsuarioNegocio
    {
        private static UsuarioNegocio instancia = null;
        public UsuarioNegocio()
        {
        }
        public static UsuarioNegocio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new UsuarioNegocio();
                }
                return instancia;
            }
        }

        public int resetear()
        {
            int respuesta = 0;
           

            return respuesta;
        }


        public List<Usuario> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Usuario> oLista = new List<Usuario>();

           
            return oLista;
        }

        public int Existe(string usuario, int defaultid, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
           
            return respuesta;
        }

        public int Guardar(Usuario objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

           

            return respuesta;
        }

        public int Editar(Usuario objeto, out string mensaje)
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
