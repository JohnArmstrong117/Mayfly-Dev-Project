using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Mayfly_LogicEngine
{
    /// <summary>
    /// Class to manage Mayfly user login and signup.
    /// </summary>
    public class LogInManager
    {
        private List<User> allUsers;
        private XmlSerializer xmlSerializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogInManager"/> class.
        /// </summary>
        public LogInManager()
        {
            this.allUsers = new List<User>();
            this.xmlSerializer = new XmlSerializer(typeof(List<User>));
        }

        public void AddUser(User user)
        {
            this.LoadUsers();
            this.allUsers.Add(user);
            this.SaveUsers();
        }

        /// <summary>
        /// Use to add a student account to the user database.
        /// </summary>
        /// <param name="username">New username and userID.</param>
        /// <param name="password">Password for new user.</param>
        public void AddStudentUser(string username, string password)
        {
            Student newStud = new Student();
            newStud.UserID = username;
            newStud.Name = username;
            newStud.Password = password;
            this.AddUser(newStud);
        }

        /// <summary>
        /// Use to add a teacher account to the user database.
        /// </summary>
        /// <param name="username">New username and userID.</param>
        /// <param name="password">Password for new user.</param>
        public void AddTeacherUser(string username, string password)
        {
            Teacher newTeach = new Teacher();
            newTeach.UserID = username;
            newTeach.Name = username;
            newTeach.Password = password;
            this.AddUser(newTeach);
        }

        public void RemoveUser(User user)
        {
            this.allUsers.Remove(user);
        }

        public void LoadUsers()
        {
            StreamReader sr = new StreamReader("users.xml");
            this.allUsers = (List<User>)this.xmlSerializer.Deserialize(sr);
            sr.Close();
        }

        public void SaveUsers()
        {
            StreamWriter sw = new StreamWriter("users.xml");
            this.xmlSerializer.Serialize(sw, this.allUsers);
            sw.Close();
        }

        /// <summary>
        /// If there is a user matching the input this will return true.
        /// </summary>
        /// <param name="username">username of user to find.</param>
        /// <returns>True if user found.</returns>
        public bool UserExists(string username)
        {
            this.LoadUsers();
            foreach (User user in this.allUsers)
            {
                if (user.UserID == username)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
