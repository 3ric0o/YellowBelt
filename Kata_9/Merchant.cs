namespace Kata_9;

public class Merchant
{
    private string _name;
    private List<string> _items = ["Sword", "Shield", "Potion"];

    public Merchant(string name)
    {
        _name = name;
    }

    public void Trade()
    {
        Console.WriteLine("Merchant's inventory: " + string.Join(", ", _items));
    }
}