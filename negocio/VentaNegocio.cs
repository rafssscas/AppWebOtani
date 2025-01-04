using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class VentaNegocio
    {

        private static VentaNegocio instancia = null;
        public VentaNegocio()
        {
        }
        public static VentaNegocio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new VentaNegocio();
                }
                return instancia;
            }
        }

        public int reducirStock(int idproducto, int cantidad, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
           

            return respuesta;
        }

        public int aumentarStock(int idproducto, int cantidad, out string mensaje)
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


        public int Registrar(Venta obj, out string mensaje)
        {

            mensaje = string.Empty;
            int respuesta = 0;
          

            return respuesta;
        }

        public List<VistaVenta> Resumen(string fechainicio = "", string fechafin = "")
        {
            List<VistaVenta> oLista = new List<VistaVenta>();
          
            return oLista;
        }


        public Venta Obtener(string numerodocumento)
        {
            Venta objeto = null;

           
            return objeto;
        }

        public List<DetalleVenta> ListarDetalle(int idVenta)
        {
            List<DetalleVenta> oLista = new List<DetalleVenta>();

          


            return oLista;
        }
        public int cancelar_Venta(int id, List<DetalleVenta> odetalle, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
          

            return respuesta;
        }


    }
}
