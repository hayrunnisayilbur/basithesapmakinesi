﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basithesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtsayi1_TextChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            double sonuc;

            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            sonuc = sayi1 * sayi2;

            lblSonuc.Text = sonuc.ToString();
            
            

            
            
            
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            double sonuc;

            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            sonuc = sayi1 * sayi2;

            lblSonuc.Text = sonuc.ToString();


        }
    }
}
