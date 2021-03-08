using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _context;

        public UserController(UserDbContext context)
        {
            _context = context;
        }
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult Get()
        {

            return Ok(_context.User);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            User user = _context.User.Where(x => x.Id == id).FirstOrDefault();
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return Ok("Esse usuario não existe");
            }
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();

            return Ok("Usuario inserido com sucesso");


        }

        // PUT api/<UserController>/5
        [HttpPut]
        public ActionResult Put([FromBody] User user)
        {
            _context.User.Update(user);
            _context.SaveChanges();
            return Ok("Usuario salvo com sucesso");
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            User user = _context.User.Where(x => x.Id == id).FirstOrDefault();
            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
                return Ok("Usuario Removido com sucesso!!");
            }
            else
            {
                return Ok("Esse usuario não existe");
            }


        }
    }
}
