using Microsoft.AspNetCore.Mvc;

namespace TestCore8._0.Controllers
{
    public class OOPController : Controller
    {
        public IActionResult Index()
        {
            Ders ders = new Ders();
            double sonuc = ders.MatOrtalama(75, 85);

            ders.Name = "deniz";
            ders.Soyad = "sevgiler";
            string ss = ders.FullName;

            ViewBag.Sonuc = sonuc;

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Name = "deniz";
            ogrenci.Soyad = "sevgiler";
            string adsoyad = ogrenci.FullName;


            int sayi = 10;

            bool m = sayi.Ciftmi();


            return View();

        }



        private class Ogrenci
        {
            public int Id { get; set; }
            public string Soyad { get; set; }


            private string _name;
            public string Name
            {
                get => _name; 
                set => _name = value; 
            }

            public virtual string FullName  
            {
                // get { return Name + " " + Soyad; }
                get => Name + " " + Soyad; 
            }

            public virtual string deneme(string isim) => isim = isim.ToLower();



        }

        class Ders : Ogrenci
        {

            public void calculate(int a, int b)
            {

            }

            public virtual double MatOrtalama(int x, int y)
            {
                return (x + y) / 2;
            }

            public override string FullName => Name.ToLower() + Soyad.ToUpper(); 
        }




    }


    public static class extentionmetodlar
    {
        public static bool Ciftmi(this int sayi)
        {
            return sayi % 2 == 0;
        }

       
    }




}
