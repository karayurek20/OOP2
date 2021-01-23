using OOP3;
using System;

class FileLoggerService : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("dosyaya loglama yapıldı");
    }
}