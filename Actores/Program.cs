using System;

namespace Actores
{

class peliculas
{
  public string titulo;
  public Int16 año;
  public string pais;
  public string director;

}
    class Program
    {


        static void Main(string[] args)
        {
            peliculas p1= new peliculas();

            p1.titulo=("el joker");
            p1.año=(2019);
            p1.pais=("Estados unidos");
            p1.director=("Todd Phillips");

            Console.WriteLine("La pelicula es: "+p1.titulo);
            Console.WriteLine("El año es: "+ p1.año);
            Console.WriteLine("El pais es:"+p1.pais);
            Console.WriteLine("El director es: " +p1.director);

        }
    }
}
