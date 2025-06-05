using Dostava.Entiteti;

namespace Dostava.Repozitorijumi.Interfejsi
{
    public interface IAdminRepozitorijum : IRepozitorijum<Korisnik>
    {
        Task<Korisnik> VratiAdminaSaEmailom(Korisnik adminDto);
    }
}
