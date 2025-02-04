namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1. I did not like this question very much.
        
        Console.WriteLine("Input an integer:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine("N is non-prime.");
        }
        else
        {
            int n2 = 2;
            while (n2 < n-1)
            {
            if(n%n2 == 0)
            {
                Console.WriteLine("N is non-prime.");
                break;
            }
            n2++;
            }
            if (n%n2 != 0 || n == 2){
            Console.WriteLine("N is prime.");
            }

        }

        
        
  
         //Code for Q2

         Console.WriteLine("Assign an int value to n");
         int n3 = Convert.ToInt32(Console.ReadLine());

         for(int n4 = 0; n4<n3; n4++){
            for(int n5 = 0; n5<n3; n5++)
            {
                Console.Write("#");
            }
              Console.WriteLine("");
         }

        //Code for Q3
        Console.WriteLine("Assign an int value to n");
        int n6 = Convert.ToInt32(Console.ReadLine());

         for(int n7 = 0; n7<n6; n7++){
            for(int n8 = 0; n8<=n7; n8++)
            {
                Console.Write("*");
            }
              Console.WriteLine("");
         }



    }
}
