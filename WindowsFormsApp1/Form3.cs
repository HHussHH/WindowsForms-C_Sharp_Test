using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Тест : Form
    {
        public Тест()
        {
            InitializeComponent();
        }
       

      
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Критерии:\r\n18-20 баллов = 5\r\n17-15 баллов = 4\r\n14-10 баллов = 3\r\n 9-0 баллов = 2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание!\r\nВ ходе работы программы вы можете столкнуться с багами\r\nЭто вполне возможно)\r\nОбратитесь к этому человеку,если обнаружите баг:\r\nhttps://vk.com/top_sportorg");
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание!\r\nВ ходе работы программы вы можете столкнуться с багами\r\nЭто вполне возможно)\r\nОбратитесь к этому человеку,если обнаружите баг:\r\nhttps://vk.com/top_sportorg");
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание!\r\nВ ходе работы программы вы можете столкнуться с багами\r\nЭто вполне возможно)\r\nОбратитесь к этому человеку,если обнаружите баг:\r\nhttps://vk.com/top_sportorg");
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание!\r\nВ ходе работы программы вы можете столкнуться с багами\r\nЭто вполне возможно)\r\nОбратитесь к этому человеку,если обнаружите баг:\r\nhttps://vk.com/top_sportorg");
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }
      

        
    }
}
