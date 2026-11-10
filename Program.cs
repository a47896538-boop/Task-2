using System.Xml.Linq;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee em = new Employee();
            em.Name = "Ahmed";
            em.Age = 25;
            em.Salary = 25000;

            em.Displayinfo();
            Console.WriteLine($"Annual Salary={em.CalculateAnnualSalary()}")  ;
            Console.WriteLine( "======================================================");

            Employee em2 = new Employee();
            em2.Name = " Ali";
            em2.Age = 23;
            em2.Salary = 95000;
            em2.Displayinfo();
            Console.WriteLine($"Annual Salary={em2.CalculateAnnualSalary()}");

            Manager m = new Manager();
            m.Name = " hussien";
            m.Age = 20;
            m.Salary = 1000000;
            m.Bonus = 40000;
            m.Displayinfo();
        }


    }
}
