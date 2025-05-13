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
        static List<int> verifyingReceiptOfNumbers(List<string> _listArguments)
        {
            if (!hasArguments(_listArguments))
            {
                Console.WriteLine("No arguments were received.");
                return new List<int>();
            }
            else
            {
                Console.WriteLine("Arguments received.");

                List<int> _listNumbers = new List<int>();
                foreach (string arg in _listArguments)
                {
                    if (int.TryParse(arg, out int number))
                    {
                        int argNum = int.Parse(arg);
                        _listNumbers.Add(argNum);
                    }
                    else
                    {
                        Console.WriteLine($"The argument {arg} is not a number.");
                    }
                }

                return _listNumbers;

            }
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

