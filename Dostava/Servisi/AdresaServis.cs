using Dostava.Repozitorijumi.Interfejsi;
using Dostava.Servisi.Interfejsi;
using DostavaHrane.Entiteti;

namespace Dostava.Servisi
{
    public class AdresaServis : IAdresaServis
    {
        private readonly IUnitOfWork uow;

        public AdresaServis(IUnitOfWork unitOfWork)
        {
            uow=unitOfWork;
        }
        public async Task DodajAdresuAsync(Adresa adresa)
        {
            await uow.AdresaRepozitorijum.DodajAsync(adresa);
            await uow.SaveChanges();
        }

        public async Task IzmeniAdresuAsync(Adresa adresa)
        {
            await uow.AdresaRepozitorijum.IzmeniAsync(adresa);
            await uow.SaveChanges();
        }

 

        public async Task<Adresa> VratiAdresuPoIdAsync(int adresaId)
        {
            return await uow.AdresaRepozitorijum.VratiPoIdAsync(adresaId);
        }

        public async Task<IEnumerable<Adresa>> VratiSveAdreseZaMusteriju(int musterijaId)
        {
            return await uow.AdresaRepozitorijum.VratiSveAdreseZaMusteriju(musterijaId);
        }
    }
}
