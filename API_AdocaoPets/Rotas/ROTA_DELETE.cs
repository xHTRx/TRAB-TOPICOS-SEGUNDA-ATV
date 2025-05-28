// Rotas/ROTA_DELETE.cs
using Microsoft.AspNetCore.Mvc;
using src.Context;
using API_AdocaoPets.src.Models;

namespace API_AdocaoPets.Rotas
{

    [ApiController]
    [Route("api/pets")]
    public class PetsDeleteController : ControllerBase
    {
        private readonly PetContext _context;
        public PetsDeleteController(PetContext context) => _context = context;

        [HttpDelete("{id}")]
        public IActionResult DeletePet(int id)
        {
            var pet = _context.Pets.Find(id);
            if (pet is null) return NotFound();

            _context.Pets.Remove(pet);
            _context.SaveChanges();
            return NoContent();
        }
    }
}