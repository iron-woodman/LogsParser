﻿using System;
using System.Windows.Forms;

namespace LogsParser {
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault( false );
                Application.Run( new frmGlobalUI() );
            }
            catch (Exception ex){
                MessageBox.Show( ex.Message,
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
