using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFormApp
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancellation = new CancellationTokenSource();//Global kann man verwenden

        public int theke { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnTheke_Click(object sender, EventArgs e)
        {
            textBoxTheke.Text = theke++.ToString();
        }
        #region Dateilesen
        //private async void BtnDateiLesen_Click(object sender, EventArgs e)
        //{
        //    //string data = DateiLesen(); //Sekron
        //    string data = String.Empty;
        //    Task<String> lese = DateiLesenAsync();
        //    richTextBox2.Text = await new HttpClient().GetStringAsync("https://google.com");
        //    data = await lese;
        //    richTextBox.Text = data.ToString();

        //    var task1 =  RufeAuf(progressBar1);

        //    var task2 =  RufeAuf(progressBar2);

        //    await Task.WhenAll(task1, task2);

        //}
        #endregion

        #region Sekron 

        //private string DateiLesen()
        //{
        //    string data = string.Empty;
        //    using(StreamReader streamReader = new StreamReader("Bewerbung.txt"))
        //    {
        //        Thread.Sleep(5000);
        //        data=streamReader.ReadToEnd();
        //    }
        //    return data;
        //}
        #endregion

        #region Asekron 
        //private async Task<string> DateiLesenAsync()
        //{
        //    string data = string.Empty;
        //    using (StreamReader streamReader = new StreamReader("Bewerbung.txt"))
        //    {
        //        Task<string> meineTask = streamReader.ReadToEndAsync();
        //        await Task.Delay(5000);
        //        data = await meineTask;
        //    }
        //    return data;
        //}
        #endregion

        #region Asekron ohne await
        private Task<string> DateiLesenAsync()
        {
            StreamReader streamReader = new StreamReader("Bewerbung.txt");

            return streamReader.ReadToEndAsync();

        }
        #endregion

        #region Task.Run

        public async Task RufeAuf(ProgressBar bar)
        {
            await Task.Run(() =>
            {
                Enumerable.Range(1, 100).ToList().ForEach(x =>
                {
                    Task.Delay(100);
                    bar.Invoke((MethodInvoker)delegate { bar.Value = x; });
                });
            });
            
        }
        #endregion

        #region Task.CancellationToken

        private async void BtnDateiLesen_Click(object sender, EventArgs e)
        {
            Task<HttpResponseMessage> meineTask;

            try
            {
                string data = String.Empty;
                Task<String> lese = DateiLesenAsync();
                data = await lese;
                richTextBox.Text = data.ToString();

                var task1 = RufeAuf(progressBar1);

                var task2 = RufeAuf(progressBar2);

                await Task.WhenAll(task1, task2);



                meineTask = new HttpClient().GetAsync("https://localhost:7292/api/task", cancellation.Token);

                await meineTask;

                var inhalt = await meineTask.Result.Content.ReadAsStringAsync();
                richTextBox2.Text = inhalt;
            }
            catch (TaskCanceledException exception)
            {
                MessageBox.Show(exception.Message);
                //throw;
            }
            catch (Exception ex)
            {
                // Verwaltung der verbleibenden Fehler
                MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
            }

        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            cancellation.Cancel();
        }
        #endregion


    }
}
