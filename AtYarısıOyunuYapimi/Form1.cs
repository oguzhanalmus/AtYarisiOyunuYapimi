using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarısıOyunuYapimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;
            int bitisuzakligi = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5,15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5) 
            {
                label6.Text = "1 Numaralı at yarışı önde götürüyor";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 Numaralı at yarışı önde götürüyor";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3 Numaralı at yarışı önde götürüyor";
            }

            if (birinciatingenisligi + pictureBox1.Left >= bitisuzakligi) 
            { 
                timer1.Enabled=false;
                MessageBox.Show("1 Numaralı at yarışı kazandı");
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı at yarışı kazandı");
            }
            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı at yarışı kazandı");
            }
        }

       
    }
}
