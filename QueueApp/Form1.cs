using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueApp
{
    public partial class Form1 : Form
    {

        Queue<string> queuesData = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnque_Click(object sender, EventArgs e)
        {
           
            string enqu = txtWrite.Text;
            queuesData.Enqueue(txtWrite.Text);

            txtWrite.Text = "";
            TxtDeque.Text = " ";

            foreach (String element in queuesData)
            {

                TxtDeque.AppendText(element + " ");
            }
            TxtDeque.Text = string.Join(" ", TxtDeque.Text.Split(' ').Reverse());

        }

        private void TxtDeque_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            foreach (String element in queuesData)
            {
   
                TxtDeque.AppendText(element + " ");   
            }
            TxtDeque.Text = string.Join(" ", TxtDeque.Text.Split(' ').Reverse()); 
        }

        private void btndeque_Click(object sender, EventArgs e)
        {
            txtWrite.Text = "";
            string str = TxtDeque.Text;
            string strTrimmed = str.Trim();
            queuesData.Dequeue();

            //TxtDeque.Text = strTrimmed.Substring(strTrimmed.LastIndexOf(" ", strTrimmed.Length));
            //TxtDeque.Text = TxtDeque.Text.Substring(0, TxtDeque.Text.LastIndexOf(" "));

           TxtDeque.Text = strTrimmed.Substring(0, strTrimmed.LastIndexOf(" ") < 0 ? 0 : strTrimmed.LastIndexOf(" "));

            //foreach (var elem in queuesData)
            //{
            //    txtWrite.Text = elem;
            //    lst1.Items.Add(elem);
            //}
        }
    }
}
