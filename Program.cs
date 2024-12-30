using System;

namespace algoritma__uygulama_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Kaç öğrenci kaydetmek istiyorsunuz ?");
                int finishvalue = int.Parse(Console.ReadLine());
                Console.WriteLine("vizenin yüzde kaçını istersiniz ?");
                byte yüzde1 = byte.Parse(Console.ReadLine());
                Console.WriteLine("finalin yüzde kaçını istersiniz ?");
                byte yüzde2 = byte.Parse(Console.ReadLine());


                int toplamNot = 0;
                int endusuknot = int.MaxValue;
                int enyükseknot = int.MaxValue ;

                for (int i = 0; i < finishvalue; i++)
                {
                    int vize = 0, final = 0, notu = 0;

                    Console.WriteLine("öğrencinin numarasını giriniz.");
                    long numara = long.Parse(Console.ReadLine());
                    Console.WriteLine("öğrencinin adını giriniz.");
                    string ad = Console.ReadLine();
                    Console.WriteLine("öğrencinin soyadını giriniz.");
                    string soyad = Console.ReadLine();
                    Console.WriteLine("öğrencinin vize notunu 0 - 100 arası bir değer giriniz.");
                    vize = int.Parse(Console.ReadLine());
                    Console.WriteLine("öğrencinin final notunu 0 - 100 arası bir değer giriniz.");
                    final = int.Parse(Console.ReadLine());


                    if (vize < 0 || vize > 100 || final < 0 || final > 100)
                    {
                        Console.WriteLine("Vize ve final notları 0 ile 100 arasında olmalıdır. Lütfen tekrar giriniz.");
                        i--;
                        continue; 
                    }

                    notu = (vize * yüzde1 / 100) + (final * yüzde2 / 100);
                    toplamNot += notu;

                    if (notu < endusuknot)
                    {
                        endusuknot = notu; 
                    }
                    else if  (notu > enyükseknot)
                    {
                        enyükseknot = notu;
                    }


                    Console.WriteLine("ortalama={0}", notu);

                    if (notu <= 100 && notu >= 85)
                    {
                        Console.WriteLine("Harf notu : AA");
                    }
                    else if (notu <= 84 && notu >= 75)
                    {
                        Console.WriteLine("Harf notu : BA");
                    }
                    else if (notu <= 74 && notu >= 60)
                    {
                        Console.WriteLine("Harf notu : BB");
                    }
                    else if (notu <= 59 && notu >= 50)
                    {
                        Console.WriteLine("Harf notu : CB");
                    }
                    else if (notu <= 49 && notu >= 40)
                    {
                        Console.WriteLine("Harf notu : CC");
                    }
                    else if (notu <=39 && notu >= 30)
                    {
                        Console.WriteLine("Harf notu : DC");
                    }
                    else if (notu <=29 && notu >= 20)
                    {
                        Console.WriteLine("Harf notu : DD");
                    }
                    else if (notu <=19 && notu >=10)
                    {
                        Console.WriteLine("Harf notu : FD");
                    }
                    else if (notu <=9 && notu >=0)
                    {
                        Console.WriteLine("Harf notu : FF");
                    }

                    double ortalama = (double)toplamNot / finishvalue;
                    Console.WriteLine("Tüm öğrencilerin ortalama notu: {0}", ortalama);
                    Console.WriteLine("En düşük not: {0}", endusuknot);
                    Console.WriteLine("En yüksek not: {0}", enyükseknot);
                }
                
                   

            }
            catch (FormatException)
            {
                Console.WriteLine("HATA!!! Lütfen sayı ile giriniz.");
            }


           
































        }
        }
}
