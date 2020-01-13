using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiContactWithConsentAndPreferences
	{
		public ApiPreferenceList Preferences
		{ get; set; }

		public ApiContact Contact
		{ get; set; }

		public ApiConsentList ConsentFields
		{ get; set; }
	}
}
