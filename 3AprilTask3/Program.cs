internal class Program
{
    public static void Main(string[] args)
    {
       /* Develop an employee payroll system using abstraction. Define an abstract class Employee with properties like 
        Name, EmployeeId, and BasicSalary, along with abstract methods like CalculateSalary(). 
        Implement this class by deriving subclasses such as FullTimeEmployee and PartTimeEmployee.
         Override the CalculateSalary() method in each subclass to calculate the salary based on the employee type (e.g.,
         full-time or part-time)*/

    FullTimeEmployee fullTimeEmployee=new FullTimeEmployee("Hikmet",12131,345);
    System.Console.WriteLine($"Full-Time Emplooye {fullTimeEmployee.Name} with id{fullTimeEmployee.EmployeeId},and salary {fullTimeEmployee.BasicSalary}");
   
   

System.Console.WriteLine("**********");
    
    PartTimeEmployee partTimeEmployee=new PartTimeEmployee("Hikmet",123312,345,10,2);
    System.Console.WriteLine($"Part-time employee name-{partTimeEmployee.Name} id-{partTimeEmployee.EmployeeId}, salary-{partTimeEmployee.BasicSalary}, hours work-{partTimeEmployee.HoursWorked} hours price-{partTimeEmployee.HourlyRate}");

//partTimeEmployee.CalculateSalary();
System.Console.WriteLine("*******************************");


    }
}