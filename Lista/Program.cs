using System;
using System.Collections.Generic;
namespace Lista
{
  class peliculas
  {
      public string titulo;
      public void final()
      {
              Console.WriteLine("({0})",titulo);
      }

      public peliculas(string t) 
      {
          titulo=t;
      }
  }



    class Program
    {
        static void Main(string[] args)
        {
            List<peliculas> Lista = new List<peliculas>();
            Lista.Add(new peliculas("El Rey Leon"));
            Lista.Add(new peliculas("Ipman"));
            Lista.Add(new peliculas("Bad Boys"));
            Lista.Add(new peliculas("Joker"));
            Lista.Add(new peliculas("Sonic"));

            foreach(peliculas t in Lista)
            t.final();


        }
    }
}
