namespace binancebot10042021
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gosterilecekcoincombo = new System.Windows.Forms.ComboBox();
            this.parabirimicombo = new System.Windows.Forms.ComboBox();
            this.gosterilecekcoingoster = new System.Windows.Forms.Button();
            this.gösterilecekcointemizle = new System.Windows.Forms.Button();
            this.currencysec = new System.Windows.Forms.Button();
            this.kripto1 = new System.Windows.Forms.Label();
            this.kripto2 = new System.Windows.Forms.Label();
            this.kripto3 = new System.Windows.Forms.Label();
            this.kripto4 = new System.Windows.Forms.Label();
            this.kripto3deger = new System.Windows.Forms.Label();
            this.kripto2deger = new System.Windows.Forms.Label();
            this.kripto1deger = new System.Windows.Forms.Label();
            this.kripto4deger = new System.Windows.Forms.Label();
            this.currency3 = new System.Windows.Forms.Label();
            this.currency2 = new System.Windows.Forms.Label();
            this.currency1 = new System.Windows.Forms.Label();
            this.currency4 = new System.Windows.Forms.Label();
            this.parabirimisiracombo = new System.Windows.Forms.ComboBox();
            this.alinacakcoincombo = new System.Windows.Forms.ComboBox();
            this.surebittigindekarcheck = new System.Windows.Forms.CheckBox();
            this.butcetextbox = new System.Windows.Forms.TextBox();
            this.butceparabirimicombo = new System.Windows.Forms.ComboBox();
            this.baslatmabutonu = new System.Windows.Forms.Button();
            this.alisfiyatitextbox = new System.Windows.Forms.TextBox();
            this.fiyataraligitextbox = new System.Windows.Forms.TextBox();
            this.suresaattextbox = new System.Windows.Forms.TextBox();
            this.emailcheckbox = new System.Windows.Forms.CheckBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.yuzdedusustesatisyap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gosterilecekcoincombo
            // 
            this.gosterilecekcoincombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gosterilecekcoincombo.FormattingEnabled = true;
            this.gosterilecekcoincombo.Items.AddRange(new object[] {
            "Bitcoin (BTC)",
            "Ethereum (ETH)",
            "Ripple (XRP)",
            "Dogecoin (DOGE)",
            "BitTorrent (BTTN)",
            "Holochain (HOT)",
            "Chiliz (CHZ)",
            "Avalanche (AVAX)",
            "Ravencoin (RVN)",
            "Troncoin (TRX)"});
            this.gosterilecekcoincombo.Location = new System.Drawing.Point(620, 58);
            this.gosterilecekcoincombo.Name = "gosterilecekcoincombo";
            this.gosterilecekcoincombo.Size = new System.Drawing.Size(222, 37);
            this.gosterilecekcoincombo.TabIndex = 0;
            // 
            // parabirimicombo
            // 
            this.parabirimicombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parabirimicombo.FormattingEnabled = true;
            this.parabirimicombo.Items.AddRange(new object[] {
            "Türk Lirası (TL)",
            "Amerikan Doları (USD)",
            "Euro (EUR)",
            "İngiliz Sterlini (GBP)",
            "Japon Yeni (JPY)",
            "Azerbaycan Manatı (AZN)"});
            this.parabirimicombo.Location = new System.Drawing.Point(609, 141);
            this.parabirimicombo.Name = "parabirimicombo";
            this.parabirimicombo.Size = new System.Drawing.Size(255, 37);
            this.parabirimicombo.TabIndex = 1;
            // 
            // gosterilecekcoingoster
            // 
            this.gosterilecekcoingoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gosterilecekcoingoster.Location = new System.Drawing.Point(759, 102);
            this.gosterilecekcoingoster.Name = "gosterilecekcoingoster";
            this.gosterilecekcoingoster.Size = new System.Drawing.Size(83, 33);
            this.gosterilecekcoingoster.TabIndex = 2;
            this.gosterilecekcoingoster.Text = "Göster";
            this.gosterilecekcoingoster.UseVisualStyleBackColor = true;
            this.gosterilecekcoingoster.Click += new System.EventHandler(this.gosterilecekcoingoster_Click);
            // 
            // gösterilecekcointemizle
            // 
            this.gösterilecekcointemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gösterilecekcointemizle.Location = new System.Drawing.Point(656, 101);
            this.gösterilecekcointemizle.Name = "gösterilecekcointemizle";
            this.gösterilecekcointemizle.Size = new System.Drawing.Size(97, 33);
            this.gösterilecekcointemizle.TabIndex = 3;
            this.gösterilecekcointemizle.Text = "Temizle";
            this.gösterilecekcointemizle.UseVisualStyleBackColor = true;
            this.gösterilecekcointemizle.Click += new System.EventHandler(this.gösterilecekcointemizle_Click);
            // 
            // currencysec
            // 
            this.currencysec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currencysec.Location = new System.Drawing.Point(680, 184);
            this.currencysec.Name = "currencysec";
            this.currencysec.Size = new System.Drawing.Size(84, 33);
            this.currencysec.TabIndex = 4;
            this.currencysec.Text = "Seç";
            this.currencysec.UseVisualStyleBackColor = true;
            this.currencysec.Click += new System.EventHandler(this.currencysec_Click);
            // 
            // kripto1
            // 
            this.kripto1.AutoSize = true;
            this.kripto1.BackColor = System.Drawing.Color.Transparent;
            this.kripto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kripto1.ForeColor = System.Drawing.Color.Khaki;
            this.kripto1.Location = new System.Drawing.Point(36, 70);
            this.kripto1.Name = "kripto1";
            this.kripto1.Size = new System.Drawing.Size(92, 25);
            this.kripto1.TabIndex = 5;
            this.kripto1.Text = "Kripto 1:";
            // 
            // kripto2
            // 
            this.kripto2.AutoSize = true;
            this.kripto2.BackColor = System.Drawing.Color.Transparent;
            this.kripto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kripto2.ForeColor = System.Drawing.Color.Khaki;
            this.kripto2.Location = new System.Drawing.Point(36, 105);
            this.kripto2.Name = "kripto2";
            this.kripto2.Size = new System.Drawing.Size(92, 25);
            this.kripto2.TabIndex = 6;
            this.kripto2.Text = "Kripto 2:";
            // 
            // kripto3
            // 
            this.kripto3.AutoSize = true;
            this.kripto3.BackColor = System.Drawing.Color.Transparent;
            this.kripto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kripto3.ForeColor = System.Drawing.Color.Khaki;
            this.kripto3.Location = new System.Drawing.Point(36, 141);
            this.kripto3.Name = "kripto3";
            this.kripto3.Size = new System.Drawing.Size(92, 25);
            this.kripto3.TabIndex = 7;
            this.kripto3.Text = "Kripto 3:";
            // 
            // kripto4
            // 
            this.kripto4.AutoSize = true;
            this.kripto4.BackColor = System.Drawing.Color.Transparent;
            this.kripto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kripto4.ForeColor = System.Drawing.Color.Khaki;
            this.kripto4.Location = new System.Drawing.Point(36, 175);
            this.kripto4.Name = "kripto4";
            this.kripto4.Size = new System.Drawing.Size(92, 25);
            this.kripto4.TabIndex = 8;
            this.kripto4.Text = "Kripto 4:";
            // 
            // kripto3deger
            // 
            this.kripto3deger.AutoSize = true;
            this.kripto3deger.BackColor = System.Drawing.Color.Transparent;
            this.kripto3deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kripto3deger.ForeColor = System.Drawing.Color.Khaki;
            this.kripto3deger.Location = new System.Drawing.Point(152, 141);
            this.kripto3deger.Name = "kripto3deger";
            this.kripto3deger.Size = new System.Drawing.Size(36, 25);
            this.kripto3deger.TabIndex = 9;
            this.kripto3deger.Text = "00";
            // 
            // kripto2deger
            // 
            this.kripto2deger.AutoSize = true;
            this.kripto2deger.BackColor = System.Drawing.Color.Transparent;
            this.kripto2deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kripto2deger.ForeColor = System.Drawing.Color.Khaki;
            this.kripto2deger.Location = new System.Drawing.Point(152, 104);
            this.kripto2deger.Name = "kripto2deger";
            this.kripto2deger.Size = new System.Drawing.Size(36, 25);
            this.kripto2deger.TabIndex = 10;
            this.kripto2deger.Text = "00";
            // 
            // kripto1deger
            // 
            this.kripto1deger.AutoSize = true;
            this.kripto1deger.BackColor = System.Drawing.Color.Transparent;
            this.kripto1deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kripto1deger.ForeColor = System.Drawing.Color.Khaki;
            this.kripto1deger.Location = new System.Drawing.Point(152, 70);
            this.kripto1deger.Name = "kripto1deger";
            this.kripto1deger.Size = new System.Drawing.Size(36, 25);
            this.kripto1deger.TabIndex = 11;
            this.kripto1deger.Text = "00";
            // 
            // kripto4deger
            // 
            this.kripto4deger.AutoSize = true;
            this.kripto4deger.BackColor = System.Drawing.Color.Transparent;
            this.kripto4deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kripto4deger.ForeColor = System.Drawing.Color.Khaki;
            this.kripto4deger.Location = new System.Drawing.Point(152, 175);
            this.kripto4deger.Name = "kripto4deger";
            this.kripto4deger.Size = new System.Drawing.Size(36, 25);
            this.kripto4deger.TabIndex = 12;
            this.kripto4deger.Text = "00";
            // 
            // currency3
            // 
            this.currency3.AutoSize = true;
            this.currency3.BackColor = System.Drawing.Color.Transparent;
            this.currency3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currency3.ForeColor = System.Drawing.Color.Khaki;
            this.currency3.Location = new System.Drawing.Point(310, 141);
            this.currency3.Name = "currency3";
            this.currency3.Size = new System.Drawing.Size(19, 25);
            this.currency3.TabIndex = 13;
            this.currency3.Text = "-";
            // 
            // currency2
            // 
            this.currency2.AutoSize = true;
            this.currency2.BackColor = System.Drawing.Color.Transparent;
            this.currency2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currency2.ForeColor = System.Drawing.Color.Khaki;
            this.currency2.Location = new System.Drawing.Point(310, 105);
            this.currency2.Name = "currency2";
            this.currency2.Size = new System.Drawing.Size(19, 25);
            this.currency2.TabIndex = 14;
            this.currency2.Text = "-";
            // 
            // currency1
            // 
            this.currency1.AutoSize = true;
            this.currency1.BackColor = System.Drawing.Color.Transparent;
            this.currency1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currency1.ForeColor = System.Drawing.Color.Khaki;
            this.currency1.Location = new System.Drawing.Point(310, 70);
            this.currency1.Name = "currency1";
            this.currency1.Size = new System.Drawing.Size(19, 25);
            this.currency1.TabIndex = 15;
            this.currency1.Text = "-";
            // 
            // currency4
            // 
            this.currency4.AutoSize = true;
            this.currency4.BackColor = System.Drawing.Color.Transparent;
            this.currency4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currency4.ForeColor = System.Drawing.Color.Khaki;
            this.currency4.Location = new System.Drawing.Point(310, 175);
            this.currency4.Name = "currency4";
            this.currency4.Size = new System.Drawing.Size(19, 25);
            this.currency4.TabIndex = 16;
            this.currency4.Text = "-";
            // 
            // parabirimisiracombo
            // 
            this.parabirimisiracombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parabirimisiracombo.FormattingEnabled = true;
            this.parabirimisiracombo.Items.AddRange(new object[] {
            "Kripto 1",
            "Kripto 2",
            "Kripto 3",
            "Kripto 4"});
            this.parabirimisiracombo.Location = new System.Drawing.Point(506, 141);
            this.parabirimisiracombo.Name = "parabirimisiracombo";
            this.parabirimisiracombo.Size = new System.Drawing.Size(97, 37);
            this.parabirimisiracombo.TabIndex = 17;
            // 
            // alinacakcoincombo
            // 
            this.alinacakcoincombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alinacakcoincombo.FormattingEnabled = true;
            this.alinacakcoincombo.Items.AddRange(new object[] {
            "Bitcoin (BTC)",
            "Ethereum (ETH)",
            "Ripple (XRP)",
            "Dogecoin (DOGE)",
            "BitTorrent (BTTN)",
            "Holochain (HOT)",
            "Chiliz (CHZ)",
            "Avalanche (AVAX)",
            "Ravencoin (RVN)",
            "Troncoin (TRX)"});
            this.alinacakcoincombo.Location = new System.Drawing.Point(194, 248);
            this.alinacakcoincombo.Name = "alinacakcoincombo";
            this.alinacakcoincombo.Size = new System.Drawing.Size(222, 37);
            this.alinacakcoincombo.TabIndex = 18;
            // 
            // surebittigindekarcheck
            // 
            this.surebittigindekarcheck.AutoSize = true;
            this.surebittigindekarcheck.BackColor = System.Drawing.Color.Transparent;
            this.surebittigindekarcheck.Location = new System.Drawing.Point(712, 307);
            this.surebittigindekarcheck.Name = "surebittigindekarcheck";
            this.surebittigindekarcheck.Size = new System.Drawing.Size(15, 14);
            this.surebittigindekarcheck.TabIndex = 19;
            this.surebittigindekarcheck.UseVisualStyleBackColor = false;
            // 
            // butcetextbox
            // 
            this.butcetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butcetextbox.Location = new System.Drawing.Point(99, 290);
            this.butcetextbox.Name = "butcetextbox";
            this.butcetextbox.Size = new System.Drawing.Size(153, 31);
            this.butcetextbox.TabIndex = 20;
            // 
            // butceparabirimicombo
            // 
            this.butceparabirimicombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butceparabirimicombo.FormattingEnabled = true;
            this.butceparabirimicombo.Items.AddRange(new object[] {
            "Türk Lirası (TL)",
            "Amerikan Doları (USD)",
            "Euro (EUR)",
            "İngiliz Sterlini (GBP)",
            "Japon Yeni (JPY)",
            "Azerbaycan Manatı (AZN)"});
            this.butceparabirimicombo.Location = new System.Drawing.Point(258, 289);
            this.butceparabirimicombo.Name = "butceparabirimicombo";
            this.butceparabirimicombo.Size = new System.Drawing.Size(97, 32);
            this.butceparabirimicombo.TabIndex = 21;
            // 
            // baslatmabutonu
            // 
            this.baslatmabutonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslatmabutonu.Location = new System.Drawing.Point(534, 463);
            this.baslatmabutonu.Name = "baslatmabutonu";
            this.baslatmabutonu.Size = new System.Drawing.Size(159, 48);
            this.baslatmabutonu.TabIndex = 22;
            this.baslatmabutonu.Text = "Başlat";
            this.baslatmabutonu.UseVisualStyleBackColor = true;
            this.baslatmabutonu.Click += new System.EventHandler(this.baslatmabutonu_Click);
            // 
            // alisfiyatitextbox
            // 
            this.alisfiyatitextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alisfiyatitextbox.Location = new System.Drawing.Point(144, 329);
            this.alisfiyatitextbox.Name = "alisfiyatitextbox";
            this.alisfiyatitextbox.Size = new System.Drawing.Size(153, 31);
            this.alisfiyatitextbox.TabIndex = 23;
            // 
            // fiyataraligitextbox
            // 
            this.fiyataraligitextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyataraligitextbox.Location = new System.Drawing.Point(157, 369);
            this.fiyataraligitextbox.Name = "fiyataraligitextbox";
            this.fiyataraligitextbox.Size = new System.Drawing.Size(153, 31);
            this.fiyataraligitextbox.TabIndex = 24;
            // 
            // suresaattextbox
            // 
            this.suresaattextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suresaattextbox.Location = new System.Drawing.Point(712, 252);
            this.suresaattextbox.Name = "suresaattextbox";
            this.suresaattextbox.Size = new System.Drawing.Size(153, 31);
            this.suresaattextbox.TabIndex = 25;
            // 
            // emailcheckbox
            // 
            this.emailcheckbox.AutoSize = true;
            this.emailcheckbox.BackColor = System.Drawing.Color.Transparent;
            this.emailcheckbox.Location = new System.Drawing.Point(824, 353);
            this.emailcheckbox.Name = "emailcheckbox";
            this.emailcheckbox.Size = new System.Drawing.Size(15, 14);
            this.emailcheckbox.TabIndex = 26;
            this.emailcheckbox.UseVisualStyleBackColor = false;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailtextbox.Location = new System.Drawing.Point(107, 474);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(298, 31);
            this.emailtextbox.TabIndex = 27;
            // 
            // yuzdedusustesatisyap
            // 
            this.yuzdedusustesatisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuzdedusustesatisyap.Location = new System.Drawing.Point(253, 417);
            this.yuzdedusustesatisyap.Name = "yuzdedusustesatisyap";
            this.yuzdedusustesatisyap.Size = new System.Drawing.Size(39, 31);
            this.yuzdedusustesatisyap.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::binancebot10042021.Properties.Resources.arkaplan10042021;
            this.ClientSize = new System.Drawing.Size(992, 523);
            this.Controls.Add(this.yuzdedusustesatisyap);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.emailcheckbox);
            this.Controls.Add(this.suresaattextbox);
            this.Controls.Add(this.fiyataraligitextbox);
            this.Controls.Add(this.alisfiyatitextbox);
            this.Controls.Add(this.baslatmabutonu);
            this.Controls.Add(this.butceparabirimicombo);
            this.Controls.Add(this.butcetextbox);
            this.Controls.Add(this.surebittigindekarcheck);
            this.Controls.Add(this.alinacakcoincombo);
            this.Controls.Add(this.parabirimisiracombo);
            this.Controls.Add(this.currency4);
            this.Controls.Add(this.currency1);
            this.Controls.Add(this.currency2);
            this.Controls.Add(this.currency3);
            this.Controls.Add(this.kripto4deger);
            this.Controls.Add(this.kripto1deger);
            this.Controls.Add(this.kripto2deger);
            this.Controls.Add(this.kripto3deger);
            this.Controls.Add(this.kripto4);
            this.Controls.Add(this.kripto3);
            this.Controls.Add(this.kripto2);
            this.Controls.Add(this.kripto1);
            this.Controls.Add(this.currencysec);
            this.Controls.Add(this.gösterilecekcointemizle);
            this.Controls.Add(this.gosterilecekcoingoster);
            this.Controls.Add(this.parabirimicombo);
            this.Controls.Add(this.gosterilecekcoincombo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "R3izler Otomasyon Bitcoin/Altcoin Otomasyonu 2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gosterilecekcoincombo;
        private System.Windows.Forms.ComboBox parabirimicombo;
        private System.Windows.Forms.Button gosterilecekcoingoster;
        private System.Windows.Forms.Button gösterilecekcointemizle;
        private System.Windows.Forms.Button currencysec;
        private System.Windows.Forms.Label kripto1;
        private System.Windows.Forms.Label kripto2;
        private System.Windows.Forms.Label kripto3;
        private System.Windows.Forms.Label kripto4;
        private System.Windows.Forms.Label kripto3deger;
        private System.Windows.Forms.Label kripto2deger;
        private System.Windows.Forms.Label kripto1deger;
        private System.Windows.Forms.Label kripto4deger;
        private System.Windows.Forms.Label currency3;
        private System.Windows.Forms.Label currency2;
        private System.Windows.Forms.Label currency1;
        private System.Windows.Forms.Label currency4;
        private System.Windows.Forms.ComboBox parabirimisiracombo;
        private System.Windows.Forms.ComboBox alinacakcoincombo;
        private System.Windows.Forms.CheckBox surebittigindekarcheck;
        private System.Windows.Forms.TextBox butcetextbox;
        private System.Windows.Forms.ComboBox butceparabirimicombo;
        private System.Windows.Forms.Button baslatmabutonu;
        private System.Windows.Forms.TextBox alisfiyatitextbox;
        private System.Windows.Forms.TextBox fiyataraligitextbox;
        private System.Windows.Forms.TextBox suresaattextbox;
        private System.Windows.Forms.CheckBox emailcheckbox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox yuzdedusustesatisyap;
    }
}

