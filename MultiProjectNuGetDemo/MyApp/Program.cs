using MyLibrary;
using System;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using MyServices;



namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1----------");
            var calculator = new Calculator();
            int sum = calculator.Add(2, 2);
            Console.WriteLine("Suma 2+2");
            Console.WriteLine(sum);
            int sub = calculator.Subtract(2, 2);
            Console.WriteLine("Różnica 2-2");
            Console.WriteLine(sub);
            Console.WriteLine("Zadanie 2----------");
            int sum2 = calculator.Add(5,3);
            var result = new { Operation = "Add", A = 5, B = 3, Result = sum2 };
            string jsonResult = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(jsonResult);
            Console.WriteLine("Zadanie 3----------");
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILoggerService, Consolelogger>()
                .BuildServiceProvider();

            // Uzyskanie instancji loggera
            var logger = serviceProvider.GetService<ILoggerService>();
            logger.log("Aplikacja uruchomiona.");

            // Przykładowe użycie kalkulatora
            int sum3 = calculator.Add(10, 15);
            logger.log($"Wynik dodawania: {sum3}");

        }
    }
}
