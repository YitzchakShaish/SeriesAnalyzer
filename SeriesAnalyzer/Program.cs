using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
    
  
{
    internal class Program
    {
        static List<string> getArguments(string[] args)
        {
            List<string> _listArguments = new List<string>();
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
                _listArguments.Add(arg);

            }
            return _listArguments;
        }
        static List<int> verifyingReceiptOfNumbers(List<string> listring)
        { 
                List<int> _listNumbers = new List<int>();
                foreach (string str in listring)
                {
                    if (int.TryParse(str, out int number))
                    {
                        int newint = int.Parse(str);
                        _listNumbers.Add(newint);
                    }
                    else
                    {
                        Console.WriteLine($"The argument '{str}' is not a valid number.");
                    }
            }
            return _listNumbers;
            }

        static bool hasArguments(List<string> arguments)
        {
            return arguments.Count > 0;
        }



        static void Main(string[] args)
        {
            getArguments(args);
            verifyingReceiptOfNumbers(getArguments(args));


        }
        
        }
    }

