using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RadioApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowsMP.URL = "https://vofile.ru/turkey/radyo_2000_fm_istanbul/icecast";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowsMP.URL = "https://stream2.rtvtakip.com:7000/stream?icy=http";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsMP.URL = "https://wowza1.radyotvonline.com/unitedmedia/karade";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsMP.URL = "https://stream.34bit.net/ar.opus";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowsMP.URL = "http://2.59.117.43:2020/;stream.mp3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowsMP.URL = "http://46.20.7.126/;stream.mp3";
        }

        
        }
    }

