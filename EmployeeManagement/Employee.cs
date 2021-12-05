using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EmployeeManagement
{
   abstract class Employee
    {
        public string employeeId;
        private string employeeName;
        private string address;

        public string EmployeeId
        {
            set { this.employeeId = value; }
            get { return this.employeeId; }
        }
        public string EmployeeName
        {
            set { this.employeeName = value; }
            get { return this.employeeName; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public Employee()
        {

        }
        public Employee(string employeeName, string address)
        {
            
            this.EmployeeName = employeeName;
            this.Address = address;
        }
        public void PrintInfo()
        {
            Console.WriteLine( "\nEmployee Name : " + this.EmployeeName + "\nAddress : " + this.Address + "\n");
        }

        public void EmployeeStatus() 
        {
        }

    }
}
