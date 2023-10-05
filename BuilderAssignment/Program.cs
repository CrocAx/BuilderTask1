using BuilderAssignment.Builders;
using BuilderAssignment.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderAssignment
{
    internal class Program
    {
        /// <summary>
        /// For this assignment we are going to build "Ramen Bowl Builder" that could be used to
        /// help kitchen staff assemble bowls o ramen according to customer's preference.
        /// 
        /// Instructions
        /// 
        /// In Builders folder, add new classes that inherit IRamenBuilder for following ramen recepies
        /// - MisoRamenBuilder
        ///     Recepie: 
        ///     - Broth: Miso
        ///     - Noodles: Udon
        ///     - Toppings: Green Onions
        ///     - Extras: Corn
        ///     
        /// - SpicyRamenBuilder
        ///     Recepie: 
        ///     - Broth: SpicyTonkotsu
        ///     - Noodles: Thin
        ///     - Toppings: Gashu Pork & Green Onions
        ///     - Extras: Extra Spice
        ///     
        /// - VeganRamenBuilder
        ///     Recepie: 
        ///     - Broth: Vegan
        ///     - Noodles: Soba
        ///     - Toppings: Bambo Shoots & Seaweed
        ///     - Extras: no extras
        /// 
        /// In RamenBowl.cs add attributes for each ingredient type found in the IngredientEnums.cs file
        /// And update FinishedBowlOfRamen method to return string containing all information of selected ingredients.
        /// 
        /// NOTE: Since in this assignment we are using IRamenBuilder which is interface, remeber to create the RamenBowl object
        ///       inside each ramen type builder class => private RamenBowl ramen = new RamenBowl();
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // TODO#1: Wake up your RamenChef by initializing it
            RamenChef chef = new RamenChef();

            // TODO#2: Create new RamenBuilder's for each ramen recepies (MisoRamenBuilder, SpicyRamenBuilder, VeganRamenBuilder) 
            IRamenBuilder miso = new MisoRamenBuilder();
            IRamenBuilder spicy = new SpicyRamenBuilder();
            IRamenBuilder vegan = new VeganRamenBuilder();
            

            // TODO#3: Use your RamenChef to prepare (build) each type of ramen (Miso, Spicy, Vegan)
            Console.WriteLine("Welcome to the ramen shop!");
            Console.WriteLine("Please select a type of ramen you'd like to eat:");
            Console.WriteLine("1: Miso Ramen");
            Console.WriteLine("2: Spicy Ramen");
            Console.WriteLine("3: Vegan Ramen");

            // Read user input
            string choice = Console.ReadLine() ?? "";
            if (choice == null) return;

            // Define builder
            IRamenBuilder ramenBuilder;

            switch (choice)
            {
                case "1":
                    ramenBuilder = miso;
                    ramenBuilder.GetRamen();
                    break;

                case "2":
                    ramenBuilder = spicy;
                    ramenBuilder.GetRamen();
                    break;
                case "3":
                    ramenBuilder = vegan;
                    ramenBuilder.GetRamen();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Making default ramen: Miso Ramen.");
                    ramenBuilder = new MisoRamenBuilder();
                    ramenBuilder.GetRamen();
                    break;
            }

            RamenBowl ramen = chef.PrepareRamen(ramenBuilder);
            // TODO#4: After the RamenCheft has prepared the bowl of ramen, use FinishedBowlOfRamen to get the content of
            //         the RamenBowl and print it out using WriteLine method

            Console.WriteLine($"Your {ramenBuilder.GetType().Name.Replace("Builder", "")} is ready:" );
            Console.WriteLine(ramen.FinishedBowlOfRamen());
        }
    }
}