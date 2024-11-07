namespace True_Exam_Kata;

public class Game
{
    private Player? _player;
    private Enemy _shadowCreature = new Enemy("Shadow Creature",100,20,100,100);

    public void GameStart()
    {
        Console.WriteLine("Hi! You will play a quick Text-Based Dungeon Crawler!");
        Thread.Sleep(1000);
        Console.WriteLine("What would you like to name your character?");

        string playerName = GlobalGameMechanics.PlayerNameInput();
        _player = new Player(playerName, 100, 1, 0, 0);

        PlayerPath(ChoosePath(playerName));
    }

    private static int ChoosePath(string playerName)
    {
        Console.WriteLine($"\n{playerName} wants to get to the nearest Town but has a choice to make.\n" +
                          $"\n------------------HARD------------------" +
                          $"\n1. Go the shortest path through a Cave.\n" +
                          $"\n------------------EASY------------------" +
                          $"\n2. Take the longer but safer path by following the main road.\n");

        return GlobalGameMechanics.PlayerInputChoice();
    }
    private void PlayerPath(int input)
    {
        switch (input)
        {
            case 1:
                CavePathPart1();
                break;

            case 2:
                MainRoadPath();
                break;
        }
    }
    
    private void CavePathPart1()
        { 
            Console.WriteLine("You step into the dark cave, its cool air sending a shiver down your spine.");
            Thread.Sleep(1000);
            Console.WriteLine("The light from the entrance fades quickly, and the only sounds are the distant drips of water and the echo of your footsteps.");
            Thread.Sleep(1000);
            Console.WriteLine("Something stirs in the shadows—this path is not without danger.");
            Thread.Sleep(1000);
            Console.WriteLine("Suddenly, a growl cuts through the silence.");
            Thread.Sleep(1000);
            Console.WriteLine("A shadowy figure leaps from the darkness, eyes glowing yellow.");
            Thread.Sleep(1000);
            Console.WriteLine("A Shadow Creature attacks!\n");
            Thread.Sleep(1000);
            CavePathFight1();

            

            // // Item: Dagger of Shadows
            // Console.WriteLine("With the dagger in hand, you press on, feeling slightly more prepared for whatever lies ahead.");
            // Thread.Sleep(1000);
            //
            // Console.WriteLine("The ground beneath you suddenly gives way, and you fall into a deep pit!");
            // Thread.Sleep(1000);
            // Console.WriteLine("Bruised but alive, you search for a way out.");
            // Thread.Sleep(1000);
            //
            // // Challenge to escape the pit
            // // Assume puzzle/escape code here...
            // Console.WriteLine("After some effort, you climb out of the pit, your muscles sore but your resolve strong.");
            // Thread.Sleep(1000);
            //
            // Console.WriteLine("At last, you reach the cave's final chamber.");
            // Thread.Sleep(1000);
            // Console.WriteLine("A massive, scaled Cave Guardian blocks your path, its eyes glowing with ancient fury.");
            // Thread.Sleep(1000);
            //
            // // Combat with the Cave Guardian
            // // Assume combat or decision-making code here...
            // Console.WriteLine("With a mighty roar, the Guardian charges.");
            // Thread.Sleep(1000);
            // Console.WriteLine("The battle is fierce, but you manage to defeat the creature.");
            // Thread.Sleep(1000);
            //
            // Console.WriteLine("You emerge from the cave, battered but victorious, and step into the sunlight.");
            // Thread.Sleep(1000);
            // Console.WriteLine("The town is just ahead. You've survived the Cave Path!");
            // Thread.Sleep(1000);
            // Console.WriteLine("Congratulations, you’ve made it through the Cave Path!");
            
        }
    private void CavePathFight1()
        {
            while(_player is { IsAlive: true } && _shadowCreature.IsAlive)
            {
                GlobalGameMechanics.FightSequence(_player, _shadowCreature);
            }
            if (_player is { IsAlive: false })
            {
                GlobalGameMechanics.GameOver(_player.Name);
            }
            if (!_shadowCreature.IsAlive)
            {
                Console.WriteLine("With a final strike, the creature crumbles into smoke.");
                Thread.Sleep(1000);
                Console.WriteLine("You breathe a sigh of relief, but you know this cave holds more dangers.");
                Thread.Sleep(1000);
                Console.WriteLine("Deeper into the cave, you discover a glimmering chest hidden in a crack in the rock.");
                Thread.Sleep(1000);
                Console.WriteLine("Inside, you find a Dagger of Shadows, a mysterious weapon that hums with power.");
                Thread.Sleep(1000);
            }
        }
    private void MainRoadPath()
        {
            Console.WriteLine("You decide to take the longer, safer route along the main road. \n" +
                              "The sun is shining, and the warm breeze brushes your face as you walk. The road is wide, bordered by trees and fields. \n" +
                              "It's a peaceful journey, but the road is not without its own challenges.\n");

            Console.WriteLine("As you travel, you pass small villages and farms. \n" +
                              "The people here seem friendly, but you can sense an underlying tension in the air. \n" +
                              "There have been rumors of bandits lurking in these parts.\n");

            Console.WriteLine("Suddenly, you hear a rustling from the bushes along the roadside. \n" +
                              "You stop and look around, but it's too late. \n" +
                              "A group of **Bandits** jumps out from the trees, weapons drawn!\n");

            // Combat with Bandits
            // Assume combat code here...
            Console.WriteLine("With quick thinking and skill, you manage to fend off the bandits. \n" +
                              "They retreat into the woods, leaving you with a few scratches and a stolen pouch of gold.\n");

            Console.WriteLine("You continue your journey, now more cautious. \n" +
                              "As night begins to fall, you find a small **Inn** by the side of the road. \n" +
                              "The warm light spilling from the windows seems inviting, and you decide to rest.\n");

            Console.WriteLine("Inside, the innkeeper offers you food and a place to sleep. \n" +
                              "You sit by the fire, relaxing for the first time since entering the wilderness. \n" +
                              "The innkeeper shares stories of travelers who've come through here, some of whom never returned.\n");

            Console.WriteLine("The next morning, you thank the innkeeper, pay your fee, and set out once more. \n");

            // Transition to Town Arrival
            Console.WriteLine(
                "As the sun rises higher in the sky, the road starts to open up. \n" +
                "In the distance, you finally see the outlines of a bustling town.\n" +
                "The road ahead leads to the town gates, where merchants are setting up their stalls and guards patrol the entrance.\n");

            Console.WriteLine(
                "You've made it! The town is just ahead. \n");
        }
}
    
 
