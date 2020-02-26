using System;
using System.Collections.Generic;
namespace Lista
{
    class Program
    {
        static void Main()
        {
            List<String> Lista = new List<String>();
            Lista.add("El Rey Leon");
            Lista.add("Ipman");
            Lista.add("Bad Boys");
            Lista.add("Joker");
            Lista.add("Sonic");

            foreach(string Pelicula in Lista)
            Console.WriteLine(Pelicula);


        }
    }
}
