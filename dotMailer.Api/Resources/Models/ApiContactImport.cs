using System;
using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiContactImport
	{
		public Guid Id
		{ get; set; }

		public ApiContactImportStatuses Status
		{ get; set; }
	}
}
