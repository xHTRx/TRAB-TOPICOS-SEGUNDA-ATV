//src/Models/Pet.cs
namespace API_AdocaoPets.src.Models
{
    public class Pet
    {
        public int Id { get; set; }               // Chave primária
        public string Nome { get; set; } = string.Empty;           // Nome do pet
        public string Especie { get; set; } = string.Empty;        // "Cachorro", "Gato", etc.
        public string Raca { get; set; } = string.Empty;           // Raça (ou "Sem raça definida")
        public int? Idade { get; set; }            // Idade em anos
        public string Sexo { get; set; } = string.Empty;           // "Macho" ou "Fêmea"
        public bool Vacinado { get; set; }         // Já foi vacinado?
        public bool PCD { get; set; }
        public string porte { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;      // Informações adicionais

        // Relacionamentos
        public Contabilidade? Contabilidade { get; set; }
    
        public int CanilId { get; set; }
        public Canil? Canil { get; set; }
        
    }
}
