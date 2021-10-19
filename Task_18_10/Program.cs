using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnitLibrary;

namespace Task_18_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Write value to covert by [number][unitFrom], [unitTo] pattern. 5g, mg for example");
            string line = Console.ReadLine();
            if (CorrectPattern(line))
            {
                LoadVariables(line, out int value, out string unitFrom, out string unitTo);
                if (UnitVariables(unitFrom, unitTo)) { 
                    decimal result = Converter.Convert(UnitFactory.FromString(unitFrom), UnitFactory.FromString(unitTo), value);
                    Console.WriteLine($"{result}{unitTo}"); }
            else
                Console.WriteLine("Unit(s) name(s) is/are incorect");
            }
            else
            {
                Console.WriteLine($"Your answer doesn't match to the pattern");
            }
            
        }
        public static bool CorrectPattern(string line)
        {
           if(!Regex.IsMatch(line, "[1-9]{1,}[a-z]{1,}, [a-z]")) 
                return false;
           return true;
        }
        public static void LoadVariables(string line, out int value, out string unitFrom, out string unitTo)
        {
            Regex numberRegex = new Regex("[1-9]{1,}");
            Regex unitRegex = new Regex("[a-z]{1,}");
            string[] splitedByComma = line.Split(',');
            value = int.Parse(numberRegex.Match(splitedByComma[0]).Value);
            unitFrom = unitRegex.Match(splitedByComma[0]).Value;
            unitTo = unitRegex.Match(splitedByComma[1]).Value;
        }
        public static bool UnitVariables( string unitfrom, string unitto)
        {
            List<string> AvailableUnits = new List<string> { "g", "mg", "lbs", "oz" };

            if(AvailableUnits.Contains(unitfrom)&&AvailableUnits.Contains(unitto))
                return true;
            else
                return false;
            

        }
    }
}
