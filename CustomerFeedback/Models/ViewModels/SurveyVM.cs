using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerFeedback.Models.ViewModels
{
	public class SurveyVM
	{
		//Survey Index Filtering form

		public List<Survey>? Surveys { get; set; }
		public SelectList? CustomerTypes { get; set; }
		public string? SurveyCustomerType { get; set; }
		public string? SearchString { get; set; }

		//Survey Create & Edit Forms DDLs
		
		public List<Administrator>? Administrators { get; set; }
		
		public SelectList? CustomerTypeIdDDL { get; set; }
		public string? SelectedCustomerType { get; set; }



		//Survey Detail & Delete pgs

		public Survey? Survey { get; set; }
		public Administrator? Administrator { get; set; }
		public CustomerType? CustomerType { get; set; }

		public string? CustomerTypeAndDescription
		{ get { return $"{CustomerType?.Type} - {CustomerType?.Description}"; } }
	}
}