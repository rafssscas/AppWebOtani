using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class PermisosNegocio
    {
        private static PermisosNegocio instancia = null;
        public PermisosNegocio()
        {
        }
        public static PermisosNegocio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new PermisosNegocio();
                }
                return instancia;
            }
        }

        public Permisos Obtener(int idpermisos)
        {
            Permisos obj = new Permisos();
           
            return obj;
        }

        public int Guardar(Permisos objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
          

            return respuesta;
        }

    }
}
