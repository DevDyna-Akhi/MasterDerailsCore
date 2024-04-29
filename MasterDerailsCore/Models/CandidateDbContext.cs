using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MasterDerailsCore.Models
{
    public class CandidateDbContext:DbContext
    {
        public CandidateDbContext(DbContextOptions<CandidateDbContext> options) : base(options) { }
        public DbSet<Candidate> candidates { get; set; }
        public DbSet<Experiance> experiances { get; set; }
    }
}
