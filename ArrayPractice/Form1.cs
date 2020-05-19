using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int[] num = { 8, 9, 5, 6, 2, 8, 4 };
            lblOutput1.Text = "First element is " + num[0];
            lblOutput2.Text = "Fifth element is " + num[4];

            int total = 0;
            for (int i = 0; i < num.Length; i++)
            {
                total = total + num[i];
            }
            int aftertotal;
            aftertotal = total * 2;
            lblTotalNum.Text = "Total is " + aftertotal;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            string[] fruit = { "Banana", "apple", "pear", "orange", "kiwi fruit" };
            fruit[1] = "strawberry";
            // changes the second element // 
            lblFruit.Text = "Second element is " + fruit[1];

            int numOfFruit;
            numOfFruit = fruit.Length;            lblTotalFruit.Text = "Total fruit is " + numOfFruit;
            //Adding all element//
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
