using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void HelloFunctionDelegate(string Message);

namespace OOPS
{
    class Delegates
    {
        public static void Delegate()
        {
            // HelloFunctionDelegate hfd = new HelloFunctionDelegate(Hello);
            // hfd("Hello");

            List<Employees> empList = new List<Employees>();
            empList.Add(new Employees() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employees() { ID = 102, Name = "John", Salary = 51000, Experience = 4 });
            empList.Add(new Employees() { ID = 103, Name = "Jack", Salary = 15000, Experience = 6 });
            empList.Add(new Employees() { ID = 104, Name = "Jill", Salary = 10000, Experience = 3 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            //Employees.PromoteEmployee(empList, isPromotable);

            Employees.PromoteEmployee(empList, emp => emp.Experience >= 5);

        }

      /*  public static bool Promote(Employees emp)
        {
            if (emp.Experience >= 5) return true;
            else return false;
        }*/
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

    delegate bool IsPromotable(Employees empl);

    class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        
        public static void PromoteEmployee(List<Employees> empList, IsPromotable IsEligibleToPromote)
        {
            foreach (var e in empList)
            {
                if(IsEligibleToPromote(e))
                {
                    Console.WriteLine(e.Name + " promoted");
                }
      
            }
        }
    }
}
