using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
   public class Case
    {
        #region Search
       

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
            return "SELECT * FROM kurs.case WHERE case.DefendantNumber ='" + param + "';";
        }

        #endregion

        /// <summary>
        /// Вводит данные в таблицу "дело" 
        /// </summary>
        public string Insert(string defendantId, string plaintiffId, string judgeId, string descripton, string article,DateTime dateOfStart,DateTime dateOfEnd, short isEnd, short isUr, string verdict)
        {
            return "INSERT INTO kurs.case (DefendantNumber,PlaintiffNumber,JudgeNumber,Description,Article,StartDate,EndDate,IsEnd,IsUr,Verdict) VALUES ('" + defendantId +"','"+plaintiffId+"','"+judgeId+"','"+descripton +"','"+article+"','"+dateOfStart.ToShortDateString()+"','" + dateOfEnd.ToShortDateString()+"','" + isEnd+"','"+isUr+"','"+verdict+"')";
        }

        /// <summary>
        /// Редактирует данные
        /// </summary>
        public string Update(string id, string defendantId, string plaintiffId, string judgeId, string descripton, string article, DateTime dateOfStart, DateTime dateOfEnd, short isEnd, short isUr, string verdict)
        {
            return "UPDATE kurs.case SET DefendantNumber='" + defendantId + "',PlaintiffNumber='" + plaintiffId + "',JudgeNumber='" + judgeId + "',Description='" + descripton + "',Article='" + article + "',StartDate='" + dateOfStart.ToShortDateString() + "',EndDate='" + dateOfEnd.ToShortDateString() + "',IsEnd='" + isEnd + "',IsUr='" + isUr + "',Verdict='" + verdict + "' WHERE Id='" + id + "'";
        }

        public string ClearVerdict(string id)
        {
            return "UPDATE kurs.case SET Verdict = NULL WHERE Id = '" + id + "';";
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

        #region Stats

        /// <summary>
        /// Количество дел истца
        /// </summary>
        public string AmountOfPlaintiffCases(int id)
        {
            return "SELECT COUNT(*) FROM kurs.case WHERE case.PlaintiffNumber = '" + id+"'";
        }

        /// <summary>
        /// Количество дел ответчика
        /// </summary>
        public string AmountOfDefendantCases(int id)
        {
            return "SELECT COUNT(*) FROM kurs.case WHERE case.DefendantNumber = '" + id + "'";
        }

        /// <summary>
        /// Количество дел судьи
        /// </summary>
        public string AmountOfJudgeCases(int id)
        {
            return "SELECT COUNT(*) FROM kurs.case WHERE case.JudgeNumber = '" + id + "'";
        }


        /// <summary>
        /// Количество открытых дел
        /// </summary>
        public string AmountOfOpenCases()
        {
            return "SELECT COUNT(*) FROM kurs.case WHERE case.IsEnd = 0";
        }


        /// <summary>
        /// Количество закрытых дел
        /// </summary>
        public string AmountOfClosedCases()
        {
            return "SELECT COUNT(*) FROM kurs.case WHERE case.IsEnd = 1";
        }

        /// <summary>
        /// Количество закрытых в определённую дату дел
        /// </summary>
        public string AmountOfClosedInSpecDateCases(DateTime date)
        {
            return "SELECT COUNT(*) FROM kurs.case WHERE EndDate = '"+date.ToShortDateString() +"'";
        }

        /// <summary>
        /// Количество открытых в определённую дату дел
        /// </summary>
        public string AmountOfOpenedInSpecDateCases(DateTime date)
        {
            return "SELECT COUNT(*) FROM kurs.case WHERE StartDate = '" + date.ToShortDateString() + "'";
        }

        #endregion
    }
}
