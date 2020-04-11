using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Записная_книжка
{
    internal class DBWorker
    {
        private SQLiteConnection connection = new SQLiteConnection("Data Source=Data.db");

        /// <summary>
        /// Выполняет заданную SQL команду
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataTable Execute(SQLiteCommand command)
        {
            DataTable dataTable = new DataTable();
            command.Connection = this.connection;
            try
            {
                this.connection.Open();
                dataTable.Load((IDataReader)command.ExecuteReader());
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.connection.Close();
            }
            return dataTable;
        }
        /// <summary>
        /// Выполняет заданную SQL команду
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataTable Execute(string command)
        {
            DataTable dataTable = new DataTable();
            SQLiteCommand sqLiteCommand = new SQLiteCommand(command, this.connection);
            sqLiteCommand.CommandType = CommandType.Text;
            sqLiteCommand.Connection = this.connection;
            try
            {
                this.connection.Open();
                dataTable.Load((IDataReader)sqLiteCommand.ExecuteReader());
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.connection.Close();
            }
            return dataTable;
        }

        /// <summary>
        /// Создаёт таблицу с именем TableName
        /// </summary>
        /// <param name="TableName"></param>
        public void CreateNewTable(string TableName)
        {
            this.Execute(new SQLiteCommand("CREATE TABLE \"" + TableName + "\" (\"id\"    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,\"answer\"    TEXT,\"time\"  TEXT); ", this.connection));
        }

        /// <summary>
        /// Загружает таблицу с именем TableName
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataTable LoadTable(string TableName)
        {
            DataTable dataTable = new DataTable();
            return this.Execute(new SQLiteCommand("SELECT * FROM '" + TableName + "'", this.connection));
        }

        /// <summary>
        /// Удаляет таблицу с именем TableName
        /// </summary>
        /// <param name="TableName"></param>
        public void DeleteTable(string TableName)
        {
            this.Execute(new SQLiteCommand("DROP TABLE '" + TableName + "'", this.connection));
        }

        public List<string> GetTables()
        {
            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = this.Execute(new SQLiteCommand("select * from sqlite_master where type = 'table' and tbl_name!='sqlite_sequence' and tbl_name!='passwords' and tbl_name!='settings'", this.connection));
            List<string> stringList = new List<string>();
            for (int index = 0; index < dataTable2.Rows.Count; ++index)
                stringList.Add(dataTable2.Rows[index]["tbl_name"].ToString());
            return stringList;
        }

        public void InsertMessage(string table, string message)
        {
            this.Execute(new SQLiteCommand("INSERT INTO '" + table + "' ('answer','time') VALUES('" + message + "','" + DateTime.Now.ToString() + "')", this.connection));
        }

        public void UpdateMessage(string table, string text, int id)
        {
            this.Execute(new SQLiteCommand("UPDATE '" + table + "' SET answer='" + text + "' WHERE id=" + id.ToString(), this.connection));
        }

        public void DeleteMessage(string table, int id)
        {
            this.Execute(new SQLiteCommand("DELETE FROM '" + table + "' WHERE id=" + id.ToString(), this.connection));
        }

        public void CopyMessage(string tableFrom, string tableTo, int id)
        {
            DataTable dataTable = this.Execute("SELECT answer FROM " + tableFrom + " WHERE id=" + id.ToString());
            this.Execute(new SQLiteCommand("INSERT INTO '" + tableTo + "' ('answer','time') VALUES('" + dataTable.Rows[0][0]?.ToString() + "','" + DateTime.Now.ToString() + "')", this.connection));
        }

        public void MoveMessage(string tableFrom, string tableTo, int id)
        {
            DataTable dataTable = this.Execute("SELECT answer FROM '" + tableFrom + "' WHERE id=" + id.ToString());
            this.Execute("DELETE FROM '" + tableFrom + "' WHERE id=" + id.ToString());
            this.Execute(new SQLiteCommand("INSERT INTO '" + tableTo + "' ('answer','time') VALUES('" + dataTable.Rows[0][0]?.ToString() + "','" + DateTime.Now.ToString() + "')", this.connection));
        }

        public void CreateSettings()
        {
            SQLiteCommand command = new SQLiteCommand("CREATE TABLE \"settings\" (\"id\" INTEGER,\"ActiveTable\"\tTEXT,\"ActiveRow\"\tINTEGER);", this.connection);
            this.Execute(command);
            command.CommandText = "INSERT INTO SETTINGS(id,ActiveTable,ActiveRow) VALUES(1,\"0\",0)";
            this.Execute(command);
        }
        public void CreatePasswordsTable()
        {
            SQLiteCommand command = new SQLiteCommand("CREATE TABLE \"passwords\" (\"id\"    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                "\"info\"  TEXT,\"user\"  TEXT,\"pass\"  TEXT); ", this.connection);
            this.Execute(command);
        }

        //Сейчас пароли лежат в базе в открытом виде, позже нужно будет сделать хэширование
        /// <summary>
        /// Создаёт новую запись в таблице с паролями
        /// </summary>
        /// <param name="info"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public void NewPass(String info, String user, String password)
        {
            SQLiteCommand command = new SQLiteCommand("INSERT INTO PASSWORDS(info,user,pass) VALUES(\"" + info + "\",\"" + user + "\",\"" + password + "\")", this.connection);
            this.Execute(command);
        }
        public int GetActiveTable()
        {
            DataTable dataTable = this.Execute(new SQLiteCommand("SELECT ActiveTable FROM SETTINGS", this.connection));
            int num;
            try
            {
                num = int.Parse(dataTable.Rows[0][0].ToString());
            }
            catch
            {
                num = 0;
            }
            return num;
        }

        public int GetActiveRow()
        {
            DataTable dataTable = this.Execute(new SQLiteCommand("SELECT ActiveRow FROM SETTINGS", this.connection));
            int num;
            try
            {
                num = int.Parse(dataTable.Rows[0][0].ToString());
            }
            catch
            {
                num = 0;
            }
            return num;
        }

        public void SetActiveTable(int table)
        {
            this.Execute(new SQLiteCommand("UPDATE SETTINGS set ActiveTable=" + table.ToString(), this.connection));
        }

        public void SetActiveRow(int row)
        {
            this.Execute(new SQLiteCommand("UPDATE SETTINGS set ActiveRow=" + row.ToString(), this.connection));
        }
    }
}
