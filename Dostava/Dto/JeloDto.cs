﻿using System.ComponentModel.DataAnnotations;

namespace Dostava.Dto
{
    public class JeloDto
    {
        [Required]
        public string Naziv { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Cena { get; set; }
        [Required]
        public string TipJela { get; set; }
        
        public int RestoranId { get; set; }
        public int Id { get; set; }
        public string Opis { get; set; }

        public string? SlikaUrl { get; set; }

    }
}
