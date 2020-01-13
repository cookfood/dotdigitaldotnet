using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiSurveyPage
	{
		public int Id
		{ get; set; }

		public string Name
		{ get; set; }

		public ApiSurveyFieldList Fields
		{ get; set; }
	}
}
