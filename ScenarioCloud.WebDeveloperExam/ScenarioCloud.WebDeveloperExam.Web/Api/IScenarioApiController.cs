using ScenarioCloud.WebDeveloperExam.Business;
using System.Collections.Generic;

namespace ScenarioCloud.WebDeveloperExam.Web.Api
{
  public interface IScenarioApiController<T> where T : class, IEntity
  {
    IEnumerable<T> GetAll();
    T Get(int id);
    T Save(T item);
    bool Remove(T item);
    bool RemoveRange(IEnumerable<T> item);
  }
}
