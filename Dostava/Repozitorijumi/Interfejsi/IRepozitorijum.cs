﻿namespace Dostava.Repozitorijumi.Interfejsi
{
    public interface IRepozitorijum<T> where T : class
    {
        Task<T> VratiPoIdAsync(int id);
        Task DodajAsync(T entity);
        Task IzmeniAsync(T entity);
        Task ObrisiAsync(T entity);
        Task<IEnumerable<T>> VratiSveAsync();
    }
}
