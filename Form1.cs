using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private static readonly char[] znaki = new char[] {'-', '+', '*', '/', '='}; 
        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            obliczenia.Text += btn.Text;
        }

        private void Delete1(object sender, EventArgs e)
        {
            if (obliczenia.Text.Length > 0)
            {
                obliczenia.Text = obliczenia.Text.Substring(0, obliczenia.Text.Length - 1);
            }
        }

        private void DeleteAll(object sender, EventArgs e)
        {
            obliczenia.Text = "";
        }

        private void DeleteLine(object sender, EventArgs e)
        {
            for(int i = obliczenia.Text.Length-1; i >=0 ; i--)
            {
                if (IsSign(obliczenia.Text[i]))
                {
                    return;
                }
                Delete1(sender, e);
            }
        }
        private bool IsSign(char _str)
        {
            for(int i = 0;i<znaki.Length;i++)
                if (znaki[i] == _str)
                {
                    return true;
                }
            return false;
        }

        private void AddSign(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "-"){
                obliczenia.Text += btn.Text;
            }
            if (obliczenia.Text.Length > 0)
            {
                if (IsSign(obliczenia.Text[obliczenia.Text.Length - 1]) && !(obliczenia.Text[obliczenia.Text.Length - 1] == '-'))
                {
                    Delete1(sender, e);
                }
            }
            obliczenia.Text += btn.Text;
        }
    }
}
