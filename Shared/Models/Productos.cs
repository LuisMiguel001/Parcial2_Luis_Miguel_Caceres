using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Caceres.Shared.Models
{
	public class Productos
	{
		[Key]

		public int ProductoId { get; set; }

		public string? Descripcion { get; set; }

		public int Existencia { get; set; }

		public int Peso { get; set; }
	}
}
