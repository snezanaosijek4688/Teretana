using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KorisnikController


    {

        private readonly TeretanaContext _contex;



        public KorisnikController(TeretanaContext contex) { _contex = contex; }
        [HttpGet]

        public IActionResult Get()
        {
            return new JsonResult(_contex.Korisnici.ToList());
        }

        [HttpPost]
        public IActionResult Post(Korisnik korisnik)
        {
            _contex.Korisnici.Add(korisnik);
            _contex.SaveChanges();


            return new JsonResult(korisnik);
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]

        public IActionResult Delete(int sifra)
        {
            var SmjerIzBaze = _contex.Korisnici.Find(sifra);

            _contex.Korisnici.Remove(SmjerIzBaze);
            _contex.SaveChanges();
            return new JsonResult(new { poruka = "obrisano" });


        }
        [HttpPut]
        [Route("{id:int}")]


        public IActionResult Put(int sifra, Korisnik korisnik)
        {
            var SmjerIzBaze = _contex.Korisnici.Find(sifra);
            SmjerIzBaze.Ime = korisnik.Ime;
           

            _contex.Korisnici.Update(SmjerIzBaze);
            _contex.SaveChanges();


            return new JsonResult(SmjerIzBaze);
        }




    }
}
