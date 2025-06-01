using DostavaHrane.Data;
using DostavaHrane.Interfejsi;
using DostavaHrane.Repozitorijum;
using Microsoft.EntityFrameworkCore.Storage;

namespace DostavaHrane.InfrastrukturniSloj.Podaci
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private readonly Lazy<IAdresaRepozitorijum> _adresaRepozitorijum;
        private readonly Lazy<IMusterijaRepozitorijum> _musterijaRepozitorijum;
        private readonly Lazy<IRestoranRepozitorijum> _restoranRepozitorijum;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            _adresaRepozitorijum = new Lazy<IAdresaRepozitorijum>(() => new AdresaRepozitorijum(_context));
            _musterijaRepozitorijum = new Lazy<IMusterijaRepozitorijum>(() => new MusterijaRepozitorijum(_context));
            _restoranRepozitorijum = new Lazy<IRestoranRepozitorijum>(() => new RestoranRepozitorijum(_context));
            
        }
        public IAdresaRepozitorijum AdresaRepozitorijum => _adresaRepozitorijum.Value;

        public IMusterijaRepozitorijum MusterijaRepozitorijum => _musterijaRepozitorijum.Value;

        public IRestoranRepozitorijum RestoranRepozitorijum => _restoranRepozitorijum.Value;

        public async Task SaveChanges() => await _context.SaveChangesAsync();


    }
}
