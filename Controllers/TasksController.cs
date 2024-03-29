﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]

        public IActionResult Tasks()
        {
            var tasks = new string[] { "Task 1", "task 2", "Task3" ,"Task 5"};
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTasks()
        {
            
            return Ok();
        }



        [HttpPut]
        public IActionResult UpdateTasks()
        {

            return Ok();
        }


        [HttpDelete]
        public IActionResult DeleteTasks()
        {
            var somethingWentWrong = true;
            if (somethingWentWrong)
                return BadRequest(); 
            return Ok();
        }
    }
}

