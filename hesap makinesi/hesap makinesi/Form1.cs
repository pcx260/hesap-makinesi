
namespace hesap_makinesi

{
    public partial class Form1 : Form
    {

        string _sayi1;
        string _sayi2;
        bool _top = false;
        bool _bol = false;
        bool _carp = false;
        bool _cik = false;
        int _sayac = 0;
        bool _son = false;
        
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }


            if (_sayac==0)
            {
                _sayi1 +="1";
                label1.Text += "1";
            }

            if (_sayac==1)
            {
                _sayi2 += "1";
                     label1.Text += "1";
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }



            if (_sayac == 0)
            {
                _sayi1 += "2";
                label1.Text += "2";
            }

            if (_sayac == 1)
            {
                _sayi2 +="2";
                label1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }


            if (_sayac == 0)
            {
                _sayi1 +="3";
                label1.Text += "3";
            }

            if (_sayac == 1)
            {
                _sayi2 += "3";
                label1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }

            if (_sayac == 0)
            {
                _sayi1 += "4";
                label1.Text += "4";
            }

            if (_sayac == 1)
            {
                _sayi2 += "4";
                label1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }


            if (_sayac == 0)
            {
                _sayi1 += "5";
                label1.Text += "5";
            }

            if (_sayac == 1)
            {
                _sayi2 += "5";
                label1.Text += "5";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (_son)
            {
                label1.Text = "";
                _son = false;
            }


            if (_sayac == 0)
            {
                _sayi1 += "6";
                label1.Text += "6";
            }

            if (_sayac == 1)
            {
                _sayi2 += "6";
                label1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }


            if (_sayac == 0)
            {
                _sayi1 += "7";
                label1.Text += "7";
            }

            if (_sayac == 1)
            {
                _sayi2 += "7";
                label1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }


            if (_sayac == 0)
            {
                _sayi1 += "8";
                label1.Text += "8";
            }

            if (_sayac == 1)
            {
                _sayi2 += "8";
                label1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }



            if (_sayac == 0)
            {
                _sayi1 += "9";
                label1.Text += "9";
            }

            if (_sayac == 1)
            {
                _sayi2 += "9";
                label1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_son)
            {
                label1.Text = "";
                _son = false;
            }


            if (_sayac == 0)
            {
                _sayi1 += "0";
                label1.Text += "0";
            }

            if (_sayac == 1)
            {
                _sayi2 += "0";
                label1.Text += "0";
            }
        }

        private void carp_Click(object sender, EventArgs e)
        {
            if (_sayac == 0)
            {
                _carp = true;
                _sayac++;

                label1.Text += "x";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (_sayac == 0)
            {
                _top = true;
                _sayac++;
                label1.Text += "+";
            }
        }

        private void eksi_Click(object sender, EventArgs e)
        {
            if (_sayac == 0)
            {
                _cik = true;
                _sayac++;
                label1.Text += "-";
            }
        }

        private void bol_Click(object sender, EventArgs e)
        {
            if (_sayac==0)
            {
                _bol = true;
                _sayac++;
                label1.Text += "/";
            }
            
        }

        private void esit_Click(object sender, EventArgs e)
        {
            
            if (_top)
            {
                int sonuc = Convert.ToInt32(_sayi1) + Convert.ToInt32(_sayi2);
                string sonuc2 = Convert.ToString(sonuc);
                label1.Text = sonuc2;

            }

            if (_cik)
            {
                int sonuc = Convert.ToInt32(_sayi1) - Convert.ToInt32(_sayi2);
                string sonuc2 = Convert.ToString(sonuc);
                label1.Text = sonuc2;

            }

            if (_carp)
            {
                int sonuc = Convert.ToInt32(_sayi1) * Convert.ToInt32(_sayi2);
                string sonuc2 = Convert.ToString(sonuc);
                label1.Text = sonuc2;

            }

            if (_bol)
            {
                int sonuc = Convert.ToInt32(_sayi1) / Convert.ToInt32(_sayi2);
                string sonuc2 = Convert.ToString(sonuc);
                label1.Text = sonuc2;

            }
            _son = true;
            _sayac = 0;
            _sayi1 = "";
            _sayi2 = "";



        }
    }

}


