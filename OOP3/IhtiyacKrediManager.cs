using System;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void CiktiAl()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Hesaplandı");
        }
    }
}