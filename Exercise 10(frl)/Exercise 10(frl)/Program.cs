namespace Exercise_10_frl_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a menu of choices
            Console.WriteLine("Hello User, Welcome to The Game. Insert an applicable # to navigate the menu");

            Console.WriteLine("|----------------------|");
            Console.WriteLine("1-New Game");
            Console.WriteLine("2-Load Game");
            Console.WriteLine("3-Options");
            Console.WriteLine("4-Credits");
            Console.WriteLine("Credits");
            Console.WriteLine("|----------------------|");
            int answer= int.Parse(Console.ReadLine());
            while (answer <1 || answer > 4)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Answer, please enter 1-4");

                Console.WriteLine("Hello User, Welcome to The Game. Insert an applicable # to navigate the menu");
                
                Console.WriteLine("|----------------------|");
                Console.WriteLine("1-New Game");
                Console.WriteLine("2-Load Game");
                Console.WriteLine("3-Options");
                Console.WriteLine("4-Credits");
                Console.WriteLine("Credits");
                Console.WriteLine("|----------------------|");
                answer = int.Parse(Console.ReadLine());
            }

            //print response 
            if (answer == 1)
            {
                Console.WriteLine("Starting a new game...");
            }
            if (answer == 2)
            {
                Console.WriteLine("Select a File to Load");
                Console.WriteLine("1-File 1");
                Console.WriteLine("1-File 2");
                Console.WriteLine("1-File 3");

                int.Parse(Console.ReadLine());
                int answer2 = int.Parse(Console.ReadLine());
                {
                    if (answer2 == 1)
                    {
                        Console.WriteLine("Loading...");
                    }
                }
               
            }
        }
    }
}