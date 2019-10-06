using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        private List<Producto> productos;
        private int espacioDisponible;
        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        #region "Constructores"
        /// <summary>
        /// Constructor que instancia una nueva lista de productos.
        /// </summary>
        private Changuito()
        {
            this.productos = new List<Producto>();
        }
        /// <summary>
        /// Constructor que asigna el espacio disponible.
        /// </summary>
        public Changuito(int ESP) : this()
        {
            this.espacioDisponible = ESP;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestra el changuito con todos los productos.
        /// </summary>
        public override string ToString()
        {
            return Changuito.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", c.productos.Count, c.espacioDisponible);
            sb.AppendLine("");
            foreach (Producto productoParametro in c.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if (productoParametro is Snacks)
                            sb.AppendLine(productoParametro.Mostrar());
                        break;
                    case ETipo.Dulce:
                        if (productoParametro is Dulce)
                            sb.AppendLine(productoParametro.Mostrar());
                        break;
                    case ETipo.Leche:
                        if (productoParametro is Leche)
                            sb.AppendLine(productoParametro.Mostrar());
                        break;
                    default:
                        sb.AppendLine(productoParametro.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"

        /// <summary>
        /// Agregará un elemento a la lista. Si ese elemento ya se encuentra en la lista, si no, lo agrega.
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            bool retorno = false;

            foreach (Producto v in c.productos)
            {
                if (v == p)
                {
                    retorno = true;
                }
            }

            if (retorno == false && c.productos.Count + 1 <= c.espacioDisponible)
            {
                c.productos.Add(p);
            }

            return c;
        }

        /// <summary>
        /// Quitará un elemento de la lista en caso que este se encuentre dentro.
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto v in c.productos)
            {
                if (v == p)
                {
                    c.productos.Remove(v);
                    break;
                }
            }

            return c;
        }
        #endregion
    }
}
