using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
    class Program
    {
        /// <summary>
        /// Converts a string into a dictionary
        /// </summary>
        static Dictionary<string, string> ConvertStringToDictionary(string input)
        {
             return input.Split(';', StringSplitOptions.RemoveEmptyEntries)
             .Select(parts => parts.Split(':', StringSplitOptions.RemoveEmptyEntries))
             .ToDictionary(kv => kv[0], kv => kv[1]);
        }

        /// <summary>
        /// Run the string to dictionary example
        /// </summary>
        static void RunStringToDictionary()
        {
            string style = "text-align: 5px; height: 5px; width: 5px";

            // step by step
            var styleParts = style.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList();
            var keysAndValues = styleParts.Select(p => p.Split(':', StringSplitOptions.RemoveEmptyEntries)).ToList();
            var dictionary = keysAndValues.ToDictionary(s => s[0], s => s[1]);
            Console.WriteLine(dictionary["text-align"]);

            // Make it elegant
            var styleMap = ConvertStringToDictionary(style);
            foreach (KeyValuePair<string, string> pair in styleMap)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }

        /// <summary>
        /// Iterates through a 2D array and calculates total hours per person
        /// </summary>
        static void RunTwoDimensionalArrayExample()
        {
            string[] names = { "Justin", "Kristy", "Katie" };
                                                              
            int[,] hours = new int[,]{ 
                // S, M, T, W, TH, F, S
                {  0, 0, 0, 0, 0,  0, 0 },  // Justin hours
                {  1, 1, 1, 1, 1,  1, 1 }, // Kristy hours
                {  8, 8, 8, 8, 8,  8, 8 } // Katie hours
            };

            Console.WriteLine("Total hours per person:");
            for (int i = 0; i < hours.GetLength(0); i++ )
            {
                int sum = 0;
                for(int h = 0; h < hours.GetLength(1); h++)
                {
                    sum += hours[i, h];
                }

                Console.WriteLine("{0} : {1} hours.", names[i], sum);
            }
        }

        static void Main(string[] args)
        {

            // Convert string to dictionary
            RunStringToDictionary();

            // Two dimensional array example (tracks hours per person
            RunTwoDimensionalArrayExample();

        }
    }
}
