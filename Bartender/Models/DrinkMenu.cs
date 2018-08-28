using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models
{
    public class DrinkMenu
    {
        public List<Beverage> Beverages = new List<Beverage>();

        public DrinkMenu()
        {
            Beverage Mojito = new Beverage();
                Mojito.Name = "Mojito";
                Mojito.AlcContent = 15;
                Mojito.Cost = 9;
                Mojito.Description = "Mojito is a traditional Cuban highball. " +
                    "Traditionally, a mojito is a cocktail that consists of five " +
                    "ingredients: white rum, sugar, lime juice, soda water, and mint.";

            Beverage Sangria = new Beverage();
                Sangria.Name = "Sangria";
                Sangria.AlcContent = 14;
                Sangria.Cost = 12;
                Sangria.Description = "Sangria is an alcoholic beverage of " +
                    "Spanish origin. A punch, the sangria traditionally" +
                    " consists of red wine and chopped fruit. ";

            Beverage Bourbon = new Beverage();
                Bourbon.Name = "Bourbon Whiskey";
                Bourbon.AlcContent = 40;
                Bourbon.Cost = 17;
                Bourbon.Description = "Bourbon whiskey is a type of American " +
                "whiskey, a barrel-aged distilled spirit made " +
                "primarily from corn. ";

            Beverage Champange = new Beverage();
                Champange.Name = "Champange Cocktail";
                Champange.AlcContent = 12;
                Champange.Cost = 11;
                Champange.Description = "A champagne cocktail is an alcoholic " +
                 "drink made with sugar, Angostura bitters, Champagne," +
                " brandy and a maraschino cherry as a garnish. ";

            Beverage French = new Beverage();
                French.Name = "French 75";
                French.AlcContent = 15;
                French.Cost = 14;
                French.Description = "French 75 is a cocktail made from gin, " +
                "Champagne, lemon juice, and sugar. It is also called a 75" +
                " Cocktail, or in French simply a Soixante Quinze.";

            Beverages.Add(Mojito);
            Beverages.Add(Sangria);
            Beverages.Add(Bourbon);
            Beverages.Add(Champange);
            Beverages.Add(French);
        }
    }
}
