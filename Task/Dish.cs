namespace Task
{
    public class Dish
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public Category Category { get; private set; }

        public Dish(int id, string name, decimal price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public static Dish[] FindDishesByCategory(Dish[] dishes, Category category)
        {
            int count = 0;
            foreach (var d in dishes)
                if (d.Category.Id == category.Id)
                    count++;

            Dish[] result = new Dish[count];
            int index = 0;

            foreach (var d in dishes)
                if (d.Category.Id == category.Id)
                    result[index++] = d;

            return result;
        }
        
        public static Dish[] FindDishesByCategoryId(Dish[] dishes, int categoryId)
        {
            int count = 0;
            foreach (var d in dishes)
                if (d.Category.Id == categoryId)
                    count++;

            Dish[] result = new Dish[count];
            int index = 0;

            foreach (var d in dishes)
                if (d.Category.Id == categoryId)
                    result[index++] = d;

            return result;
        }
    }
}
