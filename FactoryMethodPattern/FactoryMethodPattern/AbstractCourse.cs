using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    abstract class AbstractCourse
    {
        // Class or interface for keeping common behaviour 
        //Properties
        public string CourseDuration { get; set; }
        public string CourseName { get; set; }
        // Abstract Methods
        abstract public void CreateCourseMaterial();
        abstract public void CreateSchedule();
        // Concrete Method
        public void ShowCourseName()
        {
            Console.WriteLine("Course Name is :" + CourseName);
        }
    }
}
