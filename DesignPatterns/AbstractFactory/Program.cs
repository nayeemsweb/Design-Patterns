using AbstractFactory;

var militaryFactory1 = new AmericanMilitaryFactory();
var fighter = militaryFactory1.GetFighter();
var ship = militaryFactory1.GetShip();

Console.ReadKey();