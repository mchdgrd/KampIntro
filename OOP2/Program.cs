namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Mücahid";
            //musteri1.Soyadi = "Gerede";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.MusteriNo = "123";
            //musteri1.SirketAdi = "";

            //Gerçek Müşteri- Tüzel Müşteri
            //farklı müşteri tipleri...
            //Bu teknik SOLID yazılım kurallarından geliyor(inheritance)

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.TcNo = "123456789";
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mücahid";
            musteri1.Soyadi = "Gerede";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "0123456789";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

        }
    }
}
