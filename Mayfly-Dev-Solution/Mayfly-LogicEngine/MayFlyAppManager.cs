﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayfly_LogicEngine
{
    /// <summary>
    /// Class for managing general application for quiz.
    /// </summary>
    public class MayFlyAppManager
    {
        private static MayFlyAppManager? instance = null;
        private User? activeUser;
        private Quiz? activeQuiz;
        private SchoolClass? activeClass;
        private LogInManager logInManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="MayFlyAppManager"/> class.
        /// </summary>
        private MayFlyAppManager()
        {
            this.logInManager = new LogInManager();
            this.logInManager.LoadUsers();
        }

        /// <summary>
        /// Gets instance of app manager.
        /// </summary>
        /// <returns>instance of app manager.</returns>
        public static MayFlyAppManager GetInstance()
        {
            if (instance == null)
            {
                instance = new MayFlyAppManager();
            }

            return instance;
        }

        /// <summary>
        /// Saves changes to all users.
        /// </summary>
        public void SaveAllChanges()
        {
            this.logInManager.SaveUsers();
        }

        /// <summary>
        /// Gets or Sets active class.
        /// </summary>
        public SchoolClass ActiveClass
        {
            get { return this.activeClass; }
            set { this.activeClass = value; }
        }

        /// <summary>
        /// Gets or Sets ActiveQuiz.
        /// </summary>
        public Quiz ActiveQuiz
        {
            get { return this.activeQuiz; }
            set { this.activeQuiz = value; }
        }

        /// <summary>
        /// Gets or Sets active user.
        /// </summary>
        public User ActiveUser
        {
            get { return this.activeUser; }
            set { this.activeUser = value; }
        }
    }
}
