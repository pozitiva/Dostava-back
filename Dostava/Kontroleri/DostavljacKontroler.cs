﻿using AutoMapper;
using Dostava.Dto;
using Dostava.Entiteti;
using Dostava.Servisi.Interfejsi;
using Microsoft.AspNetCore.Mvc;

namespace Dostava.Kontroleri
{
    [Route("api/dostavljac")]
    [ApiController]
    public class DostavljacKontroler:ControllerBase
    {
        private readonly IDostavljacServis _dostavljacServis;
        private readonly IMapper _mapper;
        public DostavljacKontroler(IDostavljacServis dostavljacServis, IMapper mapper)
        {
            _dostavljacServis = dostavljacServis;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> KreirajDostavljaca(DostavljacDto dostavljacDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dostavljac = _mapper.Map<Dostavljac>(dostavljacDto);

            string rezultat = await _dostavljacServis.KreirajDostavljaca(dostavljac);

            return Ok("Dostavljac je uspesno kreiran");
        }


        [HttpGet]
        public async Task<IActionResult> VratiSveDostavljace()
        {
            //int musterijaId = Convert.ToInt32(User.Claims.ElementAt(0).Value);

            var dostavljaci = await _dostavljacServis.VratiSveDostavljaceAsync();
            var dostavljaciDto = _mapper.Map<List<DostavljacDto>>(dostavljaci);

            return Ok(dostavljaciDto);
        }

    }
}
