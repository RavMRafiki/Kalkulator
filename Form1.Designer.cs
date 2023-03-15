
namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.signComma = new System.Windows.Forms.Button();
            this.signPlus = new System.Windows.Forms.Button();
            this.signMinus = new System.Windows.Forms.Button();
            this.signRazy = new System.Windows.Forms.Button();
            this.signPodzielić = new System.Windows.Forms.Button();
            this.delCE = new System.Windows.Forms.Button();
            this.delC = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.obliczenia = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.White;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number1.Location = new System.Drawing.Point(16, 273);
            this.number1.Margin = new System.Windows.Forms.Padding(4);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(133, 86);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.addNumber);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.White;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number2.Location = new System.Drawing.Point(157, 273);
            this.number2.Margin = new System.Windows.Forms.Padding(4);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(133, 86);
            this.number2.TabIndex = 1;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.addNumber);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.White;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number3.Location = new System.Drawing.Point(299, 273);
            this.number3.Margin = new System.Windows.Forms.Padding(4);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(133, 86);
            this.number3.TabIndex = 2;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.addNumber);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.White;
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number4.Location = new System.Drawing.Point(16, 367);
            this.number4.Margin = new System.Windows.Forms.Padding(4);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(133, 86);
            this.number4.TabIndex = 3;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.addNumber);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.Color.White;
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number5.Location = new System.Drawing.Point(157, 367);
            this.number5.Margin = new System.Windows.Forms.Padding(4);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(133, 86);
            this.number5.TabIndex = 4;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.addNumber);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.Color.White;
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number6.Location = new System.Drawing.Point(299, 367);
            this.number6.Margin = new System.Windows.Forms.Padding(4);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(133, 86);
            this.number6.TabIndex = 5;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.Click += new System.EventHandler(this.addNumber);
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.Color.White;
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number7.Location = new System.Drawing.Point(16, 460);
            this.number7.Margin = new System.Windows.Forms.Padding(4);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(133, 86);
            this.number7.TabIndex = 6;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            this.number7.Click += new System.EventHandler(this.addNumber);
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.Color.White;
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number8.Location = new System.Drawing.Point(157, 460);
            this.number8.Margin = new System.Windows.Forms.Padding(4);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(133, 86);
            this.number8.TabIndex = 7;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            this.number8.Click += new System.EventHandler(this.addNumber);
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.Color.White;
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number9.Location = new System.Drawing.Point(299, 460);
            this.number9.Margin = new System.Windows.Forms.Padding(4);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(133, 86);
            this.number9.TabIndex = 8;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            this.number9.Click += new System.EventHandler(this.addNumber);
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.Color.White;
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.number0.Location = new System.Drawing.Point(16, 554);
            this.number0.Margin = new System.Windows.Forms.Padding(4);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(275, 86);
            this.number0.TabIndex = 9;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            this.number0.Click += new System.EventHandler(this.addNumber);
            // 
            // signComma
            // 
            this.signComma.BackColor = System.Drawing.Color.White;
            this.signComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signComma.Location = new System.Drawing.Point(299, 554);
            this.signComma.Margin = new System.Windows.Forms.Padding(4);
            this.signComma.Name = "signComma";
            this.signComma.Size = new System.Drawing.Size(133, 86);
            this.signComma.TabIndex = 10;
            this.signComma.Text = ",";
            this.signComma.UseVisualStyleBackColor = false;
            // 
            // signPlus
            // 
            this.signPlus.BackColor = System.Drawing.Color.White;
            this.signPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signPlus.Location = new System.Drawing.Point(16, 180);
            this.signPlus.Margin = new System.Windows.Forms.Padding(4);
            this.signPlus.Name = "signPlus";
            this.signPlus.Size = new System.Drawing.Size(133, 86);
            this.signPlus.TabIndex = 11;
            this.signPlus.Text = "+";
            this.signPlus.UseVisualStyleBackColor = false;
            this.signPlus.Click += new System.EventHandler(this.AddSign);
            // 
            // signMinus
            // 
            this.signMinus.BackColor = System.Drawing.Color.White;
            this.signMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signMinus.Location = new System.Drawing.Point(157, 180);
            this.signMinus.Margin = new System.Windows.Forms.Padding(4);
            this.signMinus.Name = "signMinus";
            this.signMinus.Size = new System.Drawing.Size(133, 86);
            this.signMinus.TabIndex = 12;
            this.signMinus.Text = "-";
            this.signMinus.UseVisualStyleBackColor = false;
            this.signMinus.Click += new System.EventHandler(this.AddSign);
            // 
            // signRazy
            // 
            this.signRazy.BackColor = System.Drawing.Color.White;
            this.signRazy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signRazy.Location = new System.Drawing.Point(299, 180);
            this.signRazy.Margin = new System.Windows.Forms.Padding(4);
            this.signRazy.Name = "signRazy";
            this.signRazy.Size = new System.Drawing.Size(133, 86);
            this.signRazy.TabIndex = 13;
            this.signRazy.Text = "*";
            this.signRazy.UseVisualStyleBackColor = false;
            this.signRazy.Click += new System.EventHandler(this.AddSign);
            // 
            // signPodzielić
            // 
            this.signPodzielić.BackColor = System.Drawing.Color.White;
            this.signPodzielić.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signPodzielić.Location = new System.Drawing.Point(440, 180);
            this.signPodzielić.Margin = new System.Windows.Forms.Padding(4);
            this.signPodzielić.Name = "signPodzielić";
            this.signPodzielić.Size = new System.Drawing.Size(133, 86);
            this.signPodzielić.TabIndex = 14;
            this.signPodzielić.Text = "/";
            this.signPodzielić.UseVisualStyleBackColor = false;
            this.signPodzielić.Click += new System.EventHandler(this.AddSign);
            // 
            // delCE
            // 
            this.delCE.BackColor = System.Drawing.Color.White;
            this.delCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.delCE.Location = new System.Drawing.Point(440, 273);
            this.delCE.Margin = new System.Windows.Forms.Padding(4);
            this.delCE.Name = "delCE";
            this.delCE.Size = new System.Drawing.Size(133, 86);
            this.delCE.TabIndex = 15;
            this.delCE.Text = "CE";
            this.delCE.UseVisualStyleBackColor = false;
            this.delCE.Click += new System.EventHandler(this.DeleteLine);
            // 
            // delC
            // 
            this.delC.BackColor = System.Drawing.Color.White;
            this.delC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.delC.Location = new System.Drawing.Point(440, 367);
            this.delC.Margin = new System.Windows.Forms.Padding(4);
            this.delC.Name = "delC";
            this.delC.Size = new System.Drawing.Size(133, 86);
            this.delC.TabIndex = 16;
            this.delC.Text = "C";
            this.delC.UseVisualStyleBackColor = false;
            this.delC.Click += new System.EventHandler(this.DeleteAll);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.White;
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.del.Location = new System.Drawing.Point(440, 460);
            this.del.Margin = new System.Windows.Forms.Padding(4);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(133, 86);
            this.del.TabIndex = 17;
            this.del.Text = "</x/";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.Delete1);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.White;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sum.Location = new System.Drawing.Point(440, 554);
            this.sum.Margin = new System.Windows.Forms.Padding(4);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(133, 86);
            this.sum.TabIndex = 18;
            this.sum.Text = "=";
            this.sum.UseVisualStyleBackColor = false;
            // 
            // obliczenia
            // 
            this.obliczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.obliczenia.Location = new System.Drawing.Point(16, 128);
            this.obliczenia.Name = "obliczenia";
            this.obliczenia.Size = new System.Drawing.Size(557, 45);
            this.obliczenia.TabIndex = 19;
            this.obliczenia.Text = "Wynik";
            this.obliczenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(557, 84);
            this.listBox1.TabIndex = 20;
            this.listBox1.Enabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(590, 682);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.obliczenia);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.del);
            this.Controls.Add(this.delC);
            this.Controls.Add(this.delCE);
            this.Controls.Add(this.signPodzielić);
            this.Controls.Add(this.signRazy);
            this.Controls.Add(this.signMinus);
            this.Controls.Add(this.signPlus);
            this.Controls.Add(this.signComma);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button signComma;
        private System.Windows.Forms.Button signPlus;
        private System.Windows.Forms.Button signMinus;
        private System.Windows.Forms.Button signRazy;
        private System.Windows.Forms.Button signPodzielić;
        private System.Windows.Forms.Button delCE;
        private System.Windows.Forms.Button delC;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.TextBox obliczenia;
        private System.Windows.Forms.ListBox listBox1;
    }
}

