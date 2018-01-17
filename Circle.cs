using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public string Name
        {
            get { return "Кръг"; }
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public static int TypeDescriptor
        {
            get
            { return (int)ShapeTypes.Circle; }
        }



        public byte[] Serialize()
        {
            var result = new List<byte>();
            result.AddRange(
                BitConverter.GetBytes(TypeDescriptor));
            result.AddRange(
                BitConverter.GetBytes(radius));

            return result.ToArray();
        }

        public class Deserializer : IDeserializer
        {
            public int ForTypeDescriptor
            { get { return Circle.TypeDescriptor; } }

            public ISerializable Deserialize(byte[] from,
                                    ref int readIndex)
            {
                var r = BitConverter.ToDouble(from, readIndex);
                readIndex += sizeof(double);

                return new Circle(r);
            }
        }
    }
}
