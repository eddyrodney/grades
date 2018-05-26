using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGade = 0;
            LowestGrade = float.MaxValue;
        }

        public float AverageGrade, HighestGade, LowestGrade;
    }
}
