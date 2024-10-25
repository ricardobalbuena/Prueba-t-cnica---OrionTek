using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dominio.Entities;
using Infraestructura.Data;

[Route("api/[controller]")]
[ApiController]
public class DireccionesController : ControllerBase
{
    private readonly PruebaDbContext _context;

    public DireccionesController(PruebaDbContext context)
    {
        _context = context;
    }

    // GET: api/Direcciones/cliente/5
    [HttpGet("cliente/{clienteId}")]
    public async Task<ActionResult<IEnumerable<Direccion>>> GetDireccionesByCliente(int clienteId)
    {
        var direcciones = await _context.Direcciones.Where(d => d.ClienteId == clienteId).ToListAsync();

        if (direcciones == null || direcciones.Count == 0)
        {
            return NotFound();
        }

        return direcciones;
    }

    // POST: api/Direcciones
    [HttpPost]
    public async Task<ActionResult<Direccion>> PostDireccion(Direccion direccion)
    {
        _context.Direcciones.Add(direccion);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDireccion", new { id = direccion.Id }, direccion);
    }

    // GET: api/Direcciones/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Direccion>> GetDireccion(int id)
    {
        var direccion = await _context.Direcciones.FindAsync(id);

        if (direccion == null)
        {
            return NotFound();
        }

        return direccion;
    }

    // PUT: api/Direcciones/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDireccion(int id, Direccion direccion)
    {
        if (id != direccion.Id)
        {
            return BadRequest();
        }

        _context.Entry(direccion).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DireccionExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Direcciones/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDireccion(int id)
    {
        var direccion = await _context.Direcciones.FindAsync(id);
        if (direccion == null)
        {
            return NotFound();
        }

        _context.Direcciones.Remove(direccion);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DireccionExists(int id)
    {
        return _context.Direcciones.Any(e => e.Id == id);
    }
}
