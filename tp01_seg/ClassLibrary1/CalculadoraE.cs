using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalculadoraE
    {
        /// <summary>
        /// Metodo que opera dos valores de tipo Numero segun la operacion aricmetica basica seleccionada
        /// </summary>
        /// <param name="num1">Primer dato de tipo Numero que sera operado</param>
        /// <param name="num2">Segundp dato de tipo Numero que sera operado</param>
        /// <param name="operador">Operacion aricmetica a realizar (+,-,*,/)</param>
        /// <returns>Retorna un valor de tipo Double con el resultado de la operacion</returns>
        public static double Operar(Numeros NumUno, Numeros NumDos, string Operador)
        {
            double Ret = 0;
            switch (ValOperador(Operador))
            {
                case "+":
                    Ret = NumUno + NumDos;
                    break;
                case "-":
                    Ret = NumUno - NumDos;
                    break;
                case "*":
                    Ret = NumUno * NumDos;
                    break;
                case "/":
                    Ret = NumUno / NumDos;
                    break;
                default:
                    break;
            }
            return Ret;
        }

        /// <summary>
        /// Metodo que valida que el operador ingresado sea correcto
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Retorna el operador ingresado si la validacion es correcta. Caso contrario retorna el operador +</returns>
        private static string ValOperador(string Operador)
        {
            string Ret;
            if (Operador == "+" || Operador == "-" || Operador == "*" || Operador == "/")
            {
                Ret = Operador;
            }
            else
            {
                Ret = "+";
            }
            return Ret;
        }
    }
}
