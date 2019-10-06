using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        /// <summary>
        /// Constructor que inicializa los tres parametros de un producto de tipo Snack
        /// </summary>
        /// <param name="M01"></param>
        /// <param name="Code01"></param>
        /// <param name="Col01"></param>
        public Snacks(EMarca M01, string Code01, ConsoleColor Col01) : base(Code01, M01, Col01)
        {

        }

        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        /// <summary>
        /// Muestra el contenido de un producto de tipo Snack.
        /// </summary>
        /// <returns> Retorna un string con los datos de Snack </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS: {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
