//In the game are added lives wich increases with 1 when getting the heart symbol.

using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

//create a structure for the rocks

struct Object
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

//create a structure for the player

struct PlayerObject
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}


class FallingRocks
{
    //a metod for printing the rocks

    static void PrintAtPosition(int x, int y, char c, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    //a method for printing the player

    static void PrintStringOnPosition(int x, int y, string c, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }


    static void Main()
    {
        //remove the console scroolbar

        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 60;

        //arrays that contain all posible symbols and all posible colors for the rocks objects.

        char[] symbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        ConsoleColor[] colors = { ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.DarkCyan, ConsoleColor.DarkYellow, ConsoleColor.Green, ConsoleColor.Gray };

        //creates "player" object

        PlayerObject player = new PlayerObject();
        player.x = Console.WindowWidth / 2 - 2;
        player.y = Console.WindowHeight - 1;
        player.c = "(0)";
        player.color = ConsoleColor.White;

        int lives = 5;

        Random randomGenerator = new Random();

        List<Object> objects = new List<Object>();

        while (true)
        {
            //density is the count of rock objects in one row

            int density = randomGenerator.Next(0, 4);

            //chanse is used for calculating "lives" ratio

            int chance = randomGenerator.Next(0, 100);

            //with the "for" loop, in every "while" term, are created objects which count depends on "density"

            for (int i = 0; i < density; i++)
            {
                int rX = randomGenerator.Next(0, Console.WindowWidth);
                int rC = randomGenerator.Next(0, symbols.Length);
                int rColor = randomGenerator.Next(0, colors.Length);

                if (chance < 4)
                {
                    //create "live" object

                    Object live = new Object();
                    live.x = rX;
                    live.y = 0;
                    live.c = '\u2665';
                    live.color = ConsoleColor.Red;

                    objects.Add(live);
                }
                else
                {
                    //create "rock" object

                    Object FallingRock = new Object();
                    FallingRock.x = rX;
                    FallingRock.y = 0;
                    FallingRock.c = symbols[rC];
                    FallingRock.color = colors[rColor];

                    objects.Add(FallingRock);
                }

            }

            // in every "while" term y++ for every object in "objects" list.
            //"current" is used for exchanging the current item for changing "y".

            for (int j = 0; j < objects.Count; j++)
            {
                Object current = objects[j];

                if (current.y < Console.WindowHeight - 1)
                {
                    current.y++;

                    //compare the object coordinates with the player coordinates, and wether the object is "rock" or "live".
                    //If the coordinates are the same and the object is not "live" live--. Otherwise live++

                    if ((current.x == player.x || current.x == player.x + 1 || current.x == player.x + 2) && current.y == player.y && current.c != '\u2665')
                    {
                        Console.Beep(1900, 500);
                        lives--;
                        objects.Clear();
                    }
                    else if ((current.x == player.x || current.x == player.x + 1 || current.x == player.x + 2) && current.y == player.y && current.c == '\u2665')
                    {

                        lives++;
                        Console.Beep(500, 200);
                        objects[j] = current;
                    }
                    else
                    {
                        objects[j] = current;
                    }

                }
                else
                {
                    objects.Remove(current);
                }
            }

            //prints every object from "objects"

            foreach (Object rock in objects)
            {
                PrintAtPosition(rock.x, rock.y, rock.c, rock.color);
            }

            // if key is pressed and if the key is left or right arrow, moves the player

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable) Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.LeftArrow && player.x > 0)
                {
                    player.x--;
                }
                if (pressedKey.Key == ConsoleKey.RightArrow && player.x < Console.WindowWidth - 3)
                {
                    player.x++;
                }
            }

            PrintStringOnPosition(player.x, player.y, player.c, player.color);

            //Print "lives"

            PrintStringOnPosition(0, 0, "lives: " + lives, ConsoleColor.White);

            //Print message when lives == 0

            if (lives == 0)
            {
                PrintStringOnPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 1, "Game Over!", ConsoleColor.White);
                PrintStringOnPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 + 1, "Press [Enter] to exit", ConsoleColor.White);
                Console.ReadLine();
                Environment.Exit(0);
            }

            Thread.Sleep(150);
            Console.Clear();
        }
    }
}

