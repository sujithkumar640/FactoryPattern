using System;
using System.Text;

namespace FactoryMethodPattern
{
    class Program
    {
        private static void Main(string[] args)
        {
            // This is my first GIT program. 
            // Here we trying to develop a requirment using Factory method pattern.
            AbstractCourse objCourse = CourseFactory.CreateCourse();
            Console.ReadKey();
        }
    }
}
