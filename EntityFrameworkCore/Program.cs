using EntityFrameworkCore.Data;
using EntityFrameworkCore.Models;

using PizzaContext context = new PizzaContext();

/*      :  use to add data to database
Product veggieSpecial = new Product
{
    Name = "Special Pizza",
    Price = 9.99M
};
context.Products.Add(veggieSpecial);
Product deluxMeal = new Product
{
    Name = "Delux pizza",
    Price = 12.99M
};
context.Add(deluxMeal);
context.SaveChanges();
*/
//-----------------------------------------------------------





//update data in database
/*
var specialPizza = context.Products
    .Where(i => i.Name == "Special Pizza")
    .FirstOrDefault();

if (specialPizza is Product)
{
    specialPizza.Price = 7.89M;
}
context.SaveChanges();
*/



//Delete data
var deleteAble = context.Products
    .Where(d => d.Name == "Delux pizza")
    .FirstOrDefault();
if(deleteAble is Product)
{
    context.Remove(deleteAble);
}
context.SaveChanges();




// LINQ syntax
var products = from product in context.Products
               where product.Price < 10.00M             // show all pizzas whose price is less then 10
               orderby product.Name
               select product;

foreach (Product p in products)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 19));
}




// Fluent API syntax
/*
var products = context.Products
                               //.Where(x => x.Price > 10.00M)
                               .OrderBy(x => x.Name);
foreach (Product p in products)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
}
*/