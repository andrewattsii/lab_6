using System;

namespace lab_6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Casino ! Roll the dice ? y/n");
            string yesno = Console.ReadLine();

            if (yesno == "n")
            {
                goto tag;
            }
                while (yesno == "y")
                {
                
                  
                    Console.Write("How many sides do you want your dice to be ? ");
                    int userDice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Roll 1:");


                     for (int i = 1; i < 3; i++)
                     {
                       int dice1 = random_class.diceOne(userDice);
                       Console.WriteLine(dice1);
                     }

                    Console.WriteLine("Do you want to roll again ? y/n");
                    string noyes = Console.ReadLine();

                    if(noyes == "n")
                    {
                     goto tag;
                    }
                }
            

            tag:
            Console.WriteLine("Goodbye");




            Console.ReadKey();
        }





        
    }
}
