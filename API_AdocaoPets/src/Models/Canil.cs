//src/Models/Canil.cs
namespace API_AdocaoPets.src.Models
{
    public class Canil
    {
        
        public int id { get; set; }
        
        public string local { get; set; } = string.Empty;

        public int numPets { get; set; }

        public int numCaes { get; set; }
        
        public int numGatos { get; set; }

    }

}