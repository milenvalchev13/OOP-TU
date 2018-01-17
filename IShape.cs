using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IShape
  
    {
        double Area();
        string Name { get; }
    }
 
    enum ShapeTypes
    {
        Circle = 1,
        Rectangle
    }
   
}


