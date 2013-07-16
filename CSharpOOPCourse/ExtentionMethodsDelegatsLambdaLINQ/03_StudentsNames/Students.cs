using System;
using System.Linq;


namespace _03_04_05_Students
{
    class Students
    {
        public static void Names(Student[] studArr) 
        {
            var firstBeforeLast=
                from student in studArr
                where student.FirstName.CompareTo(student.LastName)==-1
                select student;
           foreach (var item in firstBeforeLast)
	       {
	       	 Console.Write(item.FirstName + " ");
             Console.WriteLine(item.LastName);
	       }
           
        }

        public static void Ages(Student[] studArr)
        {
            var someStudents =
                from student in studArr
                where (student.Age > 18 && student.Age < 24)
                select student;
            foreach (var item in someStudents)
            {
                Console.Write(item.FirstName + " ");
                Console.WriteLine(item.LastName);
            }
        }

        static void Main(string[] args)
        {
            Student studentOne = new Student("pvan", "pvanov",7);
            Student studentTwo = new Student("avan", "zetrov",25);
            Student studentThree = new Student("zvan", "mi6ov",20);

            Student[] studArr=new Student[3];
            studArr[0] = studentOne;
            studArr[1] = studentTwo;
            studArr[2] = studentThree;

            //Names(studArr);
            //Ages(studArr);

            var sortedLambda= studArr.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            //foreach (var student in sortedLambda)
            //{
            //    Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            //}

            var sortedLINQ =
                from student in studArr
                orderby student.FirstName descending, student.LastName descending
                select student;
            foreach (var student in sortedLINQ)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }
        }
    }
}
