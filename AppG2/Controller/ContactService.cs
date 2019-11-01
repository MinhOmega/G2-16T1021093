using AppG2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Controller
{
    public class ContactService
    {
        public static List<Contact> GetContact(string pathDataFile)
        {
            if (File.Exists(pathDataFile))
            {
                var ListLines = File.ReadAllLines(pathDataFile);
                List<Contact> listContact = new List<Contact>();
                foreach (var line in ListLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    Contact contact = new Contact
                    {
                        iDContact = rs[0],
                        nameContact = rs[1],
                        phoneContact = rs[2],
                        emailContact = rs[3]
                    };

                    listContact.Add(contact);

                }
                return listContact;
            }
            else
                return null;

        }
        public static List<Contact> GetContactBySearch(string pathDataFile, string search)
        {
            if (File.Exists(pathDataFile))
            {
                var ListLines = File.ReadAllLines(pathDataFile);
                List<Contact> listContact = new List<Contact>();
                foreach (var line in ListLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    Contact contact = new Contact
                    {
                        iDContact = rs[0],
                        nameContact = rs[1],
                        phoneContact = rs[2],
                        emailContact = rs[3]
                    };

                    if (contact.nameContact.ToLower().Contains(search.ToLower()))
                    {
                        listContact.Add(contact);
                    }
                    

                }
                return listContact;
            }
            else
                return null;
        }
        public static List<Contact> GetContactChar(string pathDataFile, string s)
        {
            if (File.Exists(pathDataFile))
            {
                var ListLines = File.ReadAllLines(pathDataFile);
                List<Contact> listContact = new List<Contact>();
                foreach (var line in ListLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    Contact contact = new Contact
                    {
                        iDContact = rs[0],
                        nameContact = rs[1],
                        phoneContact = rs[2],
                        emailContact = rs[3]
                    };

                    if (contact.firstCharacter.CompareTo(s)>=0)
                    {
                        listContact.Add(contact);
                    }


                }
                return listContact;
            }
            else
                return null;
        }
        public static void DeleteContact(string pathContactFile, string idContact)
        {
            if (File.Exists(pathContactFile))
            {
                var listHistoryLines = File.ReadAllLines(pathContactFile);
                //đọc hết file
                File.WriteAllText(pathContactFile, "");
                //xóa hết trong file rồi viết lại
                foreach (var lineHistory in listHistoryLines)
                {
                    var rsHistory = lineHistory.Split(new char[] { '#' });
                    if (rsHistory[0] != idContact)
                    {

                        File.AppendAllText(pathContactFile, lineHistory + "\r\n");
                    }
                }

            }
        }
        public static void CreateContact(string pathContactFile, string name, string phone, string email)
        {

            
            int c = 0;
            var listLines = File.ReadAllLines(pathContactFile);
            foreach (var line in listLines)
            {
                var rs = line.Split(new char[] { '#' });
                if (int.Parse(rs[0]) > c)
                {

                    c = int.Parse(rs[0]);
                }

            }
            var IDContact = c + 1;
            string lineContact = IDContact + "#" + name + "#" + phone + "#" + email;
            if (File.Exists(pathContactFile))
            {
                File.AppendAllText(pathContactFile, lineContact + "\n");
            }
        }
        public static void EditContact(string IDContact, string pathDataFile, string name, string phone, string email)
        {
            if (File.Exists(pathDataFile))
            {
                var listLines = File.ReadAllLines(pathDataFile);
                File.WriteAllText(pathDataFile, "");
                
                foreach (var line in listLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    if (rs[0] != IDContact)
                    {
                        
                        File.AppendAllText(pathDataFile, line + "\r\n");

                    }
                    else
                    {
                       
                        string content = IDContact + "#" + name + "#" + phone + "#" + email;
                        File.AppendAllText(pathDataFile, content + "\r\n");
                     
                    }
                }

            }
        }
    }
}
