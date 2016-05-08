using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace YourText
{
   public static class Db_use
    {
       public static string connect = "Database=kela_6;Data Source=176.9.63.11;User Id=kela_6;Password=25176542;";
       public static Boolean AddBd(this Text_Box tb)
       {
           MySqlConnection myConnection = new MySqlConnection(connect);
           MySqlCommand command_add = new MySqlCommand("INSERT INTO FirstText (Name, Val, Date, LastRead) VALUES (@Name, @Val, @Date, @LastRead)", myConnection);
           command_add.Parameters.AddWithValue("@Name", tb.name);
           command_add.Parameters.AddWithValue("@Val", tb.val);
           command_add.Parameters.AddWithValue("@Date", DateTime.Today.ToShortDateString());
           command_add.Parameters.AddWithValue("@LastRead", DateTime.Today.ToShortDateString());
           myConnection.Open();
           command_add.ExecuteNonQuery();
           myConnection.Close();
           return true;
       }
       public static string ReadBd(string name)
       {
           MySqlConnection myConnection = new MySqlConnection(connect);
           MySqlCommand command_read = new MySqlCommand("SELECT Val FROM FirstText WHERE Name = @Name", myConnection);
           MySqlCommand command_last = new MySqlCommand("UPDATE FirstText SET LastRead = @LastRead WHERE Name = @Name", myConnection);
           command_read.Parameters.AddWithValue("@Name", name);
           command_last.Parameters.AddWithValue("@LastRead", DateTime.Today.ToShortDateString());
           command_last.Parameters.AddWithValue("@Name", name);
           myConnection.Open();
           string val = command_read.ExecuteScalar().ToString();
           command_last.ExecuteNonQuery();
           myConnection.Close();
           return val;
       }
    }
}
