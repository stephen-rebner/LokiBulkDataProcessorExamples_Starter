using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkDataProcessorExamples.EntityFramework;
using BulkDataProcessorExamples.Models;
using Microsoft.AspNetCore.Mvc;

namespace LokiBulkDataProcessorExamples.Controllers
{
    [ApiController]
    public class BullkProcessorController : Controller
    {
        private BlogDbContext _dbContext;

        public BullkProcessorController(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private async Task<Blog> CreateBlog(string url)
        {
            var blog = new Blog() { Url = url };
            _dbContext.Add(blog);
            await _dbContext.SaveChangesAsync();

            return blog;
        }
    }
}