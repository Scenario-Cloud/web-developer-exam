using System.ComponentModel.DataAnnotations;

namespace ScenarioCloud.WebDeveloperExam.Business
{
  public class Document : Entity, IDocument
  {
    [StringLength(30)]
    public string DocumentNo { get; set; }
    [StringLength(150)]
    public string Subject { get; set; }
    public int ProjectId { get; set; }
    public int RegisterId { get; set; }
  }
}
