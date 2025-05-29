using API_AdocaoPets.src.Models;
using src.Context;

namespace API_AdocaoPets.src
{
    public static class DbInitializer
    {
        public static void Initialize(PetContext context)
        {
            if (context.Pets.Any()) return;

            var canil = new Canil { local = "Canil Central" };
            context.Canis.Add(canil);
            context.SaveChanges();

            var pets = new List<Pet>
            {
                new() { Nome = "Rex", Especie = "Cachorro", Raca = "SRD", Idade = 3, Sexo = "Macho", Vacinado = true, PCD = false, porte = "Grande", Descricao = "Muito brincalhão", CanilId = canil.id },

                new() { Nome = "Luna", Especie = "Gato", Raca = "Siamês", Idade = 2, Sexo = "Fêmea", Vacinado = true, PCD = false, porte = "Pequeno", Descricao = "Gosta de carinho", CanilId = canil.id },

                // Adicione mais 8 pets com dados variados

                new() { Nome = "Thor", Especie = "Cachorro", Raca = "Pitbull", Idade = 5, Sexo = "Macho", Vacinado = false, PCD = true, porte = "Grande", Descricao = "Precisa de cuidados especiais", CanilId = canil.id },

                new() { Nome = "Mimi", Especie = "Gato", Raca = "Persa", Idade = 1, Sexo = "Fêmea", Vacinado = true, PCD = false, porte = "Pequeno", Descricao = "Muito dócil", CanilId = canil.id },


                new() { Nome = "Bolinha", Especie = "Cachorro", Raca = "Poodle", Idade = 4, Sexo = "Macho", Vacinado = true, PCD = false, porte = "Médio", Descricao = "Adora passear", CanilId = canil.id },


                new() { Nome = "Tigre", Especie = "Gato", Raca = "Rajado", Idade = 2, Sexo = "Macho", Vacinado = false, PCD = false, porte = "Pequeno", Descricao = "Muito curioso", CanilId = canil.id },


                new() { Nome = "Lili", Especie = "Cachorro", Raca = "Beagle", Idade = 6, Sexo = "Fêmea", Vacinado = true, PCD = false, porte = "Médio", Descricao = "Inteligente", CanilId = canil.id },


                new() { Nome = "Nina", Especie = "Gato", Raca = "SRD", Idade = 3, Sexo = "Fêmea", Vacinado = true, PCD = false, porte = "Pequeno", Descricao = "Dorminhoca", CanilId = canil.id },


                new() { Nome = "Bob", Especie = "Cachorro", Raca = "Labrador", Idade = 7, Sexo = "Macho", Vacinado = true, PCD = false, porte = "Grande", Descricao = "Amigável com crianças", CanilId = canil.id },


                new() { Nome = "Pandora", Especie = "Gato", Raca = "Angorá", Idade = 4, Sexo = "Fêmea", Vacinado = true, PCD = true, porte = "Pequeno", Descricao = "Precisa de atenção médica", CanilId = canil.id }
            };

            context.Pets.AddRange(pets);
            context.SaveChanges();
        }
    }
}