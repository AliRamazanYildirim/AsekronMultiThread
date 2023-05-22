// See https://aka.ms/new-console-template for more information
using PLINQKonsoleApp.Modelle;
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
namespace TaskKonsoleApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            AdventureWorks2019Context kontext = new AdventureWorks2019Context();
            kontext.Products.Take(10).ToList().ForEach(p =>
            {
                Console.WriteLine(p.Name);
            });
        }
    }
}
#endregion