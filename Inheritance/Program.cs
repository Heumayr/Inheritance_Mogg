namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var staff = CreateStaff();

            //Console.WriteLine(CalculateYearlyStaffCost(staff));

            foreach (var person in staff)
            {
                Console.WriteLine(person.Fullname);

                if (person is Employee)
                {
                    var tempEmp = (Employee)person; //Typecast

                    Console.WriteLine($"Gehalt: {tempEmp.Salary} | Bonus: {((Employee)person).Bonus}");
                }
                else if (person is Worker worker) //Typecast in if as variable worker
                {
                    Console.WriteLine($"Daily wage: {worker.DailyWage}");
                }

                Console.WriteLine();
            }
        }

        private static double CalculateYearlyStaffCost(Person[] people)
        {
            return people.Sum(person => person.GetMonthlyIncome()) * 12;
        }

        private static Person[] CreateStaff()
        {
            var emp1 = new Employee()
            {
                SocialSecurityNumber = "2910102910",
                Firstname = "Hugo",
                Lastname = "Balder",
                HireDate = DateTime.Now.AddYears(-20),
                Salary = 2500,
                Bonus = 100
            };

            var emp2 = new Employee()
            {
                SocialSecurityNumber = "2210102920",
                Firstname = "Richard",
                Lastname = "Mogg",
                HireDate = DateTime.Now.AddYears(-29),
                Salary = 3000,
                Bonus = 200
            };

            var worker1 = new Worker()
            {
                SocialSecurityNumber = "3910132910",
                Firstname = "Tina",
                Lastname = "Turner",
                HireDate = DateTime.Now.AddYears(-21),
                DailyWage = 85,
            };

            var worker2 = new Helper()
            {
                SocialSecurityNumber = "4914012910",
                Firstname = "Bibi",
                Lastname = "Blocksberg",
                HireDate = DateTime.Now.AddYears(-26),
                DailyWage = 100,
            };

            var result = new List<Person>();

            result.Add(emp1);
            result.Add(emp2);
            result.Add(worker1);
            result.Add(worker2);

            return result.ToArray();
        }

        private static void ValueVsReference()
        {
            var x = 10;

            var y = x;

            x = 5;

            //Console.WriteLine(y);
            //Console.WriteLine(x);
            Console.WriteLine(x == y);

            var dc = new DemoClass();
            dc.value = 5;

            var dx = dc;

            dc.value = 20;

            Console.WriteLine(dx.value);

            Console.WriteLine(dx.Equals(dc));
        }
    }
}