namespace BANKAMATİK;

class Program
{
    static void Main(string[] args)
    {






           
//BANKAMATİK



        //İFADELERİAÇIKLAMA
        double bakiye = 2500;
        double faturatutarı = 0;
        double cekilicektutar = 0;
        double yatırılacaktutar = 0;
        string sifre = "ab18";
        int denemehakki = 3;

        {   
            

             //ŞİFRE SORMA BÖLÜMÜ
            ŞİFRESORMA:
            Console.WriteLine("Kartlı İşlem İçin Şifrenizi Giriniz.");
            string şifre = Console.ReadLine();
        GİRİŞ:
            if (sifre == şifre)
            {   ANAMENU:
                Console.WriteLine("---Giriş Başarılı.Yedi İşlemden Birini Seçiniz---.");
            
                Console.WriteLine("1-Para Çekme");
                Console.WriteLine("2-Para Yatırma");
                Console.WriteLine("3-Para Transferi");
                Console.WriteLine("4-Eğitim Ödemeleri");
                Console.WriteLine("5-Ödemeler");
                Console.WriteLine("6-Bilgi Güncelleme");
                Console.WriteLine("7- Çıkış Yap");
                string ANAMENUSECIMKISMI = Console.ReadLine();
                switch (ANAMENUSECIMKISMI)
                {
                    case "1":
                        Console.Clear();
                    PARAÇEKME:
                        Console.WriteLine("***PARA ÇEKME BÖLÜMÜ***");
                        Console.WriteLine("Çekmek İstediğiniz Para Miktarı Giriniz");

                        try
                        {
                            cekilicektutar = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("numara dışında bir hane girmeyiniz");
                            goto PARAÇEKME;
                        }

                        if (cekilicektutar > bakiye)
                        {
                            Console.WriteLine("BAKİYENİZ GİRDİĞİNİZ TUTAR İÇİN YETERLİ DEĞİLDİR");
                            goto ANAMENU;

                        }
                        else if (cekilicektutar < bakiye)
                        {
                            bakiye = bakiye - cekilicektutar;
                            Console.WriteLine("PARA BAŞARIYLA ÇEKİLMİŞTİR.***YENİ BAKİYENİZ {0}TLDİR***.", bakiye);
                            Console.Clear();
                            goto ANAMENU;

                        }
                        break;

                    case "2":
                    PARAYATIRMABÖLÜMÜ:
                        Console.WriteLine("***PARA YATIRMA BÖLÜMÜ***");

                        Console.WriteLine("1-Kredi Kartına");
                        Console.WriteLine("2-Kendi Hesabınıza");
                        Console.WriteLine("Ana Menüye Dönmek için 9 Değerini Giriniz.");
                        Console.WriteLine("Çıkmak İçin 0 Değerini Giriniz.");

                        string parayatırmabölümü = Console.ReadLine();
                        if (parayatırmabölümü == "1")
                        {
                            Console.WriteLine("  12 HANELİ KREDİ KARTI NUMARASINI GİRİN.");
                            Console.Clear();
                            string kredikartnmr = Console.ReadLine();
                            if (kredikartnmr.Length == 12)
                            {
                            PARAYATIRMABOLUMU:
                                Console.WriteLine("Yatırılıcak Para Miktarını giriniz");
                                try
                                {
                                    yatırılacaktutar = Convert.ToDouble(Console.ReadLine());
                                }

                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Sadece Numara Giriniz.");
                                    goto PARAYATIRMABOLUMU;
                                }


                            }
                            else if (kredikartnmr.Length <= 11)
                            {
                                Console.WriteLine("12 HANELİ SAYI GİRİNİZ");
                            }
                            if (yatırılacaktutar > bakiye)
                            {
                                Console.WriteLine("Yatırılıcak Miktar Bakiyeden Büyük Olamaz");
                            }
                            if (yatırılacaktutar == 0)
                            {
                                Console.Clear();
                                goto ANAMENU;
                            }

                            else
                            {
                                bakiye = bakiye - yatırılacaktutar;
                                Console.Clear();
                                Console.WriteLine("Para Yatırma Gerçekleşmiştir.***YENİ BAKİYENİZ {0}TLDİR.", bakiye);
                                goto ANAMENU;

                            }



                        }

                        else if (parayatırmabölümü == "2")
                        {
                        KENDİHESABINAPARAYATIRMA:
                            Console.Clear();
                            Console.WriteLine("ANAMENÜYE DÖNMEK İÇİN 0 DEĞERİNİ GİRİNİZ");
                            Console.WriteLine("");
                            Console.WriteLine(" KENDİ HESABINIZA YATIRMAK İSTEDİĞİNİZ MİKTARI GİRİNİZ");

                            if (yatırılacaktutar == 0)
                            {
                                Console.Clear();
                                goto ANAMENU;
                            }
                            else if (yatırılacaktutar < bakiye)
                            {
                                Console.Clear();
                                bakiye = bakiye + yatırılacaktutar;
                                Console.WriteLine("PARA YATIRMA İŞLEMİNİZ GERÇEKLEŞMİŞTİR.***YENİ BAKİYENİZ {0}TLDİR.", bakiye);
                            }
                            else
                            {
                                Console.WriteLine("DOĞRU DEĞERLER GİRMEMİŞ OLABİLİRSİNİZ VEYA BAKİYENİZ YETERLİ DEĞİLDİR.");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                goto ANAMENU;
                            }



                        }
                        break;

                    case "3":
                    PARATRANSFERLERİ:
                        Console.Clear();
                        Console.WriteLine("1---EFT BAŞKA HESABA");
                        Console.WriteLine("2---HAVALE BAŞKA HESABA");
                        Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 0 GİR");

                        string paratransferbölüm = Console.ReadLine();
                        if (paratransferbölüm == "1")
                        {
                        EFTBÖLÜMÜ:
                            Console.Clear();
                            Console.WriteLine("Başında TR Olan 12 Haneli EFT Numaranızı Giriniz.");
                            string eftno = Console.ReadLine();
                            if (eftno[0] != 'T' || eftno[1] != 'R')
                            {
                                Console.WriteLine("EFT NUMARASININ TR İLE BAŞLADIĞINNDAN EMİN OLUNUZ VE KONTROL EDİNİZ");
                                goto EFTBÖLÜMÜ;
                            }
                            else if (eftno.Length != 14)
                            {
                                Console.WriteLine("EFT NUMARASININ TOPLAM HANESİNİN 14 HANELİ OLDUĞUNDAN EMİN OLUNUZ");
                                goto EFTBÖLÜMÜ;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-------EFT İÇİN SORGULAR------");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("GÖNDERİLİCEK PARA MİKTARINI YAZINIZ");

                                try
                                {
                                    yatırılacaktutar = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("!!!SADECE NUMARA GİRİNİZ.!!!");
                                    goto EFTBÖLÜMÜ;
                                }
                                if (yatırılacaktutar == 0)
                                {
                                    Console.WriteLine("!!!!ANA MENÜYE GİDİYORSUNUZ.!!!!");
                                    Console.Clear();
                                    goto ANAMENU;

                                }
                                if (yatırılacaktutar < bakiye)
                                {
                                    Console.Clear();
                                    bakiye = bakiye - yatırılacaktutar;
                                    Console.WriteLine("EFT BAŞARIYLA GERÇEKLEŞMİŞTİR.BAKİYENİZİ AŞAĞIDAN KONTROL EDEBİLİRSİNİZ.");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("***YENİ BAKİYENİZ {0}TLDİR.", bakiye);
                                    Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 9 GİRİNİZ");

                                }
                                if (yatırılacaktutar > bakiye)
                                {
                                    Console.WriteLine("!!!YATIRILICAK TUTAR BAKİYEDEN BÜYÜK OLAMAZ!!!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 9 GİRİNİZ");
                                }
                            }
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("----------BURASI BİR SÜRELİĞİNE ARIZALIDIR----------");
                        Console.WriteLine("----------BU SORUNDAN DOLAYI ÖZÜR DİLERİZ:))----------");
                        goto ANAMENU;
                        break;

                    case "5":
                        Console.Clear();
                    FATURALARKISMI:
                        Console.WriteLine("-----FATURALAR-----");
                        Console.WriteLine("9-ANA MENÜ");
                        Console.WriteLine("0-ÇIKIŞ YAPMA");
                        Console.WriteLine("1- --ELEKTRİK FATURASI--");
                        Console.WriteLine("2- --TELEFON FATURASI--");
                        Console.WriteLine("3- --İNTERNET FATURASI--");
                        Console.WriteLine("4- --SU FATURASI--");
                        Console.WriteLine("5- --OGS ÖDEMELERİ--");
                        string faturaseçimkısmı = Console.ReadLine();

                        if (faturaseçimkısmı == "1")
                            Console.Clear();
                        ELEKTRİKFATURA:
                        Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 0 GİRİNİZ");
                        Console.WriteLine("ÖDENECEK FATURA MİKTARINI GİRİNİZ");
                        try
                        {
                            yatırılacaktutar = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("!!SADECE NUMARA GİRİN!!!");
                        }
                        if (yatırılacaktutar > bakiye)
                        {
                            Console.WriteLine("!! Yatırılıcak Tutar Bakiyeden Büyük Olamaz !!");
                            goto FATURALARKISMI;
                        }
                        else if (yatırılacaktutar < bakiye)
                        {
                            bakiye = bakiye - yatırılacaktutar;
                            Console.WriteLine("FATURA ÖDENMİŞTİR.YENİ FATURANIZ AŞAĞIDADIR.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("***YENİ BAKİYENİZ {0}TLDİR.", bakiye);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ANA MENÜYE DÖNDÜNÜZ.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            goto ANAMENU;
                        }
                        if (faturaseçimkısmı == "2")
                            Console.Clear();
                        TELEFONFATURA:
                        Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 0 GİRİNİZ");
                        Console.WriteLine("ÖDENECEK FATURA MİKTARINI GİRİNİZ");
                        try
                        {
                            yatırılacaktutar = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("!!SADECE NUMARA GİRİN!!!");
                        }
                        if (yatırılacaktutar > bakiye)
                        {
                            Console.WriteLine("!! Yatırılıcak Tutar Bakiyeden Büyük Olamaz !!");
                            goto FATURALARKISMI;
                        }
                        else if (yatırılacaktutar < bakiye)
                        {
                            bakiye = bakiye - yatırılacaktutar;
                            Console.WriteLine("FATURA ÖDENMİŞTİR.YENİ FATURANIZ AŞAĞIDADIR.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("***YENİ BAKİYENİZ {0}TLDİR.", bakiye);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ANA MENÜYE DÖNDÜNÜZ.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            goto ANAMENU;
                        }
                        if (faturaseçimkısmı == "3")
                            Console.Clear();
                        INTERNETFATURA:
                        Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 0 GİRİNİZ");
                        Console.WriteLine("ÖDENECEK FATURA MİKTARINI GİRİNİZ");
                        try
                        {
                            yatırılacaktutar = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("!!SADECE NUMARA GİRİN!!!");
                        }
                        if (yatırılacaktutar > bakiye)
                        {
                            Console.WriteLine("!! Yatırılıcak Tutar Bakiyeden Büyük Olamaz !!");
                            goto FATURALARKISMI;
                        }
                        else if (yatırılacaktutar < bakiye)
                        {
                            bakiye = bakiye - yatırılacaktutar;
                            Console.WriteLine("FATURA ÖDENMİŞTİR.YENİ FATURANIZ AŞAĞIDADIR.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("***YENİ BAKİYENİZ {0}TLDİR.", bakiye);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ANA MENÜYE DÖNDÜNÜZ.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            goto ANAMENU;
                        }
                        if (faturaseçimkısmı == "4")
                            Console.Clear();
                        SUFATURA:
                        Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 0 GİRİNİZ");
                        Console.WriteLine("ÖDENECEK FATURA MİKTARINI GİRİNİZ");
                        try
                        {
                            yatırılacaktutar = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("!!SADECE NUMARA GİRİN!!!");
                        }
                        if (yatırılacaktutar > bakiye)
                        {
                            Console.WriteLine("!! Yatırılıcak Tutar Bakiyeden Büyük Olamaz !!");
                            goto FATURALARKISMI;
                        }
                        else if (yatırılacaktutar < bakiye)
                        {
                            bakiye = bakiye - yatırılacaktutar;
                            Console.WriteLine("FATURA ÖDENMİŞTİR.YENİ FATURANIZ AŞAĞIDADIR.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("***YENİ BAKİYENİZ {0}TLDİR.", bakiye);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ANA MENÜYE DÖNDÜNÜZ.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            goto ANAMENU;
                        }
                        if (faturaseçimkısmı == "5")
                            Console.Clear();
                        OGSODEME:
                        Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 0 GİRİNİZ");
                        Console.WriteLine("ÖDENECEK FATURA MİKTARINI GİRİNİZ");
                        try
                        {
                            yatırılacaktutar = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("!!SADECE NUMARA GİRİN!!!");
                        }
                        if (yatırılacaktutar > bakiye)
                        {
                            Console.WriteLine("!! Yatırılıcak Tutar Bakiyeden Büyük Olamaz !!");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            goto FATURALARKISMI;
                        }
                        else if (yatırılacaktutar < bakiye)
                        {
                            bakiye = bakiye - yatırılacaktutar;
                            Console.WriteLine("FATURA ÖDENMİŞTİR.YENİ FATURANIZ AŞAĞIDADIR.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("***YENİ BAKİYENİZ {0}TLDİR.", bakiye);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ANA MENÜYE DÖNDÜNÜZ.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            goto ANAMENU;
                        }
                        break;

                    case "6":
                    ŞİFREGÜNCELLEME:
                        Console.Clear();
                        Console.WriteLine("---ŞİFRE SEÇİMİ----");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("*****ESKİ ŞİFRENİZİ GİRİN.***");
                        Console.WriteLine("H- ***ANA MENÜYE DÖNMEK İÇİN H DEĞERİNİ GİRİN**");
                        string eskiolanşifre = Console.ReadLine();

                        if (eskiolanşifre == şifre)
                        {
                            Console.Clear();
                            Console.WriteLine("***YENİ ŞİFRENİZİ GİRİN.***");
                            String yenişifre = Console.ReadLine();


                        }
                        else if (eskiolanşifre == "H")
                        {
                            Console.Clear();
                            goto ANAMENU;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ESKİ ŞİFRENİZ YANLIŞTIR");
                            goto ŞİFREGÜNCELLEME;

                        }

                        break;


                }
            }
            else
            { Console.Clear();
                Console.WriteLine("***ŞİFRENİZ YANLIŞTIR.LÜTFEN TEKRAR DENEYİNİZ.");
                goto ŞİFRESORMA;
            }
        }
    Console.ReadLine();
    }
}