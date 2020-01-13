using System;
using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiPreference
	{
		public int Id
		{ get; set; }

		public string PublicName
		{ get; set; }

		public string PrivateName
		{ get; set; }

		public bool IsPreference
		{ get; set; }

		public string Order
		{ get; set; }

		public bool IsPublic
		{ get; set; }

		public int CategoryId
		{ get; set; }

		public int PreferenceCount
		{ get; set; }

		public DateTime Created
		{ get; set; }

		public DateTime LastModified
		{ get; set; }

		public bool? IsOptedIn
		{ get; set; }

		public List<ApiPreference> Preferences
		{ get; set; }

		public int OrderNumber
		{ get; set; }

		public int AddressBookId
		{ get; set; }
	}
}
