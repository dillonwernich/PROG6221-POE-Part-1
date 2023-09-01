using System;

namespace PartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe(); //calling recipe class to the main class by creating an obj of the class

            while (true) //while loop for user to select option
            {
                //housekeeping
                Console.ForegroundColor = ConsoleColor.White; //sets text color
                Console.WriteLine("\n--- RECIPE MANAGER ---\n");
                Console.WriteLine("(1) Add Recipe");
                Console.WriteLine("(2) Display The Recipe");
                Console.WriteLine("(3) Scale The Recipe");
                Console.WriteLine("(4) Reset The Recipe");
                Console.WriteLine("(5) Clear The Recipe");
                Console.WriteLine("(6) Exit\n");

                Console.ForegroundColor = ConsoleColor.Red; //sets text color
                Console.Write("ENTER OPTION: "); //housekeeping

                string UserInput = Console.ReadLine(); //stores user input for the option they have chosen

                if (UserInput == "1") //if option 1 is chosen
                {
                    recipe.AddRecipe(); //add recipe method

                }
                else if (UserInput == "2") //if option 2 is chosen
                {
                    recipe.PrintRecipe(); //print recipe method
                }
                else if (UserInput == "3") //if option 3 is chosen
                    try
                    {
                        double factor; //variable
                        bool isValidInput; //bool to make sure user input is valid

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red; //sets text color
                            Console.Write("\nScaling Factor (0.5 | 2 | 3): "); //housekeeping
                            isValidInput = double.TryParse(Console.ReadLine(), out factor) && (factor == 0.5 || factor == 2 || factor == 3); //takes user input

                            if (!isValidInput) //if loop to check if user input is valid
                            {
                                Console.WriteLine("\n---INVALID---"); //invalid error message
                            }

                        } while (!isValidInput); //while loop to scale recipe if succesful

                        recipe.ScaleRecipe(factor); //sacle recipe method
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message); //error message if code does not exucute correctly
                    }
                else if (UserInput == "4") //if option 4 is chosen
                {
                    recipe.ResetRecipe(); //reset recipe method
                }
                else if (UserInput == "5") //if option 5 is chosen
                {
                    recipe.ClearRecipe(); //clear recipe method
                    recipe = new Recipe(); //starts a new recipe
                }
                else if (UserInput == "6") //if option 6 is chosen
                {
                    return; //exit
                }
                else
                {
                    //invalid option
                    Console.ForegroundColor = ConsoleColor.Red; //sets text color
                    Console.WriteLine("--- INVALID ---\n"); //housekeeping
                }
            }
        }
    }
}
