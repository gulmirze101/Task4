namespace Task
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get;  set; }
        public string Description { get; set; }
        public Dish[] Dishes { get; set; }

        public Category(int id, string name, string description)
        {
            
            Id = id;
            Name = name;
            Description = description;
            
        }
    }
}
