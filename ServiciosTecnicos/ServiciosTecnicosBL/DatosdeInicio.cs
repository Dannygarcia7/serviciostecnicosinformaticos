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

            var NuevoUsuario2 = new Usuario();
            NuevoUsuario2.Nombre = "Cynthia";
            NuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("147");

            var NuevoUsuario3 = new Usuario();
            NuevoUsuario3.Nombre = "Joselyn";
            NuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("456");
            var NuevoUsuario4 = new Usuario();
            NuevoUsuario4.Nombre = "Daniel";
            NuevoUsuario4.Contrasena = Encriptar.CodificarContrasena("789");

            contexto.Usuarios.Add(NuevoUsuario);

            contexto.Usuarios.Add(NuevoUsuario2);
            contexto.Usuarios.Add(NuevoUsuario3);
            contexto.Usuarios.Add(NuevoUsuario4);

            

            base.Seed(contexto); 
        }
    }
}
