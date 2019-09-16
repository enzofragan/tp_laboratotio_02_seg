using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            string[] Operadores = { "+", "-", "*", "/" };

            foreach(string operador in Operadores)
            {
                this.CmbOperadores.Items.Add(operador);
            }
            this.CmbOperadores.Items.Add("");
            this.CmbOperadores.SelectedItem = ("");
            LblResultado.Text = "";
            BtnDecimal.Enabled = false;
            BtnBinario.Enabled = false;
        }

        /// <summary>
        /// Al hacer click en el boton operar realiza la operacion deseada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOperar_Click(object sender, EventArgs e)
        {
            double Resultado = Operar(txtNumeroUno.Text, TxtNumeroDos.Text, CmbOperadores.Text);
            if (!((txtNumeroUno.Text).All(char.IsDigit)) || txtNumeroUno.Text == "")
            {
                txtNumeroUno.Text = "0";
            }
            if (!((TxtNumeroDos.Text).All(char.IsDigit)) || TxtNumeroDos.Text == "")
            {
                TxtNumeroDos.Text = "0";
            }
            if (CmbOperadores.Text != "+" && CmbOperadores.Text != "-" && CmbOperadores.Text != "*" && CmbOperadores.Text != "/")
            {
                CmbOperadores.Text = "+";
            }
            LblResultado.Text = Resultado.ToString();
            BtnBinario.Enabled = true;
            BtnDecimal.Enabled = true;
        }

        /// <summary>
        /// Al hacer click en el boton limpiar se borra lo escrito en los campos y el comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Al hacer click se cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opera los valores ingresados
        /// </summary>
        /// <param name="Numero1">Primer numero en string</param>
        /// <param name="Numero2">Segundo numero en string</param>
        /// <param name="operador">Caracter de la operacion</param>
        /// <returns>Retorna el resultado</returns>
        private static double Operar(string NumUno, string NumDos, string Operador)
        {
            Numeros numeroUno = new Numeros(NumUno);
            Numeros numeroDos = new Numeros(NumDos);
            return CalculadoraE.Operar(numeroUno, numeroDos, Operador);
        }

        /// <summary>
        /// Limpia todo lo ingresados en los campos y en el comboBox
        /// </summary>
        private void Limpiar()
        {
            foreach (Control Objeto in this.Controls)
            {
                if (Objeto is TextBox || Objeto is ComboBox || Objeto is Label)
                {
                    Objeto.Text = "";
                }
            }
            BtnBinario.Enabled = false;
            BtnDecimal.Enabled = false;
        }

        /// <summary>
        /// Al precionar el boton binario convierte el numero decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBinario_Click(object sender, EventArgs e)
        {
            LblResultado.Text = Numeros.StrDecimalABinario(LblResultado.Text);
            if (LblResultado.Text != "Error Numero Invalido")
            {
                BtnBinario.Enabled = false;
            }

        }

        /// <summary>
        /// Al precionar el boton decimal convierte el numero binario de nuevo a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            LblResultado.Text = Numeros.BinarioADecimal(LblResultado.Text);
            BtnBinario.Enabled = true;
        }
    }
}
