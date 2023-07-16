using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Caceres.Shared.Models;

public class Productos
{
	[Key]

    public int ProductoId { get; set; }

    [Required(ErrorMessage = "La descripcion es un campo obligatorio")]
    public string Descripcion { get; set; } = string.Empty;

    [Required(ErrorMessage = "El tipo es obligatorio")]
    public int Tipo { get; set; }

    [Required(ErrorMessage = "La cantidad que existen de los productos es obligatoria")]
    public float Existencia { get; set; }
}

