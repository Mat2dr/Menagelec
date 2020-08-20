using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menagelec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '•';

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "fournier" && textBox2.Text == "1234") || (textBox1.Text == "hurier" && textBox2.Text == "5678"))
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Identification incorrecte, veuillez réessayer");
            }
            
        }
    }
}
