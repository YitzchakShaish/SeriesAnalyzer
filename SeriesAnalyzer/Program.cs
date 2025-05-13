using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
    
  
{
    internal class Program
    {
        static List<string> getUserInputs(int numberOfInputs)
        {
            List<string> _listInputs = new List<string>();
            for (int i = 0; i < numberOfInputs; i++)
            {
                Console.WriteLine($"Enter your {i + 1} number: ");
                string inputNum = Console.ReadLine();
                _listInputs.Add(inputNum);
            }
            return _listInputs;
        }
        static List<int> clearNumberSeries(List<int> inputSeries)
        {
            inputSeries.Clear();
            return inputSeries;
        }
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

        static List<int> verifyPositiveNumbers(List<int> listints)
        {
            List<int> _listPositiveNumbers = new List<int>();
            foreach (int number in listints)
            {
                if (number > 0)
                {
                    _listPositiveNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"The number '{number}' is not a positive number.");
                }
            }
            return _listPositiveNumbers;
        }

        static bool hasArguments(List<string> arguments)
        {
            return arguments.Count > 0;
        }



        static void Main(string[] args)
        {
            getArguments(args);
            verifyingReceiptOfNumbers(getArguments(args));
            verifyPositiveNumbers(verifyingReceiptOfNumbers(getArguments(args)));


        }
        
        }
    }

