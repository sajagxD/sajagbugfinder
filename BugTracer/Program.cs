using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracer
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
			Application.Run(new login());
			//Application.Run(new Form2());
			//Application.Run(new create_bug());
			//Application.Run(new projects());
			//Application.Run(new create_users());
			//Application.Run(new Form1());
			//Application.Run(new managebugs());





		}


	}
}
