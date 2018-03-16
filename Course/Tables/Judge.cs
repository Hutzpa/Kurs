﻿using System;
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
        public string Insert(string judgeNumber, string caseNumber, string name, string surname, string patronymic)
        {
            return "INSERT INTO kurs.judge (JudgeNumber,CaseNumber,Name,Surname,Patronymic) VALUES (" + judgeNumber +","+caseNumber+ "," + name + "," + surname +","+ patronymic+ ")";
        }

        /// <summary>
        /// Редактирование данных
        /// </summary>
        public string Update(string judgeNumber, string caseNumber, string name, string surname, string patronymic)
        {
            return "UPDATE kurs.judge SET JudgeNumber =" + judgeNumber +",CaseNumber="+caseNumber+ ",Name =" + name + ",Surname=" + surname + ",Patronymic="+patronymic+ " WHERE JudgeNumber=" + judgeNumber;
        }

        /// <summary>
        /// Поиск ответчиков по id
        /// </summary>
        public string Search(string judgeNumber)
        {
            return "SELECT * FROM kurs.judge WHERE JudgeNumber = " + judgeNumber;
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
