using System.Collections.Generic;

namespace AppLibreria
{
    public class Libro
    {
        public static List<Libro> librosList = new List<Libro>() {
                new Libro( "harry poter y la piedra filosofal", "JK Rowling", "fantasia", 1399 ) ,
                new Libro("1984", "George Orwell", "Ciencia ficcion", 800),
                new Libro("Yo robot","Isaac Asimov","Ciencia ficcion",1000),
                new Libro("El señor de los anillos","JRR tolkien","fantasia",3000)
        };

        public string Titulo;
        public string Autor;
        public string Genero;
        public double Precio;

        

        public Libro(string titulo, string autor, string genero, double precio)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Precio = precio;            
        }

    }
}