using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        private ETipo tipo;

        /// <summary>
        /// Constructor de leche. Por defecto será ENTERA.
        /// </summary>
        /// <param name="M01"></param>
        /// <param name="Code01"></param>
        /// <param name="Col01"></param>
        /// 
        public Leche(EMarca M01, string Code01, ConsoleColor Col01) : this(M01, Code01, Col01, ETipo.Entera)
        {

        }

        /// <summary>
        /// Constructor de leche. Por defecto será ENTERA.
        /// </summary>
        /// <param name="M01"></param>
        /// <param name="Code01"></param>
        /// <param name="Col01"></param>
        /// 
        public Leche(EMarca M01, string Code01, ConsoleColor Col01, ETipo tipo) : base(Code01, M01, Col01)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        /// <summary>
        /// Muestra el contenido del producto de tipo Leche
        /// </summary>
        /// <returns> Retorna un string con los datos de Leche </returns>
        /// 
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendFormat("TIPO: {0} \r\n", this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
