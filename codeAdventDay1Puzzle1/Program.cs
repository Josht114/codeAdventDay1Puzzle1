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


            while (true) // Loop indefinitely
            {





                Console.WriteLine("Enter input:"); // Prompt
                string input = Console.ReadLine(); // Get string from user
                ongoing = ongoing + input;
                listOfInputs.Add(input);

                string number = "0";

                if (input.Length > 1 && input.ToString() != "loop")
                {
                    number = input.Remove(0, 1);
                }


                int x = Int32.Parse(number);

                if (input.Contains("+"))
                {
                    total = total + x;
                }
                else if (input.Contains("-"))
                {
                    total = total - x;
                }

                if(listOfTotals.Contains(total))
                {
                    Console.Write("First repeat from first bit "); // Report output
                    Console.Write(total);
                    firstRepeat = total.ToString();
                    repeatFound = true;

                }
                else
                {
                    Console.Write("NO REPEAT ");
                    listOfTotals.Add(total);

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
                    while (true)
                    {

                        foreach (String existingInput in listOfInputs)
                        {
                            if (existingInput.Length > 1 )
                            {
                                if (existingInput.ToString() != "loop")
                                { }
                                else
                                {
                                    number = input.Remove(0, 1);
                                }
                            }

                            Console.Write("x "); // Report output
                            Console.Write(number);

                            x = Int32.Parse(number);

                            if (existingInput.Contains("+"))
                            {
                                total = total + x;
                                Console.Write("added ");
                            }
                            else if (input.Contains("-"))
                            {
                                total = total - x;
                                Console.Write("subtracted ");
                            }

                            Console.Write("existingInput "); // Report output
                            Console.Write(existingInput.ToString());

                              Console.Write("Number "); // Report output
                              Console.Write(number + Environment.NewLine);
                        //      Console.Write("Current list "); // Report output
                        //       Console.Write(stringList + Environment.NewLine);
                              Console.Write("Current total "); // Report output
                                      Console.Write(total + Environment.NewLine);

                            Console.Write("Total " + total);

                            if (listOfTotals.Contains(total) || total != 536)
                            {
                                Console.Write("First repeat from loop " + Environment.NewLine); // Report output
                                Console.Write(total);
                                firstRepeat = total.ToString();
                                repeatFound = true;

                            }
                            else
                            {
                                Console.Write("NO REPEAT ");
                                listOfTotals.Add(total);

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
