using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Caceres.Server.DAL;
using Parcial2_Luis_Miguel_Caceres.Shared;

namespace Parcial2_Luis_Miguel_Caceres.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductosController : ControllerBase
{
	private readonly Context _context;

	public ProductosController(Context context)
	{
		_context = context;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<Entradas>>> GetEntradas()
	{
		if (_context.Entradas == null)
		{
			return NotFound();
		}
		return await _context.Entradas.ToListAsync();
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Entradas>> GetEntradas(int id)
	{
		if (_context.Entradas == null)
		{
			return NotFound();
		}
		var Entradas = await _context.Entradas.FindAsync(id);

		if (Entradas == null)
		{
			return NotFound();
		}

		return Entradas;
	}

	[HttpPost]
	public async Task<ActionResult<Entradas>> PostEntradas(Entradas Entradas)
	{
		if (!EntradasExists(Entradas.ProductoId))
			_context.Entradas.Add(Entradas);
		else
			_context.Entradas.Update(Entradas);

		await _context.SaveChangesAsync();
		return Ok(Entradas);
	}

	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteEntradas(int id)
	{
		if (_context.Entradas == null)
		{
			return NotFound();
		}
		var Entradas = await _context.Entradas.FindAsync(id);
		if (Entradas == null)
		{
			return NotFound();
		}

		_context.Entradas.Remove(Entradas);
		await _context.SaveChangesAsync();

		return NoContent();
	}

	private bool EntradasExists(int id)
	{
		return (_context.Entradas?.Any(e => e.ProductoId == id)).GetValueOrDefault();
	}
}

