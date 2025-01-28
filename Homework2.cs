namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.WriteLine("Please input a letter grade:");
        string letter_grade = Console.ReadLine();

        if(letter_grade == "A"){
            Console.WriteLine("GPA Point: 4");
        }
        else if(letter_grade == "B"){
            Console.WriteLine("GPA Point: 3");
        }
        else if(letter_grade == "C"){
            Console.WriteLine("GPA Point: 2");
        }
        else if(letter_grade == "D"){
            Console.WriteLine("GPA Point: 1");
        }
        else if(letter_grade == "F"){
            Console.WriteLine("GPA Point: 0");
        }
        else{
            Console.WriteLine("Wrong Letter Grade!");
        }

        // Code for Q2
        Console.WriteLine("Please input the first num:");
        string num_1 = Console.ReadLine();
        Console.WriteLine("Please input the second num:");
        string num_2 = Console.ReadLine();
        Console.WriteLine("Please input the third num:");
        string num_3 = Console.ReadLine();

        int x = Convert.ToInt16(num_1);
        int y = Convert.ToInt16(num_2);
        int z = Convert.ToInt16(num_3);

        if(x<y){
            if(x<z){
                Console.WriteLine($"The smallest value is {x}");
            }
            else{// meaning y > x > z
                Console.WriteLine($"The smallest value is {z}");
            }
        }
        else{// meaning x > y
            if(y<z){// meaning x > z > y
                Console.WriteLine($"The smallest value is {y}");
            }
            else{//meaning x > y > z
                Console.WriteLine($"The smallest value is {z}");
            }

        }

        // Code for Bonus Question
        Console.WriteLine("Please input a year:");
        string inp_year = Console.ReadLine();
        
        int year = Convert.ToInt16(inp_year);

        if(year% 4 == 0){//year is evenly divisible by 4
            if(year% 100 == 0){//year is evenly divisible by 100
                if(year% 400 == 0){//year is evenly divisible by 400
                    Console.WriteLine($"{year} is a leap year");
                }
                else{//not evenly divisible by 400
                    Console.WriteLine($"{year} is not a leap year");
                }
            }
            else{//year is not evenly divisible by 100
                Console.WriteLine($"{year} is a leap year");
            }
        }
        else{//cannot be divided into 4
            Console.WriteLine($"{year} is not a leap year");
        }


    }
}
