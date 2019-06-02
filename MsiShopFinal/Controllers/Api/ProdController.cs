using AutoMapper;
using MsiShopFinal.Dtos;
using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MsiShopFinal.Controllers.API
{
    public class ProdController : ApiController
    {
        private ApplicationDbContext _context;
        public ProdController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/prod
        public IEnumerable<ProdsDto> GetProds()
        {
            return _context.Prod.ToList().Select(Mapper.Map<Prods, ProdsDto>);
        }

        // GET /api/prod/1
        public IHttpActionResult GetProd(int id)
        {
            var prod = _context.Prod.SingleOrDefault();

            if (prod == null)
                return NotFound();

            return Ok(Mapper.Map<Prods, ProdsDto>(prod));
        }

        // POST /api/prods
        [HttpPost]
        public IHttpActionResult CreateProd(ProdsDto prodsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var prods = Mapper.Map<ProdsDto, Prods>(prodsDto);
            _context.Prod.Add(prods);
            _context.SaveChanges();

            prodsDto.SerialNumber = prods.SerialNumber;
            return Created(new Uri(Request.RequestUri + "/" + prods.SerialNumber), prodsDto);
        }

        // PUT /api/prods/1
        [HttpPut]
        public IHttpActionResult UpdateProd(int id, ProdsDto prodsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var prodInDb = _context.Prod.SingleOrDefault();

            if (prodInDb == null)
                return NotFound();
            Mapper.Map(prodsDto, prodInDb);

            _context.SaveChanges();
            return Ok();
        }

        // DELETE /api/prods/1
        [HttpDelete]
        public IHttpActionResult DeleteProd(int id)
        {
            var prodInDb = _context.Prod.SingleOrDefault();

            if (prodInDb == null)
                return NotFound();

            _context.Prod.Remove(prodInDb);
            _context.SaveChanges();


            return Ok();
        }
    }
}