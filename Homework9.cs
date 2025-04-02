namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }

        Dictionary<string, double> gradebook = new Dictionary<string, double>();

        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if (gradebook.ContainsKey("Tom") == false){
            gradebook.Add("Tom", 3.3);
        }

        double sum = 0;
        double average = 0;
        double count = gradebook.Count;
        

        foreach(var stu in gradebook){
            sum = sum + stu.Value;
            average = sum/count;
            
        }

        Console.WriteLine($"The average GPA is: {average}");

        foreach(var stu in gradebook){
            if(stu.Value > average){
                Console.WriteLine($"Student Name: {stu.Key}");
            }
        }

    }
}

class Student
{
    public static List<Student> student_list = new List<Student>();
    private int studentID {get; set;}
    private string studentName {get; set;}

    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }
}
