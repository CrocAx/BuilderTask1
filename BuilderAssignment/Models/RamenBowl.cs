using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    public class RamenBowl
    {
        //TODO#1: Add attributes for each enum in IngredientEnums.cs file
        public BrothType Broth {  get; set; }
        public NoodleType Noodle { get; set; }
        public List<ToppingType> Toppings { get; set; }
        public List<ExtraType> Extras { get; set; }

        //TODO#2: Return description of finished bowl of ramen
        public RamenBowl()
        {
            Toppings = new List<ToppingType>();
            Extras = new List<ExtraType>();
        }
        public string FinishedBowlOfRamen()
        {
            string toppings = string.Join(", ", Toppings);
            string extras = string.Join(", ", Extras);

            return $"Broth: {Broth};\nNoodles: {Noodle};\nToppings: {toppings};\nExtras: {extras};\n";
        }
    }


}
