using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustemer custemer1 = new RealCustemer();
            custemer1.CustemerNumber = "12345";
            custemer1.FirstName = "Mehmet Can";
            custemer1.LastName = "KARAYÜREK";
            custemer1.Id = 1;
            custemer1.TcNumber = "2222222222";

            LegalCustemer custemer2 = new LegalCustemer();
            custemer2.Id = 2;
            custemer2.CompanyName = "Karayürek LTD.ŞTİ";
            custemer2.CustemerNumber = "123456789";
            custemer2.TaxNumber = "5555555555";



            
        }
    }
}
