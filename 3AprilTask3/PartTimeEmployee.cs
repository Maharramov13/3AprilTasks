class PartTimeEmployee:Employee
{
    public double HoursWorked;
    public double HourlyRate;

    public PartTimeEmployee(string name,int employeeId,int basicSalary,int hoursWorked,int hourlyRate){
        Name=name;
        EmployeeId=employeeId;
       BasicSalary=basicSalary; 
       HoursWorked=hoursWorked;
       HourlyRate=hourlyRate;
}

    public override double CalculateSalary()
    {   return HoursWorked*HourlyRate;
        
    }

}