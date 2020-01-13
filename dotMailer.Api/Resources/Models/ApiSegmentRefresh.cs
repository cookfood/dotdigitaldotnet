using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiSegmentRefresh
	{
		public int Id
		{ get; set; }

		public ApiSegmentRefreshStatuses Status
		{ get; set; }
	}
}
