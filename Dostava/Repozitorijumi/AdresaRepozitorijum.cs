﻿using Dostava.Data;
using Dostava.Entiteti;
using Dostava.Repozitorijumi.Interfejsi;
using Microsoft.EntityFrameworkCore;

namespace Dostava.Repozitorijumi
{
    public class AdresaRepozitorijum:IAdresaRepozitorijum
    {

        private readonly DataContext _context;

        public AdresaRepozitorijum(DataContext context)
        {
            _context = context;

        }

        public async Task DodajAsync(Adresa adresa)
        {
            await _context.Adrese.AddAsync(adresa);
            
        }

        public async Task ObrisiAsync(Adresa adresa)
        {
            _context.Adrese.Remove(adresa);
           
        }

        public async Task<Adresa> VratiPoIdAsync(int id)
        {
            return await _context.Set<Adresa>().FindAsync(id);
        }

        public async Task IzmeniAsync(Adresa adresa)
        {
            _context.Adrese.Update(adresa);
           
        }

        public async Task<IEnumerable<Adresa>> VratiSveAdreseZaMusteriju(int musterijaId)
        {
            return await _context.Adrese
                      .Where(n => n.MusterijaId == musterijaId)
                      .ToListAsync();
        }

        public Task<IEnumerable<Adresa>> VratiSveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
