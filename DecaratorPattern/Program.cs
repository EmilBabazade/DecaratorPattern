using DecaratorPattern.Beverages;
using DecaratorPattern.Beverages.Condiments;

Beverage houseBlend = new HouseBlend();
houseBlend.PrintDescription();
houseBlend = new SteamedMilk(new HouseBlend());
houseBlend.PrintDescription();
var darkRoast = new Mocha(new SteamedMilk(new DarkRoast()));
darkRoast.PrintDescription();
var decaf = new Soy(new Mocha(new SteamedMilk(new Decaf())));
decaf.PrintDescription();
var espresso = new Whip(new Soy(new Mocha(new SteamedMilk(new Espresso()))));
espresso.PrintDescription();