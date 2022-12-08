using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form //Reyhan ödev
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void lblBasla_Click(object sender, EventArgs e)
        {

        }
        static int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cevap = textBox1.Text.ToUpper();
            if(e.KeyCode==Keys.Enter)
            {
                textBox1.Enabled = false;
                switch (soruno)
                {
                    case 1:
                        if(cevap=="A")
                        {
                            btnA.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 2:
                        if (cevap == "D")
                        {
                            btnB.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 3:
                        if (cevap == "A")
                        {
                            btnC.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 4:
                        if (cevap == "B")
                        {
                            btnD.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 5:
                        if (cevap == "C")
                        {
                            btnE.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 6:
                        if (cevap == "B")
                        {
                            btnF.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 7:
                        if (cevap == "C")
                        {
                            btnG.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 8:
                        if (cevap == "B")
                        {
                            btnH.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 9:
                        if (cevap == "C")
                        {
                            btnI.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 10:
                        if (cevap == "C")
                        {
                            btnJ.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 11:
                        if (cevap == "C")
                        {
                            btnK.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 12:
                        if (cevap == "B")
                        {
                            btnL.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 13:
                        if (cevap == "A")
                        {
                            btnM.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 14:
                        if (cevap == "A")
                        {
                            btnN.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 15:
                        if (cevap == "D")
                        {
                            BTNO.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            BTNO.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 16:
                        if (cevap == "B")
                        {
                            btnP.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 17:
                        if (cevap == "A")
                        {
                            btnR.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 18:
                        if (cevap == "D")
                        {
                            btnS.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 19:
                        if (cevap == "B")
                        {
                            btnT.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 20:
                        if (cevap == "C")
                        {
                            btnU.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 21:
                        if (cevap == "B")
                        {
                            btnV.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;
                    case 22:
                        if (cevap == "C")
                        {
                            btnY.BackColor = Color.Green;
                            dogruarttir();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlisarttir();
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        void dogruarttir()
        {
            dogru++;
            label1.Text = dogru.ToString();
        }
        void yanlisarttir()
        {
            yanlis++;
            label2.Text = yanlis.ToString();
        }

        string cevap = "";
        private void lnlBasla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            soruno++;
            lnlBasla.Text = "Sonraki";
            this.Text = soruno.ToString();
            textBox1.Clear();
            textBox1.Enabled = true;
            if(soruno==1)
            {
                richTextBox1.Text = "C# hakkında aşağıdakilerden hangisi doğrudur? (Lütfen doğru seçeneği cevap kutucuğuna yazınız.) " +

                    "\n " +
                    "\n A. Hepsi " +
                    "\n B. Çeşitli bilgisayar platformlarında derlenebilir. " +
                    "\n C. Bileşen (component) yönelimlidir. " +
                    "\n D. .Net Framework'ün bir parçasıdır. ";
                btnA.BackColor = Color.Yellow;
                harf.Text = btnA.Text;
            }
            else if(soruno==2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi C# 'daki değer türlerinden biridir? (Lütfen doğru seçeneği cevap kutucuğuna yazınız.) " +
                    "\n " +
                    "\n A. Int32 " +
                    "\n B. Double  " +
                    "\n C. Decimal" +
                    "\n D. Hepsi ";
                btnB.BackColor = Color.Yellow;
                harf.Text = btnB.Text;
            }
            else if(soruno==3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi C# 'da bir yorum (comment) yazmayı doğru göstermiştir." +
                    "\n " +
                    "\n A. // yorum " +
                    "\n B. # yorum  " +
                    "\n C. /* yorum" +
                    "\n D. Hepsi ";
                btnC.BackColor = Color.Yellow;
                harf.Text = btnC.Text;
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Nullable tip nedir ?" +
                    "\n " +
                    "\n A. Referans türüne null atanmasına izin verir. " +
                    "\n B. Değer türüne null değer atanmasına izin verir.  " +
                    "\n C. Statik sınıfa null atanmasına izin verir." +
                    "\n D. Hepsi ";
                btnD.BackColor = Color.Yellow;
                harf.Text = btnD.Text;
            }
            else if (soruno ==5)
            {
                richTextBox1.Text = "İki değeri bir araya getirmek için hangi operatör kullanılır ?" +
                    "\n " +
                    "\n A. & " +
                    "\n B. *  " +
                    "\n C. +" +
                    "\n D. Hepsi ";
                btnE.BackColor = Color.Yellow;
                harf.Text = btnE.Text;

            }
            else if (soruno == 6)
            {
                richTextBox1.Text = "Aşağıdaki operatörlerden hangisi C# 'da bir değişkenin adresini döndürür ?" +
                    "\n " +
                    "\n A. typeof " +
                    "\n B. &  " +
                    "\n C. * " +
                    "\n D. Hepsi ";
                btnF.BackColor = Color.Yellow;
                harf.Text = btnF.Text;
            }
            else if (soruno == 7)
            {
                richTextBox1.Text = "C# 'da bir if ifadesi yazmaya nasıl başlanır ? " +
                    "\n " +
                    "\n A. if x > y then:" +
                    "\n B. if x > y:  " +
                    "\n C. if (x > y)" +
                    "\n D. Hepsi ";
                btnG.BackColor = Color.Yellow;
                harf.Text = btnG.Text;
            }
            else if (soruno == 8)
            {
                richTextBox1.Text = " C# 'da while döngüsü yazmaya nasıl başlanır ?" +
                    "\n " +
                    "\n A. while x > y: " +
                    "\n B. while (x > y)  " +
                    "\n C. x > y while {" +
                    "\n D. Hepsi ";
                btnH.BackColor = Color.Yellow;
                harf.Text = btnH.Text;
            }
            else if (soruno == 9)
            {
                richTextBox1.Text = "Hangi erişim değiştirici, kodu yalnızca aynı sınıfta erişilebilir kılar ?" +
                    "\n " +
                    "\n A. public " +
                    "\n B. abstract  " +
                    "\n C. private" +
                    "\n D. Hepsi ";
                btnI.BackColor = Color.Yellow;
                harf.Text = btnI.Text;
            }
            else if (soruno == 10)
            {
                richTextBox1.Text = "C# 'da bir döngüyü durdurmak için hangi ifade kullanılır ?" +
                    "\n " +
                    "\n A. stop " +
                    "\n B. exit  " +
                    "\n C. break" +
                    "\n D. Hepsi ";
                btnJ.BackColor = Color.Yellow;
                harf.Text = btnJ.Text;
            }
            else if (soruno == 11)
            {
                richTextBox1.Text = "Bir yöntem (method) içindeki bir değeri döndürmek için hangi anahtar kelime kullanılır ?" +
                    "\n " +
                    "\n A. void " +
                    "\n B. get  " +
                    "\n C. return" +
                    "\n D. Hepsi ";
                btnK.BackColor = Color.Yellow;
                harf.Text = btnK.Text;
            }
            else if (soruno == 12)
            {
                richTextBox1.Text = "C# 'da dizilerin (array) indeksi ___ ile başlar." +
                    "\n " +
                    "\n A. 1 " +
                    "\n B. 0  " +
                    "\n C. -1" +
                    "\n D. -2 ";
                btnL.BackColor = Color.Yellow;
                harf.Text = btnL.Text;
            }
            else if (soruno == 13)
            {
                richTextBox1.Text = "Bir dizinin uzunluğunu bulmak için hangi özellik kullanılabilir ?" +
                    "\n " +
                    "\n A. Length " +
                    "\n B. getLength()  " +
                    "\n C. length()" +
                    "\n D. long ";
                btnM.BackColor = Color.Yellow;
                harf.Text = btnM.Text;
            }
            else if (soruno == 14)
            {
                richTextBox1.Text = " C# 'daki Array (dizi) sınıfının aşağıdaki özelliğinden hangisi Array öğesinin sabit bir boyutu olup olmadığını denetler ?" +
                    "\n " +
                    "\n A. IsFixedSize " +
                    "\n B. IsStatic  " +
                    "\n C. Length" +
                    "\n D. Hepsi ";
                btnN.BackColor = Color.Yellow;
                harf.Text = btnN.Text;
            }
            else if (soruno == 15)
            {
                richTextBox1.Text = "Aşağıdaki hangisi C# programına namespace (alan adı) eklemek için kullanılır ?" +
                    "\n " +
                    "\n A. imports " +
                    "\n B. exports  " +
                    "\n C. using" +
                    "\n D. Hepsi ";
                BTNO.BackColor = Color.Yellow;
                harf.Text = BTNO.Text;
            }
            else if (soruno == 16)
            {
                richTextBox1.Text = "Aşağıdaki seçeneklerden hangisi, kendi nesneleri olmayan ancak alt sınıfı için temel sınıf görevi gören sınıf türünü temsil eder ?" +
                    "\n " +
                    "\n A. Static class " +
                    "\n B. Abstract class  " +
                    "\n C. Derived class" +
                    "\n D. Hepsi ";
                btnP.BackColor = Color.Yellow;
                harf.Text = btnP.Text;
            }
            else if (soruno == 17)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi aynı sınıfta aynı ada sahip ancak farklı parametreleri içeren iki veya daha fazla metod tanımlama işlemini temsil eder ?" +
                    "\n " +
                    "\n A. Overloading " +
                    "\n B. Overriding  " +
                    "\n C. Encapsulation" +
                    "\n D. Hepsi ";
                btnR.BackColor = Color.Yellow;
                harf.Text = btnR.Text;
            }
            else if (soruno == 18)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi döngü komutudur?" +
                    "\n " +
                    "\n A. main  " +
                    "\n B. if   " +
                    "\n C. switch " +
                    "\n D. while ";
                btnS.BackColor = Color.Yellow;
                harf.Text = btnS.Text;
            }
            else if (soruno == 19)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi karşılaştırma komutudur?" +
                    "\n " +
                    "\n A. do while " +
                    "\n B. if  " +
                    "\n C. for " +
                    "\n D. convert ";
                btnT.BackColor = Color.Yellow;
                harf.Text = btnT.Text;
            }
            else if (soruno == 20)
            {
                richTextBox1.Text = "Karşılaştırma işlemlerinde kullanılan “eşittir” operatörü aşağıdakilerden hangisidir?" +
                    "\n " +
                    "\n A. =  " +
                    "\n B. <>  " +
                    "\n C. = = " +
                    "\n D. != ";
                btnU.BackColor = Color.Yellow;
                harf.Text = btnU.Text;
            }
            else if (soruno == 21)
            {
                richTextBox1.Text = "A=B; komut satırının anlamı nedir?" +
                    "\n " +
                    "\n A. A değişkeninin değerini B değişkenine aktarır. " +
                    "\n B. B değişkeninin değerini A değişkenine aktarır.  " +
                    "\n C. A değişkeninin değeri B değişkeninin değerine eşit ise ekrana mesaj yazar" +
                    "\n D. Hata verir. ";
                btnV.BackColor = Color.Yellow;
                harf.Text = btnV.Text;
            }
            else if (soruno == 22)
            {
                richTextBox1.Text = "Mod alma işlemi için kullanılan operatör aşağıdakilerden hangisidir?" +
                    "\n " +
                    "\n A. +  " +
                    "\n B. #   " +
                    "\n C. % " +
                    "\n D. * ";
                btnY.BackColor = Color.Yellow;
                harf.Text = btnY.Text;
            }
        }
    }
}
