using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Human
{
    class Test
    {
        static void Main()
        {
            
            List<Student> students = new List<Student>();

            students.Add(new Student("peco","petkanov",3));
            students.Add(new Student("peco", "pecov", 3));
            students.Add(new Student("peco", "kolev", 4));
            students.Add(new Student("peco", "mitkov", 5));
            students.Add(new Student("peco", "bacov", 6));
            students.Add(new Student("peco", "petrankin", 2));
            students.Add(new Student("peco", "mihov", 5));
            students.Add(new Student("peco", "puckov", 4));
            students.Add(new Student("peco", "pecov", 3));
            students.Add(new Student("peco", "penov", 2));

            var studentsByGrade = students.OrderBy(x => x.Grade);
            foreach (var item in studentsByGrade)
            {
                Console.WriteLine(item.Grade);
            }

            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("dragan", "cankov", 300,7));
            workers.Add(new Worker("petar", "beron", 500,7));
            workers.Add(new Worker("ivan", "vazov", 400, 7));
            workers.Add(new Worker("hristo", "botev", 500, 7));
            workers.Add(new Worker("baba", "iliica", 600, 7));
            workers.Add(new Worker("strina", "pena", 200, 7));
            workers.Add(new Worker("vasil", "levski", 500, 7));
            workers.Add(new Worker("botio", "petkov", 400, 7));
            workers.Add(new Worker("geo", "milev", 300, 7));
            workers.Add(new Worker("elin", "pelin", 200, 7));

            var workersBySalary = workers.OrderByDescending(x=>x.MoneyPerHour(x.WeekSalary,x.WorkHoursPerDay));

            foreach (var item in workersBySalary)
            {
                Console.WriteLine(item.MoneyPerHour(item.WeekSalary,item.WorkHoursPerDay));
            }

            var bothListsMerged = students.Union<Human>(workers).ToList();

            var mergedFinal = bothListsMerged.OrderBy(x => x.FirstName).OrderBy(x => x.LastName);

            foreach (var item in mergedFinal)
            {
                Console.WriteLine(item.FirstName + "  " + item.LastName);
            }
        }
    }
}
