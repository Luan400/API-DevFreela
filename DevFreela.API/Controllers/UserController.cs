using DevFreela.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DevFreela.API.Controllers
   
{
    // criar referencia de url
    [Route("api/users")]

    public class UserController : ControllerBase
    {


        public UserController(ExempleClass exempleClass)
        {
            

        }



        //cadastro do usuario
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            return Ok();
        }


        //consulta do usuario
        [HttpPost]
       public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        //api/users/1/login
        [HttpPut("{id}/login")]

        public IActionResult Login(int id, [FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
