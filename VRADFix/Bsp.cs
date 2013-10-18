﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

namespace VRADFix
{
    // this is the class that stores data about the bsp.
    // if you don't understand what's going on here, might need to do some reading 
    // https://developer.valvesoftware.com/wiki/Source_BSP_File_Format#BSP_file_header
    class Bsp
    {
        public FileStream file;
        public BinaryReader reader;
        public BinaryWriter writer;
        public KeyValuePair<int,int>[] offsets = new KeyValuePair<int,int>[64]; // offset/length
        public bool LDR = false;
        public bool HDR = false;

        public Bsp(FileInfo file)
        {
            this.file = new FileStream(file.FullName, FileMode.Open);
            reader = new BinaryReader(this.file);
            writer = new BinaryWriter(this.file);
            //I don't exactly remember what this condition checks, but if it returns false, you're in some shit
            if (reader.ReadInt32() == 0x50534256)
            {
                //checks bsp version
                if (reader.ReadInt32() != 20)
                {
                    MessageBox.Show("this application was developed mainly for tf2 maps.\n while lightmaps are pretty standard across all source games I cannot guarantee compatibility with other games.\n so please be cautious.");
                }
                //gathers an array of of where things are located in the bsp
                for (int i = 0; i < offsets.GetLength(0); i++)
                {
                    offsets[i] = new KeyValuePair<int, int>(reader.ReadInt32(), reader.ReadInt32());
                    this.file.Seek(8, SeekOrigin.Current);
                }
            }
            else
            {
                MessageBox.Show("error 0x50534256\n\nSomething went very wrong.\nIf this is happening during normal use you probably should contact FubarFx on tf2maps.net");
            }

            //checks if there is ldr data in the bsp
            //ldr lightmap data is the 8th in the array of data in the bsp
            if (offsets[8].Value != 0)
            {
                LDR = true;
            }
            //checks if there is hdr data in the bsp
            //hdr lightmap data is the 53th in the array of data in the bsp 
            if (offsets[53].Value != 0 )
            {
                HDR = true;
            }
        }
    }
}
