using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTesting20212
{
    public class CarritoDeLibros
    {
        private List<Libro> libros;

        public CarritoDeLibros(List<Libro> libros)
        {
            this.libros = libros;
        }

        public void AddLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void QuitarLibro(Libro libro)
        {
            libros.Remove(libro);
        }

        public decimal PrecioTotal()
        {
            if(libros.Any())
                return libros.Sum(o => o.Price);
            return 0;
        }

        public void Comprar()
        {
            //guardar en base de datos;
        }
    }
}
