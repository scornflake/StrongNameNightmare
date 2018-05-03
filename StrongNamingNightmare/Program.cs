using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongNamingNightmare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly foo = Assembly.Load("Npgsql.EntityFrameworkCore.PostgreSQL, Version=2.0.2.0, Culture=neutral, PublicKeyToken=5d8b90d52f46fda7");
            Console.WriteLine("Got " + foo);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
