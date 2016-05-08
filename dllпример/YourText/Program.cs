using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace YourText
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main ( )
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new Starter() );
            Application.Exit();
        }


        static Assembly CurrentDomain_AssemblyResolve ( object sender, ResolveEventArgs args )
        {
            if ( args.Name.StartsWith("MySql.Data,") )
            {
                return Assembly.Load( Properties.Resources.MySql_Data );
            }
            else
                return null;
        }
    }
}
