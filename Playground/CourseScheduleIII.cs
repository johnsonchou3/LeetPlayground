using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class CourseScheduleIII
    {
        public int ScheduleCourse(int[][] courses)
        {
            var sortedCourses = courses.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray() ;
            var totalTime = 0;
            var coursesCount = 0;
            foreach (var course in sortedCourses)
            {
                if (totalTime + course[0] > course[1])
                {
                    continue;
                }
                else
                {
                    totalTime += course[0];
                    coursesCount += 1;
                }
            }
            return coursesCount;
        }
    }
}
