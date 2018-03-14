using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
   public class Plaintiff
    {
        /// <summary>
        /// Добавление данных
        /// </summary>
        public string Insert(string plaintiffNumber,string caseNumber,string name, string surname)
        {
            return "INSERT INTO kurs.plaintiff (PlaintiffNumber,CaseNumber,Name,Surname) VALUES (" + plaintiffNumber +","+caseNumber+ "," + name + "," + surname + ")";
        }

        /// <summary>
        /// Редактирование данных
        /// </summary>
        public string Update(string plaintiffNumber,string caseNumber ,string name, string surname)
        {
            return "UPDATE kurs.plaintiff SET PlaintiffNumber=" + plaintiffNumber +",CaseNumber="+caseNumber+",Name=" + name + ",Surname=" + surname + " WHERE PlaintiffNumber=" + plaintiffNumber;
        }

        /// <summary>
        /// Поиск ответчиков по id
        /// </summary>
        public string Search(string plaintiffNumber)
        {
            return "SELECT * FROM kurs.plaintiff WHERE PlaintiffNumber = " + plaintiffNumber;
        }

        /// <summary>
        /// Удаление данных по индексу
        /// </summary>
        public string Delete(string plaintiffNumber)
        {
            return "DELETE FROM kurs.plaintiff WHERE PlaintiffNumber = " + plaintiffNumber;
        }

        /// <summary>
        /// Вывод всех данных формы
        /// </summary>
        public string Display()
        {
            return "SELECT * FROM kurs.plaintiff";
        }
    }
}
