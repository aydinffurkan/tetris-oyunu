using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris1
{

    class ekrandakisekil:hareket
    {
        //bu fonksiyonda şekilleri döndürmek için kullandım.
        public override void dondur()
        {
            int _s_alt, _s_sag, _s_sol;//alt sağ ve sol için sonradan değiştireceğim değişkenler oluşturdum.
            if (dondurme == 0)
            {

                _s_alt = b2 + 2;
                _s_sol = a2;
                _s_sag = a2;
                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else if (s_alt > 0)
                {
                    s_alt = b2 + 2;
                    s_sol = a2;
                    s_sag = a2;
                    a1 = s_sol;
                    b1 = s_alt - 3;
                    a2 = s_sol;
                    b2 = s_alt - 2;
                    a3 = s_sol;
                    b3 = s_alt - 1;
                    a4 = s_sol;
                    b4 = s_alt;
                    dondurme = 1;
                }

            }
            else if (dondurme == 1)
            {
                _s_sol = a2 - 1;
                _s_sag = a2 + 2;
                _s_alt = b2;
                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    s_sol = a2 - 1;
                    s_sag = a2 + 2;
                    s_alt = b2;

                    a1 = s_sol;
                    b1 = s_alt;
                    a2 = s_sol + 1;
                    b2 = s_alt;
                    a3 = s_sag - 1;
                    b3 = s_alt;
                    a4 = s_sag;
                    b4 = s_alt;
                    dondurme = 0;
                }
            }
        }
        public ekrandakisekil()
        {
            //Bu blokta şekillerin değişmesi için  bir nevi lokasyon atadım. Her bir değişkende bir sonraki şekil için yeni şekli oluşturttum.
            s_alt=0;
            s_sol=4;
            s_sag=7;//başlangıçta soldan 7şer boşluk bıraktırdım.
            dondurme = 0;//çevirme için başlangıçta  atadım.
            //dikey ve yatay için değişkenlere ilk değerlerini verdirdim.
            a1 = s_sol;
            b1 = s_alt;
            a2 = s_sol+1;
            b2 = s_alt;
            a3 = s_sol+2;
            b3 = s_alt;
            a4 = s_sag;
            b4 = s_alt;
            renk = Color.SkyBlue;//şekillerin rengini skyblue yaptırdım.
        }
  
    }
    // bu sınıfım kare şekli için
    class sekilKare : hareket
    {
        public sekilKare()
        {
            //kare şeklinde döndürme olmayacağı için dondur fonk. çağırmadım.
            //kare şeklini oluşturmak için a:yatay b:dikey olarak belirlediğim değişkenlere hesaplamalar sonucu ilgili değerleri verdim.
            s_alt = 1;
            s_sag = 6;
            s_sol = 5;
            a1 = s_sol;
            b1 = 0;
            a2 = s_sag;
            b2 = 0;
            a3 = s_sol;
            b3 = 1;
            a4 = s_sag;
            b4 = 1;
            renk = Color.SkyBlue;//rengini skyblue yaptım.
        }
    }
    class sekilL1 : hareket
    {
        public sekilL1()
        {
            //sekilL1 şeklini oluşturmak için a:yatay b:dikey olarak belirlediğim değişkenlere hesaplamalar sonucu ilgili değerleri verdim
            s_alt = 1;//başlangıçtaki lokasyonlarını atadım.
            s_sag = 6;
            s_sol = 4;
            a1 = s_sol;
            b1 = s_alt - 1;
            a2 = s_sol;
            b2 = s_alt;
            a3 = s_sag - 1;
            b3 = s_alt;
            a4 = s_sag;
            b4 = s_alt;
            renk = Color.SkyBlue;  //rengini skyblue yaptım.    
        }
        public override void dondur()//şeklin donebilmesi için dondur fonk. oluşturdum.
        {
            int _s_alt, _s_sag, _s_sol;
            if (dondurme == 0)//space tuşuna hiç basmadıysa
            {
                _s_alt = b3 + 1;//sikeyine +1 ekleyerek donmesini sağladım.
                _s_sol = a3;//a3 yatayımı değişkene eşitledim.
                _s_sag = a3 + 1;
                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    s_alt = b3 + 1;
                    s_sol = a3;
                    s_sag = a3 + 1;
                    dondurme = 1;
                    a1 = s_sag;
                    b1 = s_alt - 2;
                    a2 = s_sol;
                    b2 = s_alt - 2;
                    a3 = s_sol;
                    b3 = s_alt - 1;
                    a4 = s_sol;
                    b4 = s_alt;
                }
            }
            else if (dondurme == 1)//space tuşuna 1 kez bastıysa
            {
                //yatay ve dikey değişkenlerime ilgili değerleri atadım.
                _s_sag = a3 + 1;
                _s_sol = a3 - 1;
                _s_alt = b3 + 1;
                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {
                    // bu bloğa girmediyse space tuşuna 2. kez bastığını algılattım.
                }
                else
                {
                    s_sag = a3 + 1;
                    s_sol = a3 - 1;
                    s_alt = b3 + 1;
                    dondurme = 2;
                    a1 = s_sag;
                    b1 = s_alt;
                    a2 = s_sag;
                    b2 = s_alt - 1;
                    a3 = s_sag - 1;
                    b3 = s_alt - 1;
                    a4 = s_sol;
                    b4 = s_alt - 1;
                }
            }
            else if (dondurme == 2)//space tuşuna 2 kez bastıysa
            {

                _s_sag = a3;
                _s_sol = a3 - 1;
                _s_alt = b3 + 1;
                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    s_sag = a3;
                    s_sol = a3 - 1;
                    s_alt = b3 + 1;
                    dondurme = 3;
                    a1 = s_sol;
                    b1 = s_alt;
                    a2 = s_sag;
                    b2 = s_alt;
                    a3 =

                    a4 = s_sag;
                    b4 = s_alt - 2;
                }

            }
            else if (dondurme == 3)//space tuşuna 3 kez bastıysa
            {


                _s_sag = a3 + 1;
                _s_sol = a3 - 1;
                _s_alt = b3;
                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    s_sag = a3 + 1;
                    s_sol = a3 - 1;
                    s_alt = b3;

                    dondurme = 0;
                    a1 = s_sol;
                    b1 = s_alt - 1;
                    a2 = s_sol;
                    b2 = s_alt;
                    a3 = s_sag - 1;
                    b3 = s_alt;

                    a4 = s_sag;
                    b4 = s_alt;
                }

            }
        }
    }
    class sekilL2 : hareket
    {
        public sekilL2()
        {
            //l2 şekli için yatay ve dikey değişkenlerime ilgili değerleri atadım.
            s_alt = 1;//başlangıç lokasyonlarını atadım.
            s_sag = 6;
            s_sol = 4;
            dondurme = 0;
            a1 = s_sag;
            b1 = s_alt - 1;
            a2 = s_sol;
            b2 = s_alt;
            a3 = s_sag - 1;
            b3 = s_alt;
            a4 = s_sag;
            b4 = s_alt;
            renk = Color.SkyBlue;//rengini skyblue yaptım.
        }
        public override void dondur()//şeklin donmesi için dondur fokn. oluşturdum.
        {
            int _s_alt, _s_sag, _s_sol;
            if (dondurme == 0)
            {
                _s_alt = b3 + 1;
                _s_sag = a3 + 1;
                _s_sol = a3;

                if (_s_alt >= 20 || _s_sag >= 10 || _s_sol < 0)
                {

                }
                else
                {
                    s_alt = b3 + 1;
                    s_sag = a3 + 1;
                    s_sol = a3;
                    dondurme = 1;
                    a1 = s_sol;
                    b1 = s_alt - 2;
                    a2 = s_sol;
                    b2 = s_alt;
                    a4 = s_sag;
                    b4 = s_alt;
                }
            }
            else if (dondurme == 1)//space tuşuna 1 kez bastıysa
            {
                _s_alt = b3 + 1;
                _s_sag = a3 + 1;
                _s_sol = a3 - 1;

                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {
                    //bu bloğa girmediyse dondurme değişkenini 2 tanımladım.
                }
                else
                {
                    s_alt = b3 + 1;
                    s_sag = a3 + 1;
                    s_sol = a3 - 1;
                    dondurme = 2;
                    a1 = s_sol;
                    b1 = s_alt - 1;
                    a2 = s_sag;
                    b2 = s_alt - 1;
                    a4 = s_sol;
                    b4 = s_alt;
                }
            }
            else if (dondurme == 2)//space tuşuna 2 kez bastıysa
            {
                _s_alt = b3 + 1;
                _s_sag = a3;
                _s_sol = a3 - 1;

                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    s_alt = b3 + 1;
                    s_sag = a3;
                    s_sol = a3 - 1;
                    dondurme = 3;
                    a1 = s_sol;
                    b1 = s_alt - 2;
                    a2 = s_sag;
                    b2 = s_alt - 2;

                    a4 = s_sag;
                    b4 = s_alt;
                }
            }
            else if (dondurme == 3)//space tuşuna 3 kez bastıysa
            {
                _s_alt = b3;
                _s_sag = a3 + 1;
                _s_sol = a3 - 1;

                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    s_alt = b3;
                    s_sag = a3 + 1;
                    s_sol = a3 - 1; dondurme = 0;
                    a1 = s_sag;
                    b1 = s_alt - 1;
                    a2 = s_sol;
                    b2 = s_alt;

                    a4 = s_sag;
                    b4 = s_alt;
                }
            }
        }
    }
    class sekilS1 : hareket
    {
        public sekilS1()
        {
            //şekli oluşturmak için yatay ve dikey değişkenelere ilgili hesaplamaları atadım.
            s_alt = 1;
            s_sol = 4;
            s_sag = 6;
            dondurme = 0;//başlangıçta dondurme değişkenini 0 atadım.
            a1 = s_sol + 1;
            b1 = s_alt - 1;
            a2 = s_sag;
            b2 = s_alt - 1;
            a3 = s_sol;
            b3 = s_alt;
            a4 = s_sol + 1;
            b4 = s_alt;
            renk = Color.SkyBlue;//rengini skyblue yaptırdım.
        }
        public override void dondur()//şeklin dönmesi içi dondur fonk. oluşturdum.
        {
            //s şeklinde 2 kombinasyon olduğu için döndğrme için iki koşul oluşturdum.
            int _s_alt, _s_sag, _s_sol;
            if (dondurme == 0)//space tuşuna hiç basmadıysa
            {
                _s_alt = b4 + 1;
                _s_sol = a4;
                _s_sag = a4 + 1;

                if (_s_alt >= 21 || _s_sag >= 11 || _s_sol <= 0)
                {

                }
                else
                {
                    s_alt = b4 + 1;
                    s_sol = a4;
                    s_sag = a4 + 1;
                    dondurme = 1;//if bloğuna girmediyse dondurme 1 deki şekli getirdim.
                    a1 = s_sol;
                    b1 = s_alt - 2;
                    a2 = s_sag;
                    b2 = s_alt - 1;

                    a3 = s_sag;
                    b3 = s_alt;

                }
            }
            else if (dondurme == 1)//sapace tuşuna 1 kez bastıysa
            {
                _s_alt = b4;
                _s_sol = a4 - 1;
                _s_sag = a4 + 1;

                if (_s_alt >= 20 || _s_sag >= 11 || _s_sol <= 0)
                {
                }
                else
                {
                    s_alt = b4;
                    s_sol = a4 - 1;
                    s_sag = a4 + 1;
                    dondurme = 0;
                    a1 = s_sol + 1;
                    b1 = s_alt - 1;
                    a2 = s_sag;
                    b2 = s_alt - 1;
                    a3 = s_sol;
                    b3 = s_alt;
                }

            }
        }
    }
    class sekilS2 : hareket
    {
        //s şeklinde 2 kombinasyon olduğu için döndğrme için iki koşul oluşturdum.

        public sekilS2()
        {
            //s2 şeklinin oluşması için yatay ve dikey değişkenlere ilgili değerleri atadım.
            s_alt = 1;
            s_sol = 4;
            s_sag = 6;
            dondurme = 0;
            a1 = s_sol;
            b1 = 0;
            a2 = s_sag - 1;
            b2 = 0;
            a3 = s_sol + 1;
            b3 = 1;
            a4 = s_sag;
            b4 = 1;
          
            renk = Color.SkyBlue;//rengini skyblue yaptırdım.
        }
        public override void dondur()//şeklin dönmesi içi dondur fonk. oluşturdum.
        {
            int _s_alt, _s_sag, _s_sol;
            if (dondurme == 0)//space tuşuna hiç basmadıysa
            {
                _s_alt = b3 + 1;
                _s_sol = a3;
                _s_sag = a3 + 1;

                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    s_alt = b3 + 1;
                    s_sol = a3;
                    s_sag = a3 + 1;
                    dondurme = 1;
                    a1 = s_sag;
                    b1 = s_alt - 2;
                    a2 = s_sag;
                    b2 = s_alt - 1;
                    a4 = s_sol;
                    b4 = s_alt;
                }
            }
            else if (dondurme == 1)//space tuşuna 1 kez bastıysa
            {
                _s_alt = b3;
                _s_sol = a3 - 1;
                _s_sag = a3 + 1;

                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    s_alt = b3;
                    s_sol = a3 - 1;
                    s_sag = a3 + 1;
                    dondurme = 0;
                    a1 = s_sol;
                    b1 = s_alt - 1;
                    a2 = s_sol + 1;
                    b2 = s_alt - 1;
                    a4 = s_sag;
                    b4 = s_alt;
                }
            }
        }
    }
    class TSEKLİ : hareket
    {
        public TSEKLİ()
        {
            dondurme = 0;//başlangıçta dondurme değişkneini 0 atadım.
            s_alt = 1;
            s_sol = 4;
            s_sag = 6;

            a1 = s_sol;
            b1 = 0;
            a2 = s_sag - 1;
            b2 = 0;
            a3 = s_sag;
            b3 = 0;
            a4 = s_sag - 1;
            b4 = 1;
            renk = Color.SkyBlue;//rengini skyblue atadım.
        }
        public override void dondur()//şekli döndürmek için dondur fonk. oluşturdum.
        {
            int _s_alt, _s_sag, _s_sol;
            if (dondurme == 0)//sğpace tuşuna hiç basmadıysa
            {
                _s_alt = b4;
                _s_sol = a1;
                _s_sag = a2;

                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    dondurme = 1;//if bloğuna girmediyse dondurme değişkeninin değerini  yaptım.
                    s_alt = b4;
                    s_sol = a1;
                    s_sag = a2;
                    a1 = s_sag;
                    b1 = s_alt - 2;
                    a3 = s_sol;
                    b3 = s_alt - 1;

                    a4 = s_sag;
                    b4 = s_alt;
                }
            }
            else if (dondurme == 1)//space tuşuna  kez bastıysa
            {
                _s_alt = b2;
                _s_sol = a3;
                _s_sag = a2 + 1;
                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    dondurme = 2;
                    s_alt = b2;
                    s_sol = a3;
                    s_sag = a2 + 1;
                    a1 = s_sag - 1;
                    b1 = s_alt - 1;
                    a3 = s_sol;
                    b3 = s_alt;

                    a4 = s_sag;
                    b4 = s_alt;
                }
            }
            else if (dondurme == 2)//space tuşuna 2 kez bastıysa
            {  
                _s_alt = b2 + 1;
                _s_sol = a2;
                _s_sag = a2 + 1;

                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    dondurme = 3;
                    s_alt = b2 + 1;
                    s_sol = a2;
                    s_sag = a2 + 1;
                    a1 = s_sol;
                    b1 = s_alt - 2;
                    a3 = s_sag;
                    b3 = s_alt - 1;

                    a4 = s_sol;
                    b4 = s_alt;
                }

            }
            else if (dondurme == 3)//space tuşuna 3 kez bastıysa
            {
                _s_alt = b2 + 1;
                _s_sol = a2 - 1;
                _s_sag = a2 + 1;

                if (_s_alt > 21 || _s_sag > 11 || _s_sol < 0)
                {

                }
                else
                {
                    dondurme = 0;//dondurme değerini tekrardan 0 yaptırdım.
                    s_alt = b2 + 1;
                    s_sol = a2 - 1;
                    s_sag = a2 + 1;
                    a1 = s_sol;
                    b1 = s_alt - 1;
                    a3 = s_sag;
                    b3 = s_alt - 1;

                    a4 = s_sol + 1;
                    b4 = s_alt;
                }
            }
        }
    }
}