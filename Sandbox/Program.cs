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

        static void Main(string[] args)
        {
            string style = "text-align: 5px; height: 5px; width: 5px";
           
            // step by step
            var styleParts = style.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList();
            var keysAndValues = styleParts.Select(p => p.Split(':', StringSplitOptions.RemoveEmptyEntries)).ToList();
            var dictionary = keysAndValues.ToDictionary(s => s[0], s => s[1]);
            Console.WriteLine(dictionary["text-align"]);

            // Make it elegant
            var styleMap = ConvertStringToDictionary(style);
            foreach(KeyValuePair<string, string> pair in styleMap)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

        }
    }
}
