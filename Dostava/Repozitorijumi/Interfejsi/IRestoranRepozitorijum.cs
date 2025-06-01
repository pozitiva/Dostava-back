using Dostava.Entiteti;

namespace Dostava.Repozitorijumi.Interfejsi
{
    public interface IRestoranRepozitorijum : IRepozitorijum<Restoran>
    {
        Task<Restoran> VratiRestoranSaEmailom(Korisnik restoran);
        Task<IEnumerable<Jelo>> VratiSvaJelaPoRestoranuAsync(int restoranId);
        Task<IEnumerable<Restoran>> VratiSveAsync();
        Task<IEnumerable<Restoran>> PretraziRestorane(string naziv, string tip);
    }
}
