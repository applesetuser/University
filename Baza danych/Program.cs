using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
namespace chmsql
{
  class Program
    {
        static void CreateBase(string tableName)
        {
            string connStr = "server=192.168.64.2;user=root;database=infa;port=8080;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "CREATE TABLE" + tableName + "(id BIGINT UNSIGNED NOT NULL UNIQUE AUTO_INCREMENT,login VARCHAR(32) UNIQUE NOT NULL,email VARCHAR(64) UNIQUE NOT NULL,password VARCHAR(32) NOT NULL,PRIMARY KEY (id))";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Utworzono tabelę o nazwie" + tableName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
        static void AddUser(string tableName, string login, string email, string password)
        {
            string connStr = "server=192.168.64.2;user=root;database=infa;port=8080;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = $"INSERT INTO {tableName} (id, login, email, password) VALUES ('null','{login}', '{email}', '{password}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Co chcesz zrobic? ");
                Console.WriteLine();
                Console.WriteLine("1>> stworzyc baze danych");
                Console.WriteLine("2>> dodac uzytkownika do bazy danych");
                Console.WriteLine("3>> exit ");
                Console.WriteLine();
                Console.Write("Twój wybór: ");
                int decision = int.Parse(Console.ReadLine());
                switch(decision)
                {
                    case 1:
                        Console.Write("Jak chcesz nazwać bazę danych?: ");
                        string tableName = Console.ReadLine();
                        CreateBase(tableName);
                        break;
                    case 2:
                        Console.WriteLine("Nazwa bazy danych: ");
                        tableName = Console.ReadLine();

                        Console.WriteLine("login: ");
                        string login = Console.ReadLine();

                        Console.WriteLine("email: ");
                        string email = Console.ReadLine();

                        Console.WriteLine("hasło: ");
                        string password = Console.ReadLine();
                        AddUser(tableName, login, email, password);
                        break;
                    case 3: break;
                    default:
                        Console.WriteLine("wybierz ponownie");
                        break;
                }

                if(decision==3) break;
            }
        }
    }
}