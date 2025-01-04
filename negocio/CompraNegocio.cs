using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CompraNegocio
    {
        private static CompraNegocio instancia = null;
        public CompraNegocio()
        {
        }

        public static CompraNegocio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CompraNegocio();
                }
                return instancia;
            }
        }

        public int Existe(string numerodocumento, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            return respuesta;


        }

        public int ObtenerCorrelativo(out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            return respuesta;
        }

        public int Registrar(Compra obj, out string mensaje)
        {

            mensaje = string.Empty;
            int respuesta = 0;
            return respuesta;
        }


        public List<VistaCompra> Resumen(string fechainicio = "", string fechafin = "")
        {
            List<VistaCompra> oLista = new List<VistaCompra>();
            return oLista;
        }

        public Compra Obtener(string numerodocumento)
        {
            Compra objeto = null;
            return objeto;
        }


        public List<DetalleCompra> ListarDetalle(int idCompra)
        {
            List<DetalleCompra> oLista = new List<DetalleCompra>();
            return oLista;
        }

        public int cancelar_Compra(int id, List<DetalleCompra> odetalle, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            return respuesta;
        }
    }
}
