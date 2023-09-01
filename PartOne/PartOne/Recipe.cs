using System;

namespace PartOne
{
    class Recipe
    {
        //ARRAYS
        private Original[] originals; //array to hold original quanity values for reset method
        private Ingredient[] ingredients; //array to hold ingredient name, quantity and unit of measurement
        private Step[] steps; //array to hold each step description

        //VARIABLES
        string name; //ingredient name
        double quantity; //ingredient quantity
        string unit; //ingredient unit of measurement
        string description; //step description

        public void AddRecipe() //add recipe method
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White; //sets text colour
                Console.Write("\n---------------------------------"); //housekeeping
                Console.Write("\nNumber of Ingredients: "); //housekeeping

                int numIngredients = int.Parse(Console.ReadLine()); //saves user input for num ingredients

                ingredients = new Ingredient[numIngredients]; //declares array size for numIngredients
                originals = new Original[numIngredients]; //declares array size for numIngredients (reset method)

                for (int i = 0; i < numIngredients; i++) //for loop
                {
                    Console.WriteLine("---------------------------------"); //housekeeping
                    Console.Write($"Name of Ingredient {i + 1}: "); //housekeeping with num incrementing
                    name = Console.ReadLine(); //saves user input

                    Console.Write($"Quantity of " + name + ": "); //housekeeping with num incrementing
                    quantity = double.Parse(Console.ReadLine()); //saves user input

                    Console.Write($"Unit of Measurement for " + name + " : "); //housekeeping with num incrementing
                    unit = Console.ReadLine(); //saves user input

                    ingredients[i] = new Ingredient(name, quantity, unit); //saves name, quantity and unit in array
                    ingredients[i].originalQuantity = quantity; //saves quantity in array for reset method
                }

                Console.Write("---------------------------------"); //housekeeping
                Console.WriteLine("\nNumber of Steps: "); //housekeeping
                int numSteps = int.Parse(Console.ReadLine()); //saves user input

                steps = new Step[numSteps]; //declares array size for numsteps

                for (int i = 0; i < numSteps; i++) //for loop
                {
                    Console.WriteLine("---------------------------------"); //housekeeping
                    Console.Write($"Description for Step {i + 1}: "); //housekeeping with num incrementing
                    description = Console.ReadLine(); //saves user input

                    steps[i] = new Step(description); //saves step descriptions in array
                }

                Console.WriteLine("---------------------------------"); //housekeeping
                Console.ForegroundColor = ConsoleColor.Green; //sets text color
                Console.WriteLine("\n--- RECIPE ADDED ---");  //housekeeping
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; //sets text color
                Console.WriteLine("\nERROR: " + ex.Message); //displays an error if code is not exucuted correctly
            }
        }

        public void PrintRecipe() //print recipe method
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue; //sets text color
                Console.WriteLine("\n------ RECIPE ------\n"); //housekeeping
                Console.WriteLine("INGREDIENTS:"); //housekeeping

                foreach (Ingredient ingredient in ingredients) //foreach loop
                {
                    Console.WriteLine($"{ingredient.quantity} {ingredient.unit} {ingredient.name}"); //displays ingredients
                }

                Console.WriteLine("\nSTEPS:"); //housekeeping

                for (int i = 0; i < steps.Length; i++) //for loop
                {
                    Console.WriteLine($"{i + 1}. {steps[i].description}"); //displays steps with num incrementing
                }
                Console.WriteLine("--------------------"); //housekeeping
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; //sets text color
                Console.WriteLine("ERROR: " + ex.Message); //displays an error if code is not exucuted correctly
            }
        }

        public void ScaleRecipe(double factor) //scale method
        {
            try
            {
                foreach (Ingredient ingredient in ingredients) //foreach loop
                {
                    ingredient.quantity *= factor; //takes ingredient quantity and multiplies it by the scaling factor chosen
                }
                Console.ForegroundColor = ConsoleColor.Green; //sets text color
                Console.WriteLine("\n--- RECIPE SCALED ---"); //housekeeping
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; //sets text color
                Console.WriteLine("ERROR: " + ex.Message); //displays an error if code is not exucuted correctly
            }
        }

        public void ResetRecipe() //reset method
        {
            try
            {
                foreach (Ingredient i in ingredients) //foreach loop
                {
                    i.quantity = i.originalQuantity; //replaces quantity with original user values
                }
                Console.ForegroundColor = ConsoleColor.Green; //sets text color
                Console.WriteLine("\n--- RECIPE RESET ---"); //housekeeping
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; //sets text color
                Console.WriteLine("ERROR: " + ex.Message); //displays an error if code is not exucuted correctly
            }
        }


        public void ClearRecipe() //clear method
        {
            try
            {
                ingredients = null; //clears ingredients to null 
                steps = null; //clears steps to null 
                Console.ForegroundColor = ConsoleColor.Green; //sets text color
                Console.WriteLine("\n--- RECIPE CLEARED ---"); //housekeeping
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; //sets text color
                Console.WriteLine("ERROR: " + ex.Message); //displays an error if code is not exucuted correctly
            }
        }
    }
}
