// Rotas/ROTA_GET.cs
using Microsoft.AspNetCore.Mvc;
using src.Context;
using API_AdocaoPets.src.Models;

namespace API_AdocaoPets.Rotas
{
    [ApiController]
[Route("api/pets")]
public class PetsGetController : ControllerBase
{
    private readonly PetContext _context;
    public PetsGetController(PetContext context) => _context = context;

    [HttpGet]
    public ActionResult<IEnumerable<Pet>> GetTodos()
        => Ok(_context.Pets.ToList());

    [HttpGet("{id}", Name = "GetPetById")]
    public ActionResult<Pet> GetPorId(int id)
    {
        var pet = _context.Pets.Find(id);
        return pet is null ? NotFound() : Ok(pet);
    }
}
}