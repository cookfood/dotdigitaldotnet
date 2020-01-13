using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiAddressBook
	{
		public int Id
		{ get; set; }

		public string Name
		{ get; set; }

		public ApiAddressBookVisibility Visibility
		{ get; set; }

		public int Contacts
		{ get; set; }
	}
}
