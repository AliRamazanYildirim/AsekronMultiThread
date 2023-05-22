// See https://aka.ms/new-console-template for more information
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskKonsoleApp
{
    class Program
    {
        private static bool Vorgang(int nummer)
        {
            return nummer % 2 == 0;
        }
        private  static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder();

            var array = Enumerable.Range(1, 100).ToList();

            array.Where(Vorgang).ToList().ForEach(nummer =>
            {
                stringBuilder.AppendLine(nummer.ToString());
            });
            Console.WriteLine(stringBuilder);

            var neueArray = array.AsParallel().Where(nummer => nummer % 2 == 0);


            neueArray.ToList().ForEach(nummer =>
            {
                stringBuilder.AppendLine(nummer.ToString());
            });
            Console.WriteLine(stringBuilder);
        }
    }
}
