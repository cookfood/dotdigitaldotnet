using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiSplitTestResult
	{
		public string SubjectLine
		{ get; set; }

		public string FromName
		{ get; set; }

		public string FromAddress
		{ get; set; }

		public string HtmlContent
		{ get; set; }

		public string PlainTextContent
		{ get; set; }

		public string Version
		{ get; set; }

		public bool WinningVersion
		{ get; set; }

		public decimal ResultsActual
		{ get; set; }

		public decimal ResultsPercentage
		{ get; set; }
	}
}
