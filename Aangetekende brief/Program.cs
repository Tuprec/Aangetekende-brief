
using System;
using System.Collections;
using System.Collections.Generic;

namespace Aangetekende_brief
{
    class Program
    {
        static void Main(string[] args)
        {            
            DemonstreerBrieven();          

        }

        private static void DemonstreerBrieven()
        {
            double afstand, tijd, prijs;
            List<aangetekende_brief> brieven = new List<aangetekende_brief>();
            string strAnswer = "Y";
            int intBrief;
            do
            {
                Console.WriteLine("Welk soort brief wilt u versturen?");
                Console.WriteLine("1. Aangetekende brief \n2. Internationale Aangetekende Brief \n3. Hoge Prioriteits Aangetekende Brief");
                intBrief = Convert.ToInt32(Console.ReadLine());

                if (intBrief == 1)
                {
                    aangetekende_brief brief = new aangetekende_brief();
                    do
                    {
                        afstand = brief.ReisAfstand();
                        if (afstand < 0)
                        {
                            Console.WriteLine("De afstand kan niet negatief zijn!!!");
                        }
                    } while (afstand < 0);

                    Console.WriteLine(afstand);
                }
                else if (intBrief == 2)
                {
                    InternationaleAangetekendeBrief interbrief = new InternationaleAangetekendeBrief();
                    do
                    {
                        afstand = interbrief.ReisAfstand();
                        if (afstand < 0)
                        {
                            Console.WriteLine("De afstand kan niet negatief zijn!!!");
                        }
                    } while (afstand < 0);

                    Console.WriteLine(afstand);
                }
                else
                {
                    HogePrioriteitsAangetekendeBreif hogeBrief = new HogePrioriteitsAangetekendeBreif();
                    do
                    {
                        afstand = hogeBrief.ReisAfstand();
                        if (afstand < 0)
                        {
                            Console.WriteLine("De afstand kan niet negatief zijn!!!");
                        }
                    } while (afstand < 0);

                    Console.WriteLine(afstand);
                }
                Console.Write("Wilt u nog een brief opgeven(Y/N): ");
                strAnswer = Console.ReadLine().ToUpper();
            } while (strAnswer == "Y");
        }
    }
}
