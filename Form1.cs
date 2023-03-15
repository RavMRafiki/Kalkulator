using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private static readonly char[] znaki = new char[] {'-', '+', '*', '/', '='};
        private static readonly string separator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
        private List<double> listNumbers = new List<double>();
        private List<string> listSigns = new List<string>();
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
            FixDecimal(sender, e);
            Button btn = sender as Button;
            if (obliczenia.Text.Length > 0)
            {
                if (btn.Text == "-" && obliczenia.Text[obliczenia.Text.Length - 1] != null && obliczenia.Text[obliczenia.Text.Length - 1] == '-')
                {
                    if (obliczenia.Text.Length > 1 && !IsSign(obliczenia.Text[obliczenia.Text.Length - 2]))
                    {
                        Delete1(sender, e);
                        obliczenia.Text += '+';
                    }
                    else
                    {
                        Delete1(sender, e);
                    }
                }
                else if (btn.Text == "-" && obliczenia.Text[obliczenia.Text.Length - 1] != null && IsSign(obliczenia.Text[obliczenia.Text.Length - 1]))
                {
                    obliczenia.Text += btn.Text;
                }
                else
                {
                    if (IsSign(obliczenia.Text[obliczenia.Text.Length - 1]))
                    {
                        Delete1(sender, e);
                    }
                    if (obliczenia.Text.Length > 0 && IsSign(obliczenia.Text[obliczenia.Text.Length - 1]))
                    {
                        Delete1(sender, e);
                    }
                    obliczenia.Text += btn.Text;
                }
            }
            else if (btn.Text == "-" && obliczenia.Text.Length == 0)
            {
                obliczenia.Text += btn.Text;
            }
            if (obliczenia.Text.Length > 0 && IsSign(obliczenia.Text[0]) && obliczenia.Text[0] != '-')
            {
                obliczenia.Text = "";
            }
        }

        private void AddComma(object sender, EventArgs e)
        {
            if (!IsCommaSinceSign(sender, e))
                {
                    obliczenia.Text += separator;
                }
        }
        private bool IsCommaSinceSign(object sender, EventArgs e)
        {
            for (int i = obliczenia.Text.Length - 1; i >= 0; i--)
            {
                if (IsSign(obliczenia.Text[i]))
                {
                    return false;
                }
                if (obliczenia.Text[i].ToString() == separator)
                {
                    return true;
                }
            }
            return false;
        }
        private void FixDecimal(object sender, EventArgs e )
        {
            if (obliczenia.Text.Length > 0)
            {
                if (IsCommaSinceSign(sender, e))
                {
                    for (int i = obliczenia.Text.Length - 1; i > 0; i--)
                    {
                        if(obliczenia.Text[i].ToString() == separator && IsSign(obliczenia.Text[i - 1]))
                            {
                            obliczenia.Text = obliczenia.Text.Substring(0, i) + "0" + obliczenia.Text.Substring(i, obliczenia.Text.Length - i);
                        }

                    }
                    if(obliczenia.Text[0].ToString() == separator)
                    {
                        obliczenia.Text = "0" + obliczenia.Text;
                    }
                }
                if (obliczenia.Text[obliczenia.Text.Length-1].ToString() == separator)
                {
                    Delete1(sender, e);
                }
            }
        }

        private void Calculate(object sender, EventArgs e)
        {
            AddSign(sender, e);
            int i = 0;
            double doDodania = 0;

            for (int j = 0; j < obliczenia.Text.Length; j++)
            {
                if (IsSign(obliczenia.Text[j]))
                {
                    if (Double.TryParse(obliczenia.Text.Substring(i, j - i), out doDodania))
                    {
                        listNumbers.Add(doDodania/*Convert.ToDouble(obliczenia.Text.Substring(i+1, j - i))*/);
                        listSigns.Add(obliczenia.Text.Substring(j, 1));
                        i = j+1;
                        j++;
                    }
                }
            }
            obliczenia.Text = listSigns.Count().ToString()+ listNumbers.Count().ToString();
        }
    }
}
