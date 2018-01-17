using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Queue
    {
        private List<string> cont = new List<string> () ;

        public void Enqueue(string val)
        {
            cont.Add(val);
        }


        public string Dequeue()
        {
            string nash = cont[0];
            this.cont.RemoveAt(0);
            return nash;
        }


        public bool Empty
        {
            get 
            {
                return this.cont.Count == 0;
            }
        }
    }
}
