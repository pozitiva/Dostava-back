namespace DostavaHrane.Interfejsi
{
    public interface IUnitOfWork
    {
        IAdresaRepozitorijum AdresaRepozitorijum { get; }
        IMusterijaRepozitorijum MusterijaRepozitorijum { get; }
        IRestoranRepozitorijum RestoranRepozitorijum { get; }
        Task SaveChanges();

    }
}
