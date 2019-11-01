using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Model;

namespace AppG2.Controller
{
    public class StudentService
    {
        /// <summary>
        /// ba xoẹt : lấy sinh viên theo mã sinh viên từ mockdata
        /// </summary>
        /// <param name="idStudent"> Mã Sinh Viên</param>
        /// <returns>Sinh viên có max tương ứng hoặc null</returns>
        public static Student GetStudent(string idStudent)
        {
            Student student = new Student
            {
                IDStudent = idStudent,
                FirstName = "Ánh",
                LastName = "Trần Ngọc",
                DOB = new DateTime(1997, 1, 25),
                POB = "Thừa Thiên Huế",
                Gender = GENDER.Male
            };
            student.ListHistoryLearning = new List<HistoryLearning>();
            for(int i=1;i<=12;i++)
            {
                HistoryLearning historyLearning = new HistoryLearning
                {
                    IDHistoryLearning = i.ToString(),
                    YearFrom = 2006 + i,
                    YearTo = 2007 + i,
                    Address = "THPT An Lương Đông",
                    IDStudent = idStudent,

                };
                student.ListHistoryLearning.Add(historyLearning);
            }
            return student;
        }

        /// <summary>
        /// Lấy sinh viên theo mã sinh viên từ File
        /// </summary>
        /// <param name="idStudent"></param>
        /// <param name="pathDataFile"></param>
        /// <returns> Sinh viên theo mã sinh viên hoặc null nếu không thấy</returns>
        public static Student GetStudent(string pathDataFile, string idStudent)
        {
            if (File.Exists(pathDataFile))
            {
                CultureInfo culture = CultureInfo.InvariantCulture;
                //Không quan tâm tới văn hóa lắm
                var listLines = File.ReadAllLines(pathDataFile);
                foreach (var line in listLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    Student student = new Student
                    {
                        IDStudent = rs[0],
                        LastName = rs[1],
                        FirstName = rs[2],
                        Gender = rs[3] == "Male" ? GENDER.Male : (rs[3] == "Female" ? GENDER.Female : GENDER.Other),
                        DOB = DateTime.ParseExact(rs[4], "yyyy-MM-dd", culture),
                        //parseExact là chuyển đổi chính xác cái mình mong muốn
                        //culture là không quan tâm
                        POB = rs[5]
                    };
                    if (student.IDStudent == idStudent)
                        return student;
                }
                return null;
            }
            else
            {
                return null;
            }
            
        }

        public static List<HistoryLearning> GetHistoryLearnings(string pathDataFile, string idStudent)
        {
            if(File.Exists(pathDataFile))
            {
                var ListLines = File.ReadAllLines(pathDataFile);
                List<HistoryLearning> listHistory = new List<HistoryLearning>();
                foreach (var line in ListLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    HistoryLearning history = new HistoryLearning
                    {
                        IDHistoryLearning = rs[0],
                        YearFrom = int.Parse(rs[1]),
                        YearTo = int.Parse(rs[2]),
                        Address = rs[3],
                        IDStudent = rs[4]
                    };
                    if (history.IDStudent == idStudent)
                        listHistory.Add(history);
                }
                return listHistory;
            }
            else
            {
               return null;
            }
           
        }
        public static void CreateHistoryLearnings(string pathHistoryFile, int yearFrom, int yearEnd, string address, string maSinhVien)
        {

            //var IDHistoryLearning = Guid.NewGuid().ToString();
            //var count = StudentService.GetHistoryLearnings(pathHistoryFile, maSinhVien).Count;
            //var IDHistoryLearning = count + 1;
            int c = 0;
            var listHistoryLines = File.ReadAllLines(pathHistoryFile);
            foreach (var line in listHistoryLines)
            {
                var rsHistory = line.Split(new char[] { '#' });
                if (int.Parse(rsHistory[0]) > c)
                {

                    c = int.Parse(rsHistory[0]);
                }

            }
            var IDHistoryLearning = c + 1;
            string lineHistory = IDHistoryLearning + "#" + yearFrom + "#" + yearEnd + "#" + address + "#" + maSinhVien;
            if (File.Exists(pathHistoryFile))
            {
                File.AppendAllText(pathHistoryFile,lineHistory+"\n");
            }
        }
        public static void DeleteHistoryLearning(string pathHistoryFile, string idHistory)
        {
            if (File.Exists(pathHistoryFile))
            {
                var listHistoryLines = File.ReadAllLines(pathHistoryFile);
                //đọc hết file
                File.WriteAllText(pathHistoryFile, "");
                //xóa hết trong file rồi viết lại
                foreach (var lineHistory in listHistoryLines)
                {
                    var rsHistory = lineHistory.Split(new char[] { '#' });
                    if (rsHistory[0] != idHistory)
                    {

                        File.AppendAllText(pathHistoryFile, lineHistory + "\r\n");
                    }
                }

            }
        }
        public static void EditHistoryLearnings(string historyID, string pathHistoryFile, int yearFrom, int yearEnd, string address)
        {
            if (File.Exists(pathHistoryFile))
            {
                var listHistoryLines = File.ReadAllLines(pathHistoryFile);
                File.WriteAllText(pathHistoryFile, "");
                //bool isNextLine = false;
                foreach (var lineHistory in listHistoryLines)
                {
                    var rsHistory = lineHistory.Split(new char[] { '#' });
                    if (rsHistory[0] != historyID)
                    {
                       /* if (!isNextLine)
                        {
                            File.AppendAllText(pathHistoryFile, lineHistory + "\r\n");
                        }
                        else
                        {
                            File.AppendAllText("\r\n" + pathHistoryFile, lineHistory + "\r\n");
                            isNextLine = false;
                        }*/
                        File.AppendAllText(pathHistoryFile, lineHistory + "\r\n");

                    }
                    else
                    {
                        //MessageBox.Show(address);
                        string content = historyID + "#" + yearFrom + "#" + yearEnd + "#" + address + "#" + rsHistory[4];
                        File.AppendAllText(pathHistoryFile, content + "\r\n");
                        //isNextLine = true;
                    }
                }

            }
        }
    }
}
