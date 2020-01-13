using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiSplitTestSendOptions
	{
		public ApiSplitTestMetrics TestMetric
		{ get; set; }

		public int TestPercentage
		{ get; set; }

		public int TestPeriodHours
		{ get; set; }
	}
}
