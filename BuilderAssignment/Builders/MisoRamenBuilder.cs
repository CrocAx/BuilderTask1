using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    /// <summary>
    /// This is a MisoRamenBuilder
    /// </summary>
    public class MisoRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();
        public void settingBroth()
        {
            ramen.Broth = BrothType.Miso;
        }

        public void settingNoodles()
        {
            ramen.Noodle = NoodleType.Udon;
        }

        public void addingToppings()
        {
            ramen.Toppings.Add(ToppingType.GreenOnions);
        }

        public void addingExtras()
        {
            ramen.Extras.Add(ExtraType.Corn);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
