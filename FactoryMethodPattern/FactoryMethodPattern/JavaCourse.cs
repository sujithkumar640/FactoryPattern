using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class JavaCourse : AbstractCourse
    {
        public override void CreateCourseMaterial()
        {
            CourseName = "Java Course";
        }

        public override void CreateSchedule()
        {
            CourseDuration = "Three months";
        }
    }
}
