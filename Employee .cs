using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Task_2
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private int salary;

        public int Salary
        {

            get { return salary; }


            set
            {
                if (value >= 0)
                {

                    salary = value ;

                }

            }




        }



        public int CalculateAnnualSalary()
        {

            return Salary * 12;

        }

        public virtual void Displayinfo()

        {

            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"  Age : {Age}    ");
            Console.WriteLine($"  Salary : {Salary} ");



        }

       





    }


    public class Manager : Employee
    {
        public int Bonus { get; set; }

        public override void Displayinfo()
        {
            base.Displayinfo();
            Console.WriteLine($"Bonus: {Bonus}");
        }












    }
     















     
}