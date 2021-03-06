﻿using System;
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
        add clear and clear error buttons    
        add overflow exceptions, "what are you counting, ''?", add PROPER error messages
        fix exception catching
        add functioality to order of operations toggle
        fix calculations with > 2 steps
        */


        //variables
        string LastOperator; //the last operator that was inputted
        decimal LastNumber;
        decimal Output;

        bool positive = true; //used for toggling the negative button

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
            StoreNumber();
            textBox2.AppendText(LastOperator + "\r\n");
            StoreOperator();
        }


        private void NumberButtonClick(object sender, EventArgs e)
        {

            textBox1.AppendText((sender as Button).Text);
        }


        private void button12_Click(object sender, EventArgs e) //this is the equals button
        {
            StoreNumber();
            Calculate();
            textBox1.Text = Output.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            NegativeInput();
        }


        private void StoreOperator()
        {
            textBox1.Text = ("");
            Operators[OperationCounter] = LastOperator;
            OperationCounter++;
        }


        private void StoreNumber()
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

            Numbers[OperationCounter] = LastNumber;
            textBox2.AppendText(LastNumber + "\r\n");
        }


        public void Calculate()
        {
            for (LastOperation = 0; LastOperation < OperationCounter; LastOperation++)
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
        }


        public bool NegativeInput()
        {
            if (positive)
            {
                textBox1.Text = "-" + textBox1.Text;
                positive = false;
            }
            else if (positive != true)
            {
                textBox1.Text = textBox1.Text.TrimStart("-".ToCharArray());
                positive = true;
            }
            return positive;
        }
    }
}
