namespace MainPiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                WriteChooseOperation();
            }


            static void WriteChooseOperation()
            {
                ConsoleKeyInfo clavisha;
                Console.WriteLine("Переключение между октавами F5 и F6.");
                Console.WriteLine("F3 - выход из программы.");
                clavisha = Console.ReadKey();





                if (clavisha.Key == ConsoleKey.F5)
                {
                    firstoctava();
                }
                else if (clavisha.Key == ConsoleKey.F6)
                {
                    SecondOctavia();
                }
                else if (clavisha.Key == ConsoleKey.F3)
                {
                    Environment.Exit(0);
                }




            }



            static void firstoctava()
            {
                int[] firstOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987, };
                ConsoleKeyInfo clavisha;


                do
                {


                    clavisha = Console.ReadKey();

                    if (clavisha.Key == ConsoleKey.A)
                    {
                        Console.Beep(firstOctave[0], 200);
                    }

                    if (clavisha.Key == ConsoleKey.Q)
                    {
                        Console.Beep(firstOctave[1], 200);
                    }
                    if (clavisha.Key == ConsoleKey.S)
                    {
                        Console.Beep(firstOctave[2], 200);
                    }
                    if (clavisha.Key == ConsoleKey.W)
                    {
                        Console.Beep(firstOctave[3], 200);
                    }
                    if (clavisha.Key == ConsoleKey.D)
                    {
                        Console.Beep(firstOctave[4], 200);
                    }
                    if (clavisha.Key == ConsoleKey.F)
                    {
                        Console.Beep(firstOctave[5], 200);
                    }
                    if (clavisha.Key == ConsoleKey.E)
                    {
                        Console.Beep(firstOctave[6], 200);
                    }
                    if (clavisha.Key == ConsoleKey.G)
                    {
                        Console.Beep(firstOctave[7], 200);
                    }
                    if (clavisha.Key == ConsoleKey.R)
                    {
                        Console.Beep(firstOctave[8], 200);
                    }
                    if (clavisha.Key == ConsoleKey.H)
                    {
                        Console.Beep(firstOctave[9], 200);
                    }
                    if (clavisha.Key == ConsoleKey.T)
                    {
                        Console.Beep(firstOctave[10], 200);
                    }
                    if (clavisha.Key == ConsoleKey.J)
                    {
                        Console.Beep(firstOctave[11], 200);
                    }
                    if (clavisha.Key == ConsoleKey.F3)
                    {
                        Environment.Exit(0);
                    }
                }
                while (clavisha.Key != ConsoleKey.F6);

                SecondOctavia();

            }


            static void SecondOctavia()
            {
                int[] secondOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                ConsoleKeyInfo clavisha;




                do
                {
                    clavisha = Console.ReadKey();

                    if (clavisha.Key == ConsoleKey.A)
                    {
                        Console.Beep(secondOctave[0], 200);

                    }

                    if (clavisha.Key == ConsoleKey.Q)
                    {
                        Console.Beep(secondOctave[1], 200);
                    }
                    if (clavisha.Key == ConsoleKey.S)
                    {
                        Console.Beep(secondOctave[2], 200);
                    }
                    if (clavisha.Key == ConsoleKey.W)
                    {
                        Console.Beep(secondOctave[3], 200);
                    }
                    if (clavisha.Key == ConsoleKey.D)
                    {
                        Console.Beep(secondOctave[4], 200);
                    }
                    if (clavisha.Key == ConsoleKey.F)
                    {
                        Console.Beep(secondOctave[5], 200);
                    }
                    if (clavisha.Key == ConsoleKey.E)
                    {
                        Console.Beep(secondOctave[6], 200);
                    }
                    if (clavisha.Key == ConsoleKey.G)
                    {
                        Console.Beep(secondOctave[7], 200);
                    }
                    if (clavisha.Key == ConsoleKey.R)
                    {
                        Console.Beep(secondOctave[8], 200);
                    }
                    if (clavisha.Key == ConsoleKey.H)
                    {
                        Console.Beep(secondOctave[9], 200);
                    }
                    if (clavisha.Key == ConsoleKey.T)
                    {
                        Console.Beep(secondOctave[10], 200);
                    }
                    if (clavisha.Key == ConsoleKey.J)
                    {
                        Console.Beep(secondOctave[11], 200);
                    }
                    if (clavisha.Key == ConsoleKey.F3)
                    {
                        Environment.Exit(0);
                    }

                }
                while (clavisha.Key != ConsoleKey.F5);

                firstoctava();
            }





        }
    }
}
    
