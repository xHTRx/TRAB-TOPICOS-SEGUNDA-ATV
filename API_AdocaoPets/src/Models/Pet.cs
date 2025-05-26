
namespace API_AdocaoPets.src.Models
{
    public class Pet
    {
        public int Id { get; set; }                 // Chave primária
        public string Nome { get; set; }            // Nome do pet
        public string Especie { get; set; }         // "Cachorro", "Gato", etc.
        public string Raca { get; set; }            // Raça (ou "Sem raça definida")
        public int Idade { get; set; }              // Idade em anos
        public string Sexo { get; set; }            // "Macho" ou "Fêmea"
        public bool Vacinado { get; set; }          // Já foi vacinado?
        public string Descricao { get; set; }       // Informações adicionais
    }
}
