using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
   public class Plaintiff
    {
        public string Insert(string plaintiffNumber, string name, string surname)
        {
            return "INSERT INTO kurs.plaintiff (PlaintiffNumber,Name,Surname) VALUES (" + plaintiffNumber + "," + name + "," + surname + ")";
        }

        public string Update(string plaintiffNumber, string name, string surname)
        {
            return "UPDATE kurs.plaintiff SET PlaintiffNumber=" + plaintiffNumber + ",Name=" + name + ",Surname=" + surname + " WHERE PlaintiffNumber=" + plaintiffNumber;
        }

        public string Search(string plaintiffNumber)
        {
            return "SELECT * FROM kurs.plaintiff WHERE PlaintiffNumber = " + plaintiffNumber;
        }

        public string Delete(string plaintiffNumber)
        {
            return "DELETE FROM kurs.plaintiff WHERE PlaintiffNumber = " + plaintiffNumber;
        }

        public string Display()
        {
            return "SELECT * FROM kurs.plaintiff";
        }
    }
}
