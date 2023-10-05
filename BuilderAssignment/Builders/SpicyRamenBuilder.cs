using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    /// <summary>
    /// This is an interface represeting the steps to build the ramen bowl
    /// </summary>
    public class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();
        public void settingBroth()
        {
            ramen.Broth = BrothType.SpicyTonkotsu;
        }

        public void settingNoodles()
        {
            ramen.Noodle = NoodleType.Thin;
        }

        public void addingToppings()
        {

            ramen.Toppings.Add(ToppingType.ChashuPork);
            ramen.Toppings.Add(ToppingType.GreenOnions);
        }

        public void addingExtras()
        {
            ramen.Extras.Add(ExtraType.ExtraSpice);
        }
        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
