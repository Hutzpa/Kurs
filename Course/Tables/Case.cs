using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
   public class Case
    {
        #region Search
        /// <summary>
        /// Поиск по фио
        /// </summary>
        public string Zero(string param)
        {
            return "";
        }

        /// <summary>
        /// Список юридичних справ
        /// </summary>   
        public string First(string param)
        {
            return "SELECT * FROM kurs.case WHERE case.IsUr ='" + param+"';";
        }

        /// <summary>
        /// Справа за кейвордом
        /// </summary>
        public string Second(string param)
        {
            return "SELECT * FROM kurs.case WHERE case.Description LIKE '%" + param+"%';";
        }

        /// <summary>
        /// Справа за статтею
        /// </summary>
        public string Third(string param)
        {
            return "SELECT * FROM kurs.case WHERE case.Article ='" + param + "';";
        }

        /// <summary>
        /// Список закінченних\незакінчених спрв
        /// </summary>
        public string Fourth(string param)
        {
            return "SELECT * FROM kurs.case WHERE case.IsEnd ='" + param + "';";
        }

        /// <summary>
        /// Список справ судді
        /// </summary>
        public string Fifth(string param)
        {
            return "SELECT * FROM kurs.case WHERE case.JudgeNumber ='" + param + "';";
        }

        /// <summary>
        /// Список справ позивача
        /// </summary>
        public string Sixth(string param)
        {
            return "SELECT * FROM kurs.case WHERE case.PlaintiffNumber ='" + param + "';";
        }

        /// <summary>
        /// Список справ відповідача
        /// </summary>
        public string Seventh(string param)
        {
            return "SELECT * FROM kurs.case WHERE case.NumberDefendant ='" + param + "';";
        }

        #endregion

        /// <summary>
        /// Вводит данные в таблицу "дело" 
        /// </summary>
        public string Insert(string id, string defendantId, string plaintiffId, string judgeId, string descripton, string article,DateTime dateOfStart,DateTime dateOfEnd, short isEnd, short isUr, string verdict)
        {
            return "INSERT INTO kurs.case (Id, NumberDefendant,PlaintiffNumber,JudgeNumber,Description,Article,DateOfStart,DateOfEnd,IsEnd,IsUr,Verdict) VALUES ('" + id +"','"+ defendantId +"','"+plaintiffId+"','"+judgeId+"','"+descripton +"','"+article+"','"+dateOfStart.ToShortDateString()+"','" + dateOfEnd.ToShortDateString()+"','" + isEnd+"','"+isUr+"','"+verdict+"')";
        }

        /// <summary>
        /// Редактирует данные
        /// </summary>
        public string Update(string id, string defendantId, string plaintiffId, string judgeId, string descripton, string article, DateTime dateOfStart, DateTime dateOfEnd, short isEnd, short isUr, string verdict)
        {
            return "UPDATE kurs.case SET Id ='" + id + "',NumberDefendant='" + defendantId + "',PlaintiffNumber='" + plaintiffId + "',JudgeNumber='" + judgeId + "',Description='" + descripton + "',Article='" + article + "',DateOfStart='" + dateOfStart.ToShortDateString() + "',DateOfEnd='" + dateOfEnd.ToShortDateString() + "',IsEnd='" + isEnd + "',IsUr='" + isUr + "',Verdict='" + verdict + "';";
        }

        /// <summary>
        /// Удаляет данные
        /// </summary>
        public string Delete(string id)
        {
            return "DELETE  FROM kurs.case WHERE Id = '" + id +"';";
        }

        /// <summary>
        /// Выводит всех данных таблицы
        /// </summary>
        public string Display()
        {
            return "SELECT * FROM kurs.case";
        }
    }
}
