// Database CRUD using ADO.NET
using System;
using System.Data;
using System.Data.SqlClient;    
class Program
{
    static string connectionString = "your_connection_string_here";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Create();
                    break;
                case "2":
                    Read();
                    break;
                case "3":
                    Update();
                    break;
                case "4":
                    Delete();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void Create()
    {
        Console.Write("Enter name to create: ");
        string name = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO YourTable (Name) VALUES (@Name)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);

            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("Data created successfully.");
        }
    }

    static void Read()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM YourTable";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader["ID"]}, Name: {reader["Name"]}");
            }
        }
    }

    static void Update()
    {
        Console.Write("Enter ID to update: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter new name: ");
        string name = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "UPDATE YourTable SET Name = @Name WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@ID", id);

            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("Data updated successfully.");
        }
    }
        static void Delete()
    {
        Console.Write("Enter ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM YourTable WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);

            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("Data deleted successfully.");
        }
    }
}
