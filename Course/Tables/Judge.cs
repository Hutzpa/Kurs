using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
   public class Judge
    {
        public string Insert(string judgeNumber, string name, string surname)
        {
            return "INSERT INTO kurs.judge (JudgeNumber,Name,Surname) VALUES (" + judgeNumber + "," + name + "," + surname + ")";
        }

        public string Update(string judgeNumber, string name, string surname)
        {
            return "UPDATE kurs.judge SET JudgeNumber =" + judgeNumber + ",Name =" + name + ",Surname=" + surname + " WHERE JudgeNumber=" + judgeNumber;
        }

        public string Search(string judgeNumber)
        {
            return "SELECT * FROM kurs.judge WHERE JudgeNumber = " + judgeNumber;
        }

        public string Delete(string judgeNumber)
        {
            return "DELETE  FROM kurs.judge WHERE JudgeNumber = " + judgeNumber;
        }

        public string Display()
        {
            return "SELECT * FROM kurs.judge";
        }
    }
}
