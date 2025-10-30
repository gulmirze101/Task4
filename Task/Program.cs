

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Category pizzaCat = new Category(1, "Pizza", "Pizzalar");
            Category ickiCat = new Category(2, "İcki", "Soyuq və isti ickilər");

           
            Dish d1 = new Dish(1, "Marqarita", 8.5m, pizzaCat);
            Dish d2 = new Dish(2, "Peperoni", 9.5m, pizzaCat);
            Dish d3 = new Dish(3, "Coca-Cola", 2.0m, ickiCat);

            Restaurant restoran = new Restaurant("Restoran", "Ehmedli");
            restoran.AddDishToMenu(d1);
            restoran.AddDishToMenu(d2);
            restoran.AddDishToMenu(d3);

            Dish[] Sifaris =  { d1, d3 };
            Order sifaris1 = new Order(1, Sifaris);
            restoran.PlaceOrder(sifaris1);

            
            Console.WriteLine($"Restoran: {restoran.Name}");
            Console.WriteLine($"Unvan: {restoran.Address}");
            Console.WriteLine($"Menyuda umumi yemeklerin sayi: {restoran.Menu.Length}");
            Console.WriteLine($"Verilmis sifarislerin sayi: {restoran.Orders.Length}");
            Console.WriteLine($"Sifaris No{restoran.Orders[0].Id}-in umumi meblegi: {restoran.Orders[0].TotalAmount} AZN");

            var pizzalar = Dish.FindDishesByCategory(restoran.Menu, pizzaCat);
            Console.WriteLine("\nPizza kateqoriyasina aid yemekler:");
            foreach (var p in pizzalar)
            {
                Console.WriteLine($"- {p.Name} — {p.Price} AZN");
            }

           
           
        }
    }
}
