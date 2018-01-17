using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

   

{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            string nov = Console.ReadLine();

            while (nov != " ")
            {
                q.Enqueue(nov);
                nov = Console.ReadLine();
            }

            while (!q.Empty)
            {
                Console.WriteLine(q.Dequeue());
            }

            nov = Console.ReadLine();
        }
    }
}
