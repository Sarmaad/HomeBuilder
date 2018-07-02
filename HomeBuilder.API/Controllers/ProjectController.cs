using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeBuilder.API.Models;
using HomeBuilder.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeBuilder.API.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class ProjectController : Controller
    {
        // TODO: remove this please!!
        public static List<Project> projects;

        public ProjectController()
        {
            projects = projects ?? new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Number = 1,
                    Address = "123 Some Street, Sydney, NSW 2001",
                },
                new Project
                {
                    Id = 2,
                    Number = 2,
                    Address = "22 George Street, Sydney, NSW 2001",
                }
            };


        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Projects()
        {
            return Accepted(projects);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Projects([FromBody]NewProject model)
        {
            //TODO: validate the model
            //TODO: save the project to the database
            
            var project = new Project
            {
                Number = model.Number,
                Address = model.Address
            };

            projects.Add(project);

            return Accepted(project);
        }
    }
}