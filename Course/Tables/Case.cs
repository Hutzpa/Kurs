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
        /// Get all cases, which defendant fullname contain entered fullname
        /// </summary>
        public List<object> GetFio(string query, string fio)
        {
            using (var conn = new MySqlConnection(Connection.connStr))
            {
                List<object> list = new List<object>();
                MySqlCommand com = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["Fio"].ToString() == fio)
                        {
                            list.Add(reader["CaseNumber"]);
                        }
                    }
                    conn.Close();
                    return list;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return new List<object>();
                }
            }
        }

        /// <summary>
        /// DIsplay cases, that contain the  full names
        /// </summary>
        public void FillDgv(DataGridView dataGridView1, string query, List<object> list)
        {
            using (var conn = new MySqlConnection(Connection.connStr))
            {
                MySqlCommand com = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = com.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataGridView1.DataSource = null;
                    while (reader.Read())
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (reader["Id"].ToString() == list[i].ToString())
                            {
                                dataGridView1.Rows.Add(Convert.ToInt32(reader["Id"]), Convert.ToUInt32(reader["NumberDefendant"]), Convert.ToUInt32(reader["PlaintiffNumber"]), Convert.ToUInt32(reader["JudgeNumber"]), reader["Description"].ToString(), reader["Article"].ToString(), Convert.ToDateTime(reader["DateOfStart"]).ToShortDateString(), Convert.ToDateTime(reader["DateOfEnd"]).ToShortDateString(), Convert.ToBoolean(reader["IsEnd"]), Convert.ToBoolean(reader["IsUr"]), reader["Verdict"].ToString());

                            }
                        }
                    }
                    conn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
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
        public string Insert(string defendantId, string plaintiffId, string judgeId, string descripton, string article,DateTime dateOfStart,DateTime dateOfEnd, short isEnd, short isUr, string verdict)
        {
            return "INSERT INTO kurs.case (NumberDefendant,PlaintiffNumber,JudgeNumber,Description,Article,DateOfStart,DateOfEnd,IsEnd,IsUr,Verdict) VALUES ('"+ defendantId +"','"+plaintiffId+"','"+judgeId+"','"+descripton +"','"+article+"','"+dateOfStart.ToShortDateString()+"','" + dateOfEnd.ToShortDateString()+"','" + isEnd+"','"+isUr+"','"+verdict+"')";
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
