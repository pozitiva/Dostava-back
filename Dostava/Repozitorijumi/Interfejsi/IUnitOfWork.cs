namespace Dostava.Repozitorijumi.Interfejsi
{
    public interface IUnitOfWork
    {
        IAdresaRepozitorijum AdresaRepozitorijum { get; }
        IMusterijaRepozitorijum MusterijaRepozitorijum { get; }
        IRestoranRepozitorijum RestoranRepozitorijum { get; }
        INarudzbinaRepozitorijum NarudzbinaRepozitorijum { get; }

        IDostavljacRepozitorijum DostavljacRepozitorijum { get; }
        Task SaveChanges();

    }
}
