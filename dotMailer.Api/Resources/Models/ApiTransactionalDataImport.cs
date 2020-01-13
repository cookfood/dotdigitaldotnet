using System;
using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiTransactionalDataImport
	{
		public Guid Id
		{ get; set; }

		public ApiTransactionalDataImportStatuses Status
		{ get; set; }
	}
}
