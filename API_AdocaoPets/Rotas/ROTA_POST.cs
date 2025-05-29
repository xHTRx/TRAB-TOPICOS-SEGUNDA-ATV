// Rotas/ROTA_POST.cs
using Microsoft.AspNetCore.Mvc;
using src.Context;
using API_AdocaoPets.src.Models;

namespace API_AdocaoPets.Rotas
{

[ApiController]
[Route("api/pets")]
public class PetsPostController : ControllerBase
{
    private readonly PetContext _context;
    public PetsPostController(PetContext context) => _context = context;

    [HttpPost]
    public ActionResult<Pet> PostPet([FromBody] Pet pet)
    {
        _context.Pets.Add(pet);
        _context.SaveChanges();
        return CreatedAtRoute("GetPetById", new { id = pet.Id }, pet);
    }
}

}