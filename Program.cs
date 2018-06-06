using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToSamuel
{
    public class Program
    {
        static Dictionary<char, string> ConvertDict;
        static void Main(string[] args)
        {
            ConvertDict = new Dictionary<char, string>() {
                {'a',".-" },
                {'b',"-..."},
                {'c',"-.-."},
                {'d',"-.."},
                {'e',"."},
                {'f',"..-."},
                {'g',"--."},
                {'h',"...."},
                {'i',".."},
                {'j',".---"},
                {'k',"-.-"},
                {'l',".-.."},
                {'m',"--"},
                {'n',"-."},
                {'o',"---"},
                {'p',".--."},
                {'q',"--.-"},
                {'r',".-."},
                {'s',"..."},
                {'t',"-"},
                {'u',"..-"},
                {'v',"...-"},
                {'w',".--"},
                {'x',"-..-"},
                {'y',"-.--"},
                {'z',"--.."}
            };
            Console.WriteLine("what do you want to transfer");
            string userInput = Console.ReadLine();
            Console.WriteLine(convert(userInput));
            Console.ReadLine();  
        }
        public static string convert(string input)
        {
            string output="";
            foreach (char letters in input)
            {
                if (ConvertDict.ContainsKey(letters))
                {
                    output += ConvertDict[letters];
                }
                else
                {
                    output += "_ ";
                }              
            }
            return output;
        }
    }
}
