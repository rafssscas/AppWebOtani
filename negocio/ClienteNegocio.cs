using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ClienteNegocio
    {
        private static ClienteNegocio instancia = null;
        public ClienteNegocio()
        {

        }

        public static ClienteNegocio Instancia
        {
            get
            {
                if (instancia == null) 
                {
                    instancia = new ClienteNegocio();
                }
                return instancia;
            }
        }

        public List<Cliente> Listar(out string mensaje)
        {
            mensaje = "";
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                clientes = Cliente.Listar();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return clientes;
        }

        public int Existe(string numero, int defaultid, out string mensaje)
        {

            mensaje = string.Empty;
            int respuesta = 0;

            return respuesta;
        }

        public int Guardar(Cliente objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            return respuesta;

        }

        public int Editar(Cliente objeto, out string mensaje)
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
