using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicosBL
{
    public class CategoriasBL
    {
        Contexto _contexto;
        public List<Categoria> Listadecategorias { get; set; }

        public CategoriasBL()
        {
            _contexto = new Contexto();
            Listadecategorias = new List<Categoria>();
        }

        public List<Categoria> ObtenerCategorias()
        {
            Listadecategorias = _contexto.Categorias.ToList();
            return Listadecategorias;
        }

        public void GuargarCategorias(Categoria categoria)
        {
            if(categoria.Id == 0)
            {
                _contexto.Categorias.Add(categoria);
            } else
            {
                var categoriaExistente = _contexto.Categorias.Find(categoria.Id);
                categoriaExistente.Descripcion = categoria.Descripcion;
            }

            _contexto.SaveChanges();
        }

        public Categoria ObtenerCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);

            return categoria;
        }

        public void EliminarCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();
        }
    }
}
