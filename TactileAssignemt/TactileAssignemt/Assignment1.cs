
using System;


class AssignmentOne
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
        Console.Write(NaturalMaks(n));

        Assignment2.run();

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



}