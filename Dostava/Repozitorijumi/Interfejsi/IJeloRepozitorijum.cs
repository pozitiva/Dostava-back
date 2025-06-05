using Dostava.Entiteti;

namespace Dostava.Repozitorijumi.Interfejsi
{
    public interface IJeloRepozitorijum : IRepozitorijum<Jelo>
    {
        Task<IEnumerable<Jelo>> VratiSvaJelaPoRestoranu(int restoranId);
        Task<IEnumerable<Jelo>> VratiSveAsync();
    }
}
