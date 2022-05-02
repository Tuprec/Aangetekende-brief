
using System;
using System.Collections;
using System.Collections.Generic;

namespace Aangetekende_brief
{
    class Program
    {
        static void Main(string[] args)
        {
            aangetekende_brief brief = new aangetekende_brief();
            InternationaleAangetekendeBrief interbrief = new InternationaleAangetekendeBrief();
            HogePrioriteitsAangetekendeBreif hogeBrief = new HogePrioriteitsAangetekendeBreif();
            double afstand, tijd, prijs;
            DemonstreerBrieven();


            

        }

        private static void DemonstreerBrieven()
        {
            List<aangetekende_brief> brieven = new List<aangetekende_brief>();
            string strAnswer = "Y";
            int intBrief;
            do
            {
                Console.WriteLine("Welk soort brief wilt u versturen?");
                Console.Write("1. Aangetekende brief \n2. Internationale Aangetekende Brief \n3. Hoge Prioriteits Aangetekende Brief");
                intBrief = Convert.ToInt32(Console.ReadLine());

                if(intBrief == 1)
                {

                }

                Console.Write("Wilt u nog een brief opgeven(Y/N): ");
                strAnswer = Console.ReadLine().ToUpper();
            } while (strAnswer == "Y");
        }
    }
}
