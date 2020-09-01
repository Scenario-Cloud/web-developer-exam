using ScenarioCloud.WebDeveloperExam.Business;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ScenarioCloud.WebDeveloperExam.Web.Api
{
  public class ScenarioApiController<T> : ApiController, IScenarioApiController<T> where T : class, IEntity
  {
    public virtual T Get(int id)
    {
      throw new NotImplementedException();
    }

    public virtual IEnumerable<T> GetAll()
    {
      throw new NotImplementedException();
    }

    public virtual bool Remove(T item)
    {
      throw new NotImplementedException();
    }

    public virtual bool RemoveRange(IEnumerable<T> item)
    {
      throw new NotImplementedException();
    }

    public virtual T Save(T item)
    {
      throw new NotImplementedException();
    }
  }
}