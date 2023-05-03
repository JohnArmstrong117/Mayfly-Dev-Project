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
    internal class LogInManager
    {
        private List<User> allUsers;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogInManager"/> class.
        /// </summary>
        public LogInManager()
        {
            this.allUsers = new List<User>();
        }

        public void AddUser(User user)
        {
            this.allUsers.Add(user);
        }

        public void RemoveUser(User user)
        {
            this.allUsers.Remove(user);
        }

        public void LoadUsers()
        {
            // TODO: deserialize list of user objects.
        }

        public void SaveUsers()
        {
            // TODO: serialize list of user objects.
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
