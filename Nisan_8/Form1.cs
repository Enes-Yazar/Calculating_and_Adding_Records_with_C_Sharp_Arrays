using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nisan_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class hesapla
        {
            public int cıkar(int s1, int s2)
            {
                int cıkar;

                cıkar = s1 - s2;

                return cıkar;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;

            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);

            hesapla ck = new hesapla(); // dahili class
            label3.Text = ck.cıkar(sayi1, sayi2).ToString();


            Class1 topla = new Class1(); // ek class formu
            label2.Text = topla.tp(sayi1, sayi2).ToString();
        }

        int[] sayilar = new int[5];
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sayilar[i] = Convert.ToInt32(textBox3.Text);
                i++;
                textBox3.Clear();
                label5.Text = i + ". index numarası";

                if (i == 5)
                {
                    textBox3.Enabled = false;

                    MessageBox.Show("Sayı sınırı aşıldı");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(sayilar[i]).ToString();
            }
        }

        void text_kapa()
        {
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
        }
        void text_ac()
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double tp = 0;

                for (int i = 0; i < sayilar.Length; i++) // toplam
                {
                    tp = tp + sayilar[i];

                }

                double ort = 0; // ort
                ort = tp / i;

                textBox5.Text = ort.ToString();
                textBox4.Text = tp.ToString();


                text_kapa();
                textBox6.Text = sayilar.Max().ToString();
                 textBox7.Text = sayilar.Min().ToString();

               // buyuk_kucuk();
            }
            catch
            {

                MessageBox.Show("Eksik veya Boş Bırakılamaz");
            }
        }
      /*  void buyuk_kucuk()
        {
            int en_büyük = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > en_büyük)
                {
                    en_büyük = sayilar[i];

                }
            }

            textBox6.Text = en_büyük.ToString();

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (en_büyük > sayilar[i])
                {
                    en_büyük = sayilar[i];
                }
            }

            textBox7.Text = en_büyük.ToString();
        }
      */
        private void button4_Click(object sender, EventArgs e)
        {
            text_ac();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Array.Sort(sayilar); // küçükte büyüğe

            for (int i = 0; i < 5; i++)
            {
                listBox2.Items.Add(sayilar[i]);
            }

           /* int gecici;                                             
            for (int i = 0; i < sayilar.Length; i++)                
            {                                                       
                for (int j = 0; j < sayilar.Length; j++)            
                {                                                   
                    gecici = sayilar[i];                            
                                                                    
                    sayilar[i] = sayilar[j];                        
                                                                    
                    sayilar[j] = gecici;                            
                }
            }
                listBox2.Items.Add(i);
           */

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Array.Reverse(sayilar); // büyükten küçüğe
            for (int i = 0; i < 5; i++)
            {
                listBox3.Items.Add(sayilar[i]);
            }
        }

    }
}