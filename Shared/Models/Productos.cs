using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Caceres.Shared.Models
{
	public class Productos
	{
		public int ProductoId { get; set; }

		public string Descripcion { get; set; }

        public int Tipo { get; set; }

        public int Existencia { get; set; }
    }
}
