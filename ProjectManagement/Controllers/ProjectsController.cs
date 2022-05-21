﻿using Contracts;
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
        private ILoggerManager _logger;
        public ProjectsController(ILoggerManager logger)
        {
            _projectList = new List<Project>()
            {
                new Project() { Id = Guid.NewGuid(), Name ="Project1"},
                new Project() { Id = Guid.NewGuid(), Name="Project2"},
            };
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogInfo("Projects.Get() has been Run");
                return Ok(_projectList); 
            }
            catch (Exception ex )
            {

                _logger.LogError("Projects.Get() has been crashed" + ex.Message);
                throw;
            }
         
        }
    }
}
