namespace Task
{
    public class Order
    {
        public int Id { get; private set; }
        public Dish[] Dishes { get; private set; }

        public decimal TotalAmount
        {
            get
            {
                decimal total = 0;
                foreach (var d in Dishes)
                    total += d.Price;
                return total;
            }
        }

        public Order(int id, Dish[] dishes)
        {
            Id = id;
            Dishes = dishes;
        }
    }
}
