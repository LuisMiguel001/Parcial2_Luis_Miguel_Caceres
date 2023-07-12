﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Caceres.Shared.Models
{
	public class EntradasDetalle
	{
		[Key]

		public int DetalleId { get; set; }

		public int EntradadId { get; set; }

		public int ProductoId { get; set; }

		public int CantidadUtilizada { get; set; }

		public int FrutoId { get; set; }

		public String? Nombre { get; set; }

		public int Disponibilidad { get; set; }
	}
}
