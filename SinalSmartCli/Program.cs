using SimpleInjector;
using SinalSmartCli.Proxy;
using System;
using System.Windows.Forms;

namespace SinalSmartCli {
    static class Program {
        private static Container Conteiner;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new SignalForm(Conteiner.GetInstance<IServiceHub>()));
        }

        private static void Bootstrap() {
            // Create the container as usual.
            Conteiner = new Container();

            // Register your types, for instance:
            Conteiner.Register<IServiceHub, ServiceHub>(Lifestyle.Singleton);

            // Optionally verify the container.
            Conteiner.Verify();
        }
    }
}
