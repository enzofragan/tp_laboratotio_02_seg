using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numeros
    {
        private double _Numero;

        /// <summary>
        /// Valida y setea los numeros para realizar las operaciones
        /// </summary>
        private string setNumero
        {
            set
            {
                _Numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Constructor que inicializa en 0 a un objeto de tipo Numeros
        /// </summary>
        public Numeros() : this(0)
        {

        }

        /// <summary>
        /// Constructor que inicializa a un objeto de tipo Numero con el valor pasado por parametro
        /// </summary>
        /// <param name="numero">Numero con el que se va a inicializar al objeto</param>
        public Numeros(double num) : this(num.ToString())
        {

        }

        /// <summary>
        /// Constructor que inicializa a un objeto de tipo Numero con el valor de tipo string pasado por parametro
        /// </summary>
        /// <param name="strNumero">Valor con el que se va a inicializar al objeto</param>
        public Numeros(string StrNum)
        {
            setNumero = StrNum;
        }

        /// <summary>
        /// Metodo que pasa un numero de binario a decimal
        /// </summary>
        /// <param name="binario">Numero binario en formato string</param>
        /// <returns>Retorna el numero convertido a decimal o "Valor invalido" si el valor ingresado es incorrecto</returns>
        public static string BinarioADecimal(string Bin)
        {
            int[] cadenaInt = new int[Bin.Length];
            string Ret = "";
            double Numero = 0;
            bool Bandera = true;
            int i;
            for (i = 0; i < Bin.Length; i++)
            {
                cadenaInt[i] = (int)char.GetNumericValue(Bin[i]);
                if (cadenaInt[i] != 0 && cadenaInt[i] != 1)
                {
                    Bandera = false;
                    break;
                }
            }
            if (Bandera == true)
            {
                for (i = 0; i < Bin.Length; i++)
                {
                    Numero += (cadenaInt[i] * Math.Pow(2, Bin.Length - i - 1));
                }
                Ret = Numero.ToString();
            }
            else
            {
                Ret = "Valor Invalido";
            }

            return Ret;
        }

        /// <summary>
        /// Sobrecarga del metodo DecimalBinario que valida que la cadena pasada por parametro sea correcta
        /// </summary>
        /// <param name="numero">Numero decimal de tipo string</param>
        /// <returns>Retorna un numero decimal de tipo string si el valor es correcto. Si es incorrecto retorna "Valor invalido"</returns>
        public static string StrDecimalABinario(string Num)
        {
            string Ret;
            double NumDou;
            if (double.TryParse(Num, out NumDou))
            {
                Ret = DubDecimalABinario(NumDou);
            }
            else
            {
                Ret = "Valor Invalido";
            }
            return Ret;
        }

        /// <summary>
        /// Sobrecarga del metodo DecimalBinario que convierte un numero decimal de tipo double a un numero binario
        /// </summary>
        /// <param name="entero">Numero de tipo double que sera convertido</param>
        /// <returns>Retorna el numero convertido a binario en tipo string</returns>
        public static string DubDecimalABinario(double entero)
        {
            int Num = (int)entero;
            string Bin = "";
            while (Num > 0)
            {
                Bin += (Num % 2).ToString();
                Num = Num / 2;
            }
            char[] BinArray = Bin.ToCharArray();
            Array.Reverse(BinArray);
            return new string(BinArray);
        }

        /// <summary>
        /// Metodo que valida que el numero de tipo string ingresado sea convertible a double
        /// </summary>
        /// <param name="strNumero">Numero de tipo string</param>
        /// <returns>Retorna el numero convertido a tipo double o 0 si no puede ser convertido</returns>
        private double ValidarNumero(string StrNum)
        {
            double retorno;
            double.TryParse(StrNum, out retorno);
            return retorno;
        }

        public static double operator +(Numeros n1, Numeros n2)
        {
            return n1._Numero + n2._Numero;
        }

        public static double operator -(Numeros n1, Numeros n2)
        {
            return n1._Numero - n2._Numero;
        }

        public static double operator *(Numeros n1, Numeros n2)
        {
            return n1._Numero * n2._Numero;
        }

        public static double operator /(Numeros n1, Numeros n2)
        {
            return n1._Numero / n2._Numero;
        }
    }
}
