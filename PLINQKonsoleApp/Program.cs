// See https://aka.ms/new-console-template for more information
using PLINQKonsoleApp.Modelle;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
#region PLINQ AsParallel Methode
//namespace TaskKonsoleApp
//{
//    class Program
//    {
//        private static bool Vorgang(int nummer)
//        {
//            return nummer % 2 == 0;
//        }
//        private static void Main(string[] args)
//        {
//            var stringBuilder = new StringBuilder();

//            var array = Enumerable.Range(1, 100).ToList();

//            array.Where(Vorgang).ToList().ForEach(nummer =>
//            {
//                stringBuilder.AppendLine(nummer.ToString());
//            });
//            Console.WriteLine(stringBuilder);

//            var neueArray = array.AsParallel().Where(nummer => nummer % 2 == 0);


//            neueArray.ToList().ForEach(nummer =>
//            {
//                stringBuilder.AppendLine(nummer.ToString());
//            });
//            Console.WriteLine(stringBuilder);
//        }
//    }
//}
#endregion

#region PLINQ ForAll Methode
//namespace TaskKonsoleApp
//{
//    class Program
//    {
//        private static bool Vorgang(int nummer)
//        {
//            return nummer % 2 == 0;
//        }
//        private static void Main(string[] args)
//        {

//            var array = Enumerable.Range(1, 100).ToList();

//            var neueArray = array.AsParallel().Where(Vorgang);


//            //neueArray.ToList().ForEach(nummer =>
//            //{
//            //    Thread.Sleep(500);
//            //    Console.WriteLine(nummer);
//            //});

//            #region Mit ForAll
//            neueArray.ForAll(nummer =>
//            {
//                Thread.Sleep(500);
//                Console.WriteLine($"Nummer {nummer} wurde mit Thread: {Thread.CurrentThread.ManagedThreadId} gerechnet.");
//            });
//            #endregion
//        }
//    }
//}
#endregion

#region AdventureWorks2019 Database First
//namespace TaskKonsoleApp
//{
//    class Program
//    {
//        private static void Main(string[] args)
//        {
//            AdventureWorks2019Context kontext = new AdventureWorks2019Context();
//            kontext.Products.Take(10).ToList().ForEach(p =>
//            {
//                Console.WriteLine(p.Name);
//            });
//        }
//    }
//}
#endregion

#region PLINQ-Abfrage über Entity schreiben
namespace TaskKonsoleApp
{
    class Program
    {
        private static void SchreibenProtokollierung(Product p)
        {
            Console.WriteLine(p.Name+ " wurde protokolliert.");
        }
        private static void Main(string[] args)
        {
            AdventureWorks2019Context kontext = new AdventureWorks2019Context();

            #region Mit AsParallel Methode
            //var produkt = (from p in kontext.Products.AsParallel()
            //               where p.ListPrice > 10M
            //               select p).Take(10);
            //produkt.ForAll(p =>
            //{
            //    Console.WriteLine(p.Name);
            //});
            #endregion

            #region Ohne AsParallel Methode
            //var produkt = (from p in kontext.Products
            //               where p.ListPrice > 10M
            //               select p).Take(10);
            //produkt.ToList().ForEach(p =>
            //{
            //    Console.WriteLine(p.Name);
            //}); 
            #endregion

            kontext.Products.AsParallel().ForAll(p =>
            {
                SchreibenProtokollierung(p);
            });
        }
    }
}
#endregion