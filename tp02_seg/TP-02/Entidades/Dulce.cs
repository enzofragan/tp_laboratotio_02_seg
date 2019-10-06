using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        /// <summary>
        /// Constructor que se encarga de inicializar los parametros de un producto de tipo dulce
        /// </summary>
        /// <param name="M01"></param>
        /// <param name="Code01"></param>
        /// <param name="Col01"></param>
        public Dulce(EMarca M01, string Code01, ConsoleColor Col01) : base(Code01, M01, Col01)
        {

        }

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        /// <summary>
        /// Muestra el contenido de un producto de tipo dulce.
        /// </summary>
        /// <returns> Retorna un string con los datos </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
