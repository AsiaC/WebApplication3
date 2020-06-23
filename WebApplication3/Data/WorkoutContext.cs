using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

    public class WorkoutContext : DbContext
    {
        public WorkoutContext (DbContextOptions<WorkoutContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Workout> Workout { get; set; }
    }
