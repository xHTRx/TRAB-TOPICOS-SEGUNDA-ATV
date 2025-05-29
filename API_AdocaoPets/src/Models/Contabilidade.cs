//src/Models/Contabilidade.cs

using System.ComponentModel.DataAnnotations.Schema;
namespace API_AdocaoPets.src.Models
{
    public class Contabilidade
    {
        public int id { get; set; }
        public double valorMedioRacao { get; set; }
        public double valorMedioVet { get; set; }
        public double valorMedioVac { get; set; }

        public Pet? Pet { get; set; }  // Navegação

        public int PetId { get; set; }
        public Pet Pets { get; set; } = null!;
          
    }

}