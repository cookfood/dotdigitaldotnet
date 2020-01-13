using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiContactResubscription
	{
		public ApiContact UnsubscribedContact
		{ get; set; }

		public string PreferredLocale
		{ get; set; }

		public string ReturnUrlToUseIfChallenged
		{ get; set; }
	}
}
