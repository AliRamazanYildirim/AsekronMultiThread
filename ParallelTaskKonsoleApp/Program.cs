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

//            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Sekunden beendet.");

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

//            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Sekunden beendet.");

//        }

//    }
//}
#endregion

#region Parallel.ForEach Mit SixLabors.ImageSharp.Image
namespace ParallelTaskKonsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string bildWeg = @"C:\Users\Pro\TPL\";

            Directory.CreateDirectory(Path.Combine(bildWeg, "vorschauBild"));

            var daten = Directory.GetFiles(bildWeg);

            Parallel.ForEach(daten, (artikel) =>
            {
                Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);

                var image = Image.Load(artikel);

                image.Mutate(x => x.Resize(new ResizeOptions { Size = new Size(50, 50) }));
                image.Save(Path.Combine(bildWeg, "vorschauBild", Path.GetFileName(artikel)));

            });

            stopwatch.Stop();
            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Sekunden beendet.");

            stopwatch.Restart();
            stopwatch.Start();

            daten.ToList().ForEach(a =>
            {
                Console.WriteLine("Threadnummer:" + Thread.CurrentThread.ManagedThreadId);

                var image = Image.Load(a);

                image.Mutate(x => x.Resize(new ResizeOptions { Size = new Size(50, 50) }));
                image.Save(Path.Combine(bildWeg, "vorschauBild", Path.GetFileName(a)));

            });

            stopwatch.Stop();
            Console.WriteLine($"Der Vorgang wurde in {stopwatch.ElapsedMilliseconds} Sekunden beendet.");
        }
    }
}
#endregion
