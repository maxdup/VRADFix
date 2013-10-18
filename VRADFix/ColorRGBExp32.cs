using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VRADFix
{
    //this class stores the data for a single luxel
    class ColorRGBExp32
    {
        public byte r, g, b, e;

        public ColorRGBExp32(BinaryReader reader)
            //constructor, pulls the data from the binaryReader
            //BinaryReader MUST be at the correct offset
        {
            r = reader.ReadByte();
            g = reader.ReadByte();
            b = reader.ReadByte();
            e = reader.ReadByte();
        }

        public void updateLuxel(string[] value, char[] mode)
            //reads the textbox and updates values
        {
            for (int i = 0; i < mode.Length; i++)
            {
                switch (mode[i])
                {
                    case 'r':
                        r = byte.Parse(value[i]);
                        break;
                    case 'g':
                        g = byte.Parse(value[i]);
                        break;
                    case 'b':
                        b = byte.Parse(value[i]);
                        break;
                    case 'e':
                        e = byte.Parse(value[i]);
                        break;
                }
            }
        }
        
        public void writeLuxel(BinaryWriter writer)
            //writes the luxel in the binary writer
            //BinaryWriter MUST be at the correct position
        {
            writer.Write(r);
            writer.Write(g);
            writer.Write(b);
            writer.Write(e);
        }

        public void randomRGB(Random rand)
            //randomizes data
        {
            r = (byte)(rand.Next(0, 2) * 255);
            g = (byte)(rand.Next(0, 2) * 255);
            b = (byte)(rand.Next(0, 2) * 255);
        }
    }
}
