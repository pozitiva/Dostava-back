﻿using System.Text.Json.Serialization;

namespace Dostava.Entiteti
{
    public class Narudzbina
    {
        public int Id { get; set; }
        public DateTime DatumNarudzbine { get; set; }
        public string Status { get; set; } 
        public decimal UkupnaCena { get; set; }
        public Dostavljac? Dostavljac { get; set; }
        public int? DostavljacId { get; set; }
        public Restoran Restoran { get; set; } 
        public int RestoranId { get; set; }
        public Adresa Adresa { get; set; }
        public int AdresaId { get; set; }
        [JsonIgnore]
        public Musterija Musterija { get; set; }
        public int MusterijaId { get; set; }
        public ICollection<StavkaNarudzbine> StavkeNarudzbine { get; set; }

        public DateTime? VremeDostave { get; set; }
        public DateTime? VremeOtkazivanja { get; set; }
    }
}
