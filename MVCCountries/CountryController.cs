using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
        {
                new Country("Singapore", "Asia", new List<string>{"Red", "White"}),
                new Country("Brazil", "South America", new List<string>{"Blue", "Green", "Yellow"}),
                new Country("Italy", "Europe", new List<string>{"Green", "Red", "White"}),
        };


        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();

        }
        public void WelcomeAction()
        {
            bool runProgram = true;
            CountryListView views = new CountryListView(CountryDb);

            Console.WriteLine("Hello welcome to the country app. Please select country from the following list:");
            while (runProgram)
            {
                while (true)
                {
                    try
                    {
                        views.Display();
                        Console.WriteLine("Please input a number between 0 to 2");
                        int input = int.Parse(Console.ReadLine());
                        if (input < 0 || input > 2)
                        {
                            Console.WriteLine("Please enter between 0 to 2");

                        }

                        else
                        {
                            CountryAction(CountryDb[input]);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                }
                while (true)
                {
                    Console.WriteLine("Continue? y/n");
                    string inputs = Console.ReadLine();
                    if (inputs == "y")
                    {
                        runProgram = true;
                        break;
                    }
                    else if (inputs == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }
    }
}