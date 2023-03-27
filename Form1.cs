using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0, yanlis = 0 , dogru = 0;

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (soruno)
            {
                case 1:
                    if (textBox1.Text.ToLower() == "akdeniz")
                    {
                        btnA.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnA.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                    ; break;
                case 2:
                    if (textBox1.Text.ToLower() == "bursa")
                    {
                        btnB.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnB.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                    ; break;
                case 3:
                    if (textBox1.Text.ToLower() == "cuma")
                    {
                        btnC.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnC.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 4:
                    if (textBox1.Text.ToLower() == "diyarbakır")
                    {
                        btnD.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnD.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                    ; break;
                case 5:
                    if (textBox1.Text.ToLower() == "eski")
                    {
                        btnE.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnE.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 6:
                    if (textBox1.Text.ToLower() == "ferman")
                    {
                        btnF.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnF.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 7:
                    if (textBox1.Text.ToLower() == "güneş")
                    {
                        btnG.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnG.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                    ; break;
                case 8:
                    if (textBox1.Text.ToLower() == "haziran")
                    {
                        btnH.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnH.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 9:
                    if (textBox1.Text.ToLower() == "ısparta")
                    {
                        btnI.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnI.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 10:
                    if (textBox1.Text.ToLower() == "içel")
                    {
                        btnİ.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnİ.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 11:
                    if (textBox1.Text.ToLower() == "jandarma")
                    {
                        btnJ.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnJ.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 12:
                    if (textBox1.Text.ToLower() == "kayısı")
                    {
                        btnK.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnK.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 13:
                    if (textBox1.Text.ToLower() == "lale festivali")
                    {
                        btnL.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnL.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 14:
                    if (textBox1.Text.ToLower() == "mart")
                    {
                        btnM.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnM.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 15:
                    if (textBox1.Text.ToLower() == "ney")
                    {
                        btnN.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnN.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 16:
                    if (textBox1.Text.ToLower() == "ozan")
                    {
                        btnO.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnO.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 17:
                    if (textBox1.Text.ToLower() == "pırasa")
                    {
                        btnP.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnP.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 18:
                    if (textBox1.Text.ToLower() == "ramazan")
                    {
                        btnR.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnR.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 19:
                    if (textBox1.Text.ToLower() == "snake")
                    {
                        btnS.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnS.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 20:
                    if (textBox1.Text.ToLower() == "tarkan")
                    {
                        btnT.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnT.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 21:
                    if (textBox1.Text.ToLower() == "umut")
                    {
                        btnU.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnU.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 22:
                    if (textBox1.Text.ToLower() == "van")
                    {
                        btnV.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnV.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 23:
                    if (textBox1.Text.ToLower() == "yıldırım")
                    {
                        btnY.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnY.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                case 24:
                    if (textBox1.Text.ToLower() == "zeytin")
                    {
                        btnZ.BackColor = Color.Green;
                        dogru++;
                        lblTrue.Text = dogru.ToString();
                        linkLabel2.Visible = false;
                    }
                    else
                    {
                        btnZ.BackColor = Color.Red;
                        yanlis++;
                        lblFalse.Text = yanlis.ToString();
                        linkLabel2.Visible = false;
                    }
                        ; break;
                    
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = "Soru No :" + soruno;
            switch (soruno)
            {
                case 1:
                        richTextBox1.Text = "Ülkemizin Güney Kıyı Bölgesi ?";
                        btnA.BackColor = Color.Yellow;
                    ;
                    break;
                case 2:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Yeşilliği İle Meşhur Marmara İlimiz ?";
                        btnB.BackColor = Color.Yellow;
                    ;
                    break;
                case 3:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Müslümanların Kutsal Günü ?";
                        btnC.BackColor = Color.Yellow;
                    ;
                    break;
                case 4:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Karpuzu İle Ünlü İlimiz ?";
                        btnD.BackColor = Color.Yellow;
                    ;
                    break;
                case 5:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Yeni Kelimesinin Zıt Anlamlısı ?";
                        btnE.BackColor = Color.Yellow;
                    ;
                    break;
                case 6:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Padişahın Emirlerinin Yazılı Hali ?";
                        btnF.BackColor = Color.Yellow;
                    ;
                    break;
                case 7:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Dünyanın Isı Kaynağı ?";
                        btnG.BackColor = Color.Yellow;
                    ;
                    break;
                case 8:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Yaz Ayı ?";
                        btnH.BackColor = Color.Yellow;
                    ;
                    break;
                case 9:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Gülüyle Ünlü İlimiz ?";
                        btnI.BackColor = Color.Yellow;
                    ;
                    break;
                case 10:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Mersinin Önceki İsmi ?";
                    btnİ.BackColor = Color.Yellow;
                    ;
                    break;
                case 11:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Askeri Topluluk ?";
                    btnJ.BackColor = Color.Yellow;
                    ;
                    break;
                case 12:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Malatyanın Meşhur Meyvesi ?";
                    btnK.BackColor = Color.Yellow;
                    ;
                    break;
                case 13:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Her Yıl Bahar Aylarında Düzenlenen Çiçek Festivali?";
                    btnL.BackColor = Color.Yellow;
                    ;
                    break;
                case 14:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Yılın 3.Ayı ?";
                    btnM.BackColor = Color.Yellow;
                    ;
                    break;
                case 15:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Üflemeli Müzik Hali ?";
                    btnN.BackColor = Color.Yellow;
                    ;
                    break;
                case 16:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Halk Şairi ?";
                    btnO.BackColor = Color.Yellow;
                    ;
                    break;
                case 17:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Sebzeler İle Yapılan Yemek ?";
                    btnP.BackColor = Color.Yellow;
                    ;
                    break;
                case 18:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "11 Ayın Sultanı ?";
                    btnR.BackColor = Color.Yellow;
                    ;
                    break;
                case 19:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "İngilize Yılan Kelimesi ?";
                    btnS.BackColor = Color.Yellow;
                    ;
                    break;
                case 20:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Türkiyenin Megastarı ?";
                    btnT.BackColor = Color.Yellow;
                    ;
                    break;
                case 21:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Ümit Kelimesinin Eş Anlamlısı ?";
                    btnU.BackColor = Color.Yellow;
                    ;
                    break;
                case 22:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Kahvaltısı İle Ünlü İlimiz ?";
                    btnV.BackColor = Color.Yellow;
                    ;
                    break;
                case 23:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Şimşek Kelimesinin Eş Anlamlısı ?";
                    btnY.BackColor = Color.Yellow;
                    ;
                    break;
                case 24:
                    linkLabel2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                    richTextBox1.Text = "Kahvaltılık Çeşiti ?";
                    btnZ.BackColor = Color.Yellow;
                    ;
                    break;
            }
            if (soruno>24)
            {
                btnEmpty.Text = "Tebrikler! Yarışmayı Tamamladınız!";
            }
        }
    }
}
