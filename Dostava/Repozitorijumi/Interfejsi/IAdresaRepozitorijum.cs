using Dostava.Entiteti;

namespace Dostava.Repozitorijumi.Interfejsi
{
    public interface IAdresaRepozitorijum : IRepozitorijum<Adresa>
    {
        Task<IEnumerable<Adresa>> VratiSveAdreseZaMusteriju(int musterijaId);
    }
}
