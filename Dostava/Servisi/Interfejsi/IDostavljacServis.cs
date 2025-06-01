using Dostava.Entiteti;

namespace Dostava.Servisi.Interfejsi
{
    public interface IDostavljacServis
    {
        Task AžurirajDostavljacaAsync(Dostavljac dostavljac);
        Task<string> KreirajDostavljaca(Dostavljac dostavljacDto);
        Task<Dostavljac> VratiDostavljacaPoIdAsync(int? dostavljacId);
        Task<Dostavljac> VratiSlobodnogDostavljacaAsync();
        Task<IEnumerable<Dostavljac>> VratiSveDostavljaceAsync();
    }
}
