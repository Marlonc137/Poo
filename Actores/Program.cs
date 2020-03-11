using System;

namespace Actores
{

class peliculas
{
  private string titulo;
  private Int16 año;
  private string pais;
  private string Director;


  public void settitulo(string titulo)
{
    this.titulo= titulo;
}

public string gettitulo()
{
    return this.titulo;
}

  public void setaño(Int16 año)
    {
      this.año= año;
    }
    
    public Int16 getaño()
    {
      return this.año;
    }

public void setpais(string pais)
{
  this.pais=pais;
}

public string getpais()
{
  return this.pais;
}

public void setdirector(string Director)
{
  this.Director=Director;
}
 
public string getdirector()
{
  return this.Director;
}

public peliculas(string titulo, Int16 año, string pais, string Director)//constructor 1
{
 this.titulo=titulo;
 this.año=año;
 this.pais=pais;
 this.Director=Director;

}
 public peliculas()// constructor 2
 {

 }



  }



    class Program
    {


        static void Main(string[] args)
        {
            peliculas p1= new peliculas();

            /*p1.titulo=("el joker");
            p1.año=(2019);
            p1.pais=("Estados unidos");
            p1.director=("Todd Phillips");

            Console.WriteLine("La pelicula es: "+p1.titulo);
            Console.WriteLine("El año es: "+ p1.año);
            Console.WriteLine("El pais es:"+p1.pais);
            Console.WriteLine("El director es: " +p1.director);*/

            p1.settitulo("El irlandes");
           p1.setaño(2019);
           p1.setpais("Estados Unidos");
           p1.setdirector("Martin Scorsese");
           Console.WriteLine(" Pelicula 1: {0}, Año: {1}, Pais: {2}, Director: {3}",p1.gettitulo(),p1.getaño(),p1.getpais(),p1.getdirector());

           peliculas p2= new peliculas();//// Es para declarar un nueva pelicula
           p2.settitulo("Joker de Joaquin Phoenix");
           p2.setaño(2019);
           p2.setpais("Estados Unidos");
           p2.setdirector("Todd Phillips");
           Console.WriteLine(" Pelicula 1: {0}, Año: {1}, Pais: {2}, Director: {3}",p2.gettitulo(),p2.getaño(),p2.getpais(),p2.getdirector());






        }
    }
}
