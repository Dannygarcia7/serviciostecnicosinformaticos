using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicosBL
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese la Categoria")]
        [MinLength(3,ErrorMessage ="Ingrese un minimo de 3 caracteres")]
        [MaxLength(25,ErrorMessage ="Ingrese un maximo de 25 caracteres")]
        public string Descripcion { get; set; }
    }
}
