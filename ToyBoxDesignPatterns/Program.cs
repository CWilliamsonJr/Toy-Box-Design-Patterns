// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using ToyBoxDesignPatterns.Filters;
using ToyBoxDesignPatterns.Models;
using ToyBoxDesignPatterns.Specifications;



var toys = new List<Toy>
{
    new() {Name = "Teddy Bear", Color = "Brown", Size = 10, Age = 3},
    new() {Name = "LEGO Set", Color = "Multi-Colored", Size = 20, Age = 6},
    new() {Name = "Doll", Color = "Pink", Size = 15, Age = 4}
};

var colorSpec = new ColorSpecification("Pink");
var sizeSpec = new SizeSpecification(15);
var ageSpec = new MinAgeSpecifciation(4);

var toyFilter = new ToyFilter();

var pinkToys = toyFilter.Filters(toys, colorSpec);
var smallToys = toyFilter.Filters(toys, sizeSpec);
var ageAppropriateToys = toyFilter.Filters(toys, ageSpec);

PrintToys("Pink Toys", pinkToys);
PrintToys("Small Toys", smallToys);
PrintToys("Age appropritate toys", ageAppropriateToys);


Console.ReadLine();
static void PrintToys(string label, IEnumerable<Toy> toys)
{
    Console.Write($"{label}: ");

    foreach (var toyName in toys.Select(x => x.Name))
    {
        Console.Write(toyName);

        if (toyName == toys.Last().Name)
        {
            Console.WriteLine();
        }
        else
        {
            Console.Write(", ");
        }
    }
}


