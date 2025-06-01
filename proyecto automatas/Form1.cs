using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proyecto_automatas
{
    public partial class Form1 : Form
    {
        private List<string> ListaDeToken;
        private int pos;
        private string TokenActual;

        private class NodoArbol
        {
            public string Valor { get; set; }
            public List<NodoArbol> Hijos { get; set; }
            public double Resultado { get; set; }

            public NodoArbol(string valor, double resultado = 0)
            {
                Valor = valor;
                Hijos = new List<NodoArbol>();
                Resultado = resultado;
            }
        }

        private NodoArbol raizArbol;
        private List<string> historialExpresiones = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // Analizador l�xico: convierte la expresi�n en una lista de tokens
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

        private void GetNextToken()
        {
            if (pos < ListaDeToken.Count)
            {
                TokenActual = ListaDeToken[pos];
                pos++;
            }
            else
            {
                TokenActual = null;
            }
        }

        private double Expresion(NodoArbol nodoActual = null)
        {
            var nodo = nodoActual ?? new NodoArbol("Expresi�n");
            if (raizArbol == null) raizArbol = nodo;

            var primerTermino = new NodoArbol("T�rmino");
            nodo.Hijos.Add(primerTermino);
            double resultado = Termino(primerTermino);

            while (TokenActual == "+" || TokenActual == "-")
            {
                string operador = TokenActual;
                var nodoOperador = new NodoArbol(operador);
                nodo.Hijos.Add(nodoOperador);

                GetNextToken();
                var siguienteTermino = new NodoArbol("T�rmino");
                nodo.Hijos.Add(siguienteTermino);
                double segundoOperando = Termino(siguienteTermino);

                if (operador == "+")
                    resultado += segundoOperando;
                else
                    resultado -= segundoOperando;
            }

            nodo.Resultado = resultado;
            return resultado;
        }

        private double Termino(NodoArbol nodoActual)
        {
            var primerFactor = new NodoArbol("Factor");
            nodoActual.Hijos.Add(primerFactor);
            double resultado = Factor(primerFactor);

            while (TokenActual == "*" || TokenActual == "/")
            {
                string operador = TokenActual;
                var nodoOperador = new NodoArbol(operador);
                nodoActual.Hijos.Add(nodoOperador);

                GetNextToken();
                var siguienteFactor = new NodoArbol("Factor");
                nodoActual.Hijos.Add(siguienteFactor);
                double segundoOperando = Factor(siguienteFactor);

                if (operador == "*")
                    resultado *= segundoOperando;
                else
                {
                    if (segundoOperando == 0)
                        throw new DivideByZeroException("Divisi�n por cero no permitida");
                    resultado /= segundoOperando;
                }
            }

            nodoActual.Resultado = resultado;
            return resultado;
        }

        private double Factor(NodoArbol nodoActual)
        {
            double resultado;

            if (TokenActual == "(")
            {
                nodoActual.Valor = "( )";
                GetNextToken();
                var expresionInterna = new NodoArbol("Expresi�n");
                nodoActual.Hijos.Add(expresionInterna);
                resultado = Expresion(expresionInterna);

                if (TokenActual != ")")
                    throw new Exception("Se esperaba un par�ntesis de cierre ')'");

                GetNextToken();
            }
            else if (double.TryParse(TokenActual, out resultado))
            {
                nodoActual.Valor = TokenActual;
                GetNextToken();
            }
            else
            {
                throw new Exception($"Token no esperado: {TokenActual}");
            }

            if (TokenActual == "^")
            {
                var nodoExponente = new NodoArbol("^");
                nodoActual.Hijos.Add(nodoExponente);
                GetNextToken();
                var factorExponente = new NodoArbol("Factor");
                nodoActual.Hijos.Add(factorExponente);
                double exponente = Factor(factorExponente);
                resultado = Math.Pow(resultado, exponente);
            }

            nodoActual.Resultado = resultado;
            return resultado;
        }

        private void MostrarArbolEnTreeView(NodoArbol nodo, TreeNode nodoPadre)
        {
            string etiqueta = $"{nodo.Valor} [{nodo.Resultado}]";
            TreeNode nuevoNodo = nodoPadre == null ?
                treeViewDerivacion.Nodes.Add(etiqueta) :
                nodoPadre.Nodes.Add(etiqueta);

            foreach (var hijo in nodo.Hijos)
            {
                MostrarArbolEnTreeView(hijo, nuevoNodo);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text = string.Empty;
        }

        private void textBoxExpresionMatematica_TextChanged(object sender, EventArgs e)
        {
            // No agregar texto autom�ticamente aqu�
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
            try
            {
                string expresion = textBoxExpresionMatematica.Text.Trim();
                if (string.IsNullOrEmpty(expresion))
                {
                    MessageBox.Show("Por favor ingrese una expresi�n matem�tica.", "Error");
                    return;
                }

                ListaDeToken = AnalizadorLexico(expresion);
                pos = 0;
                raizArbol = null;
                GetNextToken();

                double resultado = Expresion();

                if (TokenActual != null)
                    throw new Exception("Tokens adicionales despu�s del final de la expresi�n");

                // Actualizar TreeView
                treeViewDerivacion.Nodes.Clear();
                MostrarArbolEnTreeView(raizArbol, null);
                treeViewDerivacion.ExpandAll();

                // Actualizar historial
                string entradaHistorial = $"{expresion} = {resultado}";
                listBoxHistorial.Items.Insert(0, entradaHistorial);

                MessageBox.Show($"Resultado: {resultado}", "An�lisis Sint�ctico Exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de an�lisis: {ex.Message}", "Error");
            }
        }
    }
}