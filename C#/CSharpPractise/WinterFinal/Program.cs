using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] elective1 = new Student[10];
            elective1[0] = new Student
            {
                Id = 201712001,
                Name = "ARCHAN",
                InSem1Marks = 9,
                InSem2Marks = 15,
                FinalExamMarks = 23
            };
            elective1[1] = new Student
            {
                Id = 201712002,
                Name = "DHRUVIL",
                InSem1Marks = 8,
                InSem2Marks = 17,
                FinalExamMarks = 26
            };
            elective1[2] = new Student
            {
                Id = 201712003,
                Name = "SAHIL",
                InSem1Marks = 4,
                InSem2Marks = 14,
                FinalExamMarks = 3
            };
            elective1[3] = new Student
            {
                Id = 201712004,
                Name = "NILESHKUMAR",
                InSem1Marks = 11,
                InSem2Marks = 16,
                FinalExamMarks = 35
            };
            elective1[4] = new Student
            {
                Id = 201712005,
                Name = "DHRUV",
                InSem1Marks = 10,
                InSem2Marks = 17,
                FinalExamMarks = 33
            };
            elective1[5] = new Student
            {
                Id = 201712006,
                Name = "HIMANSHU",
                InSem1Marks = 10,
                InSem2Marks = 17,
                FinalExamMarks = 24
            };
            elective1[6] = new Student
            {
                Id = 201712007,
                Name = "KISHAN",
                InSem1Marks = 9,
                InSem2Marks = 15,
                FinalExamMarks = 30
            };
            elective1[7] = new Student
            {
                Id = 201712008,
                Name = "YASH",
                InSem1Marks = 7,
                InSem2Marks = 16,
                FinalExamMarks = 17
            };
            elective1[8] = new Student
            {
                Id = 201712009,
                Name = "RASHMI",
                InSem1Marks = 8,
                InSem2Marks = 18,
                FinalExamMarks = 27
            };
            elective1[9] = new Student
            {
                Id = 201712010,
                Name = "SHASHANK",
                InSem1Marks = 14,
                InSem2Marks = 16,
                FinalExamMarks = 25
            };


            foreach (var student in elective1)
            {
                Console.WriteLine("{0} {1} {2} {3}", student.Id, student.Name, student.InSem1Marks, student.InSem2Marks);
            }



            Console.ReadLine();
        }

        
    }

   
}
