namespace Exam_Kata;

    public class NPC(string name, string dialogue = "Enjoy your stay in our town!")
    {
        private string _name = name;


        public void Talk(Player player)
        {
            Console.WriteLine($"Welcome {player.Name}!\n" +
                              $"{dialogue}\n");
        }
    }

