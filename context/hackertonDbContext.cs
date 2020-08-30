using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group2.context
{
    public class hackertonDbContext:DbContext

    {
        public hackertonDbContext(DbContextOptions<hackertonDbContext> options) : base(options)
        {

        }
        public DbSet<Group2.Models.categories> Categories { get; set; }
        public DbSet<Group2.Models.Doc_Res> doc_Res { get; set; }
        public DbSet<Group2.Models.roles> roles { get; set; }
        public DbSet<Group2.Models.UserDetails> userDetails { get; set; }
        public DbSet<Group2.Models.Users> Users { get; set; }
    }
}
