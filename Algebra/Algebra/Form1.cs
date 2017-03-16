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

        //variables
        string LastOperator; //the last operator that was inputted

        int OperationCounter = 0; //counts the number of operations done

        decimal[] Operations = new decimal[16];
        string[] Operators = new string[16];

        public Form1()
        {
            InitializeComponent();

            //create event handlers for the buttons; redundant for now
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
            // button12.Click += new EventHandler(OperatorButtonClick);   // This button has its own event handler due to its unique function: it's the equals button
            button13.Click += new EventHandler(OperatorButtonClick);
            button14.Click += new EventHandler(OperatorButtonClick);
            button15.Click += new EventHandler(OperatorButtonClick);
            button16.Click += new EventHandler(OperatorButtonClick);

        }




        private void OperatorButtonClick(object sender, EventArgs e)
        {
            LastOperator = (sender as Button).Text;

            textBox2.AppendText(textBox1.Text + "\r \n");

            textBox1.Text = (LastOperator);

          //  Operations[OperationCounter] = textBox1.Text;
            
            OperationCounter++;

        }

        private void NumberButtonClick(object sender, EventArgs e)
        {

            textBox1.AppendText((sender as Button).Text);
        }


        private void button12_Click(object sender, EventArgs e) //this is the equals button
        {

        }

    }
}
