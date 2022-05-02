using System;
using System.Collections.Generic;
using System.Text;

namespace Aangetekende_brief
{
    class aangetekende_brief
    {
        public double ReisAfstand()
        {
            double AFstand;
            Console.Write("Geef de reisafstand in km: ");
            AFstand = Convert.ToDouble(Console.ReadLine());
            if (AFstand < 0)
            {
                Console.WriteLine("De afstand kan niet negatief zijn!!!");
                ReisAfstand();
            }
            return AFstand;
        }
        public virtual byte Reistijd(double reisafstand)
        {
            byte tijd;
            tijd = Convert.ToByte(reisafstand/ 100);
            return tijd;
        }
        public virtual double Kostprijs(double reisafstand)
        {
            double prijs;
            if (reisafstand<= 100)
            {
                prijs = 15;
            }
            else
            {
                double afstand = (reisafstand - 100) / 100;
                prijs = Math.Round(afstand, 0, MidpointRounding.AwayFromZero)*10+15;
            }
            return prijs;
        }
    }
}
