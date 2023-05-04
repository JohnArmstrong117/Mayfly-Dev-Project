using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mayfly_LogicEngine
{
    /// <summary>
    /// Abstract class base for student and teacher users.
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(Student))]
    [XmlInclude(typeof(Teacher))]
    public abstract class User
    {
        protected string name;

        protected string password;

        protected string userID;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            this.name = string.Empty;
            this.password = string.Empty;
            this.userID = string.Empty;
        }

        /// <summary>
        /// Gets or Sets UserId.
        /// </summary>
        public string UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        /// <summary>
        /// Gets or Sets Password.
        /// </summary>
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        /// <summary>
        /// Gets or Sets Name.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set{ this.name = value; }
        }
    }
}
