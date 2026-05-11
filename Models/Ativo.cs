namespace PetroAtivosSeuRA.Models
{
    public class Ativo
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }

        public string Localizacao { get; set; }

        public double CapacidadeProducao { get; set; }

        public DateTime DataUltimaInspecao { get; set; }

        public bool StatusOperacional { get; set; }
    }
}