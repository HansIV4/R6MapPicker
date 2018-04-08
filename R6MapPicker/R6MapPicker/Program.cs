//-----------------------------------------------------------------------
// <copyright file="Program.cs" company = "HansIV4" >
//     Copyright (c) HansIV4. All rights reserved.
//      Name: HansIV4
//      Goal: The entry point behind an app that will randomly select one of the enabled elements in the UI
//      Date: 01/04/2018
// </copyright>
//-----------------------------------------------------------------------

namespace R6MapPicker
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The entry point of the program
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
