using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    class random_class
    {
        public static int diceOne(int num1)
        {
            Random random = new Random();
            return random.Next(1, num1);
        }



    }
}
