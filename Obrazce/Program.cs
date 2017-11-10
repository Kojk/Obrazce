using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    class Program
    {
        static void Main(string[] args)
        {
           // Obrazec kruh = new Kruh(5.1);
            //Console.WriteLine("Obsah kruhu : {0}", kruh.VypocitajObsah());
            //Stvorec stvorec = new Stvorec(5.6);
            //Console.WriteLine("Obsah stvorca : {0}", stvorec.VypocitajObsah());

            //Stvorec stvorec2 = new Stvorec(5.6);

            //Stvorec.Porovnej(stvorec, stvorec2);

            //Console.WriteLine("Porovnanie {0}", Stvorec.Porovnej(stvorec, stvorec2));

            //IKreslenie k = stvorec2;
            //IKreslenie k1 = new Kruh(10.2);

            //k.Vykresli();
            //k1.Vytlac();

            Kruh kruh1 = new Kruh(8);
            IZmenRozmer zmenaKruhu = kruh1;
            zmenaKruhu.ZmenRozmer(1);
            kruh1.VypocitajObsah();
            Console.WriteLine(kruh1.VypocitajObsah());

            Stvorec stvorec1 = new Stvorec(8);
            IZmenRozmer zmenaStvorca = stvorec1;
            zmenaStvorca.ZmenRozmer(1);
            kruh1.VypocitajObsah();
            Console.WriteLine(stvorec1.VypocitajObsah());

            Console.ReadLine();
        }
                
    }
}
