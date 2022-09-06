
using System;


class AssignmentOne
{
    

    static int NaturalMaks(int Maks) { 

    
        int InitialNr = 0;
        int Total = 0;

        for(int i = 0; InitialNr < Maks; i++)
        {
            InitialNr = i * 3;

            if(InitialNr < Maks)
            {
                Total = Total + InitialNr;
            }
            
        }

        InitialNr = 0;

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

    public static void Main()
    {

        Console.Write("Enter an Maks(typed nr not inkl.): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write(NaturalMaks(n));
    }


}