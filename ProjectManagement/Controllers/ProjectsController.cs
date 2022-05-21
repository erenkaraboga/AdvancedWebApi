using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagement.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private List<Project> _projectList;
        public ProjectsController()
        {
            _projectList = new List<Project>()
            {
                new Project() { Id = Guid.NewGuid(), Name ="Project1"},
                new Project() { Id = Guid.NewGuid(), Name="Project2"},
            }; 
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_projectList);
        }
    }
}
