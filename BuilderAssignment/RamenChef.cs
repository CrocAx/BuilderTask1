﻿using BuilderAssignment.Builders;
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.settingBroth();
            builder.settingNoodles();
            builder.addingToppings();
            builder.addingExtras();

            //TODO#2: Finaly return build bowl of ramen
            return builder.GetRamen();
        }
    }
}
