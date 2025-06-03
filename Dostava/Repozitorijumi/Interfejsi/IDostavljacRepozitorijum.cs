using Dostava.Entiteti;

namespace Dostava.Repozitorijumi.Interfejsi
{
    public interface IDostavljacRepozitorijum : IRepozitorijum<Dostavljac>
    {
        Task AzurirajDostavljacaAsync(Dostavljac dostavljac);
        Task<Dostavljac> VratiDostavljacaPoIdAsync(int? dostavljacId);
        Task<Dostavljac> VratiSlobodnogDostavljacaAsync();
    }
}
