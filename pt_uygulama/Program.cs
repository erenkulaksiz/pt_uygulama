using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt_uygulama
{
    class Program
    {
        // Programlama Temelleri uygulaması
        //
        // AD/SOYAD: Eren Kulaksız
        // SINIF:    10/A AMP
        // NO:       1411
        //
        // Amaç, tüm işlemleri bir metotta yapmak değil, sadece
        // matematiksel işlemleri metotlarda yaparak main metoduna
        // geri dönüş sağlamak.
        //
        // Eğer tüm işlemleri bir metotta yapsaydım aynı kodu main
        // metoduna yazarakda çalıştırabilirdik. Burada sadece
        // işlemleri koydum. Biraz farklı.
        //
        // Son güncelleme: 26.05.2019 22:00 civarları


        // Basit matematiksel işlemler
        public static int topla(int sayi1, int sayi2) { int sonuc = sayi1 + sayi2; return sonuc; }
        public static int cikar(int sayi1, int sayi2) { int sonuc = sayi1 - sayi2; return sonuc; }
        public static int carp(int sayi1, int sayi2) { int sonuc = sayi1 * sayi2; return sonuc; }
        public static int bol(int sayi1, int sayi2) { int sonuc = sayi1 / sayi2; return sonuc; }
        public static int kareal(int sayi) { int sonuc = sayi * sayi; return sonuc; }
        //////////////////////////////////////////
        public static int faktor(int sayi)
        {
            int sonuc = 1;

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }

            return sonuc;
        }
        //////////////////////////////////////////
        public static int asalbul(int sayi)
        {
            int sonuc = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sonuc++;
                }
            }

            return sonuc; // Sonuc > 1 ise sayı asaldır.
        }
        //////////////////////////////////////////
        public static int cifttek(int sayi)
        {
            int sonuc = 0;

            if (sayi % 2 == 0)
            {
                sonuc++;
            }

            return sonuc; // Sonuc == 1 ise sayı çifttir.
        }
        //////////////////////////////////////////
        public static int ortbul(int[] sayi)
        {
            int toplanacak = 0, toplanan = 0, sonuc = 0;

            int uzunluk = sayi.Length;

            for (int i = 0; i < uzunluk; i++)
            {
                toplanacak = sayi[i];
                toplanan += toplanacak;
            }

            sonuc = toplanan / uzunluk;

            return sonuc;
        }
        //////////////////////////////////////////
        public static int[] basamakayir(int sayi)
        {
            int[] basamak = new int[3]{
                0,0,0
            };

            int birler = sayi % 10;
            sayi = sayi / 10;
            basamak[0] = birler;
            int onlar = sayi % 10;
            sayi = sayi / 10;
            basamak[1] = onlar;
            int yuzler = sayi % 10;
            sayi = sayi / 10;
            basamak[2] = yuzler;

            return basamak; // 0 = birler // 1 = onlar // 2 = yüzler
        }
        //////////////////////////////////////////
        public static string tambolen(int sayi)
        {
            string sonuc = "";
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    if (sayi != i)
                    {
                        //Console.Write(i + "-");
                        sonuc += i + "-";
                    }
                    else
                    {
                        //Console.Write(i);
                        sonuc += i;
                    }
                }
            }
            return sonuc;
        }
        //////////////////////////////////////////
        public static int[] dizisirala(int[] dizi) { int[] sonuc = dizi; Array.Sort(sonuc);  return sonuc; }
        //////////////////////////////////////////

        static void Main(string[] args)
        {
            menuyedon:

            //////////////////////////////////////////////////////////////////
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   .----------------------------------------.");
            Console.WriteLine("   |                                       | |");
            Console.WriteLine("   |         Programlama Temelleri         | |");
            Console.WriteLine("   |              Uygulaması               | |");
            Console.WriteLine("   |                                       | |");
            Console.WriteLine("   .------------ İşlem Menüsü -------------| |");
            Console.WriteLine("   |                                       | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("1)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Toplama                      | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("2)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Çıkarma                      | |   .------------------------- .");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("3)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Çarpma                       | |  |                          | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("4)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bölme                        | |  |  Ad/Soyad: Eren Kulaksız | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("5)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kare Alma                    | |  |                          | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("6)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Faktöriyel Hesaplama         | |  |     Sınıf: 10/A AMP      | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("7)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Asal Sayı Bulma              | |  |                          | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("8)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Çift/Tek Sayı Kontrolü       | |  |       Numara: 1411       | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("9)  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ortalama Bulma               | |  |                          | |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("10) ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Basamaklarına Ayırma         | |  ;--------------------------* |");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("11) ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tam Bölen Bulma              | |   *___________________________;");
            //////////////////////////////////////////////////////////////////
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("12) ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Diziye Sıralama              | |");
            //////////////////////////////////////////////////////////////////
            Console.WriteLine("   |                                       | |");
            Console.Write("   |      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("13) ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menüden Çıkış                | |");
            //////////////////////////////////////////////////////////////////
            Console.WriteLine("   |                                       | ;");
            Console.Write("   ;---------------------------------------;*");
            //////////////////////////////////////////////////////////////////
            Console.Write("   > İşlem Seçiniz (1 ile 13): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int secilen_secenek = Convert.ToInt16(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            char secenek_donus;

            switch (secilen_secenek){
                //////////////////////////////////////////////////////////////////
                case 1:
                    // Toplama İşlemi
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      __________________");
                    Console.Write("      > Toplama İşlemi < \n");
                    Console.WriteLine("      __________________");
                    //////////////
                    Console.Write("\n > Birinci sayıyı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int topla_birincisayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n > İkinci sayıyı giriniz: ");
                    //////////////
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int topla_ikincisayi = Convert.ToInt16(Console.ReadLine());
                    //////////////
                    int topla_sonuc = topla(topla_birincisayi, topla_ikincisayi);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\n > "+topla_birincisayi+" + "+topla_ikincisayi+" = ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(topla_sonuc);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                    ///
                    break;
                ////////////////////////////////////////////////////////////////// 

                //////////////////////////////////////////////////////////////////
                case 2: 
                    // Çıkarma İşlemi
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      __________________");
                    Console.Write("      > Çıkarma İşlemi < \n");
                    Console.WriteLine("      __________________");
                    //////////////
                    Console.Write("\n > Birinci sayıyı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int cikarma_birincisayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n > İkinci sayıyı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int cikarma_ikincisayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    int cikarma_sonuc = cikar(cikarma_birincisayi, cikarma_ikincisayi);
                    Console.Write("\n\n > "+cikarma_birincisayi+" - "+cikarma_ikincisayi+" = ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(cikarma_sonuc);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                    break;
                ////////////////////////////////////////////////////////////////// 

                //////////////////////////////////////////////////////////////////
                case 3: 
                    // Çarpma İşlemi
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      _________________");
                    Console.Write("      > Çarpma İşlemi < \n");
                    Console.WriteLine("      _________________");
                    //////////////
                    Console.Write("\n > Birinci sayıyı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int carpma_birincisayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n > İkinci sayıyı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int carpma_ikincisayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    int carpma_sonuc = carp(carpma_birincisayi, carpma_ikincisayi);
                    Console.Write("\n\n > "+carpma_birincisayi+" x "+carpma_ikincisayi+" = ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(carpma_sonuc);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                    break;
                ////////////////////////////////////////////////////////////////// 

                //////////////////////////////////////////////////////////////////
                case 4:
                    // Bölme İşlemi
                    bolmetekrar:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      ________________");
                    Console.Write("      > Bölme İşlemi < \n");
                    Console.WriteLine("      ________________");
                    //////////////
                    Console.Write("\n > Birinci sayıyı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int bolme_birincisayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n > İkinci sayıyı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int bolme_ikincisayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    if (bolme_birincisayi < 1 || bolme_ikincisayi < 1)
                    {
                        Console.WriteLine("\n > Sayılar 0'dan büyük olmalı!");
                        Console.Write("\n > Tekrar girmek için bir tuşa basınız...");
                        Console.ReadKey();
                        goto bolmetekrar;
                    }
                    //////////////
                    int bolme_sonuc = bol(bolme_birincisayi, bolme_ikincisayi);
                    Console.Write("\n\n > "+bolme_birincisayi+" / "+bolme_ikincisayi+" = ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(bolme_sonuc);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                    break;
                ////////////////////////////////////////////////////////////////// 

                //////////////////////////////////////////////////////////////////
                case 5: 
                    // Kare Alma
                    karetekrar:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      _______________");
                    Console.Write("      >  Kare Alma  < \n");
                    Console.WriteLine("      _______________");
                    //////////////
                    Console.Write("\n > Bir sayı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int kareal_sayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    if (kareal_sayi < 1)
                    {
                        Console.WriteLine("\n > Sayı pozitif olmalı!");
                        Console.Write("\n > Tekrar girmek için bir tuşa basınız...");
                        Console.ReadKey();
                        goto karetekrar;
                    }
                    //////////////
                    int kareal_sonuc = kareal(kareal_sayi);
                    //////////////
                    Console.Write("\n\n > " + kareal_sayi + " sayısının karesi: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(kareal_sonuc);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                    
                    break;
                //////////////////////////////////////////////////////////////////      

                //////////////////////////////////////////////////////////////////
                case 6:
                    // Faktöriyel Hesaplama
                    fakttekrar:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      ________________");
                    Console.Write("      >  Faktöriyel  < \n");
                    Console.WriteLine("      ________________");
                    //////////////
                    Console.Write("\n > Bir sayı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int fakt_sayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    if (fakt_sayi < 2)
                    {
                        Console.WriteLine("\n > Sadece 2 ve üstündeki sayıların faktöriyelini bulabilirsiniz!");
                        Console.Write("\n > Tekrar girmek için bir tuşa basınız...");
                        Console.ReadKey();
                        goto fakttekrar;
                    }
                    //////////////
                    int fakt_sonuc = faktor(fakt_sayi);
                    //////////////
                    Console.Write("\n\n > "+fakt_sayi+"! = ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(fakt_sonuc);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////

                    break;
                ////////////////////////////////////////////////////////////////// 

                //////////////////////////////////////////////////////////////////
                case 7:
                    // Asal Sayı Kontrolü
                    asaltekrar:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      _______________");
                    Console.Write("      >  Asal Sayı  < \n");
                    Console.WriteLine("      _______________");
                    //////////////
                    Console.Write("\n > Bir sayı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int asalk_sayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    if (asalk_sayi < 1)
                    {
                        Console.WriteLine("\n > Sayı pozitif olmalı!");
                        Console.Write("\n > Tekrar girmek için bir tuşa basınız...");
                        Console.ReadKey();
                        goto asaltekrar;
                    }
                    //////////////
                    int asalk_sonuc = asalbul(asalk_sayi);
                    //////////////
                    string asalk_sonuc_str = "";
                    //////////////
                    if (asalk_sonuc > 1) { asalk_sonuc_str = " sayısı asal değildir."; } else { asalk_sonuc_str = " sayısı asaldır."; }
                    //////////////
                    Console.Write("\n\n > ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(asalk_sayi);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(asalk_sonuc_str);
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////

                    break;
                ////////////////////////////////////////////////////////////////// 

                //////////////////////////////////////////////////////////////////
                case 8:  
                    // Çift/Tek sayı kontrolü
                    cifttektekrar:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      ___________________________");
                    Console.Write("      >  Çift/Tek Sayı Kontrolü < \n");
                    Console.WriteLine("      ___________________________");
                    //////////////
                    Console.Write("\n > Bir sayı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int cts_sayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    if (cts_sayi < 1)
                    {
                        Console.WriteLine("\n > Sayı pozitif olmalı!");
                        Console.Write("\n > Tekrar girmek için bir tuşa basınız...");
                        Console.ReadKey();
                        goto cifttektekrar;
                    }
                    //////////////
                    int cts_sonuc = cifttek(cts_sayi);
                    //////////////
                    string cts_sonuc_str = "";
                    //////////////
                    if (cts_sonuc == 1) { cts_sonuc_str = " sayısı çifttir."; } else { cts_sonuc_str = " sayısı tektir."; }
                    Console.Write("\n\n > ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(cts_sayi);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(cts_sonuc_str);
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): "); 
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                    
                    break;
                ////////////////////////////////////////////////////////////////// 


                //////////////////////////////////////////////////////////////////
                case 9:
                    //////////////
                    orttekrar:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      ________________________");
                    Console.Write("      >  Ortalama Hesaplama  < \n");
                    Console.WriteLine("      ________________________");
                    //////////////
                    Console.Write("\n > Kaç sayı gireceksiniz?: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int ort_miktar = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    if (ort_miktar < 2)
                    {
                        Console.WriteLine("\n > En az 2 sayının ortalamasını bulabilirsiniz!");
                        Console.Write("\n > Tekrar girmek için bir tuşa basınız...");
                        Console.ReadKey();
                        goto orttekrar;
                    }
                    //////////////
                    int[] sayilar = new int[ort_miktar];
                    for(int i = 0; i < ort_miktar; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n > ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write((i+1));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(". sayıyı giriniz: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        int girensayi = Convert.ToInt16(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        if (girensayi < 1)
                        {
                            Console.WriteLine("\n > Sayı pozitif olmak zorundadır!");
                            Console.Write("\n > Tekrar girmek için bir tuşa basınız...");
                            Console.ReadKey();
                            goto orttekrar;
                        }
                        sayilar[i] = girensayi;
                    }
                    //////////////
                    int sonuc = ortbul(sayilar);
                    //////////////
                    Console.Write("\n > Sayıların Ortalaması: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(sonuc);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                    
                    break;
                ////////////////////////////////////////////////////////////////// 

                //////////////////////////////////////////////////////////////////
                case 10:
                    // Basamaklarına Ayırma
                    tekrarbasamak:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      _________________________");
                    Console.Write("      >  Basamaklarına Ayırma < \n");
                    Console.WriteLine("      _________________________");
                    //////////////
                    Console.Write("\n > Bir sayı giriniz (3 haneli): ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int basamak_sayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    if (basamak_sayi < 100 || basamak_sayi > 999)
                    {
                        Console.WriteLine("\n > Sayı 3 haneli ve pozitif olmak zorundadır!");
                        Console.Write("\n > Sayıyı tekrar girmek için bir tuşa basınız...");
                        Console.ReadKey();
                        goto tekrarbasamak;
                    }
                    //////////////
                    int[] basamaklar = new int[3]; 
                    basamaklar = basamakayir(basamak_sayi);
                    //////////////
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n > ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(basamak_sayi);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" sayısının;");

                    Console.Write("\n\n > Birler Basamağı: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(basamaklar[0]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n > Onlar  Basamağı: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(basamaklar[1]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n > Yüzler Basamağı: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(basamaklar[2]);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                     
                    break;
                ////////////////////////////////////////////////////////////////// 

                //////////////////////////////////////////////////////////////////
                case 11: 
                    // Tam Bölen bulma
                    tambolentekrar:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      ____________________");
                    Console.Write("      >  Tam Bölen Bulma < \n");
                    Console.WriteLine("      ____________________");
                    //////////////
                    Console.Write("\n > Bir sayı giriniz: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int tambolen_sayi = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    if (tambolen_sayi < 1)
                    {
                        Console.WriteLine("\n > Sayı pozitif olmak zorundadır!");
                        Console.Write("\n > Sayıyı tekrar girmek için bir tuşa basınız...");
                        Console.ReadKey();
                        goto tambolentekrar;
                    }
                    //////////////
                    string tambolen_sonuc = tambolen(tambolen_sayi);
                    //////////////
                    Console.Write("\n > ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(tambolen_sayi);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" sayısının tambölenleri: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(tambolen_sonuc);
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    //////////////
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                     
                    break;
                ////////////////////////////////////////////////////////////////// 


                ////////////////////////////////////////////////////////////////// 
                case 12: 
                    // Diziyi sıralama mevzusu 
                    siralatekrar:
                    //////////////
                    Console.Clear();
                    //////////////
                    Console.WriteLine();
                    Console.WriteLine("      ____________________");
                    Console.Write("      >  Diziye Sıralama < \n");
                    Console.WriteLine("      ____________________");
                    //////////////
                    int[] siralanmamis_dizi = new int[5];
                    int[] siralanmis_dizi = new int[5];
                    //////////////
                    for (int i = 0; i < 5; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n > ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write((i + 1));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(". sayıyı giriniz: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        int girensayi = Convert.ToInt16(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        if (girensayi > 100)
                        {
                            Console.WriteLine("\n > Sayı 100'den küçük olmak zorundadır!");
                            Console.Write("\n > Tekrar girmek için bir tuşa basınız...");
                            Console.ReadKey();
                            goto siralatekrar;
                        }
                        siralanmamis_dizi[i] = girensayi;
                    }
                    //////////////
                    Console.Write("\n\n > Sıralanmamış dizi: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    //////////////
                    foreach (int sayilar_siralanmamis_dizi in siralanmamis_dizi)
                    {

                        Console.Write(" "+sayilar_siralanmamis_dizi);
                    }
                    //////////////
                    siralanmis_dizi = dizisirala(siralanmamis_dizi);
                    //////////////
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\n > Sıralanmış dizi: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    //////////////
                    foreach (int sayilar_siralanmis_dizi in siralanmis_dizi)
                    {
                        Console.Write(" "+sayilar_siralanmis_dizi);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;
                    //////////////
                    ///
                    break;
                ////////////////////////////////////////////////////////////////// 
                

                /////////////////
                case 13: // Çıkış 
                    break;
                /////////////////


                //////////////////////////////////////////////////////////////////
                default:

                    Console.Clear();
                    Console.WriteLine("\n > Belirtilen seçenekteki işlem bulunamadı.");

                    //////////////
                    Console.Write("\n\n > Menüye dönmek ister misiniz? (E-H): ");
                    secenek_donus = Convert.ToChar(Console.ReadLine());
                    if (secenek_donus == 'E' || secenek_donus == 'e') goto menuyedon;

                    break;
                ////////////////////////////////////////////////////////////////// 
            }
        }
    }
}


           //////////////////////////////////////////////////////////////////////////
           // Murphy kanunu: birşeyin ters gitme olasılığı varsa, ters gidecektir. //
           //                                                                      //
           //            O yüzden en kötü olana hazırlanmamız gerek.               //
           //////////////////////////////////////////////////////////////////////////

