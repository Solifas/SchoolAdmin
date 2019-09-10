using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAdminSystem.Models;

namespace SchoolAdminSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private DataAccessLayer teacherDataAccessLayer = null;

        public TeacherController()
        {
            teacherDataAccessLayer = new DataAccessLayer();
        }


        // GET: api/Teacher
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {

           return teacherDataAccessLayer.GetAllTeachers().ToList();
        }

        // GET: api/Teacher/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Teacher
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Teacher/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
