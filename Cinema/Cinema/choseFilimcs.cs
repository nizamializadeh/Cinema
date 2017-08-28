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
    public partial class choseFilimcs : Form
    {
      
       
  

        public choseFilimcs()
        {
            InitializeComponent();
        }
        private void yer(object sender, EventArgs e)
        {
          
            Button b = (Button)sender;
            if (b.BackColor == Color.Red)
            {
                MessageBox.Show("bu yer artiq secilib");
            }
            else
	        {
                textBox1.Text += b.Text + ",";
                
            }
            b.BackColor = Color.Red;

        


          
        }
        private void button7_Click(object sender, EventArgs e)
        {
          
           
            MessageBox.Show(textBox1.Text+"Nomreli yerler alindi");
            
            



        }
        private void choseFilimcs_Load(object sender, EventArgs e)
        {

        }
        private void button14_Click(object sender, EventArgs e)
        {
            choseFilimcs.ActiveForm.Hide();
            Form1 fr2 = new Form1();
            fr2.Show();
        }
    }
}
