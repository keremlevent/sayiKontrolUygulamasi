using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypÖdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void EkraniAyarla()
        {
            
            {
                txtBaslangicDegeri.Text = txtBitisDegeri.Text = "0";
                txtBaslangicDegeri.Focus();
            }
        }

        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(txtBaslangicDegeri.Text);
                Convert.ToInt32(txtBitisDegeri.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public Boolean TekCiftKontrol(int i)
        {
            {
                {
                    if (i % 2 == 0)
                    {
                        return true;

                    }

                    else
                        return false;
                }
            }
        }

        int toplamTek = 0, toplamCift = 0, carpimTek = 1, carpimCift = 1; 
        public void HesapTekCift(int i, int bitisDegeri, bool tekCiftBool)
        {
          

            if (tekCiftBool)
            {
                toplamCift = toplamCift + i;
                carpimCift = carpimCift * i;
            }
            else
            {
                toplamTek = toplamTek + i;
                carpimTek = carpimTek * i;
            }

            if (i == bitisDegeri)
            {
                txtCiftToplamSonucu.Text = toplamCift.ToString();
                txtCiftCarpimSonucu.Text = carpimCift.ToString();

                txtTekToplamSonucu.Text = toplamTek.ToString();
                txtTekCarpimSonucu.Text = carpimTek.ToString();
            }

        }



        public Boolean AsalKontrol(int i) 
        {
            int kontrolDegiskeniAsal = 1;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    kontrolDegiskeniAsal = 0;
                    break;
                }
            }

            if (kontrolDegiskeniAsal == 1)
            {
                return true;
            }
            else  
                return false;  
        }



        int toplamAsal = 0, carpimAsal = 1;
        public void HesapAsal(int i, int bitisDegeri)
        {
            
                toplamAsal = toplamAsal + i;
                carpimAsal = carpimAsal * i;
            
           
               txtAsalToplamSonucu.Text = toplamAsal.ToString();
               txtAsalCarpimSonucu.Text = carpimAsal.ToString();
           
        }




        public Boolean MukemmelKontrol(int i, int toplam = 0) 
        {
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        {
                            toplam = toplam + j;
                        }
                    }
                }

                if (toplam == i)
                    return true;
                else
                    return false;
            }
        }

        int toplamMukemmel = 0, carpimMukemmel = 1;
        public void HesapMukemmel(int i, int bitisDegeri) {

            

            toplamMukemmel = toplamMukemmel + i;
            carpimMukemmel = carpimMukemmel * i;

            
                txtMukemmelToplamSonucu.Text = toplamMukemmel.ToString();
                txtMukemmelCarpimSonucu.Text = carpimMukemmel.ToString();
            
        }






        private void buton_Click(object sender, EventArgs e)
        {

            bool dogrulamaSonucu = Dogrula();

            int baslangicDegeri, bitisDegeri;

          
            //gerekli islemleri yapabilmek icin int türüne donusturdum.

            baslangicDegeri = Convert.ToInt32(txtBaslangicDegeri.Text);
            bitisDegeri = Convert.ToInt32(txtBitisDegeri.Text);


            //        [Tek Cift kontrolü]

            for (int i=baslangicDegeri ; i<=bitisDegeri ; i++)
            {
                bool tekCiftBool = TekCiftKontrol(i);

                if (tekCiftBool)
                {
                    listCiftSayilar.Items.Add(i.ToString()); //degisken degerini listView'e direk ekleyebiliriz.
                }
                else
                {
                    listTekSayilar.Items.Add(i.ToString());
                }

                HesapTekCift(i,bitisDegeri,tekCiftBool);

                EkraniAyarla();
            }
            



            //          [Asal Kontrol]
            for (int i = baslangicDegeri; i <= bitisDegeri; i++)
            {
                if (i == 1)
                {
                    i++;
                } //1 asal degildir.

                bool asalBool = AsalKontrol(i);

                if (asalBool)
                {
                    listAsalSayilar.Items.Add(i.ToString()); //degisken degerini listView'e direk ekleyebiliriz.
                    //!!! 1 degeri asal sayi tablosuna yazilmamali.
                    HesapAsal(i,bitisDegeri);
                }
                
            }



            //          [Mukemmel Kontrol]
            for (int i = baslangicDegeri; i < bitisDegeri; i++)
            {
                bool mukemmelBool=MukemmelKontrol(i);

                if (mukemmelBool)
                {
                    listMukemmelSayilar.Items.Add(i.ToString());
                    HesapMukemmel(i, bitisDegeri);
                }
            }

        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            EkraniAyarla();
        }


        private void txtBaslangicDegeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
            char.IsLetter(e.KeyChar) ||
            char.IsSymbol(e.KeyChar) ||
            char.IsWhiteSpace(e.KeyChar) ||
            char.IsPunctuation(e.KeyChar)
            )
                e.Handled = true;


        }

        private void txtBitisDegeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
            char.IsLetter(e.KeyChar) ||
            char.IsSymbol(e.KeyChar) ||
            char.IsWhiteSpace(e.KeyChar) ||
            char.IsPunctuation(e.KeyChar)
            )
                e.Handled = true;
        }





        //---------------------------------------------------------------------------------------------------------------------





        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCiftToplamSonucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCiftCarpimSonucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAsalToplamSonucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAsalCarpimSonucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMukemmelToplamSonucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void txtBitisDegeri_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
 
        }


    }
}
