﻿using Dostava.Entiteti;
using Dostava.Repozitorijumi.Interfejsi;
using Dostava.Servisi.Interfejsi;

namespace Dostava.Servisi
{
    public class JeloServis : IJeloServis
    {
        private readonly IUnitOfWork uow;

        public JeloServis(IUnitOfWork unitOfWork)
        {
            uow= unitOfWork;
        }


        public async Task DodajJeloAsync(Jelo jelo, IFormFile? slika)
        {
            await  SacuvajSliku(slika, jelo);

            await uow.JeloRepozitorijum.DodajAsync(jelo);

            await uow.SaveChanges();
        }

        private async Task SacuvajSliku(IFormFile? slika, Jelo jelo)
        {
           
            if (slika != null && slika.Length != 0)
                {
                    var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..",  "DostavaHrane.InfrastrukturniSloj", "Podaci", "static", "slike", "jela"));
                    var path = Path.Combine(basePath, jelo.RestoranId + "_" + jelo.Naziv + ".jpg");

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await slika.CopyToAsync(stream);
                    }

                    jelo.SlikaUrl = "/static/slike/jela/" + jelo.RestoranId + "_" + jelo.Naziv + ".jpg";
             }
            

        }

        public async Task IzmeniJeloAsync(Jelo jelo)
        {
            await uow.JeloRepozitorijum.IzmeniAsync(jelo);
            await uow.SaveChanges();
        }

        public async Task ObrisiJeloAsync(Jelo jelo)
        {
            await uow.JeloRepozitorijum.ObrisiAsync(jelo);
            await uow.SaveChanges();
        }

        public async Task<Jelo> VratiJeloPoIdAsync(int jeloId)
        {
            return await uow.JeloRepozitorijum.VratiPoIdAsync(jeloId);
        }

        public async Task<IEnumerable<Jelo>> VratiSvaJelaAsync()
        {
            return await uow.JeloRepozitorijum.VratiSveAsync();
        }

        public async Task<IEnumerable<Jelo>> VratiSvaJelaPoRestoranu(int restoranId)
        {
           return await uow.JeloRepozitorijum.VratiSvaJelaPoRestoranu(restoranId);
        }

    }
}
