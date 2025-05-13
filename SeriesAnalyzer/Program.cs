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
        static void  displaySeriesReversed(List<int> inputSeries)
        {
            Console.WriteLine("The series in reverse order is: ");
            for (int i = inputSeries.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(inputSeries[i]);
            }
        }
        static void displaySeries(List<int> inputSeries)
        {
            Console.WriteLine("The series is: ");
            foreach (int i in inputSeries)
            {
                Console.WriteLine(i);
            }
            
        }
        static void displaySeriesSorted(List<int> inputSeries)
        {
            Console.WriteLine("The series sorted is: ");
            List<int> sortedList = inputSeries.OrderBy(x => x).ToList();
            foreach (int i in sortedList)
            {
                Console.WriteLine(i);
            }
        }
        static void displaySeriesMax(List<int> inputSeries)
        {
            Console.WriteLine("The maximum number in the series is: ");
            int max = inputSeries[0];
            for  (int i = 1; i <= inputSeries.Count-1; i++ )
            {
                if (inputSeries[i] > max)
                {
                    max = inputSeries[i];
                }
            }
                   Console.WriteLine(max);
        }

        static void displaySeriesMin(List<int> inputSeries)
        {
            Console.WriteLine("The minimum number in the series is: ");
            int min = inputSeries[0];
            for (int i = 1; i <= inputSeries.Count - 1; i++)
            {
             
                if (inputSeries[i] < min)
                {
                    min = inputSeries[i];
                }
            }
            Console.WriteLine(min);
        }
        static void displaySeriesAverage(List<int> inputSeries)
        {
            Console.WriteLine("The average of the series is: ");
            int sum = 0;
            foreach (int i in inputSeries)
            {
                sum += i;
            }
            double average = (double)sum / inputSeries.Count;
            Console.WriteLine(average);
        }
        static void displaySeriesCount(List<int> inputSeries)
        {
            Console.WriteLine("The count of the series is: ");
            Console.WriteLine(inputSeries.Count);
        }
        static void displaySeriesSum(List<int> inputSeries)
        {
            Console.WriteLine("The sum of the series is: ");
            int sum = 0;
            foreach (int i in inputSeries)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void ExitProgram()
        {
            Console.WriteLine("God bay!! ");
            Environment.Exit(0);
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
            return arguments.Count > 2;
        }
        static void displayMenu()
        {
            Console.WriteLine("Please choose one of the following options by entering the corresponding letter:");
            Console.WriteLine("a. Enter a new series (replace the current one)");
            Console.WriteLine("b. Display the series in the original order");
            Console.WriteLine("c. Display the series in reverse order");
            Console.WriteLine("d. Display the series sorted (ascending)");
            Console.WriteLine("e. Display the maximum value in the series");
            Console.WriteLine("f. Display the minimum value in the series");
            Console.WriteLine("g. Display the average of the series");
            Console.WriteLine("h. Display the number of elements in the series");
            Console.WriteLine("i. Display the sum of the series");
            Console.WriteLine("j. Exit the program");
            Console.Write("Enter your choice (a–j): ");
        }



        static void Main(string[] args)
        {
            getArguments(args);
            verifyingReceiptOfNumbers(getArguments(args));
            verifyPositiveNumbers(verifyingReceiptOfNumbers(getArguments(args)));


        }
        
        }
    }

