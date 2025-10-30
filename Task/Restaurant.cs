namespace Task
{
    public class Restaurant
    {
        public string Name { get; private set; }
        public string Address { get; set; }
        public Dish[] Menu { get; private set; }
        public Order[] Orders { get; private set; }

        public Restaurant(string name, string address)
        {
            Name = name;
            Address = address;
            Menu = new Dish[0];
            Orders = new Order[0];
        }

        public void AddDishToMenu(Dish dish)
        {
            Dish[] newMenu = new Dish[Menu.Length + 1];

            for (int i = 0; i < Menu.Length; i++)
            {
                newMenu[i] = Menu[i];
            }

            newMenu[Menu.Length] = dish;
            Menu = newMenu;
        }

        public void PlaceOrder(Order order)
        {
            Order[] newOrders = new Order[Orders.Length + 1];

            for (int i = 0; i < Orders.Length; i++)
            {
                newOrders[i] = Orders[i];
            }

            newOrders[Orders.Length] = order;
            Orders = newOrders;
        }

        public Order GetOrderById(int orderId)
        {
            foreach (var order in Orders)
                if (order.Id == orderId)
                    return order;
            return null;
        }
    }
}
