class FullTimeEmployee:Employee
{
    public FullTimeEmployee(string name,int  employeeId,int basicSalary){
        Name=name;
        EmployeeId=employeeId;
        BasicSalary=basicSalary;
    }
    public override double CalculateSalary()
    {
        return BasicSalary;
    }

}