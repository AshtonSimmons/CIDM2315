namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        double p1Salary = p1.GetSalary();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        double p2Salary = p2.GetSalary();

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        double s1Grade = s1.GetGrade();

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        double s2Grade = s2.GetGrade();



        double salaryDif = p1Salary - p2Salary;
        double totalGrade = s1Grade + s2Grade;

        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach}, and the salary is: {p1Salary}");
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach}, and the salary is: {p2Salary}");
        Console.WriteLine($"Student {s1.studentName} enrolls {s1.classEnroll}, and the grade is: {s1Grade}");
        Console.WriteLine($"Student {s2.studentName} enrolls {s2.classEnroll}, and the grade is: {s2Grade}");      
        Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDif}");
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");


    }
}

class Professor
{
   public string profName;
   public string classTeach;
   private double salary;

   public void SetSalary(double salary_amount){
        salary = salary_amount;
   }
   public double GetSalary(){
        return salary;
   }
}

class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
}
