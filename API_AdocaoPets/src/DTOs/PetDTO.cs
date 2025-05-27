// src/DTOs/PetDTO.cs
namespace API_AdocaoPets.src.DTOs
{
    public class PetDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public int Idade { get; set; }
    }
}