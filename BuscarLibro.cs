using System;
using System.Collections.Generic;
using System.Linq;

namespace AppLibreria
{
    public class BuscarLibro 
    {
        
        public static List<Libro> Busqueda(string busqueda, List<Libro> libros)
        {
            var query = from libro in libros
                        where libro.Autor.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0 || libro.Titulo.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0
                        select libro;
            List<Libro> librosList = new List<Libro>();
            foreach (var libro in query)
            {
                librosList.Add(libro);
            }
            return librosList;
        }
    }
}