// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
#region Task.WhenAll 
//namespace TaskKonsoleApp
//{
//    public class Inhalt
//    {
//        public string? Seite { get; set; }
//        public int Länge { get; set; }

//    }
//    internal class Programm
//    {
//        static async Task Main(string[] args)
//        {
//            await Console.Out.WriteLineAsync("Haupt Thread:" + Thread.CurrentThread.ManagedThreadId);
//            List<string> urlListe = new List<string>()
//            {
//                 "https://www.google.com",
//                 "https://www.microsoft.com",
//                 "https://www.amazon.com",
//                 "https://www.apple.com"
//            };

//            List<Task<Inhalt>> taskList = new List<Task<Inhalt>>();
//            urlListe.ToList().ForEach(x =>
//            {
//                taskList.Add(RufeInhaltAufAsync(x));
//            });

//            var inhalte = await Task.WhenAll(taskList.ToArray());

//            inhalte.ToList().ForEach(x =>
//            {
//                Console.WriteLine($"{x.Seite}- Grösse:{x.Länge}");
//            });
//            static async Task<Inhalt> RufeInhaltAufAsync(string url)
//            {
//                Inhalt inhalt = new Inhalt();
//                var daten = await new HttpClient().GetStringAsync(url);

//                inhalt.Seite = url;
//                inhalt.Länge = daten.Length;
//                await Console.Out.WriteLineAsync("RufeInhaltAufAsync Thread:" + Thread.CurrentThread.ManagedThreadId);
//                return inhalt;
//            }
//        }
//    }
//}
#endregion

#region Task.WhenAny
//namespace TaskKonsoleApp
//{
//    public class Inhalt
//    {
//        public string? Seite { get; set; }
//        public int Länge { get; set; }

//    }
//    internal class Programm
//    {
//        static async Task Main(string[] args)
//        {
//            await Console.Out.WriteLineAsync("Haupt Thread:" + Thread.CurrentThread.ManagedThreadId);
//            List<string> urlListe = new List<string>()
//            {
//                 "https://www.google.com",
//                 "https://www.microsoft.com",
//                 "https://www.amazon.com",
//                 "https://www.apple.com"
//            };

//            List<Task<Inhalt>> taskList = new List<Task<Inhalt>>();
//            urlListe.ToList().ForEach(x =>
//            {
//                taskList.Add(RufeInhaltAufAsync(x));
//            });
//            var ersteDatei = await Task.WhenAny(taskList);
//            await Console.Out.WriteLineAsync($"{ersteDatei.Result.Seite}-{ersteDatei.Result.Länge}");

//            static async Task<Inhalt> RufeInhaltAufAsync(string url)
//            {
//                Inhalt inhalt = new Inhalt();
//                var daten = await new HttpClient().GetStringAsync(url);

//                inhalt.Seite = url;
//                inhalt.Länge = daten.Length;
//                await Console.Out.WriteLineAsync("RufeInhaltAufAsync Thread:" + Thread.CurrentThread.ManagedThreadId);
//                return inhalt;
//            }
//        }
//    }
//}
#endregion

#region Task.WaitAll
//namespace TaskKonsoleApp
//{
//    public class Inhalt
//    {
//        public string? Seite { get; set; }
//        public int Länge { get; set; }

//    }
//    internal class Programm
//    {
//        static async Task Main(string[] args)
//        {
//            await Console.Out.WriteLineAsync("Haupt Thread:" + Thread.CurrentThread.ManagedThreadId);
//            List<string> urlListe = new List<string>()
//            {
//                 "https://www.google.com",
//                 "https://www.microsoft.com",
//                 "https://www.amazon.com",
//                 "https://www.apple.com"
//            };

//            List<Task<Inhalt>> taskList = new List<Task<Inhalt>>();
//            urlListe.ToList().ForEach(x =>
//            {
//                taskList.Add(RufeInhaltAufAsync(x));
//            });
//            await Console.Out.WriteLineAsync("Vor der WaitAll-Methode");

//            bool resultat= Task.WaitAll(taskList.ToArray(),5000);

//            Console.WriteLine("Ist das in 3 Sekunden gekommen?" + resultat);

//            await Console.Out.WriteLineAsync("Nach der WaitAll-Methode");

//            await Console.Out.WriteLineAsync($"{taskList.First().Result.Seite}-{taskList.First().Result.Länge}");

//            static async Task<Inhalt> RufeInhaltAufAsync(string url)
//            {
//                Inhalt inhalt = new Inhalt();
//                var daten = await new HttpClient().GetStringAsync(url);

//                inhalt.Seite = url;
//                inhalt.Länge = daten.Length;
//                await Console.Out.WriteLineAsync("RufeInhaltAufAsync Thread:" + Thread.CurrentThread.ManagedThreadId);
//                return inhalt;
//            }
//        }
//    }
//}
#endregion

#region Task.WaitAny
//namespace TaskKonsoleApp
//{
//    public class Inhalt
//    {
//        public string? Seite { get; set; }
//        public int Länge { get; set; }

//    }
//    internal class Programm
//    {
//        static async Task Main(string[] args)
//        {
//            await Console.Out.WriteLineAsync("Haupt Thread:" + Thread.CurrentThread.ManagedThreadId);
//            List<string> urlListe = new List<string>()
//            {
//                 "https://www.google.com",
//                 "https://www.microsoft.com",
//                 "https://www.amazon.com",
//                 "https://www.apple.com"
//            };

//            List<Task<Inhalt>> taskList = new List<Task<Inhalt>>();
//            urlListe.ToList().ForEach(x =>
//            {
//                taskList.Add(RufeInhaltAufAsync(x));
//            });
//            await Console.Out.WriteLineAsync("Vor der WaitAll-Methode");

//            bool resultat = Task.WaitAll(taskList.ToArray(), 5000);

//            var ersterIndex = Task.WaitAny(taskList.ToArray());

//            Console.WriteLine("Ist das in 3 Sekunden gekommen?" + resultat);

//            await Console.Out.WriteLineAsync("Nach der WaitAll-Methode");

//            await Console.Out.WriteLineAsync($"{taskList[ersterIndex].Result.Seite}-{taskList[ersterIndex].Result.Länge}");

//            static async Task<Inhalt> RufeInhaltAufAsync(string url)
//            {
//                Inhalt inhalt = new Inhalt();
//                var daten = await new HttpClient().GetStringAsync(url);

//                inhalt.Seite = url;
//                inhalt.Länge = daten.Length;
//                await Console.Out.WriteLineAsync("RufeInhaltAufAsync Thread:" + Thread.CurrentThread.ManagedThreadId);
//                return inhalt;
//            }
//        }
//    }
//}
#endregion

#region Task.Delay
//namespace TaskKonsoleApp
//{
//    public class Inhalt
//    {
//        public string Seite { get; set; } = string.Empty;
//        public int Länge { get; set; }

//    }
//    internal class Programm
//    {
//        static async Task Main(string[] args)
//        {
//            await Console.Out.WriteLineAsync("Haupt Thread:" + Thread.CurrentThread.ManagedThreadId);
//            List<string> urlListe = new List<string>()
//            {
//                 "https://www.google.com",
//                 "https://www.microsoft.com",
//                 "https://www.amazon.com",
//                 "https://www.apple.com"
//            };

//            List<Task<Inhalt>> taskList = new List<Task<Inhalt>>();
//            urlListe.ToList().ForEach(x =>
//            {
//                taskList.Add(RufeInhaltAufAsync(x));
//            });

//            var inhalte = await Task.WhenAll(taskList.ToArray());

//            inhalte.ToList().ForEach(inhalt =>
//            {
//                Console.WriteLine($"{inhalt.Seite.ToString()} - {inhalt.Länge.ToString()}");
//            });

//            static async Task<Inhalt> RufeInhaltAufAsync(string url)
//            {
//                Inhalt inhalt = new Inhalt();
//                var daten = await new HttpClient().GetStringAsync(url);

//                await Task.Delay(3000); //Thread.Sleep(3000); Sekron

//                inhalt.Seite = url;
//                inhalt.Länge = daten.Length;
//                await Console.Out.WriteLineAsync("RufeInhaltAufAsync Thread:" + Thread.CurrentThread.ManagedThreadId);
//                return inhalt;
//            }
//        }
//    }
//}
#endregion

#region Task.StartNew
//public class Status
//{
//    public int ThreadID { get; set; }
//    public DateTime Datum { get; set; }
//}
//public class Program
//{
//    private async static Task Main(string[] args)
//    {
//        var meineTask = Task.Factory.StartNew((Obj) =>
//        {
//            Console.WriteLine("Meine Task wurde ausgeführt");
//            var status = Obj as Status;
//            status.ThreadID = Thread.CurrentThread.ManagedThreadId;
//        }, new Status()
//        {
//            Datum = DateTime.Now
//        });
//        await meineTask;
//        Status? status = meineTask.AsyncState as Status;

//        Console.WriteLine($"Datum: {status.Datum.ToString()}");
//        Console.WriteLine($"ThreadID: {status.ThreadID.ToString()}");

//    }
//}
#endregion

#region Task.FromResult
//internal class Program
//{
//    public static string CacheData { get; set; } = string.Empty;

//    private async static Task Main(string[] args)
//    {
//        CacheData = await RufeDateiAufAsync();
//        await Console.Out.WriteLineAsync(CacheData);
//    }

//    public async static Task<string> RufeDateiAufAsync()
//    {
//        if (String.IsNullOrEmpty(CacheData))
//        {
//            return await File.ReadAllTextAsync("Bewerbung.txt");
//        }
//        else
//        {
//            return await Task.FromResult(CacheData);
//        }
//    }
//}
#endregion

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

#region Task.Result
namespace TaskKonsoleApp
{
    //internal class Program
    //{
    #region Sekron
    //private async static Task Main(string[] args)
    //{
    //    Console.WriteLine(RufeDateiAuf());
    //}

    //public static string RufeDateiAuf()
    //{
    //    var task = new HttpClient().GetStringAsync("https://www.google.com");
    //    return task.Result;
    //}
    #endregion

    #region Asekron
    //private async static Task Main(string[] args)
    //{
    //    Console.WriteLine(await RufeDateiAuf());
    //}
    //public static async Task<string> RufeDateiAuf()
    //{
    //    var task = new HttpClient().GetStringAsync("https://www.google.com");
    //    return await task;
    //}
    #endregion

    #region Asekron Task.Result
    //private async static Task Main(string[] args)
    //{
    //    await RufeDateiAuf();

    //    var task = new HttpClient().GetStringAsync("https://www.google.com").ContinueWith((datei) =>
    //    {
    //        Console.WriteLine(datei.Result);
    //    });

    //    Console.WriteLine(await RufeDateiAuf());

    //}
    //public static async Task<string> RufeDateiAuf()
    //{
    //    await Task.Delay(5000); // Zum Beispiel 5 Sekunden warten.

    //    return "Es wurde eine Datei aufgerufen.";
    //}
    #endregion

    //}
}

#endregion

#region Task Instance
//namespace TaskKonsoleApp
//{
//    internal class Program
//    {
//        private async static Task Main(string[] args)
//        {
//            try
//            {
//                Task meineTask = Task.Run(() =>
//                {
//                    throw new ArgumentException("Ein Fehler ist aufgetreten");
//                    //Console.WriteLine("Meine Task wurde ausgeführt");
//                });
//                await meineTask;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Der Vorgang ist beendet: {ex.Message}"); 
//            }

//        }
//    }
//}
#endregion

#region ValueTask
//namespace TaskKonsoleApp
//{
//    internal class Program
//    {
#region Mit Task
//public static int zwischenspeicherDaten { get; set; } = 10;
//private async static Task Main(string[] args)
//{
//    await RufeDatenAuf();
//}
//public static Task<int> RufeDatenAuf()
//{
//    return Task.FromResult(zwischenspeicherDaten);
//} 
#endregion

#region Mit ValueTask
//public static int cacheDaten { get; set; } = 10;
//private async static Task Main(string[] args)
//{
//    var meineTask = RufenDatenAuf();
//    var resultat = await meineTask;
//    await Console.Out.WriteLineAsync($"Wert:{resultat}");
//}
//public static ValueTask<int> RufenDatenAuf()
//{
//    return new ValueTask<int>(cacheDaten);
//}
#endregion
//    }
//}
#endregion

#region Taskablauf
//namespace TaskKonsoleApp
//{
//    internal class Program
//    { 
//        private async static Task Main(string[] args)
//        {
//            Console.WriteLine("1.Schritt");
//            var meineTask = RufenDatenAuf();
//            Console.WriteLine("2.Schritt");
//            var inhalt = await meineTask;
//            Console.WriteLine("3.Schritt:"+inhalt.Length);

//        }
//        public static async Task<string> RufenDatenAuf()
//        {
//            var inhalt = await new HttpClient().GetStringAsync("https://www.google.com");
//            return inhalt;
//        }
//    }
//}
#endregion

#region ConfigureAwait
//namespace TaskKonsoleApp
//{
//    public class Program
//    {
//        public static async Task Main(string[] args)
//        {
//            var result = await AbrufenDateiVonApiAsync();
//            Console.WriteLine(result);
//        }

//        public static async Task<string?> AbrufenDateiVonApiAsync()
//        {
//            try
//            {
//                var client = new HttpClient();


//                var antwort = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1")
//                                             .ConfigureAwait(false);

//                if (!antwort.IsSuccessStatusCode)
//                {
//                    throw new Exception($"Error: {antwort.StatusCode}");
//                }

//                var json = await antwort.Content.ReadAsStringAsync().ConfigureAwait(false);

//                return json;

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString());// Im Falle eines Fehlers wird der Fehler protokolliert und null zurückgegeben.
//                return null;
//            }
//        }
//    }
//}
#endregion

#region ConfigureAwait-2
public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Thread starten: " + Thread.CurrentThread.ManagedThreadId);

        await BeispielAsyncMethod().ConfigureAwait(true);

        Console.WriteLine("Thread in Bearbeitung (ConfigureAwait(true)): " + Thread.CurrentThread.ManagedThreadId);

        await BeispielAsyncMethod().ConfigureAwait(false);

        Console.WriteLine("Thread in Bearbeitung (ConfigureAwait(false)): " + Thread.CurrentThread.ManagedThreadId);

        var resultat = await DownloadData();
        Console.WriteLine(resultat);
    }

    public static async Task BeispielAsyncMethod()
    {
        await Task.Delay(1000); // Wartezeit nur für Beispielzwecke

        Console.WriteLine("Thread in BeispielAsyncMethod: " + Thread.CurrentThread.ManagedThreadId);
    }

    public static async Task<HttpResponseMessage> DownloadData()
    {
        HttpClient client = new HttpClient();

        HttpResponseMessage antwort = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1").ConfigureAwait(false);

        Console.WriteLine("Thread zum Herunterladen von Daten: " + Thread.CurrentThread.ManagedThreadId);
        return antwort;

        // Sie können mit der Verarbeitung der Daten fortfahren

    }
}
#endregion



