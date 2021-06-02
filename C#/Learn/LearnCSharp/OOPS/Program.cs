using OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {


            //Student s1 = new Student("Julia", "Roberts");
            //s1.PrintName();

            //Student s2 = new Student();
            //s2.PrintName();


            /* ----- Inheritance Example -------*/

            //FullTimeEmployee fte = new FullTimeEmployee();
            //fte.FirstName = "Julia";
            //fte.LastName = "Roberts";
            //fte.YearlySalary = 50000;
            //((Employee)fte).PrintFullName();        //this will print the printfullname() from base class

            //PartTimeEmployee pte = new PartTimeEmployee();
            //pte.FirstName = "Julia";
            //pte.LastName = "Roberts";
            //pte.HourlySalary = 50000;
            //pte.PrintFullName();

            /* ----- Polymorphism Example ----- */

            //Employee[] e = new Employee[4];

            //e[0] = new Employee();
            //e[1] = new PartTimeEmployee();
            //e[2] = new FullTimeEmployee();
            //e[3] = new TemporaryEmployee();

            //foreach (var emp in e)
            //{
            //    emp.PrintFullName();
            //}


            /* ----- Getters and Setters ----- */

            // GettersAndSetters gs = new GettersAndSetters();
            // gs.x = 10;
            // gs.y = 15;        //throws error as y is read only

            // Console.WriteLine("{0} {1}", gs.x, gs.y);



            /* ----- Interfaces ----- */

            //Customer c = new Customer();
            //c.Print1();

            //ICustomer2 ic = new Customer();
            //ic.Print2();


            /* ----- Delegates ----- */
            //A delegate is a type safe function pointer

            Delegates.Delegate();

            Console.ReadLine();
        }

        
    }
}
