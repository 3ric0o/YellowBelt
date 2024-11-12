using System;
using System.Collections.Generic;

namespace Exam_Kata;

    public class Merchant
    {
        private string _name;
        private readonly List<Item> _inventory;


        public Merchant(string name)
        {
            _name = name;
            _inventory =
            [
                new Item("Potion", "Restores 50 HP.", 100),
                new Item("Sword", "A sharp sword for combat (+20 damage).", 300)
            ];
        }


        public void Talk(Player player)
        {
            Console.WriteLine($"Welcome to my shop, {player.Name}!");
            Console.WriteLine("Feel free to browse my inventory.");
        }

        public int ShowInventory()
        {
            Console.WriteLine("Here are the items available for purchase:\n");
            for (int i = 0; i < _inventory.Count; i++)
            {
                var item = _inventory[i];
                Console.WriteLine($"{i + 1}. {item.Name}: {item.Description} - {item.Price} gold");
            }

            Console.WriteLine("\nDo you want to buy any?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int choice = GlobalGameMechanics.PlayerInputChoice();
            return choice;
        }

        public void SellItem(Player player, int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= _inventory.Count)
            {
                Console.WriteLine("Invalid item selection.");
                return;
            }
            
            Item itemToSell = _inventory[itemIndex];
            
            if (player.SpendGold(itemToSell.Price))
            {
                player.AddItem(itemToSell);
                _inventory.Remove(itemToSell);
                Console.WriteLine($"{player.Name} bought a {itemToSell.Name} for {itemToSell.Price} gold.");
            }
        }
    }
