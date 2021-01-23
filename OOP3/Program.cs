using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManeger ihtiyacKrediMenager = new IhtiyacKrediMenager();
            TasıtKrediMenager tasıtKrediMenager = new TasıtKrediMenager();
            KonutKrediMenager konutKrediMenager = new KonutKrediMenager();
            EsnafKredisiMenager esnafKredisiMenager = new EsnafKredisiMenager();
            //ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            //ILoggerService fileBaseLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService(), new FileLoggerService() };
            BasvuruMenager basvuruMenager = new BasvuruMenager();
            basvuruMenager.BasvuruYap(esnafKredisiMenager,loggers);
            Console.WriteLine("-------------");
            List<ICrediManeger> krediler = new List<ICrediManeger>(){ihtiyacKrediMenager,tasıtKrediMenager,konutKrediMenager,esnafKredisiMenager };
            basvuruMenager.KrediOnBilgilendirmesiYap(krediler,loggers);
        }
    }
}
