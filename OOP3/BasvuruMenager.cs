using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruMenager
    {
        public void BasvuruYap(ICrediManeger crediManeger,List<ILoggerService> loggerService)
        {
          crediManeger.Calculate();
            foreach (var loggerServices in loggerService)
            {
                loggerServices.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<ICrediManeger> krediler,List<ILoggerService> loggers)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
            foreach (var loggerServiceS in loggers)
            {
                loggerServiceS.Log();
            }
            
        }
    }
}
