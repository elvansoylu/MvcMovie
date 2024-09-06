using MvcMovie.Models;

namespace MvcMovie.Helper
{
    public class VeriIslem
    {
        public Yemek YemekGetir(int id)
        {
            string[] urunler = {"","Kalem", "Defter", "Silgi" };
            double[] fiyatlar = { 0, 10, 23, 11 };

                string ad = urunler[id];
                double fiyat = fiyatlar[id];

            if(id>0&&id<urunler.Length)
            {
                Yemek y = new Yemek();
                y.YemekId = id;
                y.Ad = ad;
                y.Fiyat = fiyat;

                return y;
            }
            else
            {
                return null;
            }
               

           
        }
    }
}
