
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

        /*int n = 1000;
        Console.Write(NaturalMaks(n));*/

        int m = 2;
        Console.Write(Palindrome(m));

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


        // largest number of n-1 digit.
        // One plus this number
        // is lower limit which is
        // product of two numbers.
        int lower_limit = 1 + upper_limit / 10;

        // Initialize result
        int max_product = 0;

        for (int i = upper_limit; i >= lower_limit; i--)
        {
            for (int j = i; j >= lower_limit; j--)
            {
                // calculating product of two
                // n-digit numbers
                int product = i * j;
                if (product < max_product)
                    break;
                int number = product;
                int reverse = 0;

                // calculating reverse of product
                // to check whether it is
                // palindrome or not
                while (number != 0)
                {
                    reverse = reverse * 10 + number % 10;
                    number /= 10;
                }

                // update new product if exist and if
                // greater than previous one
                if (product == reverse && product > max_product)
                    max_product = product;
            }
        }
        return max_product;
    }
    /*
        int Maks = (int)Math.Pow(10, number) - 1;
        int Min = 1 + Maks / 10;

        int result = 0;

        for (int i = Maks; i >= Min; i--)
        {
            for (int j = i; j >= Min; j--)
            {
                //calculations
                int product = i * j;
                if (product < result)
                    break;
                int ProductNumber = product;
                int Check = 0;

                // checking if number is a palindrome

                while (ProductNumber != 0)
                {
                    Check = Check * 10 + ProductNumber % 10;
                    ProductNumber /= 10;
                }

                if (product == ProductNumber && product > result)
                {
                    result = product;
                }
            }
        }

        return result;*/

}

    
