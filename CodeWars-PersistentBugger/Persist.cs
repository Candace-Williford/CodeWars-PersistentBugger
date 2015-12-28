using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_PersistentBugger
{
    public static class Persist
    {
        public static int Persistence(int num)
        {
            int persistence = 0;

            if (num >= 0) //make sure the number is not negative
            {
                while (num > 9) //while the number is not a single digit
                {
                    char[] numbers = num.ToString().ToCharArray(); //Separate numbers so you can multiply them individually
                    num = MultiplyNumbers(numbers);
                    persistence++;
                }

                return persistence;
            }
            else
            {
                return 0;
            }
        }

        public static int MultiplyNumbers(char[] numbers)
        {
            int number = 1; //set to 1 so it won't always equal zero

            foreach(char n in numbers)
            {
                number *= (int)Char.GetNumericValue(n);
            }

            return number;
        }
    }
}

//Write a function, persistence, that takes in a positive parameter num and returns 
//its multiplicative persistence, which is the number of times you must multiply the 
//digits in num until you reach a single digit.

//For example:

//persistence(39) == 3  //because 3*9 = 27, 2*7 = 14, 1*4=4
//                      //and 4 has only one digit

//persistence(999) == 4 //because 9*9*9 = 729, 7*2*9 = 126,
//                      //1*2*6 = 12, and finally 1*2 = 2

//persistence(4) == 0   //because 4 is already a one-digit number