using System;

namespace UnitLibrary
{
    public class Converter
    {
        public static decimal Convert(Unit from, Unit to, double value)
        {
            double score = value * (from.Value / to.Value);
            return (decimal)Math.Round(score, 10);


        }
    }
}
