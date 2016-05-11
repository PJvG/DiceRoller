// Project created: 2016-01-24
// By: Pieterjan P.J.G. van Gastel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Simple_Dice_Roller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiceRollerForm());
        }
    }
}
