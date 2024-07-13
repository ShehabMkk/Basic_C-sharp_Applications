//============================================================================================\\
//===================================Assignment_06============================================\\
//============================================================================================\\

using System;
namespace Assignment_07
{
    #region Enums
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    #endregion

    #region Classes
    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }

    public class Employee
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'");
                }
            }
        }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public SecurityLevel Security { get; set; }
        #endregion

        #region Constructors
        public Employee(int id, string name, char gender, double salary, HiringDate hireDate, SecurityLevel security)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            Security = security;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}, Hire Date: {HireDate}, Security Level: {Security}";
        }
        #endregion
    }
    #endregion

    #region Program
    class Assignment_07
    {
        static void Main(string[] args)
        {
            Employee[] Emp = new Employee[3];
            Emp[0] = new Employee(1, "Shehab Mkk", 'M', 41500, new HiringDate(1, 1, 2020), SecurityLevel.DBA);
            Emp[1] = new Employee(2, "Omar K", 'F', 43400, new HiringDate(1, 6, 2021), SecurityLevel.Guest);
            Emp[2] = new Employee(3, "Zezo A", 'M', 44500, new HiringDate(1, 9, 2019), SecurityLevel.SecurityOfficer);

            foreach (var emp in Emp)
            {
                Console.WriteLine(emp);
            }
        }
    }
    #endregion
}
