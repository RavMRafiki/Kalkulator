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
        private static readonly char[] signsFirst = new char[] { '+', '-' };
        private static readonly char[] signsSecond = new char[] { '*', '/' };
        private static bool hasFail = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber(object sender, EventArgs e)
        {
            if (hasFail)
            {
                DeleteAll(sender, e);
                hasFail = false;
            }
            Button btn = sender as Button;
            obliczenia.Text += btn.Text;
        }

        private void Delete1(object sender, EventArgs e)
        {
            if (hasFail)
            {
                DeleteAll(sender, e);
                hasFail = false;
            }
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
            if (hasFail)
            {
                DeleteAll(sender,e);
                hasFail = false;
            }
            for (int i = obliczenia.Text.Length-1; i >=0 ; i--)
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
            if (hasFail)
            {
                DeleteAll(sender, e);
                hasFail = false;
            }
            FixDecimal(sender, e);
            Button btn = sender as Button;
            if (obliczenia.Text.Length > 0)
            {
                if (btn.Text == "-" && obliczenia.Text[obliczenia.Text.Length - 1] == '-')
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
                else if (btn.Text == "-" && IsSign(obliczenia.Text[obliczenia.Text.Length - 1]))
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
            if (obliczenia.Text.Length > 0 && obliczenia.Text[0] == '-')
            {
                FixMinusZero();
            }
        }

        private void AddComma(object sender, EventArgs e)
        {
            if (hasFail)
            {
                DeleteAll(sender, e);
                hasFail = false;
            }
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
            if (!ContainsEquationSign())
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
                            listNumbers.Add(doDodania);
                            listSigns.Add(obliczenia.Text.Substring(j, 1));
                            i = j + 1;
                            j++;
                        }
                    }
                }
                MakeCalculations(sender, e);
                if (!hasFail && obliczenia.Text.Length>0)
                {
                    obliczenia.Text += listNumbers[0].ToString();
                    History.Items.Add(obliczenia.Text);
                }
                listNumbers.Clear();
                listSigns.Clear();
            } 
            else
            {
                obliczenia.Text = obliczenia.Text.Substring(ContainsEquationSignOn()+1);
            }
            
        }
        private bool ContainsEquationSign()
        {
            if (obliczenia.Text.Length >= 0)
            {
                for (int i = obliczenia.Text.Length - 1; i >= 0; i--)
                {
                    if (obliczenia.Text[i] == '=')
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private int ContainsEquationSignOn()
        {
            if (obliczenia.Text.Length >= 0)
            {
                for (int i = obliczenia.Text.Length - 1; i >= 0; i--)
                {
                    if (obliczenia.Text[i] == '=')
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private void MakeCalculations(object sender, EventArgs e)
        {
            for (int i = 0; i < listSigns.Count - 1; i++)
            {
                if (listSigns[i] == "*")
                {
                    listSigns.RemoveAt(i);
                    listNumbers[i] = listNumbers[i] * listNumbers[i + 1];
                    listNumbers.RemoveAt(i + 1);
                    i--;
                }
                else if (listSigns[i] == "/")
                {
                    if (listNumbers[i + 1] == 0)
                    {
                        hasFail = true;
                        obliczenia.Text += "Error";
                        return;
                    }
                    listSigns.RemoveAt(i);
                    listNumbers[i] = listNumbers[i] / listNumbers[i + 1];
                    listNumbers.RemoveAt(i + 1);
                    i--;

                }
            }
            for (int i = 0; i < listSigns.Count - 1; i++)
            {
                if (listSigns[i] == "+")
                {
                    listSigns.RemoveAt(i);
                    listNumbers[i] = listNumbers[i] + listNumbers[i + 1];
                    listNumbers.RemoveAt(i + 1);
                    i--;
                }
                else if (listSigns[i] == "-")
                {
                    listSigns.RemoveAt(i);
                    listNumbers[i] = listNumbers[i] - listNumbers[i + 1];
                    listNumbers.RemoveAt(i + 1);
                    i--;

                }
            }
        }
        private void FixMinusZero()
        {
            double zero = 1;
            for (int j = 1; j < obliczenia.Text.Length; j++)
            {
                if (IsSign(obliczenia.Text[j]))
                {
                    if (Double.TryParse(obliczenia.Text.Substring(0, j), out zero))
                    {
                        if (zero == 0)
                        {
                            obliczenia.Text = obliczenia.Text.Substring(1, obliczenia.Text.Length - 1);
                        }
                    }
                    
                }
                if (j == obliczenia.Text.Length - 1)
                {
                    if (Double.TryParse(obliczenia.Text.Substring(0, j), out zero))
                    {
                        if (zero == 0)
                        {
                            obliczenia.Text = obliczenia.Text.Substring(1, obliczenia.Text.Length - 1);
                        }
                    }
                }
            }
        }

    }
}
