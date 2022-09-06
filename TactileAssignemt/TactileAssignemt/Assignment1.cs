
using System;


class AssignmentOneTwo
{

    public static void Main()
    {
        //Tjek test according to writen eksamble 
        // int n = 10;

        //writing test
        /*
        Console.Write("Enter an Maks(typed nr not inkl.): ");
        int n = int.Parse(Console.ReadLine());
        */

        int n = 1000;
        int m = 3;
        Console.Write("assingment 1 " + NaturalMaks(n) + " assignment 2 " + Palindrome(m));


    }



    static int NaturalMaks(int Maks) { 

    
        int InitialNr = 0;
        int Total = 0;

        //calculated all numbers times 3 up to Maks
        for(int i = 0; InitialNr < Maks; i++)
        {
            InitialNr = i * 3;

            if(InitialNr < Maks)
            {
                Total = Total + InitialNr;
            }
            
        }

        //restart process
        InitialNr = 0;

        //calculated all numbers times 5 up to Maks
        for (int i = 0; InitialNr < Maks; i++)
        {
            InitialNr = i * 5;

            if (InitialNr < Maks)
            {
                Total = Total + InitialNr;
            }

        }

        
        return Total;
    }
    static int Palindrome(int n)
        {
        int upper_limit = (int)Math.Pow(10, n) - 1;

        int lower_limit = 1 + upper_limit / 10;

        int max_product = 0;

        for (int i = upper_limit; i >= lower_limit; i--)
        {
            for (int j = i; j >= lower_limit; j--)
            {

                int product = i * j;
                if (product < max_product)
                    break;
                int number = product;
                int reverse = 0;

                while (number != 0)
                {
                    reverse = reverse * 10 + number % 10;
                    number /= 10;
                }

                if (product == reverse && product > max_product)
                    max_product = product;
            }
        }
        return max_product;

    }

    }
