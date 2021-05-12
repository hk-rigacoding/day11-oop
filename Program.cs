using System;

namespace day11_oop
{
   
    class Kvadrats : Shapes
    {


        public Kvadrats()
        {
        }

        //vajadzētu konstruktorus kvadrātam
        //kvadrātam raksturīgus laukus/metodes
        public Kvadrats(int garums)
        {
            SetMalas(4);
            MalaA = MalaB = MalaC = MalaD = garums;
        }

        int MalaA;
        int MalaB;
        int MalaC;
        int MalaD;

    }



    class Trijsturis : Shapes
    {
        public Trijsturis()
        {
        }

        //vajadzētu konstruktorus trijstūrim
        //trijstūrim raksturīgus laukus/metodes
        
        
        //vienādmalu trijstūris
        public Trijsturis(int garums)
        {
            SetMalas(3);
            MalaA = MalaB = MalaC = garums;
        }


        //dažādiem malu garumiem
        public Trijsturis(int garums1, int garums2, int garums3)
        {
            SetMalas(3);
            MalaA = garums1;
            MalaB = garums2;
            MalaC = garums3;
        }


        int MalaA;
        int MalaB;
        int MalaC;

    }







    class Program
    {


        static void Main(string[] args)
        {


            //izņemt `malu_skaits` + metodes no Shapes un pielikt to tikai Kvadrātā.


            Kvadrats kv = new Kvadrats(5);

            Trijsturis tr = new Trijsturis(5);

            //kv.SetMalas(0);

            //kv.GetMalas();



            Console.WriteLine("Laukums = " +  kv.GetLaukums());


            //mūsu klasei nav insanču un nav atmiņas tēriņa.
            //taisnsturis, taisnsturis_2, rinkjis neaizņem atmiņu 
            //=============================================
            //šajā vietā mēs pieprasām atmiņas alokāciju !
            Shapes taisnsturis = new Shapes(4);

            //šajā vietā mēs pieprasām atmiņas alokāciju !
            Shapes taisnsturis_2 = new Shapes(4);

            //šajā vietā mēs pieprasām atmiņas alokāciju !
            //Shapes rinkjis = new Shapes(true);


            //šajā vietā mēs pieprasām atmiņas alokāciju !
            //int sk = 0;
            //Shapes rinkjis_diivains = new Shapes(10.4d);


            //piešķiram lauku vērtības dažādiem objektiem !
            //taisnsturis.SetEdges(5);
           // taisnsturis_2.SetEdges(5);
            //rinkjis.SetEdges(0);



            //netiek kopēti nekādi dati !
            //tā ir vienkārši reference uz koplietojamiem datiem
            //darbības ar referenci maina datus patiesajā atmiņā
            //Shapes rinkjis_diivains_reference = rinkjis_diivains;
            //kas notiks ar `rinkjis_diivains` datiem, ja es mainīšu `rinkjis_diivains_reference` datus ?

           // rinkjis_diivains_reference.SetEdges(23);


            //tiks veidota datu kopija, dati tiks dublēti
            int viens = 5;
            int divi = viens;

            //mainam datus tikai kopijā !
            divi = 3;


            {
                //darbības ar failiem
                //lokālo mainīgo darbības lauks ir šis koda bloks !
            }


            //masīvs ar referencēm

            //1. Ar Random() izveidojiet no 1 - 100 klases instances un
            //2. ciklā inicializējiet tās.

            //Shapes[] taisnsturis_mas = new Shapes[3];
            //ciklā jāinicializē `taisnsturis_mas`
            //for ciklā ar new Shapes(???)
            /*
            Random rand = new Random();
            int instances = rand.Next(1, 100);

            Shapes[] formas_100 = new Shapes[instances];
            for (int i = 0; i < instances; i++)
            {
                formas_100[i] = new Shapes(3);
            }

            */



            Random r = new Random();
            int inst = r.Next(1, 100);

            Shapes[] EdgeArray = new Shapes[inst];

            for (int i = 0; i < inst; i++)
            {
                EdgeArray[i] = new Shapes(0);
                Console.WriteLine("{0}", EdgeArray[i]);
            }

            //rinkjis_diivains.SetEdges(0);






            Console.WriteLine("Hello World!");
        }
    }
}
