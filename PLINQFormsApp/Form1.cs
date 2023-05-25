using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLINQFormsApp
{
    public partial class Form1 : Form
    {
        CancellationTokenSource _cancellationTokenSource;
        public Form1()
        {
            InitializeComponent();
            _cancellationTokenSource=new CancellationTokenSource();
        }
        private bool Berechne(int x)
        {
            Thread.SpinWait(1000000);
            return x % 12 == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    Enumerable.Range(1, 1000).AsParallel().AsOrdered().WithCancellation(_cancellationTokenSource.Token).Where(Berechne).ToList().ForEach(x =>
                    {
                        Thread.Sleep(100);
                        _cancellationTokenSource.Token.ThrowIfCancellationRequested();
                        listBox1.Invoke((MethodInvoker)delegate
                        {
                            listBox1.Items.Add(x);
                        });
                    });
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Der Vorgang wurde abgebrochen.");
                }
                catch (Exception)
                {

                    throw;
                }
                
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }
    }
}
