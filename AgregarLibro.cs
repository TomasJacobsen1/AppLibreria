using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibreria
{
    public class AgregarLibro
    {
        public static void Agregar()
        {
            Console.WriteLine("Ingrese titulo del libro");
            string titulo = Console.ReadLine();
            
            Console.WriteLine("Ingrese Nombre del Autor ");
            string autor = Console.ReadLine();
            
            Console.WriteLine("Ingrese genero del libro");
            string genero = Console.ReadLine();
            
            Console.WriteLine("ingrese precio del libro");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("¿estan todos lo datos correctos? si/no");
            string respuesta = Console.ReadLine();

            while (respuesta != "si")
            {
                Console.WriteLine("cual es el dato incorrecto?\n1-titulo\n2-autor\n3-genero\n4-precio\n5-Todos los datos correctos");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Ingrese titulo del libro");
                        titulo = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese Nombre del Autor ");
                        autor = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese genero del libro");
                        genero = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("ingrese precio del libro");
                        precio = double.Parse(Console.ReadLine());
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Dato no encotrado");
                        continue;

                }
                Console.WriteLine("¿estan todos lo datos correctos? si/no");
                respuesta = Console.ReadLine();
            }
            
                Libro.librosList.Add(new Libro(titulo,autor,genero,precio));

        }
    }
}
