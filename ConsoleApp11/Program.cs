using System.Text;

namespace ConsoleApp11 //burada lingq yaptık.
{
    class Person:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int Heigth { get; set; }
        public string City { get; set; }

        public int CompareTo(object? obj)
        {
            Person person = obj as Person;
            if (Age > person.Age)
            {
                return 1;
            }
            if (Age < person.Age)
            {
                return -1;
            }
            return 0;
            if (Salary < person.Salary)
            {
                return -1;
            }
            if (Salary > person.Salary)
            {
                return 1;
            }
            return 0;
            if (Heigth < person.Heigth)
            {
                return -1;
            }
            if (Heigth > person.Heigth)
            {
                return 1;
            }
            return 0;

            //if((Age>person.Age && Age<person.Age) | (Salary>person.Salary && Salary<person.Salary) | (Heigth>person.Heigth && Heigth < person.Heigth))
            //{
            //    return 1;             
            //}
            //return 0;
        }
    }
    internal class Program
    {
        static List<Person> personList = new List<Person>();
        static String[] cities = new[] { "Ankara", "Istanbul", "Bursa", "Eskişehir", "Antalya", "Trabzon" };

        static void Main(string[] args)
        {
            Person p1 = new Person { Age=40};
            Person p2 = new Person { Age=20};
            Console.WriteLine(p1.CompareTo(p2));
            for (int i = 0; i < 100; i++)
            {
                Random r = new Random();
                personList.Add(new Person { Name = "Sümeyra", Age = r.Next(18, 90), City = cities[r.Next(0, 6)], Salary=r.Next(20000,200000), Heigth=r.Next(170,190) });
            }
            personList.Sort();
            IEnumerable<Person> people;
            people = personList.Where(x => x.Salary > 50000);
            //List<Person> people2 = people.ToList();
            people = personList.Where(x => x.City == "Ankara" && x.Age < 30);
            bool found = personList.Exists(x => x.City == "Berlin");
            personList.ForEach(x => x.Age = x.Age * 2);
            Person p3 = personList.Find(x => x.City == "Istanbul");
            Person p4 = personList.Single(x => x.City == "Istanbul");
            Person p5 = personList.SingleOrDefault(x => x.City == "Istanbul", new Person { City = "Istanbul" });
            foreach (var p in people)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("id: {0} ", p.Id);
                sb.AppendFormat("Age: {0}, Salary: {1} ", p.Age, p.Salary);
                sb.AppendLine(" Height" + p.Heigth);
                Console.WriteLine(sb.ToString());
            }
        }
        
    }






}