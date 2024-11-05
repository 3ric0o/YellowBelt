namespace Kata_9;

public class NPC
{
    private string _name;
    private readonly string _dialogue = "Welcome to our village!";

    public NPC(string name)
    {
        _name = name;
    }

    public void Dialogue()
    {
        Console.WriteLine($"{_name} says: {_dialogue}");
    }
}