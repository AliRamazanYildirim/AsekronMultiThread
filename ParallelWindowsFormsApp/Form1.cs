using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Parallel.ForEach CancellationToken-1
//namespace ParallelWindowsFormsApp
//{
//    public partial class Form1 : Form
//    {
//        CancellationTokenSource _cancellationToken;
//        private int theke { get; set; } = 0;
//        public Form1()
//        {
//            InitializeComponent();
//            _cancellationToken = new CancellationTokenSource();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            _cancellationToken = new CancellationTokenSource();
//            List<string> urls = new List<string>()
//            {
//                "https://www.google.com",
//                "https://www.amazon.com",
//                "https://www.microsoft.com",
//                "https://www.lenovo.com",
//                "https://www.dell.com",

//            };
//            HttpClient httpClient = new HttpClient();
//            ParallelOptions parallelOptions = new ParallelOptions();
//            parallelOptions.CancellationToken = _cancellationToken.Token;
//            Task.Run(() =>
//            {
//                try
//                {
//                    Parallel.ForEach<string>(urls, parallelOptions, (url) =>
//                    {
//                        string inhalt = httpClient.GetStringAsync(url).Result;
//                        string datei = $"{url}:{inhalt.Length}";
//                        _cancellationToken.Token.ThrowIfCancellationRequested();

//                        listBox1.Invoke((MethodInvoker)delegate
//                        {
//                            listBox1.Items.Add(datei);
//                        });

//                    });
//                }
//                catch (OperationCanceledException ex)
//                {

//                    MessageBox.Show("Der Vorgang wurde abgebrochen." + ex.Message);
//                }
//                catch (Exception ex)
//                {

//                    MessageBox.Show("Der Vorgang wurde beendet" + ex.Message);
//                }

//            });

//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            _cancellationToken.Cancel();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            button2.Text = theke++.ToString();
//        }
//    }
//}
#endregion

#region Parallel.ForEach CancellationToken-2
//namespace ParallelWindowsFormsApp
//{
//    public partial class Form1 : Form
//    {
//        CancellationTokenSource _cancellationToken;
//        private int theke { get; set; } = 0;
//        public Form1()
//        {
//            InitializeComponent();
//            _cancellationToken=new CancellationTokenSource();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            _cancellationToken = new CancellationTokenSource();
//            List<string>urls=new List<string>()
//            {
//                "https://www.google.com",
//                "https://www.amazon.com",
//                "https://www.microsoft.com",
//                "https://www.lenovo.com",
//                "https://www.dell.com",

//            };
//            HttpClient httpClient = new HttpClient();
//            ParallelOptions parallelOptions = new ParallelOptions();
//            parallelOptions.CancellationToken = _cancellationToken.Token;
//            Task.Run(() =>
//            {
//                try
//                {
//                    Parallel.ForEach<string>(urls, parallelOptions, (url) =>
//                    {
//                        string inhalt = httpClient.GetStringAsync(url).Result;
//                        string datei = $"{url}:{inhalt.Length}";
//                        parallelOptions.CancellationToken.ThrowIfCancellationRequested();

//                        listBox1.Invoke((MethodInvoker)delegate
//                        {
//                            listBox1.Items.Add(datei);
//                        });

//                    });
//                }
//                catch (OperationCanceledException ex)
//                {

//                    MessageBox.Show("Der Vorgang wurde abgebrochen." + ex.Message);
//                }
//                catch (Exception ex)
//                {

//                    MessageBox.Show("Der Vorgang wurde beendet" + ex.Message);
//                }

//            });

//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            _cancellationToken.Cancel();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            button2.Text = theke++.ToString();
//        }
//    }
//}
#endregion

#region Parallel.For CancellationToken
namespace ParallelWindowsFormsApp
{
    public partial class Form1 : Form
    {
        CancellationTokenSource _cancellationToken;
        private int theke { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            _cancellationToken = new CancellationTokenSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _cancellationToken = new CancellationTokenSource();
            List<string> urls = new List<string>()
            {
                "https://www.google.com",
                "https://www.amazon.com",
                "https://www.microsoft.com",
                "https://www.lenovo.com",
                "https://www.dell.com",

            };
            HttpClient httpClient = new HttpClient();
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = _cancellationToken.Token;
            Task.Run(() =>
            {
                try
                {
                    Parallel.For(0, urls.Count, parallelOptions, i =>
                    {
                        string inhalt = httpClient.GetStringAsync(urls[i]).Result;
                        string datei = $"{urls[i]}:{inhalt.Length}";
                        parallelOptions.CancellationToken.ThrowIfCancellationRequested();

                        listBox1.Invoke((MethodInvoker)delegate
                        {
                            listBox1.Items.Add(datei);
                        });
                    });
                }
                catch (OperationCanceledException ex)
                {

                    MessageBox.Show("Der Vorgang wurde abgebrochen." + ex.Message);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Der Vorgang wurde beendet" + ex.Message);
                }

            });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _cancellationToken.Cancel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = theke++.ToString();
        }
    }
}
#endregion