using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Owner.API.Model;
using Owner.API.Data;
using System.Linq;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {

        [Route("All")]
        [HttpGet]
        public List<OwnerModel> GetAllOwners()
        {
            var temps = new TempDB().GetOwnerModels();
            return temps;

        }

        [HttpPost]
        [Route("IsThereHackInExp")]
        public IActionResult IsThereHack()
        {
            var temps = new TempDB().GetOwnerModels();

            for (int i=0; i < temps.Count; i++)
            {
                if (temps[i].Explanation.Contains("Hack")){
                    return NotFound($"Is there a hack word in explanation. Owners id = {temps[i].Id}!!");
                }
            }
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteBy{id}")]
        public IActionResult DeleteOwner(int id)
        {
            var temps = new TempDB().GetOwnerModels();
            var owner = temps.FirstOrDefault(x => x.Id == id);
            if (owner == null)
                return NotFound();
            temps.Remove(owner);
                return Ok(temps);
        }

        [HttpPut]
        [Route("UpdateBy{id}")]
        public IActionResult UpdateOwners(int id, OwnerModel owner)
        {
            var temps = new TempDB().GetOwnerModels();
            if (id != owner.Id)
                return BadRequest("ID's does not match");
            for(int i = 0; i < temps.Count; i++)
            {
                if(temps[i].Id == id)
                {
                    temps[i].Name = owner.Name;
                    temps[i].Surname = owner.Surname;
                    temps[i].Date = owner.Date;
                    temps[i].Explanation = owner.Explanation;
                    temps[i].Type = owner.Type;
                }
            }
            return Ok(temps);
        }
    }
}
