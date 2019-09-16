using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SchemaDict.Helper
{
    class SQLiteHelper
    {
        private String constr;
        private SQLiteConnection conn;
        private SQLiteCommand comd;
        public SQLiteHelper()
        {
            constr = "Data Source=" + Application.StartupPath + "\\Database\\Searched.db;Initial Catalog=sqlite;Integrated Security=True;";
            conn = new SQLiteConnection(constr);
            conn.Open();
            comd = new SQLiteCommand(conn);
        }

        public string GetTopTimesWord()
        {
            string word = "";
            comd.CommandText = string.Format("select WORD from SearchedWords order by TIMES DESC LIMIT 0, 1;");
            Object result = comd.ExecuteScalar();
            if (result != null)
                word = result.ToString();
            return word;
        }

        //test3
        public int Append(string word)
        {
            comd.CommandText = string.Format("select TIMES FROM SearchedWords where WORD='{0}';", word);
            Object result = comd.ExecuteScalar();
            if (result == null)
            {
                comd.CommandText = string.Format("insert into SearchedWords values(null, '{0}', 1);", word);
            }
            else
            {
                comd.CommandText = string.Format("UPDATE SearchedWords set TIMES=(select TIMES FROM SearchedWords where WORD='{0}')+1 WHERE WORD='{1}';", word, word);
            }
            return comd.ExecuteNonQuery();
        }

        public void CloseAll()
        {
            conn.Close();
            comd.Dispose();
        }
    }
}
