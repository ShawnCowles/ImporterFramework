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

        private readonly T _importContext;
        private readonly IEnumerable<AbstractWorker<T>> _workers;

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
            _importContext = importContext;
            _workers = workers;
            SetStatus("Initializing...", Color.Black);
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
                if(_autoCloseOnSuccess)
                {
                    ShowSuccessAndClose();
                }
                else
                {
                    SetStatus("Import Successful", Color.Green);
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

        private void ShowSuccessAndClose()
        {
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }

            var successDisplay = new SuccessDisplay();
            Controls.Add(successDisplay);
            //AutoSize = true;
            FormBorderStyle = FormBorderStyle.None;
            Width = successDisplay.Width;
            Height = successDisplay.Height;
            CenterToScreen();
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

        private void ImportResultsForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            ImportAndValidate(_importContext, _workers);
        }
    }
}
