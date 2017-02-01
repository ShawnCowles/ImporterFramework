using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImporterFramework.Data;
using ImporterFramework.Workers;

namespace ImporterFramework
{
    public partial class ImportResultsForm<T> : Form where T : ImportContext
    {
        delegate void SetStatusCallback(string status, Color color);

        delegate void AddWorkResultCallback(WorkResult result);

        private Dictionary<string, string> _resultDetails;
        private readonly bool _autoCloseOnSuccess;

        public ImportResultsForm(
            string title, 
            T importContext, 
            IEnumerable<AbstractWorker<T>> workers,
            bool autoCloseOnSuccess = false)
        {
            InitializeComponent();

            _resultDetails = new Dictionary<string, string>();
            _autoCloseOnSuccess = autoCloseOnSuccess;

            Text = title;

            SetStatus("Initializing...", Color.Black);

            ImportAndValidate(importContext, workers);
        }

        private async void ImportAndValidate(T importContext, IEnumerable<AbstractWorker<T>> workers)
        {
            SetStatus("Importing...", Color.Black);

            var results = new List<WorkResult>();
            
            foreach (var worker in workers)
            {
                var result = await Task.Run(() => worker.DoWork(importContext));

                results.Add(result);
                AddWorkResult(result);

                if (!result.Success)
                {
                    break;
                }
            }

            if (results.All(r => r.Success))
            {
                SetStatus("Import Successful", Color.Green);

                if(_autoCloseOnSuccess)
                {
                    Dispose();
                }
            }
            else
            {
                SetStatus("Import Failed!", Color.Red);
            }
        }

        private void SetStatus(string status, Color color)
        {
            if (statusLabel.InvokeRequired)
            {
                Invoke(new SetStatusCallback(SetStatus), new object[] { status, color });
            }
            else
            {
                statusLabel.Text = status;
                statusLabel.ForeColor = color;
            }
        }

        private void AddWorkResult(WorkResult result)
        {
            if (resultsList.InvokeRequired)
            {
                Invoke(new AddWorkResultCallback(AddWorkResult), new object[] { result });
            }
            else
            {
                resultsList.Items.Add(result);
            }
        }


        private void resultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = resultsList.SelectedItem as WorkResult;

            if (item != null)
            {
                resultsDetailArea.Text = item.Message.Replace("\n", "\r\n");
            }
            else
            {
                resultsDetailArea.Text = "";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
