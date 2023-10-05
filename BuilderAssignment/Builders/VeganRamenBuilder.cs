using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    /// <summary>
    /// This is an interface represeting the steps to build the ramen bowl
    /// </summary>
    public class VeganRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();
        public void settingBroth()
        {
            ramen.Broth = BrothType.Vegan;
        }

        public void settingNoodles()
        {
            ramen.Noodle = NoodleType.Soba;
        }

        public void addingToppings()
        {
            ramen.Toppings.Add(ToppingType.BambooShoots);
            ramen.Toppings.Add(ToppingType.Seaweed);
        }

        public void addingExtras()
        {
            ramen.Extras.Add(ExtraType.NoExtras);
        }
        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
