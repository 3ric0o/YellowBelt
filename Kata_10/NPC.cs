namespace Kata_10;

public class Npc : IDialogue
{
    private string _name;
    private readonly string _dialogue = "Welcome to our village!";

    public Npc(string name)
    {
        _name = name;
    }

    public void Dialogue()
    {
        Console.WriteLine($"{_name} says: {_dialogue}");
    }
}