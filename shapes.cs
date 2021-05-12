using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace day11_oop
{
    //instancēta klase aizņems atmiņu
   class Shapes
    {
        public Shapes()
        {
        }


        //kāpēc rakstam konstruktorus ?
        //dod iespēju manipulēt 

        //ne - rinkja konstruktora metode
        
        public Shapes(int skaits)
        {
            malu_skaits = skaits;
            //Console.WriteLine("Hello World! int");
        }

        /*
        //rinkja konstruktora metode
        public Shapes(bool ir_rinkjis)
        {
            circle = ir_rinkjis;
            Console.WriteLine("Hello World! bool");
        }


        public Shapes(double virsotnju_skaits)
        {
            edges = (int)virsotnju_skaits;
            Console.WriteLine("Hello World! double");
        }


        public void SetEdges (int _edges)
        {
            edges = _edges;
        }
        */

        //datu laukiem var piekļūt pēc instancēšanas

        //riņķim šo nevajag
        //int edges;

        //taisnstūrim šo nevajag
        //bool circle;


        public void SetMalas(int skaits)
        {
            malu_skaits = skaits;
        }
        public int GetMalas()
        {
            return malu_skaits;
        }

        public double GetLaukums()
        {
            return laukums;
        }

        public void SetKraasa(Color kr)
        {
            kraasa = kr;
        }

        double laukums;
        Color kraasa;
        int malu_skaits;


    }
}
