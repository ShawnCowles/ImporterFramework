using System;
using System.Linq;
using System.Windows.Forms;
using ImporterFramework.Workers;

namespace ImporterFramework.TestRun
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
            
            Application.Run(new ImportResultsForm<TestImportContext>(
                "Test Importer",
                new TestImportContext(),
                Enumerable.Empty<AbstractWorker<TestImportContext>>(),
                autoCloseOnSuccess: true));
        }
    }
}
