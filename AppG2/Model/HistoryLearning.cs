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
        public int YearTo { get; set; }
        public string Address { get; set; }
        public string IDStudent { get; set; }
        public Student Student { get; set; }
        public string Period
        {
            get
            {
                return string.Format("Từ năm {0} đến năm {1}", YearFrom, YearTo);
            }
        }
    }
}
