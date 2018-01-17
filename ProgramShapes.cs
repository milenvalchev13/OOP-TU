using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            public List<double> Shapes = new List<double>();

        int selection = 0;
            do
            {


                Console.WriteLine("1. Add Circle ");
                Console.WriteLine("2. Add Rectangle");
                Console.WriteLine("3. Print Areas");
                Console.WriteLine("0. Exit");
                selection = int.Parse(Console.ReadLine());

                switch (selection)
                  {
                    case 1 : 
                       Console.Write("R=");
                       double r = double.Parse(Console.ReadLine());
                       Shape.Add( new Circle(r));
                       break;
                    case 2 :
                       Console.Write("Ширина=");
                       double w = double.Parse(Console.ReadLine());
                       Console.Write("Височина=");
                       double h = double.Parse(Console.ReadLine());
                       Shape.Add( new Rectangle(w,h));
                       break;
                    case 3 :
                       int i = 1;
                    foreach (var Shape in Shapes)
                        Console.WriteLine("{0}: {2} с площ = {1}",
                            i++, Shape.Area(), Shape.Name);
                    break;
                    case 0 : break ;
                  }
            }   
            while (selection == 0);
        }
    }
}
