// Role-based Authentication System 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RoleBasedAuthenticationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some users with different roles
            User adminUser = new User("admin", "admin123", Role.Admin);
            User editorUser = new User("editor", "editor123", Role.Editor);
            User viewerUser = new User("viewer", "viewer123", Role.Viewer);

            // Simulate user login
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            User loggedInUser = AuthenticateUser(username, password);

            if (loggedInUser != null)
            {
                Console.WriteLine($"Welcome, {loggedInUser.Username}! Your role is {loggedInUser.UserRole}.");
                AccessControl(loggedInUser);
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        static User AuthenticateUser(string username, string password)
        {
            // In a real application, you would check the credentials against a database
            List<User> users = new List<User>
            {
                new User("admin", "admin123", Role.Admin),
                new User("editor", "editor123", Role.Editor),
                new User("viewer", "viewer123", Role.Viewer)
            };

            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        static void AccessControl(User user)
        {
            switch (user.UserRole)
            {
                case Role.Admin:
                    Console.WriteLine("You have full access to the system.");
                    break;
                case Role.Editor:
                    Console.WriteLine("You can edit content but cannot manage users.");
                    break;
                case Role.Viewer:
                    Console.WriteLine("You can view content but cannot edit or manage users.");
                    break;
                default:
                    Console.WriteLine("Unknown role.");
                    break;
            }
        }
    }

    public enum Role
    {
        Admin,
        Editor,
        Viewer
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }

        public User(string username, string password, Role userRole)
        {
            Username = username;
            Password = password;
            UserRole = userRole;
        }   
    }
}
