using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPPM
{


    public partial class Form1 : Form
    {

class Stack
        {
            public string[] arrayData;
            public int TOP;

            public Stack(int n)
            {
                arrayData = new string[n];
                TOP = 0;
            }
            public void Push(string ss)
            {
                if (TOP == arrayData.Length)
                {
                    MessageBox.Show("testing");
                    return;
                }
                arrayData[TOP] = ss;
                TOP += 1;
            }
            public string Pop()
            {
                if (TOP ==0)
                {
                    MessageBox.Show("Empty Stack");
                    return "";
                }
                TOP -= 1;
                return arrayData[TOP];
            }
            public string Peek()
            {
                if (TOP == 0)
                {
                    MessageBox.Show("Empty Stack");
                    return "";
                }
                TOP -= 1;
                return arrayData[TOP];
            }

        }
        Stack s1;
        public Form1()
        {
            InitializeComponent();
            textBoxStack.Visible = false;
            buttonPUSH.Visible = false;
            buttonPOP.Visible = false;
            buttonPEEK.Visible = false;
            buttonCLEAR.Visible = false;
            textBoxPush.Visible = false;
            labelStartUpChoose.Visible = true;
        }
       

        private void buttonPUSH_Click(object sender, EventArgs e)
        {
            s1.Push(textBoxPush.Text);
            PrintStack();

        }

        private void buttonPOP_Click(object sender, EventArgs e)
        {
            labelPop.Text = s1.Pop();
            PrintStack();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                s1 = new Stack(num);
            
            PrintStack();
            textBoxStack.Visible = true;
            buttonPUSH.Visible = true;
            buttonPOP.Visible = true;
            buttonPEEK.Visible = true;
            buttonCLEAR.Visible = true;
            textBoxPush.Visible = true;
            labelStartUpChoose.Visible = false;
            }
            catch
            {
                MessageBox.Show("Only Numbers");
            }

        }
        public void PrintStack()
        {
            textBoxStack.Text = "--bottom--";
            if (s1.TOP == 0)
            {
                MessageBox.Show("Stack Empty Ready for Values");
                return;

            }
            for (int i = 0; i < s1.TOP; i++)
            {
                textBoxStack.Text = s1.arrayData[i] + "\r\n" + textBoxStack.Text; 
            }
        }

        private void buttonPEEK_Click(object sender, EventArgs e)
        {
            labelPeek.Text = s1.Peek();
            
        }
    }
    }

