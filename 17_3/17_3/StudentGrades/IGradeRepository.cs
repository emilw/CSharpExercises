using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_3.StudentGrades
{
    interface IGradeRepository
    {
        IList<StudentGrade> GetAllGrades();
        void AddGrade(StudentGrade grade);
    }
}
