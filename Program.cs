using System;
using System.Collections.Generic;

namespace AppLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                {
                int accion;
                while (true)
                {
                    Console.WriteLine("Elija una accion\n1-Agregar un libro a la lista\n2-Buscar un libro");
                    try
                    {
                         accion = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Accion no encontrada");
                    }
                }
                switch (accion)
                {
                    case 1:
                        AgregarLibro.Agregar();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese titulo de libro o autor");
                        string busqueda = Console.ReadLine();
                        List<Libro> query = BuscarLibro.Busqueda(busqueda, Libro.librosList);
                        int i = 0;
                        foreach (var libro in query)
                        {
                            if (busqueda == "") break;
                            i = 1;
                            Console.WriteLine("\nTitulo: {0},\nAutor: {1},\nGenero: {2},\nPrecio: ${3}\n", libro.Titulo, libro.Autor, libro.Genero, libro.Precio);
                        }
                        if (i == 0)  Console.WriteLine("\nNo se encontro tu libro\n");                      
                        break;

                } 
            }
        }
       
    }
}