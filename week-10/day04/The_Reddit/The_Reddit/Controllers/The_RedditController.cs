﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Reddit.Models;
using The_Reddit.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace The_Reddit.Controllers
{
    [Route("")]
    public class The_RedditController : Controller
    {
        private The_RedditRepository the_RedditRepository;

        public The_RedditController(The_RedditRepository the_RedditRepository)
        {
            this.the_RedditRepository = the_RedditRepository;
        }

        [HttpGet("posts")]
        public IActionResult ShowList()
        {
            return Json(new { posts = the_RedditRepository.GetList() });
        }

        [HttpPost("posts")]
        public IActionResult Add([FromBody]Post post)
        {
            the_RedditRepository.AddPost(post);
            return Json(the_RedditRepository.GetAPost());
        }

        [HttpPost("posts/{name}")]
        public IActionResult AddPostAndUser([FromBody]Post post, [FromQuery]string Name)
        {
            the_RedditRepository.AddPostWithUsers(post, Name);
            return Json(the_RedditRepository.GetAPost());
        }
    }
}
