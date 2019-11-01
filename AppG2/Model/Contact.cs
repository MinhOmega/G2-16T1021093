using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class Contact
    {
        public string iDContact { get; set; }
        public string nameContact { get; set; }
        public string phoneContact { get; set; }
        public string emailContact { get; set; }

        public string firstCharacter
        {
            get
            {
                return nameContact.Substring(0, 1).ToUpper();
            }
        }
    }
}
