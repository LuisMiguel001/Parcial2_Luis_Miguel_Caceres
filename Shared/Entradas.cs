﻿using Parcial2_Luis_Miguel_Caceres.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Caceres.Shared;

public class Entradas
{
    [Key]

    public int EntradaId { get; set; }

    public DateTime Fecha { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "El concepto es obligatorio")]
    public string Concepto { get; set; } = string.Empty;

    public int PesoTotal { get; set; }

    [Required(ErrorMessage = "El ProductodId obligatorio")]
    public int ProductoId { get; set; }

    [Required(ErrorMessage = "La cantidad utilizada es obligatoria")]
    public int CantidadProducida { get; set; }

    [ForeignKey("EntradaId")]
    public List<EntradasDetalle> EntradasDetalles { get; set; } = new List<EntradasDetalle>();
}
