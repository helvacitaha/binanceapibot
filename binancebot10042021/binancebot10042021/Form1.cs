using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binancebot10042021
{
    public partial class Form1 : Form
    {
        void btc1()
        {
            //1.slotta BTC
        }
        void btc2()
        {
            //2.slotta BTC
        }
        void btc3()
        {
            //3.slotta BTC
        }
        void btc4()
        {
            //4.slotta BTC
        }
        void eth1()
        {
            //1.slotta ETH
        }
        void eth2()
        {
            //2.slotta ETH
        }
        void eth3()
        {
            //3.slotta ETH
        }
        void eth4()
        {
            //4.slotta ETH
        }
        void xrp1()
        {
            //1.slotta XRP
        }
        void xrp2()
        {
            //2.slotta XRP
        }
        void xrp3()
        {
            //3.slotta XRP
        }
        void xrp4()
        {
            //4.slotta XRP
        }
        void doge1()
        {
            //1.slotta DOGE
        }
        void doge2()
        {
            //2.slotta DOGE
        }
        void doge3()
        {
            //3.slotta DOGE
        }
        void doge4()
        {
            //4.slotta DOGE
        }
        void bttn1()
        {
            //1.slotta BTTN
        }
        void bttn2()
        {
            //2.slotta BTTN
        }
        void bttn3()
        {
            //3.slotta BTTN
        }
        void bttn4()
        {
            //4.slotta BTTN
        }
        void holo1()
        {
            //1.slotta HOT
        }
        void holo2()
        {
            //2.slotta HOT
        }
        void holo3()
        {
            //3.slotta HOT
        }
        void holo4()
        {
            //4.slotta HOT
        }
        void chz1()
        {
            //1.slotta CHZ
        }
        void chz2()
        {
            //2.slotta CHZ
        }
        void chz3()
        {
            //3.slotta CHZ
        }
        void chz4()
        {
            //4.slotta CHZ
        }
        void avax1()
        {
            //1.slotta AVAX
        }
        void avax2()
        {
            //2.slotta AVAX
        }
        void avax3()
        {
            //3.slotta AVAX
        }
        void avax4()
        {
            //4.slotta AVAX
        }
        void rvn1()
        {
            //1.slotta RVN
        }
        void rvn2()
        {
            //2.slotta RVN
        }
        void rvn3()
        {
            //3.slotta RVN
        }
        void rvn4()
        {
            //4.slotta RVN
        }
        void trx1()
        {
            //1.slotta TRX
        }
        void trx2()
        {
            //2.slotta TRX
        }
        void trx3()
        {
            //3.slotta TRX
        }
        void trx4()
        {
            //4.slotta TRX
        }
        bool btcgoster = false;
        bool ethgoster = false;
        bool xrpgoster = false;
        bool dogegoster = false;
        bool bttngoster = false;
        bool hologoster = false;
        bool chzgoster = false;
        bool avaxgoster = false;
        bool ravengoster = false;
        bool trongoster = false;
        short gosterilencoinsayisi = 0;
        bool ilkalimdansonrakiyuzdesatisyapilmasi = false;
        bool surebittigindekaredilmesi = false;
        bool alimsatimdamailatilmasi = false;
        double ilkalistakidusustesatis;
        int butce;
        string email;
        short alinacakcoinint = 0; //1-BTC 2-ETH 3-XRP 4-DOGE 5-BTTN 6-HOLO 7-CHZ 8-AVAX 9-RVN 10-TRON
        public Form1()
        {
            InitializeComponent();
        }

        private void gösterilecekcointemizle_Click(object sender, EventArgs e)
        {
            kripto1.Text = "Kripto 1:";
            kripto2.Text = "Kripto 2:";
            kripto3.Text = "Kripto 3:";
            kripto4.Text = "Kripto 4:";
            btcgoster = false;
            ethgoster = false;
            xrpgoster = false;
            dogegoster = false;
            bttngoster = false;
            hologoster = false;
            chzgoster = false;
            avaxgoster = false;
            ravengoster = false;
            trongoster = false;
            gosterilencoinsayisi = 0;
        }

        private void gosterilecekcoingoster_Click(object sender, EventArgs e)
        {
            if (gosterilencoinsayisi == 4)
            {
                MessageBox.Show("Gösterilen coinler alanı doludur. Lütfen \"Temizle\" butonuna basıp tekrar deneyiniz.");
            }
            else
            {
                if (gosterilecekcoincombo.Text == "Bitcoin (BTC)")
                {
                    if (btcgoster)
                    {
                        MessageBox.Show("Bitcoin (BTC) halihazırda gösteriliyor. Lütfen başka bir coin seçiniz.");
                    }
                    else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "BTC:";
                            btcgoster = true;
                            btc1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "BTC:";
                            btcgoster = true;
                            btc2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "BTC:";
                            btcgoster = true;
                            btc3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "BTC:";
                            btcgoster = true;
                            btc4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="Ethereum (ETH)")
                {
                    if (ethgoster)
                    {
                        MessageBox.Show("Ethereum (ETH) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }
                    else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "ETH:";
                            ethgoster = true;
                            eth1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "ETH:";
                            ethgoster = true;
                            eth2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "ETH:";
                            ethgoster = true;
                            eth3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "ETH:";
                            ethgoster = true;
                            eth4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="Ripple (XRP)")
                {
                    if (xrpgoster)
                    {
                        MessageBox.Show("Ripple (XRP) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }
                    else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "XRP:";
                            xrpgoster = true;
                            xrp1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "XRP:";
                            xrpgoster = true;
                            xrp2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "XRP:";
                            xrpgoster = true;
                            xrp3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "XRP:";
                            xrpgoster = true;
                            xrp4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="Dogecoin (DOGE)")
                {
                    if (dogegoster)
                    {
                        MessageBox.Show("Dogecoin (DOGE) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }
                    else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "DOGE:";
                            dogegoster = true;
                            doge1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "DOGE:";
                            dogegoster = true;
                            doge2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "DOGE:";
                            dogegoster = true;
                            doge3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "DOGE:";
                            dogegoster = true;
                            doge4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="BitTorrent (BTTN)")
                {
                    if (bttngoster)
                    {
                        MessageBox.Show("BitTorrent (BTTN) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }
                    else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "BTTN:";
                            bttngoster = true;
                            bttn1();
                            gosterilencoinsayisi++;
                        }
                        else if(gosterilencoinsayisi==1)
                        {
                            kripto2.Text = "BTTN:";
                            bttngoster = true;
                            bttn2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "BTTN:";
                            bttngoster = true;
                            bttn3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "BTTN:";
                            bttngoster = true;
                            bttn4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="Holochain (HOT)")
                {
                    if (hologoster)
                    {
                        MessageBox.Show("Holochain (HOT) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }
                    else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "HOT:";
                            hologoster = true;
                            holo1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "HOT:";
                            hologoster = true;
                            holo2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "HOT:";
                            hologoster = true;
                            holo3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "HOT:";
                            hologoster = true;
                            holo4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="Chiliz (CHZ)")
                {
                    if (chzgoster)
                    {
                        MessageBox.Show("Chiliz (CHZ) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }
                    else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "CHZ:";
                            chzgoster = true;
                            chz1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "CHZ:";
                            chzgoster = true;
                            chz2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "CHZ:";
                            chzgoster = true;
                            chz3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "CHZ:";
                            chzgoster = true;
                            chz4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="Avalanche (AVAX)")
                {
                    if (avaxgoster)
                    {
                        MessageBox.Show("Avalanche (AVAX) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "AVAX:";
                            avaxgoster = true;
                            avax1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "AVAX:";
                            avaxgoster = true;
                            avax2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "AVAX:";
                            avaxgoster = true;
                            avax3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "AVAX:";
                            avaxgoster = true;
                            avax4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="Ravencoin (RVN)")
                {
                    if (ravengoster)
                    {
                        MessageBox.Show("Ravencoin (RVN) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "RVN:";
                            ravengoster = true;
                            rvn1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "RVN:";
                            ravengoster = true;
                            rvn2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "RVN:";
                            ravengoster = true;
                            rvn3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "RVN:";
                            ravengoster = true;
                            rvn4();
                            gosterilencoinsayisi++;
                        }
                    }
                }else if(gosterilecekcoincombo.Text=="Troncoin (TRX)")
                {
                    if (trongoster)
                    {
                        MessageBox.Show("Troncoin (TRX) halihazırda gösteriliyor. Lütfen farklı bir coin seçiniz.");
                    }
                    else
                    {
                        if (gosterilencoinsayisi == 0)
                        {
                            kripto1.Text = "TRX:";
                            trongoster = true;
                            trx1();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 1)
                        {
                            kripto2.Text = "TRX:";
                            trongoster = true;
                            trx2();
                            gosterilencoinsayisi++;
                        }
                        else if (gosterilencoinsayisi == 2)
                        {
                            kripto3.Text = "TRX:";
                            trongoster = true;
                            trx3();
                            gosterilencoinsayisi++;
                        }
                        else
                        {
                            kripto4.Text = "TRX:";
                            trongoster = true;
                            trx4();
                            gosterilencoinsayisi++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen gösterilecek bir coin seçiniz.");
                }
            }
        }

        private void currencysec_Click(object sender, EventArgs e)
        {
            if(parabirimisiracombo.Text=="Kripto 1")
            {
                if (parabirimicombo.Text == "Türk Lirası (TL)")
                {
                    currency1.Text = "TL";
                }
                else if (parabirimicombo.Text == "Amerikan Doları (USD)")
                {
                    currency1.Text = "$";
                }
                else if (parabirimicombo.Text == "Euro (EUR)")
                {
                    currency1.Text = "€";
                }
                else if (parabirimicombo.Text == "İngiliz Sterlini (GBP)")
                {
                    currency1.Text = "£";
                }
                else if(parabirimicombo.Text== "Japon Yeni (JPY)")
                {
                    currency1.Text = "¥";
                }else if(parabirimicombo.Text== "Azerbaycan Manatı (AZN)")
                {
                    currency1.Text = "AZN";
                }
                else
                {
                    MessageBox.Show("Lütfen bir para birimi seçiniz.");
                }
            }
            else if(parabirimisiracombo.Text=="Kripto 2")
            {
                if(parabirimicombo.Text== "Türk Lirası (TL)")
                {
                    currency2.Text = "TL";
                }
                else if(parabirimicombo.Text== "Amerikan Doları (USD)")
                {
                    currency2.Text = "$";
                }
                else if(parabirimicombo.Text== "Euro (EUR)")
                {
                    currency2.Text = "€";
                }
                else if(parabirimicombo.Text == "İngiliz Sterlini (GBP)")
                {
                    currency2.Text = "£";
                }
                else if(parabirimicombo.Text== "Japon Yeni (JPY)")
                {
                    currency2.Text = "¥";
                }else if(parabirimicombo.Text== "Azerbaycan Manatı (AZN)")
                {
                    currency2.Text = "AZN";
                }
                else
                {
                    MessageBox.Show("Lütfen bir para birimi seçiniz.");
                }
            }
            else if(parabirimisiracombo.Text=="Kripto 3")
            {
                if(parabirimicombo.Text=="Türk Lirası (TL)")
                {
                    currency3.Text = "TL";
                }
                else if(parabirimicombo.Text=="Amerikan Doları (USD)")
                {
                    currency3.Text = "$";
                }
                else if(parabirimicombo.Text=="Euro (EUR)")
                {
                    currency3.Text = "€";
                }
                else if(parabirimicombo.Text=="İngiliz Sterlini (GBP)")
                {
                    currency3.Text = "£";
                }
                else if(parabirimicombo.Text=="Japon Yeni (JPY)")
                {
                    currency3.Text = "¥";
                }
                else if(parabirimicombo.Text=="Azerbaycan Manatı (AZN)")
                {
                    currency3.Text = "AZN";
                }
                else
                {
                    MessageBox.Show("Lütfen bir para birimi seçiniz.");
                }
            }
            else if(parabirimisiracombo.Text=="Kripto 4")
            {
                if(parabirimicombo.Text=="Türk Lirası (TL)")
                {
                    currency4.Text = "TL";
                }
                else if(parabirimicombo.Text=="Amerikan Doları (USD)")
                {
                    currency4.Text = "$";
                }
                else if(parabirimicombo.Text=="Euro (EUR)")
                {
                    currency4.Text = "€";
                }
                else if(parabirimicombo.Text=="İngiliz Sterlini (GBP)")
                {
                    currency4.Text = "£";
                }
                else if(parabirimicombo.Text=="Japon Yeni (JPY)")
                {
                    currency4.Text = "¥";
                }
                else if(parabirimicombo.Text=="Azerbaycan Manatı (AZN)")
                {
                    currency4.Text = "AZN";
                }
                else
                {
                    MessageBox.Show("Lütfen bir para birimi seçiniz.");
                }
            }
        }

        private void baslatmabutonu_Click(object sender, EventArgs e)
        {
            if (yuzdedusustesatisyap.Text == "") {
                ilkalimdansonrakiyuzdesatisyapilmasi = false;
            }
            else
            {
                ilkalimdansonrakiyuzdesatisyapilmasi = true;
                ilkalistakidusustesatis = Convert.ToInt32(yuzdedusustesatisyap.Text);
            }
            if (surebittigindekarcheck.Checked)
            {
                surebittigindekaredilmesi = true;
            }
            else
            {
                surebittigindekaredilmesi = false;
            }
            if (butcetextbox.Text != "")
            {
                butce = Convert.ToInt32(butcetextbox.Text);
            }
            else
            {
                MessageBox.Show("Lütfen bütçenizi belirtiniz.");
            }
            if(butceparabirimicombo.Text=="Türk Lirası (TL)")
            {
                //Birim Türk Lirası.
            }else if(butceparabirimicombo.Text=="Amerikan Doları (USD)")
            {
                //Birim Amerikan Doları
            }else if(butceparabirimicombo.Text=="Euro (EUR)")
            {
                //Birim Euro
            }else if(butceparabirimicombo.Text=="İngiliz Sterlini (GBP)")
            {
                //Birim İngiliz Sterlini
            }else if(butceparabirimicombo.Text=="Japon Yeni (JPY)")
            {
                //Birim Japon Yeni
            }else if(butceparabirimicombo.Text=="Azerbaycan Manatı (AZN)")
            {
                //Birim Azerbaycan Manatı
            }
            else
            {
                MessageBox.Show("Lütfen bütçeniz ile alım için bir para birimi seçiniz.");
            }
            if(alinacakcoincombo.Text=="Bitcoin (BTC)")
            {
                alinacakcoinint = 1;
            }
            else if(alinacakcoincombo.Text=="Ethereum (ETH)")
            {
                alinacakcoinint = 2;
            }
            else if(alinacakcoincombo.Text=="Ripple (XRP)")
            {
                alinacakcoinint = 3;
            }
            else if(alinacakcoincombo.Text=="Dogecoin (DOGE)")
            {
                alinacakcoinint = 4;
            }
            else if(alinacakcoincombo.Text=="BitTorrent (BTTN)")
            {
                alinacakcoinint = 5;
            }
            else if(alinacakcoincombo.Text=="Holochain (HOT)")
            {
                alinacakcoinint = 6;
            }
            else if(alinacakcoincombo.Text=="Chiliz (CHZ)")
            {
                alinacakcoinint = 7;
            }
            else if(alinacakcoincombo.Text=="Avalanche (AVAX)")
            {
                alinacakcoinint = 8;
            }
            else if(alinacakcoincombo.Text=="Ravencoin (RVN)")
            {
                alinacakcoinint = 9;
            }
            else if(alinacakcoincombo.Text=="Troncoin (TRX)")
            {
                alinacakcoinint = 10;
            }
            else
            {
                MessageBox.Show("Lütfen alınacak bir coin seçiniz.");
            }
            if (surebittigindekarcheck.Checked)
            {
                surebittigindekaredilmesi = true;
            }
            else
            {
                surebittigindekaredilmesi = false;
            }
            if (emailcheckbox.Checked)
            {
                alimsatimdamailatilmasi = true;
                if (emailtextbox.Text != "")
                {
                    email = emailtextbox.Text;
                }
                else
                {
                    MessageBox.Show("Lütfen E-Mailinizi Giriniz.");
                }
            }
        }
    }
}
