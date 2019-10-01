using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicosBL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var NuevoUsuario = new Usuario();
            NuevoUsuario.Nombre = "admin";
            NuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

           
            

            contexto.Usuarios.Add(NuevoUsuario);
            

            base.Seed(contexto); 
        }
    }
}
