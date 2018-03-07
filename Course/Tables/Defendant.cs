using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
   public class Defendant
    {
        public string Insert(string defendantNumber, string name, string surname)
        {
            return "INSERT INTO kurs.defendant (DefendantNumber,Name,Surname) VALUES (" + defendantNumber + "," + name + "," + surname + ")";
        }

        public string Update(string defendantNumber, string name, string surname)
        {
            return "UPDATE kurs.defendant SET DefendantNumber=" + defendantNumber + ",Name=" + name + ",Surname=" + surname + " WHERE DefendantNumber=" + defendantNumber;
        }

        public string Search(string defendantNumber)
        {
            return "SELECT * FROM kurs.defendant WHERE DefendantNumber = " + defendantNumber;
        }

        public string Delete(string defendantNumber)
        {
           return "DELETE  FROM kurs.defendant WHERE DefendantNumber = " + defendantNumber;
        }

        public string Display()
        {
            return "SELECT * FROM kurs.defendant";
        }
    }
}
