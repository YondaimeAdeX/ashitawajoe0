using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ashitawajoe0
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

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        OkulEntities okul = new OkulEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler og = new Ogrenciler();
            og.adi = txtadi.Text;
            og.sinifi = txtsinifi.Text;
            og.no = txtno.Text;
            okul.Ogrenciler.Add(og);
            okul.SaveChanges();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogretmenler og = new Ogretmenler();
            og.adi = txtogAdi.Text;
            og.bransi = txtbransi.Text;
            okul.Ogretmenler.Add(og);
            okul.SaveChanges();
        }
    }
}
