﻿using Dostava.Entiteti;
using System.Text.Json.Serialization;

namespace Dostava.Entiteti

{
    public class StavkaNarudzbine
    {
        public int Kolicina { get; set; }

        public int JeloId { get; set; }
        public int NarudzbinaId { get; set; }
        public Jelo Jelo { get; set; }
        [JsonIgnore]
        public Narudzbina Narudzbina { get; set; }
    }
}
