using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Player : Employee
    {
        private int rating;
        private int wagePerMatch = 1000;
        private int noOfMatch;
        public static int counter = 1;

        public int Rating
        {
            set { this.rating = value; }
            get { return this.rating; }
        }
        public int WagePerMatch
        {
            set { this.wagePerMatch = 1000; }
            get { return this.wagePerMatch; }
        }
        public int NoOfMatch
        {
            set { this.noOfMatch = value; }
            get { return this.noOfMatch; }
        }
        public Player()
        {

        }

        public Player( string employeeName, string address, int rating, int noOfMatch) : base(employeeName, address)
        {
            this.Rating = rating;
            
            this.NoOfMatch = noOfMatch;
            employeeId = "PL-" + Convert.ToString(counter);
            counter++;
        }

        public bool EmployeeStatus()
        {
            if (rating > 70 && noOfMatch >= 10)
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
            Console.WriteLine("Employee ID :" + this.EmployeeId + "\nEmployee Name : " + this.EmployeeName + "\nAdress : " + this.Address + "\nPlayer Rating : " + this.Rating + "%" + "\nWage Per Match : " + this.WagePerMatch + "\nNo of Match : " + this.NoOfMatch + "\n");
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
