using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Kral Arthur");
            comboBox2.Items.Add("Old Boy");
           
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            choseFilimcs fr2 = new choseFilimcs();
            fr2.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
