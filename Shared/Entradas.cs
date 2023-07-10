﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Caceres.Shared
{
	public class Entradas
	{
		[Key]

		public int EntradaId { get; set; }

        public DateTime Fecha { get; set; }

		public string Concepto { get; set; }

		public float PesoTotal { get; set; }

		public int ProductoId { get; set; }

		public int CantiadadId { get; set; }
    }
}