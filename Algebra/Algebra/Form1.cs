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
        /*to do: 
        create button for negative numbers, move equals button to bottom
        add clear and clear error buttons    
        add overflow exceptions, "what are you counting, ''?", add PROPER error messages
        fix exception catching
        add order of operations toggle
        */


        //variables
        string LastOperator; //the last operator that was inputted
        decimal LastNumber;
        decimal Output;

        int OperationCounter = 0; //counts the number of operations done
        int LastOperation; //for use in a "for" loop

        decimal[] Numbers = new decimal[16]; //maximum of 16 operations
        string[] Operators = new string[16];

        public Form1()
        {
            InitializeComponent();

            //create event handlers for the buttons, manual for now
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
            StoreInput();
            textBox2.AppendText(LastNumber + "\r\n" + LastOperator + "\r\n");
        }

        private void StoreInput()
        {
            try
            {
                LastNumber = decimal.Parse(textBox1.Text);
            }

            catch (Exception ParseFail)
            {
                if (ParseFail is OverflowException)
                {
                    MessageBox.Show("Use a smaller number you dingus!");
                }
            }


            textBox1.Text = ("");
            Numbers[OperationCounter] = LastNumber;
            Operators[OperationCounter] = LastOperator;
            OperationCounter++;
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {

            textBox1.AppendText((sender as Button).Text);
        }


        private void button12_Click(object sender, EventArgs e) //this is the equals button
        {
            StoreInput();
            for (LastOperation = 0; LastOperation + 1 < OperationCounter; LastOperation++)
            {
                if (Operators[LastOperation] == "+")
                { Output = Numbers[LastOperation] + Numbers[LastOperation + 1]; }
                else if (Operators[LastOperation] == "-")
                { Output = Numbers[LastOperation] - Numbers[LastOperation + 1]; }
                else if (Operators[LastOperation] == "*")
                { Output = Numbers[LastOperation] * Numbers[LastOperation + 1]; }
                else if (Operators[LastOperation] == "/")
                { Output = Numbers[LastOperation] / Numbers[LastOperation + 1]; }

            }
            textBox1.Text = Output.ToString();
        }

    }
}
