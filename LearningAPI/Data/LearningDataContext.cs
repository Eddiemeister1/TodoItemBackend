using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningAPI.Data
{
    public class LearningDataContext : DbContext
    {
        public LearningDataContext(DbContextOptions<LearningDataContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
