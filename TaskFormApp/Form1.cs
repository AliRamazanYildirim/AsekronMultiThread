using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFormApp
{
    public partial class Form1 : Form
    {
        public int theke { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BtnDateiLesen_Click(object sender, EventArgs e)
        {
            //string data = DateiLesen(); //Sekron
            string data = String.Empty;
            Task<String> lese = DateiLesenAsync();
            richTextBox2.Text = await new HttpClient().GetStringAsync("https://google.com");
            data = await lese;
            richTextBox.Text = data.ToString();
        }

        private void BtnTheke_Click(object sender, EventArgs e)
        {
            textBoxTheke.Text = theke++.ToString();
        }
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
    }
}
