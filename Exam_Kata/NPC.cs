namespace Exam_Kata;

    public class NPC
    {
        private string _name;
        private string _dialogue;
        
        public NPC(string name, string dialogue = "Enjoy your stay in our town!")
        {
            _name = name;
            _dialogue = dialogue;
        }

        
        public void Talk(Player player)
        {
            Console.WriteLine($"Welcome {player.Name}!\n" +
                              $"{_dialogue}\n");
        }
    }

