﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aangetekende_brief
{
    class HogePrioriteitsAangetekendeBreif:aangetekende_brief
    {
        public byte Reistijd(double reisafstand)
        {
            byte tijd;
            tijd = Convert.ToByte(Math.Round((reisafstand/200), 0, MidpointRounding.AwayFromZero));
            return tijd;
        }
        public double Kostprijs(double reisafstand)
        {
            double prijs;
            double afstand = reisafstand / 100;
            prijs = Math.Round(afstand, 0, MidpointRounding.AwayFromZero) * 30;
            return prijs;
        }
    }
}