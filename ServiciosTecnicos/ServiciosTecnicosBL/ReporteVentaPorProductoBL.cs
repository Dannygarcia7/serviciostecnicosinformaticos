using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicosBL
{
    public class ReporteVentaPorProductoBL
    {
        Contexto _contexto;
        public List<ReporteVentaPorProducto> ListadeVentasPorProducto { get; set; }

        public ReporteVentaPorProductoBL()
        {
            _contexto = new Contexto();
            ListadeVentasPorProducto = new List<ReporteVentaPorProducto>();
        }

        public List<ReporteVentaPorProducto> ObtenerVentasPorProducto() //LinQ para hacer reportes
        {
            ListadeVentasPorProducto = _contexto.OrdenDetalle
                .Include("Producto")//Trae los productos
                .Where(r => r.Orden.Activo)//solo filtra ordenes activas
                .GroupBy(r => r.Producto.Descripcion)//Agrupa por descripcion
                .Select(r => new ReporteVentaPorProducto()
                {
                    Producto = r.Key,//Agrupacion se convierte en una llave
                    Cantidad = r.Sum(s => s.Cantidad),//Suma cantidad
                    Total = r.Sum(s => s.Total)//Suma total
                }).ToList();

            return ListadeVentasPorProducto;
        }
    }
}
