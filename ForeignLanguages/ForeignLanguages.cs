using System;

namespace ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main(string[] args)
        {
            //            Create a program that prints the spoken language in a country. You will receive only the following combinations:
            //•	English is spoken in England and the USA.
            //•	Spanish is spoken in Spain, Argentina, and Mexico.
            //•	For the others, we should print "unknown".
            //Input
            //You will receive a single line of input, representing the country name.
            //Output
            //Print the language that is spoken in the given country.In case the country is unknown for the program, print "unknown".

            string country = Console.ReadLine();
            string language = string.Empty;

            switch (country)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }
            Console.WriteLine(language);
        }
    }
}