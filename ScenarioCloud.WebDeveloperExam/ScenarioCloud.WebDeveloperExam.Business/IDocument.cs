namespace ScenarioCloud.WebDeveloperExam.Business
{
  public interface IDocument : IEntity
  {
    string DocumentNo { get; set; }
    string Subject { get; set; }
    int ProjectId { get; set; }
    int RegisterId { get; set; }
  }
}
