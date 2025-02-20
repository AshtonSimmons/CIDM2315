namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_method()
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"a = {x}; b={y}");
        int max0 = Q1_Method(x,y);
        Console.WriteLine($"The largest number is: {max0}");

        //Call Q2_method()
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"a = {a}; b={b}; c = {c}; d={d}");
        int max = Q2_Method(a, b, c, d);
        Console.WriteLine($"The largest number is: {max}");

        //Call Q3_method()
        createAccount();
    }

    //Q1 method
    static int Q1_Method(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    //Q2 method
    static int Q2_Method(int a, int b, int c, int d)
    {
       int max1 = Q1_Method(a, b);
       int max2 = Q1_Method(c, d);
       int max = Q1_Method(max1, max2);
       return max;
    }

    //Q3 method
    static bool checkAge(int birth_year){
        int age = 2025 - birth_year;
        if (age>=18){
            return true;
        }
        else{
            return false;
        }
    } 

    static void createAccount()
    {
        Console.WriteLine("Enter Your Username:");
        string user = Console.ReadLine();
        Console.WriteLine("Enter Your Password:");
        string pass = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string passcheck = Console.ReadLine();
        Console.WriteLine("Enter Your Birth Year:");
        int birth_year = Convert.ToInt32(Console.ReadLine());
        bool ofAge = checkAge(birth_year);
        if (ofAge == true){
            if (pass == passcheck){
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else{
            Console.WriteLine("Could not create an account");
        }

    }


}
