using Adventures_Guild;
using Adventures_Guild.Characters;
using Adventures_Guild.Commissions;
using Adventures_Guild.Exceptions;
using Adventures_Guild.Exceptions.Adventures_Guild.Exceptions;
using Adventures_Guild.Helpers;
using Adventures_Guild.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create characters
            PyroCharacter amber = new PyroCharacter("Amber", 2, 5);

            HydroCharacter barbara = new HydroCharacter("Barbara", 3, 8);

            AnemoCharacter venti = new AnemoCharacter("Venti", 5, 10);

            ElectroCharacter lisa = new ElectroCharacter("Lisa", 4, 12);

            CryoCharacter kaeya = new CryoCharacter("Kaeya", 4, 8);

            GeoCharacter noelle = new GeoCharacter("Noelle", 3, 15);

            DendroCharacter nahida = new DendroCharacter("Nahida", 5, 12);

            PyroCharacter diluc = new PyroCharacter("Diluc", 5, 8);

            HydroCharacter xingqiu = new HydroCharacter("Xingqiu", 4, 6);

            CryoCharacter qiqi = new CryoCharacter("Qiqi", 5, 7);

            GeoCharacter ningguang = new GeoCharacter("Ningguang", 4, 10);

            // Create a character selection strategy
            ICharacterSelectionStrategy strategy = new FirstAvailableCharacterStrategy();

            // Create the Adventurers Guild with the selected strategy
            AdventurersGuild guild = new AdventurersGuild(strategy);

            // Add characters to the guild
            guild.AddCharacter(amber);
            guild.AddCharacter(barbara);
            guild.AddCharacter(venti);
            guild.AddCharacter(lisa);
            guild.AddCharacter(kaeya);
            guild.AddCharacter(noelle);
            guild.AddCharacter(nahida);
            guild.AddCharacter(diluc);
            guild.AddCharacter(xingqiu);
            guild.AddCharacter(qiqi);
            guild.AddCharacter(ningguang);

            // Create a list of characters for easy access in the menu
            List<Character> characterList = new List<Character>
            {
                amber,
                barbara,
                venti,
                lisa,
                kaeya,
                noelle,
                nahida,
                diluc,
                xingqiu,
                qiqi,
                ningguang
            };

            // Filter available characters using SearchHelper
            List<Character> availableCharacters =
            SearchHelper.Filter(characterList, character => character.IsAvailable);

            // Create commissions
            Commission cookingCommission = new Commission(
            "Cook Sweet Madame",
            "Prepare a meal for the Adventurers' Guild.",
            "Mondstadt",
            CommissionDifficulty.Easy,
            300,
            ElementType.Pyro);

            cookingCommission.BaseTime = 120;

            Commission liftingCommission = new Commission(
            "Move the Fallen Tree",
            "Move a fallen tree blocking the road.",
            "Windrise",
            CommissionDifficulty.Medium,
            450,
            ElementType.Anemo);

            liftingCommission.RequiredWeight = 40;

            Commission freezingCommission = new Commission(
            "Freeze the River",
            "Keep the river frozen long enough for supplies to cross.",
            "Dragonspine",
            CommissionDifficulty.Medium,
            500,
            ElementType.Cryo);

            freezingCommission.RequiredFreezeTime = 10;

            Commission healingCommission = new Commission(
            "Heal an Injured Adventurer",
            "Help an adventurer recover after a monster attack.",
            "Mondstadt",
            CommissionDifficulty.Easy,
            350,
            ElementType.Hydro);

            healingCommission.CurrentHealth = 20;
            healingCommission.MaxHealth = 100;

            Commission growthCommission = new Commission(
            "Grow Sweet Flowers",
            "Help the local alchemist grow fresh Sweet Flowers.",
            "Springvale",
            CommissionDifficulty.Easy,
            300,
            ElementType.Dendro);

            growthCommission.RequiredGrowth = 12;

            Commission defenseCommission = new Commission(
            "Protect the Caravan",
            "Protect a merchant caravan from incoming attacks.",
            "Stone Gate",
            CommissionDifficulty.Hard,
            600,
            ElementType.Geo);

            defenseCommission.IncomingDamage = 16;

            Commission energyCommission = new Commission(
            "Restore the Ruin Mechanism",
            "Supply enough energy to restart an ancient mechanism.",
            "Stormterror's Lair",
            CommissionDifficulty.Hard,
            650,
            ElementType.Electro);

            energyCommission.RequiredEnergy = 50;

            // Add commissions to the guild
            guild.AddCommission(cookingCommission);
            guild.AddCommission(liftingCommission);
            guild.AddCommission(freezingCommission);
            guild.AddCommission(healingCommission);
            guild.AddCommission(growthCommission);
            guild.AddCommission(defenseCommission);
            guild.AddCommission(energyCommission);

            // Create a list of commissions for easy access in the menu
            List<Commission> commissions = new List<Commission>
            {
                cookingCommission,
                liftingCommission,
                freezingCommission,
                healingCommission,
                growthCommission,
                defenseCommission,
                energyCommission
            };

            // Filter commissions by difficulty using SearchHelper
            List<Commission> hardCommissions =
            SearchHelper.Filter(commissions, commission => commission.Difficulty == CommissionDifficulty.Hard);

            // Main menu loop
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("=== Adventurers' Guild ===");
                Console.WriteLine();
                Console.WriteLine("1. Select commission");
                Console.WriteLine("2. View characters");
                Console.WriteLine("3. View statistics");
                Console.WriteLine("4. Change selection strategy");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Input: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();

                        Console.WriteLine("=== Available Commissions ===");
                        Console.WriteLine();

                        for (int i = 0; i < commissions.Count; i++)
                        {
                            Commission commission = commissions[i];

                            Console.WriteLine($"[{i + 1}] {commission.Name}");
                            Console.WriteLine($"Location: {commission.Location}");
                            Console.WriteLine($"Difficulty: {commission.Difficulty}");
                            Console.WriteLine($"Required element: {commission.RequiredElement}");
                            Console.WriteLine($"Reward: {commission.Reward} Mora");
                            Console.WriteLine();
                        }

                        Console.Write("Select commission: ");
                        string commissionInput = Console.ReadLine();

                        if (int.TryParse(commissionInput, out int commissionNumber))
                        {
                            int commissionIndex = commissionNumber - 1;

                            if (commissionIndex >= 0 && commissionIndex < commissions.Count)
                            {
                                Commission selectedCommission = commissions[commissionIndex];

                                try
                                {
                                    guild.CompleteCommission(selectedCommission, ShowCommissionCompleted);

                                    // The callback can also be written as a lambda expression:
                                    // guild.CompleteCommission(selectedCommission, commission => Console.WriteLine($"Commission completed: {commission.Name}"));
                                }
                                catch (NoSuitableCharacterException exception)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Error: {exception.Message}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid commission number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number.");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();

                        guild.ShowCharacters();

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();

                        Console.WriteLine("=== Guild Statistics ===");
                        Console.WriteLine();

                        Console.WriteLine($"Available characters: {availableCharacters.Count}");
                        Console.WriteLine($"Hard commissions: {hardCommissions.Count}");

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        break;

                    case "4":
                        Console.Clear();

                        Console.WriteLine("=== Selection Strategy ===");
                        Console.WriteLine();
                        Console.WriteLine("1. First available character");
                        Console.WriteLine("2. Highest ascension character");
                        Console.WriteLine();
                        Console.Write("Input: ");

                        string strategyInput = Console.ReadLine();

                        if (strategyInput == "1")
                        {
                            guild.SetSelectionStrategy(new FirstAvailableCharacterStrategy());
                            Console.WriteLine("Strategy changed to First Available.");
                        }
                        else if (strategyInput == "2")
                        {
                            guild.SetSelectionStrategy(new HighestAscensionCharacterStrategy());
                            Console.WriteLine("Strategy changed to Highest Ascension.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void ShowCommissionCompleted(Commission commission)
        {
            Console.WriteLine();
            Console.WriteLine($"Commission completed: {commission.Name}");
            Console.WriteLine($"Reward: {commission.Reward} Mora");
        }
    }
}