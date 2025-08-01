﻿using Dostava.Entiteti;

namespace Dostava.Servisi.Interfejsi
{
    public interface IJeloServis
    {
        Task<IEnumerable<Jelo>> VratiSvaJelaAsync();
        Task IzmeniJeloAsync(Jelo jelo);
        Task ObrisiJeloAsync(Jelo jelo);
        Task<Jelo> VratiJeloPoIdAsync(int jeloId);
        Task<IEnumerable<Jelo>> VratiSvaJelaPoRestoranu(int restoranId);
        Task DodajJeloAsync(Jelo jelo, IFormFile? slika);
    }
}
