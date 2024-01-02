using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dogumGun = new DateTime (2024,9, 22);
            DateTime bugun= DateTime.Today;
            TimeSpan kalanSure = dogumGun - bugun;
            int kalanAy = kalanSure.Days;
            label1.Text= "Kalan Gün:"+kalanAy.ToString();
        }
    }
}
