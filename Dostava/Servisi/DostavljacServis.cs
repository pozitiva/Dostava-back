using Dostava.Entiteti;
using Dostava.Repozitorijumi.Interfejsi;
using Dostava.Servisi.Interfejsi;

namespace Dostava.Servisi
{
    public class DostavljacServis : IDostavljacServis
    {
        private readonly IUnitOfWork uow;

        public DostavljacServis(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;

        }
        public async Task AžurirajDostavljacaAsync(Dostavljac dostavljac)
        {
            await uow.DostavljacRepozitorijum.AzurirajDostavljacaAsync(dostavljac);
            await uow.SaveChanges();

        }

        public async Task<string> KreirajDostavljaca(Dostavljac dostavljac)
        {
            await uow.DostavljacRepozitorijum.DodajAsync(dostavljac);
            await uow.SaveChanges();
            return "Uspesna registracija";
        }

        public async Task<Dostavljac> VratiDostavljacaPoIdAsync(int? dostavljacId)
        {
            return await uow.DostavljacRepozitorijum.VratiDostavljacaPoIdAsync(dostavljacId);
        }

        public async Task<Dostavljac> VratiSlobodnogDostavljacaAsync()
        {
            return await uow.DostavljacRepozitorijum.VratiSlobodnogDostavljacaAsync();
        }

        public async Task<IEnumerable<Dostavljac>> VratiSveDostavljaceAsync()
        {
            return await uow.DostavljacRepozitorijum.VratiSveAsync();
        }
    }
}
