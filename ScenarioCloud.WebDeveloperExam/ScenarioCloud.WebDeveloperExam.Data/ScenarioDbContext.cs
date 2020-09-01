using ScenarioCloud.WebDeveloperExam.Business;
using System.Data.Entity;

namespace ScenarioCloud.WebDeveloperExam.Data
{
  public class ScenarioDbContext : DbContext, IScenarioDbContext
  {
    public DbSet<Document> Documents { get; set; }
  }
}
