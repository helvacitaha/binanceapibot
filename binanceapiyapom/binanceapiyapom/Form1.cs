using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binanceapiyapom
{
    public partial class Form1 : Form
    {
        int gosterilencoinsayisi=0;
        string kullaniciemail;
        string alinacakcoin;
        bool surebittigindekaret;
        bool alimsatimemailgonder;
        int dogesayisi = 0;
        int btcsayisi = 0;
        int xrpsayisi = 0;
        int ethsayisi = 0;
        double butce;
        double alisfiyati;
        double satisfiyati;
        double calismasuresi;
        double ilkalistansonrasatisyuzde;
        bool ilkalistansonradusersesat;
        public Form1()
        {
            InitializeComponent();
        }

        private void iletisimbuton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/reizlerotomasyon/");
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            kullaniciemail = mailtextbox.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form1 load
            parabirimicombo.Text = "USD(Amerikan Doları)";
        }

        private void baslamabutonu_Click(object sender, EventArgs e)
        {
            if (cointurutext.Text == "BTC")
            {
                alinacakcoin = "bitc";
            }else if (cointurutext.Text == "ETH")
            {
                alinacakcoin = "etherium";
            }else if (cointurutext.Text == "DOGE")
            {
                alinacakcoin = "dogecoin";
            }else if (cointurutext.Text == "XRP")
            {
                alinacakcoin = "ripple";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir kripto para ismi giriniz.");
            }
            if (butcetext.Text != "")
            {
                butce = Convert.ToDouble(butcetext.Text);
            }
            if (alisfiyattext.Text != "")
            {
                alisfiyati = Convert.ToDouble(alisfiyattext.Text);
            }
            if (satisfiyattext.Text != "")
            {
                satisfiyati = Convert.ToDouble(satisfiyattext.Text);
            }
            if (suretext.Text != "")
            {
                calismasuresi = Convert.ToDouble(suretext.Text);

            }
            if (surebittigindecheck.Checked == true)
            {
                surebittigindekaret = true;
            }
            else
            {
                surebittigindekaret = false;
            }
            if (alimsatimmail.Checked == true)
            {
                alimsatimemailgonder = true;
            }
            else
            {
                alimsatimemailgonder = false;
            }
            if (yuzdedususmail.Text != "")
            {
                ilkalistansonrasatisyuzde = Convert.ToDouble(yuzdedususmail.Text);
            }
            else
            {
                ilkalistansonradusersesat = false;
            }
        }

        private void kriptoekle_Click(object sender, EventArgs e)
        {
            if (gosterilencoinsayisi < 4)
            {
                if (gostercoincombo.Text == "BTC(Bitcoin)")
                {
                    if (gosterilencoinsayisi == 0)
                    {
                        if (btcsayisi == 0)
                        {
                            kripto1.Text = "BTC   :";
                            gosterilencoinsayisi++;
                            btcsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("BTC(Bitcoin) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }else if (gosterilencoinsayisi == 1)
                    {
                        if (btcsayisi == 0)
                        {
                            kripto2.Text = "BTC   :";
                            gosterilencoinsayisi++;
                            btcsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("BTC(Bitcoin) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else if (gosterilencoinsayisi == 2)
                    {
                        if (btcsayisi == 0)
                        {
                            kripto3.Text = "BTC   :";
                            gosterilencoinsayisi++;
                            btcsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("BTC(Bitcoin) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else
                    {
                        if (btcsayisi == 0)
                        {
                            kripto4.Text = "BTC   :";
                            gosterilencoinsayisi++;
                            btcsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("BTC(Bitcoin) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                }else if(gostercoincombo.Text== "ETH(Etherium)")
                {
                    if (gosterilencoinsayisi == 0)
                    {
                        if (ethsayisi == 0)
                        {
                            kripto1.Text = "ETH   :";
                            gosterilencoinsayisi++;
                            ethsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("ETH(Etherium) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else if (gosterilencoinsayisi == 1)
                    {
                        if (ethsayisi == 0)
                        {
                            kripto2.Text = "ETH   :";
                            gosterilencoinsayisi++;
                            ethsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("ETH(Etherium) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else if (gosterilencoinsayisi == 2)
                    {
                        if (ethsayisi == 0)
                        {
                            kripto3.Text = "ETH   :";
                            gosterilencoinsayisi++;
                            ethsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("ETH(Etherium) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else
                    {
                        if (ethsayisi == 0)
                        {
                            kripto4.Text = "ETH   :";
                            gosterilencoinsayisi++;
                            ethsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("ETH(Etherium) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                }else if (gostercoincombo.Text == "DOGE(Dogecoin)")
                {
                    if (gosterilencoinsayisi == 0)
                    {
                        if (dogesayisi == 0)
                        {
                            kripto1.Text = "DOGE  :";
                            gosterilencoinsayisi++;
                            dogesayisi++;
                        }
                        else
                        {
                            MessageBox.Show("DOGE(Dogecoin) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else if (gosterilencoinsayisi == 1)
                    {
                        if (dogesayisi == 0)
                        {
                            kripto2.Text = "DOGE  :";
                            gosterilencoinsayisi++;
                            dogesayisi++;
                        }
                        else
                        {
                            MessageBox.Show("DOGE(Dogecoin) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else if (gosterilencoinsayisi == 2)
                    {
                        if (dogesayisi == 0)
                        {
                            kripto3.Text = "DOGE  :";
                            gosterilencoinsayisi++;
                            dogesayisi++;
                        }
                        else
                        {
                            MessageBox.Show("DOGE(Dogecoin) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else
                    {
                        if (dogesayisi == 0)
                        {
                            kripto4.Text = "DOGE  :";
                            gosterilencoinsayisi++;
                            dogesayisi++;
                        }
                        else
                        {
                            MessageBox.Show("DOGE(Dogecoin) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                }else if (gostercoincombo.Text == "XRP(Ripple)")
                {
                    if (gosterilencoinsayisi == 0)
                    {
                        if (xrpsayisi == 0)
                        {
                            kripto1.Text = "XRP   :";
                            gosterilencoinsayisi++;
                            xrpsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("XRP(Ripple) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else if (gosterilencoinsayisi == 1)
                    {
                        if (xrpsayisi == 0)
                        {
                            kripto2.Text = "XRP   :";
                            gosterilencoinsayisi++;
                            xrpsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("XRP(Ripple) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else if (gosterilencoinsayisi == 2)
                    {
                        if (xrpsayisi == 0)
                        {
                            kripto3.Text = "XRP   :";
                            gosterilencoinsayisi++;
                            xrpsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("XRP(Ripple) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                    else
                    {
                        if (xrpsayisi == 0)
                        {
                            kripto4.Text = "XRP   :";
                            gosterilencoinsayisi++;
                            xrpsayisi++;
                        }
                        else
                        {
                            MessageBox.Show("XRP(Ripple) halihazırda gösteriliyor. Lütfen başka bir kripto para seçiniz.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir kripto para türü seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Canlı gösterim yerleri doludur. \"Temizle\" butonuna basıp tekrar deneyiniz.");
            }
        }

        private void canlitemizle_Click(object sender, EventArgs e)
        {
            kripto1.Text = "kripto1";
            kripto2.Text = "kripto2";
            kripto3.Text = "kripto3";
            kripto4.Text = "kripto4";
            gosterilencoinsayisi = 0;
        }

        private void parabirimicombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void currencydegistirbuton_Click(object sender, EventArgs e)
        {
            if(parabirimicombo.Text=="TRY(Türk Lirası)")
            {
                currency1.Text = "₺";
                currency2.Text = "₺";
                currency3.Text = "₺";
                currency4.Text = "₺";
            }else if (parabirimicombo.Text == "EUR(Euro)")
            {
                currency1.Text = "€";
                currency2.Text = "€";
                currency3.Text = "€";
                currency4.Text = "€";
            }else if(parabirimicombo.Text=="USD(Amerikan Doları)")
            {
                currency1.Text = "$";
                currency2.Text = "$";
                currency3.Text = "$";
                currency4.Text = "$";
            }else if(parabirimicombo.Text=="GBP(İngiliz Sterlini)")
            {
                currency1.Text = "£";
                currency2.Text = "£";
                currency3.Text = "£";
                currency4.Text = "£";
            }
            else
            {
                MessageBox.Show("Lütfen bir para birimi seçiniz.");
            }
        }
    }    
}
