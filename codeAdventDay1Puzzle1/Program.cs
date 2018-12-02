using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeAdventDay1Puzzle1
{
    class Program
    {
        static void Main(string[] args)
        {

            string ongoing = "";
            int total = 0;
            List<int> listOfTotals = new List<int>();
            List<String> listOfInputs = new List<String>();

            bool repeatFound = false;
            string firstRepeat = "";

            string number = "";

            int containsCounter = 0;
            int doesNotContainCounter = 0;
            int x = 0;

            while (true) // Loop indefinitely
            {





                Console.WriteLine("Enter input:"); // Prompt
                string input = Console.ReadLine(); // Get string from user
                ongoing = ongoing + input;
                listOfInputs.Add(input);


                if (input != "loop")
                {
                     number = "";
                }

                if (input.Length > 1 && input.ToString() != "loop")
                {
                    number = input.Remove(0, 1);
                }

                if (input != "loop")
                {
                     x = Int32.Parse(number);
                }


                if (input.Contains("+") && input != "loop")
                {
                    total = total + x;
                }
                else if (input.Contains("-") && input != "loop")
                {
                    total = total - x;
                }

                if(listOfTotals.Contains(total) && input != "loop")
                {
                    Console.Write("First repeat from first bit ");
                    Console.Write("Current total " + total + Environment.NewLine);
                    firstRepeat = total.ToString();
                    repeatFound = true;

                }
                else if  (input != "loop")
                {
                    Console.Write("NO REPEAT (no loop) ");
                    listOfTotals.Add(total);
                    Console.Write("New total added " + total + Environment.NewLine);
                }

                string stringList = "";

                foreach (int i in listOfTotals)
                {
                    stringList = stringList + i.ToString() + " ";
                }




                //   sr.ReadLine().Replace(Environment.NewLine, String.Empty);

       //         Console.Write("You typed "); // Report output
        //        Console.Write(input.Length );
        //        Console.WriteLine(" character(s) " + Environment.NewLine);
        //        Console.Write("Number "); // Report output
         //       Console.Write(number + Environment.NewLine);
        //        Console.Write("Current list "); // Report output
        //        Console.Write(stringList + Environment.NewLine);
        //        Console.Write("Current total "); // Report output
         //       Console.Write(total + Environment.NewLine);




                if (input == "exit") // Check string
                {
                    break;
                }

                if (input == "loop") // Check string
                {

                    listOfInputs.Remove("loop");

                    while (true)
                    {

                        foreach (String existingInput in listOfInputs)
                        {
                            if (existingInput.Length > 1 )
                            {
                                if (existingInput.ToString() != "loop")
                                {
                                    number = existingInput.Remove(0, 1);
                                }

                            }

                            Console.Write("existingInput (in loop) " + existingInput + Environment.NewLine);

                            if (existingInput != "loop")
                            {
                                x = Int32.Parse(number);
                            }

                            if (existingInput.Contains("+") && existingInput != "loop")
                            {
                                total = total + x;
                                Console.Write("added ");
                            }
                            else if (existingInput.Contains("-") && existingInput != "loop")
                            {
                                total = total - x;
                                Console.Write("subtracted ");
                            }

                            Console.Write("Number " + number + Environment.NewLine);

                              Console.Write("Current total " + total + Environment.NewLine);


                       //     Console.Write("Total " + total + Environment.NewLine);

                            if (listOfTotals.Contains(total) && existingInput != "loop")
                            {
                                containsCounter++;
                                Console.Write("Contains counter " + containsCounter + Environment.NewLine);

                                Console.Write("total in list of totals " + Environment.NewLine);

                                firstRepeat = total.ToString();
                                repeatFound = true;
                                break;

                            }
                            else if (existingInput != "loop")
                            {
                                doesNotContainCounter++;
                                Console.Write("Contains counter " + containsCounter + Environment.NewLine);


                                Console.Write("NO REPEAT " + Environment.NewLine);
                                listOfTotals.Add(total);

                                Console.Write("New total added " + total + Environment.NewLine);


                            }
                        }

                        if (repeatFound)
                        {
                            Console.Write("***** REPEAT FOUND ***** " + firstRepeat + Environment.NewLine);
                            break;
                        }


                    }

                }

            }



        }
    }
}
