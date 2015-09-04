using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class NetCourse : AbstractCourse
    {
        public override void CreateCourseMaterial()
        {
            CourseName = ".NET Course";
        }

        public override void CreateSchedule()
        {
            CourseDuration = "Six months";
        }
    }
}
