//============================================================================================\\
//===================================Assignment_12============================================\\
//============================================================================================\\

namespace Assignment_12;
using System;
using System.Collections.Generic;

#region Employee

public enum LayOffCause
{
    VacationStockNegative,
    AgeAboveSixty
}

public class EmployeeLayOffEventArgs : EventArgs
{
    public LayOffCause Cause { get; set; }

    public EmployeeLayOffEventArgs(LayOffCause cause)
    {
        Cause = cause;
    }
}

public class Employee
{
    public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

    protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
    {
        EmployeeLayOff?.Invoke(this, e);
    }

    public int EmployeeID { get; set; }
    private DateTime birthDate;
    public DateTime BirthDate
    {
        get { return birthDate; }
        set
        {
            birthDate = value;
            if (DateTime.Now.Year - birthDate.Year > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(LayOffCause.AgeAboveSixty));
            }
        }
    }

    private int vacationStock;
    public int VacationStock
    {
        get { return vacationStock; }
        set
        {
            vacationStock = value;
            if (vacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(LayOffCause.VacationStockNegative));
            }
        }
    }

    public bool RequestVacation(DateTime from, DateTime to)
    {
        int requestedDays = (to - from).Days;
        if (VacationStock >= requestedDays)
        {
            VacationStock -= requestedDays;
            return true;
        }
        return false;
    }
    
}

#endregion

//============================================================================================\\

#region Department

public class Department
{
    public int DeptID { get; set; }
    public string DeptName { get; set; }
    private List<Employee> staff = new List<Employee>();

    public void AddStaff(Employee e)
    {
        staff.Add(e);
        e.EmployeeLayOff += RemoveStaff;
    }

    private void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
    {
        Employee employee = sender as Employee;
        if (employee != null)
        {
            staff.Remove(employee);
            Console.WriteLine($"Employee {employee.EmployeeID} removed due to {e.Cause}");
        }
    }
}

#endregion

//============================================================================================\\

public class Program
{
    public static void Main()
    {
        Department department = new Department { DeptID = 1, DeptName = "HR" };
        Employee employee1 = new Employee { EmployeeID = 101, BirthDate = new DateTime(1950, 1, 1), VacationStock = 10 };
        Employee employee2 = new Employee { EmployeeID = 102, BirthDate = new DateTime(1990, 1, 1), VacationStock = 5 };

        department.AddStaff(employee1);
        department.AddStaff(employee2);

        employee1.VacationStock = -1;
        employee2.BirthDate = new DateTime(1940, 1, 1);
    }
}
