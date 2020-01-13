using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiContact
	{
		public int Id
		{ get; set; }

		public string Email
		{ get; set; }

		public ApiContactOptInTypes? OptInType
		{ get; set; }

		public ApiContactEmailTypes? EmailType
		{ get; set; }

		public ApiContactDataList DataFields
		{ get; set; }

		public ApiContactStatuses Status
		{ get; set; }
	}
}
