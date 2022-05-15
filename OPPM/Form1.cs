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
// parts of code modifired from tutorial
// https://www.youtube.com/watch?v=VVv1neQpuLw C# Stack Form (4) 完整解說

namespace OPPM
{


    public partial class Form1 : Form
    {

class Stack
        {
            public int[] arrayData;
            public int TOP;

            public Stack(int n)
            {
                arrayData = new int[n];
                TOP = 0;
            }
            public void Push(int ss)
            {
                if (TOP == arrayData.Length)
                {
                    MessageBox.Show("Stack Full");
                    return;
                }
                arrayData[TOP] = ss;
                TOP += 1;
            }
            public int Pop()
            {
                if (TOP ==0)
                {
                    MessageBox.Show("Empty Stack");
                    return arrayData[TOP];
                }
                else
                {
                    TOP -= 1;
                    return arrayData[TOP];
                }
              
            }
            public int Peek()
            {
                if (TOP == 0)
                {
                    MessageBox.Show("Empty Stack");
                    return arrayData[TOP];
                }
                else
                {
                    return arrayData[TOP - 1];
                }
         
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
            textBoxPush.Visible = false;
            labelStartUpChoose.Visible = true;
            labelPeek.Visible = false;
            labelPop.Visible = false;
        }
       

        private void buttonPUSH_Click(object sender, EventArgs e)
        {
            try
            {
                s1.Push(int.Parse(textBoxPush.Text));
                PrintStack();
            }
            catch
            {
                MessageBox.Show("Numbers Only");
            }

        }

        private void buttonPOP_Click(object sender, EventArgs e)
        {
            labelPop.Text = s1.Pop() + " Poped";
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
            textBoxPush.Visible = true;
            labelStartUpChoose.Visible = false;
            labelPeek.Visible = true;
            labelPop.Visible = true;
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
            labelPeek.Text = s1.Peek() + " Peek";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

