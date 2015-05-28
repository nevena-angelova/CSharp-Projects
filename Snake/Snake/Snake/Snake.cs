using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;


namespace Snake
{
    struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Program
    {
        static void Main()
        {

            int lives = 3;
            int scores = 0;

            Console.WindowWidth = 35;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;

            Queue<Position> snakeElements = new Queue<Position>();

            SetDefaultSnakElements(snakeElements);

            Position apple = GenerateRandomElement();
            int startAppleCount = DateTime.Now.Second; // used in generating apple in an interval

            List<Position> obstacles = new List<Position>();
            int startObstaclesCount = DateTime.Now.Second; // used in generating obsacles in an interval

            Position[] directions = new Position[]
            {
                new Position(1, 0), // right
                new Position(-1, 0), // left
                new Position(0, 1), // down
                new Position(0, -1) // top
            };

            byte right = 0;
            byte left = 1;
            byte down = 2;
            byte up = 3;

            byte direction = right;

            while (true)
            {
                // if key pressed set the direction depending on the pressed key

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();

                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        if (direction != right)
                        {
                            direction = left;
                        }
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (direction != left)
                        {
                            direction = right;
                        }
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        if (direction != up)
                        {
                            direction = down;
                        }
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        if (direction != down)
                        {
                            direction = up;
                        }
                    }
                }

                // adds new snake element relevent to the new direction

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position newSnakeHead = new Position(snakeHead.x + nextDirection.x, snakeHead.y + nextDirection.y);

                // check wether the snake eat the apple if not, removes an element from the tail

                if (newSnakeHead.x == apple.x && newSnakeHead.y == apple.y)
                {
                    apple = GenerateRandomElement();
                    startAppleCount = DateTime.Now.Second;
                    Console.Beep(2000, 100);
                    scores += 10;
                }
                else
                {
                    snakeElements.Dequeue();
                }

                // if the interval becomes 8 seconds, generates a new apple

                int endAppleCount = DateTime.Now.Second;
                int intervalApple = endAppleCount - startAppleCount;

                if (intervalApple == 8)
                {

                    do // make shure that the new apple would not be at the snake position
                    {
                        apple = GenerateRandomElement();
                        startAppleCount = endAppleCount;
                    }
                    while (snakeElements.Contains(apple) && obstacles.Contains(apple));

                }

                // if the interval becomes 5 seconds, generates a new apple

                int endObstaclesCount = DateTime.Now.Second;
                int intervalObstacles = endObstaclesCount - startObstaclesCount;

                if (intervalObstacles == 5)
                {
                    // make shure that the new obstacle would not be at the snake position

                    do
                    {
                        obstacles.Add(GenerateRandomElement());
                        startObstaclesCount = endObstaclesCount;

                    }

                    while (snakeElements.Contains(obstacles.Last())); // the condition is about the snake elements and the last eventualy generated obstacle

                }

                Console.Clear(); // clear the console. Bellow all the elements are drawn


                foreach (Position obstacle in obstacles)
                {
                    Draw(obstacle, '=', ConsoleColor.Gray);
                }

                Draw(apple, '@', ConsoleColor.Yellow);

                // catch the exeption when the new snake head is attempted to be drwan out of the boundaries of the console

                try
                {
                    // throws an exception if the snake goes trough itself or crashes into an obstecle

                    if (snakeElements.Contains(newSnakeHead) || obstacles.Contains(newSnakeHead))
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    snakeElements.Enqueue(newSnakeHead);
                    DrawSnake(snakeElements);
                }
                catch (ArgumentOutOfRangeException)
                {

                    if (lives == 0)
                    {
                        Console.Beep(500, 1000);
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Game Over!");
                        Console.WriteLine();
                        Console.WriteLine("Your points are: {0}", scores);
                        Console.WriteLine();
                        Console.WriteLine("Ranking:");                    

                        List<int> allScores = new List<int>();
                        allScores.Add(scores); // adds the current score

                        try
                        {
                            StreamReader reader = new StreamReader("scores.txt");
                            using (reader)
                            {
                                string line = reader.ReadLine();

                                while (line != null)
                                {
                                    allScores.Add(int.Parse(line)); // adds all scores from the text file
                                    line = reader.ReadLine();
                                }
                            }
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Path is null.");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters");
                        }
                        catch (PathTooLongException)
                        {
                            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
                        }
                        catch (DirectoryNotFoundException)
                        {
                            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("The file specified in path was not found. ");
                        }
                        catch (IOException)
                        {
                            Console.WriteLine("An I/O error occurred while opening the file.");
                        }
                        catch (UnauthorizedAccessException)
                        {
                            Console.WriteLine("path specified a file that is read-only.");
                            Console.WriteLine("-or-");
                            Console.WriteLine("This operation is not supported on the current platform.");
                            Console.WriteLine("-or-");
                            Console.WriteLine("path specified a directory.");
                            Console.WriteLine("-or-");
                            Console.WriteLine("The caller does not have the required permission.");
                        }
                        catch (NotSupportedException)
                        {
                            Console.WriteLine("Path is in an invalid format.");
                        }
                        catch (System.Security.SecurityException)
                        {
                            Console.WriteLine("The caller does not have the required permission.");
                        }
                        allScores.Sort();

                        StreamWriter writer = new StreamWriter("scores.txt");

                        using (writer)
                        {

                            for (int i = allScores.Count - 1; i >= 0; i--)
                            {
                                Console.WriteLine(allScores[i]);
                                writer.WriteLine(allScores[i]); // writes all scores from the list to the text file
                            }
                        }

                        Console.WriteLine();

                        return;
                    }
                    else
                    {
                        Console.Beep(500, 500);

                        snakeElements.Clear();
                        direction = right;
                        startObstaclesCount = DateTime.Now.Second;
                        SetDefaultSnakElements(snakeElements);

                        lives--;
                    }

                }

                DrawLives(lives);

                Thread.Sleep(150);
            }
        }

        // set default snake elements

        static void SetDefaultSnakElements(Queue<Position> elements)
        {
            for (int i = 0; i < 6; i++)
            {
                elements.Enqueue(new Position(i, 0));
            }
        }

        // draw all kind of "Position" elements

        static void Draw(Position element, char symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(element.x, element.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        // draw the snake

        static void DrawSnake(Queue<Position> snake)
        {
            foreach (Position element in snake)
            {
                Draw(element, '*', ConsoleColor.Cyan);
            }
        }

        // generates ramdom "Position" elements 

        static Position GenerateRandomElement()
        {
            Random randomGenerator = new Random();
            Position element = new Position(randomGenerator.Next(0, Console.WindowWidth), randomGenerator.Next(0, Console.WindowHeight));
            return element;
        }

        // draw lives

        static void DrawLives(int lives)
        {
            Console.SetCursorPosition(Console.WindowWidth - 9, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Lives: {0}", lives);
        }

    }
}