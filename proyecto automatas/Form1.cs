using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyrcto_Final_avance2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Analizador léxico: convierte la expresión en una lista de tokens
        private List<string> AnalizadorLexico(string expresion)
        {
            List<string> tokens = new List<string>();
            string patron = @"(\d+(\.\d+)?|[+\-*/^()])";
            MatchCollection coincidencias = Regex.Matches(expresion, patron);

            foreach (Match match in coincidencias)
            {
                tokens.Add(match.Value);
            }

            return tokens;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text = string.Empty;
        }

        // Ensure this matches the event handler assigned in Designer
        private void textBoxExpresionMatematica_TextChanged(object sender, EventArgs e)
        {
            // No agregar texto automáticamente aquí
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "(";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += ")";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "^";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expresion = textBoxExpresionMatematica.Text;
            List<string> tokens = AnalizadorLexico(expresion);

            MessageBox.Show("Tokens:\n" + string.Join(", ", tokens), "Resultado del Análisis Léxico");
        }
    }
}