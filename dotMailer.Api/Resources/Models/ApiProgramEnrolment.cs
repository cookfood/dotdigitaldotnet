using System;
using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiProgramEnrolment
	{
		public Guid ID
		{ get; set; }

		public int ProgramId
		{ get; set; }

		public ApiProgramEnrolmentStatus Status
		{ get; set; }

		public DateTime DateCreated
		{ get; set; }

		public List<int> Contacts
		{ get; set; }

		public List<int> AddressBooks
		{ get; set; }
	}
}
