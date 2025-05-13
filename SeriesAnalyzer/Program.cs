using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
    
  
{
    internal class Program
    {
        //Functions for receiving a series of arguments or numbers from the user (including validation that positive numbers are received).
        // Get the arguments from the command line
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

        // Verify the receipt of numbers from the command line arguments
        static List<int> verifyingReceiptOfNumbers(List<string> listring)
        {
            List<int> _listNumbers = new List<int>();
            foreach (string str in listring)
            {
                if (int.TryParse(str, out int number))
                    _listNumbers.Add(number);
                else
                {
                    Console.WriteLine($"The argument '{str}' is not a valid number.");
                }
            }
            return _listNumbers;
        }

        // Verify that the numbers are positive
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

        // Get user inputs with a stop option
        static List<string> getUserInputsWithStop(int numberOfInputs)
        {
            List<string> _listInputs = new List<string>();
            int i = 0;

            while (true)
            {
                Console.WriteLine($"Enter your {i + 1} number: ");
                string inputNum = Console.ReadLine();

                if (inputNum.ToLower() == "stop" && i >= numberOfInputs)
                {
                    Console.WriteLine("Input stopped by user.");
                    break;
                }

                _listInputs.Add(inputNum);
                i++;

                if (i == numberOfInputs)
                {
                    Console.WriteLine("You have reached the minimum number of inputs.");
                    Console.WriteLine("If you want to stop, type 'stop' next time.");
                    Console.WriteLine("Otherwise, keep entering numbers.");
                }
            }

            return _listInputs;
        }

        //Functions to display the series in different formats according to the user's choice in the menu
        // Display the series in the original order
        static void displaySeries(List<int> inputSeries)
        {
            Console.WriteLine("The series is: ");
            foreach (int i in inputSeries)
            {
                Console.WriteLine(i);
            }

        }

        // Display the series in reverse order
        static void  displaySeriesReversed(List<int> inputSeries)
        {
            Console.WriteLine("The series in reverse order is: ");
            for (int i = inputSeries.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(inputSeries[i]);
            }
        }
        // Display the series sorted in ascending order
        static void displaySeriesSorted(List<int> inputSeries)
        {
            Console.WriteLine("The series sorted is: ");
            List<int> sortedList = inputSeries.OrderBy(x => x).ToList();
            foreach (int i in sortedList)
            {
                Console.WriteLine(i);
            }
        }
        // Display the maximum value in the series
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
        // Display the minimum value in the series
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
        // Display the average of the series
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
        // Display the number of elements in the series
        static void displaySeriesCount(List<int> inputSeries)
        {
            Console.WriteLine("The count of the series is: ");
            Console.WriteLine(inputSeries.Count);
        }
        // Display the sum of the series
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
        // Display the exit message and exit the program
        static void ExitProgram()
        {
            Console.WriteLine("God bay!! ");
            Environment.Exit(0);
        }


        //General functions for running the program
        // Display the menu with options
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
        // Validate the user's choice
        static char getValidatedMenuChoice()
        {
            char choice;
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == 1 && char.IsLetter(input[0]) && "abcdefghij".Contains(char.ToLower(input[0])))

                {
                    choice = char.ToLower(input[0]);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a single letter (a–j).");
                }
            }
            return choice;
        }
        // Handle the user's choice and call the appropriate function
        static void HandleUserChoice(char choice,ref List<int> inputSeries)
        {
            switch (choice)
            {
                case 'a':
                    while (true)
                    {
                        inputSeries = verifyPositiveNumbers(verifyingReceiptOfNumbers(getUserInputsWithStop(3)));
                        if (inputSeries.Count >= 3)
                            break;
                        else
                            Console.WriteLine("No valid positive numbers were entered. Please try again.");
                    }
                    break;

                case 'b':
                    displaySeries(inputSeries);
                    break;

                case 'c':
                    displaySeriesReversed(inputSeries);
                    break;

                case 'd':
                    displaySeriesSorted(inputSeries);
                    break;

                case 'e':
                    displaySeriesMax(inputSeries);
                    break;

                case 'f':
                    displaySeriesMin(inputSeries);
                    break;

                case 'g':
                    displaySeriesAverage(inputSeries);
                    break;

                case 'h':
                    displaySeriesCount(inputSeries);
                    break;

                case 'i':
                    displaySeriesSum(inputSeries);
                    break;

                case 'j':
                    ExitProgram();
                    break;

                default:
                    Console.WriteLine("Unknown option.");
                    break;
            }
        }
        // Main function to start the program
        static void startProgram(string[] args)
        {
            List<int> inputSeries = verifyPositiveNumbers(
     verifyingReceiptOfNumbers(
         getArguments(args)
            )
                );
            if (inputSeries.Count < 3)

                { 
                while (true)
                    {
                inputSeries = verifyPositiveNumbers(verifyingReceiptOfNumbers(getUserInputsWithStop(3)));
                if (inputSeries.Count >= 3)

                    break;
                else
                    Console.WriteLine("No valid positive numbers were entered. Please try again.");
                        }
                }
            while (true)
            {
                displayMenu();
                char choice = getValidatedMenuChoice();
                HandleUserChoice(choice, ref inputSeries);
                if (choice == 'j')
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You selected option '{choice}'.");
                }
                
            }
        }

        static void Main(string[] args)
        {
            startProgram(args);
           


        }
        
        }
    }

