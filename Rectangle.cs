using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Rectangle : IShape
    {
        private double width, height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public string Name
        {
            get { return "Правоъгълник"; }
        }

        public static int TypeDescriptor
        { get { return (int)ShapeTypes.Rectangle; } }

        public double Area()
        {
            return width * height;
        }

        public byte[] Serialize()
        {
            var result = new List<byte>();
            result.AddRange(
                BitConverter.GetBytes(TypeDescriptor));
            result.AddRange(
                BitConverter.GetBytes(width));
            result.AddRange(
                BitConverter.GetBytes(height));

            return result.ToArray();
        }

        public class Deserializer : IDeserializer
        {
            public int ForTypeDescriptor
            { get { return TypeDescriptor; } }

            public ISerializable Deserialize(byte[] from,
                                    ref int readIndex)
            {
                var w = BitConverter.ToDouble(from, readIndex);
                readIndex += sizeof(double);
                var h = BitConverter.ToDouble(from, readIndex);
                readIndex += sizeof(double);

                return new Rectangle(w, h);
            }
        }
    }
}

