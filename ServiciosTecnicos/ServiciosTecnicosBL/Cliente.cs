using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicosBL
{
   public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        [MinLength(6, ErrorMessage = "Ingrese mínimo 6 caracteres")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "Ingrese el telefono")]
        [MinLength(8, ErrorMessage = "El telefono debe ser de 8 digitos incluyendo guiones")]
        [MaxLength(12, ErrorMessage = "El telefono debe ser de 12 digitos")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese la direccion")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
