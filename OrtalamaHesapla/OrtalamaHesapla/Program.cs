using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesapla
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.
            //Dikkat Edilmesi Gereken Noktalar :
            //Kod tekrarından kaçınılmalı
            //Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.


            Console.WriteLine("Adet sayısı giriniz");
            int s = int.Parse(Console.ReadLine());
            Metotlar m = new Metotlar();
            m.hesapla(s);
            Console.ReadKey();
        }
        public class Metotlar
        {
            int a = 0;
            int b = 1;
            int c;
            int toplam = 0;

            public void hesapla(int s)
            {
                for (int i = 1; i <= s; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;

                    toplam += c;
                }
                Console.WriteLine("Dizinin ortalaması :" + toplam / s);
            }
        }
    }
}
