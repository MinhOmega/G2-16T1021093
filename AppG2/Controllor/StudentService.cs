using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppG2.Model;
namespace AppG2.Controllor
{
    public class StudentService
    {
        /// <summary>
        /// lấy sinh viên theo mã sinh viên
        /// </summary>
        /// <param name="idStudent"></param>
        /// <returns> Sinh viên có mã tương ứng hoặc null </returns>
        public static Student GetStudent(string idStudent) // khởi tạo dữ liệu mẫu Mock Data
        {
            Student student = new Student
            {
                IDStudent = idStudent,
                FirstName = "Minh",
                LastName = "Võ",
                DOB = new DateTime(1998, 2, 5),
                Gender = GENDER.Male
            };
            //student.ListHistoryLearning
            student.ListHistoryLearning = new List<HistoryLearning>();
            for(int i = 0; i < 12; i++)
            {
                HistoryLearning historyLearning = new HistoryLearning
                {
                    IDHistoryLearning = i.ToString(),
                    YearFrom = 2006 + i,
                    YearEnd = 2007 + i,
                    Address = "THCS...",
                    IDStudent = idStudent,

                };
                student.ListHistoryLearning.Add(historyLearning);
            }
            return student;
        }
    }
}
