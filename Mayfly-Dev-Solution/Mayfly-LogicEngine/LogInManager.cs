using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

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
            this.xmlSerializer = new XmlSerializer(typeof(List<User>), new XmlRootAttribute("root"));
            string filePath = "users.xml";

            if (!File.Exists(filePath))
            {
                // Create a new XML document with a root element
                XmlDocument xmlDocument = new XmlDocument();
                XmlElement rootElement = xmlDocument.CreateElement("root");
                xmlDocument.AppendChild(rootElement);
                xmlDocument.Save(filePath);
            }
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
            if (File.Exists("users.xml") && new FileInfo("users.xml").Length > 0)
            {
                StreamReader sr = new StreamReader("users.xml");
                this.allUsers = (List<User>)this.xmlSerializer.Deserialize(sr);
                sr.Close();
            }
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

        /// <summary>
        /// Gets a user in the database by username.
        /// </summary>
        /// <param name="username">Username od user to find.</param>
        /// <returns>Returns the User if found. returns null if not.</returns>
        public User getUserByUsername(string username)
        {
            this.LoadUsers();
            foreach (User current in this.allUsers)
            {
                if (current.UserID == username)
                {
                    return current;
                }
            }

            return null;
        }
    }
}
