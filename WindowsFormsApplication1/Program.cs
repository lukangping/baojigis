﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimpleForm;
using TestWF;

namespace WindowsFormsApplication1
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
            Application.Run(new MainForm());
            //PollutionConcentration pollutionConcentration = new PollutionConcentration(20, 20);
            //pollutionConcentration.calculate();
        }
    }

}
