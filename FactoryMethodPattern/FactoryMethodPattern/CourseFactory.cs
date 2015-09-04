using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class CourseFactory
    {
        public static AbstractCourse CreateCourse()
        {
            // Think that this is Business logic 

            AbstractCourse objCourse = null;
            Console.WriteLine("we are doing simple factory pattern");
            switch (Console.ReadLine())
            {
                case "J":
                    objCourse = new JavaCourse();
                    break;
                case "N":
                    objCourse = new NetCourse();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            // Lets see which course seleted
            objCourse.CreateCourseMaterial();
            objCourse.CreateSchedule();
            objCourse.ShowCourseName();
            return objCourse;
        }
    }
}
