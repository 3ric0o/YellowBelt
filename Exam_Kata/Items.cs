namespace Exam_Kata;

    public class Item(string name, string description, int price)
    {
        public string Name { get; } = name;
        public string Description { get; } = description;
        public int Price { get; } = price;
    }
