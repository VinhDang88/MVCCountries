using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryView
    {
        public Country DisplayCounter { get; set; }
        public CountryView(Country _displayCounter)
        {
            DisplayCounter = _displayCounter;
        }
        //method
        public void Display()
        {
            Console.WriteLine($"Country: {DisplayCounter.Name} \nContinent: {DisplayCounter.Continent}"); /*\n {DisplayCounter.Colors}");*/

            foreach (string n in DisplayCounter.Colors)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(n);
                Console.WriteLine(n);
            }
            Console.ResetColor();
        }
    }
}
