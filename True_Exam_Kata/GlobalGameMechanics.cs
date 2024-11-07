namespace True_Exam_Kata;

public abstract class GlobalGameMechanics
{
    public static string PlayerNameInput()
    {
        string? nameInput;
        while (true)
        {
            nameInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameInput) || nameInput.Contains(' '))
            {
                Console.WriteLine("Invalid input. Please enter a single word for your character's name.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"Character name set to: {nameInput}");
        Thread.Sleep(1000);
        return nameInput;
    }

    public static int PlayerInputChoice()
    {
        while (true)
        {
            bool validInput = int.TryParse(Console.ReadLine(), out int optionInput);
            if (validInput && optionInput is 1 or 2)
            {
                return optionInput;
            }

            Console.WriteLine("\nInvalid option. Please choose 1 or 2.\n");
        }
    }
    public static void FightSequence(Player player, Enemy enemy)
    {
        int enemyDamage = (enemy.DealDamage(player.Name));
        player.TakeDamage(enemyDamage);
        Console.WriteLine($"{enemy._type} attacks {player.Name} for {enemyDamage} Damage!");
    }
    
    public static void GameOver(string? name)
    {
        Console.WriteLine($"{name} died! - GAME OVER!");
    }
}