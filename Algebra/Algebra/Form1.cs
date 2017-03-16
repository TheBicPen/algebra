using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algebra
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();

            //create event handlers for the buttons; I wonder if there is some way to automate this...
            button1.Click += new EventHandler(NumberButtonClick);
            button2.Click += new EventHandler(NumberButtonClick);
            button3.Click += new EventHandler(NumberButtonClick);
            button4.Click += new EventHandler(NumberButtonClick);
            button5.Click += new EventHandler(NumberButtonClick);
            button6.Click += new EventHandler(NumberButtonClick);
            button7.Click += new EventHandler(NumberButtonClick);
            button8.Click += new EventHandler(NumberButtonClick);
            button9.Click += new EventHandler(NumberButtonClick);
            button10.Click += new EventHandler(NumberButtonClick);
            button11.Click += new EventHandler(NumberButtonClick);
            // button12.Click += new EventHandler(OperatorButtonClick);   // This button has its own event handler due to its unique function
            button13.Click += new EventHandler(OperatorButtonClick);
            button16.Click += new EventHandler(OperatorButtonClick);
            button15.Click += new EventHandler(OperatorButtonClick);
            button14.Click += new EventHandler(OperatorButtonClick);

        }

        private void OperatorButtonClick(object sender, EventArgs e)
        {
            textBox1.AppendText("\n" + (sender as Button).Text);
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {

            textBox1.AppendText((sender as Button).Text);
        }


        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
