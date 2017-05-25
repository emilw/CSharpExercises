using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _17_3
{
    public partial class Form1 : Form
    {
        StudentGrades.IGradeRepository repository;
        
        public Form1()
        {
            InitializeComponent();
            repository = new StudentGrades.GradeRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void LoadGrades()
        {
            txtOutput.Text = "";
            var grades = repository.GetAllGrades();

            foreach (var grade in grades)
            {
                var gradePrintOut = String.Format("{0}, {1}:\t{2}\t{3}\t{4}{5}", grade.LastName, grade.FirstName, grade.Id, grade.Class, grade.Grade, Environment.NewLine);
                txtOutput.Text += gradePrintOut;
            }
            UpdateStatusText("Grades was loaded");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var newGrade = new StudentGrades.StudentGrade()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Grade = txtGrade.Text,
                Id = Convert.ToInt32(txtId.Text),
                Class = txtClass.Text
            };

            repository.AddGrade(newGrade);
            LoadGrades();
            UpdateStatusText("A new grade was added");
        }

        private void UpdateStatusText(string statusText)
        {
            lblStatusText.Text = String.Format("{0}: {1}",DateTime.Now,statusText);
        }
    }
}
