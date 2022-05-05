using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tetris1
{
    abstract class hareket
    {
        // gelensekil sınıfında da kullanacağım değişkenleri oluşturdum.
        public int dondurme;
        public int a1;
        public int b1;
        public int a2;
        public int b2;
        public int a3;
        public int b3;
        public int a4;
        public int b4;       
        public Color renk;
        public int s_sol;
        public int s_sag;
        public int s_alt;

        public void asagıilerle()
        {
           
                b1++;//aşağı git fonk. dikey olarak tanımladığım b değişkenini her bastığında arttırdım.
                b2++;//aşağı git fonk. dikey olarak tanımladığım b değişkenini her bastığında arttırdım.
                b3++;//aşağı git fonk. dikey olarak tanımladığım b değişkenini her bastığında arttırdım.
                b4++;//aşağı git fonk. dikey olarak tanımladığım b değişkenini her bastığında arttırdım.
                s_alt++;//geçici olarak oluşturduğum değişken gelen sekil sinıfında
            
        }
        public void solaGit()
        {
           
                a1--;//sola git fonk. dikey olarak tanımladığım a değişkenini her bastığında azalttım.
                a2--;//sola git fonk. dikey olarak tanımladığım a değişkenini her bastığında azalttım.
            a3--;//sola git fonk. dikey olarak tanımladığım a değişkenini her bastığında azalttım.
            a4--;//sola git fonk. dikey olarak tanımladığım a değişkenini her bastığında azalttım.
            s_sol--;//geçici olarak oluşturduğum değişken gelen sekil sinıfında azalttım
            s_sag--;//geçici olarak oluşturduğum değişken gelen sekil sinıfında azalttım
        }
        public void sagailerle()
        {
                a1++;//saga git fonk. dikey olarak tanımladığım a değişkenini her bastığında arttırdım.
            a2++;//saga git fonk. dikey olarak tanımladığım a değişkenini her bastığında arttırdım.
            a3++;//saga git fonk. dikey olarak tanımladığım a değişkenini her bastığında arttırdım.
            a4++;//saga git fonk. dikey olarak tanımladığım a değişkenini her bastığında arttırdım.
            s_sag++;//geçici olarak oluşturduğum değişken gelen sekil sinıfında arttırdım
            s_sol++;            //geçici olarak oluşturduğum değişken gelen sekil sinıfında arttırdım
        }
        public virtual void dondur()
        {

        }

    }
    class PANEL
    {

        hareket rstsekil, sonrakirstsekill;
        Label[,] labeloyun = new Label[22, 12];
        Label[,] labelsonraki = new Label[4, 4];
        Panel panel1, panel;//paneli oluşturmak için panel değişkenleri oluşturdum.
        Random rnd = new Random();//rastgele olarak şekil getirmek için
        public int skor = 0;// skor için int değişken tanımladım.
        int secim;//rstgele şekil için secim değişkeni oluşturdum.
        int yukseklik = 10;//
        int sol = 35;
        Boolean durum = true;//oyunun devam edip etmediğini kontrol ettim.
        public PANEL()//oyunun oynanacağı paneli oluşturdum.
        {
            panel1 = new Panel();
            panel1.AutoSize = true;
            panel = new Panel();
            panel.AutoSize = true;

        }
        public Panel labelYaz()
        {


            for (int i = 0; i <= 21; i++)
            {
                for (int j = 0; j <= 11; j++)
                {
                    labeloyun[i, j] = new Label();
                    labeloyun[i, j].BackColor = Color.Black;//panelin her bir parçasını rengini siyah yaptırdım.

                    labeloyun[i, j].Width = 20;//i nin j indexinin widhtini 20 yaptım.
                    labeloyun[i, j].Height = 20;//i nin j indexinin heightini 20 yaptım.
                    labeloyun[i, j].Left = sol;// left değerini yani soldan eklemesini sol değişkenine eşitledim.
                    labeloyun[i, j].Top = yukseklik;//dikeyini top değerine eşitledim.
                    sol += 20;
                    panel1.Controls.Add(labeloyun[i, j]);//panele değerleri ekledim.
                }
                yukseklik += 20;
                sol = 35;
            }
            return panel1;//panel1in değerini döndürdüm.
        }
        public void oyna()//oyna fonk. oluşturdum
        {
            sekilOlustur();//şekli oluşturması için fonk. çağırdım.
            sonrakisekil();// sonrakişekilin gelmesi için fomk. öağırdım.
            sekligetir(false);//ilk değerini false atadım bloklara girmesi için
        }
        public void sonrakisekil()//sonraki şekil için oluşturduğum fonksiyon
        {
            secim = rnd.Next(0, 7);//rastgele şekili getirmek için random sınıfından nesne 7 tane rastgele rakam oluşturdum.

            if (secim == 0)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                sonrakirstsekill = new sekilKare();

            }
            else if (secim == 1)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                sonrakirstsekill = new sekilL1();
            }
            else if (secim == 2)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                sonrakirstsekill = new sekilL2();
            }
            else if (secim == 3)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                sonrakirstsekill = new sekilS1();
            }
            else if (secim == 4)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                sonrakirstsekill = new sekilS2();
            }
            else if (secim == 5)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                sonrakirstsekill = new TSEKLİ();
            }
            else if (secim == 6)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                sonrakirstsekill = new ekrandakisekil();
            }

            // üst üste gelen şekiller panelin boyutlarını aşarsa oyunu durdurdum.
            if (labeloyun[rstsekil.b1, rstsekil.a1].BackColor != Color.Black || labeloyun[rstsekil.b2, rstsekil.a2].BackColor != Color.Black || labeloyun[rstsekil.b3, rstsekil.a3].BackColor != Color.Black || labeloyun[rstsekil.b4, rstsekil.a4].BackColor != Color.Black)
            {
                durum = false;
            }
        }
        // ilk başta rastgele bir şekil gelmesini sağladım.
        public void sekilOlustur()
        {
            secim = rnd.Next(0, 7);
            if (secim == 0)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                rstsekil = new sekilKare();
            }
            else if (secim == 1)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                rstsekil = new sekilL1();
            }
            else if (secim == 2)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                rstsekil = new sekilL2();
            }
            else if (secim == 3)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                rstsekil = new sekilS1();
            }
            else if (secim == 4)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                rstsekil = new sekilS2();
            }
            else if (secim == 5)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                rstsekil = new TSEKLİ();
            }
            else if (secim == 6)//rastgele secim bu blokta ise bloğa ait şekli getirdim.
            {
                rstsekil = new ekrandakisekil();
            }
        }
        public void sekligetir(Boolean sifirla)//bool değeri ile parametre yolladım
        {
            if (sifirla)//sifirla true ise renklerini siyah yaptırdım ve stil atamadım
            {
                labeloyun[rstsekil.b1, rstsekil.a1].BackColor = Color.Black;
                labeloyun[rstsekil.b2, rstsekil.a2].BackColor = Color.Black;
                labeloyun[rstsekil.b3, rstsekil.a3].BackColor = Color.Black;
                labeloyun[rstsekil.b4, rstsekil.a4].BackColor = Color.Black;

                labeloyun[rstsekil.b1, rstsekil.a1].BorderStyle = BorderStyle.None; //stil atamadım
                labeloyun[rstsekil.b2, rstsekil.a2].BorderStyle = BorderStyle.None; //stil atamadım
                labeloyun[rstsekil.b3, rstsekil.a3].BorderStyle = BorderStyle.None; //stil atamadım
                labeloyun[rstsekil.b4, rstsekil.a4].BorderStyle = BorderStyle.None; //stil atamadım
            }
            else
            {//false ise renklerini rastgele atadığım şekillerle aynı yaptırdım.
                labeloyun[rstsekil.b1, rstsekil.a1].BackColor = rstsekil.renk;
                labeloyun[rstsekil.b2, rstsekil.a2].BackColor = rstsekil.renk;
                labeloyun[rstsekil.b3, rstsekil.a3].BackColor = rstsekil.renk;
                labeloyun[rstsekil.b4, rstsekil.a4].BackColor = rstsekil.renk;
                labeloyun[rstsekil.b1, rstsekil.a1].BorderStyle = BorderStyle.FixedSingle;//stillerini ise fixedsingle yaptırdım.
                labeloyun[rstsekil.b2, rstsekil.a2].BorderStyle = BorderStyle.FixedSingle;//stillerini ise fixedsingle yaptırdım.
                labeloyun[rstsekil.b3, rstsekil.a3].BorderStyle = BorderStyle.FixedSingle;//stillerini ise fixedsingle yaptırdım.
                labeloyun[rstsekil.b4, rstsekil.a4].BorderStyle = BorderStyle.FixedSingle;//stillerini ise fixedsingle yaptırdım.

            }
        }
        public void asagıilerle()//asağı gitme fonksiyonunu oluşturdum.
        {
            if (rstsekil.s_alt + 1 < 22)
            {
                sekligetir(true);//şekli getire parametre olarak true atadım.
                if (labeloyun[rstsekil.b1 + 1, rstsekil.a1].BackColor == Color.Black && labeloyun[rstsekil.b2 + 1, rstsekil.a2].BackColor == Color.Black && labeloyun[rstsekil.b3 + 1, rstsekil.a3].BackColor == Color.Black && labeloyun[rstsekil.b4 + 1, rstsekil.a4].BackColor == Color.Black)
                {
                    rstsekil.asagıilerle();
                    sekligetir(false);
                }
                else//rastgle oluşturulan şekil panelin boyutlarından küçükse yani yanyana 22 şekil geldiyse
                {
                    sekligetir(false);
                    patlat();//patlat fonk ile şekilleri sildirdim.
                    rstsekil = sonrakirstsekill;
                    sonrakisekil();
                }
            }
            else
            {
                patlat();
                rstsekil = sonrakirstsekill;
                sonrakisekil();
            }
        }
        public void sagailerle()//sağa git fonk. oluşturdum.
        {
            if (rstsekil.s_sag + 1 <= 11)
            {
                sekligetir(true);
                //panelin rengi siyah olduğu için sınırlarıda panelin renklerine göre oluşturdum.
                if (labeloyun[rstsekil.b1, rstsekil.a1 + 1].BackColor == Color.Black && labeloyun[rstsekil.b2, rstsekil.a2 + 1].BackColor == Color.Black && labeloyun[rstsekil.b3, rstsekil.a3 + 1].BackColor == Color.Black && labeloyun[rstsekil.b4, rstsekil.a4 + 1].BackColor == Color.Black)
                {
                    rstsekil.sagailerle();
                    sekligetir(false);
                }
                else
                {
                    sekligetir(false);
                }
            }
        }
        public void dondur()//şekli döndürme fonksiyonunu oluşturdum.
        {
            sekligetir(true);//şekligetiri true atadım bu sayde durdurdum.
            rstsekil.dondur();//rastgele gelen şekli döndrmek için çağırdım.
            if (labeloyun[rstsekil.b1, rstsekil.a1].BackColor == Color.Black && labeloyun[rstsekil.b2, rstsekil.a2].BackColor == Color.Black && labeloyun[rstsekil.b3, rstsekil.a3].BackColor == Color.Black && labeloyun[rstsekil.b4, rstsekil.a4].BackColor == Color.Black)
            {
                sekligetir(false);//dikey ve yatay değişkenleri birbirlerine eşitse false olarak atadım.
            }
            else
            {
                rstsekil.dondur();
                sekligetir(false);
            }
        }
        // Patlayan satiri uste alarak diger satirlari alta indiriyor
        public void usteAl(int satir)
        {
            for (int i = satir; i > 0; i--)//satirdaki kutu sayisi bitene kadar
            {
                for (int j = 0; j < 12; j++)
                {
                    labeloyun[i, j].BackColor = labeloyun[i - 1, j].BackColor;
                    labeloyun[i, j].BorderStyle = labeloyun[i - 1, j].BorderStyle;

                }

            }
        }
        
        public void patlat()
        {
            Boolean deger = true;
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (labeloyun[i, j].BackColor == Color.Black)//labellerın rengi birbiriyle uyuşuyorsa
                    {
                        deger = false;
                        break;//bloğu kırdım.
                    }
                }
                if (deger == true)
                {
                    usteAl(i);//üsteal fonksiyonunu çağırdım
                    skor += 100;//patladığı için 100 puan skor ekledim.

                }
                deger = true;
            }
        }
        
        public void solaGit()
        {
            if (rstsekil.s_sol - 1 >= 0)
            {
                sekligetir(true);
                if (labeloyun[rstsekil.b1, rstsekil.a1 - 1].BackColor == Color.Black && labeloyun[rstsekil.b2, rstsekil.a2 - 1].BackColor == Color.Black && labeloyun[rstsekil.b3, rstsekil.a3 - 1].BackColor == Color.Black && labeloyun[rstsekil.b4, rstsekil.a4 - 1].BackColor == Color.Black)
                {

                    rstsekil.solaGit();//şekile solagit fonksiyonuu uyguladım.
                    sekligetir(false);
                }
                else
                {
                    sekligetir(false);

                }
            }
        }

        public Boolean durumGonder()
        {
            return durum;
        }
    }
}

