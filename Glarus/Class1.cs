using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Add MySql Library
using MySql.Data.MySqlClient;
namespace Glarus
{


    class DBConnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            server = "localhost";
            database = "GLARUS_DB";
            uid = "root";
            password = "RjvgfybzRBN25";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }

        }

        //Close connection
        //private bool CloseConnection()
        //{
        //}

        ////Insert statement
        //public void Insert()
        //{
        //}

        ////Update statement
        //public void Update()
        //{
        //}

        ////Delete statement
        //public void Delete()
        //{
        //}

        ////Select statement
        //public List<string>[] Select()
        //{
        //}

        ////Count statement
        //public int Count()
        //{
        //}

        ////Backup
        //public void Backup()
        //{
        //}

        ////Restore
        //public void Restore()
        //{
        //}
    }

    ////open connection to database
    //private bool OpenConnection()
    //{
    //    try
    //    {
    //        connection.Open();
    //        return true;
    //    }
    //    catch (MySqlException ex)
    //    {
    //        //When handling errors, you can your application's response based 
    //        //on the error number.
    //        //The two most common error numbers when connecting are as follows:
    //        //0: Cannot connect to server.
    //        //1045: Invalid user name and/or password.
    //        switch (ex.Number)
    //        {
    //            case 0:
    //                MessageBox.Show("Cannot connect to server.  Contact administrator");
    //                break;

    //            case 1045:
    //                MessageBox.Show("Invalid username/password, please try again");
    //                break;
    //        }
    //        return false;
    //    }
    //}

    ////Close connection
    //private bool CloseConnection()
    //{
    //    try
    //    {
    //        connection.Close();
    //        return true;
    //    }
    //    catch (MySqlException ex)
    //    {
    //        MessageBox.Show(ex.Message);
    //        return false;
    //    }
    //}

    ////Insert statement
    //public void Insert()
    //{
    //    string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

    //    //open connection
    //    if (this.OpenConnection() == true)
    //    {
    //        //create command and assign the query and connection from the constructor
    //        MySqlCommand cmd = new MySqlCommand(query, connection);

    //        //Execute command
    //        cmd.ExecuteNonQuery();

    //        //close connection
    //        this.CloseConnection();
    //    }
    //}

    ////Update statement
    //public void Update()
    //{
    //    string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

    //    //Open connection
    //    if (this.OpenConnection() == true)
    //    {
    //        //create mysql command
    //        MySqlCommand cmd = new MySqlCommand();
    //        //Assign the query using CommandText
    //        cmd.CommandText = query;
    //        //Assign the connection using Connection
    //        cmd.Connection = connection;

    //        //Execute query
    //        cmd.ExecuteNonQuery();

    //        //close connection
    //        this.CloseConnection();
    //    }
    //}

    ////Delete statement
    //public void Delete()
    //{
    //    string query = "DELETE FROM tableinfo WHERE name='John Smith'";

    //    if (this.OpenConnection() == true)
    //    {
    //        MySqlCommand cmd = new MySqlCommand(query, connection);
    //        cmd.ExecuteNonQuery();
    //        this.CloseConnection();
    //    }
    //}

    ////Insert statement
    //public void Insert()
    //{
    //    string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

    //    //open connection
    //    if (this.OpenConnection() == true)
    //    {
    //        //create command and assign the query and connection from the constructor
    //        MySqlCommand cmd = new MySqlCommand(query, connection);

    //        //Execute command
    //        cmd.ExecuteNonQuery();

    //        //close connection
    //        this.CloseConnection();
    //    }
    //}

    ////Update statement
    //public void Update()
    //{
    //    string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

    //    //Open connection
    //    if (this.OpenConnection() == true)
    //    {
    //        //create mysql command
    //        MySqlCommand cmd = new MySqlCommand();
    //        //Assign the query using CommandText
    //        cmd.CommandText = query;
    //        //Assign the connection using Connection
    //        cmd.Connection = connection;

    //        //Execute query
    //        cmd.ExecuteNonQuery();

    //        //close connection
    //        this.CloseConnection();
    //    }
    //}

    ////Delete statement
    //public void Delete()
    //{
    //    string query = "DELETE FROM tableinfo WHERE name='John Smith'";

    //    if (this.OpenConnection() == true)
    //    {
    //        MySqlCommand cmd = new MySqlCommand(query, connection);
    //        cmd.ExecuteNonQuery();
    //        this.CloseConnection();
    //    }
    //}
    ////Insert statement
    //public void Insert()
    //{
    //    string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

    //    //open connection
    //    if (this.OpenConnection() == true)
    //    {
    //        //create command and assign the query and connection from the constructor
    //        MySqlCommand cmd = new MySqlCommand(query, connection);

    //        //Execute command
    //        cmd.ExecuteNonQuery();

    //        //close connection
    //        this.CloseConnection();
    //    }
    //}

    ////Update statement
    //public void Update()
    //{
    //    string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

    //    //Open connection
    //    if (this.OpenConnection() == true)
    //    {
    //        //create mysql command
    //        MySqlCommand cmd = new MySqlCommand();
    //        //Assign the query using CommandText
    //        cmd.CommandText = query;
    //        //Assign the connection using Connection
    //        cmd.Connection = connection;

    //        //Execute query
    //        cmd.ExecuteNonQuery();

    //        //close connection
    //        this.CloseConnection();
    //    }
    //}

    ////Delete statement
    //public void Delete()
    //{
    //    string query = "DELETE FROM tableinfo WHERE name='John Smith'";

    //    if (this.OpenConnection() == true)
    //    {
    //        MySqlCommand cmd = new MySqlCommand(query, connection);
    //        cmd.ExecuteNonQuery();
    //        this.CloseConnection();
    //    }
    //}

    //    class Class1
    //    {
    //    }
}
//private void connectBtn_Click(object sender, System.EventArgs e)
//{
//    if (conn != null)
//        conn.Close();

//    string connStr = String.Format("server={0};user id={1}; password={2}; database=mysql; pooling=false",
//        server.Text, userid.Text, password.Text );

//    try 
//    {
//        conn = new MySqlConnection( connStr );
//        conn.Open();

//        GetDatabases();
//    }
//    catch (MySqlException ex) 
//    {
//        MessageBox.Show( "Error connecting to the server: " + ex.Message );
//    }
//}
