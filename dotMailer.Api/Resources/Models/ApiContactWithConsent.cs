using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiContactWithConsent
	{
		public ApiContact Contact
		{ get; set; }

		public ApiConsentList ConsentFields
		{ get; set; }
	}
}
