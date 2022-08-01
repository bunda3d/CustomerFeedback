using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
	public class Survey
	{
		[Display(Name = "Survey ID")]
		public int Id { get; set; }

		[StringLength(100, ErrorMessage = "{0} length must be between {2} and {1} characters long.", MinimumLength = 6)]
		[Column(TypeName = "VARCHAR(100)")]
		public string Title { get; set; }

		[Column(TypeName = "VARCHAR(250)")]
		public string? Description { get; set; }

		[Display(Name = "Created")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:M/dd/yy}")]
		public DateTime CreatedDate { get; set; }

		[Display(Name = "Expires")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:M/dd/yy}")]
		public DateTime? ExpireDate { get; set; }

		[Display(Name = "Created By")]
		public int? AdministratorId { get; set; }

		[Display(Name = "Customer Type")]
		public int CustomerTypeId { get; set; }

		/// <summary>
		/// Navigation classes
		/// </summary>

		public virtual List<SurveyResponse>? SurveyResponses { get; set; }

		[InverseProperty("Survey")]
		public virtual ICollection<SurveyQuestion>? SurveyQuestions { get; set; }

		public virtual Administrator? Administrator { get; set; }
		public virtual CustomerType? CustomerType { get; set; }
	}
}