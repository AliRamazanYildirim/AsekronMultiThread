// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
#region Parallel.ForEach Mit System.Drawing.Image
//using System.Drawing;

//namespace ParallelTaskKonsoleApp
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();

//            string bildWeg = @"C:\Users\Pro\TPL\";

//            Directory.CreateDirectory(Path.Combine(bildWeg, "vorschauBild"));

//            var daten = Directory.GetFiles(bildWeg);

//            Parallel.ForEach(daten, (artikel) =>
//            {
//                Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);
//                Image image = new Bitmap(artikel);

//                var vorschauBild = image.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);
//                vorschauBild.Save(Path.Combine(bildWeg, "vorschauBild", Path.GetFileName(artikel)));
//            });
//            stopwatch.Stop();

//            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Millisekunden beendet.");

//            stopwatch.Restart();
//            stopwatch.Start();

//            daten.ToList().ForEach(a =>
//            {
//                Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);
//                Image image = new Bitmap(a);

//                var vorschauBild = image.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);
//                vorschauBild.Save(Path.Combine(bildWeg, "vorschauBild", Path.GetFileName(a)));
//            });
//            stopwatch.Stop();

//            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Millisekunden beendet.");

//        }

//    }
//}
#endregion

#region Parallel.ForEach Mit SixLabors.ImageSharp.Image
//namespace ParallelTaskKonsoleApp
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();

//            string bildWeg = @"C:\Users\Pro\TPL\";

//            Directory.CreateDirectory(Path.Combine(bildWeg, "vorschauBild"));

//            var daten = Directory.GetFiles(bildWeg);

//            Parallel.ForEach(daten, (artikel) =>
//            {
//                Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);

//                var image = Image.Load(artikel);

//                image.Mutate(x => x.Resize(new ResizeOptions { Size = new Size(50, 50) }));
//                image.Save(Path.Combine(bildWeg, "vorschauBild", Path.GetFileName(artikel)));

//            });

//            stopwatch.Stop();
//            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Millisekunden beendet.");

//            stopwatch.Restart();
//            stopwatch.Start();

//            daten.ToList().ForEach(a =>
//            {
//                Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);

//                var image = Image.Load(a);

//                image.Mutate(x => x.Resize(new ResizeOptions { Size = new Size(50, 50) }));
//                image.Save(Path.Combine(bildWeg, "vorschauBild", Path.GetFileName(a)));

//            });

//            stopwatch.Stop();
//            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Millisekunden beendet.");
//        }
//    }
//}
#endregion

#region Parallel.ForEach-2
//namespace ParallelTaskKonsoleApp
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            long dateiByte = 0;
//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();

//            string bildWeg = @"C:\Users\Pro\TPL\";

//            Directory.CreateDirectory(Path.Combine(bildWeg, "vorschauBild"));

//            var daten = Directory.GetFiles(bildWeg);

//            Parallel.ForEach(daten, (artikel) =>
//            {
//                Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);
//                FileInfo datei=new FileInfo(artikel);
//                Interlocked.Add(ref dateiByte, datei.Length);
//            });
//            Console.WriteLine("Gesamtgröße:" + dateiByte.ToString());
//            stopwatch.Stop();
//            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Millisekunden erledigt.");
//        }
//    }
//}
#endregion

#region Parallel.ForEach Mit Interlocked.Increment
class Program
{
    static void Main(string[] args)
    {
        List<string> productList = new List<string>();
        int gesamtProdukte = 0;

        // Mehrere Threads erstellen und ausführen

        Thread[] threads = new Thread[3];
        #region Klassische for-Schleife 
        //for (int i = 0; i < threads.Length; i++)
        //{
        //    Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);

        //    threads[i] = new Thread(() => AddProducts(productList, ref totalProducts));
        //    Console.WriteLine($"Product {i}");

        //    threads[i].Start();
        //} 
        #endregion

        Parallel.ForEach(Enumerable.Range(0, threads.Length), thread =>
        {
            Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);

            threads[thread] = new Thread(() => AddProducts(productList, ref gesamtProdukte));
            Console.WriteLine($"Product {thread}");

            threads[thread].Start();
        });

        // Warten, bis alle Vorgänge abgeschlossen sind
        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("Gesamtzahl der Produkte: " + gesamtProdukte);
    }

    static void AddProducts(List<string> productList, ref int gesamtProdukte)
    {
        for (int i = 1; i <= 1000; i++)
        {
            productList.Add($"Product {i}");
            Interlocked.Increment(ref gesamtProdukte);

        }
    }
}
#endregion
