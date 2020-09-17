using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tech_oasis_backend.Model
{
    public class ProfileContext: DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options)
            : base(options)
        { }
        public DbSet<Profile> Profiles { get; set; }
    }
}
