﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Caceres.Shared.Models
{
	public class EntradasDetalle
	{
		public int DetalleId { get; set; }

		public int EntradadId { get; set; }

		public int ProductoId { get; set; }

		public float CantidadUtilizada { get; set; }
	}
}
