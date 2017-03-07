using System;
using System.Collections.Generic;
using System.Threading;

namespace GenericTableOperations
{
    /// <summary>
    /// Driver Class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Driver Method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student studentObj = new Student();
            
            Table<Student> genericTabeObj  = new Table<Student>();


            //Console.WriteLine("Enter the Student Details :");

            //Console.WriteLine("Enter ID:");
            //studentObj.StudentID = Console.ReadLine();

            //Console.WriteLine("Enter Name:");
            //studentObj.StudentName = Console.ReadLine();

            //Console.WriteLine("Enter Age:");
            //studentObj.Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter DateOfBirth:");
            //studentObj.DateOfBirth = Console.ReadLine();

            //Console.WriteLine("Enter Address:");
            //studentObj.Address = Console.ReadLine();

            //genericTabeObj.Insert(studentObj);
            Console.WriteLine("Enter the StudentID you want to Update on");
            studentObj.StudentID = Console.ReadLine(); 
            genericTabeObj.Update(studentObj);

            //List<Student> testList = genericTabeObj.GetList(studentObj);

            //foreach (var item in testList)
            //{
            //    Console.WriteLine(item);
            //}
            genericTabeObj.Delete(studentObj);

   

        }
    }
}
