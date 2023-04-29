﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayfly_LogicEngine
{
    /// <summary>
    /// Abstract class base for student and teacher users.
    /// </summary>
    internal abstract class User
    {
        protected string name;

        protected string password;

        protected string userID;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="newName">string name of user.</param>
        /// <param name="newPass">string password.</param>
        /// <param name="newUID">string userID.</param>
        public User(string newName, string newPass, string newUID)
        {
            this.name = newName;
            this.password = newPass;
            this.userID = newUID;
        }
    }
}
