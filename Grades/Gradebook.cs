using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Gradebook
    {
        public Gradebook()
        {
          
        }

        List<float> grades = new List<float>();

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (var grade in grades)
            {
                stats.HighestGade = Math.Max(grade, stats.HighestGade);
                stats.LowestGrade = Math.Min(grade, stats.HighestGade);

                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;           
            return stats;
        }

        

        public void AddGrade(float grade) => grades.Add(grade); 
    }
}
