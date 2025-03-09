using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Adventurify");
            Console.WriteLine(
                "Rules are simple\n 1. Name your character\n 2. Choose its type\n 3. Go through all the challenges faced and win the game\n All the best");
            Console.WriteLine("Enter your Character's name: ");
            string charac = Console.ReadLine();
            Console.WriteLine($"Your name is {charac} and it will be used throughout the game");
            int choice;
            Console.WriteLine("Choose your character type: \n1. Warrior\n 2. Wizard\n 3. Archer");
            choice = Int32.Parse(Console.ReadLine());
            if (!Int32.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input, Enter integer");
                return;
            }

            if (choice == 1)
            {
                warrior();
            }
            else if (choice == 2)
            {
                wizard();
            }
            else if (choice == 3)
            {
                archer();
            }
            else
            {
                Console.WriteLine("Enter a valid choice");
            }
        }

        static void warrior()
        {
            Console.WriteLine(
                "Welcome to the warrior world\n You will be faced various challenges throughout the story");
            Console.WriteLine(
                "Since you went for a hunt in the woods, you came across a tiger\n What would you choose?\n 1. Fight\n 2. Flight");
            int choice2 = Int32.Parse(Console.ReadLine());
            if (!Int32.TryParse(Console.ReadLine(), out choice2))
            {
                Console.WriteLine("Invalid input, Provide integer value");
                return;
            }
            if (choice2 == 1)
            {
                fight();
            }
            else if (choice2 == 2)
            {
                flight();
            }
            else
            {
                Console.WriteLine("Enter valid choice");
            }

            void fight()
            {
                Console.WriteLine("Good decision\n You have 2 weapons\n 1. Bow and Arrow\n 2. Sniper rifle");
                int choice3 = Int32.Parse(Console.ReadLine());
                if (!Int32.TryParse(Console.ReadLine(), out choice3))
                {
                    Console.WriteLine("Invalid input, Enter integer value");
                    return;
                }
                if (choice3 == 1)
                {
                    bow_arrow();
                }
                else if (choice3 == 2)
                {
                    sniper_rifle();
                }
                else
                {
                    Console.WriteLine("Enter valid choice input");
                }
                void bow_arrow()
                {
                    int arrows = 3;
                    Console.WriteLine("You have 3 arrows in total");
                    while (arrows > 0)
                    {
                        arrows--;
                        if (arrows == 2)
                        {
                            Console.WriteLine("You still have 2 arrows left, keep trying");
                        }
                        else if (arrows == 1)
                        {
                            Console.WriteLine("You have 1 arrow left");
                        }
                        else if (arrows == 0)
                        {
                            Console.WriteLine("You have exhausted all your arrows\n Game Over!!");
                        }
                    }
                }

                void sniper_rifle()
                {
                    int bullets = 10;
                    Console.WriteLine("You have 10 bullets in your gun\n Use them wisely");
                    while (bullets > 0)
                    {
                        bullets--;
                        if (bullets >= 5)
                        {
                            Console.WriteLine("You have 5 bullets left, make them count");
                        }
                        else if (bullets >= 2)
                        {
                            Console.WriteLine("Watch out, you are almost out");
                        }
                        else if (bullets == 0)
                        {
                            Console.WriteLine("Bullets over\n Game Over!!");
                        }
                    }
                }
            }
            void flight()
            {
                Console.WriteLine("Coward!!!");
            }
        }

        static void wizard()
        {
            Console.WriteLine("Welcome to Wizard world\n All possible magic awaits you!!");
            Console.WriteLine(
                "One fine day, you were taking a walk in a nearby garden, you witnessed a robbery\n Given your powers, you can cast a spell and stop the robbery then and there.\n Remember you are underage to use the magic and if caught, there will be serious consequences including some time in the prison\n Keeping this in mind, what would you thoose? 1. Use Magic \n 2. Call for Help");

            int choice3 = Int32.Parse(Console.ReadLine());
            if (!Int32.TryParse(Console.ReadLine(), out choice3))
            {
                Console.WriteLine("Invalid input, Enter integer value");
                return;
            }
            if (choice3 == 1)
            {
                use_magic();
            }
            else if (choice3 == 2)
            {
                call_help();
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }
            void use_magic()
            {
                int magic = 5;
                Console.WriteLine("You have 5 magic points");
                while (magic > 0)
                {
                    if (magic >= 3)
                    {
                        Console.WriteLine("Be careful, you are low on magic");
                    }
                    else if (magic >= 1)
                    {
                        Console.WriteLine("Opps, last one, make it count");
                    }
                    else if (magic == 0)
                    {
                        Console.WriteLine("Magic exhausted\n Game Over!");
                    }
                }
            }
            void call_help()
            {
                Console.WriteLine(
                    "Good decison ethics wise\n Go run home and come back once you are old enough to do something");
            }
        }

        static void archer()
        {
            Console.WriteLine("Welcome to Archer's world\n You will be faced various challenges including hunting");
            Console.WriteLine("Imagine you are on your way to home where you find yourself surrounded by strange noises\n What would you do?\n 1. Explore and find out\n 2. Continue your journey by choosing a different path");

            int choice4 = Int32.Parse(Console.ReadLine());
            if (!Int32.TryParse(Console.ReadLine(), out choice4))
            {
                Console.WriteLine("Invalid input, Enter integer value");
                return;
            }
            if (choice4 == 1)
            {
                explore();
            }
            else if (choice4 == 2)
            {
                different_path();
            }
            void explore()
            {
                Console.WriteLine("Good yet dangerous decision coz you don't know who can be there\n However you go to explore the area what you observe is that someone is being tied with chains\n You look around to find out there is been a ritual conducted\n What would you do? 1. Stop the ritual\n 2. Run as quickly as possible and report it to the higher authorities");

                int choice5 = Int32.Parse(Console.ReadLine());
                if (!Int32.TryParse(Console.ReadLine(), out choice5))
                {
                    Console.WriteLine("Invalid input, Enter integer value");
                    return;
                }
                if (choice5 == 1)
                {
                    stop_ritual();
                }
                else if (choice5 == 2)
                {
                    report();
                }
                else
                {
                    Console.WriteLine("Enter valid decision number");
                }
                void stop_ritual()
                {
                    int fire = 10;
                    Console.WriteLine("You have 10 fireballs to throw at the ritual and stop it right there\n Remember 4 fireballs are necessary to stop the ritual");
                    while (fire>0)
                    {
                        fire--;
                        if (fire >= 5)
                        {
                            Console.WriteLine("You have 5 fireballs left\n hurry");
                        }
                        else if (fire >= 2)
                        {
                            Console.WriteLine("Carefull, you are almost out");
                        }
                        else if (fire == 0)
                        {
                            Console.WriteLine("All fireballs exhausted\n Game Over!!!");
                        }
                    }
                }
                void report()
                {
                    Console.WriteLine("Good\n Get some proof and go to the concerned authorities");
                }
            }
            void different_path()
            {
                Console.WriteLine("Coward!!!, you are not worthy of the title");
            }
        }
    }
}