using System;

namespace Class 
{
class Pelicula
{
    private string  titulo;
    private Int16 año;
    private string pais;
    private string director;


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
        this.año=año;
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
public void setdirector(string director)
    {
        this.director=director;
    }
    
    public string getdirector()
    {
        return this.director;
    }
    
public Pelicula(string titulo, Int16 año, string pais, string director)
{
    this.titulo=titulo;
    this.año=año;
    this.pais=pais;
    this.director=director;
}

public Pelicula()
        {

        }

 

}

class Program
    {
        static void Main(string[] args)
        {
          Pelicula Numero1 = new Pelicula();

          Numero1.settitulo("El irlandes");
          Numero1.setaño(2019);
          Numero1.setpais("Estados Unidos");
          Numero1.setdirector("Martin Scorsese");

          Console.WriteLine("Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}", Numero1.gettitulo(), Numero1.getaño(), Numero1.getpais(), Numero1.getdirector());


         
         /* Numero1.titulo="El irlandés";
          Numero1.año=2019;
          Numero1.pais="Estados Unidos";
          Numero1.director="Martin Scorsese";
          

          Console.WriteLine(" Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}",Numero1.titulo,Numero1.año,Numero1.pais,Numero1.director);
           */
           
        }

        

    }

    
}