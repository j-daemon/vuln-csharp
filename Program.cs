using System;
using System.Data.SqlClient;

class Program {
    static void Main(string[] args) {
        // Intentional hardcoded password
        string connString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=mySuperSecretPassword123;";
        string userInput = args[0];
        
        using (SqlConnection connection = new SqlConnection(connString)) {
            // Intentional SQL Injection
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = '" + userInput + "'", connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
