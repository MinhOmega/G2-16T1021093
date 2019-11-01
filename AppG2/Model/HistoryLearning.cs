using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class HistoryLearning
    {
        public string IDHistoryLearning { get; set; }
        public int YearFrom { get; set; }
<<<<<<< HEAD
        public int YearTo { get; set; }
        public string Address { get; set; }
        public string IDStudent { get; set; }
        public Student Student { get; set; }
=======
        public int YearEnd { get; set; }
        public string Address { get; set; }
        public string IDStudent { get; set; }
        public Student Student { get; set; } // một HL chỉ thuộc về 1 sinh viên
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
        public string Period
        {
            get
            {
<<<<<<< HEAD
                return string.Format("Từ năm {0} đến năm {1}", YearFrom, YearTo);
=======
                return string.Format("{0} -> {1}", YearFrom, YearEnd);
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            }
        }
    }
}
