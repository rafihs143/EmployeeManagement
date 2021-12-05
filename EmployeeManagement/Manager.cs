using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Manager : Employee
    {
        private int yearsOfExperiance;
        public static int counter=1;

      
        
        public int YearsOfExperiance 
        {
            set { this.yearsOfExperiance = value;}
            get { return this.yearsOfExperiance; }
        }
        public Manager()
        {

        }

        public Manager(string employeeName, string address, int yearsOfExperance) : base(employeeName, address)
        {
            this.YearsOfExperiance = yearsOfExperance;
            employeeId = "M-" + Convert.ToString(counter);
            counter++;
        }

        public bool EmployeeStatus()
        {
            if (yearsOfExperiance > 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintInfo()
        {

            Console.WriteLine("Employee ID :" + this.EmployeeId  + "\nEmployee Name : " + this.EmployeeName + "\nAdress : " + this.Address + "\nYears Of Experiance : " + this.YearsOfExperiance + "\n");
            if (EmployeeStatus())
            {
                Console.Write("Eligible for bonus\n\n");
            }
            else
            {
                Console.Write("Not eligible for bonus\n\n");
            }
        }
        
    }
}
