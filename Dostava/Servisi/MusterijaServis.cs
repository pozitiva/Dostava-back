﻿using AutoMapper;
using Dostava.Entiteti;
using Dostava.Repozitorijumi.Interfejsi;
using Dostava.Servisi.Interfejsi;



namespace Dostava.Servisi
{
    public class MusterijaServis : IMusterijaServis
    {

        private readonly IUnitOfWork uow;
        private readonly IMapper _mapper;
        public MusterijaServis(IUnitOfWork unitOfWork, IMapper mapper)
        {
            uow= unitOfWork;
            _mapper= mapper;
        }

        public Task<Musterija> DodajMusterijuAsync()
        {
            throw new NotImplementedException();
        }

        public async Task IzmeniMusterijuAsync(Musterija musterija)
        {

            await uow.MusterijaRepozitorijum.IzmeniAsync(musterija);
            await uow.SaveChanges();

        }

        public Task ObrisiMusterijuAsync()
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<Musterija>> VratiSveMusterijaAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Musterija> VratiMusterijuPoIdAsync(int id)
        {
            return await uow.MusterijaRepozitorijum.VratiPoIdAsync(id);
        }


        public async Task<IEnumerable<Adresa>> VratiSveAdresePoMusterijiAsync(int id)
        {
            return await uow.MusterijaRepozitorijum.VratiSveAdresePoMusterijiAsync(id);
        }

    }
}
