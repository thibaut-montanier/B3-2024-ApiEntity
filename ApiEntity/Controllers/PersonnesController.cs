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
        public List<PersonneGetVM> Get() {

            return context.Personnes
                .Select(p => 
                    new PersonneGetVM {
                        Nom = p.Name,
                        FirstName = p.Prenom,
                        Cours = p.Cours.Select(c=>c.Cours.Name).ToList()
                        
                    })
                .ToList();

        }

        public class PersonneGetVM {
            public string Nom { get; set; }
            public string FirstName { get; set; }

            public List<string> Cours { get; set; }
        }

            [HttpPost]
            public void Create(string prenom, string nom, string cours) {

                var p = new Personne {
                    Prenom = prenom,
                    Name = nom,
                    Cours = new List<ParticipeCours> {
                   new ParticipeCours {
                        Cours = new Cours{ Name = cours }
                    }

                }
                };
                context.Add(p);
                context.SaveChanges();

            }

        }

        
    }
