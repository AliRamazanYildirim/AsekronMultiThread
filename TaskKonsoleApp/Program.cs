// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

namespace TaskKonsoleApp
{
    public class Inhalt
    {
        public string? Seite { get; set; }
        public int Länge { get; set; }

    }
    internal class Programm
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteLineAsync("Haupt Thread:" + Thread.CurrentThread.ManagedThreadId);
            List<string> urlListe = new List<string>()
            {
                 "https://www.google.com",
                 "https://www.microsoft.com",
                 "https://www.amazon.com",
                 "https://www.apple.com"
            };

            List<Task<Inhalt>> taskList = new List<Task<Inhalt>>();
            urlListe.ToList().ForEach(x =>
            {
                taskList.Add(RufeInhaltAufAsync(x));
            });

            var inhalte = await Task.WhenAll(taskList.ToArray());

            inhalte.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Seite}- Grösse:{x.Länge}");
            });
            static async Task<Inhalt> RufeInhaltAufAsync(string url)
            {
                Inhalt inhalt = new Inhalt();
                var daten = await new HttpClient().GetStringAsync(url);

                inhalt.Seite = url;
                inhalt.Länge = daten.Length;
                await Console.Out.WriteLineAsync("RufeInhaltAufAsync Thread:" + Thread.CurrentThread.ManagedThreadId);
                return inhalt;
            }
        }
    }



}

#region Task mit ContinueWith 
//var meineTask =new HttpClient().GetStringAsync("https://www.google.com").ContinueWith((daten)=>
//{
//    Console.WriteLine("Datengrösse:"+ daten.Result.Length);
//});
//Console.WriteLine("Zwischenarbeiten");
//await meineTask;
#endregion

#region Task ohne ContinueWith (Best practices)
//var meineTask = new HttpClient().GetStringAsync("https://www.google.com");
//Console.WriteLine("Zwischenarbeiten");

//var daten = await meineTask;
//Console.WriteLine("Datengrösse:" + daten.Length);

#endregion
