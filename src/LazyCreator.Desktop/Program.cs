using LazyCreator.Engines.Engines;
using LazyCreator.Interpreters;
using LazyCreator.Interpreters.ConsoleInterpreter;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyCreator.Desktop
{
    static class Program
    {
        private static Container _container;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _container = new Container();
            _container.Register<IInterpreter, Interpreter>();
            _container.Register<DesktopEngine>();
            _container.Verify();
            var engine = _container.GetInstance<DesktopEngine>();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame(engine));
        }
    }
}
