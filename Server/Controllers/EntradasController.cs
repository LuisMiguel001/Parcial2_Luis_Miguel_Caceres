using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Caceres.Server.DAL;
using Parcial2_Luis_Miguel_Caceres.Shared;

namespace Parcial2_Luis_Miguel_Caceres.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EntradasController : ControllerBase
{
	private readonly Context _context;

	public EntradasController(Context contex)
	{
		_context = contex;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<Entradas>>> GetEntrada()
	{
		if (_context.Entradas == null)
		{
			return NotFound();
		}
		return await _context.Entradas.ToListAsync();
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Entradas>> GetEntrada(int id)
	{
		if (_context.Entradas == null)
		{
			return NotFound();
		}

		var entrada = await _context.Entradas
			.Include(i => i.EntradasDetalles)
			.Where(i => i.EntradaId == id)
			.FirstOrDefaultAsync();

		if (entrada == null)
		{
			return NotFound();
		}
		return entrada;
	}

	[HttpPost]
	public async Task<ActionResult<Entradas>> PostIngresos(Entradas entrada)
	{
		if (!Existe(entrada.EntradaId))
			_context.Entradas.Add(entrada);
		else
			_context.Entradas.Update(entrada);

		await _context.SaveChangesAsync();
		return Ok(entrada);
	}

	[HttpDelete]
	public async Task<ActionResult> DeleteIngresos(int id)
	{
		if (_context.Entradas == null)
		{
			return NotFound();
		}

		var detalle = await _context.Entradas.FindAsync(id);

		if (detalle == null)
		{
			return NotFound();
		}

		_context.Entradas.Remove(detalle);
		await _context.AddRangeAsync(detalle);

		return NoContent();
	}

	public bool Existe(int id)
	{
		return (_context.Entradas?.Any(e => e.EntradaId == id)).GetValueOrDefault();
	}
}

