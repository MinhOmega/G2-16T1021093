using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class Student
    {
        public string IDStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GENDER Gender { get; set; }
        public DateTime DOB { get; set; } // ngày sinh
        public string POB { get; set; } // nơi sinh
        public ICollection<HistoryLearning> ListHistoryLearning { get; set; } // một sinh viên có nhiều HL
    }
    public enum GENDER
    {
        Male, Female, Orther
    }
}
