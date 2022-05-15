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


        public Form1()
        {
            InitializeComponent();

        }
       

        private void buttonPUSH_Click(object sender, EventArgs e)
        {
            Stack st = new Stack();
            st.Push(Number_Entry.Value);

            textBoxStack.Text = st.ToString();
        }

        private void buttonPOP_Click(object sender, EventArgs e)
        {
            Stack st = new Stack();
            st.Pop();
           
            }
        }
    }
}
