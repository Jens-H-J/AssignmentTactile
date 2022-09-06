using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Assignment2
{
    public static void Main()
    {
        //Test to check according to the eksamble
        int n = 2;
        Console.Write(Palindrome(n));

    }

    static int Palindrome(int n)
    {   
        int result = 0;

        int Maks = (int)Math.Pow(10, n) - 1;
        int Min = 1 + Maks / 10;

       for (int i = Maks; i >= Min; i--)
        {
            for (int j = i; j >= Min; j--)
            {
                //calculations
                int product = i * j;
                if (product < Maks)
                    break;
                int ProductNumber = product;
                

                // checking if number is a palindrome
                int Check = 0;
                while(ProductNumber != 0)
                {
                    Check = Check * 10 + ProductNumber % 10;
                }
            }
        }
        

        return result;

    }

}
