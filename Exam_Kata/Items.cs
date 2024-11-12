namespace Exam_Kata;

    public class Item
    {
        public string Name { get; }
        public string Description { get; }
        public int Price { get; }

        public Item(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
