using Microsoft.Extensions.Logging;
using System;

namespace DotNet.DependecyInjection.ConsoleApp
{
    class MyClass
    {
        private readonly ILogger _logger;

        public string Message { get; set; }

        public MyClass(ILogger<MyClass> logger)
        {
            _logger = logger;
        }

        public void WriteMessage()
        {
            Message = $"Main Run {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
            Console.WriteLine("Finsihed WriteMessage");
        }
    }
}
