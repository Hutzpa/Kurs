﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
   public class Defendant
    {
        /// <summary>
        /// Добавление данных
        /// </summary>
        public string Insert(string caseNumber,string name,string surname,string patronymic)
        {
            return "INSERT INTO kurs.defendant (CaseNumber,Name,Surname,Patronymic,Fio) VALUES ('"+caseNumber +"','" + name + "','" + surname + "','"+patronymic+"','" + name.Substring(0, 1).ToUpper() + surname.Substring(0, 1).ToUpper() + patronymic.Substring(0, 1).ToUpper()+"')";
        }

        /// <summary>
        /// Редактирование данных
        /// </summary>
        public string Update(string defendantNumber,string caseNumber,string name,string surname,string patronymic )
        {
            return "UPDATE kurs.defendant SET DefendantNumber='" + defendantNumber + "',CaseNumber='"+caseNumber+"',Name='" + name + "',Surname='" + surname +"',Patronymic='"+patronymic+ "',Fio='" + name.Substring(0, 1).ToUpper() + surname.Substring(0, 1).ToUpper() + patronymic.Substring(0, 1).ToUpper() + "' WHERE DefendantNumber='" + defendantNumber+"'";
        }

        /// <summary>
        /// Поиск ответчиков по id
        /// </summary>
        public string Search(string defendantNumber)
        {
            return "SELECT * FROM kurs.defendant WHERE DefendantNumber = '" + defendantNumber+"'";
        }

        /// <summary>
        /// Удаление данных по индексу
        /// </summary>
        public string Delete(string defendantNumber)
        {
           return "DELETE  FROM kurs.defendant WHERE DefendantNumber = " + defendantNumber;
        }

        /// <summary>
        /// Вывод всех данных формы
        /// </summary>
        public string Display()
        {
            return "SELECT * FROM kurs.defendant";
        }
    }
}
