using Microsoft.AspNetCore.Mvc.Rendering;
using CustomerFeedback.Models;
using System.Collections.Generic;

namespace CustomerFeedback.Models.ViewModels
{
	public class SurveyVM
	{
		public List<Survey>? Surveys { get; set; }
		public SelectList? CustomerTypes { get; set; }
		public string? SurveyCustomerType { get; set; }
		public string? SearchString { get; set; }
	}
}