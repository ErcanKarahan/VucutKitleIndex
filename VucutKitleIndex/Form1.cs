using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vki, kilo, boy;
            boy = Convert.ToDouble(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);
            vki = kilo / (boy * boy);
            lblVkiSonuc.Text = vki.ToString("0.00");

            if (vki<=18)
            {
                lblDurumSonuc.Text = "Zayıf";
            }
            else if (vki >=18 && vki<25)
            {
                lblDurumSonuc.Text = "Normal";
            }
            else if (vki>=25 && vki<30)
            {
                lblDurumSonuc.Text = "Kilolu";
            }
            else if (vki >=30 && vki <35)
            {
                lblDurumSonuc.Text = "Obez";
            }
            else
            {
                lblDurumSonuc.Text = "Ciddi Obez";

            }

        }
    }
}
