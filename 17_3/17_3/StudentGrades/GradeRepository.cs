using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _17_3.StudentGrades
{
    public class GradeRepository : IGradeRepository
    {
        string defaultPath = "StudentGrades.xml";

        public GradeRepository(string fileName)
        {
            defaultPath = fileName;
        }
        public GradeRepository()
        {

        }

        public void AddGrade(StudentGrade grade)
        {
            var grades = GetAllGrades();

            grades.Add(grade);
            Save(grades);
        }

        public IList<StudentGrade> GetAllGrades()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<StudentGrade>));

            if (!File.Exists(defaultPath))
            {
                CreateDummyRecords(defaultPath);
            }
            var textReader = File.OpenText(defaultPath);
            var grades = (List<StudentGrade>)serializer.Deserialize(textReader);
            textReader.Close();
            return grades;
        }

        private void CreateDummyRecords(string fileName)
        {
            var studentGrades = new List<StudentGrade>();
            studentGrades.Add(new StudentGrade() { FirstName = "Tuva", LastName = "Westholm", Class = "Youtube for beginners", Grade = "A+", Id = 1 });
            studentGrades.Add(new StudentGrade() { FirstName = "Alfred", LastName = "Westholm", Class = "Babblarna for beginners", Grade = "A+", Id = 2 });
        }

        private void Save(IList<StudentGrade> grades)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<StudentGrade>));
            var writer = File.OpenWrite(defaultPath);
            serializer.Serialize(writer, grades);
            writer.Close();
        }

        
    }
}
