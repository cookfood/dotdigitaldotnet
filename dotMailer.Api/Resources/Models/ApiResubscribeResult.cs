using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiResubscribeResult
	{
		public ApiContact Contact
		{ get; set; }

		public ApiResubscribeStatuses Status
		{ get; set; }
	}
}
