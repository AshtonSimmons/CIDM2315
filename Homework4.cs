namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //call method for Q1
        Console.WriteLine("Please Enter 2 Integers");
        Q1_Method(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
        //call method for Q2
        Console.WriteLine("Please Enter an Integer and a Shape (Right or Left)");
        Q2_Method(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
    }

    static void Q1_Method(int a, int b)
    {
        Console.WriteLine($"a = {a}, b={b}");
        if (a>b)
        {
            Console.WriteLine($"The largest number is: {a}");
        }
        else
        {
            Console.WriteLine($"The largest number is: {b}");
        }
    }

    static void Q2_Method(int N, string shape)
    {
        if(shape == "right" || shape == "Right")
        {
            Console.WriteLine($"N is: {N}, shape is {shape}");
            
            int x,y,z; 
             
            for (x = 1; x <= N; x++)  
            {  
                for (y = 1; y <= N-x; y++)  
                {  
                    Console.Write(" ");  
                }  
                for (z = 1; z <= x; z++)  
                {  
                    Console.Write("*");  
                }  
                Console.WriteLine("");  
            }  
        }
        if(shape == "left" || shape == "Left")
        {
            Console.WriteLine($"N is: {N}, shape is {shape}");
            int x,y; 
 
            for (x = 1; x <= N; x++)  
            {  
                for (y = 1; y <= x; y++)  
                {  
                    Console.Write("*");  
                }  
            Console.WriteLine("");  
            }
        }
        if(shape != "right" && shape !="left" && shape != "Right" && shape != "Left")
        {
            Console.WriteLine("Invalid entry, please try again");
        }
    }
}
