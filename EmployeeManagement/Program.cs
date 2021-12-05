using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {

 
            Player player1 = new Player("Neymar", "Road-7,Banani,Dhaka", 80, 14);
            player1.PrintInfo();
            Employee employee = new Player();
            employee.EmployeeStatus();

            Player player2 = new Player("Neymar", "Road-7,Banani,Dhaka", 60, 9);
            player2.PrintInfo();
            employee.EmployeeStatus();



            Manager manager1 = new Manager("Ronald Koman", "Barcelona, Spain", 3);
            manager1.PrintInfo();
            Employee employee1 = new Manager();
            employee.EmployeeStatus();

            Manager manager2 = new Manager("Zidane", "Madrid, Spain", 7);
            manager2.PrintInfo();
            Employee employee2 = new Manager();
            employee.EmployeeStatus();

            
        }
    }
}
