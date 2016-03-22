//-----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Microsoft.Azure.DocumentDBStudio
{
    static class Program
    {
        private static MainForm _mainForm;
        public static List<TreeNode> _TreeViewCache = new List<TreeNode>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program._mainForm = new MainForm();
            Application.Run(Program._mainForm);
        }

        public static MainForm GetMain()
        {
            return Program._mainForm;
        }
    }
}