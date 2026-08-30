using Microsoft.EntityFrameworkCore;

namespace PractiveWebPages.Models
{
    public class PracticeDBContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public PracticeDBContext(Microsoft.EntityFrameworkCore.DbContextOptions<PracticeDBContext> options) : base(options)
        {

        }

        public DbSet<AdditionModel> AdditionModels { get; set; }

    }
}

