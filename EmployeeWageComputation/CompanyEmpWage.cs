using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        public string company;
        public int maxWorkingDays, maxWorkingHrs, empPerHrs;
        public int totalEmpWage;
        public CompanyEmpWage(string company,int maxWorkingDays, int maxWorkingHrs, int empPerHrs) 
        {
            this.company = company;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empPerHrs = empPerHrs;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage= totalEmpWage;
        }
        public override string ToString()
        {
            return $"Company: {company} EmpPerRateHrs: {empPerHrs} TotalWage: {totalEmpWage}";
        }
    }
}
