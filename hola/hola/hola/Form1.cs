using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hola
{
    public partial class PRUEBA : Form
    {
        public PRUEBA()
        {
            InitializeComponent();
        }

        public bool contenido = true;
    

        private void button1_Click(object sender, EventArgs e)
        {
            
          textBox1.Text = "HOLA MUNDO";
           textBox2.Text = contenido.ToString();

           int[] myint = { 5, 10, 15, 56, 567 };
           string p = " ";

           foreach (int i in myint)
           {
               p = p + Convert.ToString(i) + ",";
           }
           textBox3.Text = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

     

        private void textBox1_TextChanged(object sender, EventArgs e){

        }

        
           }
}