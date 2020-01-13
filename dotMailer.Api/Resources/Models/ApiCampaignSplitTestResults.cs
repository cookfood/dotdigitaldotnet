using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiCampaignSplitTestResults
	{
		public ApiSplitTestResultList Versions
		{ get; set; }

		public ApiSplitTestMetrics SplitTestWinnerMetric
		{ get; set; }
	}
}
