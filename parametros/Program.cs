using System;

namespace parametros
{

/*
class Persona 
{
    public string nombre;
    public string apellido;

    public Persona()
    {
        nombre= 'Pancho';
        apellido= 'Lopez';
    }
}

class formato
{
    static public void nuevo1( Persona p)
    {
        p.nombre = 'xxxxxxxxx';
		p.apellido = 'xxxxxxxxx';
    }
    static void Main()
    {
        Persona nuevo = new Persona();

		Console.WriteLine(nuevo.nombre);
		nuevo1(nuevo);
		Console.WriteLine(nuevo.nombre);
    }
}
*/
class Duplicador
{

	public void duplica(int n) 
    { 
			n = n*2;
	}

	public void duplica_ref(ref int n)
     { 
			n = n*2;
	 }

	/*public void duplica(in int n) 
    { 
			n = n*2;
	}
    */



}

    class Program
    {
        static void Main(string[] args)
        {
            Duplicador d = new Duplicador();
		int x = 2;
		d.duplica(x);
		Console.WriteLine(x);

		d.duplica_ref(ref x);
		Console.WriteLine(x);

       /* d.duplica( in x); 
		Console.WriteLine(x);*/
        }
    }
}
