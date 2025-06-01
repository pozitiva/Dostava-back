using Dostava.Dto;
using DostavaHrane.Entiteti;

namespace Dostava.Servisi.Interfejsi 
{ 
    public interface INarudzbinaServis
    {
        Task DodajNarudzbinuAsync(Narudzbina narudzbina);
        Task IzmeniNarudzbinuAsync(Narudzbina narudzbina);
        Task<bool> izmeniStatusNarudzbineAsync(NarudzbinaDto narudzbinaDto);
        Task<Narudzbina> VratiNarudzbinuPoIdAsync(int narudzbinaId);
        Task<IEnumerable<Narudzbina>> VratiSveNarudzbinePoRestoranu(int restoranId);

    }
}
