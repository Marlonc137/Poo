using System;

namespace Peliculas
{
   class Peliculas //Nueva clase peliculas
  {
    // Declarar nuevas variables
    private string titulo;
    private Int16 año;
    private string pais;
    private string Director;


public void settitulo(string titulo)// Se usa este metodo cuando es privado
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

  }


    class Program
    {
        static void Main(string[] args)
        {
           Peliculas p1= new Peliculas();// Es para declarar un nueva pelicula

           p1.settitulo("El irlandes");
           p1.setaño(2019);
           p1.setpais("Estados Unidos");
           p1.setdirector("Martin Scorsese");
           Console.WriteLine(" Pelicula 1: {0}, Año: {1}, Pais: {2}, Director: {3}",p1.gettitulo(),p1.getaño(),p1.getpais(),p1.getdirector());

           //Todo esto es dominio publico
           /*p1.titulo=" El irlandes";
           p1.año=2019;
           p1.pais="Estados Unidos";
           p1.Director="Martin Scorsese";

            Console.WriteLine(" Pelicula 1: {0}, Año: {1}, Pais: {2}, Director: {3}",p1.titulo,p1.año,p1.pais,p1.Director);*/
            
            
            Peliculas p2= new Peliculas();//// Es para declarar un nueva pelicula
           p2.settitulo("Joker de Joaquin Phoenix");
           p2.setaño(2019);
           p2.setpais("Estados Unidos");
           p2.setdirector("Todd Phillips");
           Console.WriteLine(" Pelicula 1: {0}, Año: {1}, Pais: {2}, Director: {3}",p2.gettitulo(),p2.getaño(),p2.getpais(),p2.getdirector());

           /*p2.titulo="Joker de Joaquin Phoenix";
           p2.año=2019;
           p2.pais="Estados Unidos";
           p2.Director="Todd Phillips";

            Console.WriteLine(" Pelicula 2: {0}, Año: {1}, Pais: {2}, Director: {3}",p2.titulo,p2.año,p2.pais,p2.Director);*/
        }
    }
}
