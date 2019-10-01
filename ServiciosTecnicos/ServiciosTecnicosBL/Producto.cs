using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicosBL
{
    public class Producto
    {
       public Producto()
       {
            Activo = true;
       }

        public int Id { get; set; }

        [Required(ErrorMessage ="Ingrese la descripcion")]
        [MinLength(3,ErrorMessage ="Ingrese minimo 3 carcateres")]
        [MaxLength(25,ErrorMessage ="Ingrese maximo de 20 carcateres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="Ingrese el precio")]
        [Range(0,2000,ErrorMessage ="Ïngrese un precio entre 0 y 2000")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}
