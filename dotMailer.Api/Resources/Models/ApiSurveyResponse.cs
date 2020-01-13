using System;
using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiSurveyResponse
	{
		public int Id
		{ get; set; }

		public string Email
		{ get; set; }

		public bool Started
		{ get; set; }

		public DateTime? DateStarted
		{ get; set; }

		public bool Complete
		{ get; set; }

		public DateTime? DateCompleted
		{ get; set; }

		public ApiSurveyGivenAnswerList GivenAnswers
		{ get; set; }
	}
}
