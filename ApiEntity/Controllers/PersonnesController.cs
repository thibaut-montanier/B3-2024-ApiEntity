using ApiEntity.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEntity.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnesController : ControllerBase {
        private readonly VoyageDbContext context;

        public PersonnesController(VoyageDbContext context) {
            this.context = context;
            this.context.Database.Migrate();
        }

        [HttpGet] 
        public List<Personne> Get() {

            return context.Personnes.ToList();

        }



        
    }
}
