namespace SalaryLibrary
{
    public class Employee
    {
        public string EmployeeName;
        public string EmployeeID;
        public double BasicSalary;
        public double Allowance;
        public double Deduction;

        public Employee(string name, string id, double basicSalary, double allowance, double deduction)
        {
            EmployeeName = name;
            EmployeeID = id;
            BasicSalary = basicSalary;
            Allowance = allowance;
            Deduction = deduction;
        }

        public double CalculateGrossSalary()
        {
            return BasicSalary + Allowance;
        }

        public double CalculateTaxRate()
        {
            double gross = CalculateGrossSalary();

            if (gross <= 20000) return 0.05;
            if (gross <= 40000) return 0.10;
            if (gross <= 60000) return 0.15;
            return 0.20;
        }

        public double CalculateTax()
        {
            return CalculateGrossSalary() * CalculateTaxRate();
        }

        public double CalculateNetSalary()
        {
            return CalculateGrossSalary() - CalculateTax() - Deduction;
        }

        public string GetSalaryGrade()
        {
            double gross = CalculateGrossSalary();

            if (gross <= 15000) return "Grade 1";
            if (gross <= 25000) return "Grade 2";
            if (gross <= 40000) return "Grade 3";
            return "Grade 4";
        }
    }
}