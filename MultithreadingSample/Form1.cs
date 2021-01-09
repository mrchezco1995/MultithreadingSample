//Multithreading Example
//This is a VERY BASIC implementation of Multithreading in C#

using System;
using System.Windows.Forms;
using System.Threading; //call the Threading 

namespace MultithreadingSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Normally, you do this...
            msg1();
            msg2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //but in multithreading...
            //create a new thread class
            Thread t1 = new Thread(msg1);
            Thread t2 = new Thread(msg2);

            //Then we spawn them...
            t1.Start();
            t2.Start();
        }

        private void msg1()
        {
            MessageBox.Show("Hello World!");
        }

        private void msg2()
        {
            MessageBox.Show("Hi Person!");
        }

        
    }
}
