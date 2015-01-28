using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int j=Charcount(textBox1.Text);
            MessageBox.Show(j.ToString());*/
            string [] ArrayofNumbers = textBox1.Text.Split(',');
            int[] Arrays={2,3,4};
            int i=AverageOfNumbers(Arrays);
            MessageBox.Show(i.ToString());
        }

        public int AverageOfNumbers(int[] Numbers)
        {
            int Average;
            int Sum = 0;
            int TotalNumbers=0;
            /*for (int i = 0; i < Numbers.Length; i++)
            {
                Sum = Sum + Numbers[i];
                TotalNumbers++;
                
            }*/
            foreach (int N in Numbers)
            {
                Sum = Sum + N;
                TotalNumbers++;

            }
            Average = Sum / TotalNumbers;
            return Average;

        }


        public int Charcount(string WORD)
        {
            int counter = 0;
            /*for (int i = 0; i < WORD.Length; i++)
            {
                if(WORD[i]=='a' || WORD[i]=='A')
                counter++;
            }*/
            foreach (char Ch in WORD)
            {
                if (Ch == 'a' || Ch == 'A')
                {
                    counter++;
                }
            }

            return counter;

        }
    }
}
