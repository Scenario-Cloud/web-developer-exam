using ScenarioCloud.WebDeveloperExam.Business;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ScenarioCloud.WebDeveloperExam.Data
{
  public interface IScenarioDbContext
  {
    DbSet<Document> Documents { get; set; }

    int SaveChanges();
    Task<int> SaveChangesAsync();
  }
}
