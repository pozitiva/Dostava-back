﻿using DostavaHrane.Dto;
using System.ComponentModel.DataAnnotations;

namespace Dostava.Dto
{
    public class RestoranDto
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public string SlikaUrl { get; set; }
        public string Email { get; set; }
        public ICollection<JeloDto> Jela { get; set; }

    }
}
