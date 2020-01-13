using System;
using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiContactSuppression
	{
		public ApiContact SuppressedContact
		{ get; set; }

		public DateTime DateRemoved
		{ get; set; }

		public ApiContactStatuses Reason
		{ get; set; }
	}
}
