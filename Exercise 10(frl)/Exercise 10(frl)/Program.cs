namespace Exercise_10_frl_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a menu of choices
            int answer= 0;
            while(answer !=5)
            {
                
                
                


                    Console.WriteLine("Hello User, Welcome to The Game. Insert an applicable # to navigate the menu");

                    Console.WriteLine("|----------------------|");
                    Console.WriteLine("1-New Game");
                    Console.WriteLine("2-Load Game");
                    Console.WriteLine("3-Options");
                    Console.WriteLine("4-Credits");
                    Console.WriteLine("5-Exit");
                    Console.WriteLine("|----------------------|");
                    answer = int.Parse(Console.ReadLine());

                    while (answer < 1 || answer > 6)
                    

                    //print response 1
                    if (answer == 1)
                    {
                        Console.WriteLine("Starting a new game...");
                    }
                    if (answer == 2)
                    {
                        Console.WriteLine("Select a File to Load");
                        Console.WriteLine("1-File 1");
                        Console.WriteLine("2-File 2");
                        Console.WriteLine("3-File 3");

                        //print response 2
                        int answer2 = int.Parse(Console.ReadLine());
                        {
                            if (answer2 == 1 || answer2 == 2 || answer2 == 3)
                            {
                                Console.WriteLine("Loading...");

                            }
                        }
                    }
                    //print response 3
                    if (answer == 3)
                    {
                        Console.WriteLine("SFX");
                        Console.WriteLine("Voices");
                        Console.WriteLine("Language");
                        Console.WriteLine("Finished");
                    }
                    {
                        //print response 4
                        if (answer == 4)
                        {
                            Console.WriteLine("Shoutout to Christian, Justin, Micah. Ms. Gallant, Mari, Ari, Bri, Keegan, Trevor, Lyric, Layla, Ben, and lastly the Pikmin gang. Luv u all.");
                        }

                    }


            }
            { 
                if (answer == 5)
                {
                    Console.WriteLine("Thank you so much for playing my game... WAHOOO");
                }
            }

        } 
    }
}