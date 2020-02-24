using System;

namespace Peliculas
{
   class Peliculas 
  {
    public string titulo;
    public Int16 año;
    public  string pais;
    public string Director;



  }


    class Program
    {
        static void Main(string[] args)
        {
           Peliculas p1= new Peliculas();


           p1.titulo=" El irlandes";
           p1.año=2019;
           p1.pais="Estados Unidos";
           p1.Director="Martin Scorsese";



            Console.WriteLine(" Pelicula 1: {0}, Año: {1}, Pais: {2}, Director: {3}",p1.titulo,p1.año,p1.pais,p1.Director);


            Peliculas p2= new Peliculas();


           p2.titulo="Joker de Joaquin Phoenix";
           p2.año=2019;
           p2.pais="Estados Unidos";
           p2.Director="Todd Phillips";



            Console.WriteLine(" Pelicula 2: {0}, Año: {1}, Pais: {2}, Director: {3}",p2.titulo,p2.año,p2.pais,p2.Director);
        }
    }
}
