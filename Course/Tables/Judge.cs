using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
   public class Judge
    {
        /// <summary>
        /// Добавление данных
        /// </summary>
        public string Insert( string name, string surname, string patronymic)
        {
            return "INSERT INTO kurs.judge (Name,Surname,Patronymic,Fio) VALUES ('" + name + "','" + surname +"','"+ patronymic+ "','" + name.Substring(0, 1).ToUpper() + surname.Substring(0, 1).ToUpper() + patronymic.Substring(0, 1).ToUpper() +"')";
        }

        /// <summary>
        /// Редактирование данных
        /// </summary>
        public string Update(string judgeNumber, string name, string surname, string patronymic)
        {
            return "UPDATE kurs.judge SET JudgeNumber ='" + judgeNumber +"',Name ='" + name + "',Surname='" + surname + "',Patronymic='"+patronymic+ "',Fio='" + name.Substring(0, 1).ToUpper() + surname.Substring(0, 1).ToUpper() + patronymic.Substring(0, 1).ToUpper() + "' WHERE JudgeNumber='" + judgeNumber+"'";
        }

        /// <summary>
        /// Редактирование номера дела 
        /// </summary>
        public string UpdateCaseNmb(string judgeNumber, string caseNumber)
        {
            return "UPDATE kurs.judge SET CaseNumber='" + caseNumber + "' WHERE JudgeNumber='" + judgeNumber + "'";
        }

        /// <summary>
        /// Поиск ответчиков по id
        /// </summary>
        public string Search(string judgeNumber)
        {
            return "SELECT * FROM kurs.judge WHERE JudgeNumber = '" + judgeNumber+"'";
        }

        /// <summary>
        /// Удаление данных по индексу
        /// </summary>
        public string Delete(string judgeNumber)
        {
            return "DELETE  FROM kurs.judge WHERE JudgeNumber = " + judgeNumber;
        }

        /// <summary>
        /// Вывод всех данных формы
        /// </summary>
        public string Display()
        {
            return "SELECT * FROM kurs.judge";
        }
    }
}
