using Dostava.Repozitorijumi.Interfejsi;
using Dostava.Repozitorijumi;
using Dostava.Data;

namespace Dostava.Podaci
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private readonly Lazy<IAdresaRepozitorijum> _adresaRepozitorijum;
        private readonly Lazy<IMusterijaRepozitorijum> _musterijaRepozitorijum;
        private readonly Lazy<INarudzbinaRepozitorijum> _narudzbinaRepozitorijum;
        private readonly Lazy<IRestoranRepozitorijum> _restoranRepozitorijum;
        private readonly Lazy<IDostavljacRepozitorijum> _dostavljacRepozitorijum;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            _adresaRepozitorijum = new Lazy<IAdresaRepozitorijum>(() => new AdresaRepozitorijum(_context));
            _musterijaRepozitorijum = new Lazy<IMusterijaRepozitorijum>(() => new MusterijaRepozitorijum(_context));
            _narudzbinaRepozitorijum = new Lazy<INarudzbinaRepozitorijum>(() => new NarudzbinaRepozitorijum(_context));
            _restoranRepozitorijum = new Lazy<IRestoranRepozitorijum>(() => new RestoranRepozitorijum(_context));
            _dostavljacRepozitorijum = new Lazy<IDostavljacRepozitorijum>(() => new DostavljacRepozitorijum(_context));
        }
        public IAdresaRepozitorijum AdresaRepozitorijum => _adresaRepozitorijum.Value;

        public IMusterijaRepozitorijum MusterijaRepozitorijum => _musterijaRepozitorijum.Value;

        public INarudzbinaRepozitorijum NarudzbinaRepozitorijum => _narudzbinaRepozitorijum.Value;

        public IRestoranRepozitorijum RestoranRepozitorijum => _restoranRepozitorijum.Value;

        public IDostavljacRepozitorijum DostavljacRepozitorijum => _dostavljacRepozitorijum.Value;

        public async Task SaveChanges() => await _context.SaveChangesAsync();


    }
}
