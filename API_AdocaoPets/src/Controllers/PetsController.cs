using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Context;
using API_AdocaoPets.src.Models;

namespace API_AdocaoPets.src.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly PetContext _context;

        public PetsController(PetContext context)
        {
            _context = context;
        }

        // GET: /Pets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
        {
            return await _context.Pets.ToListAsync();
        }

        // GET: /Pets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> GetPet(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null) return NotFound();
            return pet;
        }

        // POST: /Pets
        [HttpPost]
        public async Task<ActionResult<Pet>> PostPet(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPet), new { id = pet.Id }, pet);
        }

        // DELETE: /Pets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePet(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null) return NotFound();

            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}