using System;

namespace Class 
{
class Pelicula
{
    public string  titulo;
    public Int16 año;
    public string pais;
    public string director;
}

class Program
    {
        static void Main(string[] args)
        {
          Pelicula Numero1 = new Pelicula();
          Numero1.titulo="El irlandés";
          Numero1.año=2019;
          Numero1.pais="Estados Unidos";
          Numero1.director="Martin Scorsese";

          Console.WriteLine(" Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}",Numero1.titulo,Numero1.año,Numero1.pais,Numero1.director);
           
           
        }

        

    }

    
}