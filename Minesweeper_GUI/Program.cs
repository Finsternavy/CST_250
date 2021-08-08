using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_GUI
{
    static class Program
    {
        public static StartMenu startMenu = new StartMenu();
        //public static GameBoard gameBoard = new GameBoard(startMenu);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //GameBoard gameBoard = new GameBoard(startMenu);
            Application.Run(new GameBoard(startMenu));
        }
    }
}
