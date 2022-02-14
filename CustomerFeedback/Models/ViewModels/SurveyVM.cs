using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerFeedback.Models.ViewModels
{
  public class SurveyVM
  {
    public List<Survey>? Surveys { get; set; }
    public List<Administrator>? Administrators { get; set; }
    public SelectList? CustomerTypes { get; set; }
    public string? SurveyCustomerType { get; set; }
    public string? SurveyAdministrator { get; set; }
    public string? SearchString { get; set; }

    public SelectList? SurveyAdministrators { get; set; }
  }
}