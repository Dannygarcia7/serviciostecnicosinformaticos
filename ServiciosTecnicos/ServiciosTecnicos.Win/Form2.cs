using ServiciosTecnicosBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiciosTecnicos.Win
{
    
    public partial class Form2 : Form
    {
        ReporteVentaPorProductoBL _reporteVentaPorProductoBL;

        public Form2()
        {
            InitializeComponent();
            _reporteVentaPorProductoBL = new ReporteVentaPorProductoBL();

            ActualizarDatos();//Este metodo lo llamamos aqui en el constructor paa que de entrada
                                //inicie los datos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            var listadeVentasPorProducto = _reporteVentaPorProductoBL.ObtenerVentasPorProducto();
            listadeVentasPorProductoBindingSource.DataSource = listadeVentasPorProducto;
            listadeVentasPorProductoBindingSource.ResetBindings(false);//CADA VEZ QUE SE PRESIONA EL BOTON BORRARA DATOS VIEJOS Y COLOCARA LOS NUEVOS

        }
    }
}
