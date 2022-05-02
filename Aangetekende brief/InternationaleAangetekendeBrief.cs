using System;
using System.Collections.Generic;
using System.Text;

namespace Aangetekende_brief
{
    class InternationaleAangetekendeBrief: aangetekende_brief
    {
        public override byte Reistijd(double reisafstand)
        {
            byte tijd;
            tijd = Convert.ToByte(Math.Round((reisafstand / 50), 0, MidpointRounding.AwayFromZero));
            return tijd;
        }
        public override double Kostprijs(double reisafstand)
        {
            double prijs;
            double afstand = reisafstand/100;
            prijs = Math.Round(afstand, 0, MidpointRounding.AwayFromZero)*20;
            return prijs;
        }
    }
}
