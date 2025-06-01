namespace proyecto_automatas
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.TextBox textBoxExpresionMatematica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.textBoxExpresionMatematica = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();

            // textBoxExpresionMatematica
            this.textBoxExpresionMatematica.Name = "textBoxExpresionMatematica";
            this.textBoxExpresionMatematica.Location = new System.Drawing.Point(12, 12);
            this.textBoxExpresionMatematica.Size = new System.Drawing.Size(260, 23);
            this.textBoxExpresionMatematica.TabIndex = 0;
            this.textBoxExpresionMatematica.TextChanged += new System.EventHandler(this.textBoxExpresionMatematica_TextChanged);

            // button1 ("Analizar")
            this.button1.Name = "button1";
            this.button1.Text = "Analizar";
            this.button1.Location = new System.Drawing.Point(12, 50);
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // button2 ("(")
            this.button2.Name = "button2";
            this.button2.Text = "(";
            this.button2.Location = new System.Drawing.Point(78, 50);
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // button3 (")")
            this.button3.Name = "button3";
            this.button3.Text = ")";
            this.button3.Location = new System.Drawing.Point(124, 50);
            this.button3.Size = new System.Drawing.Size(40, 30);
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // button4 ("C" - Clear)
            this.button4.Name = "button4";
            this.button4.Text = "C";
            this.button4.Location = new System.Drawing.Point(170, 50);
            this.button4.Size = new System.Drawing.Size(40, 30);
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // button5 ("^")
            this.button5.Name = "button5";
            this.button5.Text = "^";
            this.button5.Location = new System.Drawing.Point(216, 50);
            this.button5.Size = new System.Drawing.Size(40, 30);
            this.button5.Click += new System.EventHandler(this.button5_Click);

            // button6 ("7")
            this.button6.Name = "button6";
            this.button6.Text = "7";
            this.button6.Location = new System.Drawing.Point(12, 90);
            this.button6.Size = new System.Drawing.Size(40, 30);
            this.button6.Click += new System.EventHandler(this.button6_Click);

            // button7 ("8")
            this.button7.Name = "button7";
            this.button7.Text = "8";
            this.button7.Location = new System.Drawing.Point(58, 90);
            this.button7.Size = new System.Drawing.Size(40, 30);
            this.button7.Click += new System.EventHandler(this.button7_Click);

            // button8 ("9")
            this.button8.Name = "button8";
            this.button8.Text = "9";
            this.button8.Location = new System.Drawing.Point(104, 90);
            this.button8.Size = new System.Drawing.Size(40, 30);
            this.button8.Click += new System.EventHandler(this.button8_Click);

            // button9 ("/")
            this.button9.Name = "button9";
            this.button9.Text = "/";
            this.button9.Location = new System.Drawing.Point(150, 90);
            this.button9.Size = new System.Drawing.Size(40, 30);
            this.button9.Click += new System.EventHandler(this.button9_Click);

            // button10 ("4")
            this.button10.Name = "button10";
            this.button10.Text = "4";
            this.button10.Location = new System.Drawing.Point(12, 130);
            this.button10.Size = new System.Drawing.Size(40, 30);
            this.button10.Click += new System.EventHandler(this.button10_Click);

            // button11 ("5")
            this.button11.Name = "button11";
            this.button11.Text = "5";
            this.button11.Location = new System.Drawing.Point(58, 130);
            this.button11.Size = new System.Drawing.Size(40, 30);
            this.button11.Click += new System.EventHandler(this.button11_Click);

            // button12 ("6")
            this.button12.Name = "button12";
            this.button12.Text = "6";
            this.button12.Location = new System.Drawing.Point(104, 130);
            this.button12.Size = new System.Drawing.Size(40, 30);
            this.button12.Click += new System.EventHandler(this.button12_Click);

            // button13 ("*")
            this.button13.Name = "button13";
            this.button13.Text = "*";
            this.button13.Location = new System.Drawing.Point(150, 130);
            this.button13.Size = new System.Drawing.Size(40, 30);
            this.button13.Click += new System.EventHandler(this.button13_Click);

            // button14 ("1")
            this.button14.Name = "button14";
            this.button14.Text = "1";
            this.button14.Location = new System.Drawing.Point(12, 170);
            this.button14.Size = new System.Drawing.Size(40, 30);
            this.button14.Click += new System.EventHandler(this.button14_Click);

            // button15 ("2")
            this.button15.Name = "button15";
            this.button15.Text = "2";
            this.button15.Location = new System.Drawing.Point(58, 170);
            this.button15.Size = new System.Drawing.Size(40, 30);
            this.button15.Click += new System.EventHandler(this.button15_Click);

            // button16 ("3")
            this.button16.Name = "button16";
            this.button16.Text = "3";
            this.button16.Location = new System.Drawing.Point(104, 170);
            this.button16.Size = new System.Drawing.Size(40, 30);
            this.button16.Click += new System.EventHandler(this.button16_Click);

            // button17 ("-")
            this.button17.Name = "button17";
            this.button17.Text = "-";
            this.button17.Location = new System.Drawing.Point(150, 170);
            this.button17.Size = new System.Drawing.Size(40, 30);
            this.button17.Click += new System.EventHandler(this.button17_Click);

            // button18 ("0")
            this.button18.Name = "button18";
            this.button18.Text = "0";
            this.button18.Location = new System.Drawing.Point(12, 210);
            this.button18.Size = new System.Drawing.Size(40, 30);
            this.button18.Click += new System.EventHandler(this.button18_Click);

            // button19 ("00")
            this.button19.Name = "button19";
            this.button19.Text = "00";
            this.button19.Location = new System.Drawing.Point(58, 210);
            this.button19.Size = new System.Drawing.Size(40, 30);
            this.button19.Click += new System.EventHandler(this.button19_Click);

            // button20 (".")
            this.button20.Name = "button20";
            this.button20.Text = ".";
            this.button20.Location = new System.Drawing.Point(104, 210);
            this.button20.Size = new System.Drawing.Size(40, 30);
            this.button20.Click += new System.EventHandler(this.button20_Click);

            // button21 ("+")
            this.button21.Name = "button21";
            this.button21.Text = "+";
            this.button21.Location = new System.Drawing.Point(150, 210);
            this.button21.Size = new System.Drawing.Size(40, 30);
            this.button21.Click += new System.EventHandler(this.button21_Click);

            // Add controls to the form
            this.Controls.Add(this.textBoxExpresionMatematica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);

            this.Name = "Form1";
            this.Text = "Analizador Léxico";
            this.ClientSize = new System.Drawing.Size(270, 260);
        }

        #endregion
    }
}
