﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Moq;
using SD_340_W22SD_Final_Project_Group6.Models;

namespace SD_340_W22SD_Final_Project_Group6.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
            : base()
        {
        }
        public virtual DbSet<SD_340_W22SD_Final_Project_Group6.Models.Ticket> Tickets { get; set; }
        public virtual DbSet<SD_340_W22SD_Final_Project_Group6.Models.Project> Projects { get; set; }
        public virtual DbSet<SD_340_W22SD_Final_Project_Group6.Models.Comment> Comments { get; set; }
        public virtual DbSet<SD_340_W22SD_Final_Project_Group6.Models.UserProject> UserProjects { get; set; }
        public virtual DbSet<SD_340_W22SD_Final_Project_Group6.Models.TicketWatcher> TicketWatchers { get; set; }

    }

}