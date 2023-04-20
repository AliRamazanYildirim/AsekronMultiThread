// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

#region Task mit ContinueWith 
//var meineTask =new HttpClient().GetStringAsync("https://www.google.com").ContinueWith((daten)=>
//{
//    Console.WriteLine("Datengrösse:"+ daten.Result.Length);
//});
//Console.WriteLine("Zwischenarbeiten");
//await meineTask;
#endregion

#region Task ohne ContinueWith (Best practices)
var meineTask = new HttpClient().GetStringAsync("https://www.google.com");
Console.WriteLine("Zwischenarbeiten");

var daten = await meineTask;
Console.WriteLine("Datengrösse:" + daten.Length);

#endregion