using System.Linq;
using LINQ;

var listCar = Car.GenerateListOfProducts();

var availableCarsList = listCar.Where(c => c.isAvailable.Equals(true))
    .OrderByDescending(c => c.Price)
    .Select(c => c.Name);
/*foreach (var car in availableCarsList)
{
    Console.WriteLine(car);

}*/

var groupedCarsList = listCar.GroupBy(c => c.isAvailable);

foreach (var group in groupedCarsList)
{
    Console.WriteLine(group.Key + ":" + group.Count());

    foreach (var car in group)
    {
        Console.WriteLine(car);
    }
}

var listOfExpensiveCars = listCar.Where(c => c.Price > 40000 && c.type=="Sport"|| c.type=="Comfort").Select(c => new { c.Name ,c.type} );
/*foreach (var car in listOfExpensiveCars)
{
    Console.WriteLine($"{car.Name} is an expensive and {car.type} car");
}*/

var listOfCheapCars = listCar.Where(c => c.Price <= 30000).Select(c =>new { c.Name, c.type });

/*foreach (var car in listOfCheapCars)
{
    Console.WriteLine($"{car.Name} is an affordable and {car.type} car");
}*/


